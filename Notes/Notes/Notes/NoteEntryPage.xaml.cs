using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Notes.Models;

namespace Notes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note) BindingContext;

            //if (string.IsNullOrWhiteSpace(note.Filename))
            //{
            //    //Save
            //    var fileName = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
            //    File.WriteAllText(fileName, note.Text);
            //}
            //else
            //{
            //    //Update
            //    File.WriteAllText(note.Filename, note.Text);
            //}

            note.Date = DateTime.UtcNow;
            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            //if (File.Exists(note.Filename))
            //{
            //    File.Delete(note.Filename);
            //}
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}