using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Application.Classes.Models
{
    //Author:  Cullen Gostel
    //Version: 07/25/2024
    //Boxes in the warehouse, contain apparel
    public class Box
    {
        public int BoxID { get; set; } //Unique ID
        public int LocationID { get; set; } //Corresponds to location
        public List<Apparel> Contents { get; set; } //list of contents

        public Box()
        {

        }
        public Box(int boxID, int locationID, List<Apparel> contents)
        {
            BoxID = boxID;
            LocationID = locationID;
            Contents = contents;
        }

        public int GetTotalQuantity()
        {
            int total = 0;
            foreach (Apparel a in Contents)
            {
                total += a.Quantity;
            }
            return total;
        }
    }
}
