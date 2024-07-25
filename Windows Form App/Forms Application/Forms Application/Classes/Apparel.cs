using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Application.Classes
{
    //Author:  Cullen Gostel
    //Version: 07/25/2024
    public class Apparel
    {
        int ItemNumber; //Unique ID
        ApparelType Type; //See ApparelType.cs
        string Color;
        string Size;
        string Style; //Additional style info if needed
        int Quantity;

        public Apparel(int itemNumber, ApparelType type, string color, string size, string style, int quantity)
        {
            ItemNumber = itemNumber;
            Type = type;
            Color = color;
            Size = size;
            Style = style;
            Quantity = quantity;
        }
    }
}
