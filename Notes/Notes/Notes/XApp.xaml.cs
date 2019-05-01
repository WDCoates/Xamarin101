using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Notes.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Notes
{
    public partial class XApp
    {
        private static NoteDatabase _database;

        //public static string FolderPath { get; private set;}

        public static NoteDatabase Database =>
            _database ?? (_database = new NoteDatabase(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3")));

        public XApp()
        {
            InitializeComponent();
            //FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new NotesPage());
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
