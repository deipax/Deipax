using Deipax.Convert.Extensions;
using Deipax.Convert.Interfaces;

namespace Deipax.Convert.Factories
{
    public class DefaultFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public IConvertResult<TFrom, TTo> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            return args
                .Add(args.LabelExpression)
                .ToResult(this);
        }
        #endregion
    }
}