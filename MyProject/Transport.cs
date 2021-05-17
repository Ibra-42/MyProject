using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Transport
    {
        public string Mark;
        public string Model;
        public decimal CurrentFuel;
        public decimal MaxCapacity;
        public decimal FuelEff;

        public Transport(string mark, string model, decimal currentFuel, decimal maxCapacity, decimal fuelEff)
        {
            Mark = mark;
            Model = model;
            CurrentFuel = currentFuel;
            MaxCapacity = maxCapacity;
            FuelEff = fuelEff;
        }

        public void Go()
        {
        Back:
            Console.WriteLine("Please, enter the distance length:");
            string neededLength = Console.ReadLine();

            try
            {
                decimal neededLengthD = Convert.ToDecimal(neededLength);
                if (CurrentFuel >= neededLengthD * FuelEff / 100)
                {
                    CurrentFuel -= neededLengthD * FuelEff / 100;
                    Console.WriteLine($"You pave passed {neededLengthD} km. There are {CurrentFuel} litres left.");
                }
                else
                {
                    Console.WriteLine("There is not enough fuel in tank. Please, fill it.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please, enter a numeric number.");
                goto Back;
            }
        }
        public void TopUp()
        {
            decimal neededFuelD = 0;
            while (neededFuelD == 0)
            {
                Console.WriteLine("How much litres do yo want to add?");
                string neededFuelEff = Console.ReadLine();
                try
                {
                    neededFuelD = Convert.ToDecimal(neededFuelEff);
                    if(MaxCapacity >= neededFuelD + CurrentFuel)
                    {
                        CurrentFuel += neededFuelD;
                        Console.WriteLine($"You have added {neededFuelD} litres. There are {CurrentFuel} litres in tank.");
                    }
                    else
                    {
                        Console.WriteLine("The tank capacity isn't enough!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter a numeric number");
                }
            }
        }
    }
}
