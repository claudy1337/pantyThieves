using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingConstructor.sql;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingConstructor.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Auth : ContentPage
    {
       
        public Auth()
        {
            InitializeComponent();
        }

        private async void BRegistration_Clicked(object sender, EventArgs e)
        {
            var users = App.Db.GetUsers().Where(u => u.Login == Login.Text && u.Password == Password.Text).ToList();
            if (users.Count != 0)
            {
                await Navigation.PushAsync(new Page1());
            }
            else
            {
                await DisplayAlert("Ошибка авторизации", "Неверный логин или пароль", "Закрыть");
            }
            
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}