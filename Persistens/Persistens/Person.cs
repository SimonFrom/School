using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private int noOfChildren = 0;
        public string title = "";
        

        public string Name
        {
            get { return name; }

            set
            {
                name = value;
                if (name.Length == 0)
                {
                    throw new Exception("Name cannot be empty");
                }
            }
        }

        public DateTime BirthDate
        {
            get { return birthdate; }
            set
            {
                birthdate = value;
                if (birthdate.Year < 1900)
                {
                    throw new Exception("Year must be after 1900");
                }
            }
        }

        public double Height
        {
            get { return height; }
            set 
            {
                height = value;
                if (height < 0)
                {
                    throw new Exception("Heigth must be more than 0");
                }                           
            }
        }

        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }

        public int NoOfChildren
        {
            get { return noOfChildren; }
            set
            {
                noOfChildren = value;
                if (noOfChildren < 0)
                {
                    throw new Exception("Number of children cannot be negative");
                }
            }
        }
        public Person(string name,
            DateTime birthdate,
            double height,
            bool isMarried,
            int noOfChildren)
        {
            Name = name;
            BirthDate = birthdate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
            
        }

        public Person(string name,
            DateTime birthdate,
            double height,
            bool isMarried)
        {
            this.Name = name;
            this.BirthDate = birthdate;
            this.Height = height;
            this.IsMarried = isMarried;
        }

        
        public string MakeTitle()
        {
            Person[] personsArray = new Person[10];
            birthdate.ToLongDateString();
            height.ToString();
            isMarried.ToString();
            noOfChildren.ToString();
            string title = ($"{name};{birthdate};{height};{isMarried};{noOfChildren}");           
            return title;
        }
        
    }
}
