using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TrainingConstructor.sql
{
    [Table("User")]
    internal class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        [Unique]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public string BirthDay { get; set; }
        public int IDWorkout { get; set; }
    }
}
