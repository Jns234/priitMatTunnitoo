namespace NotesApp.Droid.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
        public DateTime ChangeDateTime { get; set; }
        //public Note(string Id, string heading, string content, DateTime datetime)
        //{
        //    Heading = heading;
        //    Content = content;
        //    ChangeDateTime = datetime;
        //}
    }
}