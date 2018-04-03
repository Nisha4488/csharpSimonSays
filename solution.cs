using System;
using System.Collections.Generic;

namespace simonsays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringsList = new List<string>() {"Hello", "Kevin", "Bacon", "boopo", "programming r so nice", "same", "csharp"};


            bool isPlaying = true;
            while (isPlaying)
            {
                isPlaying = PlayGame(stringsList);
            }

            Console.WriteLine("Game Over");

        }

        static bool PlayGame(List<string> generatedList)
        {
            Random ourGenerator = new Random();

            int indx = ourGenerator.Next(0, generatedList.Count);
            string result = generatedList[indx];

            int willSay = ourGenerator.Next(0, 2);

            string userInput;
            
            if (willSay == 1)
            {
                Console.WriteLine($"Simon Says {result}");
                userInput = Console.ReadLine();

                return userInput == result;
            }
            else
            {
                Console.WriteLine(result);
                userInput = Console.ReadLine();
                return userInput == "";
            }
        }
    }
    
}

