
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 16.732 ns | 0.0088 ns | 0.0073 ns |      - |       0 B |
     FromBoolNullable | 10.109 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
             FromChar | 17.401 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
     FromCharNullable |  8.217 ns | 0.0087 ns | 0.0072 ns |      - |       0 B |
            FromSByte | 17.120 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
    FromSByteNullable |  8.212 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
             FromByte | 16.723 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
     FromByteNullable |  8.227 ns | 0.0070 ns | 0.0065 ns |      - |       0 B |
            FromShort | 17.233 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
    FromShortNullable |  8.222 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
           FromUShort | 16.612 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
   FromUShortNullable |  8.209 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
              FromInt | 17.114 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
      FromIntNullable |  8.190 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
             FromUInt | 16.717 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
     FromUIntNullable |  8.256 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
             FromLong | 17.231 ns | 0.0105 ns | 0.0087 ns |      - |       0 B |
     FromLongNullable |  8.209 ns | 0.0034 ns | 0.0029 ns |      - |       0 B |
            FromULong | 14.336 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
    FromULongNullable |  8.192 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
            FromFloat | 20.983 ns | 0.0081 ns | 0.0068 ns |      - |       0 B |
    FromFloatNullable |  8.292 ns | 0.0092 ns | 0.0077 ns |      - |       0 B |
           FromDouble | 20.836 ns | 0.0161 ns | 0.0142 ns |      - |       0 B |
   FromDoubleNullable |  8.250 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
          FromDecimal | 34.757 ns | 0.0765 ns | 0.0678 ns |      - |       0 B |
  FromDecimalNullable |  8.212 ns | 0.0028 ns | 0.0020 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  8.216 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
           FromObject |  8.204 ns | 0.0113 ns | 0.0101 ns |      - |       0 B |
           FromString |  8.604 ns | 0.0045 ns | 0.0038 ns |      - |       0 B |
             FromEnum | 47.166 ns | 0.0613 ns | 0.0478 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_ULongNullable_NoValue.FromDateTime: DefaultJob
