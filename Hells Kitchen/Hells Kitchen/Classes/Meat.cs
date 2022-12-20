using System;
using System.Collections.Generic;
using System.Text;

namespace Hells_Kitchen.Classes
{
    public class Meat: RawMaterial
    {
        public string type ="Meat";
        public Meat()
        {
                
        }
        public Meat(string name, string unitMeasure) : base(name, unitMeasure)
        {

        }
    }
}
