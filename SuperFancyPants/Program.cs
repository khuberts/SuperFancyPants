using System;
using SuperFancyPants.Business;

namespace SuperFancyPants
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();

            Console.ReadKey();
        }
    }
}
