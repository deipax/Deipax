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
    public class KeyValueFactory : ICloneDelFactory
    {
        #region ICloneDelFactory Members
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsGenericType() &&
                type.GetGenericTypeDefinition() == typeof(KeyValuePair<,>))
            {
                var args = CloneArgs.Create(type, false);

                var keyType = args.Type.GetGenericArguments()[0];
                var valueType = args.Type.GetGenericArguments()[1];

                ConstructorInfo _constructor = args
                    .Type
                    .GetConstructors()
                    .Where(x => x.GetParameters().Length == 2)
                    .FirstOrDefault();

                Expression cloneKey = keyType.CanShallowClone() ?
                    (Expression)Expression.Property(args.Source, "Key") :
                    (Expression)ExpressionHelper.GetGuardedClone(keyType, Expression.Property(args.Source, "Key"), args.Context);

                Expression cloneValue = valueType.CanShallowClone() ?
                    (Expression)Expression.Property(args.Source, "Value") :
                    (Expression)ExpressionHelper.GetGuardedClone(valueType, Expression.Property(args.Source, "Value"), args.Context);

                var newExpression = Expression.New(
                    _constructor,
                    cloneKey,
                    cloneValue);

                args.CloneExpression = Expression.Assign(args.Target, newExpression);

                return ExpressionHelper.Get<T>(args).Compile();
            }

            return null;
        }
        #endregion
    }
}