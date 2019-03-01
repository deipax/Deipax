
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.436 ns | 0.0023 ns | 0.0018 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.378 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
             ToChar |  1.683 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.379 ns | 0.0042 ns | 0.0040 ns |           - |           - |           - |                   - |
            ToSByte |  2.597 ns | 0.0060 ns | 0.0057 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.048 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
             ToByte |  2.612 ns | 0.0048 ns | 0.0044 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.048 ns | 0.0039 ns | 0.0037 ns |           - |           - |           - |                   - |
            ToShort |  1.637 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToShortNullable |  1.147 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
           ToUShort |  1.956 ns | 0.0031 ns | 0.0027 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.361 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
              ToInt |  1.465 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.361 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToUInt |  1.849 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.362 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
             ToLong |  1.607 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.127 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
            ToULong |  1.680 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.248 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
            ToFloat |  1.449 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.590 ns | 0.0028 ns | 0.0024 ns |           - |           - |           - |                   - |
           ToDouble |  1.603 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.249 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
          ToDecimal |  5.963 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.548 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
         ToDateTime |  2.164 ns | 0.0099 ns | 0.0077 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.163 ns | 0.0210 ns | 0.0196 ns |           - |           - |           - |                   - |
           ToObject |  4.421 ns | 0.0040 ns | 0.0038 ns |      0.0038 |           - |           - |                24 B |
          To_String | 17.186 ns | 0.0119 ns | 0.0112 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.230 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.582 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
