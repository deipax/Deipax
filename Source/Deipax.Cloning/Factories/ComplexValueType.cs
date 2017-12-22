using Deipax.Cloning.Common;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class ComplexValueType : ICloneDelFactory
    {
        #region ICloneDelFactory Members 
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsValueType())
            {
                if (type.HasDefaultConstructor())
                {
                    var args = CloneArgs.Create(type, false);

                    Expression createExpression = CloneConfig<T>.Initializer != null ?
                        (Expression)Expression.Invoke(Expression.Constant(CloneConfig<T>.Initializer), args.Source) :
                        (Expression)Expression.New(args.Type);

                    args.CloneExpression = Expression.Block(
                        Expression.Assign(args.Target, createExpression),
                        ExpressionHelper.GetMemberAssignments<T>(args.Source, args.Target, args.Context),
                        ExpressionHelper.GetCollectionAssignment<T>(args.Source, args.Target, args.Context));

                    return ExpressionHelper.Get<T>(args).Compile();
                }
                else
                {
                    return (source, context) =>
                    {
                        throw new ArgumentException($"({type}) has no default constructor or registered initializer.");
                    };
                }
            }

            return null;
        }
        #endregion
    }
}