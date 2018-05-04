
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 26.385 ns | 0.0134 ns | 0.0112 ns | 0.0057 |      24 B |
     FromBoolNullable |  6.783 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
             FromChar | 26.037 ns | 0.0364 ns | 0.0341 ns | 0.0057 |      24 B |
     FromCharNullable |  6.800 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
            FromSByte | 25.033 ns | 0.0104 ns | 0.0087 ns | 0.0057 |      24 B |
    FromSByteNullable |  6.793 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
             FromByte | 25.039 ns | 0.0191 ns | 0.0179 ns | 0.0057 |      24 B |
     FromByteNullable |  6.792 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
            FromShort | 25.277 ns | 0.0170 ns | 0.0151 ns | 0.0057 |      24 B |
    FromShortNullable |  6.781 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
           FromUShort | 26.310 ns | 0.0278 ns | 0.0246 ns | 0.0057 |      24 B |
   FromUShortNullable |  6.796 ns | 0.0166 ns | 0.0147 ns |      - |       0 B |
              FromInt | 24.953 ns | 0.0171 ns | 0.0152 ns | 0.0057 |      24 B |
      FromIntNullable |  6.813 ns | 0.0034 ns | 0.0025 ns |      - |       0 B |
             FromUInt | 27.190 ns | 0.0228 ns | 0.0202 ns | 0.0057 |      24 B |
     FromUIntNullable |  6.799 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
             FromLong | 27.599 ns | 0.0240 ns | 0.0213 ns | 0.0057 |      24 B |
     FromLongNullable |  7.283 ns | 0.0095 ns | 0.0080 ns |      - |       0 B |
            FromULong | 27.314 ns | 0.0288 ns | 0.0241 ns | 0.0057 |      24 B |
    FromULongNullable |  7.284 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
            FromFloat | 26.569 ns | 0.0101 ns | 0.0090 ns | 0.0057 |      24 B |
    FromFloatNullable |  6.530 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
           FromDouble | 26.756 ns | 0.0082 ns | 0.0068 ns | 0.0057 |      24 B |
   FromDoubleNullable |  7.030 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
          FromDecimal | 44.312 ns | 0.0547 ns | 0.0511 ns | 0.0076 |      32 B |
  FromDecimalNullable | 10.669 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
         FromDateTime | 25.809 ns | 0.0083 ns | 0.0065 ns | 0.0057 |      24 B |
 FromDateTimeNullable |  7.286 ns | 0.0091 ns | 0.0085 ns |      - |       0 B |
           FromObject |  7.282 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
           FromString |  6.770 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
             FromEnum |  1.050 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
     FromEnumNullable |  1.111 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
