using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Objects
{
    public class RandomPasswordGenerator
    {
        private const string CapitalLetters =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters =
            "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialCharacters =
            "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
        private const string AllChars =
            CapitalLetters + SmallLetters + Digits + SpecialCharacters;

        private static Random random = new Random();

        private static char GenerateChar(string availableChars)
        {
            int randomIndex = random.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }

        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int randomPosition = random.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }

        public static void RandomGenerator()
        {
            StringBuilder password = new StringBuilder();

            //Generate two capital letters
            for(int i = 1; i <=2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(password, capitalLetter);
            }

            //Generate two small letters
            for(int i = 1; i <=2;i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(password, smallLetter);
            }

            //Generate one digit
            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);

            //Generate three special characters
            for(int i = 1; i <= 3;i++)
            {
                char specialChar = GenerateChar(SpecialCharacters);
                InsertAtRandomPosition(password, specialChar);
            }

            //generate few random characters (between 0 and 7)
            int count = random.Next(8);
            for(int i = 1; i <= count;i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password,specialChar);
            }

            Console.WriteLine(password);
        }

    }
}
