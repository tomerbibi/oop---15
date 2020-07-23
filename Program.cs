using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_15
{
    class Program
    {
        static void PrintGame(Game g)
        {
            Console.WriteLine(g.ToString());
            int number = g.TellMeHowManyPlayers();
        }
        static void Main(string[] args)
        {
            Game g = new Game();
            Game socker = new Game("socker", 8f);
            Game snooker = new Game("snooker", 2, 5, "england");
            Game tennis = new Game("tennis", "france");

        }
    }
}
