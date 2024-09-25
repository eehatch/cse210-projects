using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputNum = 1;
        while (inputNum != 0)
        {

        }
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            Console.Write("Enter a number: ");
            int newnum = int.Parse(Console.ReadLine());

            numbers.Add(newnum);

            Console.WriteLine(numbers.Count);
    }
}