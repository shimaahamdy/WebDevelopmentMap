``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1526 (21H2)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


```
|    Method |     Mean |    Error |   StdDev |
|---------- |---------:|---------:|---------:|
| DapperFun | 645.1 μs | 12.67 μs | 26.17 μs |
|     EFFun | 656.3 μs | 12.66 μs | 31.77 μs |
