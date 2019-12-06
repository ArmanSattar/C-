using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Practice1
{
    class Player
    {
        static void Main(String []args)
        {
            //
            Console.WriteLine("Please enter up to what number you wish to check the prime numbers for:");
            int primeNumberTotal = int.Parse(Console.ReadLine());
            List<int> primeNumberList = new List<int>();
            bool x = false;
            //
            for (int y = 3; y < primeNumberTotal; y++)
            {
                for (int i = 2; i < y - 1; i++)
                {
                    if (y % i == 0)
                    {
                        x = true;
                    }
                }
                if (x == false)
                {
                    primeNumberList.Add(y); 
                }
                x = false;
            }
            primeNumberList.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
