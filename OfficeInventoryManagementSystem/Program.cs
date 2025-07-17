using System;
using System.Collections.Generic;


public class InventoryManagement
{
    public static void Main(string[] args)
    {
        // Creates list to store inventory items
        List<string> inventoryList = new List<string>();
        // Adds items to list
        inventoryList.Add("Printer");
        inventoryList.Add("Laptop");
        inventoryList.Add("Desk Chair");
        inventoryList.Add("Monitor");
        inventoryList.Add("Keyboard");
        // Prints the total number of items
        Console.WriteLine(inventoryList.Count);

        // Checks if Desk Chair is in the inventory list
        bool hasDeskChair = inventoryList.Contains("Desk Chair");
        // Prints value of hasDeskChair
        Console.WriteLine(hasDeskChair);
        // Removes Printer from the inventory list and stores it in a bool
        bool removed = inventoryList.Remove("Printer");
        // Prints value of removed
        Console.WriteLine(removed);
        // Prints inventory items after removing prter
        foreach (string inventory in inventoryList)
        {
            Console.WriteLine(inventory);
        }
        // New list initialzed with new items
        List<string> newItems = new List<string>();
        newItems.Add("Mouse");
        newItems.Add("Desk Lamp");
        // Adds the new items to inventoryList
        inventoryList.AddRange(newItems);
        // Removes the two items from inventoryList
        inventoryList.RemoveRange(4, 2);
        // Stores the first three items in a new list called topInventory
        List<string> topInventory = new List<string>();

        topInventory.AddRange(inventoryList.GetRange(0, 3));
        // Prints topInventory items
        foreach (string topItems in topInventory)
        {
            Console.WriteLine(topItems);
        }




    }
}