using System;

namespace EscapeRoomAdventure
{
    interface ISystem
    {
        public void Operate();

        public string Status
        { get; set; }
    }
}