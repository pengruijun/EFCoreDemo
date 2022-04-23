using ConsoleApp.InheritedExample.Lib;

namespace ConsoleApp.InheritedExample;

public class MyContext : IContext
{
    public string Name { get; set; } = null!;
}