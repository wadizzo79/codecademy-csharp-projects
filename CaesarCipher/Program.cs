using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter your secret message: ");
            string text = Console.ReadLine();
            string message = text.ToLower();
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int currPosition = Array.IndexOf(alphabet, letter);
                if (currPosition < 0)
                {
                    continue;
                }
                int encryptPosition = (currPosition + 3) % alphabet.Length;
                char encryptLetter = alphabet[encryptPosition];
                encryptedMessage[i] = encryptLetter;


            }

            string encryptedText = String.Join("", encryptedMessage);
            Console.WriteLine(encryptedText);

        }
    }
}