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
            Workout img = new Workout();
           
            img.Puth = pathName;
            App.Db.SaveItem(img);
            

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
                pathName = photo.FullPath;
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

    }
}