using System;
using System.IO;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace T11_SQLite
{
    public partial class App
    {
        private static Database _database;

        public static Database Database =>
            _database ?? (_database = new Database(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "People.db3")));

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
