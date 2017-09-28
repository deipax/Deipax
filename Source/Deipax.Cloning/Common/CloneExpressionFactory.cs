using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Deipax.Cloning.Common
{
	public static class CloneExpressionFactory<T>
	{
		static CloneExpressionFactory()
		{
		}

		#region Field Members
		private static Type _type = typeof(T);
		private static ParameterExpression _source = Expression.Parameter(_type, "source");
		private static ParameterExpression _target = Expression.Variable(_type, "target");
		private static ParameterExpression _clonedObjects = Expression.Parameter(typeof(IDictionary<object, object>));
		private static Type _objectType = typeof(object);
		private static ConstantExpression _nullConstant = Expression.Constant(null, _objectType);
		private static ConstantExpression _dbNullConstant = Expression.Constant(DBNull.Value, _objectType);
		private static ConstantExpression _defaultValue = Expression.Constant(default(T), _type);
		private static LabelTarget _returnTarget = Expression.Label(_type);
		private static LabelExpression _returnLabel = Expression.Label(_returnTarget, _defaultValue);
		private static GotoExpression _returnExpression = Expression.Return(_returnTarget, _target, _type);
		#endregion

		#region Public Members
		public static ICloneExpression<T> Get()
		{
			var cloneLogic = CloneLogicFactory.Get<T>(new CloneLogicArgs()
			{
				ClonedObjects = _clonedObjects,
				Source = _source,
				Target = _target,
				Type = _type
			});
			var cloneExpression = CreateCloneExpression(cloneLogic);
			var cloneAsObjectExpression = CreateCloneAsObjectExpression(cloneExpression);

			return new CloneExpressionHelper<T>()
			{
				CloneLogic = cloneLogic,
				Clone = cloneExpression.Compile(),
				CloneAsObject = cloneAsObjectExpression.Compile()
			};
		}
		#endregion

		#region Private Members
		private static Expression<Func<T, IDictionary<object, object>, T>> CreateCloneExpression(ICloneLogic cloneLogic)
		{
			List<Expression> expressions = new List<Expression>();

			if (cloneLogic.AddNullCheck)
			{
				var isNullOrDbNullExpression = Expression.Or(
					Expression.Equal(_source, _nullConstant),
					Expression.Equal(_source, _dbNullConstant));

				expressions.Add(Expression.IfThen(isNullOrDbNullExpression, _returnExpression));
			}

			if (!_type.IsValueType() && cloneLogic.CheckClonedObjects)
			{
				var fromClonedObjects = Expression.Variable(_objectType, "fromClonedObjects");

				expressions.Add(Expression.Block(
					new[] { fromClonedObjects },
					Expression.IfThenElse(
						ExpressionHelper.TryGetValue(_clonedObjects, _source, fromClonedObjects),
						Expression.Assign(_target, Expression.Convert(fromClonedObjects, _type)),
						cloneLogic.CloneLogicExpression)));
			}
			else
			{
				expressions.Add(cloneLogic.CloneLogicExpression);
			}

			expressions.Add(_returnExpression);
			expressions.Add(_returnLabel);

			var block = Expression.Block(
				new[] { _target },
				expressions);

			return Expression.Lambda<Func<T, IDictionary<object, object>, T>>(block, _source, _clonedObjects);
		}

		private static Expression<Func<object, IDictionary<object, object>, object>> CreateCloneAsObjectExpression(
			Expression<Func<T, IDictionary<object, object>, T>> cloneItExpression)
		{
			var source = Expression.Parameter(typeof(object), "source");
			var target = Expression.Variable(typeof(object), "target");
			var dict = Expression.Parameter(typeof(IDictionary<object, object>));

			var invoke = Expression.Invoke(
				cloneItExpression,
				Expression.Convert(source, typeof(T)),
				dict);

			var assign = Expression.Assign(
				target,
				Expression.Convert(invoke, typeof(object)));

			var block = Expression.Block(
				new[] { target },
				assign,
				Expression.Label(Expression.Label(typeof(object)), target));

			return Expression.Lambda<Func<object, IDictionary<object, object>, object>>(block, source, dict);
		}
		#endregion

		#region Helpers
		class CloneExpressionHelper<X> : ICloneExpression<X>
		{
			public ICloneLogic CloneLogic { get; set; }
			public Func<X, IDictionary<object, object>, X> Clone { get; set; }
			public Func<object, IDictionary<object, object>, object> CloneAsObject { get; set; }
		}

		class CloneLogicArgs : ICloneLogicArgs
		{
			public ParameterExpression ClonedObjects { get; set; }
			public ParameterExpression Source { get; set; }
			public ParameterExpression Target { get; set; }
			public Type Type { get; set; }
		}
		#endregion
	}
}