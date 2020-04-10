using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobRISv2.Views
{
    public class MyCarouselPage : CarouselPage
    {
        public MyCarouselPage()
        {
            Children.Add(new MyContentPage());
            Children.Add(new MyContentPage2());
        }
    }
}