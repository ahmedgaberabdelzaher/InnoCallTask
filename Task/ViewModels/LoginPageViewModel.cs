using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task.ViewModels
{
    class LoginPageViewModel:BindableBase
    {
      public  DelegateCommand LoginCommand { get; set; }
      public  string[] Langauges{ get; set; }

        IPageDialogService _pageDialogService;
        INavigationService _navigationService;
        public LoginPageViewModel(IPageDialogService pageDialogService, INavigationService navigationService)
        {
            _pageDialogService = pageDialogService;
            _navigationService = navigationService;
            LoginCommand = new DelegateCommand(Login);
            Langauges =new string[]{ "English (United State)", "Arabic (Saudi Arabia)"};
        }

        private void Login()
        {
           // Xamarin.Essentials.PhoneDialer.Open("555555");
           _navigationService.NavigateAsync("Home");
        }
    }
}
