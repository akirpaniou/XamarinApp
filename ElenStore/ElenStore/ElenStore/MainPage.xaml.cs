using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElenStore
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotesPage());
        }
        private async void Button2_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }
        private async void Button3_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageFiles());
        }

        protected override void OnAppearing()
        {

            

        }
    }
}
