// C# Files

using System.IO;
string testTxt = "test text";
File.WriteAllText("test.txt", testTxt);
string readTxt = File.ReadAllText("test.txt");
Console.WriteLine(readTxt);
