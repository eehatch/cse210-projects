using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new();

        int inputNum = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (inputNum != 0)
        {
            Console.Write("Enter a number: ");
            inputNum = int.Parse(Console.ReadLine());
            if (inputNum != 0)
            {
                numList.Add(inputNum);
            }

        }
        int sum = 0;
        foreach(int item in numList)
        {
            sum = numList.Sum();
        }
            Console.WriteLine($"The sum is {sum}");

            float average = ((float)sum) / numList.Count();
            Console.WriteLine($"The average is: {average}");
            
            int max = numList.Max();
            Console.WriteLine($"The max is: {max}");
    }
}