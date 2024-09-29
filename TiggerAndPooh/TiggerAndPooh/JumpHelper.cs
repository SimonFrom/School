using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TiggerAndPooh
{
    public static class JumpHelper
    {
        
       
        public static string CalculateMeetingPoint(int tiggerX, int tiggerSpeed, int poohX, int poohSpeed)
        {
            string meetpoint = "";         
            for (int i = 0; i < 10000; i++)
            {                
                tiggerX += tiggerSpeed;
                poohX += poohSpeed;

                if (tiggerX == poohX)
                {
                    meetpoint = $"{tiggerX},{poohX}";                    
                    return meetpoint; 
                }
                if (tiggerX != poohX)
                {
                    meetpoint = "NO";                    
                }                
            }
            Console.WriteLine(meetpoint);
            return meetpoint;
        } 
    }
}
