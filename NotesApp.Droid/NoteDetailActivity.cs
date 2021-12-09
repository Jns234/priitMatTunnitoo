using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
<<<<<<< HEAD
using NotesApp.Core.Models;
=======
using NotesApp.Core;
using NotesApp.Core.Models;
using SQLite;
>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
using System;

namespace NotesApp.Droid
{
    [Activity(Label = "NoteDetailActivity")]
    public class NoteDetailActivity : Activity
    {
        Note _note;
        EditText _headingText;
        EditText _contentText;
        int _id;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.notes_detail_activity);

            _headingText = FindViewById<EditText>(Resource.Id.editText2);
            _contentText = FindViewById<EditText>(Resource.Id.editText1);
            var saveButton = FindViewById<Button>(Resource.Id.saveButton);
            var deleteButton = FindViewById<Button>(Resource.Id.deleteButton);

            var mode = Intent.GetStringExtra("mode");

            if (mode == "edit")
            {
                _id = Intent.GetIntExtra("id", 0);

                _note = MainActivity.SqlService.GetNote(_id);
                _headingText.Text = _note.Heading;
                _contentText.Text = _note.Content;
            }

            saveButton.Click += SaveButton_Click;
            deleteButton.Click += DeleteButton_Click;


        }
        private void SaveButton_Click(object sender, System.EventArgs e)
        {

            if (_note == null)
            {
                _note = new Note();
                _note.Heading = _headingText.Text;
                _note.Content = _contentText.Text;
                _note.ChangeDateTime = DateTime.Now;

                MainActivity.SqlService.InsertData(_note);
            }
            else
            {
                _note.Heading = _headingText.Text;
                _note.Content = _contentText.Text;
                _note.ChangeDateTime = DateTime.Now;
                MainActivity.SqlService.UpdateData(_note);
            }
            Finish();
        }
        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            MainActivity.SqlService.DeleteData(_note);
            Finish();
<<<<<<< HEAD
=======

            //kui ma deletein, kustutab see note'i andmebaasist, aga see jääb listi nii kauaks, kuni ma rakenduse uuesti käima panen

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        }
    }
}
