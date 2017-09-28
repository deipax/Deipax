using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    internal class TupleCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            if (args.Type.IsGenericType() &&
                (args.Type.GetGenericTypeDefinition() == typeof(Tuple<>) ||
                args.Type.GetGenericTypeDefinition() == typeof(Tuple<,>) ||
                args.Type.GetGenericTypeDefinition() == typeof(Tuple<,,>) ||
                args.Type.GetGenericTypeDefinition() == typeof(Tuple<,,,>) ||
                args.Type.GetGenericTypeDefinition() == typeof(Tuple<,,,,>) ||
                args.Type.GetGenericTypeDefinition() == typeof(Tuple<,,,,,>) ||
                args.Type.GetGenericTypeDefinition() == typeof(Tuple<,,,,,,>) ||
                args.Type.GetGenericTypeDefinition() == typeof(Tuple<,,,,,,,>)))
            {
                ConstructorInfo constructor = args.Type.GetConstructors()[0];
                Type[] genericTypes = typeof(T).GetGenericArguments();

                var cloneItems = new Expression[genericTypes.Length];

                // Can't loop to 8, because instead of Item8 the last one is called Rest
                var loopCount = Math.Min(genericTypes.Length, 7);
                for (int i = 0; i < loopCount; i++)
                {
                    string itemName = "Item" + (i + 1).ToString(CultureInfo.InvariantCulture);

                    var itemType = genericTypes[i];

                    cloneItems[i] = itemType.IsPrimitiveCloneLogic() ?
                        (Expression)Expression.Property(args.Source, itemName) :
                        (Expression)ExpressionHelper.GetCloneMethod(itemType, Expression.Property(args.Source, itemName), args.ClonedObjects);
                }

                // add Rest expression if it's necessary
                if (genericTypes.Length == 8)
                {
                    string itemName = "Rest";

                    var itemType = genericTypes[7];

                    cloneItems[7] = itemType.IsPrimitiveCloneLogic() ?
                        (Expression)Expression.Property(args.Source, itemName) :
                        (Expression)ExpressionHelper.GetCloneMethod(itemType, Expression.Property(args.Source, itemName), args.ClonedObjects);
                }

                var newExpression = Expression.New(
                    constructor,
                    cloneItems);

                return new TupleCloneLogic()
                {
                    AddNullCheck = true,
                    CheckClonedObjects = true,
                    CloneLogicExpression = Expression.Block(
                        Expression.Assign(args.Target, newExpression),
                        ExpressionHelper.Add(args.ClonedObjects, args.Source, args.Target))
                };
            }

            return null;
        }
        #endregion
    }

    public class TupleCloneLogic : ICloneLogic
    {
        #region ICloneLogicMembers
        public bool AddNullCheck { get; set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; set; }
        #endregion
    }
}