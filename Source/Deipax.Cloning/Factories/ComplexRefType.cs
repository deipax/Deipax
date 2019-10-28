using Deipax.Cloning.Common;
using Deipax.Cloning.Interfaces;
using Deipax.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class ComplexRefType : ICloneDelFactory
    {
        #region ICloneDelFactory
        public CloneDel<T> Get<T>()
        {
            var type = typeof(T);

            if (type.IsClass() &&
                !type.IsArray &&
                !type.IsAnonymous())
            {
                if (type.HasDefaultConstructor() ||
                    CloneCmdConfig<T>.Initializer != null)
                {
                    var args = CloneArgs.Create(type, true);

                    Expression createExpression = CloneCmdConfig<T>.Initializer != null ?
                        (Expression)Expression.Invoke(Expression.Constant(CloneCmdConfig<T>.Initializer), args.Source) :
                        (Expression)Expression.New(args.Type);

                    List<Expression> expressions = new List<Expression>()
                    {
                        Expression.Assign(args.Target, createExpression),
                        ExpressionHelper.RecordCopy(args.Context, args.Source, args.Target),
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