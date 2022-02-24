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
     

        public ObservableCollection<Card> ListDetails { get; set; }
        public UserListExercise()
        {
            InitializeComponent();
            ListDetails = new ObservableCollection<Card>
            {
                new Card{ImgIcon = "plus.png", Name = "derr", ImgIcon1="user.png", Name1 = "dsdsds"},
                new Card{ImgIcon ="plus.png",Name = "dadad", ImgIcon1 = "user.png", Name1="fdad"},
                new Card{ImgIcon="plus.png", Name = "dsfdds", ImgIcon1 = "fzfdfd", Name1="ddaasd"},
                new Card{ImgIcon="plus.png", Name = "dsfdds", ImgIcon1 = "fzfdfd", Name1="ddaasd"}
            };
            BindingContext = this;

            
        }
        public class Card
        {
            public string Name { get; set; }
            public string ImgIcon { get; set; }
            public string ImgIcon1 { get; set; }
            public string  Name1 { get; set; }
            

        }

    }
}
