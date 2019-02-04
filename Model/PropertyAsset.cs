using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialHouse.Models
{
    public class PropertyAsset
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int NoteId { get; set; }
        public int PaintId { get; set; }
        public int HVACId { get; set; }
        public int AppliancesId { get; set; }
        public int DoorsWinsId { get; set; }
        public int RoofId { get; set; }
        public int UserId { get; set; }
    }
}
