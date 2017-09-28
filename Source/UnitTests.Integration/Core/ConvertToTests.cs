using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integration.Core
{
	[TestClass]
	public class ConvertToTests
	{
		[TestMethod]
		public void ConvertToTests_Test1()
		{
			/*
			var tmp = ConvertTo<MyEnum?>.From(null);
			Assert.IsTrue(!tmp.HasValue);

			tmp = ConvertTo<MyEnum?>.From(1);
			Assert.IsTrue(tmp.HasValue);
			*/

			/*
			var tmp = ConvertTo<int?>.From(null);
			Assert.IsTrue(!tmp.HasValue);

			tmp = ConvertTo<int?>.From(1);
			Assert.IsTrue(tmp.HasValue);
			*/

			/*
			GrandChildClass instance = new GrandChildClass();

			var tmp = ConvertTo<GrandChildClass>.From(1);
			var defaultValue = default(GrandChildClass);
			Assert.IsTrue(defaultValue == tmp);

			tmp = ConvertTo<GrandChildClass>.From(instance);

			Assert.IsTrue(tmp == instance);*/


		}
	}
}