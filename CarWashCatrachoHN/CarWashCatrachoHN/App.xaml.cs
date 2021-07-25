using CarWashCatrachoHN.Services;
using CarWashCatrachoHN.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarWashCatrachoHN
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new AppShell());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
