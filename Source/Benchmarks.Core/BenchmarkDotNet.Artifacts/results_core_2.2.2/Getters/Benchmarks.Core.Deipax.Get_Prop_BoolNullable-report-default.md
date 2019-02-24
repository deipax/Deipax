
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.6028 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToBoolNullable |  0.8938 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
             ToChar |  0.9515 ns | 0.0010 ns | 0.0010 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1014 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
            ToSByte |  1.5536 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.3316 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
             ToByte |  1.3710 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.3321 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
            ToShort |  1.6169 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.3316 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
           ToUShort |  1.6888 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.3358 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
              ToInt |  1.5562 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3261 ns | 0.0034 ns | 0.0029 ns |           - |           - |           - |                   - |
             ToUInt |  1.3885 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.3295 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
             ToLong |  1.6041 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.8370 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
            ToULong |  1.3801 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.8881 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
            ToFloat |  1.5831 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.7886 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
           ToDouble |  1.6129 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.0747 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
          ToDecimal |  6.3867 ns | 0.0047 ns | 0.0042 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.2941 ns | 0.0082 ns | 0.0069 ns |           - |           - |           - |                   - |
         ToDateTime |  2.0537 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.2763 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
           ToObject |  4.3141 ns | 0.0093 ns | 0.0087 ns |      0.0038 |           - |           - |                24 B |
          To_String |  2.7262 ns | 0.0044 ns | 0.0037 ns |           - |           - |           - |                   - |
             ToEnum | 12.1935 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.7387 ns | 0.0182 ns | 0.0171 ns |           - |           - |           - |                   - |
