
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.2008 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.3267 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
             ToChar |  1.3258 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.3282 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            ToSByte |  1.6346 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.3359 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
             ToByte |  1.6885 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.5577 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
            ToShort |  1.3993 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.3296 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
           ToUShort |  1.5992 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
   ToUShortNullable |  0.9082 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
              ToInt |  1.4522 ns | 0.0039 ns | 0.0036 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3281 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
             ToUInt |  1.3332 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.3267 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
             ToLong |  1.1927 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.6561 ns | 0.0026 ns | 0.0022 ns |           - |           - |           - |                   - |
            ToULong |  1.1901 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.6095 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
            ToFloat |  1.4169 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.5531 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
           ToDouble |  1.3217 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.8128 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
          ToDecimal |  5.9268 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.1710 ns | 0.0240 ns | 0.0225 ns |           - |           - |           - |                   - |
         ToDateTime |  2.0107 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.2682 ns | 0.0057 ns | 0.0050 ns |           - |           - |           - |                   - |
           ToObject |  4.3026 ns | 0.0065 ns | 0.0060 ns |      0.0038 |           - |           - |                24 B |
          To_String | 16.9156 ns | 0.0111 ns | 0.0098 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.1879 ns | 0.0081 ns | 0.0075 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.6230 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
