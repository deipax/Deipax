
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 12.556 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
     FromBoolNullable | 12.545 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
             FromChar | 13.330 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
     FromCharNullable | 13.325 ns | 0.0111 ns | 0.0087 ns |      - |       0 B |
            FromSByte | 12.550 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
    FromSByteNullable | 12.568 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
             FromByte | 12.543 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
     FromByteNullable | 12.549 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
            FromShort | 12.567 ns | 0.0087 ns | 0.0077 ns |      - |       0 B |
    FromShortNullable | 12.565 ns | 0.0235 ns | 0.0220 ns |      - |       0 B |
           FromUShort | 12.573 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
   FromUShortNullable | 12.557 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
              FromInt | 12.557 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
      FromIntNullable | 12.557 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
             FromUInt | 12.567 ns | 0.0123 ns | 0.0103 ns |      - |       0 B |
     FromUIntNullable | 12.550 ns | 0.0183 ns | 0.0162 ns |      - |       0 B |
             FromLong |  3.627 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
     FromLongNullable |  3.338 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
            FromULong | 13.331 ns | 0.0139 ns | 0.0124 ns |      - |       0 B |
    FromULongNullable | 13.320 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
            FromFloat | 17.424 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
    FromFloatNullable | 17.415 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
           FromDouble | 17.204 ns | 0.0401 ns | 0.0355 ns |      - |       0 B |
   FromDoubleNullable | 17.167 ns | 0.0372 ns | 0.0290 ns |      - |       0 B |
          FromDecimal | 60.734 ns | 0.0487 ns | 0.0407 ns |      - |       0 B |
  FromDecimalNullable | 58.364 ns | 0.0219 ns | 0.0183 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  6.881 ns | 0.0048 ns | 0.0043 ns |      - |       0 B |
           FromObject |  3.393 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
           FromString | 84.330 ns | 0.0420 ns | 0.0328 ns |      - |       0 B |
             FromEnum | 42.568 ns | 0.0694 ns | 0.0649 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Long.FromDateTime: DefaultJob
