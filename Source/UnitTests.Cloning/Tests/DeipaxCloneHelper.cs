using Deipax.Cloning;
using Deipax.Cloning.Common;
using Deipax.Core.Common;
using System.Collections.Generic;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning
{
    public class DeipaxCloneHelper : ICloneHelper
    {
        private DeipaxCloneHelper()
        {
        }

        public static readonly ICloneHelper Instance = new DeipaxCloneHelper();

        public void Clone<T>(CloneArguments<T> args)
        {
            args.Context = new Dictionary<object, object>(16, ReferenceEqualsComparer.Instance);
            CopyContext c = new CopyContext(args.Context);
            args.Target = Cloner<T>.Get(args.Source, c);
        }
    }
}