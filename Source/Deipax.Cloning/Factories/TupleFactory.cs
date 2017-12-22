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
    internal class TupleFactory : ICloneDelFactory
    {
        #region ICloneDelFactory Members
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsGenericType() &&
                (type.GetGenericTypeDefinition() == typeof(Tuple<>) ||
                 type.GetGenericTypeDefinition() == typeof(Tuple<,>) ||
                 type.GetGenericTypeDefinition() == typeof(Tuple<,,>) ||
                 type.GetGenericTypeDefinition() == typeof(Tuple<,,,>) ||
                 type.GetGenericTypeDefinition() == typeof(Tuple<,,,,>) ||
                 type.GetGenericTypeDefinition() == typeof(Tuple<,,,,,>) ||
                 type.GetGenericTypeDefinition() == typeof(Tuple<,,,,,,>) ||
                 type.GetGenericTypeDefinition() == typeof(Tuple<,,,,,,,>)))
            {
                var args = CloneArgs.Create(type, true);
        
                Type[] genericTypes = typeof(T).GetGenericArguments();
                var cloneItems = new Expression[genericTypes.Length];

                // Can't loop to 8, because instead of Item8 the last one is called Rest
                var loopCount = Math.Min(genericTypes.Length, 7);
                for (int i = 0; i < loopCount; i++)
                {
                    string itemName = "Item" + (i + 1).ToString(CultureInfo.InvariantCulture);

                    var itemType = genericTypes[i];

                    cloneItems[i] = itemType.CanShallowClone() ?
                        (Expression)Expression.Property(args.Source, itemName) :
                        (Expression)ExpressionHelper.GetGuardedClone(itemType, Expression.Property(args.Source, itemName), args.Context);
                }

                // add Rest expression if it's necessary
                if (genericTypes.Length == 8)
                {
                    string itemName = "Rest";

                    var itemType = genericTypes[7];

                    cloneItems[7] = itemType.CanShallowClone() ?
                        (Expression)Expression.Property(args.Source, itemName) :
                        (Expression)ExpressionHelper.GetGuardedClone(itemType, Expression.Property(args.Source, itemName), args.Context);
                }

                ConstructorInfo constructor = args.Type.GetConstructors()[0];
                var newExpression = Expression.New(constructor, cloneItems);

                args.CloneExpression = Expression.Block(
                    Expression.Assign(args.Target, newExpression),
                    ExpressionHelper.RecordCopy(args.Context, args.Source, args.Target));

                return ExpressionHelper.Get<T>(args).Compile();
            }

            return null;
        }
        #endregion
    }
}