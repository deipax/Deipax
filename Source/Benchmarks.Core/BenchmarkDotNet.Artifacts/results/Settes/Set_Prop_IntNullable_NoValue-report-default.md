
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.062 ns | 0.0071 ns | 0.0059 ns |      - |       0 B |
     FromBoolNullable |  7.714 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
             FromChar | 15.851 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
     FromCharNullable |  7.710 ns | 0.0091 ns | 0.0086 ns |      - |       0 B |
            FromSByte | 15.069 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
    FromSByteNullable |  7.705 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
             FromByte | 15.077 ns | 0.0079 ns | 0.0073 ns |      - |       0 B |
     FromByteNullable |  7.711 ns | 0.0077 ns | 0.0069 ns |      - |       0 B |
            FromShort | 15.072 ns | 0.0163 ns | 0.0145 ns |      - |       0 B |
    FromShortNullable |  7.709 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
           FromUShort | 15.078 ns | 0.0084 ns | 0.0066 ns |      - |       0 B |
   FromUShortNullable |  7.709 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
              FromInt | 14.881 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
      FromIntNullable |  7.709 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
             FromUInt | 15.602 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
     FromUIntNullable |  7.708 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
             FromLong | 16.353 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
     FromLongNullable |  7.704 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
            FromULong | 16.347 ns | 0.0097 ns | 0.0081 ns |      - |       0 B |
    FromULongNullable |  7.727 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
            FromFloat | 17.121 ns | 0.0206 ns | 0.0182 ns |      - |       0 B |
    FromFloatNullable |  8.164 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
           FromDouble | 16.876 ns | 0.0288 ns | 0.0270 ns |      - |       0 B |
   FromDoubleNullable |  7.701 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
          FromDecimal | 27.747 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
  FromDecimalNullable |  7.709 ns | 0.0133 ns | 0.0125 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  8.590 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
           FromObject |  7.712 ns | 0.0025 ns | 0.0018 ns |      - |       0 B |
           FromString |  7.710 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
             FromEnum | 46.144 ns | 0.0995 ns | 0.0930 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_IntNullable_NoValue.FromDateTime: DefaultJob
