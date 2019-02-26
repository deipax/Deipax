
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  7.5940 ns | 0.0076 ns | 0.0067 ns |           - |           - |           - |                   - |
     ToBoolNullable | 14.2256 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
             ToChar |  0.8773 ns | 0.0056 ns | 0.0044 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.0976 ns | 0.0038 ns | 0.0036 ns |           - |           - |           - |                   - |
            ToSByte | 13.4369 ns | 0.2275 ns | 0.2017 ns |           - |           - |           - |                   - |
    ToSByteNullable | 21.0495 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
             ToByte | 12.8162 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
     ToByteNullable | 21.2519 ns | 0.0176 ns | 0.0156 ns |           - |           - |           - |                   - |
            ToShort | 13.0481 ns | 0.0116 ns | 0.0109 ns |           - |           - |           - |                   - |
    ToShortNullable | 21.2150 ns | 0.0103 ns | 0.0091 ns |           - |           - |           - |                   - |
           ToUShort | 12.8391 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
   ToUShortNullable | 20.9758 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
              ToInt | 12.3710 ns | 0.0073 ns | 0.0061 ns |           - |           - |           - |                   - |
      ToIntNullable | 20.5402 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
             ToUInt | 12.5412 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
     ToUIntNullable | 20.6538 ns | 0.0167 ns | 0.0148 ns |           - |           - |           - |                   - |
             ToLong | 12.7480 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
     ToLongNullable | 13.0889 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
            ToULong | 12.5760 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
    ToULongNullable | 12.8653 ns | 0.0119 ns | 0.0105 ns |           - |           - |           - |                   - |
            ToFloat | 20.3188 ns | 0.0052 ns | 0.0043 ns |           - |           - |           - |                   - |
    ToFloatNullable | 19.1996 ns | 0.0357 ns | 0.0334 ns |           - |           - |           - |                   - |
           ToDouble |  8.1568 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  8.7672 ns | 0.0036 ns | 0.0028 ns |           - |           - |           - |                   - |
          ToDecimal |  1.3679 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  5.4826 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
         ToDateTime |  1.8811 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.8995 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
           ToObject |  3.8949 ns | 0.0092 ns | 0.0086 ns |      0.0051 |           - |           - |                32 B |
          To_String | 46.6154 ns | 0.0249 ns | 0.0221 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 26.4050 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
     ToEnumNullable | 30.9411 ns | 0.0293 ns | 0.0244 ns |           - |           - |           - |                   - |
