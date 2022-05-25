using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_game_
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();

        public virtual void ListPLayers() //Allows the ability to override 'ListPLayers' to 
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
