using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElenStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoursePage : ContentPage
    {
        public CoursePage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            await App.Database.CreateTable();
            courseList.ItemsSource = await App.Database.GetItemsAsync();
            base.OnAppearing();
        }
    }
}