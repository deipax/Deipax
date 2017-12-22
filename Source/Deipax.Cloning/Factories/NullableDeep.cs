using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    public class NullableDeep : ICloneDelFactory
    {
        #region ICloneDelFactory Members
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsNullable())
            {
                var structType = typeof(T).GetGenericArguments()[0];

                if (!structType.CanShallowClone())
                {
                    var args = CloneArgs.Create(type, false);
                    var sourceProperty = Expression.Property(args.Source, "Value");

                    var cloneCall = ExpressionHelper.GetUnGuardedClone(structType, sourceProperty, args.Context);
                    var newNullable = Expression.New(typeof(T).GetConstructor(new[] { structType }), cloneCall);
                    args.CloneExpression = Expression.Assign(args.Target, newNullable);
                    return ExpressionHelper.Get<T>(args).Compile();
                }
            }

            return null;
        }
        #endregion
    }
}