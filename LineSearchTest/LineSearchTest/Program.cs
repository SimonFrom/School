using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool hold = true;
        if (hold == true)
        {
            //Path to file
            string EmployeeInfo = @"C:\Users\simon\Desktop\Hydac Projekt\HydacGuests.txt";
            string LogFile = @"C:\\Users\\simon\\Desktop\Hydac Projekt\HydacLog.txt\";

            Console.Write("Hello! Welcome to HYDAC.\n" +
                "Please input your name so that the system can find you: ");
            //Inputs the name into searchtext and checks file
            string searchText = Console.ReadLine();

            // Call the function to search the file and get the matching lines
            List<string> matchingLines = SearchFileForText(EmployeeInfo, searchText);

            // Check if there is at least one match
            if (matchingLines.Count > 0)
            {
                // Print the first matching line
                Console.WriteLine(matchingLines[0]);
            }
            else
            {
                Console.WriteLine("No matching lines found.");
            } 
        }
    }

    static List<string> SearchFileForText(string filePath, string searchText)
    {
        // Create a list to store matching lines
        List<string> matchingLines = new List<string>();

        // Read all lines from the file
        string[] lines = File.ReadAllLines(filePath);

        // Loop through each line
        foreach (string line in lines)
        {
            // Check if the line contains the search text (case-insensitive)
            if (line.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                matchingLines.Add(line);
            }
        }

        // Return the list of matching lines
        return matchingLines;
    }
}
