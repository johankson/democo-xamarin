using System;
using Autofac;

namespace Demo.Droid
{
	public static class Bootstrapper
	{
		public static void Initialize()
		{
			var builder = new ContainerBuilder();

			// Common stuff (PCL)
			Demo.Bootstrapper.Initialize(builder);

			// Android specific
			// builder.RegisterType<BarcodeScanningService>().As<IBarcodeScanningService>();

			// And build
			Resolver.SetContainer(builder.Build());
		}
	}
}
