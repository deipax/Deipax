
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9358 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.0917 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
             ToChar |  2.0115 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.7798 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
            ToSByte |  2.1812 ns | 0.0039 ns | 0.0036 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.7792 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
             ToByte |  2.0120 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.7766 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            ToShort |  1.9792 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.7754 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
           ToUShort |  2.1377 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.7805 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
              ToInt |  0.8752 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3205 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToUInt |  1.2336 ns | 0.0499 ns | 0.0490 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.2340 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
             ToLong |  1.0032 ns | 0.0060 ns | 0.0054 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.6493 ns | 0.0538 ns | 0.0477 ns |           - |           - |           - |                   - |
            ToULong |  1.1777 ns | 0.0097 ns | 0.0081 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.9764 ns | 0.0415 ns | 0.0368 ns |           - |           - |           - |                   - |
            ToFloat |  1.2032 ns | 0.0050 ns | 0.0042 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3745 ns | 0.0229 ns | 0.0215 ns |           - |           - |           - |                   - |
           ToDouble |  1.2160 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.8367 ns | 0.0076 ns | 0.0067 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6743 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.6056 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
         ToDateTime |  1.9454 ns | 0.0295 ns | 0.0262 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.1090 ns | 0.0227 ns | 0.0190 ns |           - |           - |           - |                   - |
           ToObject |  3.8932 ns | 0.0909 ns | 0.0850 ns |      0.0038 |           - |           - |                24 B |
          To_String | 16.8293 ns | 0.0630 ns | 0.0558 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 11.7439 ns | 0.0403 ns | 0.0358 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.4508 ns | 0.0383 ns | 0.0359 ns |           - |           - |           - |                   - |
