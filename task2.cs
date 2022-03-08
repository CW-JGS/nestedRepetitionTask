using System;

namespace nestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterValue = 0;
            int internalCounterValue = 0;
            while(counterValue < 4)
            {
                Console.WriteLine("");
                internalCounterValue = counterValue;
                while (internalCounterValue < 4)
                {
                    Console.Write("x");
                    internalCounterValue++;
                }
                counterValue++;
            }
        }
    }
}