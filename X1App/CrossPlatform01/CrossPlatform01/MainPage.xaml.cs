using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossPlatform01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button) sender).Text = $"Clicked {count} times! Click Me Again!";
        }
    }
}
