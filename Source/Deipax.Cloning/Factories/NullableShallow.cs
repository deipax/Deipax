using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    public class NullableShallow : ICloneDelFactory
    {
        #region ICloneDelFactory Members
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsNullable())
            {
                var structType = typeof(T).GetGenericArguments()[0];

                if (structType.CanShallowClone())
                {
                    var args = CloneArgs.Create(type, false);
                    args.CloneExpression = Expression.Assign(args.Target, args.Source);
                    return ExpressionHelper.Get<T>(args).Compile();
                }
            }

            return null;
        }
        #endregion
    }
}