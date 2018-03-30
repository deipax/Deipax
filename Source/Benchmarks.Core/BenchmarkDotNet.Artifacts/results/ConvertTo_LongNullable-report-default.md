
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410117 Hz, Resolution=293.2451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                Method |      Mean |      Error |     StdDev |    Median |  Gen 0 | Allocated |
-------------------------------------- |----------:|-----------:|-----------:|----------:|-------:|----------:|
                              From_Int |  45.86 ns |  0.9914 ns |  2.9077 ns |  45.20 ns | 0.0038 |      24 B |
                     From_Int_AsObject |  39.93 ns |  0.8291 ns |  2.3787 ns |  39.79 ns |      - |       0 B |
           From_Int_Nullable_WithValue | 185.28 ns | 15.7812 ns | 46.5313 ns | 220.67 ns | 0.0036 |      24 B |
  From_Int_Nullable_WithValue_AsObject |  39.52 ns |  0.8267 ns |  1.9648 ns |  39.49 ns |      - |       0 B |
             From_Int_Nullable_NoValue |  46.47 ns |  0.9696 ns |  2.4147 ns |  46.06 ns |      - |       0 B |
    From_Int_Nullable_NoValue_AsObject |  17.11 ns |  0.3891 ns |  1.1165 ns |  16.97 ns |      - |       0 B |
                             From_Long |  31.22 ns |  0.6500 ns |  1.8857 ns |  31.24 ns | 0.0038 |      24 B |
                    From_Long_AsObject |  46.95 ns |  0.0124 ns |  0.0273 ns |  46.94 ns |      - |       0 B |
          From_Long_Nullable_WithValue | 107.11 ns |  2.1705 ns |  4.5783 ns | 106.73 ns | 0.0037 |      24 B |
 From_Long_Nullable_WithValue_AsObject |  29.79 ns |  0.6267 ns |  1.6944 ns |  28.86 ns |      - |       0 B |
            From_Long_Nullable_NoValue |  43.25 ns |  0.9050 ns |  2.1153 ns |  43.48 ns |      - |       0 B |
   From_Long_Nullable_NoValue_AsObject |  16.48 ns |  0.3884 ns |  0.8925 ns |  16.46 ns |      - |       0 B |
