using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Application.Classes.Models
{
    //Author:  Cullen Gostel
    //Version: 07/25/2024
    //Distributor of apparel
    public class Distributor
    {
        internal int DistributorID; //Unique ID
        internal string Name;
        internal string ContactInfo; //Just a string representation of contact info, not particularly formatted
        public Distributor(int id, string name, string info)
        {
            DistributorID = id;
            Name = name;
            ContactInfo = info;
        }

        public override string ToString()
        {
            return $"Distributor ID: {DistributorID}, Name: {Name}, Contact: {ContactInfo}";
        }
    }
}
