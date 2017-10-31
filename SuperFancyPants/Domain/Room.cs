using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFancyPants
{
    class Room
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public Room(string name, string message)
        {
            Name = name;
            Message = message;
        }
    }
}
