namespace Pr03Substring__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks for text string
            Console.WriteLine("Insert your text here: ");
            string message = Console.ReadLine();

            //Asks for input about substring length
            Console.WriteLine("Where do you want your substring extract to start?");
            int subStrStart = Convert.ToInt32(Console.ReadLine());

            //Asks for input about substring length
            Console.WriteLine("Where do you want your substring extract to end?");
            int subStrEnd = Convert.ToInt32(Console.ReadLine());

            //Extract substring and length from original
            string substring = message.Substring(subStrStart, subStrEnd);
            int substringlength = substring.Length;

            //Print substring and length to console
            Console.WriteLine("The chosen substring is: {0}. The length is {1}.", substring, substringlength);


        }
    }
}
