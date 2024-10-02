using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTCar
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public int maxSpeed;


        public Car(string argMake,string argModel,int argYear,int argMaxSpeed)
        {
            make = argMake;
            model = argModel;
            year = argYear;
            maxSpeed = argMaxSpeed;

        }

        public void Start()
        {
            Console.WriteLine("Type 1 to start the car \n");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("The car started\n");
            }
            else
            {
                Console.Write("Wrong, restart please");
            }
        }

        public void Stop()
        {
            Console.WriteLine("Type 2 to stop the car\n");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                Console.Write("The car stopped\n");
            }
            else
            {
                Console.Write("Wrong, restart please");
            }
        }

        public void Speed()
        {
            Console.Write("How fast would you like to go?\n");
            var speed = Console.ReadLine();
            Console.WriteLine($"The car is going {speed} km/h.\n");
        }
    }
}
