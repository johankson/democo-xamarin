using System;
using Autofac;

namespace Demo
{
	public static class Resolver
	{
		private static IContainer _container;
		public static void SetContainer(IContainer container)
		{
			_container = container;
		}

		public static T Resolve<T>()
		{
			if (_container == null)
			{
				throw new Exception("You must set the container using SetContainer(...) before calling resolve");
			}
			return _container.Resolve<T>();
		}
	}
}
