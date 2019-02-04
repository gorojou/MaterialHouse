using MaterialHouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaterialHouse.ViewModels
{
    public class PropertySecondViewModel : INotifyPropertyChanged
    {


        private ObservableCollection<Property> property;
        public ObservableCollection<Property> Property
        {
            get { return property; }
            set
            {
                property = value;
                OnPropertyChanged("PropertyTypeId");
            }
        }


        public PropertySecondViewModel(int type)
        {

            Property = new ObservableCollection<Property>();

          
            foreach (var property in property)
            {
                Property.Add(property);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
