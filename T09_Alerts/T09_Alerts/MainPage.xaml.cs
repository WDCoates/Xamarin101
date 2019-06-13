using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace T09_Alerts
{
    public partial class MainPage : ContentPage
    {
        private MainPage Current;
        public MainPage()
        {
            InitializeComponent();

            this.Current = this;
        }

        private async void B1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert.", "Ohi");
            Current.L1.Text = "B1 has been Clicked";
        }

        private async void B2_Clicked(object sender, EventArgs e)
        {
            bool resp = await DisplayAlert("Save Me?", "Would you like tis saved", "Yes", "No");
            Current.L1.Text = "Save data: " + resp;
        }

        private async void B3_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Do What?", "Cancel", null, "Email", "Shout", "Letter");
            Current.Action.Text = action;
        }
    }
}
