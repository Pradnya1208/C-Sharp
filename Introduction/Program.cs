// Basics of C#
using System;
namespace helloWorld
{
    class tutorial
    {
       static void Main(string[] args)
        {
            string name = "Pradnya";
            const int roll = 397250;
            int myInt = 30;
            double myDouble = myInt;
            Console.WriteLine(myInt + " , " + myDouble); // Implicit casting

            double myDoubleX = 9.72;
            int myIntX = (int)myDoubleX;
            Console.WriteLine("myIntX: " + myIntX); // Explicit TypeCasting

            // Type Conversion Methods
            int myInt_x = 9;
            double myDouble_x = 9.5;
            bool xy = true;
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToString(xy));

            // User Input 
            Console.WriteLine("Enter your name: ");
            String name_ = Console.ReadLine();
            Console.WriteLine("Hello " + name_);
            Console.WriteLine(name + " enter your age");
            int age_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have entered age : " + age_);

            // Operators
            int x = 15;
            x %= 3;
            Console.WriteLine("x : " + x);

            // Math
            Console.WriteLine(Math.Min(15, 26));
            Console.WriteLine(Math.Abs(-2.3));
            Console.WriteLine(Math.Sqrt(121));

            // Strings
            string txt = "hello world";
            Console.WriteLine(txt.ToUpper() + " | Length of the string is: " + txt.Length);
            Console.WriteLine(String.Concat(txt, " of strings"));

            // String interpolation
            string s1 = "string";
            string s2 = "interpolation";
            string ip = $"interpolated string is : {s1} {s2}";
            Console.WriteLine(ip); //Console.WriteLine($"interpolated string is : {s1} {s2}");

            // Finding index and a substring in a string
            Console.WriteLine(s1.Substring(s1.IndexOf("n")));

            // special characters
            Console.WriteLine("Hello there welcome to \"World\" of programming");
            string a, b;
            a = b = "10";
            string c = a + b;
            Console.WriteLine("String addition is : " + c);

            // Booleans
            Console.WriteLine(10 > 5);

            // Conditions and if statements in C-Sharp
            if (c == "1011")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            int time_ = 8;
            string result = (time_ <= 12) ? "Good morning" : "Good Day";
            Console.WriteLine(result);

            // Switch Statements
            int day = 6;
            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    break;

            }

            // While Loop
            int k = 0;
            while (k < 5)
            {
                Console.WriteLine(" " + k);
                ++k;
            }

            // do-while loop
            int j = 10;
            do
            {
                Console.WriteLine(" " + j);
                j--;
            }
            while (j > 5);

            Console.Write("Hello there " + name + " " + roll);

            // For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i : " + i);

            }

            // Foreach loop
            string[] rights = {"Liberty", "Equality", "Fraternity"};
            foreach (string r in rights)
            {
                Console.WriteLine(r);
            }

            // Break and Continue
            for(int i=0; i<=10; i++)
            {
                if(i==3)
                {
                    break;

                }
                Console.WriteLine("value of i : " + i);
            }

            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;

                }
                Console.WriteLine("value of i (cont): " + i);
            }
        }
        
    }
}

