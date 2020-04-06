using MobRISv2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobRISv2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MyNavigationPage());
            MainPage = new NavigationPage(new MyNavigationPage2()) { BarBackgroundColor = Color.GreenYellow, BarTextColor = Color.Red };

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
