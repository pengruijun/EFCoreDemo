using ConsoleApp.InheritedExample.Lib;

namespace ConsoleApp.InheritedExample;

public class MyRepository : RepositoryBase<MyContext>
{
    public MyRepository(MyContext context) : base(context)
    {
    }

    public void Operation()
    {
        Console.WriteLine(ContextName);
    }
}