using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using T11_SQLite.Model;

namespace T11_SQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listPeople.ItemsSource = await App.Database.GetPeopleAsync();

        }
        private async void AddPerson_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(handleEntry.Text) && !string.IsNullOrWhiteSpace(existenceEntry.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Handle = handleEntry.Text,
                    Existence = int.Parse(existenceEntry.Text)
                });

                handleEntry.Text = existenceEntry.Text = string.Empty;
                listPeople.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}
