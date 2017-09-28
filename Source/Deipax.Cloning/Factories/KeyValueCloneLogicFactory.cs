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
    internal class KeyValueCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            if (args.Type.IsGenericType() &&
                args.Type.GetGenericTypeDefinition() == typeof(KeyValuePair<,>))
            {
                var keyType = args.Type.GetGenericArguments()[0];
                var valueType = args.Type.GetGenericArguments()[1];

                ConstructorInfo _constructor = args
                    .Type
                    .GetConstructors()
                    .Where(x => x.GetParameters().Length == 2)
                    .FirstOrDefault();

                Expression cloneKey = keyType.IsPrimitiveCloneLogic() ?
                    (Expression)Expression.Property(args.Source, "Key") :
                    (Expression)ExpressionHelper.GetCloneMethod(keyType, Expression.Property(args.Source, "Key"), args.ClonedObjects);

                Expression cloneValue = valueType.IsPrimitiveCloneLogic() ?
                    (Expression)Expression.Property(args.Source, "Value") :
                    (Expression)ExpressionHelper.GetCloneMethod(valueType, Expression.Property(args.Source, "Value"), args.ClonedObjects);

                var newExpression = Expression.New(
                    _constructor,
                    cloneKey,
                    cloneValue);

                return new KeyValueCloneLogic()
                {
                    AddNullCheck = false,
                    CheckClonedObjects = false,
                    CloneLogicExpression = Expression.Assign(args.Target, newExpression)
                };
            }

            return null;
        }
        #endregion
    }

    public class KeyValueCloneLogic : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}