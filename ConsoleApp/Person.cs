namespace ConsoleApp;

public class Person
{
    
    public string Name { get; set; } = null!;
    public int Age { get; set; } = 100;

    public Address address { get; set; } = null!;

    // public override int GetHashCode()
    // {
    //     return base.GetHashCode();
    // }
}

public class Student : Person
{
    public string StudentId { get; set; } = null!;
}

public class Address
{
    public int Postcode { get; set; }
}

public static class Test
{
    public static void PrintPerson(Person person)
    {
        var result = person.Name.Length;
        var result1 = person.address.Postcode;
    }

    public static void PrintStudent(Student student)
    {
        
    }
}