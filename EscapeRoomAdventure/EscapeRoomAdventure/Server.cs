using System;

namespace EscapeRoomAdventure
{
    class Server : ISystem
    {
        public string Status
        { get; set; }

        public Server(string status)
        {
            Status = status;
        }
        public void Operate()
        {
            Console.WriteLine($"Server is {Status}");
        }
    }
}