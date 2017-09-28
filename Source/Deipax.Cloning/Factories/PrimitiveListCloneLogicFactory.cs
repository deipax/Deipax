using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    internal class PrimitiveListCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            var type = typeof(T);

            if (type.IsGenericType() &&
                type.GetGenericTypeDefinition() == typeof(List<>) &&
                type.GetGenericArguments()[0].IsPrimitiveCloneLogic())
            {
                ConstructorInfo constructor = args
                    .Type
                    .GetConstructors()
                    .Where(x =>
                        x.GetParameters().Length == 1 &&
                        x.GetParameters().ElementAt(0).ParameterType.IsGenericType())
                    .FirstOrDefault();

                return new PrimitiveListCloneLogic()
                {
                    AddNullCheck = true,
                    CheckClonedObjects = true,
                    CloneLogicExpression = Expression.Block(
                        Expression.Assign(args.Target, Expression.New(constructor, args.Source)),
                        ExpressionHelper.Add(args.ClonedObjects, args.Source, args.Target))
                };
            }

            return null;
        }
        #endregion
    }

    public class PrimitiveListCloneLogic : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}