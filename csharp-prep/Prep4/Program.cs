using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        
        List<int> numbers = new List<int>();
        Console.WriteLine(numbers.Count);
        
        int newNumber = -1;
        while (newNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string response = Console.ReadLine();

            newNumber = int.Parse(response);

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }
        int sum = 0;
        foreach (number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The Sum is {sum:.0f}");
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
            Console.WriteLine($"The largest number is {largest}");      

    }
}