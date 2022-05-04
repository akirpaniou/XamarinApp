using ElenStore.Models;
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
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }
        /*
        protected override void OnAppearing()
        {
            notesList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        */
        protected override async void OnAppearing()
        {
            await App.Database.CreateTabel();
            notesList.ItemsSource = await App.Database.GetItemsAsync();
            base.OnAppearing();
        }
        // Select item
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Note selectedNote = (Note)e.SelectedItem;
            NotePage2 notePage2 = new NotePage2();
            notePage2.BindingContext = selectedNote;
            await Navigation.PushAsync(notePage2);
        }
        //Add
        private async void CreateNote(object sender, EventArgs e)
        {
            Note note = new Note();
            NotePage2 notePage2 = new NotePage2();
            notePage2.BindingContext = note;
            await Navigation.PushAsync(notePage2);
        }
    }
}