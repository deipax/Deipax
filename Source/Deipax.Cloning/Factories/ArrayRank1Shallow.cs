using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    internal class ArrayRank1Shallow : ICloneDelFactory
    {
        #region Field Members
        private static MethodInfo _arrayCopy = typeof(Array).GetRuntimeMethod(
            "CopyTo",
            new Type[2] { typeof(Array), typeof(int) });
        #endregion

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
                        _arrayCopy,
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