using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Buttons
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StackLayout sL = new StackLayout
            {
                Spacing = 10,
                Margin = 20,
                
                Children =
                {
                    new Label
                    {
                        Text = "Buttons - Added Below"                        
                    }
                }
            };


            Button btn1 = new Button
            {
                Text = "Help Me!", BorderColor = Color.Red,
                TextColor = Color.Blue, BorderRadius = 5, BorderWidth = 5, WidthRequest = 150, HeightRequest = 75
            };
            btn1.Clicked += btn_Clicked;
            sL.Children.Add(btn1);

            this.Content = sL;
        }

        public void btn_Clicked(object sender, EventArgs ea)
        {
            (sender as Button).Text = "Still need help!";
            Console.WriteLine($"This is a call for help....");
        }
    }
}
