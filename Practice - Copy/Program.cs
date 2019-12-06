using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Program
    {
        static void Main(string []args)
        {
            int frac = 1;
            int denominator = 3;
            int numerator = 1;
            //int fracDem;
            int impFrac;

            while (true)
            {
                impFrac = (frac * denominator) + numerator;
                System.Console.WriteLine($"[{denominator},{impFrac},{impFrac + 1}]");
                frac += 1;
                denominator += 2;
                numerator +=1;
            }
            
        }
    }z