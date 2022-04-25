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

        protected override void OnAppearing()
        {
            StackLayout layout = new StackLayout();

            Label label1 = new Label();
            Label label2 = new Label();

            label1.Text = "CodeLearn";
            label1.TextColor = Color.Red;
            label1.FontSize = 30;
            label1.FontAttributes = FontAttributes.Bold;
            label1.HorizontalOptions = LayoutOptions.Center;
            label1.BackgroundColor = Color.Blue;
            

            label2.Text = "Learn a programming language";
            label2.TextColor = Color.Green;
            label2.FontSize = 20;
            label2.FontAttributes = FontAttributes.Bold;
            label2.HorizontalOptions = LayoutOptions.Center;


            layout.Children.Add(label1);
            layout.Children.Add(label2);

            //Image image1 = new Image();
            //image1.Source = ImageSource.FromResource("ElenStore.langMainPge.jpg");

            Content = layout;

            Frame imageFrame = new Frame
            {
                Content = new StackLayout
                {

                }
            };

        }

    }
}
