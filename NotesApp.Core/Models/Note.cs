
using System;
using SQLite;

﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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

}