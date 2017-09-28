using Deipax.Cloning.Common;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class ArrayCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            if (args.Type.IsArray)
            {
                var itemType = args
                    .Type
                    .GetInterfaces()
                    .First(x =>
                        x.IsGenericType() &&
                        x.GetGenericTypeDefinition() == typeof(ICollection<>))
                    .GetGenericArguments()
                    .First();

                var counter = Expression.Variable(typeof(int));
                var breakLabel = Expression.Label();
                var arrayLength = Expression.Property(args.Source, "Length");
                var newArray = Expression.NewArrayBounds(itemType, Expression.Property(args.Source, "Length"));

                var loop = Expression.Loop(
                    Expression.IfThenElse(
                        Expression.LessThan(counter, arrayLength),
                        Expression.Block(
                            Expression.Assign(
                                Expression.ArrayAccess(args.Target, counter),
                                ExpressionHelper.GetCloneMethod(itemType, Expression.ArrayAccess(args.Source, counter), args.ClonedObjects)),
                            Expression.AddAssign(counter, Expression.Constant(1))),
                        Expression.Break(breakLabel)),
                    breakLabel);

                return new ArrayCloneLogic()
                {
                    AddNullCheck = true,
                    CheckClonedObjects = true,
                    CloneLogicExpression = Expression.Block(
                        new[] { counter },
                        Expression.Assign(counter, Expression.Constant(0)),
                        Expression.Assign(args.Target, newArray),
                        ExpressionHelper.Add(args.ClonedObjects, args.Source, args.Target),
                        loop)
                };
            }

            return null;
        }
        #endregion
    }

    public class ArrayCloneLogic : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}