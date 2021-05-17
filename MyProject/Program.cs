using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Transport("BMW", "M5", 50, 80, 15);
            string input;
            do
            {
                Console.WriteLine("Please, enter a number:");
                Console.WriteLine("1. Go");
                Console.WriteLine("2. TopUp");
                Console.WriteLine("3. Stop");
                Console.WriteLine("4. Exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        car.Go();
                        break;
                    case "2":
                        car.TopUp();
                        break;
                    case "3":
                        Console.WriteLine("You have stopped the car.");
                        break;
                    case "4":
                        Console.WriteLine("GoodBye!");
                        break;
                    default:
                        Console.WriteLine("Please, enter the number from the list.");
                        break;
                }
            }
            while (input != "4");
        }
    }
}
