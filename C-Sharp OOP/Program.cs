// Class Members
using System;
namespace OOP

{

    class Car
    {
        string color;                 // field
        int maxSpeed;                 // field
        public void carMethod()    // method
        {
            Console.WriteLine("This is the method of Car class");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.carMethod();  // Call the method
        }
    }


}



