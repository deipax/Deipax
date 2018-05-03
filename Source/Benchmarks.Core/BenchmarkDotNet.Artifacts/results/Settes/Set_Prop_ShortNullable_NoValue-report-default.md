
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  6.754 ns | 0.0014 ns | 0.0012 ns |       0 B |
     FromBoolNullable |  6.515 ns | 0.0045 ns | 0.0042 ns |       0 B |
             FromChar |  6.755 ns | 0.0013 ns | 0.0012 ns |       0 B |
     FromCharNullable |  6.769 ns | 0.0023 ns | 0.0021 ns |       0 B |
            FromSByte |  6.756 ns | 0.0061 ns | 0.0054 ns |       0 B |
    FromSByteNullable |  6.513 ns | 0.0017 ns | 0.0014 ns |       0 B |
             FromByte |  6.730 ns | 0.0309 ns | 0.0289 ns |       0 B |
     FromByteNullable |  6.497 ns | 0.0011 ns | 0.0010 ns |       0 B |
            FromShort |  1.113 ns | 0.0039 ns | 0.0035 ns |       0 B |
    FromShortNullable |  1.022 ns | 0.0027 ns | 0.0026 ns |       0 B |
           FromUShort |  6.754 ns | 0.0012 ns | 0.0010 ns |       0 B |
   FromUShortNullable |  6.773 ns | 0.0082 ns | 0.0073 ns |       0 B |
              FromInt |  7.509 ns | 0.0071 ns | 0.0066 ns |       0 B |
      FromIntNullable |  6.513 ns | 0.0014 ns | 0.0009 ns |       0 B |
             FromUInt |  7.491 ns | 0.0014 ns | 0.0012 ns |       0 B |
     FromUIntNullable |  6.513 ns | 0.0017 ns | 0.0014 ns |       0 B |
             FromLong |  7.505 ns | 0.0012 ns | 0.0009 ns |       0 B |
     FromLongNullable |  7.008 ns | 0.0016 ns | 0.0013 ns |       0 B |
            FromULong |  7.248 ns | 0.0077 ns | 0.0072 ns |       0 B |
    FromULongNullable |  7.021 ns | 0.0160 ns | 0.0141 ns |       0 B |
            FromFloat |  8.993 ns | 0.0084 ns | 0.0079 ns |       0 B |
    FromFloatNullable |  6.529 ns | 0.0170 ns | 0.0151 ns |       0 B |
           FromDouble |  8.935 ns | 0.0049 ns | 0.0041 ns |       0 B |
   FromDoubleNullable |  7.016 ns | 0.0139 ns | 0.0123 ns |       0 B |
          FromDecimal | 20.853 ns | 0.0582 ns | 0.0544 ns |       0 B |
  FromDecimalNullable |  7.283 ns | 0.0097 ns | 0.0091 ns |       0 B |
         FromDateTime |  6.817 ns | 0.0074 ns | 0.0070 ns |       0 B |
 FromDateTimeNullable |  7.282 ns | 0.0087 ns | 0.0072 ns |       0 B |
           FromObject |  8.070 ns | 0.0055 ns | 0.0049 ns |       0 B |
           FromString |  7.020 ns | 0.0184 ns | 0.0163 ns |       0 B |
             FromEnum |  7.490 ns | 0.0064 ns | 0.0057 ns |       0 B |
     FromEnumNullable |  6.517 ns | 0.0050 ns | 0.0044 ns |       0 B |
