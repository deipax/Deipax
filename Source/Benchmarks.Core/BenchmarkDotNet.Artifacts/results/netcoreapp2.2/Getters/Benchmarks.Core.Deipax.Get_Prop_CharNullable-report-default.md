
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.146 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.136 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
             ToChar |  1.649 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
     ToCharNullable |  1.137 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
            ToSByte |  1.824 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.363 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToByte |  1.634 ns | 0.0032 ns | 0.0028 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.365 ns | 0.0021 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToShort |  1.971 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.366 ns | 0.0025 ns | 0.0022 ns |           - |           - |           - |                   - |
           ToUShort |  1.610 ns | 0.0067 ns | 0.0060 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.370 ns | 0.0040 ns | 0.0035 ns |           - |           - |           - |                   - |
              ToInt |  1.732 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.369 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
             ToUInt |  1.591 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.370 ns | 0.0032 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToLong |  1.412 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.810 ns | 0.0041 ns | 0.0037 ns |           - |           - |           - |                   - |
            ToULong |  1.413 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.833 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
            ToFloat |  1.134 ns | 0.0020 ns | 0.0017 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.366 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
           ToDouble |  1.130 ns | 0.0020 ns | 0.0017 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.580 ns | 0.0026 ns | 0.0022 ns |           - |           - |           - |                   - |
          ToDecimal |  1.918 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.811 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
         ToDateTime |  2.111 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.128 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
           ToObject |  4.392 ns | 0.0142 ns | 0.0126 ns |      0.0038 |           - |           - |                24 B |
          To_String |  4.807 ns | 0.0076 ns | 0.0067 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.236 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.625 ns | 0.0087 ns | 0.0077 ns |           - |           - |           - |                   - |
