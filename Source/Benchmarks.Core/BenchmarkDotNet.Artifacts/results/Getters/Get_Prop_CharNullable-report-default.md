
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.609 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
     ToBoolNullable |  6.797 ns | 0.0391 ns | 0.0347 ns |      - |       0 B |
             ToChar |  2.850 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
     ToCharNullable |  1.799 ns | 0.0207 ns | 0.0173 ns |      - |       0 B |
            ToSByte |  5.382 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
    ToSByteNullable |  7.290 ns | 0.0149 ns | 0.0133 ns |      - |       0 B |
             ToByte |  5.142 ns | 0.0091 ns | 0.0080 ns |      - |       0 B |
     ToByteNullable |  7.276 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
            ToShort |  5.137 ns | 0.0164 ns | 0.0137 ns |      - |       0 B |
    ToShortNullable |  7.291 ns | 0.0092 ns | 0.0087 ns |      - |       0 B |
           ToUShort |  4.697 ns | 0.1855 ns | 0.1549 ns |      - |       0 B |
   ToUShortNullable |  7.006 ns | 0.0448 ns | 0.0397 ns |      - |       0 B |
              ToInt |  4.710 ns | 0.1050 ns | 0.0982 ns |      - |       0 B |
      ToIntNullable |  6.777 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
             ToUInt |  4.601 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
     ToUIntNullable |  6.773 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
             ToLong |  4.605 ns | 0.0109 ns | 0.0085 ns |      - |       0 B |
     ToLongNullable |  6.910 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
            ToULong |  4.604 ns | 0.0097 ns | 0.0081 ns |      - |       0 B |
    ToULongNullable |  7.020 ns | 0.0169 ns | 0.0150 ns |      - |       0 B |
            ToFloat |  3.876 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
    ToFloatNullable |  6.837 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
           ToDouble |  3.877 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
   ToDoubleNullable |  6.170 ns | 0.0069 ns | 0.0057 ns |      - |       0 B |
          ToDecimal |  7.205 ns | 0.0392 ns | 0.0348 ns |      - |       0 B |
  ToDecimalNullable |  6.455 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
         ToDateTime |  5.414 ns | 0.0385 ns | 0.0360 ns |      - |       0 B |
 ToDateTimeNullable |  6.691 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
           ToObject |  5.334 ns | 0.0084 ns | 0.0070 ns | 0.0057 |      24 B |
          To_String |  8.681 ns | 0.1571 ns | 0.1469 ns | 0.0076 |      32 B |
             ToEnum | 25.785 ns | 0.1217 ns | 0.0951 ns | 0.0057 |      24 B |
