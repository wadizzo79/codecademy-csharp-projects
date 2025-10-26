using System;
using EscapeRoomAdventure;

public class Program
{
    public static void Main(string[] args)
    {
        // Your code goes here
        FieldAgent agent1 = new FieldAgent("Agent Smith", 007);
        FieldAgent agent2 = agent1;

        agent2.SecretCode = 999;

        Console.WriteLine(agent1.SecretCode);
        Console.WriteLine(agent2.SecretCode);

        EscapeRoomAdventure.File file1 = new EscapeRoomAdventure.File("Confidential.txt", 1024);
        EscapeRoomAdventure.File file2 = new EscapeRoomAdventure.File("Confidential.txt", 1024);

        bool sameFile = (file1 == file2);
        Console.WriteLine(sameFile);

        Server mainServer = new Server("Active");
        Server backupServer = new Server("Inactive");

        ISystem[] systems = new ISystem[] { mainServer, backupServer };

        foreach (ISystem system in systems)
        {
            system.Operate();
        }
    }
}