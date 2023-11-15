using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
	public class Page2ViewModel : ViewModelBase
	{
		public Page2ViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Page 2";
			NavigateToMainPageCommand = new DelegateCommand(NavigateToMainPage);
		}

		public DelegateCommand NavigateToMainPageCommand { get; }
		private async void NavigateToMainPage()
		{
			await this.NavigationService.NavigateAsync("../../");
		}
	}
}
