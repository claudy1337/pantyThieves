using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrainingConstructor.sql;
using SQLite;
using System.IO;
using TrainingConstructor.Pages;



namespace TrainingConstructor
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Project.db";
        internal static WorkoutBD db;
        internal static WorkoutBD Db
        {
            get
            {
                if (db == null)
                {
                    db = new WorkoutBD(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return db;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
