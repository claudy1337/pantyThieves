using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrainingConstructor.sql;

namespace TrainingConstructor.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListExercise : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListExercise()
        {
            InitializeComponent();
        }

       

        private void AddWalking_Clicked(object sender, EventArgs e)
        {

                Workout project = new Workout();
                //project.Title = Names.Text;
                project.Time = Times.ToString();
                
                App.Db.SaveItem(project);
                Navigation.PopAsync();
        }
    }
}
