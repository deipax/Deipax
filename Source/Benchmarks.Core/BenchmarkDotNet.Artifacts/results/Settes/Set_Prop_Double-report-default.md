
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  12.807 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
     FromBoolNullable |  12.842 ns | 0.0358 ns | 0.0318 ns |      - |       0 B |
             FromChar |         NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |   6.789 ns | 0.0028 ns | 0.0026 ns |      - |       0 B |
            FromSByte |  12.806 ns | 0.0118 ns | 0.0098 ns |      - |       0 B |
    FromSByteNullable |  12.902 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
             FromByte |  12.808 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
     FromByteNullable |  12.809 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
            FromShort |  13.059 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
    FromShortNullable |  13.121 ns | 0.0157 ns | 0.0122 ns |      - |       0 B |
           FromUShort |  12.809 ns | 0.0200 ns | 0.0167 ns |      - |       0 B |
   FromUShortNullable |  12.803 ns | 0.0040 ns | 0.0035 ns |      - |       0 B |
              FromInt |  12.819 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
      FromIntNullable |  12.807 ns | 0.0134 ns | 0.0125 ns |      - |       0 B |
             FromUInt |  13.060 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
     FromUIntNullable |  13.054 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
             FromLong |  13.059 ns | 0.0148 ns | 0.0124 ns |      - |       0 B |
     FromLongNullable |  13.061 ns | 0.0190 ns | 0.0168 ns |      - |       0 B |
            FromULong |  13.563 ns | 0.0069 ns | 0.0062 ns |      - |       0 B |
    FromULongNullable |  13.562 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
            FromFloat |  12.816 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
    FromFloatNullable |  12.804 ns | 0.0151 ns | 0.0142 ns |      - |       0 B |
           FromDouble |   3.342 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
   FromDoubleNullable |   3.379 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
          FromDecimal |  18.294 ns | 0.0153 ns | 0.0128 ns |      - |       0 B |
  FromDecimalNullable |  18.284 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
         FromDateTime |         NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |   6.887 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
           FromObject |   3.537 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
           FromString | 101.241 ns | 0.0604 ns | 0.0565 ns |      - |       0 B |
             FromEnum |  43.342 ns | 0.0715 ns | 0.0669 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Double.FromChar: DefaultJob
  Set_Prop_Double.FromDateTime: DefaultJob
