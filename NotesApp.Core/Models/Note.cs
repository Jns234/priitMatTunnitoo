<<<<<<< HEAD
using System;
using SQLite;
=======
﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd

namespace NotesApp.Core.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
        public DateTime ChangeDateTime { get; set; }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 92fce4e6bf9a8379eabbf3ab24f2f7f52fa583bd
