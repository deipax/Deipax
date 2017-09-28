using Deipax.Cloning.Common;
using Deipax.Cloning.Extensions;
using Deipax.Cloning.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Common
{
	public static class TestingHelper
	{
		public static ComparisonResult ComparePerformance<T>(
			T source,
			int firstCount,
			int secondCount)
		{
			return TimingHelper.ComparePerformance(
				firstCount,
				secondCount,
				() => CloneExtensions.CloneFactory.GetClone(source),
				() => source.GetClone());
		}

		public static ComparisonResult ComparePerformance2<T>(
			T source,
			int firstCount,
			int secondCount)
		{
			var cloneExpression = CloneExpressionFactory<T>.Get();

			var dictionary = new Dictionary<object, object>();

			return TimingHelper.ComparePerformance(
				firstCount,
				secondCount,
				() => CloneFactory<T>.GetClone(source),
				() =>
				{
					dictionary.Clear();
					cloneExpression.Clone(source, dictionary);
				});
		}

		public static GrandChildClass GetRandomGrandChild()
		{
			var grandChild = new GrandChildClass()
			{
				Child_PublicField = RandGen.GenerateString(10),
				Child_Public_GetSet_AutoProp = RandGen.GenerateString(10),
				Child_Public_PGetSet_AutoProp = RandGen.GenerateString(10),
				GrandChild_PublicField = RandGen.GenerateString(10),
				GrandChild_Public_GetSet_AutoProp = RandGen.GenerateString(10),
				GrandChild_Public_PGetSet_AutoProp = RandGen.GenerateString(10),
				Parent_PublicField = RandGen.GenerateString(10),
				Parent_Public_GetSet_AutoProp = RandGen.GenerateString(10),
				Parent_Public_PGetSet_AutoProp = RandGen.GenerateString(10),
				PublicFieldCommonName = RandGen.GenerateString(10),
				PublicPropCommonName = RandGen.GenerateString(10),
			};

			ChildAbstractClass child = grandChild as ChildAbstractClass;

			child.PublicFieldCommonName = RandGen.GenerateString(10);
			child.PublicPropCommonName = RandGen.GenerateString(10);

			ParentAbstractClass parent = child as ParentAbstractClass;
			parent.PublicFieldCommonName = RandGen.GenerateString(10);
			parent.PublicPropCommonName = RandGen.GenerateString(10);

			return grandChild;
		}
	}
}