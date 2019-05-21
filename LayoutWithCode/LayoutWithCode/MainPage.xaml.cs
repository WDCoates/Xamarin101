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
                        Text = "This is done done through code!",
                        HorizontalOptions = LayoutOptions.Start
                    }
                }
            };

            stackLayout01.Children.Add(new Label
            {
                Text = "This is also done done through code!",
                HorizontalOptions = LayoutOptions.End,
                BackgroundColor = Color.Yellow
            });

            this.Content = stackLayout01;
        }
    }
}
