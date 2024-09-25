using System;
using System.Collections.Generic;
using System.Linq;
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
        private bool treeAlive = true;

        public bool TreeAlive
        {
            get { return treeAlive; }
            set { treeAlive = value; }
        }

        //NumOranges
        private int numOranges;

        public int NumOranges
        {
            get { return numOranges; }
            set { numOranges = value; }
        }

        //OrangesEaten
        private int orangesEaten;

        public int OrangesEaten
        {
            get { return orangesEaten; }
            set {  orangesEaten = value; }
        }

        public int EatOrange(int i)
        {
            int count = orangesEaten;
            return count;
        }

        public void OneYearPasses()
        {
            {
                
                if (age < 1)
                {
                    Age += 1;
                    height += 2;
                    Console.WriteLine($"The tree's age is {age}, {height} meters tall and does not have any oranges on it yet.");
                    
                }
                else if (age >= 1)
                {
                    Age += 1;
                    Height += 2;
                    NumOranges += 5;
                    Console.WriteLine($"The tree's age is {age}, {height} meters tall and have {numOranges} oranges on it.");
                    //break;
                }
                else if (age > 80)
                {
                    TreeAlive = true;
                    Console.WriteLine("The tree is dead, mourn it, chop it up.. I don't care.");
                }
            }
        }


      
    }   
}

