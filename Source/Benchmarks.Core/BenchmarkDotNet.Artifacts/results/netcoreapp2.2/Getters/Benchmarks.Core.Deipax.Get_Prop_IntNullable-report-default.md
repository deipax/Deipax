
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.615 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.381 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
             ToChar |  2.746 ns | 0.0229 ns | 0.0215 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.076 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
            ToSByte |  2.676 ns | 0.0226 ns | 0.0212 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.047 ns | 0.0048 ns | 0.0045 ns |           - |           - |           - |                   - |
             ToByte |  2.828 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.047 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
            ToShort |  2.662 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.047 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
           ToUShort |  2.607 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
   ToUShortNullable |  5.063 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
              ToInt |  1.636 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
      ToIntNullable |  1.148 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
             ToUInt |  1.691 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.369 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
             ToLong |  1.614 ns | 0.0591 ns | 0.1657 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.905 ns | 0.0054 ns | 0.0050 ns |           - |           - |           - |                   - |
            ToULong |  1.692 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.176 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToFloat |  1.435 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.589 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
           ToDouble |  1.520 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.233 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
          ToDecimal |  5.961 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.870 ns | 0.0223 ns | 0.0208 ns |           - |           - |           - |                   - |
         ToDateTime |  2.315 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.247 ns | 0.0258 ns | 0.0242 ns |           - |           - |           - |                   - |
           ToObject |  4.360 ns | 0.0094 ns | 0.0078 ns |      0.0038 |           - |           - |                24 B |
          To_String | 17.475 ns | 0.0230 ns | 0.0215 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.281 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.619 ns | 0.0209 ns | 0.0196 ns |           - |           - |           - |                   - |
