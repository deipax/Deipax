using Deipax.Cloning.Extensions;
using Deipax.Core.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Common
{
	public static class ExpressionHelper
	{
		public static BlockExpression GetMemberAssignments<T>(
			ParameterExpression source,
			ParameterExpression target,
			ParameterExpression clonedObjects)
		{
			List<Expression> expressions = new List<Expression>();

			var type = typeof(T);

			bool cloneAll = type
				.GetCustomAttributes<CloneAllAttribute>()
				.Count() > 0;
	 
			var fields = type.GetAllFields();
			var properties = type.GetFilteredProperties(fields);

			fields.Where(x =>
				x.CanRead &&
				x.CanWrite &&
				!x.IsStatic &&
				!x.IsLiteral &&
				!x.IsBackingField &&
				(x.IsPublic || cloneAll || x.GetCustomAttributes<CloneAttribute>().Count() > 0) &&
				x.GetCustomAttributes<NoCloneAttribute>().Count() == 0)
			.ToList()
			.ForEach(x =>
			{
				var memberType = x.Type;
				var memberInfo = x.FieldInfo;

				var cloneExpression = memberType.IsPrimitiveCloneLogic() ?
					(Expression)Expression.MakeMemberAccess(source, memberInfo) :
					(Expression)GetCloneMethod(memberType, Expression.MakeMemberAccess(source, memberInfo), clonedObjects);

				expressions.Add(Expression.Assign(
					Expression.MakeMemberAccess(target, memberInfo),
					cloneExpression));
			});

			properties.Where(x =>
				x.CanRead &&
				x.CanWrite &&
				!x.IsLiteral &&
				!x.IsStatic &&
				!x.HasParameters &&
				(x.IsPublic || cloneAll || x.GetCustomAttributes<CloneAttribute>().Count() > 0) &&
				x.GetCustomAttributes<NoCloneAttribute>().Count() == 0)
			.ToList()
			.ForEach(x =>
			{
				var memberType = x.Type;
				var memberInfo = x.HasBackingField ?
					(MemberInfo)x.BackingField.FieldInfo :
					(MemberInfo)x.PropertyInfo;

				var cloneExpression = memberType.IsPrimitiveCloneLogic() ?
					(Expression)Expression.MakeMemberAccess(source, memberInfo) :
					(Expression)GetCloneMethod(memberType, Expression.MakeMemberAccess(source, memberInfo), clonedObjects);

				expressions.Add(Expression.Assign(
					Expression.MakeMemberAccess(target, memberInfo),
					cloneExpression));
			});

			return expressions.Count > 0 ?
				Expression.Block(expressions) :
				Expression.Block(Expression.Empty());
		}

		public static BlockExpression GetCollectionAssignment<T>(
			ParameterExpression source,
			ParameterExpression target,
			ParameterExpression clonedObjects)
		{
			Type collectionType = typeof(T)
				.GetInterfaces()
				.Where(x =>
					x.IsGenericType() &&
					x.GetGenericTypeDefinition() == typeof(ICollection<>))
				.FirstOrDefault();

			if (collectionType != null)
			{
				var collection = Expression.Variable(collectionType);
				var itemType = collectionType.GetGenericArguments().First();
				var enumerableType = typeof(IEnumerable<>).MakeGenericType(itemType);
				var enumeratorType = typeof(IEnumerator<>).MakeGenericType(itemType);
				var enumerator = Expression.Variable(enumeratorType);
				var getEnumeratorCall = Expression.Call(Expression.Convert(source, enumerableType), "GetEnumerator", null);
				var assignToEnumerator = Expression.Assign(enumerator, Expression.Convert(getEnumeratorCall, enumeratorType));
				var assignToCollection = Expression.Assign(collection, Expression.Convert(target, collectionType));
				var moveNextCall = Expression.Call(enumerator, typeof(IEnumerator).GetMethod("MoveNext"));
				var currentProperty = Expression.Property(enumerator, "Current");
				var breakLabel = Expression.Label();

				Expression cloneItem = itemType.IsPrimitiveCloneLogic() ?
					(Expression)currentProperty :
					GetCloneMethod(itemType, currentProperty, clonedObjects);

				LoopExpression loop = Expression.Loop(
					Expression.IfThenElse(
						Expression.NotEqual(moveNextCall, Expression.Constant(false, typeof(bool))),
						Expression.Call(collection, "Add", null, cloneItem),
						Expression.Break(breakLabel)),
					breakLabel);

				return Expression.Block(
					new[] { enumerator, collection },
					assignToEnumerator,
					assignToCollection,
					loop);
			}

			return Expression.Block(Expression.Empty());
		}

		public static MethodCallExpression TryGetValue(
			ParameterExpression clondedObjects,
			ParameterExpression source,
			ParameterExpression target)
		{
			return Expression.Call(
				clondedObjects,
				"TryGetValue",
				new Type[] { },
				source,
				target);
		}

		public static MethodCallExpression Add(
			ParameterExpression clondedObjects,
			ParameterExpression source,
			ParameterExpression target)
		{
			return Expression.Call(
				clondedObjects,
				"Add",
				new Type[] { },
				source,
				target);
		}

		public static MethodCallExpression GetCloneMethod(
			Type t,
			Expression source,
			Expression clonedObjects)
		{
			return Expression.Call(
				typeof(CloneExtensions),
				"GetClone",
				new Type[] { t },
				source,
				clonedObjects);
		}
	}
}