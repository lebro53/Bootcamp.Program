using static ArrayCreator;
using static ArrayMath;
using System.Diagnostics;


int[] array = 10_000_000.Create()
					.Fill(1, 10);
// array.COnvertToString();


int m = 10000;
Stopwatch sw = new Stopwatch();
sw.Start();
int max = array.BadGetSum(m);
sw.Stop();

Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");
sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");