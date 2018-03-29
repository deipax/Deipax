
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
-------------------------------------- |----------:|----------:|----------:|-------:|----------:|
                             From_Long |  22.24 ns | 0.7863 ns |  2.319 ns | 0.0038 |      24 B |
                    From_Long_AsObject |  18.71 ns | 0.6974 ns |  2.045 ns |      - |       0 B |
          From_Long_Nullable_WithValue | 105.13 ns | 4.7402 ns | 13.677 ns | 0.0036 |      24 B |
 From_Long_Nullable_WithValue_AsObject |  18.82 ns | 0.7484 ns |  2.183 ns |      - |       0 B |
            From_Long_Nullable_NoValue |  64.83 ns | 0.6569 ns |  1.496 ns |      - |       0 B |
   From_Long_Nullable_NoValue_AsObject |  17.43 ns | 0.6196 ns |  1.817 ns |      - |       0 B |
