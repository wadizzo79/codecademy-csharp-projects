using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase;
            string lowercase;
            string digits;
            string specialChars;

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            int score = 0;

            int len = password.Length;

            // Checks if password meets minimum length requirements
            if (len >= minLength)
            {
                score++;
            }

            // Checks if password contains uppercase letters
            uppercase = "ABCDEFGHIJKMNOPQRSTUVWXYZ";

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            // Checks if password contains lowercase letters
            lowercase = "abcdefghijklmnopqrstuvwxyz";

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }

            // Checks if password contains digits
            digits = "1234567890";
            if (Tools.Contains(password, digits))
            {
                score++;
            }

            // Check if password contains special characters
            specialChars = "!@#$%^&*()_+-=[]{}|;:'\",.<>/?`~";
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            Console.WriteLine(score);

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Password is extremely strong.");
                    break;
                case 3:
                    Console.WriteLine("Password is strong.");
                    break;
                case 2:
                    Console.WriteLine("Password is medium.");
                    break;
                case 1:
                    Console.WriteLine("Password is weak.");
                    break;
                default:
                    Console.WriteLine("Password does not meet required standards.");
                    break;



            }
        }
    }
}
