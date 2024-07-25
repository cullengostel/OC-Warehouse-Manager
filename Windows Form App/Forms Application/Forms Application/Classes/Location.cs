using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Application.Classes
{
    public class Location
    {
        public int LocationID { get; set; } //Unique ID
        public string LocationDescription { get; set; }
        public Location(int locationID, string locationDescription)
        {
            LocationID = locationID;
            LocationDescription = locationDescription;
        }
    }
}
