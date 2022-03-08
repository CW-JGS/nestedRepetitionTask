using System;

namespace nestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 11;


            int counter = 0;
            int intCounter;

            while(counter < rows && (rows - (2 * counter)) > 0)
            {
                Console.WriteLine("\n");

                intCounter = 0;
                while (intCounter < counter)
                {
                    Console.Write(" ");
                    intCounter++;

                }
                intCounter = 0;
                while (intCounter < (rows - (2 * counter)))
                {
                    Console.Write("x");
                    intCounter++;

                }
                intCounter = 0;
                while (intCounter < counter)
                {
                    Console.Write(" ");
                    intCounter++;

                }
                counter++;
            }
        }
    }
}