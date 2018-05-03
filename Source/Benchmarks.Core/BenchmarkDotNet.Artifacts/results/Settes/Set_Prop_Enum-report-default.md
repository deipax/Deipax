
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool | 26.4940 ns | 0.0145 ns | 0.0129 ns | 0.0057 |      24 B |
     FromBoolNullable | 27.1706 ns | 0.1824 ns | 0.1617 ns | 0.0057 |      24 B |
             FromChar | 26.7026 ns | 0.0345 ns | 0.0322 ns | 0.0057 |      24 B |
     FromCharNullable | 26.8736 ns | 0.0616 ns | 0.0546 ns | 0.0057 |      24 B |
            FromSByte | 26.2700 ns | 0.0238 ns | 0.0222 ns | 0.0057 |      24 B |
    FromSByteNullable | 26.6111 ns | 0.0553 ns | 0.0491 ns | 0.0057 |      24 B |
             FromByte | 26.0581 ns | 0.0186 ns | 0.0174 ns | 0.0057 |      24 B |
     FromByteNullable | 26.4542 ns | 0.0880 ns | 0.0780 ns | 0.0057 |      24 B |
            FromShort | 26.1256 ns | 0.0401 ns | 0.0375 ns | 0.0057 |      24 B |
    FromShortNullable | 26.7740 ns | 0.0137 ns | 0.0121 ns | 0.0057 |      24 B |
           FromUShort | 26.3144 ns | 0.0390 ns | 0.0365 ns | 0.0057 |      24 B |
   FromUShortNullable | 26.7509 ns | 0.0380 ns | 0.0355 ns | 0.0057 |      24 B |
              FromInt | 25.8389 ns | 0.0134 ns | 0.0112 ns | 0.0057 |      24 B |
      FromIntNullable | 26.8043 ns | 0.0407 ns | 0.0381 ns | 0.0057 |      24 B |
             FromUInt | 26.6608 ns | 0.0407 ns | 0.0381 ns | 0.0057 |      24 B |
     FromUIntNullable | 27.7659 ns | 0.0547 ns | 0.0485 ns | 0.0057 |      24 B |
             FromLong | 27.2779 ns | 0.0236 ns | 0.0210 ns | 0.0057 |      24 B |
     FromLongNullable | 29.4217 ns | 0.0693 ns | 0.0649 ns | 0.0057 |      24 B |
            FromULong | 27.3714 ns | 0.0196 ns | 0.0174 ns | 0.0057 |      24 B |
    FromULongNullable | 29.4202 ns | 0.0105 ns | 0.0088 ns | 0.0057 |      24 B |
            FromFloat | 28.5869 ns | 0.0263 ns | 0.0246 ns | 0.0057 |      24 B |
    FromFloatNullable | 29.4653 ns | 0.0100 ns | 0.0094 ns | 0.0057 |      24 B |
           FromDouble | 28.3642 ns | 0.0292 ns | 0.0273 ns | 0.0057 |      24 B |
   FromDoubleNullable | 30.6133 ns | 0.0091 ns | 0.0081 ns | 0.0057 |      24 B |
          FromDecimal | 39.4301 ns | 0.0619 ns | 0.0548 ns | 0.0076 |      32 B |
  FromDecimalNullable | 43.0298 ns | 0.0050 ns | 0.0042 ns | 0.0076 |      32 B |
         FromDateTime | 24.5430 ns | 0.0207 ns | 0.0194 ns | 0.0057 |      24 B |
 FromDateTimeNullable |  4.3459 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
           FromObject |  2.7497 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
           FromString | 34.4387 ns | 0.0088 ns | 0.0073 ns |      - |       0 B |
             FromEnum |  0.9433 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
     FromEnumNullable |  1.7238 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
