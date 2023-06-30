using Database2022.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database2022.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPerson : ContentPage
    {
        public InsertPerson()
        {
            InitializeComponent();
            this.BindingContext = new InsertViewModel();
        }
    }
}