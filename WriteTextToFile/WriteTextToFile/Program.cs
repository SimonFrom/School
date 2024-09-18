using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Store the path of the textfile in your system 
        string file = @"C:\Users\simon\Desktop\Dette er en test til at læse og skr.txt";

        // To append text to a file 
        //string text2 = "Daniel Riisager, ID = 2345, COO";
        //File.AppendAllText(file, text2);

         if (File.Exists(file))
         {
             // Store each line in array of strings 
             string[] lines = File.ReadAllLines(file);

                Console.WriteLine(lines[0]);
         }
        Console.WriteLine();



            // To display current contents of the file 
            //Console.WriteLine(File.ReadAllText(file));
            //Console.ReadKey();

        }
}
