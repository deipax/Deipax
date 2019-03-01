
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.448 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.374 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
             ToChar |  1.691 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.377 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
            ToSByte |  1.647 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    ToSByteNullable |  1.163 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
             ToByte |  2.009 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.373 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
            ToShort |  1.761 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.601 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
           ToUShort |  1.959 ns | 0.0032 ns | 0.0028 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.375 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
              ToInt |  1.476 ns | 0.0025 ns | 0.0022 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.376 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
             ToUInt |  1.843 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.383 ns | 0.0053 ns | 0.0049 ns |           - |           - |           - |                   - |
             ToLong |  1.617 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.197 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
            ToULong |  1.691 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.170 ns | 0.0060 ns | 0.0057 ns |           - |           - |           - |                   - |
            ToFloat |  1.462 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.601 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
           ToDouble |  1.627 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.241 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
          ToDecimal |  5.975 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.884 ns | 0.0132 ns | 0.0123 ns |           - |           - |           - |                   - |
         ToDateTime |  2.172 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.133 ns | 0.0064 ns | 0.0059 ns |           - |           - |           - |                   - |
           ToObject |  4.334 ns | 0.0126 ns | 0.0118 ns |      0.0038 |           - |           - |                24 B |
          To_String | 17.241 ns | 0.0160 ns | 0.0134 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.236 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.601 ns | 0.0089 ns | 0.0079 ns |           - |           - |           - |                   - |
