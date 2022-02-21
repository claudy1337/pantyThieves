using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrainingConstructor.Pages;

namespace TrainingConstructor.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loadining : ContentPage
    {
        public Loadining()
        {
            InitializeComponent();
        }

        private async void IncomingAuth_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Auth());
        }
    }
}