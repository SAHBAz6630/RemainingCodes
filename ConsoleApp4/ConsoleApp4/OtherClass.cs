using System;

public class OtherClass
{
    public void DisplayOtherFields(BaseClass baseClass)
    {
        Console.WriteLine("OtherClass:");
        Console.WriteLine($"PublicField: {baseClass.PublicField}");
        // Console.WriteLine($"PrivateField: {baseClass.PrivateField}"); // Error: Inaccessible due to protection level
        // Console.WriteLine($"ProtectedField: {baseClass.ProtectedField}"); // Error: Inaccessible due to protection level
        Console.WriteLine($"InternalField: {baseClass.InternalField}");
        Console.WriteLine($"ProtectedInternalField: {baseClass.ProtectedInternalField}");
    }
}
