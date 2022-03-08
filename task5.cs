using System;

namespace nestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfXs = int.Parse(Console.ReadLine());
            int counterValue = 0;
            int internalCounterValue = 5;
            while(counterValue < noOfXs)
            {
                internalCounterValue = counterValue;
                Console.WriteLine("");
                while (internalCounterValue > noOfXs)
                {
                    Console.Write("x");
                    internalCounterValue--;
                }
                counterValue++;
            }
        }
    }
}

 