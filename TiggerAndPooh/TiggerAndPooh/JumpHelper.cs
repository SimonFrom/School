using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TiggerAndPooh
{
    public class JumpHelper
    {
        
       
        public static string CalculateMeetingPoint(int tiggerX, int tiggerSpeed, int poohX, int poohSpeed)
        {
            string meetpoint = "";
            int tiggerLoc;
            int poohLoc;


            for (int i = 0; i < 10000; i++)
            {
                tiggerLoc = tiggerX + tiggerSpeed;
                poohLoc = poohX + poohSpeed;

                if (tiggerLoc == poohLoc)
                {
                    meetpoint = $"{tiggerLoc}, {poohLoc}";
                    Console.WriteLine(meetpoint);
                }
                else
                {
                    meetpoint = "NO";
                    Console.WriteLine(meetpoint);
                }
            }
            return meetpoint;
        } 
    }
}
