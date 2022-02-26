using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using TrainingConstructor.sql;

namespace TrainingConstructor.sql
{
    [Table ("Workout")]
    internal class Workout
    {
        [PrimaryKey,AutoIncrement, Column("_id")]
        [Unique]
        public int IdWorkout { get; set;}
        public string NameWorkout { get; set;}
        public string PathWorkout { get; set;}
        public string Time { get; set;}

        [Unique]
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public string PathUser { get; set; }
        public string LoginUser { get; set; }
        public string NumberUser { get; set; }
        public string PasswordUser { get; set; }
        public string BirthDay { get; set; }
       
    }
}
