using System;
using System.Collections.Generic;
using System.Text;

namespace DonutsApp
{   
    class MyOrder       // This class holds all fields for the order
    {
        // Class constructor for fields
        public MyOrder(string name, int coffees, int donuts)
        {
            Name = name;
            Coffees = coffees;
            Donuts = donuts;
        }

        // Property values
        public string Name { get; set; }
        public int Coffees { get; set; }
        public int Donuts { get; set; }

        // overridable ToString method to return output
        public override string ToString()
        {
            return this.Name + " -- " 
                + "\r\n" + this.Coffees + " coffees " 
                + "\r\n" + this.Donuts + " donuts.";
        }
    }
}
