using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TrainingConstructor.sql
{
    internal class User
    {
        [Table("User")]
        internal class Workout
        {
            [PrimaryKey, AutoIncrement, Column("_id")]
            [Unique]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public string Login { get; set; }
            
        }
    }
}
