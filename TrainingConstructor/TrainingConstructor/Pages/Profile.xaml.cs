using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;
using SQLite;
using TrainingConstructor.Pages;
using TrainingConstructor.sql;

namespace TrainingConstructor.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public string pathName;
        public Profile()
        {
            InitializeComponent();           
        }



        private void SaveProfile_Clicked(object sender, EventArgs e)
        {
            Workout workout = new Workout();
            workout.Time = pathName;
            App.Db.SaveItem(workout);
        }
        protected override void OnAppearing()
        {
            
            base.OnAppearing();
        }

        private async void UserImages_Clicked(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                pathName = photo.FullPath;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }
    }
}