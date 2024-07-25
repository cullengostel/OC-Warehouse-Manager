using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Application.Classes
{
    public class Location
    {
        int LocationID;
        string LocationDescription;
        public Location(int locationID, string locationDescription)
        {
            LocationID = locationID;
            LocationDescription = locationDescription;
        }
    }
}
