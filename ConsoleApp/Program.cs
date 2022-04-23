// See https://aka.ms/new-console-template for more information

using ConsoleApp;

// Gender? gender = null;
//
// string result1;
// switch (gender)
// {
//     case Gender.Female:
//         result1 = "Female";
//         break;
//     case Gender.Male:
//         result1 = "Male";
//         break;
//     default:
//         result1 = "Others";
//         break;
// }
//
// Console.WriteLine($"result1: {result1}");
//
// string result = gender switch
// {
//     Gender.Female => "Female",
//     Gender.Male => "Male",
//     _ => "Others"
// };
//
// Console.WriteLine($"result: {result}");
//
// int middle = 100;
// string result2 = middle switch
// {
//     < 10 => "less",
//     10 => "equal",
//     > 10 => "greater",
// };
// Console.WriteLine($"result2: {result2}");
// Console.WriteLine("Hello, World!");

// var person1 = new Person()
// {
//     Name = "ruijun",
//     Age = 44
// };
// var person2 = new Person()
// {
//     Name = "oscar",
//     Age = 11
// };
// var person3 = new Person()
// {
//     Name = "ruijun",
//     Age = 44
// };
// var data = new Dictionary<Person, int>()
// {
//     {person1, 40},
//     {person2, 10}
// };
//
//
//
// Console.WriteLine(data[person1]);
// Console.WriteLine(data[person2]);
// Console.WriteLine(data[person3]);

// Foreach.Break();
// Console.WriteLine("-------------------------");
// Foreach.Continue();
// Console.WriteLine("-------------------------");
// Foreach.Return();
// Console.WriteLine("-------------------------");

var numbers = Iterator.GetSampleNumbers();
while (numbers.MoveNext())
{
    var number = numbers.Current;
    Console.WriteLine(number);
}
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }
// var numbers = Enumerable.Range(1, 10);
// var enumerator = numbers.GetEnumerator();
// while (enumerator.MoveNext())
// {
//     var number = enumerator.Current;
//     Console.WriteLine(number);
// }