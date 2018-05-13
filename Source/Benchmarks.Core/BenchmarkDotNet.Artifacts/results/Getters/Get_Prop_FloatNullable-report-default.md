
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   2.034 ns | 0.0055 ns | 0.0051 ns |      - |       0 B |
     ToBoolNullable |   4.993 ns | 0.0076 ns | 0.0068 ns |      - |       0 B |
             ToChar |   1.261 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
     ToCharNullable |   4.490 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
            ToSByte |   5.890 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
    ToSByteNullable |   8.784 ns | 0.0740 ns | 0.0692 ns |      - |       0 B |
             ToByte |   6.138 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
     ToByteNullable |   8.071 ns | 0.0110 ns | 0.0098 ns |      - |       0 B |
            ToShort |   7.307 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
    ToShortNullable |   8.263 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
           ToUShort |   6.138 ns | 0.0051 ns | 0.0048 ns |      - |       0 B |
   ToUShortNullable |   8.262 ns | 0.0068 ns | 0.0061 ns |      - |       0 B |
              ToInt |   4.657 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
      ToIntNullable |   7.420 ns | 0.1044 ns | 0.0976 ns |      - |       0 B |
             ToUInt |   5.306 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
     ToUIntNullable |   7.299 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
             ToLong |   5.621 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
     ToLongNullable |   6.652 ns | 0.0128 ns | 0.0113 ns |      - |       0 B |
            ToULong |   5.811 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
    ToULongNullable |   6.528 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
            ToFloat |   2.033 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
    ToFloatNullable |   1.280 ns | 0.0022 ns | 0.0021 ns |      - |       0 B |
           ToDouble |   1.793 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
   ToDoubleNullable |   3.579 ns | 0.0050 ns | 0.0046 ns |      - |       0 B |
          ToDecimal |  26.279 ns | 0.1616 ns | 0.1433 ns |      - |       0 B |
  ToDecimalNullable |  36.509 ns | 0.0341 ns | 0.0319 ns |      - |       0 B |
         ToDateTime |   2.555 ns | 0.0028 ns | 0.0026 ns |      - |       0 B |
 ToDateTimeNullable |   8.328 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
           ToObject |   4.849 ns | 0.0045 ns | 0.0037 ns | 0.0057 |      24 B |
          To_String | 221.726 ns | 0.1791 ns | 0.1587 ns | 0.0074 |      32 B |
             ToEnum |  16.600 ns | 0.0237 ns | 0.0210 ns |      - |       0 B |
     ToEnumNullable |  21.600 ns | 0.0180 ns | 0.0160 ns |      - |       0 B |
