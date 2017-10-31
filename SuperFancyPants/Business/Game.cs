using System;
using System.Collections.Generic;

namespace SuperFancyPants
{
    public class Game
    {
        private string Name { get; set; }
        private Room ActiveRoom { get; set; }

        public void StartGame()
        {
            Initialize();

            Start();
        }

        private void End()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Dank voor het mee doen!");
            Console.WriteLine("----------------------------");    
        }

        private void Start()
        {
            Console.WriteLine("Voer naam in:");
            while (string.IsNullOrEmpty(Name))
            {
                Name = Console.ReadLine();

                if (string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Je moet je naam invoeren om het spel te kunnen spelen!!");
                }

                if (Name.Trim().ToLower() == "help")
                {
                    Console.WriteLine("Je moet eerst een naam invoeren voordat je commands uit kan voeren");
                }
            }

            Console.WriteLine($"Welkom {Name}");
            Console.WriteLine("Het is vandaag:");
            Console.WriteLine(DateTime.Now);

            IList<Room> roomList = new List<Room>();

            roomList.Add(new Room("Slaapkamer", "Je bent dood"));
            roomList.Add(new Room("Woonkamer", "Je mag naar de volgende kamer"));
            roomList.Add(new Room("Berging", "Je kan niks vinden en mag naar een andere kamer"));

            bool isAlive = true;

            while (isAlive)
            {
                string command = Console.ReadLine();

                if (command.Trim().ToLower() == "help")
                {
                    Console.WriteLine("     help - Commando om alle mogelijke commands op te vragen");
                    Console.WriteLine("     kamer 'Woonkamer' - Navigeer naar een kamer");
                    Console.WriteLine("     kamerlijst - Vraag een lijst van alle beschikbare kamers op");
                }

                if (command.Trim().ToLower() == "kamerlijst")
                {
                    Console.WriteLine("----------------------------");

                    foreach (var room in roomList)
                    {
                        Console.WriteLine(room.Name);
                    }
                    Console.WriteLine("----------------------------");
                }

                switch (command.Trim().ToLower())
                {
                    case "kamer slaapkamer":
                        foreach (var room in roomList)
                        {
                            if (room.Name == "Slaapkamer")
                            {
                                ActiveRoom = room;
                                isAlive = false;
                            }
                        }
                        break;

                    case "kamer woonkamer":
                        foreach (var room in roomList)
                        {
                            if (room.Name == "Woonkamer")
                            {
                                ActiveRoom = room;
                            }
                        }
                        break;

                    case "kamer berging":
                        foreach (var room in roomList)
                        {
                            if (room.Name == "Berging")
                            {
                                ActiveRoom = room;
                            }
                        }
                        break;

                }
                if (ActiveRoom != null)
                {
                    Console.WriteLine(ActiveRoom.Name + " " + ActiveRoom.Message);
                }

                if (!isAlive)
                {
                    End();
                }
            }


        }

        private void Initialize()
        {
            Console.Title = "SuperFancyPants";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Welkom bij <SuperFancyPants>");
            Console.WriteLine("----------------------------");
        }
    }
}
