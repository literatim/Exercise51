using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise51
{
    class Program
    {
        static void Main(string[] args)
        {

            var spanglishDictionary = new Dictionary<string, string>
            {
                {"hello", "hola"},
                {"food", "comida"},
                {"world", "mundo"},
                {"computer", "computadora"},
                {"exercise", "ejercicio"}
            };

            do
            {
                Console.Write("Enter a word in English: ");

                var userSelection = GetUserInput();


                Console.WriteLine($"{userSelection} in Spanish is {spanglishDictionary[userSelection]}.");

                Console.WriteLine($"Do you want to continue? (y/n)");

            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));

        }
        public static string GetUserInput()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Word cannot be blank.");
                Console.WriteLine("Enter a word in English : ");
            }

            return input;
        }
    }
}
