using System;

namespace nestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {

            int counterValue = 0;
            int internalCounterValue = 5;
            while(counterValue < 5)
            {
                internalCounterValue = counterValue;
                Console.WriteLine("");
                while (internalCounterValue > 0)
                {
                    Console.Write("x");
                    internalCounterValue--;
                }
                counterValue++;
            }
        }
    }
}