using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Task.ViewModels;
using Task.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task
{
    public partial class App : PrismApplication
    {
        public App() : this(null)
        {
            // _data = dat;
        }
        public App(IPlatformInitializer initializer) : base(initializer)
        {
            //  _data = data;
        }

        protected override async void OnInitialized()
        {

            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/LoginPage").ConfigureAwait(false);
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<Home, HomeViewModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
