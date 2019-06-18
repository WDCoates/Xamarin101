using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace T10_LifeCycle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            (Application.Current as App).DisplayText = TextEntry.Text;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            TextEntry.Text = (Application.Current as App).DisplayText;
        }
    }
}
