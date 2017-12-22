using System;
using System.Linq.Expressions;

namespace Deipax.Cloning.Common
{
    public class CloneArgs
    {
        private CloneArgs()
        {
        }

        public static CloneArgs Create(
            Type type,
            bool checkContext)
        {
            return new CloneArgs
            {
                CheckContext = checkContext,
                Context = Expression.Parameter(typeof(CopyContext), "context"),
                Type = type,
                Target = Expression.Variable(type, "target"),
                Source = Expression.Parameter(type, "source")
            };
        }

        public bool CheckContext { get; set; }
        public Expression CloneExpression { get; set; }
        public Type Type { get; set; }
        public ParameterExpression Source { get; set; }
        public ParameterExpression Target { get; set; }
        public ParameterExpression Context { get; set; }
    }
}