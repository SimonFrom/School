namespace Pr04Loops_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beder om tekstinput fra bruger
            Console.Write("Indsæt tekst: ");
            //Laver string ud fra konsol
            string str = Console.ReadLine();
            //Laver int med længde fra brugers input string
            int length = str.Length;
            //Laver int med count der ligger en til efter hvert loop
            int count = 0;

            do
            {
                //Tager count og bruger til at udtrække en karakter fra bruger string til chr
                char chr = str[count];
                //Udskriver count og chr
                Console.WriteLine($"{count}: {chr}");
                //Ligger en til count
                count++;
            //Stopper loopet når udtrykket ikke længere er opfyldt
            } while (count < length);
        }
    }
}
