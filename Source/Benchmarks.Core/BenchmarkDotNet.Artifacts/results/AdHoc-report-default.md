
BenchmarkDotNet=v0.10.13, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


      Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------ |----------:|----------:|----------:|-------:|----------:|
 IsNullable1 |  89.26 ns | 0.5074 ns | 0.4498 ns |      - |       0 B |
 IsNullable2 | 227.40 ns | 2.2035 ns | 2.0612 ns | 0.0074 |      32 B |
