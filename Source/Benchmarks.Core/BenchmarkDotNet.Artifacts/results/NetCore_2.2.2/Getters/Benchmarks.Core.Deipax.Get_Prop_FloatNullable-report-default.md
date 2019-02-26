
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   1.493 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.966 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
             ToChar |   1.033 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.387 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
            ToSByte |   5.416 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
    ToSByteNullable |   6.905 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
             ToByte |   5.039 ns | 0.0094 ns | 0.0083 ns |           - |           - |           - |                   - |
     ToByteNullable |   6.930 ns | 0.0129 ns | 0.0108 ns |           - |           - |           - |                   - |
            ToShort |   5.037 ns | 0.0036 ns | 0.0032 ns |           - |           - |           - |                   - |
    ToShortNullable |   6.900 ns | 0.0034 ns | 0.0030 ns |           - |           - |           - |                   - |
           ToUShort |   5.024 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
   ToUShortNullable |   6.904 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
              ToInt |   3.572 ns | 0.0047 ns | 0.0042 ns |           - |           - |           - |                   - |
      ToIntNullable |   6.212 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
             ToUInt |   3.516 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
     ToUIntNullable |   6.214 ns | 0.0029 ns | 0.0025 ns |           - |           - |           - |                   - |
             ToLong |   2.924 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
     ToLongNullable |   3.491 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
            ToULong |   2.836 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
    ToULongNullable |   3.502 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
            ToFloat |   1.724 ns | 0.0029 ns | 0.0028 ns |           - |           - |           - |                   - |
    ToFloatNullable |   1.197 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
           ToDouble |   1.430 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   2.086 ns | 0.0040 ns | 0.0035 ns |           - |           - |           - |                   - |
          ToDecimal |  24.100 ns | 0.0174 ns | 0.0162 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  33.875 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
         ToDateTime |   2.135 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  16.533 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
           ToObject |   4.345 ns | 0.0052 ns | 0.0048 ns |      0.0038 |           - |           - |                24 B |
          To_String | 103.422 ns | 0.0742 ns | 0.0658 ns |      0.0050 |           - |           - |                32 B |
             ToEnum |  14.512 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
     ToEnumNullable |  18.467 ns | 0.0074 ns | 0.0066 ns |           - |           - |           - |                   - |
