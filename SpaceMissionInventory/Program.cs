using System;

namespace SpaceMission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array with list of items
            string[] spaceInventory = { "Space Suits", "Oxygen Tanks", "Food Supplies", "Medical Kits", "Communication Devices", "Fuel Canisters", "Navigation Tools", "Repair Tools" };

            // Array with quantity of items
            int[] itemQuantities = { 10, 8, 15, 5, 6, 9, 4, 7 };

            // Checks the length of the array
            if (spaceInventory.Length == 8)
            {
                Console.WriteLine("Space Inventory is ready to go!");
            }

            else if (spaceInventory.Length > 8)
            {
                Console.WriteLine("Too many items!");
            }
            else
            {
                Console.WriteLine("Add more items!");
            }

            // Checks and prints the item along with its quantity
            Console.WriteLine(spaceInventory[1] + " " +
            itemQuantities[1]);

            // Updates the last item and its quantity
            spaceInventory[7] = "Scientific Instruments";

            itemQuantities[7] = 5;

            // Finds index of the first item with a quantity of 5
            int position = Array.IndexOf(itemQuantities, 5);

            Console.WriteLine($"The first item with quantity 5 is at position {position}");

            // Reverses the order of items in the inventory
            Array.Reverse(spaceInventory);

            Console.WriteLine($"{spaceInventory[0]},{spaceInventory[7]}");

            // Sorts the order of items alphabetically
            Array.Sort(spaceInventory);

            Console.WriteLine($"{spaceInventory[0]},{spaceInventory[7]}");


        }
    }
}