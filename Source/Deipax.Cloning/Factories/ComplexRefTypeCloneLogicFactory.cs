using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
	internal class ComplexRefTypeCloneLogicFactory : ICloneLogicFactory
	{
		#region ICloneLogicFactory Members
		public ICloneLogic Get<T>(ICloneLogicArgs args)
		{
			if (args.Type.IsClass() &&
				!args.Type.IsAnonymous())
			{
				if (args.Type.HasDefaultConstructor() ||
					CloneConfig<T>.Initializer != null)
				{
					return new ComplexRefTypeCloneLogic()
					{
						AddNullCheck = true,
						CheckClonedObjects = true,
						CloneLogicExpression = Expression.IfThenElse(
							Expression.TypeEqual(args.Source, args.Type),
							GetAreSameTypeBlock<T>(args, CloneConfig<T>.Initializer),
							GetAreDiffTypeBlock(args))
					};
				}
				else
				{
					return ExceptionCloneLogic.Create(string.Format(
						"({0}) has no default constructor or registered initializer.",
						 args.Type.FullName));
				}
			}

			return null;
		}
		#endregion

		#region Private Members
		private static Expression GetAreSameTypeBlock<T>(
			 ICloneLogicArgs args,
			Func<T, T> initializer = null)
		{
			Expression createExpression = initializer != null ?
				(Expression)Expression.Invoke(Expression.Constant(initializer), args.Source) :
				(Expression)Expression.New(args.Type);

			return Expression.Block(
				Expression.Assign(args.Target, createExpression),
				ExpressionHelper.Add(args.ClonedObjects, args.Source, args.Target),
				ExpressionHelper.GetMemberAssignments<T>(args.Source, args.Target, args.ClonedObjects),
				ExpressionHelper.GetCollectionAssignment<T>(args.Source, args.Target, args.ClonedObjects));
		}

		private static Expression GetAreDiffTypeBlock(
			ICloneLogicArgs args)
		{
			var callDynamicClone = Expression.Call(
				typeof(CloneExpressionCache),
				"GetCloneDynamic",
				new Type[] { },
				args.Source,
				args.ClonedObjects);

			return Expression.Assign(
				args.Target,
				Expression.Convert(callDynamicClone, args.Type));;
		}
		#endregion
	}

	public class ComplexRefTypeCloneLogic : ICloneLogic
	{
		#region ICloneLogicMembers
		public bool AddNullCheck { get; set; }
		public bool CheckClonedObjects { get; set; }
		public Expression CloneLogicExpression { get; set; }
		#endregion
	}
}