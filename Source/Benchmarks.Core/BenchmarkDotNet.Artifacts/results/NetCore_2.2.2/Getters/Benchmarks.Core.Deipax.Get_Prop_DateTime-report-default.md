
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   0.9472 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.1370 ns | 0.0066 ns | 0.0061 ns |           - |           - |           - |                   - |
             ToChar |   0.9469 ns | 0.0017 ns | 0.0014 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.1404 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
            ToSByte |   0.9542 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
    ToSByteNullable |   4.1413 ns | 0.0038 ns | 0.0036 ns |           - |           - |           - |                   - |
             ToByte |   0.9540 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToByteNullable |   4.1393 ns | 0.0030 ns | 0.0025 ns |           - |           - |           - |                   - |
            ToShort |   0.9588 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
    ToShortNullable |   4.1443 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
           ToUShort |   0.9446 ns | 0.0032 ns | 0.0027 ns |           - |           - |           - |                   - |
   ToUShortNullable |   4.1405 ns | 0.0031 ns | 0.0027 ns |           - |           - |           - |                   - |
              ToInt |   0.9617 ns | 0.0038 ns | 0.0036 ns |           - |           - |           - |                   - |
      ToIntNullable |   4.1723 ns | 0.0034 ns | 0.0031 ns |           - |           - |           - |                   - |
             ToUInt |   0.9514 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
     ToUIntNullable |   4.1428 ns | 0.0033 ns | 0.0029 ns |           - |           - |           - |                   - |
             ToLong |   0.9594 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     ToLongNullable |   1.6064 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
            ToULong |   0.9467 ns | 0.0037 ns | 0.0033 ns |           - |           - |           - |                   - |
    ToULongNullable |   2.0806 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToFloat |   1.1597 ns | 0.0031 ns | 0.0024 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.3791 ns | 0.0039 ns | 0.0036 ns |           - |           - |           - |                   - |
           ToDouble |   1.1607 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.5931 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
          ToDecimal |   2.7602 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
  ToDecimalNullable |   1.8172 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
         ToDateTime |   1.1386 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   5.0606 ns | 0.0036 ns | 0.0032 ns |           - |           - |           - |                   - |
           ToObject |   3.6159 ns | 0.0031 ns | 0.0028 ns |      0.0038 |           - |           - |                24 B |
          To_String | 268.7562 ns | 0.1943 ns | 0.1818 ns |      0.0262 |           - |           - |               168 B |
             ToEnum |   9.2108 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
     ToEnumNullable |   9.6118 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
