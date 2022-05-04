using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElenStore.Models
{
    [Table("Notes")]
    public class Note
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string NoteName { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
