using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutWithCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StackLayout stackLayout01 = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {
                        Text = "This is has been done through code!",
                        HorizontalOptions = LayoutOptions.Start
                    }
                }
            };

            stackLayout01.Children.Add(new Label
            {
                Text = "This is also done done through code!",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Green,
                FontAttributes = FontAttributes.Italic,
                FontSize = 22,
                TextDecorations = TextDecorations.Underline,
                BackgroundColor = Color.Yellow
            });


            stackLayout01.Children.Add(new Label
            {
                TextColor = Color.Gray,
                //FontSize = 20,
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span {Text = "This has stuff in it "},
                        new Span {Text = "words that have emphasis!", FontAttributes = FontAttributes.Bold, TextDecorations = TextDecorations.Underline/*, FontSize = 20*/}
                    }
                }
            });

            this.Content = stackLayout01;

            switch (Device.RuntimePlatform)

            {

                case Device.iOS:

                    this.BackgroundColor = Color.Black;

                    break;

                case Device.Android:

                    this.BackgroundColor = Color.Red;

                    break;


                default:

                    this.BackgroundColor = Color.Yellow;

                    break;

            }

            Editor m1 = new Editor
            {
                Placeholder = "..."
            };

            m1.HeightRequest = 100;
            m1.TextChanged += e1_TextChanged;
            stackLayout01.Children.Add(m1);


            //https://commons.wikimedia.org/wiki/Main_Page useful source of free to use images.

            Image i1 = new Image
            {
                HeightRequest = 200,
                Source =
                    "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            };
            //i1.WidthRequest = 
            stackLayout01.Children.Add(i1);

            Image i2 = new Image
            {
                HeightRequest = 200,
                Source =
                    "FordGTBlueWS.jpg"
            };
            stackLayout01.Children.Add(i2);

        }

        public void e1_TextChanged(object sender, TextChangedEventArgs ea)
        {
            var o = ea.OldTextValue;
            var n = ea.NewTextValue;
        }

        public void e1_OnEntryCompleted(object sender, EventArgs ea)
        {
            var t = (sender as Entry).Text;
        }
    }
}
