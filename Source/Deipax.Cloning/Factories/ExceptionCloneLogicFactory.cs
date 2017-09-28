using Deipax.Cloning.Interfaces;
using System;
using System.Linq.Expressions;

namespace Deipax.Cloning.Factories
{
    internal class ExceptionCloneLogicFactory : ICloneLogicFactory
    {
        #region ICloneLogicFactory Members
        public ICloneLogic Get<T>(ICloneLogicArgs args)
        {
            return ExceptionCloneLogic.Create(string.Format("({0}) is unsupported.", args.Type.FullName));
        }
        #endregion
    }

    public class ExceptionCloneLogic : ICloneLogic
    {
        private ExceptionCloneLogic()
        {
        }

        #region ICloneLogic Members
        public bool AddNullCheck { get; private set; }
        public bool CheckClonedObjects { get; set; }
        public Expression CloneLogicExpression { get; private set; }
        #endregion

        #region Public Members
        public static ICloneLogic Create(string message)
        {
            var newException = Expression.New(
               typeof(ArgumentException).GetConstructor(new[] { typeof(string) }),
               Expression.Constant(message, typeof(string)));

            return new ExceptionCloneLogic()
            {
                AddNullCheck = false,
                CheckClonedObjects = false,
                CloneLogicExpression = Expression.Throw(newException)
            };
        }
        #endregion
    }
}