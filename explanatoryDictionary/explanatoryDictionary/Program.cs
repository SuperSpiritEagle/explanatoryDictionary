using System;
using System.Collections.Generic;

namespace explanatoryDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandExit = "выход";
            string userInput = "";

            while (userInput != commandExit)
            {
                Console.WriteLine($"Введите слово значение которого вы хотите узнать для выхода введите {commandExit}");
                userInput = Console.ReadLine();

                Console.Clear();

                ExplanatoryDictionary(userInput);
            }
        }

        private static void ExplanatoryDictionary(string userInput)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Акт", "Единичное действие, а также отдельный поступок.");
            dictionary.Add("Йогурт", "Заквашенное молоко с различными добавками.");
            dictionary.Add("Фабрика", "Промышленное предприятие с машинным способом производства.");

            if (dictionary.ContainsKey(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{userInput}: {dictionary[userInput]}]\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Слово не найдено.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
