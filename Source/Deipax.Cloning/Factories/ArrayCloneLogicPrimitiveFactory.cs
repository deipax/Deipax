using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    internal class ArrayCloneLogicPrimitiveFactory : ICloneLogicFactory
    {
        #region Field Members
        private static MethodInfo _copyTo = typeof(Array).GetRuntimeMethod(
            "CopyTo",
            new Type[2] { typeof(Array), typeof(int) });
        #endregion

        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            if (args.Type.IsArray)
            {
                var elementType = args.Type.GetElementType();

                if (elementType.IsPrimitiveCloneLogic())
                {
                    var assign = Expression.Assign(
                        args.Target,
                        Expression.NewArrayBounds(elementType, Expression.Property(args.Source, "Length")));

                    var copy = Expression.Call(
                        args.Source,
                        _copyTo,
                        args.Target,
                        Expression.Constant(0));

                    return new ArrayCloneLogicPrimitive()
                    {
                        AddNullCheck = true,
                        CheckClonedObjects = true,
                        CloneLogicExpression = Expression.Block(
                            assign,
                            ExpressionHelper.Add(args.ClonedObjects, args.Source, args.Target),
                            copy)
                    };
                }
            }

            return null;
        }
        #endregion
    }

    public class ArrayCloneLogicPrimitive : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}