using MaterialHouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaterialHouse.ViewModels
{
    public class PropertyViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string PropertyTypeId { get; set; }
        public string Address { get; set; }

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


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
            [System.Runtime.CompilerServices.CallerMemberName]
            string propertyName = null) =>
                PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));

        private bool Busy;
        public bool IsBusy
        {
            get
            {
                return Busy;
            }
            set
            {
                Busy = value;
                OnPropertyChanged();
                GetPropertyCommand.ChangeCanExecute();
            }
        }
        //public ObservableCollection<Property> Property { get; set; }
        public PropertyViewModel()
        {
            Property = new ObservableCollection<Property>();
            GetPropertyCommand = new Command(
                async () => await GetProperty(),
                () => !IsBusy
                );
        }
        public async Task GetProperty()
        {
            if (!IsBusy)
            {
                Exception Error = null;
                try
                {
                    IsBusy = true;
                    var Repository = new Repository();
                    var Items = await Repository.GetProperty();
                    Property.Clear();
                    foreach (var property in Items)
                    {
                        Property.Add(property);
                    }
                }
                catch (Exception ex)
                {
                    Error = ex;
                }
                finally
                {
                    IsBusy = false;
                }
                if (Error != null)
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(
                    "Error!", Error.Message, "OK");
                }

            }
            return;
        }
        public Command GetPropertyCommand { get; set; }



    }
}
