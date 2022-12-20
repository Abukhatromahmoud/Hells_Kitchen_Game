using System;
using System.Collections.Generic;
using System.Text;

namespace Hells_Kitchen.Classes
{
    public class Spice : RawMaterial
    {
        public string type = "Spice";
        public Spice():base()
        {
          
        }
        public Spice(string name, string unitMeasure) : base(name,unitMeasure)
        {

        }
    }
}
