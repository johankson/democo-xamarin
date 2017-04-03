using System;
using Autofac;

namespace Demo.iOS
{
	public static class Bootstrapper
	{
		public static void Initialize()
		{
			var builder = new ContainerBuilder();

			// Common stuff (PCL)
			Demo.Bootstrapper.Initialize(builder);

			// iOS specific
			// builder.RegisterType<BarcodeScanningService>().As<IBarcodeScanningService>();

			// And build
			Resolver.SetContainer(builder.Build());
		}
	}
}
