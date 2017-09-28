using Deipax.Cloning.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Integration.Cloning
{
	[TestClass]
	public class CloneExtensionsTests
	{
		[TestMethod]
		public void CloneExtensionsTests_AsObject()
		{
			Helper1 source = new Helper1()
			{
				PropEight = RandGen.GenerateInt(),
				PropFive = RandGen.GenerateInt(),
				PropFour = RandGen.GenerateInt(),
			};

			object sourceAsObject = source;

			var cloned1 = sourceAsObject.GetClone();		
			var cloned2 = source.GetClone();

			Assert.IsInstanceOfType(cloned1, typeof(Helper1));
			Assert.IsInstanceOfType(cloned2, typeof(Helper1));
		}
	}
}