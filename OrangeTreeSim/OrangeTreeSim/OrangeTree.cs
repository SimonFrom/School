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

        //Simulates one years growth
        public void OneYearPasses()
        {
            //Adds 1 to age
            age++;
            //If age is less than 80 adds 2 to height
            if (age < 80)
            {   
                height += 2;
            
                Console.WriteLine($"The tree's age is {age}, {height} meters tall and have {numOranges} oranges on it.");
                //If age is larger than 1, sets Oranges to 0, OrangesEaten to 0 and sets oranges.
                if (age > 1)
                {
                    numOranges = 0;
                    orangesEaten = 0;
                    numOranges = (age - 1) * 5;
                }
            }
            //If age is 80 KILLS the tree and sets Oranges to 0
            else if (age >= 80)
            {
                numOranges = 0;
                treeAlive = false;
            }
        }

        //Takes int from unit test and adds and subtracts
        public void EatOrange(int count)
        {
            orangesEaten += count;
            numOranges -= count;
            
        }
    }
}


