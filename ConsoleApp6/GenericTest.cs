namespace ConsoleApp6;

public class GenericTest<T>
{
    public T Model { get; set; }
}

public class Person
{
    public string Surname { get; set; }

    public string Print()
    {
        
        return GetType().Name + ": " + ToString();
    }
}

