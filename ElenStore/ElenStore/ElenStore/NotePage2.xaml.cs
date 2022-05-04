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
        private void SaveNote(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            if (!String.IsNullOrEmpty(note.NoteName))
            {
                App.Database.SaveItem(note);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteNote(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            App.Database.DeleteItem(note.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}