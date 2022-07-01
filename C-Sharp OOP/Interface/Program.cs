// C# Interface

using System;
namespace OOP

{
    interface IAnimal
    {
        public void interfaceMethod();//interface method does not have a body

    }
    class Dog : IAnimal
    {
        public void interfaceMethod()
        {
            Console.WriteLine("This is the definition of the interface class method");
        }
    }

    class MianFunc
    {
        static void Main(string[] args)
        {
            //Animal anim = new Animal();// cannot create an instance of the abstract type or interface Animal
            Dog dog = new Dog();
            dog.interfaceMethod();
           
        }

    }


}



