// C# Enum

using System;
namespace OOP

{
    class EnumClass
    {
        enum Levels
        {
            small,
            medium,
            large
        }

        static void Main(string[] args)
        {
            Levels myElem = Levels.medium;
            //Console.WriteLine(myElem);
            switch(myElem)
            {
                case Levels.small:
                    Console.WriteLine("small");
                    break;
                case Levels.medium:
                    Console.WriteLine("medium");
                    break ;
                case Levels.large:
                    Console.WriteLine("large");
                    break;
                default:
                    break;
            
            }
        }
    }



}



