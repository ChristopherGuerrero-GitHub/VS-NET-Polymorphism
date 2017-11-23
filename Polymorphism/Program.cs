using System;

//This program has a sub class Dog that inherits from the parent/super class Animal. Both have same name access method
// move() and makeNoise() using the polymorphism process by using the "virtural" keyword in the parent/super class
// and the "override" keyword in the child/subclass for the same name access method. 

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Dog spot = new Dog();

            spot.move();
            spot.makeNoise();

            Animal pet = new Animal();

            pet.move();
            pet.makeNoise();    
            
            
                
            
        }
    }
}