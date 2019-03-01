
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.589 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.132 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
             ToChar |  1.466 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.132 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
            ToSByte |  1.392 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.358 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
             ToByte |  1.389 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.129 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
            ToShort |  1.521 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.137 ns | 0.0060 ns | 0.0050 ns |           - |           - |           - |                   - |
           ToUShort |  1.396 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.122 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
              ToInt |  1.511 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.136 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToUInt |  1.396 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.350 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
             ToLong |  1.483 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.272 ns | 0.0015 ns | 0.0012 ns |           - |           - |           - |                   - |
            ToULong |  1.408 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.582 ns | 0.0064 ns | 0.0059 ns |           - |           - |           - |                   - |
            ToFloat |  1.345 ns | 0.0011 ns | 0.0009 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.362 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
           ToDouble |  1.345 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.049 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
          ToDecimal |  2.045 ns | 0.0061 ns | 0.0054 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.586 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
         ToDateTime |  2.280 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.120 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
           ToObject |  1.453 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
          To_String |  1.467 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
             ToEnum |  1.593 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.360 ns | 0.0023 ns | 0.0018 ns |           - |           - |           - |                   - |
