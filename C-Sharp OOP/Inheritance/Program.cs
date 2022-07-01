// C# Access Modifiers: Public , Private , Protected, Internal
// properties and encapsulation
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
    }
    class MianFunc
    {
        static void Main(string[] args)
        {
            Mustang myCar = new Mustang();
            myCar.honk();
            Console.WriteLine(myCar.brandName + " : " + myCar.modelName);
        }

    }


}



