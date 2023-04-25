using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPart1
{
    public class Ingredients
    {
        //data members of ingredients required
        private string Name;
        private double Quantity;
        private string unit;

        //get and set
        public string name { get; set; }
        public double quantity { get; set; }
        public string Unit { get; set; }

        public Ingredients()
        {
            name = name;
            quantity = Quantity;
            unit = unit;
        }
        public void resetquantity()
        {
            quantity /= 2;
        }
    }
}
