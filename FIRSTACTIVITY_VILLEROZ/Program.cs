using System;

namespace Divisblebyfive
{
    class program
    {
        static void Main(string[] args)
        {
            int first = 1;

            Console.WriteLine("======================================");
            Console.WriteLine("  Display Odd numbers divisible by 5");
            Console.WriteLine("======================================");


            for (first = 1; first <= 300; first++)
            {
                if (first % 5 == 0)
                {
                    Console.WriteLine(first);

                }
                first++;
            }
        }
    }
}







