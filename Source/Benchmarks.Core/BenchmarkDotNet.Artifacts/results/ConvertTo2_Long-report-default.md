
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                Method |     Mean |     Error |    StdDev | Allocated |
-------------------------------------- |---------:|----------:|----------:|----------:|
                              From_Int | 15.63 ns | 0.6057 ns | 1.7860 ns |       0 B |
                     From_Int_AsObject | 29.17 ns | 0.9793 ns | 2.8721 ns |       0 B |
           From_Int_Nullable_WithValue | 16.28 ns | 0.8419 ns | 2.4824 ns |       0 B |
  From_Int_Nullable_WithValue_AsObject | 40.86 ns | 0.1161 ns | 0.0907 ns |       0 B |
             From_Int_Nullable_NoValue | 15.12 ns | 0.5544 ns | 1.6085 ns |       0 B |
    From_Int_Nullable_NoValue_AsObject | 20.99 ns | 0.7605 ns | 2.2424 ns |       0 B |
                             From_Long | 20.47 ns | 0.2230 ns | 0.5512 ns |       0 B |
                    From_Long_AsObject | 20.10 ns | 0.7297 ns | 2.1286 ns |       0 B |
          From_Long_Nullable_WithValue | 15.99 ns | 0.4783 ns | 1.3800 ns |       0 B |
 From_Long_Nullable_WithValue_AsObject | 19.97 ns | 0.5784 ns | 1.7054 ns |       0 B |
            From_Long_Nullable_NoValue | 15.78 ns | 0.4512 ns | 1.3232 ns |       0 B |
   From_Long_Nullable_NoValue_AsObject | 22.90 ns | 0.6800 ns | 2.0050 ns |       0 B |
