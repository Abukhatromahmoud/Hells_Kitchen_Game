using System;
using System.Collections.Generic;
using System.Text;

namespace Hells_Kitchen.Classes
{
    public class Vegetable : RawMaterial
    {
        public string type = "Vegetable";
        public Vegetable()
        {

                
        }
        public Vegetable(string name, string unitMeasure) : base(name, unitMeasure)
        {

        }
    }
}
