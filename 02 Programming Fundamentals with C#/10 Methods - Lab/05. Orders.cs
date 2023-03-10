using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());   
            PrintOrder(product, quantity);
        }

        static void PrintOrder(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            Console.WriteLine($"{price * quantity:f2}");
        }
    }
}