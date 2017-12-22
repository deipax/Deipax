using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Cloning.Factories
{
    internal class ListShallow : ICloneDelFactory
    {
        #region ICloneDelFactory Members 
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsGenericType() &&
                type.GetGenericTypeDefinition() == typeof(List<>) &&
                type.GetGenericArguments()[0].CanShallowClone())
            {
                var args = CloneArgs.Create(type, true);

                ConstructorInfo constructor = args
                    .Type
                    .GetConstructors()
                    .Where(x =>
                        x.GetParameters().Length == 1 &&
                        x.GetParameters().ElementAt(0).ParameterType.IsGenericType())
                    .FirstOrDefault();

                args.CloneExpression = Expression.Block(
                    Expression.Assign(args.Target, Expression.New(constructor, args.Source)),
                    ExpressionHelper.RecordCopy(args.Context, args.Source, args.Target));

                return ExpressionHelper.Get<T>(args).Compile();
            }

            return null;
        }
        #endregion
    }
}