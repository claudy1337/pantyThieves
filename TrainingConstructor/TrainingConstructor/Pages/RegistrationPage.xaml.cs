using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;
using SQLite;
using TrainingConstructor.sql;


namespace TrainingConstructor.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public string pathName;
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void CreateProfile_Clicked(object sender, EventArgs e)
        {
            Workout workout = new Workout();
            workout.NameUser = Name.Text;
            workout.LoginUser = Login.Text;
            workout.PathUser = pathName;
            workout.PasswordUser = Password.Text;
            App.Db.SaveItem(workout);
            
            await Navigation.PushAsync(new Profile());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
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