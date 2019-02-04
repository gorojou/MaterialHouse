using MaterialHouse.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MaterialHouse.Views
{
    public partial class iTabPage : ContentPage
    {
        public iTabPage(int type)
        {
            InitializeComponent();
            string img="";
            if (type==1)
            { Title = "Home"; img = "Home.png"; }
            if (type == 2)
            { Title = "Appartment";  img = "Appartment.png";}

            if (type == 3)
            { Title = "Office"; img = "Office.png"; }
                

            BindingContext = new PropertySecondViewModel(type);
        }
    }
}
