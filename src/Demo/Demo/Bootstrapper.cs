using System;
using System.Reflection;
using Autofac;

namespace Demo
{
	public static class Bootstrapper
	{
		public static void Initialize(ContainerBuilder builder)
		{
			// Views
			var asm = typeof(App).GetTypeInfo().Assembly;
			builder.RegisterAssemblyTypes(asm)
				   .Where(t => t.Name.EndsWith("View", StringComparison.Ordinal));

			// ViewModels
			builder.RegisterAssemblyTypes(asm)
			       .Where(t => t.Name.EndsWith("ViewModel", StringComparison.Ordinal));
		}
	}
}
