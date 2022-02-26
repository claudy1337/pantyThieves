using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingConstructor.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserListExercise : ContentPage
    {
     

        
        public UserListExercise()
        {
            InitializeComponent();
            

            
        }
        
        protected override void OnAppearing()
        {
            LVProject.ItemsSource = App.Db.GetItems();
            base.OnAppearing();
        }

        private void UpdateList()
        {
            LVProject.ItemsSource = App.Db.GetItems();
        }

    }
}
