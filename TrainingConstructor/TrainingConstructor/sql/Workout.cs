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
        public int Id { get; set;}
        public string Name { get; set;}
        public string Title { get; set;}
       
        public string Puth { get; set;}
        public string Time { get; set;}
        public int Count { get; set;}
    }
}
