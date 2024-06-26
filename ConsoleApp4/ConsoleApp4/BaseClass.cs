using System;

public class BaseClass
{
    public int PublicField = 1;            
    private int PrivateField = 2;         
    protected int ProtectedField = 3;      
    internal int InternalField = 4;        
    protected internal int ProtectedInternalField = 5; 

    public void DisplayFields()
    {
        Console.WriteLine("BaseClass:");
        Console.WriteLine($"PublicField: {PublicField}");
        Console.WriteLine($"PrivateField: {PrivateField}");
        Console.WriteLine($"ProtectedField: {ProtectedField}");
        Console.WriteLine($"InternalField: {InternalField}");
        Console.WriteLine($"ProtectedInternalField: {ProtectedInternalField}");
    }
}
