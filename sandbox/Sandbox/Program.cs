using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess Three Dice!");
        //&nbsp;The&nbsp;computer&nbsp;throws&nbsp;three&nbsp;dice,
        Random randomGenerator = new();
        int d1 = randomGenerator.Next(1, 7);
        int d2 = randomGenerator.Next(1, 7);
        int d3 = randomGenerator.Next(1, 7);
        //&nbsp;sorts&nbsp;them&nbsp;in&nbsp;order&nbsp;(smallest&nbsp;to&nbsp;largest),
        if (d2 > d3)
        {
            (d2, d3) = (d3, d2);
        }
        if (d1 > d3)
        {
            (d1, d3) = (d3, d1);
        }
        if (d1 > d2)
        {
            (d1, d2) = (d2, d1);
        }
        //&nbsp;and&nbsp;outputs&nbsp;their&nbsp;sum.
        //Console.WriteLine($"{d1} {d2} {d3}"); // Cheat!
        Console.WriteLine($"Their sum is: {d1 + d2 + d3}.");

        //&nbsp;Loop:&nbsp;&nbsp;&nbsp;&nbsp;
        bool playing = true;
        while (playing)
        {
            //&nbsp;Prompt&nbsp;the&nbsp;user&nbsp;to&nbsp;guess&nbsp;the&nbsp;value&nbsp;of&nbsp;each&nbsp;die,&nbsp;&nbsp;&nbsp;&nbsp;
            //&nbsp;from&nbsp;smallest&nbsp;to&nbsp;largest&nbsp;(non-decreasing).
            Console.Write("Guess the values of each of the three dice,");
            Console.WriteLine(" from smallest to largest.");
            Console.Write("First die: ");
            int guess1 = int.Parse(Console.ReadLine());
            Console.Write("Second die: ");
            int guess2 = int.Parse(Console.ReadLine());
            Console.Write("Third die: ");
            int guess3 = int.Parse(Console.ReadLine());

            //&nbsp;If&nbsp;the&nbsp;guesses&nbsp;are&nbsp;out&nbsp;of&nbsp;order, prompt&nbsp;to&nbsp;guess&nbsp;again.
            if (guess1 > guess2 || guess2 > guess3) {
                Console.Write("Those weren't in order from smallest to largest.");
            }

            //&nbsp;If&nbsp;the&nbsp;guesses&nbsp;don't&nbsp;produce&nbsp;the&nbsp;desired&nbsp;sum, prompt&nbsp;to&nbsp;guess&nbsp;again.
            else if (guess1+guess2+guess3 != d1+d2+d3)
            {
                Console.Write($"Those don't add up to {d1+d2+d3}.");
            }

            //&nbsp;If&nbsp;the&nbsp;guesses&nbsp;are&nbsp;incorrect, prompt&nbsp;to&nbsp;guess&nbsp;again.
            else if (guess1 != d1 || guess2 != d2 || guess3 != d3)
            {
                Console.Write("Good guess, but incorrect.");
            }
            else
            {
                //&nbsp;If&nbsp;the&nbsp;guesses&nbsp;are&nbsp;correct,&nbsp;the&nbsp;user&nbsp;wins!
                Console.WriteLine("Success! Thank you for playing.");
                playing=false;
            }
            if (playing)
            {
                Console.WriteLine(" Try again.");
            }
        }
    }
}