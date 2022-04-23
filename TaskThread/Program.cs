// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("main1 Thread Id: " + Thread.CurrentThread.ManagedThreadId);
//await TestAsync();
var test = TestAsync();
await test;

Console.WriteLine("main2 Thread Id: " + Thread.CurrentThread.ManagedThreadId);
//Test();

async Task TestAsync()
{
    Console.WriteLine("testasync1 thread Id: " + Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(500);
    Console.WriteLine("testasync2 thread Id: " + Thread.CurrentThread.ManagedThreadId);
}

void Test()
{
    Console.WriteLine("test1 thread Id: " + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("test2 thread Id: " + Thread.CurrentThread.ManagedThreadId);
}