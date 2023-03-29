// using static RandomArray;
// using static ArraySum;
using System.Diagnostics;

int[] array = 1_000_000.Create()
                .Fill(1, 10, 100);
Console.WriteLine("----------------------------");
array.ConvertToStringAndPrintToTerminal();
// int mm; 
// int.TryParse(Console.ReadLine()!, out int mm);
int m = 10_000;
Stopwatch sw = new Stopwatch();
sw.Start();
int max = array.BadGetSum(m);
sw.Stop();
Console.WriteLine($"----------------------------\nBadGetSum: {max} => {sw.ElapsedMilliseconds}\n");
sw.Reset();

sw.Start();
int max2 = array.BestGetSum(m);
sw.Stop();
Console.Write($"BestGetSum: {max2} => {sw.ElapsedMilliseconds}\n----------------------------\n");

// array.ConvertToStringAndPrintToTerminal();
// Console.WriteLine("-----------------------");
