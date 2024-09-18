using System;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool on = true;
            do
            {
                string message = "";
                //Udskriver en menu man kan vælge fra
                Console.WriteLine("Min fantastiske menu:");
                Console.WriteLine("");
                Console.WriteLine(
                    "1. Gør dit \n" +
                    "2. Gør dat \n" +
                    "3. Gør noget \n" +
                    "4. Få svaret på livet, universet og alting \n" +
                    "5. Afslut program \n\n" +
                    "Tryk menu punkt 1, 2, 3, 4 eller 5\n");
                //Konverterer string til int

                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 5)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Punkt 1 er valgt. Gør dit.");
                            break;

                        case 2:
                            Console.WriteLine("Piunkt 2 er valgt. Gør dat.");
                            break;

                        case 3:
                            Console.WriteLine("Punkt 3 er valgt. Gør noget.");
                            break;

                        case 4:
                            Console.WriteLine("42");
                            break;
                    }
                }
                else if (choice == 5)
                {
                    on = false;
                }
                else
                {
                    Console.WriteLine("Vælg venligst et tal fra listen");
                }
            }while (on == true);    
        }
    }
}
