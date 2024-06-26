using System;

public class DerivedClass : BaseClass
{
    public void DisplayDerivedFields()
    {
        Console.WriteLine("DerivedClass:");
        Console.WriteLine($"PublicField: {PublicField}");
        // Console.WriteLine($"PrivateField: {PrivateField}"); // Error: Inaccessible due to protection level
        Console.WriteLine($"ProtectedField: {ProtectedField}");
        Console.WriteLine($"InternalField: {InternalField}");
        Console.WriteLine($"ProtectedInternalField: {ProtectedInternalField}");
    }
}
