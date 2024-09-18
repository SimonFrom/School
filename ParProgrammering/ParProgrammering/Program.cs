namespace ParProgrammering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Spørger om navn input fra brugeren
            Console.WriteLine("Hvad er dit navn? ");
            string name = Console.ReadLine();

            //Spørger om alder input fra brugeren
            Console.WriteLine("Hvad er din alder? ");
            
            //Konverterer fra string til int
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);
            string message = "";

            if (ageInt >= 0 && ageInt <= 12)
            {
                message = ("et barn.");
            }
            else if (ageInt >= 13 && ageInt <= 19)
            {
                message = ("en teenager.");
            }
            else if (ageInt >= 20 && ageInt <= 25)
            {
                message = ("en studerende.");
            }
            else if (ageInt >= 26 && ageInt <= 67)
            {
                message = ("i arbejde.");
            }
            else if (ageInt > 67)
            {
                message = ("en pensionist.");
            }
                        
            //Skriver i konsollen
            Console.WriteLine($"Hej {name} og din alder er {ageInt} år gammel og du er {message}");

        }
    }
}
