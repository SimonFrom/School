using System.IO;

namespace HydacTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string HydacGuests = @"C:\Users\simon\Desktop\Hydac Projekt\HydacGuests.txt";
            string HydacLog = @"C:\Users\simon\Desktop\Hydac Projekt\HydacLog.txt";
            Console.Write("Hello and welcome to Hydac!\n" +
                "Please input your name: ");
            //Saves userinput
            string GuestName = Console.ReadLine();


            //Saves userinput
            Console.Write("Please input your company: ");
            string GuestCompany = Console.ReadLine();

            //Asks user if they recieved safety folder
            Console.Write("Have you recieved the safety folder?: \nYes or No? ");
            string safetyFolder = Console.ReadLine();
            if (safetyFolder == "Yes")
            {
                bool safetyBool = true;
            }
            else if (safetyFolder == "No")
            {
                bool safetyBool = false;
            }
            DateTime Now = DateTime.Now;
            string Time = DateTime.Now.ToString();
            
            string[] GuestCheckIn = { Time };
            File.AppendAllLines(HydacLog, new string[] { GuestName, Time });


            //Writes all info to document
            File.AppendAllLines(HydacGuests,new string[] {GuestName, GuestCompany});
            //File.AppendAllLines(HydacGuests, GuestName);
            
            









        }
    }
}
