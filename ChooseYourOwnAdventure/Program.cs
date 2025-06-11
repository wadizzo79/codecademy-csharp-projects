using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            // Interpolates name given by user
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            // User types YES or NO
            Console.Write("Type YES or NO:");
            string noiseChoice = Console.ReadLine();
            string answer = noiseChoice.ToUpper();

            // Checks if incorrect answer is given
            if (answer != "YES" && answer != "NO")
            {
                Console.WriteLine("Please enter a valid option");
                return;
            }

            // Checks if choice is NO
            if (answer == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
                return;
            }

            // Checks if choice is YES
            else if (answer == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");

                // Asks for User iput
                Console.Write("TYPE OPEN or KNOCK:");
                string doorChoice = Console.ReadLine();
                string doorAction = doorChoice.ToUpper();

                // Checks if answer is KNOCK
                if (doorAction == "KNOCK")
                {
                    Console.WriteLine("A voice behind this door speaks. It says, \"Answer this riddle: \"\n\"Poor people have it. Rich people need it. If you eat it, you die. What is it?\"");
                    Console.Write("Type your answer: ");
                    string riddleAnswer = Console.ReadLine();
                    string riddleChoice = riddleAnswer.ToUpper();

                    // Checks if answer is correct
                    if (riddleChoice == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door.\nTHE END.");
                    }
                    // If incorrect answer is given
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END.");
                    }
                }

                // Checks if answer is OPEN
                else if (doorAction == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1-3):");
                    string keyChoice = Console.ReadLine();
                    string keyAnswer = keyChoice.ToUpper();

                    // Responses switch provides to choice picked 
                    switch (keyAnswer)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there.\nStrange...\nTHE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END.");
                            break;
                    }
                }
                // If answer other than KNOCK or OPEN is given
                else
                {
                    Console.WriteLine("Please enter a valid choice");
                    return;
                }
            }
        }
    }
}



