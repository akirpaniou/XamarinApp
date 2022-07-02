using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElenStore
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageFiles : ContentPage
    {
        public PageFiles()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var pickResult = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Pick an Image"
            });
            if(pickResult != null)
            {
                var stream = await pickResult.OpenReadAsync();
                resultImage.Source = ImageSource.FromStream(() => stream);
            }
        }
        async void Button1_Clicked(System.Object sender, System.EventArgs e)
        {
            var pickResult = await FilePicker.PickMultipleAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Pick image(s)"
            });
            if(pickResult != null)
            {
                var imageList = new List<ImageSource>();
                foreach(var image in pickResult)
                {
                    var stream = await image.OpenReadAsync();
                    imageList.Add(ImageSource.FromStream(() => stream));
                }
                CollectionView.ItemsSource = imageList;
            }
        }
    }
}