
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.461 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.147 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
             ToChar |  1.643 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.151 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
            ToSByte |  1.549 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.375 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToByte |  1.693 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
     ToByteNullable |  1.166 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
            ToShort |  1.631 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.148 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
           ToUShort |  1.525 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.150 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
              ToInt |  1.618 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.148 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
             ToUInt |  1.449 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.146 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
             ToLong |  1.504 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.015 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            ToULong |  1.523 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.897 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
            ToFloat |  1.642 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.834 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
           ToDouble |  1.499 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.146 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
          ToDecimal |  2.232 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.625 ns | 0.0129 ns | 0.0115 ns |           - |           - |           - |                   - |
         ToDateTime |  2.255 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.103 ns | 0.0089 ns | 0.0084 ns |           - |           - |           - |                   - |
           ToObject |  1.444 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
          To_String |  1.619 ns | 0.0116 ns | 0.0109 ns |           - |           - |           - |                   - |
             ToEnum |  1.748 ns | 0.0025 ns | 0.0021 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.377 ns | 0.0033 ns | 0.0028 ns |           - |           - |           - |                   - |
