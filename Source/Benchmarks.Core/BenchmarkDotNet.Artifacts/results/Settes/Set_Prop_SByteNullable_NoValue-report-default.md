
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.164 ns | 0.0205 ns | 0.0160 ns |      - |       0 B |
     FromBoolNullable |  7.749 ns | 0.0313 ns | 0.0277 ns |      - |       0 B |
             FromChar | 16.387 ns | 0.0153 ns | 0.0120 ns |      - |       0 B |
     FromCharNullable |  7.744 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
            FromSByte | 14.211 ns | 0.1730 ns | 0.1533 ns |      - |       0 B |
    FromSByteNullable |  7.835 ns | 0.0961 ns | 0.0899 ns |      - |       0 B |
             FromByte | 15.767 ns | 0.2094 ns | 0.1857 ns |      - |       0 B |
     FromByteNullable |  7.735 ns | 0.0215 ns | 0.0179 ns |      - |       0 B |
            FromShort | 16.366 ns | 0.0137 ns | 0.0122 ns |      - |       0 B |
    FromShortNullable |  7.837 ns | 0.1760 ns | 0.1560 ns |      - |       0 B |
           FromUShort | 15.591 ns | 0.0325 ns | 0.0304 ns |      - |       0 B |
   FromUShortNullable |  7.734 ns | 0.0106 ns | 0.0083 ns |      - |       0 B |
              FromInt | 16.271 ns | 0.2220 ns | 0.1854 ns |      - |       0 B |
      FromIntNullable |  7.781 ns | 0.0479 ns | 0.0425 ns |      - |       0 B |
             FromUInt | 15.808 ns | 0.1865 ns | 0.1744 ns |      - |       0 B |
     FromUIntNullable |  7.824 ns | 0.1036 ns | 0.0969 ns |      - |       0 B |
             FromLong | 16.486 ns | 0.1283 ns | 0.1072 ns |      - |       0 B |
     FromLongNullable |  7.728 ns | 0.0123 ns | 0.0096 ns |      - |       0 B |
            FromULong | 15.757 ns | 0.1695 ns | 0.1585 ns |      - |       0 B |
    FromULongNullable |  7.870 ns | 0.0885 ns | 0.0828 ns |      - |       0 B |
            FromFloat | 19.014 ns | 0.1964 ns | 0.1837 ns |      - |       0 B |
    FromFloatNullable |  7.859 ns | 0.1158 ns | 0.1084 ns |      - |       0 B |
           FromDouble | 18.502 ns | 0.0429 ns | 0.0358 ns |      - |       0 B |
   FromDoubleNullable |  7.746 ns | 0.0222 ns | 0.0185 ns |      - |       0 B |
          FromDecimal | 27.277 ns | 0.1225 ns | 0.1146 ns |      - |       0 B |
  FromDecimalNullable |  7.741 ns | 0.0526 ns | 0.0466 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.814 ns | 0.1129 ns | 0.1056 ns |      - |       0 B |
           FromObject |  7.882 ns | 0.0974 ns | 0.0864 ns |      - |       0 B |
           FromString |  8.104 ns | 0.0572 ns | 0.0535 ns |      - |       0 B |
             FromEnum | 47.080 ns | 1.0935 ns | 1.4218 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_SByteNullable_NoValue.FromDateTime: DefaultJob
