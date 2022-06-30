using System;
namespace OOP

{
 
    // C-sharp constructors
    class Car2
    {
        public string model;
        public Car2()
        {
            model = "test model";
        }

        static void Main(string[] args)
        {
            Car2 obj = new Car2();
            Console.WriteLine(obj.model);
        }

    }


}



