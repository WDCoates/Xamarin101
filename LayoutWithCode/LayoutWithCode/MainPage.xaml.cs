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
        }
    }
}
