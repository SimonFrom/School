using System.Numerics;

namespace Pr06ArrayPrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = new double[5];
            
            //Loop to start filling array
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Please input a price: ");
                prices[i] = Double.Parse(Console.ReadLine());
            }
            double sum = 0;

            //Loop to iterate over the array and add them together
            Array.ForEach(prices, i => sum = sum + i);
            foreach (double price in prices)
            {
                int i = 0;
                Console.WriteLine($"{price}\n");
                i++;
            }
            Console.WriteLine($"The total sum is: {sum}");




        }
    }
}
