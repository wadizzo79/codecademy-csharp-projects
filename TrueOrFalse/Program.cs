using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Initialized string array with questions
            string[] questions = { "Water is a liquid.", "Man United have fallen off", "Video games are boring" };
            // Initialized bool array with answers
            bool[] answers = { true, true, false };
            // Array declared is empty with same length as questions array
            bool[] responses = new bool[questions.Length];
            // Checks if length of questions and answers arrays are of equal length
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("The number of questions to answers do not match");
            }

            // Variable keeps track of currently asked question
            int askingIndex = 0;

            // Loops through questions array asking each question and recording responses
            foreach (string question in questions)
            {
                string input; // Text the user enters 
                bool isBool; // True if the user input can be converted to boolean otherwise false
                bool inputBool; // Boolean version of the users entry

                // Prints the current question 
                Console.WriteLine(questions[askingIndex]);
                Console.WriteLine("True or false?");
                // Stores user's input and converts to lowercase
                input = Console.ReadLine().ToLower();

                // Checks if user entered a valid value
                if (input == "true" || input == "false")
                {
                    isBool = true;
                }
                else
                {
                    isBool = false;
                }

                // Re-prompts user if they respond with an invalid value
                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine().ToLower();

                    // Checks again if user entered a valid value
                    if (input == "true" || input == "false")
                    {
                        isBool = true;
                    }
                    else
                    {
                        isBool = false;
                    }
                }

                // Sets what is input to the correct boolean value
                if (input == "true")
                {
                    inputBool = true;
                }
                else
                {
                    inputBool = false;
                }

                // Stores user's bool answer 
                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0; // Loops through responses
            int score = 0; // Counts the number of correct responses

            // Iterates through each answer
            foreach (bool answer in answers)
            {
                // Accesses each element and stores them 
                bool userAnswer = responses[scoringIndex];
                // Writes current user response and correct answer
                Console.WriteLine($"Input: {userAnswer} | Answer: {answer} ");

                // Adds user score if the response matches the answer
                if (userAnswer == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {scoringIndex} correct!");

        }
    }
}
