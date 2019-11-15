using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class ShallowClone : ICloneDelFactory
    {
        #region ICloneDelFactory Members 
        public CloneDel<T> Create<T>()
        {
            var type = typeof(T);

            if (type.CanShallowClone())
            {
                var args = CloneArgs.Create(type, false);
                args.CloneExpression = Expression.Assign(args.Target, args.Source);
                return ExpressionHelper.Get<T>(args).Compile();
            }

            return null;
        }
        #endregion
    }
}