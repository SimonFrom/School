namespace Pr06ProductPrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prod1 = 23.95;
            double prod2 = 59.95;
            double prod3 = 1.95;
            double prod4 = 79.95;
            double prod5 = 49.95;

            Console.WriteLine($"{prod1}\n{prod2}\n{prod3}\n{prod4}\n{prod5}\n");
            double averagePrice = ((prod1+prod2+prod3+prod4+prod5) / 5);

            Console.Write($"The average product price is: {averagePrice}");
        }
    }
}
