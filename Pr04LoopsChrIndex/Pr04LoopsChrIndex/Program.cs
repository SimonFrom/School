namespace Pr04LoopsChrIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beder om tekst fra bruger
            Console.Write("Indlæs tekst: ");
            //Læser tekst i konsol vindue
            string str = Console.ReadLine();
            //Bestemmer hvilke karakterer der bliver udskrevet
            char ch2 = str[2];
            char ch4 = str[4];
            char ch6 = str[6];
            //Skriver resultat ud i konsol
            Console.WriteLine($"Karakter 2, 4 og 6 er henholdsvis {ch2}, {ch4} og {ch6}");
        }
    }
}
