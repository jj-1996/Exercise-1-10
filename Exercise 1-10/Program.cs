using System;

namespace Exercise_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 2;
            int numMembers = 100;

            for(int i = 0; i < numMembers; i++)
            {
                int num = startingNumber + i;

                if((i % 2) != 0)
                {
                    num = 0 - num;
                }

                Console.Write(num.ToString());

                if (i < (numMembers - 1)) Console.Write(", ");
            }

            Console.ReadKey();
        }
    }
}
