using System;
using System.Diagnostics;
using System.Threading;
    Stopwatch stopwatch = new Stopwatch();
  

    stopwatch.Start();

    int maxNum = 99999999;
    int count = 0;
for (int i = 1; i <= maxNum; i *= 10)
{
    int divider = i * 10;
    count += (maxNum / divider) * i;
    count+=Math.Min(Math.Max(maxNum % divider - i + 1, 0), i);

}
    stopwatch.Stop();
    Console.WriteLine(count + " " + stopwatch.Elapsed);

