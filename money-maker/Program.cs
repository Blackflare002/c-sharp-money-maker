using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            string stringTotal = Console.ReadLine();
            double doubleTotal = Convert.ToDouble(stringTotal);
            double flooredTotal = Math.Floor(doubleTotal);
            Console.WriteLine($"{stringTotal} is equal to...");
            int goldValue = 10;
            int silverValue = 5;
            double goldCoins = Math.Floor(flooredTotal / goldValue);
            double remainder = flooredTotal % goldValue;
            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;
            Console.WriteLine($"Gold: {goldCoins}");
            Console.WriteLine($"Silver: {silverCoins}");
            Console.WriteLine($"Bronze: {remainder}");
        }
    }
}
