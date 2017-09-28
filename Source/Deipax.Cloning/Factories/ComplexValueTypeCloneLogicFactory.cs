using Deipax.Cloning.Common;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class ComplexValueTypeCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            if (args.Type.IsValueType())
            {
                if (args.Type.HasDefaultConstructor() ||
                    CloneConfig<T>.Initializer != null)
                {
                    Expression createExpression = CloneConfig<T>.Initializer != null ?
                        (Expression)Expression.Invoke(Expression.Constant(CloneConfig<T>.Initializer), args.Source) :
                        (Expression)Expression.New(args.Type);

                    return new ComplexValueTypeCloneLogic()
                    {
                        AddNullCheck = false,
                        CheckClonedObjects = false,
                        CloneLogicExpression = Expression.Block(
                            Expression.Assign(args.Target, createExpression),
                            ExpressionHelper.GetMemberAssignments<T>(args.Source, args.Target, args.ClonedObjects),
                            ExpressionHelper.GetCollectionAssignment<T>(args.Source, args.Target, args.ClonedObjects))
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
    }

    public class ComplexValueTypeCloneLogic : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}