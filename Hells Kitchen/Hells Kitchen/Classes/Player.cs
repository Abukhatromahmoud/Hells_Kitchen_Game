using System;
using System.Collections.Generic;
using System.Text;

namespace Hells_Kitchen.Classes
{
    public class Player
    {
        public string name { get; set; }
        public char team { get; set; }
        public List<Recipe> knownRecipes  { get; set; }
        public int numberOfDishesDone { get; set; }
        public Dictionary<RawMaterial,int> ingredientsgiven { get; set; }
        public Player()
        {
            this.knownRecipes = new List<Recipe>();
            this.numberOfDishesDone = 0;
            this.ingredientsgiven = new Dictionary<RawMaterial, int>();
        }
        public Player(string name,char team)
        {

            this.name = name;
            this.team = team;
            this.knownRecipes = new List<Recipe>();
            this.ingredientsgiven = new Dictionary<RawMaterial, int>();
            this.numberOfDishesDone = 0;
        }
    }
}
