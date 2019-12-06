using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        //User inputs how many times they want the array to run for
        System.Console.WriteLine("Please enter how many times you want the Fibonacci Sequence to run for (Integer Value):");
        ulong arrLength = ulong.Parse(Console.ReadLine());

        //declaring array with the length the user inputted
        ulong[] arr = new ulong[arrLength];
        //Adding the first 3 terms in the fibb sequence
        arr[0] = 0; arr[1] = 1; arr[2] = 1;
        //Loops through each index of the array and calculates the fibonacci value of it
        for (ulong i = 2; i < arrLength + 1; i++)
        {
            arr[i] = arr[i-2] + arr[i-1];
            Console.WriteLine($"The {i} term of the sequence is {arr[i]}");
        }
        //Waits for input to kill the program
        Console.ReadLine();
    }
}