using System;

namespace MultiplyLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("Please enter a number:");
            //acquire user input
            string userInputStr = Console.ReadLine();
            //convert user input to integer
            int userInputInt = int.Parse(userInputStr);


            //declare an integer and assign it a value that will be changed later
            int sumOutput = 0;

            //loop from 2 to 20, incrementing loopStart each time
            for (int loopStart = 2; loopStart < 21; loopStart++)
            {
                //display the result of loopStart * userInputInt
                Console.WriteLine(loopStart * userInputInt);

                //add the result of loopstart * userInputInt to the variable sumOutput
                sumOutput += loopStart * userInputInt;
            }

            //display SumOutput
            Console.Write(sumOutput);
            //wait for user input
            Console.ReadLine();
        }
    }
}
