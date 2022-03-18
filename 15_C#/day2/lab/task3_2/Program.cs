
using System;
using System.Diagnostics;
using System.Threading;
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();

int maxNum = 99999999;
int count = 0;
for (int i = 0; i <= maxNum; i++)
{
    int t = i;
    while(t!=0)
    {
        int digit = t % 10;
        if (digit == 1) count++;
        t = t / 10;
    }

}
stopwatch.Stop();
Console.WriteLine(count + " " + stopwatch.Elapsed);
