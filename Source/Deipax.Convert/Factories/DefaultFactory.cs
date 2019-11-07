using Deipax.Convert.Interfaces;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class DefaultFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public Expression<Convert<TFrom, TTo>> Get<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            args.Add(args.LabelExpression);
            return args.Get();
        }
        #endregion
    }
}