using System;
using System.Collections.Generic;
using System.Text;

namespace Hells_Kitchen.Classes
{
    public class Team
    {
        public char designation { get; set; }
        public int nbrDishesDone { get; set; }
        public List<Player> teamPlayers { get; set; }
        public Team()
        {
            this.teamPlayers = new List<Player>();
            this.nbrDishesDone = 0;
        }
        public Team(char designation)
        {
            this.designation = designation;
            this.teamPlayers = new List<Player>();
            this.nbrDishesDone = 0;
        }
    }
}
