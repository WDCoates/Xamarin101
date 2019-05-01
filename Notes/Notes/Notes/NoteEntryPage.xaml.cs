using System;
using Xamarin.Forms.Xaml;
using Notes.Models;

namespace Notes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage
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
            //    var fileName = Path.Combine(XApp.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
            //    File.WriteAllText(fileName, note.Text);
            //}
            //else
            //{
            //    //Update
            //    File.WriteAllText(note.Filename, note.Text);
            //}

            note.Date = DateTime.UtcNow;
            await XApp.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            //if (File.Exists(note.Filename))
            //{
            //    File.Delete(note.Filename);
            //}
            await XApp.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}