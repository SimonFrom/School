namespace Pr03ArealRektangel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Samler input fra bruger i konsollen
            Console.WriteLine("Please input length of the square in cm: ");
            int length = Convert.ToInt32(Console.ReadLine());

            //Samler input fra bruger i konsollen
            Console.WriteLine("Please input width of the square in cm: ");
            int width = Convert.ToInt32(Console.ReadLine());

            //Beregner arealet
            int area = length * width;

            //Skriver arealet ud i konsollen
            Console.WriteLine($"The calculated area is {area} square cm.");
        }
    }
}
