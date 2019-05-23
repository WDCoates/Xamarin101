using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Buttons
{
    public partial class MainPage : ContentPage
    {
        private string _Text;

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

            Entry e1 = new Entry
            {
                Placeholder = "Enter Text Here..."
            };

            sL.Children.Add(e1);
            e1.IsPassword = true;
            e1.TextChanged += e1_TextChanged;
            e1.Completed += e1_OnEntryCompleted;


            Editor m1 = new Editor
            {
                Placeholder = "..."
            };

            m1.HeightRequest = 100;
            m1.TextChanged += e1_TextChanged;
            sL.Children.Add(m1);


            //https://commons.wikimedia.org/wiki/Main_Page useful source of free to use images.

            Image i1 = new Image
            {
                HeightRequest = 200,
                Source =
                    "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"                
            };

            //i1.WidthRequest = 

            sL.Children.Add(i1);

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
        }

        public void btn_Clicked(object sender, EventArgs ea)
        {
            (sender as Button).Text = "Still need help!";
            Console.WriteLine($"This is a call for help....");
        }

        public void e1_TextChanged(object sender, TextChangedEventArgs ea)
        {
            var o = ea.OldTextValue;
            var n = ea.NewTextValue;
        }

        public void e1_OnEntryCompleted(object sender, EventArgs ea)
        {
            var t = (sender as Entry).Text;
            _Text = "";
        }
    }
}
