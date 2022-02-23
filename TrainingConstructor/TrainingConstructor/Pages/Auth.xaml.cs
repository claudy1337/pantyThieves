using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            await Navigation.PushAsync(new Page1());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}