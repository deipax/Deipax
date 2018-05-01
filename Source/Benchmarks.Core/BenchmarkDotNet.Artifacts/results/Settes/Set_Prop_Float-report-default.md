
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  12.801 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
     FromBoolNullable |  12.797 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
             FromChar |         NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |   6.795 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
            FromSByte |  12.811 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
    FromSByteNullable |  12.815 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
             FromByte |  12.809 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
     FromByteNullable |  12.822 ns | 0.0241 ns | 0.0225 ns |      - |       0 B |
            FromShort |  13.065 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
    FromShortNullable |  13.049 ns | 0.0145 ns | 0.0114 ns |      - |       0 B |
           FromUShort |  12.813 ns | 0.0215 ns | 0.0190 ns |      - |       0 B |
   FromUShortNullable |  12.843 ns | 0.0375 ns | 0.0351 ns |      - |       0 B |
              FromInt |  12.801 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
      FromIntNullable |  12.804 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
             FromUInt |  13.080 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
     FromUIntNullable |  13.070 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
             FromLong |  13.051 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
     FromLongNullable |  13.054 ns | 0.0105 ns | 0.0099 ns |      - |       0 B |
            FromULong |  13.562 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
    FromULongNullable |  13.586 ns | 0.0241 ns | 0.0226 ns |      - |       0 B |
            FromFloat |   3.399 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
    FromFloatNullable |   3.388 ns | 0.0052 ns | 0.0048 ns |      - |       0 B |
           FromDouble |  12.799 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
   FromDoubleNullable |  12.804 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
          FromDecimal |  24.758 ns | 0.0271 ns | 0.0254 ns |      - |       0 B |
  FromDecimalNullable |  25.079 ns | 0.0155 ns | 0.0138 ns |      - |       0 B |
         FromDateTime |         NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |   6.802 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
           FromObject |   3.340 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
           FromString | 106.095 ns | 0.1684 ns | 0.1493 ns |      - |       0 B |
             FromEnum |  43.175 ns | 0.1387 ns | 0.1158 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Float.FromChar: DefaultJob
  Set_Prop_Float.FromDateTime: DefaultJob
