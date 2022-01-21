using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xAuthSystemSAP.Services;
using xAuthSystemSAP.Views;

namespace xAuthSystemSAP
{
    public partial class App : Application
    {
        public static string BaseAPI { get; set; }
        public App()
        {
            InitializeComponent();
            BaseAPI = "https://103.111.202.38:1818/";
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
