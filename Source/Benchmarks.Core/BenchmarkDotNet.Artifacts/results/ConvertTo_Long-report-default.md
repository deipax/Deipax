
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
-------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
                              From_Int |  36.52 ns | 1.3661 ns |  4.007 ns |  35.97 ns | 0.0038 |      24 B |
                     From_Int_AsObject |  31.87 ns | 1.0165 ns |  2.965 ns |  31.74 ns |      - |       0 B |
           From_Int_Nullable_WithValue | 122.73 ns | 4.9090 ns | 14.320 ns | 121.74 ns | 0.0036 |      24 B |
  From_Int_Nullable_WithValue_AsObject |  32.53 ns | 1.0677 ns |  3.115 ns |  32.21 ns |      - |       0 B |
             From_Int_Nullable_NoValue |  58.82 ns | 2.6778 ns |  7.896 ns |  64.79 ns |      - |       0 B |
    From_Int_Nullable_NoValue_AsObject |  16.93 ns | 0.5965 ns |  1.750 ns |  16.78 ns |      - |       0 B |
                             From_Long |  20.40 ns | 0.6723 ns |  1.982 ns |  20.29 ns | 0.0038 |      24 B |
                    From_Long_AsObject |  18.01 ns | 0.4947 ns |  1.443 ns |  17.93 ns |      - |       0 B |
          From_Long_Nullable_WithValue | 104.09 ns | 4.3939 ns | 12.817 ns | 101.04 ns | 0.0037 |      24 B |
 From_Long_Nullable_WithValue_AsObject |  17.33 ns | 0.4065 ns |  1.198 ns |  17.27 ns |      - |       0 B |
            From_Long_Nullable_NoValue |  47.07 ns | 1.4108 ns |  4.160 ns |  46.05 ns |      - |       0 B |
   From_Long_Nullable_NoValue_AsObject |  17.35 ns | 0.4958 ns |  1.454 ns |  17.43 ns |      - |       0 B |
