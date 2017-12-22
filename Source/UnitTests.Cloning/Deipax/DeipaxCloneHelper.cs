using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.Deipax
{
    public class DeipaxCloneHelper : ICloneHelper
    {
        private DeipaxCloneHelper()
        {    
        }

        public static readonly ICloneHelper Instance = new DeipaxCloneHelper();

        public void Clone<T>(CloneArguments<T> args)
        {
            CopyContext context = new CopyContext();
            args.Target = args.Source.GetClone(context);
            args.CacheCount = context.GetCount();
        }
    }
}