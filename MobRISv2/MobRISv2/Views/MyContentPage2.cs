using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobRISv2.Views
{
    public class MyContentPage2 : ContentPage
    {
        public MyContentPage2()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "My Content Page 2!", FontSize=28 }
                }
            };
        }
    }
}