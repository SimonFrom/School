using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        //Age
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //Height
        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        //TreeAlive
        private bool treeAlive;

        public bool TreeAlive
        {
            get { return treeAlive; }
            set { treeAlive = false; }
        }

        //NumOranges
        private int numOranges;

        public int NumOranges
        {
            get { return numOranges; }
        }

        //OrangesEaten
        private int orangesEaten;

        public int GetOrangesEaten
        {
            get { return orangesEaten; }
        }

        public void OneYearPasses()
        {
            age++;
            if (age < 80)
            {
                
                height += 2;
            
                Console.WriteLine($"The tree's age is {age}, {height} meters tall and have {numOranges} oranges on it.");
                if (age > 1)
                {
                    numOranges = 0;
                    orangesEaten = 0;
                    numOranges = (age - 1) * 5;
                }
            }
            else if (age >= 80)
            {
                numOranges = 0;
                treeAlive = false;
            }
        }

        public void EatOrange(int count)
        {
            orangesEaten += count;
            numOranges -= count;
            
        }
    }
}


