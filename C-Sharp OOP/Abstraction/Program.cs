// Abstraction

using System;
namespace OOP

{
 
    abstract class Animal
    {
        public abstract void animalSound();
        public void justMethod()
        {
            Console.WriteLine("xxxxxxxxxxx");

        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("This is the definition of the Abstract class method");
        }
    }

    class MianFunc
    {
        static void Main(string[] args)
        {
            //Animal anim = new Animal();// cannot create an instance of the abstract type or interface Animal
            Dog dog = new Dog();
            dog.animalSound();
            dog.justMethod();  
        }

    }


}



