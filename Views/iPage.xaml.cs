using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialHouse.ViewModels;
using Xamarin.Forms;

namespace MaterialHouse.Views
{
    public partial class iPage : ContentPage
    {
        public iPage()
        {
            InitializeComponent();
            BindingContext = new PropertyViewModel();
        }
    }
}
