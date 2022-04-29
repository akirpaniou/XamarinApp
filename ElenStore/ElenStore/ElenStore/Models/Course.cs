using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace ElenStore.Models
{
    [Table("Courses")]
    public class Course
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }

        public string CourseName { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }

    }
}
