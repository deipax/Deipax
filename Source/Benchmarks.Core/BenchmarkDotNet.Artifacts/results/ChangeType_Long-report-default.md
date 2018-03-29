
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                Method |      Mean |    Error |    StdDev |  Gen 0 | Allocated |
-------------------------------------- |----------:|---------:|----------:|-------:|----------:|
                             From_Long |  59.40 ns | 2.590 ns |  7.636 ns | 0.0075 |      48 B |
                    From_Long_AsObject |  50.78 ns | 2.015 ns |  5.940 ns | 0.0037 |      24 B |
          From_Long_Nullable_WithValue | 143.86 ns | 5.682 ns | 16.575 ns | 0.0074 |      48 B |
 From_Long_Nullable_WithValue_AsObject |  49.93 ns | 1.808 ns |  5.274 ns | 0.0038 |      24 B |
            From_Long_Nullable_NoValue |        NA |       NA |        NA |    N/A |       N/A |
   From_Long_Nullable_NoValue_AsObject |        NA |       NA |        NA |    N/A |       N/A |

Benchmarks with issues:
  ChangeType_Long.From_Long_Nullable_NoValue: DefaultJob
  ChangeType_Long.From_Long_Nullable_NoValue_AsObject: DefaultJob
