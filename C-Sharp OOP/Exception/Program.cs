// C# Exceptions

using System.IO;
try
{
    int[] test = { 0, 1, 2, 3, 4 };
    Console.WriteLine(test[10]);

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


