
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.117 ns | 0.0012 ns | 0.0009 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.121 ns | 0.0038 ns | 0.0034 ns |           - |           - |           - |                   - |
             ToChar |  1.431 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.119 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
            ToSByte |  1.118 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.351 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
             ToByte |  1.417 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.123 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
            ToShort |  1.136 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.122 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
           ToUShort |  1.575 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.127 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
              ToInt |  1.120 ns | 0.0027 ns | 0.0026 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.124 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
             ToUInt |  1.429 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.121 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
             ToLong |  1.126 ns | 0.0070 ns | 0.0065 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.559 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
            ToULong |  1.389 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.034 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
            ToFloat |  1.158 ns | 0.0011 ns | 0.0011 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.354 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
           ToDouble |  1.157 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.571 ns | 0.0009 ns | 0.0009 ns |           - |           - |           - |                   - |
          ToDecimal |  5.958 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.838 ns | 0.0085 ns | 0.0079 ns |           - |           - |           - |                   - |
         ToDateTime |  2.261 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.339 ns | 0.0400 ns | 0.0354 ns |           - |           - |           - |                   - |
           ToObject |  3.550 ns | 0.0070 ns | 0.0059 ns |      0.0038 |           - |           - |                24 B |
          To_String | 16.758 ns | 0.0172 ns | 0.0144 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 10.151 ns | 0.0066 ns | 0.0058 ns |           - |           - |           - |                   - |
     ToEnumNullable | 14.789 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
