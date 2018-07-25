using System;

namespace MultiplyLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userInputStr = Console.ReadLine();
            int userInputInt = int.Parse(userInputStr);

            int sumOutput = 0;

            for (int loopStart = 2; loopStart < 20; loopStart++)
            {
                Console.WriteLine(loopStart * userInputInt);

                sumOutput += loopStart * userInputInt;
            }

            Console.Write(sumOutput);
            Console.ReadLine();
        }
    }
}
