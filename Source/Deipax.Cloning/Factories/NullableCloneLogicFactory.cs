using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class NullableCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            if (args.Type.IsNullable())
            {
                var structType = typeof(T).GetGenericArguments()[0];
                var sourceProperty = Expression.Property(args.Source, "Value");

                var cloneCall = structType.IsPrimitiveCloneLogic() ?
                    (Expression)sourceProperty :
                    (Expression)ExpressionHelper.GetCloneMethod(structType, sourceProperty, args.ClonedObjects);

                var newNullable = Expression.New(typeof(T).GetConstructor(new[] { structType }), cloneCall);

                return new NullableCloneLogic()
                {
                    AddNullCheck = false,
                    CheckClonedObjects = false,
                    CloneLogicExpression = Expression.IfThenElse(
                        Expression.Equal(
                            Expression.Property(args.Source, "HasValue"),
                            Expression.Constant(false)),
                        Expression.Assign(args.Target, Expression.Constant(null, args.Type)),
                        Expression.Assign(args.Target, newNullable))
                };
            }

            return null;
        }
        #endregion
    }

    public class NullableCloneLogic : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}