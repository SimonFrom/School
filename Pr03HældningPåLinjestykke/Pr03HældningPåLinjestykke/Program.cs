namespace Pr03HældningPåLinjestykke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start coordinate for X
            Console.WriteLine("Input startpoint for x coordinate: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            //Start coordinate for Y
            Console.WriteLine("Input startpoint for y coordinate: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            //End coordinate for X
            Console.WriteLine("Input endpoint for x coordinate: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            //End coordinate for Y
            Console.WriteLine("Input endpoint for y coordinate: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //Calculated slope
            double slope = (y2 - y1) / (x2 - x1);

            //Output to console
            Console.WriteLine(
                $"The slope for the line with the following coordinates, {x1}.{y1} and {x2}.{y2} ,is: {slope}");
        }
    }
}
