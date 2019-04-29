using System;
using Notes.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesPage
    {
		public NotesPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //var notes = new List<Note>();
            //var files = Directory.EnumerateFiles(App.FolderPath, $"*.notes.txt");
            //foreach (var filename in files)
            //{
            //    notes.Add(new Note
            //        {Filename = filename, Text = File.ReadAllText(filename), Date = File.GetCreationTime(filename)});
            //}
            //listView.ItemsSource = notes.OrderBy(o => o.Date).ToList();

            listView.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void OnNoteAddClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoteEntryPage {BindingContext = new Note()});
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }
    }
}