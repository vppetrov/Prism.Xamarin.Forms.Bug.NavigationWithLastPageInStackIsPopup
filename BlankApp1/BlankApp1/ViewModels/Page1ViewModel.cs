using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
	public class Page1ViewModel : ViewModelBase
	{
		public Page1ViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Page 1";
			NavigateToPage2Command = new DelegateCommand(NavigateToPage2Page);
			NavigateToPopup2Command = new DelegateCommand(NavigateToPopup2Page);
		}

		public DelegateCommand NavigateToPage2Command { get; }
		private async void NavigateToPage2Page()
		{
			await this.NavigationService.NavigateAsync("Page2");
		}

		public DelegateCommand NavigateToPopup2Command { get; }
		private async void NavigateToPopup2Page()
		{
			await this.NavigationService.NavigateAsync("Popup2");
		}
	}
}
