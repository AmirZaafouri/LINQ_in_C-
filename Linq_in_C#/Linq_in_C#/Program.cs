// See https://aka.ms/new-console-template for more information
using Linq_in_C_.main;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");
// Reason reason = new Reason();
//reason.FindPeople();
//Practice.HandleStringOp(); // ✅ Correct
int[] array = { 0,1, 2, 3, 4, 5,6,7,8,9 };
int[] array3 = { 1,5, 5, 9, 4, 5,6,7,8,9 };
int[] array2 = { 9,8, 6, 5};

array.Where(x => x % 2 == 0)
    .ToList()
    .ForEach(Console.WriteLine);
array2.Select(x => new { Number =x , SqrNo = x * x})
    .ToList()
    .ForEach(Console.WriteLine);
Console.WriteLine();
Console.WriteLine();
array3.GroupBy(x=>x)
    .Select(x => new { Number = x.Key, Count = x.Count() })
    .ToList()
    .ForEach(Console.WriteLine);
Console.WriteLine();
string apple = "apple";
apple.GroupBy(x => x)
     .Select(x => new { Letter = x.Key, Count = x.Count() })
    .ToList()
    .ForEach(Console.WriteLine);
List<string> list = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

list.Where(x => x.StartsWith("A"))
    .Where(x => x.EndsWith("M"))
    .ToList()
    .ForEach(Console.WriteLine);
Console.WriteLine();

array3.Select(x => x)
    .Take(3)
    .ToList()
    .ForEach(Console.WriteLine);

string upper = "this IS a STRING";
upper.Split(' ')
    .Where(x => x.All(c=>   c >= 'A' && c <= 'Z'))
    .ToList()
    .ForEach(Console.WriteLine);