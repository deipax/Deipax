using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class PrimitiveCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            if (args.Type.IsPrimitiveCloneLogic())
            {
                return new PrimitiveCloneLogic
                {
                    AddNullCheck = false,
                    CheckClonedObjects = false,
                    CloneLogicExpression = Expression.Assign(
                        args.Target,
                        args.Source)
                };
            }

            return null;
        }
        #endregion
    }

    public class PrimitiveCloneLogic : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}