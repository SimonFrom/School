namespace Pr01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Dit fulde navn: ");
            name = Console.ReadLine();
            Console.WriteLine("Du indtastede: " + name);

            string age;

            Console.WriteLine("Din alder: ");
            age = Console.ReadLine();
                      
            
            Console.WriteLine("");
            Console.WriteLine("Dit navn er " + name);
            Console.WriteLine("Din alder er " + age);

            Console.WriteLine($"{name} er {age} år gammel.");
   
            
        }
    }
}
