using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ElenStore
{
    class StartPage : ContentPage
    {
        public StartPage()
        {
            Label header = new Label() { Text = "Hi from Xamarin Forms" };
            this.Content = header;
        }
    }
}
