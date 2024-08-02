using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Application.Classes.Models
{
    //Author:  Cullen Gostel
    //Version: 07/25/2024
    //Location in the warehouse
    public class Location
    {
        public int LocationID { get; set; } //Unique ID
        public string Description { get; set; }
        public Location(int locationID, string description)
        {
            LocationID = locationID;
            Description = description;
        }
    }
}
