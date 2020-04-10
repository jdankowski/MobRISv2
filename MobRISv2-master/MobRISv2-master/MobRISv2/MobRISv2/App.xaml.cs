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
            //MainPage = new NavigationPage(new MyNavigationPage2()) { BarBackgroundColor = Color.GreenYellow, BarTextColor = Color.Red };
            //MainPage = new TabbedPage();

            //TabbedPage tabbedPage = new TabbedPage();
            //tabbedPage.Children.Add(new MyContentPage() { Title="My Contenet Page 1 "});
            //tabbedPage.Children.Add(new MyContentPage2());

            //MainPage = tabbedPage;

            //MainPage = new MyCarouselPage();

            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new MyContentPage());
            carouselPage.Children.Add(new MyContentPage2());

            MainPage = carouselPage;


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
