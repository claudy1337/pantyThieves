using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using TrainingConstructor.Pages;
using TrainingConstructor.sql;

namespace TrainingConstructor.sql
{
    internal class WorkoutBD
    {
        SQLiteConnection db;
        public WorkoutBD(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Workout>();
        }

        public IEnumerable<Workout> GetItems()
        {
            return db.Table<Workout>().ToList();
        }

        public Workout GetItem(int id)
        {
            return db.Get<Workout>(id);
        }

        public int DeleteItem(int id)
        {
            return db.Delete<Workout>(id);
        }

        public int SaveItem(Workout item)
        {
            if (item.Id != 0)
            {
                db.Update(item);
                return item.Id;
            }
            else
            {
                return db.Insert(item);
            }
        }
    }
}
