using System;
using System.Collections.Generic;
using System.Text;

namespace Hells_Kitchen.Classes
{
    public class RawMaterial
    {
        public static List<RawMaterial> ingredientsList = new List<RawMaterial>();
        public string name {  get; set; }
        public string unitMeasure { get; set; }
        public RawMaterial()
        {

        }
        public RawMaterial(string name,string unitMeasure)
        {
            this.name = name;
            this.unitMeasure = unitMeasure;
            ingredientsList.Add(this); 
        }

    }
}
