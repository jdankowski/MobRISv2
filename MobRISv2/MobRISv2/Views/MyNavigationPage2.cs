using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobRISv2.Views
{
    public class MyNavigationPage2 : ContentPage
    {
        public MyNavigationPage2()
        {
            this.Title = "Navigation Page 2";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "My navigation Page 2" }
                }
            };
        
            ToolbarItems.Add(new ToolbarItem("Add", "addicon.png", new Action(() => { })));

            var deleteItem = new ToolbarItem();
            deleteItem.Text = "Delete";
            deleteItem.Order = ToolbarItemOrder.Secondary;
            this.ToolbarItems.Add(deleteItem);
        
        
        }

    }
}