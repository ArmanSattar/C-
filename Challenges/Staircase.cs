using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Arman
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter how many rows you would like:");
            int rowsInput = int.Parse(Console.ReadLine());
            for (int rows = 0; rows < rowsInput; rows++)
            {
                for (int space = rows; space < rowsInput; space++)
                {
                    Console.Write(" ");
                }
                for (int columns = 0; columns < rows + 1; columns++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}