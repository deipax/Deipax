
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9955 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1558 ns | 0.0041 ns | 0.0038 ns |           - |           - |           - |                   - |
             ToChar |  0.9319 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1393 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
            ToSByte |  1.4005 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1414 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToByte |  1.3934 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1405 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
            ToShort |  1.2109 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1389 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
           ToUShort |  0.9401 ns | 0.0051 ns | 0.0047 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.3678 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
              ToInt |  0.9380 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1381 ns | 0.0032 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToUInt |  0.9353 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1399 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToLong |  0.9366 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.8347 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
            ToULong |  0.9583 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.6211 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
            ToFloat |  1.2438 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3727 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
           ToDouble |  1.2412 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.8582 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
          ToDecimal |  5.9823 ns | 0.0038 ns | 0.0033 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.6463 ns | 0.0074 ns | 0.0062 ns |           - |           - |           - |                   - |
         ToDateTime |  2.2990 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.1272 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
           ToObject |  3.8545 ns | 0.0035 ns | 0.0033 ns |      0.0038 |           - |           - |                24 B |
          To_String | 16.5876 ns | 0.0211 ns | 0.0197 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 10.1819 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
     ToEnumNullable | 14.7214 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
