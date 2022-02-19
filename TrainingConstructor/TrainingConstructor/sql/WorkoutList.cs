using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TrainingConstructor.sql
{
    [Table("WorkoutList")]
    internal class WorkoutList
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string IDUser { get; set; }
        public string IDWorkout { get; set; }
    }
}
