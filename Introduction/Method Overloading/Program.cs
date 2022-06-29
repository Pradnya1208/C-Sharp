
using System;
namespace OOP

{
    class Program
    {
        // Method Overloading in C-sharp

        static int MyMethod(int x)
        {
            return x+1;
        }
        static double MyMethod(double x1)
        {
            return x1;
        }

        static string MyMethod(string x2)
        {
            return x2;

        }



        static void Main(string[] args)
        {
          
            string x2_ = MyMethod("Helllooo");
            double x1_ = MyMethod(9.5);
            int x_ = MyMethod(10);
            Console.WriteLine(x2_);
            Console.WriteLine(x1_);
            Console.WriteLine(x_);

        }

   


    }
    

}



