using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Application.Classes
{
    public class Box
    {
        int BoxID;
        private int LocationID;
        List<Apparel> Contents;

        public Box(int boxID, int locationID, List<Apparel> contents)
        {
            BoxID = boxID;
            LocationID = locationID;
            Contents = contents;
        }
    }
}
