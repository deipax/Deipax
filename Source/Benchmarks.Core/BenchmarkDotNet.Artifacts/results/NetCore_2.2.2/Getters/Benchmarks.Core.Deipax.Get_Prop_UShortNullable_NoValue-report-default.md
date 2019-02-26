
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.2011 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1398 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
             ToChar |  1.3701 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1397 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
            ToSByte |  1.2683 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.3774 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
             ToByte |  1.3204 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.3674 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
            ToShort |  1.2264 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.3656 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
           ToUShort |  1.2071 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   ToUShortNullable |  0.9614 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
              ToInt |  1.3192 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1404 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
             ToUInt |  1.3950 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1388 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
             ToLong |  1.2081 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.8323 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToULong |  1.2025 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.8627 ns | 0.0055 ns | 0.0048 ns |           - |           - |           - |                   - |
            ToFloat |  1.3889 ns | 0.0007 ns | 0.0006 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3730 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
           ToDouble |  1.3989 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.1046 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
          ToDecimal |  2.2081 ns | 0.2361 ns | 0.2810 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.5605 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
         ToDateTime |  2.1107 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.3554 ns | 0.0058 ns | 0.0051 ns |           - |           - |           - |                   - |
           ToObject |  1.2503 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
          To_String |  1.3929 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
             ToEnum |  1.5055 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3675 ns | 0.0069 ns | 0.0054 ns |           - |           - |           - |                   - |
