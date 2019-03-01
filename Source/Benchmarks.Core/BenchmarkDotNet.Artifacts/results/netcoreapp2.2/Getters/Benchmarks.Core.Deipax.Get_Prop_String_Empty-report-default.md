
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.3402 ns | 0.0052 ns | 0.0043 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.4207 ns | 0.0109 ns | 0.0091 ns |           - |           - |           - |                   - |
             ToChar |  1.4097 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.4258 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
            ToSByte |  1.6990 ns | 0.0065 ns | 0.0054 ns |           - |           - |           - |                   - |
    ToSByteNullable |  9.7908 ns | 0.0481 ns | 0.0449 ns |           - |           - |           - |                   - |
             ToByte |  1.7176 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
     ToByteNullable |  9.7395 ns | 0.0288 ns | 0.0255 ns |           - |           - |           - |                   - |
            ToShort |  1.6957 ns | 0.0153 ns | 0.0135 ns |           - |           - |           - |                   - |
    ToShortNullable |  9.8006 ns | 0.0321 ns | 0.0285 ns |           - |           - |           - |                   - |
           ToUShort |  1.7523 ns | 0.0141 ns | 0.0117 ns |           - |           - |           - |                   - |
   ToUShortNullable |  9.8798 ns | 0.0709 ns | 0.0629 ns |           - |           - |           - |                   - |
              ToInt |  1.7011 ns | 0.0072 ns | 0.0064 ns |           - |           - |           - |                   - |
      ToIntNullable |  9.8167 ns | 0.0604 ns | 0.0565 ns |           - |           - |           - |                   - |
             ToUInt |  1.7318 ns | 0.0050 ns | 0.0045 ns |           - |           - |           - |                   - |
     ToUIntNullable |  9.7980 ns | 0.0615 ns | 0.0546 ns |           - |           - |           - |                   - |
             ToLong |  1.7161 ns | 0.0068 ns | 0.0060 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.1221 ns | 0.0093 ns | 0.0083 ns |           - |           - |           - |                   - |
            ToULong |  1.7261 ns | 0.0145 ns | 0.0135 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.1476 ns | 0.0271 ns | 0.0253 ns |           - |           - |           - |                   - |
            ToFloat |  1.7680 ns | 0.0057 ns | 0.0047 ns |           - |           - |           - |                   - |
    ToFloatNullable | 10.0093 ns | 0.0282 ns | 0.0263 ns |           - |           - |           - |                   - |
           ToDouble |  1.7802 ns | 0.0115 ns | 0.0102 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.5734 ns | 0.0109 ns | 0.0091 ns |           - |           - |           - |                   - |
          ToDecimal |  2.3726 ns | 0.0143 ns | 0.0127 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  8.7228 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
         ToDateTime |  2.6127 ns | 0.0229 ns | 0.0203 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.8887 ns | 0.0401 ns | 0.0355 ns |           - |           - |           - |                   - |
           ToObject |  0.9684 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
          To_String |  0.9491 ns | 0.0043 ns | 0.0038 ns |           - |           - |           - |                   - |
             ToEnum |  1.3990 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.4483 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
