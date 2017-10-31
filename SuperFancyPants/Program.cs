using System;
using System.Collections;
using System.Collections.Generic;

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
