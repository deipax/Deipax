using Deipax.Convert.Interfaces;
using System.Linq.Expressions;

namespace Deipax.Convert.Factories
{
    public class DefaultFactory : IConvertFactory
    {
        #region IConvertFactory Members
        public Expression<ConvertDelegate<TFrom, TTo>> Create<TFrom, TTo>(
            IExpArgs<TFrom, TTo> args)
        {
            args.Add(args.LabelExpression);
            return args.Create();
        }
        #endregion
    }
}