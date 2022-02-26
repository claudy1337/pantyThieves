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

            var users = App.Db.GetItems().Where(u => u.LoginUser == Login.Text).ToList();
            Login.Text = CurrentUser.Login;
            Name.Text = CurrentUser.Name;
           

        }


        protected override void OnAppearing()
        {
           // App.Db.GetItems();
           // base.OnAppearing();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                AddUserImage.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

        private void SaveProfile_Clicked_1(object sender, EventArgs e)
        {
            
            var project = (Workout)BindingContext;


                App.Db.SaveItem(project);

        }
    }
}