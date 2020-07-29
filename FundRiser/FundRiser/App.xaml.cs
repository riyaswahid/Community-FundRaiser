using FundRiser.Abstractions;
using FundRiser.Services;
using FundRiser.Helpers;
using Xamarin.Forms;

namespace FundRiser
{
    public partial class App : Application
    {
        public static ICloudService CloudService { get; set; }

        public App()
        {
            ServiceLocator.Instance.Add<ICloudService, AzureCloudService>();
            MainPage = new NavigationPage(new Pages.EntryPage());
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
