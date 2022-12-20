using System;
using System.Collections.Generic;
using System.Text;

namespace Hells_Kitchen.Classes
{
    public class Recipe
    {
        public string name { get; set; }
        public Dictionary<RawMaterial,int> ingredients { get; set; }
        public Recipe()
        {

        }
        public Recipe(string name, Dictionary<RawMaterial, int> ingredients)
        {
            this.name = name;
            this.ingredients = ingredients;
        }
    }
}
