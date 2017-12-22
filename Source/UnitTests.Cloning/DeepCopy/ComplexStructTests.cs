using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Cloning.BaseTests;

namespace UnitTests.Cloning.DeepCopy
{
    // DeepCopy Note:
    // This throws a runtime error.  It is determined to
    // need tracking and the IL code tries to push the address
    // on the stack. This code also places the struct in the 
    // copy context .. or attempts to.

    // Even for a Struct that does not "NeedTracking",
    // the ArrayCopy logic stores the struct in the CopyContext
    // and fetches it.  Since the CopyContext works on object, 
    // the struct is boxed and unboxed here ... this causes the
    // struct to be copied back and forth from the stack/heap.

    [TestClass]
    [Ignore]
    public class ComplexStructTests : ComplexStructBase
    {
        public ComplexStructTests() : base(DeepCopyCloneHelper.Instance)
        {
        }
    }
}