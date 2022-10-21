using RandomThreadSafety;
using static System.Console;


var rng = new Random(7);

Parallel.For(0, 16, _ =>
{
    var numbers = new int[10_000];
    for (var i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rng.Next();
    }
    var threadIssues = numbers.Count(y => y == 0);
    WriteLine($"Thread issues: {threadIssues}");
});


Parallel.For(0, 16, _ =>
{
    var numbers = new int[10_000];
    for (var i = 0; i < numbers.Length; i++)
    {
        numbers[i] = CustomRandom.Next();
    }
    var threadIssues = numbers.Count(y => y == 0);
    WriteLine($"Thread issues: {threadIssues}");
});