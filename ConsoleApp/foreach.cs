namespace ConsoleApp;

public static class Foreach {
    public static void Break()
    {
        var data = Enumerable.Range(0, 10).ToArray();
        foreach (var d in data)
        {
            Console.WriteLine($"start break loop index: {d}");
            if (d > 2) break;
            Console.WriteLine(d);
        }
        Console.WriteLine("finish break loop");
    }
    
    public static void Continue()
    {
        var data = Enumerable.Range(0, 10).ToArray();
        foreach (var d in data)
        {
            Console.WriteLine($"start continue loop index: {d}");
            if (d > 2) continue;
            Console.WriteLine(d);
        }
        Console.WriteLine("finish continue loop");
    }
    
    public static void Return()
    {
        var data = Enumerable.Range(0, 10).ToArray();
        foreach (var d in data)
        {
            Console.WriteLine($"start return loop index: {d}");
            if (d > 2) return;
            Console.WriteLine(d);
        }
        Console.WriteLine("finish return loop");
    }
}