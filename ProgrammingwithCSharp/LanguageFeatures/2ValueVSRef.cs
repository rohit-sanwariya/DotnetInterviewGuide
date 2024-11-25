namespace ProgrammingwithCSharp.LanguageFeatures;

public class ValueVSRef {

    public void ShowDiffBetweenValueAndRef()
    {
        // stored on stack,contains actual data , change in original value doesn't change the copied value,
        // e.g. int,float,struct,enums are all value types.
        int valType = 10;
        int x = valType;
        valType = 12;
        Console.WriteLine($"{x} remains 10 even after the last line modifies the val type");

        // stored on stack,contains actual data , change in original value doesn't change the copied value,
        // e.g. int,float,struct,enums are all value types.
        var refType = new Person { Name = "Alice Cooper" };
        var y = refType;
        refType.Name = "Alice Cooper Modified";
        Console.WriteLine(
        $"""{
            y.Name
        } we modified the refType and it got reflected in y""" );
    }

    private record Person
    {
        public required string Name { get; set; }
    }
}