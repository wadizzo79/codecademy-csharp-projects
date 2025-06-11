using System;

public class SpaceExpedition
{
    public static void Main(string[] args)
    {
        // Your code goes here
        // Initialize boolean variables for planet conditions
        bool isAtmosphereBreathable = true;

        bool isGravityStable = false;

        bool resourcesSufficient = true;

        bool isHabitable;

        bool suitableForExpansion;

        // Checks if the planet is habitable
        isHabitable = isAtmosphereBreathable && isGravityStable;

        Console.WriteLine(isHabitable);

        // Checks if the planet is suitable for expansion
        suitableForExpansion = isGravityStable || resourcesSufficient;

        Console.WriteLine(suitableForExpansion);

        // Initialize int variables for crew size and ship capacity
        int currentCrew = 5;

        int maxCrewCapacity = 10;

        bool canAcceptMoreCrew;

        // Checks if the ship can accept more crew members
        canAcceptMoreCrew = currentCrew < maxCrewCapacity;

        Console.WriteLine(canAcceptMoreCrew);
    }
}