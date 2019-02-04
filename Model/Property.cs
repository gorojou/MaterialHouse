using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialHouse.Models
{
    public class Property
    {
        public int Id { get; set; }
        public int PropertyTypeId { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int ZipCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int UserId { get; set; }
    }
}
