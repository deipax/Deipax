
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 16.634 ns | 0.0270 ns | 0.0253 ns |      - |       0 B |
     FromBoolNullable |  8.188 ns | 0.0147 ns | 0.0123 ns |      - |       0 B |
             FromChar | 17.499 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
     FromCharNullable |  8.188 ns | 0.0040 ns | 0.0032 ns |      - |       0 B |
            FromSByte | 16.727 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
    FromSByteNullable |  8.198 ns | 0.0080 ns | 0.0074 ns |      - |       0 B |
             FromByte | 16.617 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
     FromByteNullable |  8.242 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
            FromShort | 16.625 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
    FromShortNullable |  8.154 ns | 0.0060 ns | 0.0054 ns |      - |       0 B |
           FromUShort | 16.743 ns | 0.0134 ns | 0.0118 ns |      - |       0 B |
   FromUShortNullable |  8.184 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
              FromInt | 16.753 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
      FromIntNullable |  8.316 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
             FromUInt | 16.623 ns | 0.0070 ns | 0.0058 ns |      - |       0 B |
     FromUIntNullable |  8.234 ns | 0.0128 ns | 0.0119 ns |      - |       0 B |
             FromLong | 14.430 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
     FromLongNullable |  8.174 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
            FromULong | 17.502 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
    FromULongNullable |  8.182 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
            FromFloat | 21.631 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
    FromFloatNullable |  8.186 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
           FromDouble | 21.268 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
   FromDoubleNullable |  8.221 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
          FromDecimal | 62.112 ns | 0.0103 ns | 0.0086 ns |      - |       0 B |
  FromDecimalNullable |  8.559 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  8.185 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
           FromObject |  8.199 ns | 0.0044 ns | 0.0034 ns |      - |       0 B |
           FromString |  8.176 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
             FromEnum | 46.161 ns | 0.0145 ns | 0.0129 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_LongNullable_NoValue.FromDateTime: DefaultJob
