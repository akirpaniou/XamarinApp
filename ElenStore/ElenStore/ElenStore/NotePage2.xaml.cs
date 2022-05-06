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
    public partial class NotePage2 : ContentPage
    {
        public NotePage2()
        {
            InitializeComponent();
        }
        private async void SaveNote(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            if (!String.IsNullOrEmpty(note.NoteName))
            {
                await App.Database.SaveItemAsync(note);
            }
            await this.Navigation.PopAsync();
        }
        private async void DeleteNote(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteItemAsync(note);
            await this.Navigation.PopAsync();
        }
        private async void Cancel(object sender, EventArgs e)
        {
            await this .Navigation.PopAsync();
        }
    }
}