using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive = true;
        private int numOranges;
        private int orangesEaten;

        public int SetAge(int age)
        {
            this.age = age;
            return age;
        }
            

        public int GetAge()
        {
            return age;
        }

        public int SetHeight(int height)
        {
            this.height = height;
            return height;
        }

        public int GetHeight()
        {
            return height;
        }

        public bool SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
            return treeAlive;
        }

        public bool GetTreeAlive()
        {
            return treeAlive;
        }

        public int SetNumOranges(int numOranges)
        {
            for (int i = 1; i >= 80; i++)
                this.SetNumOranges(numOranges);
            SetNumOranges(numOranges + 5);
            return numOranges;
        }

        public int GetNumOranges()
        {
            return numOranges;
        }

        public int SetOrangesEaten(int orangesEaten)
        {
            this.orangesEaten = orangesEaten;
            return orangesEaten;
        }

        public int GetOrangesEaten()
        {
            return orangesEaten;
        }

        public int OneYearPasses()
        {
            this.SetAge(this.age + 1);
            return age;
        }
    }
}


