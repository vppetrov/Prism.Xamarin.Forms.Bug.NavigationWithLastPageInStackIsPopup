using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Main Page";
			NavigateToPage1Command = new DelegateCommand(NavigateToPage1Page);
		}

		public DelegateCommand NavigateToPage1Command { get; }
		private async void NavigateToPage1Page()
		{
			await this.NavigationService.NavigateAsync("Page1");
		}
	}
}
