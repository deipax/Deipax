using Deipax.Cloning.Factories;
using Deipax.Cloning.Interfaces;
using System.Collections.Generic;

namespace Deipax.Cloning.Common
{
	public static class CloneLogicFactory
	{
		static CloneLogicFactory()
		{
			UserFactories = new List<ICloneLogicFactory>();
			DefaultFactories = new List<ICloneLogicFactory>();

			DefaultFactories.Add(new KeyValueCloneLogicFactory());
			DefaultFactories.Add(new TupleCloneLogicFactory());
			DefaultFactories.Add(new PrimitiveListCloneLogicFactory());
			DefaultFactories.Add(new PrimitiveCloneLogicFactory());
			DefaultFactories.Add(new NullableCloneLogicFactory());
			DefaultFactories.Add(new ArrayCloneLogicPrimitiveFactory());
			DefaultFactories.Add(new ArrayCloneLogicFactory());
			DefaultFactories.Add(new ComplexRefTypeCloneLogicFactory());
			DefaultFactories.Add(new ComplexValueTypeCloneLogicFactory());
			DefaultFactories.Add(new AbstractCloneLogicFactory());
			DefaultFactories.Add(new ExceptionCloneLogicFactory());
		}

		public static List<ICloneLogicFactory> UserFactories { get; private set; }
		internal static List<ICloneLogicFactory> DefaultFactories { get; private set; }

		internal static ICloneLogic Get<T>(ICloneLogicArgs args)
		{
			var cloneLogic = CloneConfig<T>.UserCloneLogic ?? CloneConfig<T>.DefaultCloneLogic;

			if (cloneLogic == null)
			{
				foreach (var factory in UserFactories)
				{
					cloneLogic = factory.Get<T>(args);

					if (cloneLogic != null)
					{
						break;
					}
				}
			}

			if (cloneLogic == null)
			{
				foreach (var factory in DefaultFactories)
				{
					cloneLogic = factory.Get<T>(args);

					if (cloneLogic != null)
					{
						break;
					}
				}
			}

			return cloneLogic;
		}
	}
}