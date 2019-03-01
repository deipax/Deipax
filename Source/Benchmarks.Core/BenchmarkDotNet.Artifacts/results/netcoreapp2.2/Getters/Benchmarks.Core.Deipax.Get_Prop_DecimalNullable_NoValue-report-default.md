
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  9.852 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
     ToBoolNullable |  9.836 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
             ToChar |  1.118 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.120 ns | 0.0022 ns | 0.0019 ns |           - |           - |           - |                   - |
            ToSByte |  9.843 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
    ToSByteNullable | 10.051 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
             ToByte |  9.838 ns | 0.0041 ns | 0.0039 ns |           - |           - |           - |                   - |
     ToByteNullable |  9.852 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
            ToShort |  9.846 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
    ToShortNullable |  9.837 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
           ToUShort |  9.844 ns | 0.0102 ns | 0.0090 ns |           - |           - |           - |                   - |
   ToUShortNullable | 10.332 ns | 0.2318 ns | 0.2168 ns |           - |           - |           - |                   - |
              ToInt |  9.836 ns | 0.0536 ns | 0.0501 ns |           - |           - |           - |                   - |
      ToIntNullable | 10.249 ns | 0.2057 ns | 0.1823 ns |           - |           - |           - |                   - |
             ToUInt |  9.850 ns | 0.0446 ns | 0.0396 ns |           - |           - |           - |                   - |
     ToUIntNullable |  9.992 ns | 0.1310 ns | 0.1226 ns |           - |           - |           - |                   - |
             ToLong | 10.052 ns | 0.0824 ns | 0.0771 ns |           - |           - |           - |                   - |
     ToLongNullable |  8.786 ns | 0.1181 ns | 0.1105 ns |           - |           - |           - |                   - |
            ToULong | 10.018 ns | 0.0681 ns | 0.0604 ns |           - |           - |           - |                   - |
    ToULongNullable | 12.510 ns | 0.0205 ns | 0.0160 ns |           - |           - |           - |                   - |
            ToFloat |  9.942 ns | 0.0275 ns | 0.0230 ns |           - |           - |           - |                   - |
    ToFloatNullable | 10.229 ns | 0.0289 ns | 0.0270 ns |           - |           - |           - |                   - |
           ToDouble | 10.105 ns | 0.0424 ns | 0.0376 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  8.888 ns | 0.0490 ns | 0.0409 ns |           - |           - |           - |                   - |
          ToDecimal |  1.820 ns | 0.0083 ns | 0.0077 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.847 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
         ToDateTime |  2.066 ns | 0.0096 ns | 0.0085 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.482 ns | 0.0567 ns | 0.0502 ns |           - |           - |           - |                   - |
           ToObject |  1.510 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
          To_String | 11.477 ns | 0.1349 ns | 0.1262 ns |           - |           - |           - |                   - |
             ToEnum | 10.217 ns | 0.0620 ns | 0.0550 ns |           - |           - |           - |                   - |
     ToEnumNullable |  9.941 ns | 0.0269 ns | 0.0252 ns |           - |           - |           - |                   - |
