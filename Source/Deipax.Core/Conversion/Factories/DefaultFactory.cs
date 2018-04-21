using Deipax.Core.Interfaces;

namespace Deipax.Core.Conversion.Factories
{
    public class DefaultFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public Convert<TFrom, TTo> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            args.Add(args.LabelExpression);
            return args.GetConvertResult();
        }
        #endregion
    }
}