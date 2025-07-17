using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

            string[] hobbies = { "listening to audiobooks and podcasts", "\nplaying rec sports like bowling and kickball", "\nwriting a speculative fiction novel", "\nreading advice columns" };


            sam.SetHobbies(hobbies);

            string bio = sam.ViewProfile();

            Console.WriteLine(bio);


        }
    }
}
