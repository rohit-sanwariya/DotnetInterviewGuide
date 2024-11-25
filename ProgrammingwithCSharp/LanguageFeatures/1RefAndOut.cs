namespace ProgrammingwithCSharp.Programming;

public class RefAndOut {
    public void PassByRef(ref int number)
    {
        number += 10; // Modify the value
        Console.WriteLine($"Inside PassByRef method: {number}");
    }

    // Method demonstrating the use of out
    public void PassByOut(out int number)
    {
        number = 20; // Must assign a value before the method ends
        Console.WriteLine($"Inside PassByOut method: {number}");
    }
}