using MaterialHouse.DAL;
using MaterialHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MaterialHouse.Views
{
    public partial class iTabbedPage : TabbedPage
    {
        public iTabbedPage()
        {
            InitializeComponent();

            DummyDB _context = new DummyDB();

            List<string> allContinents = new List<string>();

            // Retrieve and insert all continents from our list
            //foreach (var continent in _context.Animals)
            //    allContinents.Add(continent.ContinentOrigin);

            // Distinct to remove duplicates
            //allContinents = allContinents.Distinct().ToList();

            // Create dinamically tabs for continents that we have
            //foreach (var continent in allContinents)
            //    Children.Add(new iTabPage(continent));


            //New

            Repository repository = new Repository();
            //  List<Property> propertyList = repository.GetPropertyByUserSync(int.Parse(App.Current.Properties["UsersId"].ToString()));

            List<Property> propertyList = repository.GetPropertyByUserSync(7);

            propertyList = propertyList.Distinct().ToList();

            foreach (var type in propertyList)
                Children.Add(new iTabPage(int.Parse(type.ToString())));

        }
    }
}
