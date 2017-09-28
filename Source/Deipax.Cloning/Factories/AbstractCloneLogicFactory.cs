using Deipax.Cloning.Common;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class AbstractCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            if (args.Type.IsAbstract() || args.Type.IsInterface())
            {
                var callDynamicClone = Expression.Call(
                    typeof(CloneExpressionCache),
                    "GetCloneDynamic",
                    new Type[] { },
                    args.Source,
                    args.ClonedObjects);

                return new AbstractCloneLogic
                {
                    AddNullCheck = true,
                    CheckClonedObjects = true,
                    CloneLogicExpression = Expression.Assign(
                        args.Target,
                        Expression.Convert(callDynamicClone, args.Type))
                };
            }

            return null;
        }
        #endregion
    }

    public class AbstractCloneLogic : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}