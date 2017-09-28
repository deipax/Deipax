using System;
using Deipax.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Common;

namespace Performance.Core
{
	[TestClass]
	public class ObjectActivatorTests
	{
		[TestMethod]
		public void ObjectActivatorTests_Test1()
		{
			Type t = typeof(GrandChildClass);

			var initializer = ObjectActivator.GetActivator(t).Create;

			var result = TimingHelper.ComparePerformance(
				10000000,
				10000000,
				() => Activator.CreateInstance(t),
				() => initializer());

			Console.WriteLine(result.GetReport());
		}
	}
}