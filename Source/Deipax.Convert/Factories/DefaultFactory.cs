using Deipax.Convert.Common;
using Deipax.Convert.Concretes;
using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;

namespace Deipax.Convert.Factories
{
    public class DefaultFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>()
        {
            var expBuilder = new ExpBuilder<TFrom, TTo>();

            return expBuilder
                .Add(expBuilder.LabelExpression)
                .ToResult(this);
        }
        #endregion
    }
}