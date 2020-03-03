using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HW6.Services;
using HW6.Views;

namespace HW6
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
