using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HW6.ViewModels
{
    public class ActivityPageOneViewModel : BaseViewModel
    {
        public ActivityPageOneViewModel()
        {
            Title = "Activity Page One";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}