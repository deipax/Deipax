
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                Method |     Mean |     Error |   StdDev | Allocated |
-------------------------------------- |---------:|----------:|---------:|----------:|
                             From_Long | 14.26 ns | 0.5801 ns | 1.701 ns |       0 B |
                    From_Long_AsObject | 20.25 ns | 0.6940 ns | 2.046 ns |       0 B |
          From_Long_Nullable_WithValue | 16.16 ns | 0.5615 ns | 1.647 ns |       0 B |
 From_Long_Nullable_WithValue_AsObject | 22.12 ns | 0.9010 ns | 2.656 ns |       0 B |
            From_Long_Nullable_NoValue | 17.09 ns | 0.7261 ns | 2.130 ns |       0 B |
   From_Long_Nullable_NoValue_AsObject | 19.48 ns | 0.8109 ns | 2.391 ns |       0 B |
