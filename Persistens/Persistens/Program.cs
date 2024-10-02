namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Simon", new DateTime(1950, 10, 02), 175, true, 2);
            
            //Person person = new Person();
            Console.WriteLine(person.MakeTitle());
        }
    }
}
