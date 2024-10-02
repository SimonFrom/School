using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name = "";
        private DateTime birthdate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }

        public int NoOfChildren
        {
            get { return noOfChildren; }
            set { noOfChildren = value; }
        }
        public Person(string name,
            DateTime birthdate,
            double height,
            bool isMarried,
            int noOfChildren)
        {
            Name = name;
            Birthdate = birthdate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
            
        }

        public string MakeTitle()
        {
            birthdate.ToLongDateString();
            height.ToString();
            isMarried.ToString();
            noOfChildren.ToString();
            string title = ($"{name};{birthdate};{height};{isMarried};{noOfChildren}");
            return title;
            
            
        }
    }
}
