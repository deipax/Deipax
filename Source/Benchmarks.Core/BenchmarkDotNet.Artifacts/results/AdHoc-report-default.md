
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                  Method |       Mean |     Error |     StdDev |     Median |  Gen 0 | Allocated |
---------------------------------------- |-----------:|----------:|-----------:|-----------:|-------:|----------:|
                    ConvertTo_LongToLong |  10.699 ns | 0.4232 ns |  1.2411 ns |  10.804 ns | 0.0038 |      24 B |
                   ConvertTo2_LongToLong |   6.034 ns | 0.2740 ns |  0.8035 ns |   5.988 ns |      - |       0 B |
                ConvertTo_LongToNullLong |  31.205 ns | 1.7226 ns |  5.0790 ns |  34.950 ns | 0.0038 |      24 B |
               ConvertTo2_LongToNullLong |   7.007 ns | 0.2955 ns |  0.8525 ns |   6.913 ns |      - |       0 B |
      ConvertTo_NullLongToLong_WithValue | 149.245 ns | 2.8918 ns |  3.4425 ns | 149.501 ns | 0.0037 |      24 B |
     ConvertTo2_NullLongToLong_WithValue |   7.497 ns | 0.3881 ns |  1.1444 ns |   7.437 ns |      - |       0 B |
        ConvertTo_NullLongToLong_NoValue |  31.933 ns | 1.1242 ns |  3.2970 ns |  32.221 ns |      - |       0 B |
       ConvertTo2_NullLongToLong_NoValue |   6.782 ns | 0.2792 ns |  0.7965 ns |   6.702 ns |      - |       0 B |
  ConvertTo_NullLongToNullLong_WithValue | 106.197 ns | 3.5501 ns | 10.3557 ns | 106.224 ns | 0.0036 |      24 B |
 ConvertTo2_NullLongToNullLong_WithValue |   8.729 ns | 0.2945 ns |  0.8592 ns |   8.789 ns |      - |       0 B |
    ConvertTo_NullLongToNullLong_NoValue |  33.899 ns | 1.3931 ns |  4.1075 ns |  33.607 ns |      - |       0 B |
   ConvertTo2_NullLongToNullLong_NoValue |   8.945 ns | 0.3918 ns |  1.1552 ns |   8.803 ns |      - |       0 B |
