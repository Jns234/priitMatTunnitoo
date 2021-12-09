using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using NotesApp.Core.Models;

namespace NotesApp.Core
{
    public class SqlService
    {
        SQLiteConnection _sqlConnection;
<<<<<<< HEAD
=======

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        public SqlService()
        {
            CreateConnection();
        }
<<<<<<< HEAD
=======

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        public void CreateConnection()
        {
            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "notesdb2.db3");

            _sqlConnection = new SQLiteConnection(dbPath);
        }
<<<<<<< HEAD
=======

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        public void CreateTable()
        {
            _sqlConnection.CreateTable<Note>();
        }
<<<<<<< HEAD
=======

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        public void InsertData(Note note)
        {
            _sqlConnection.Insert(note);
        }
<<<<<<< HEAD
=======

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        public void UpdateData(Note note)
        {
            _sqlConnection.Update(note);
        }
<<<<<<< HEAD
=======

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        public List<Note> GetAllNotes()
        {
            return _sqlConnection.Table<Note>().ToList();
        }
<<<<<<< HEAD
=======

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        public Note GetNote(int id)
        {
            return _sqlConnection.Table<Note>().Where(x => x.Id == id).FirstOrDefault();
        }
<<<<<<< HEAD
=======

>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
        public void DeleteData(Note note)
        {
            _sqlConnection.Delete(note);
        }

    }
}
