using DeepCopy;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    public class DeepCopyCloneHelper : ICloneHelper
    {
        private DeepCopyCloneHelper()
        {
        }

        public static readonly ICloneHelper Instance = new DeepCopyCloneHelper();

        public void Clone<T>(CloneArguments<T> args)
        {
            args.Target = DeepCopier.Copy(args.Source);
        }
    }
}