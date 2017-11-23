using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Dog : Animal
    {
        string name;
        string owner;

        public override void move()
        {
            Console.WriteLine("Dog is Running");
        }

        public override void makeNoise()
        {
            Console.WriteLine("Barking! ");
        }
    }
}
