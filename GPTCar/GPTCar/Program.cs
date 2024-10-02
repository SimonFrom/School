namespace GPTCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Honda ", "Civic ", 1998, 230);
            Console.WriteLine(car.make + car.model + car.year + " " + car.maxSpeed);

            car.Start();
            
            car.Speed();

            car.Stop();


        }
    }
}
