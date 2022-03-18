``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1526 (20H2/October2020Update)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|    Method |     Mean |     Error |    StdDev |   Median |
|---------- |---------:|----------:|----------:|---------:|
| DapperFun | 1.100 ms | 0.0982 ms | 0.2864 ms | 1.085 ms |
|     EFFun | 1.647 ms | 0.3123 ms | 0.8654 ms | 1.348 ms |
