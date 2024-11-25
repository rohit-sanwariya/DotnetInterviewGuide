using ProgrammingwithCSharp.Programming;

namespace DotnetInterviewGuide;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        RefAndOut refAndOut = new RefAndOut();

        int x = 5;
        refAndOut.PassByRef(ref x);
        Console.WriteLine(x);
        refAndOut.PassByOut(out x);
        Console.WriteLine(x);
    }
}