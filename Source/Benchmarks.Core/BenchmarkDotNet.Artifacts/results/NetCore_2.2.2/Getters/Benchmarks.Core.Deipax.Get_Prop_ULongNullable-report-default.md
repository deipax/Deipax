
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.592 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.362 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
             ToChar |  2.391 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.043 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            ToSByte |  1.632 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.359 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
             ToByte |  2.437 ns | 0.0097 ns | 0.0090 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.043 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
            ToShort |  2.649 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.043 ns | 0.0041 ns | 0.0036 ns |           - |           - |           - |                   - |
           ToUShort |  2.359 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
   ToUShortNullable |  5.053 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
              ToInt |  2.653 ns | 0.0030 ns | 0.0027 ns |           - |           - |           - |                   - |
      ToIntNullable |  5.042 ns | 0.0025 ns | 0.0022 ns |           - |           - |           - |                   - |
             ToUInt |  1.630 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.368 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
             ToLong |  1.674 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.504 ns | 0.0033 ns | 0.0029 ns |           - |           - |           - |                   - |
            ToULong |  1.634 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.593 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
            ToFloat |  1.806 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    ToFloatNullable |  5.043 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
           ToDouble |  1.806 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.050 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
          ToDecimal |  5.959 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.137 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
         ToDateTime |  2.282 ns | 0.0030 ns | 0.0025 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.112 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
           ToObject |  4.410 ns | 0.0202 ns | 0.0179 ns |      0.0038 |           - |           - |                24 B |
          To_String | 19.358 ns | 0.0231 ns | 0.0205 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.874 ns | 0.0057 ns | 0.0050 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.861 ns | 0.0078 ns | 0.0065 ns |           - |           - |           - |                   - |
