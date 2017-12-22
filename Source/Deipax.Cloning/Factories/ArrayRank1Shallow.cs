using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class ArrayRank1Shallow : ICloneDelFactory
    {
        #region ICloneDelFactory Members 
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsArray &&
                type.GetArrayRank() == 1 &&
                type.HasElementType)
            {
                var elementType = type.GetElementType();

                if (elementType.CanShallowClone())
                {
                    var args = CloneArgs.Create(type, true);

                    var assign = Expression.Assign(
                        args.Target,
                        Expression.NewArrayBounds(elementType, Expression.Property(args.Source, "Length")));

                    var copy = Expression.Call(
                        args.Source,
                        MethodInfos.ArrayCopy,
                        args.Target,
                        Expression.Constant(0));

                    args.CloneExpression = Expression.Block(
                        assign,
                        ExpressionHelper.RecordCopy(args.Context, args.Source, args.Target),
                        copy);

                    return ExpressionHelper.Get<T>(args).Compile();
                }
            }

            return null;
        }
        #endregion
    }
}