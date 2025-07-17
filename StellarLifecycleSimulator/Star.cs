using System;

namespace StarLifecycleSimulator
{
    public class Star
    {
        public string name;
        public string type;
        public int age;
        public double brightness;

        public Star(string name, string type)
        {
            this.name = name;
            this.type = type;
            age = 0;
            brightness = 1.0;
        }

        public Star(string type) : this(type, "Unknown")
        {
            Console.WriteLine("Star type set to default: Unknown.");
        }

        public void Shine()
        {
            Console.WriteLine($"Star {name} is shining with brightness {brightness}");
        }

        public void GrowOlder()
        {
            age += 1;
            brightness *= 0.9;
        }

        public void Supernova()
        {
            brightness = 0;
            Console.WriteLine($"Star {name} has exploded in a supernova");
        }
    }
}