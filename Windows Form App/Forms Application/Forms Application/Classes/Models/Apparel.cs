using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms_Application.Enums;

namespace Forms_Application.Classes.Models
{
    //Author:  Cullen Gostel
    //Version: 07/25/2024
    public class Apparel
    {
        public int ItemNumber { get; set; } //Unique ID
        public ApparelType Type { get; set; } //See ApparelType.cs
        public string Color { get; set; }
        public string Size { get; set; }
        public string Style { get; set; } //Additional style info if needed
        public int Quantity { get; set; }

        public Apparel()
        {

        }
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
