using System;
using System.Collections.Generic;
using System.Text;

namespace Hells_Kitchen.Classes
{
    public class otherIngredient:RawMaterial
    {
        public string type = "OtherIngredient";
        public otherIngredient():base()
        {

        }
        public otherIngredient(string name, string unitMeasure) : base(name, unitMeasure)
        {

        }
    }
}
