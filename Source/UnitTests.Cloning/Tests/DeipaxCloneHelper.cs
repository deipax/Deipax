using Deipax.Cloning;
using Deipax.Cloning.Common;
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
            CopyContext c = new CopyContext();
            args.Target = Cloner<T>.Get(args.Source, c);
            args.CacheCount = c.GetCount();
        }
    }
}