using System;
using System.Collections.Generic;
using System.Timers;

namespace NumberRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputNumber = Convert.ToInt32(input);
            string input2 = Console.ReadLine();
            int inputNumber2 = Convert.ToInt32(input2);

            List<int> intList = new List<int>();
            for (int i = inputNumber; i < inputNumber2 + 1; i++)
            {
                intList.Add(i);
            }

            int time = DateTime.Now.Millisecond;
            int output = intList[(time * inputNumber2)/1000];
            Console.WriteLine(output);
        }
    }
}
