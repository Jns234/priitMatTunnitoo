using NotesApp.Droid.Models;

namespace NotesApp.CommandLine
{
    public class SqlService
    {

        public SQLiteConnection CreateConnection()
        {
            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "notesdb.db3");

            return new SQLiteConnection(dbPath);
        }

        public void CreateTable(SQLiteConnection conn)
        {
            conn.CreateTable<Note>();
        }

        public void InsertData(SQLiteConnection conn, Note note)
        {

            conn.Insert(note);
        }

        public List<Note> GetAllNotes(SQLiteConnection conn)
        {
            return conn.Table<Note>().ToList();
        }

        public Note GetNote(SQLiteConnection conn, int id)
        {
            return conn.Table<Note>().Where(x => x.Id == id).FirstOrDefault();
        }
        public void ModifyData(SQLiteConnection conn, Note note)
        {

        }

        public void DeleteData(SQLiteConnection conn, Note note)
        {

        }

    }
}
