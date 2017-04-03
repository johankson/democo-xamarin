using System;
using System.Collections.Generic;
using ViewModels;
using Xamarin.Forms;

namespace Views
{
	public partial class MainView : ContentPage
	{
		public MainView(MainViewModel vm)
		{
			InitializeComponent();
			vm.Navigation = Navigation;
			BindingContext = vm;
		}
	}
}
