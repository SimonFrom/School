using System.ComponentModel.Design;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Bool til at program kørende
            bool hold = true;
            
            //do while loop til at genkalde menuen efter regnestykke
            do
            {
                //Menu med valgmuligheder
                Console.Write("Vælg matematisk operator:\n" +
                    "1. Addition\n" +
                    "2. Multiplikation\n" +
                    "3. Divison\n" +
                    "4. Subtraktion\n" +
                    "5. Modulus\n" +
                    "6. Afslut\n");
                //Int til at læse bruger valg
                int choice = int.Parse(Console.ReadLine());
                //If statement til at tjekke om brugeren vælger et tal fra listen
                if (choice >= 1 && choice <= 5)
                {
                    //Console.Clear til at rydde op og beder om input fra brugeren omkring tal til regnestykket
                    Console.Clear();
                    Console.Write("Indlæs første tal: ");
                    float x = float.Parse(Console.ReadLine());

                    Console.Write("Indlæs andet tal: ");
                    float y = float.Parse(Console.ReadLine());
                    Console.Clear();
                    //Henter calculator klassen
                    CalculatorClass calc = new CalculatorClass();
                    //Switch til at bruge den ønskede funktion
                    switch (choice)
                    {
                        case 1:
                            Console.Write($"\n{x} + {y} = ");
                            Console.Write(calc.Add(x, y));
                            Console.WriteLine("\n");
                            break;

                        case 2:
                            Console.Write($"\n{x} * {y} = ");
                            Console.Write(calc.Multiply(x, y));
                            Console.WriteLine("\n");
                            break;

                        case 3:
                            Console.Write($"\n{x} / {y} = ");
                            Console.Write(calc.Divide(x, y));
                            Console.WriteLine("\n");
                            break;

                        case 4:
                            Console.Write($"\n{x} - {y} = ");
                            Console.Write(calc.Subtract(x, y));
                            Console.WriteLine("\n");
                            break;

                        case 5:
                            Console.Write($"\n{x} $ {y} = ");
                            Console.Write(calc.Mod(x, y));
                            Console.WriteLine("\n");
                            break;
                    }

                }//Afslutter programmet ved at ændre hold til false
                else if (choice == 6)
                {
                    Console.Write("Tak for idag");
                    hold = false;
                }
                else//Sikring med forkert input
                {
                    Console.WriteLine("\nForkert input, vælg venligst et tal fra listen\n");
                }
                //While del af loopet til at holde menuen kørende
            }while (hold == true);
        }
    }
}
