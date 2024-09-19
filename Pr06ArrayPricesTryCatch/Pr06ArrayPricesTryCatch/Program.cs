using System.Numerics;

namespace Pr06ArrayPricesTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool to hold the program running
            bool hold = true;
            
            //Start of program loop
            do
            {
                
                //Asks user what size array they want
                Console.WriteLine("How many prices would you like to input? ");
                //Uses try and catch to secure the correct input format
                try
                {
                    //Takes user input and creates an array of that size
                    int ArraySize = int.Parse(Console.ReadLine());
                    double[] prices = new double[ArraySize];

                    //Loop to start filling array
                    for (int i = 0; i < prices.Length; i++)
                    {
                        Console.WriteLine("Please input a price: \n");
                        prices[i] = Double.Parse(Console.ReadLine());
                    }
                    double sum = 0;

                    //Clear to clean up screen
                    Console.Clear();

                    //Loop to iterate over the array and add them together
                    Array.ForEach(prices, length => sum = sum + length);
                    foreach (double price in prices)
                    {
                        int i = 0;
                        Console.WriteLine($"\n{price}\n");
                        i++;
                    }
                    Console.WriteLine($"The total sum is: {sum}");
                }
                //Error message if input is wrong type
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input. Please use numbers.");
                    Console.WriteLine(e);
                }
            } while (hold == true);




        }
    }
}
