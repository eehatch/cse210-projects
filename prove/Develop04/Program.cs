using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Write("Menu Options: \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            Console.ReadLine(); 
            
        }
        static void StartMessage(string StartMessage)
        {
            Activity listing1 = new Listing("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Activity breathing1 = new Breathing("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Activity reflection1 = new Reflection("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
            listing1.StartMessage();
            breathing1.StartMessage();
            reflection1.StartMessage();
            
        } 
        
    }
}