// Polymorphism and overriding methods
using System;
namespace OOP

{
 
    // C-sharp inheritance
    class Vehicle
    {
        public string brandName = "xyz";
        public void honk()
        {
            Console.WriteLine(">>>>>>>");
        }
    }

    class Mustang : Vehicle
    {
        public string modelName = "Mustang";
        public void honk()
        {
            Console.WriteLine("!!!!!!!!!!");
        }
    }
    class MianFunc
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            Mustang myCar = new Mustang();
            v.honk();
            myCar.honk();
            Console.WriteLine(myCar.brandName + " : " + myCar.modelName);
        }

    }


}



