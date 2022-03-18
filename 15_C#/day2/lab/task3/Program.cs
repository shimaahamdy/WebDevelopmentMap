using System;
using System.Diagnostics;
using System.Threading;
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();



int maxNum = 99999999 ;
int count = 0;
for (int i = 0; i <= maxNum; i++)
{
    string num = i.ToString();
    for(int j=0; j < num.Length; j++)
    {
        if (num[j] == '1') count++;
    }
  
}
stopwatch.Stop();
Console.WriteLine(count +" "+ stopwatch.Elapsed);
