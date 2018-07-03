using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pac_Man
{
    [Serializable]
    class Player
    {
        public string name;
        public int score;
        public int id;

        public Player()
        {
        }

        public Player(string name, int score, int id)
        {
            this.name = name;
            this.score = score;
            this.id = id;
        }

        public string Info()
        {
            return name + " Score: " + score;
        }
    }
}
