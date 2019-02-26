
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.456 ns | 0.0082 ns | 0.0076 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.377 ns | 0.0051 ns | 0.0047 ns |           - |           - |           - |                   - |
             ToChar |  1.654 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.605 ns | 0.0038 ns | 0.0036 ns |           - |           - |           - |                   - |
            ToSByte |  1.990 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.609 ns | 0.0061 ns | 0.0054 ns |           - |           - |           - |                   - |
             ToByte |  1.649 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToByteNullable |  1.174 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            ToShort |  1.611 ns | 0.0038 ns | 0.0032 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.604 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
           ToUShort |  1.498 ns | 0.0029 ns | 0.0022 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.595 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
              ToInt |  1.617 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.377 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
             ToUInt |  1.446 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.373 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
             ToLong |  1.486 ns | 0.0056 ns | 0.0052 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.243 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
            ToULong |  1.496 ns | 0.0030 ns | 0.0029 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.132 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
            ToFloat |  1.528 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.834 ns | 0.0070 ns | 0.0065 ns |           - |           - |           - |                   - |
           ToDouble |  1.700 ns | 0.0041 ns | 0.0038 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.151 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
          ToDecimal |  6.204 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.873 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
         ToDateTime |  2.244 ns | 0.0039 ns | 0.0037 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.319 ns | 0.0223 ns | 0.0208 ns |           - |           - |           - |                   - |
           ToObject |  4.375 ns | 0.0037 ns | 0.0035 ns |      0.0038 |           - |           - |                24 B |
          To_String | 17.240 ns | 0.0200 ns | 0.0187 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.239 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.580 ns | 0.0260 ns | 0.0243 ns |           - |           - |           - |                   - |
