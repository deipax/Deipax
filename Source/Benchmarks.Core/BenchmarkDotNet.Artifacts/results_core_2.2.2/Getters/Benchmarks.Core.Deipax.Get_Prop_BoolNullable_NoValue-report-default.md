
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.2116 ns | 0.0034 ns | 0.0030 ns |           - |           - |           - |                   - |
     ToBoolNullable |  0.8939 ns | 0.0020 ns | 0.0017 ns |           - |           - |           - |                   - |
             ToChar |  0.9642 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.0977 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            ToSByte |  1.3315 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.0932 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
             ToByte |  1.1605 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1031 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            ToShort |  1.1915 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1130 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
           ToUShort |  1.2388 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1066 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
              ToInt |  1.4541 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1118 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
             ToUInt |  1.1618 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1023 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
             ToLong |  1.1652 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.6046 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
            ToULong |  1.1539 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.6635 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
            ToFloat |  1.5491 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3322 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
           ToDouble |  1.1564 ns | 0.0017 ns | 0.0014 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.6154 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
          ToDecimal |  1.8340 ns | 0.0030 ns | 0.0027 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.5521 ns | 0.0060 ns | 0.0050 ns |           - |           - |           - |                   - |
         ToDateTime |  2.0529 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.2824 ns | 0.0052 ns | 0.0046 ns |           - |           - |           - |                   - |
           ToObject |  1.2482 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
          To_String |  1.3289 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             ToEnum |  1.3276 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3184 ns | 0.0037 ns | 0.0033 ns |           - |           - |           - |                   - |
