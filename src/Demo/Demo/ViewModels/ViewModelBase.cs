using System;
using Acr.UserDialogs;
using PropertyChanged;
using Xamarin.Forms;

namespace ViewModels
{
	[ImplementPropertyChanged]
	public abstract class ViewModelBase
	{
		private INavigation _navigation;

		public ViewModelBase()
		{
		}

		public INavigation Navigation
		{
			get
			{
				if (_navigation == null)
				{
					throw new Exception("Navigation is not assigned, make sure you assign it before passing the ViewModel to the BindingContext of the view.");
				}
				return _navigation;
			}
			set
			{
				_navigation = value;
			}
		}

		public bool IsBusy { get; set; }

		public void SetBusy()
		{
			IsBusy = true;
		}

		public void SetReady()
		{
			IsBusy = false;
		}

		public static IProgressDialog Busy(String text)
		{
			return UserDialogs.Instance.Loading(text, maskType: MaskType.Black);
		}
	}
}
