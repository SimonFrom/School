namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            
            DataHandler handler = new DataHandler("Data.txt");
            //handler.SavePerson(person);
            handler.LoadPerson();

            Console.Write("Writing person: ");
            Console.WriteLine(person.MakeTitle());
            //Console.WriteLine(loadedPerson.Name);

            Console.ReadLine();

        }
    }
}
