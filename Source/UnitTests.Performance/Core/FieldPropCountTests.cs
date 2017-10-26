using Deipax.Core.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.Common;

namespace UnitTests.Performance.Core
{
    [TestClass]
    public class FieldPropCountTests
    {
        [TestMethod]
        public void FieldPropCountTests_FetchFields()
        {
            Type t = typeof(GrandChildClass);

            var result = TimingHelper.GetPerformance(
                100000,
                () => t.GetAllFields());

            Console.WriteLine(result.GetReport());
        }

        [TestMethod]
        public void FieldPropCountTests_FetchAllProperties()
        {
            Type t = typeof(GrandChildClass);
            var fields = t.GetAllFields();

            var result = TimingHelper.GetPerformance(
                100000,
                () => t.GetAllProperties(fields));

            Console.WriteLine(result.GetReport());
        }

        [TestMethod]
        public void FieldPropCountTests_FetchFilteredProperties()
        {
            Type t = typeof(GrandChildClass);
            var fields = t.GetAllFields();

            var result = TimingHelper.GetPerformance(
                100000,
                () => t.GetAllProperties(fields));

            Console.WriteLine(result.GetReport());
        }
    }
}