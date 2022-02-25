using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrainingConstructor.sql;

namespace TrainingConstructor.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void CreateProfile_Clicked(object sender, EventArgs e)
        {
            User user = new User();
             user.Login = Login.Text;
              user.Password = Password.Text;
               user.Name = Name.Text;
            App.Db.AddUser(user);

            await Navigation.PushAsync(new Profile());
        }
    }
}