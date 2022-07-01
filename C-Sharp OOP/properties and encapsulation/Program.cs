// C# Access Modifiers: Public , Private , Protected, Internal
// properties and encapsulation
using System;
namespace OOP

{
 
    // C-sharp constructors
    class Car2
    {
        private string name; // field
        public string Name
        {
            get{return name;}
            set{name = value;}
        }
  

    }
    class MianFunc
    {
        static void Main(string[] args)
        {
            Car2 obj = new Car2();
            obj.Name = "ppp";
            Console.WriteLine(obj.Name);
        }

    }


}



