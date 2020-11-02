using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SourceScout.Services;
using SourceScout.Views;
using MonkeyCache.FileStore;

namespace SourceScout
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        public App()
        {
            Barrel.ApplicationId = "sourcescout";

            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("[YOUR LICENSE HERE]");

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
