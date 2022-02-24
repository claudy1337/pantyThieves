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
            User user = new User();

            Login.Text = user.Login;
            user.Name = Name.Text;

               
            
            
        }



        private async void SaveProfile_Clicked(object sender, EventArgs e)
        {
            var project = (User)BindingContext;

                if (!String.IsNullOrEmpty(project.Login))
                {
                    App.Db.SaveItem(project);
                }
                

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
                // выбираем фото
                var photo = await MediaPicker.PickPhotoAsync();
                // загружаем в ImageView
                AddUserImage.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

    }
}