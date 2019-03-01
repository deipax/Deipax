
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.405 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.136 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToChar |  1.470 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.136 ns | 0.0037 ns | 0.0034 ns |           - |           - |           - |                   - |
            ToSByte |  2.769 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.862 ns | 0.0269 ns | 0.0252 ns |           - |           - |           - |                   - |
             ToByte |  2.368 ns | 0.0052 ns | 0.0048 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.821 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            ToShort |  1.165 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.368 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
           ToUShort |  1.642 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.131 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
              ToInt |  1.166 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.132 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
             ToUInt |  1.450 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.138 ns | 0.0056 ns | 0.0053 ns |           - |           - |           - |                   - |
             ToLong |  1.162 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.936 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            ToULong |  1.641 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.919 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
            ToFloat |  1.190 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.362 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
           ToDouble |  1.199 ns | 0.0080 ns | 0.0071 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.670 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
          ToDecimal |  5.735 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.342 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
         ToDateTime |  2.264 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.075 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
           ToObject |  3.601 ns | 0.0050 ns | 0.0047 ns |      0.0038 |           - |           - |                24 B |
          To_String | 16.574 ns | 0.0150 ns | 0.0140 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 10.200 ns | 0.0048 ns | 0.0042 ns |           - |           - |           - |                   - |
     ToEnumNullable | 14.729 ns | 0.0158 ns | 0.0140 ns |           - |           - |           - |                   - |
