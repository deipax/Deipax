using System.Linq.Expressions;
using System.Reflection;

namespace Deipax.Core.Extensions
{
    public static class ExpressionExtensions
    {
        public static string ExtractMemberName<T>(this Expression<T> source)
        {
            if (source != null)
            {
                MemberExpression memberExpression = null;

                if (source.Body is UnaryExpression)
                {
                    var unaryExpression = source.Body as UnaryExpression;
                    memberExpression = unaryExpression.Operand as MemberExpression;
                }
                else if (source.Body is MemberExpression)
                {
                    memberExpression = source.Body as MemberExpression;
                }

                if (memberExpression != null &&
                    (memberExpression.Member is PropertyInfo || memberExpression.Member is FieldInfo))
                {
                    return memberExpression.Member.Name;
                }
            }

            return string.Empty;
        }
    }
}