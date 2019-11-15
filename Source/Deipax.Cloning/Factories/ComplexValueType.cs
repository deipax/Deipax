using Deipax.Cloning.Common;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class ComplexValueType : ICloneDelFactory
    {
        #region ICloneDelFactory Members 
        public CloneDel<T> Create<T>()
        {
            var type = typeof(T);

            if (type.IsValueType())
            {
                if (type.HasDefaultConstructor())
                {
                    var args = CloneArgs.Create(type, false);

                    Expression createExpression = CloneConfig<T>.Initializer != null ?
                        Expression.Invoke(Expression.Constant(CloneConfig<T>.Initializer), args.Source) :
                        (Expression)Expression.New(args.Type);

                    List<Expression> expressions = new List<Expression>()
                    {
                        Expression.Assign(args.Target, createExpression),
                        ExpressionHelper.GetMemberAssignments<T>(args.Source, args.Target, args.Context),
                        ExpressionHelper.GetCollectionAssignment<T>(args.Source, args.Target, args.Context)
                    };

                    args.CloneExpression = Expression.Block(expressions.Where(x => x != null));

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