using System;

public class GalacticTravelAgency
{
    public static void Main(string[] args)
    {
        // This program simulates a galactic travel agency booking system.
        string passengerName = "Zara";
        int passengerAge = 28;
        string ticketType = "First Class";
        string preferredPlanet = "Mars";

        // Simulating a scenario where the passenger's age is incremented until they are older than 28
        while (passengerAge <= 28) // Loop to simulate time passing until the passenger is older than 28
        {
            passengerAge++; // Incrementing age to simulate time passing
        }

        double passengerAgeDouble = (double)passengerAge; // Explicitly casting int to double
        double passengerAgeDouble2 = passengerAge; // Implicitly casting int to double

        string passengerAgeString = Convert.ToString(passengerAge); // Converting int to string

        // Output the passenger details
        Console.WriteLine(passengerName);
        Console.WriteLine(passengerAgeString);
        Console.WriteLine(ticketType);
        Console.WriteLine(preferredPlanet);
    }
}