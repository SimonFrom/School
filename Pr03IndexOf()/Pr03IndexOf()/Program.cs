namespace Pr03IndexOf__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks for input from user
            Console.WriteLine("Insert text here: ");
            string message = Console.ReadLine();

            //Asks what char the user wants
            Console.WriteLine("What character would you like to find?");
            
            //Converts string to char
            char userChr = char.Parse(Console.ReadLine());

            //Finds the index of the userChr
            int indexOf = message.IndexOf(userChr);

            //Print to console if userChr is found or is not found
            if (indexOf != -1)
            {

                Console.WriteLine($"You have chosen '{userChr}' and it can be found at position {indexOf}.");
            } else
            {
                Console.WriteLine("Your chosen character was not found.");
            }

        }
    }
}
