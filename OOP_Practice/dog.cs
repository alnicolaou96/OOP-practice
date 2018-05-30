using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Dog
    {
        //declare fields
        private int hairLength, height, runningSpeed, weight;

        //declare properties
        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        //prop tab tab
        //public int MyProperty { get; set; }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.runningSpeed = value; }
        }

        //ctr tab tab
        //constructor shortcut
        //declare constructors
        public Dog()
        {
            //default constructor
        }

        public Dog(int hairLength, int height, int runningSpeed, int weight)
        {
            //loaded constructor
            this.weight = weight;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run()
        {
            Console.WriteLine("your dog can run {0} miles per hour \n", runningSpeed);
        }

        public void Bark()
        {
        }

        public void Potty()
        {
        }

        public void Cuddle()
        {
        }

    }
}
