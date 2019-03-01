
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.599 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.369 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
             ToChar |  1.913 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.357 ns | 0.0041 ns | 0.0037 ns |           - |           - |           - |                   - |
            ToSByte |  1.966 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.367 ns | 0.0025 ns | 0.0019 ns |           - |           - |           - |                   - |
             ToByte |  1.820 ns | 0.0034 ns | 0.0030 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.353 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
            ToShort |  2.974 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.057 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
           ToUShort |  1.971 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.354 ns | 0.0042 ns | 0.0040 ns |           - |           - |           - |                   - |
              ToInt |  1.820 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.377 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
             ToUInt |  1.641 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToUIntNullable |  1.143 ns | 0.0011 ns | 0.0011 ns |           - |           - |           - |                   - |
             ToLong |  1.413 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.815 ns | 0.0038 ns | 0.0036 ns |           - |           - |           - |                   - |
            ToULong |  1.600 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.049 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
            ToFloat |  1.618 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
    ToFloatNullable |  5.054 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
           ToDouble |  1.384 ns | 0.0010 ns | 0.0008 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.034 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
          ToDecimal |  5.740 ns | 0.0039 ns | 0.0037 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.203 ns | 0.0168 ns | 0.0149 ns |           - |           - |           - |                   - |
         ToDateTime |  2.279 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 12.161 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |
           ToObject |  4.400 ns | 0.0038 ns | 0.0032 ns |      0.0038 |           - |           - |                24 B |
          To_String | 16.973 ns | 0.0269 ns | 0.0252 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.222 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.665 ns | 0.0235 ns | 0.0220 ns |           - |           - |           - |                   - |
