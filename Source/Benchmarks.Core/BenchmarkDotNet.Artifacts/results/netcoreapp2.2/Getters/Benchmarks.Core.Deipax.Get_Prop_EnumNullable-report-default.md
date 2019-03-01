
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.630 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.431 ns | 0.0175 ns | 0.0155 ns |           - |           - |           - |                   - |
             ToChar |  2.804 ns | 0.0180 ns | 0.0168 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.162 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
            ToSByte |  2.711 ns | 0.0111 ns | 0.0093 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.145 ns | 0.0169 ns | 0.0141 ns |           - |           - |           - |                   - |
             ToByte |  2.456 ns | 0.0128 ns | 0.0119 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.113 ns | 0.0197 ns | 0.0165 ns |           - |           - |           - |                   - |
            ToShort |  2.711 ns | 0.0127 ns | 0.0106 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.115 ns | 0.0100 ns | 0.0084 ns |           - |           - |           - |                   - |
           ToUShort |  2.589 ns | 0.0073 ns | 0.0061 ns |           - |           - |           - |                   - |
   ToUShortNullable |  5.133 ns | 0.0136 ns | 0.0121 ns |           - |           - |           - |                   - |
              ToInt |  1.766 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.204 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
             ToUInt |  1.661 ns | 0.0122 ns | 0.0108 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.436 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
             ToLong |  1.510 ns | 0.0120 ns | 0.0113 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.838 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
            ToULong |  1.694 ns | 0.0325 ns | 0.0304 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.116 ns | 0.0265 ns | 0.0235 ns |           - |           - |           - |                   - |
            ToFloat |  1.389 ns | 0.0086 ns | 0.0071 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.678 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
           ToDouble |  1.380 ns | 0.0069 ns | 0.0058 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.086 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
          ToDecimal |  6.109 ns | 0.0524 ns | 0.0465 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.411 ns | 0.3869 ns | 0.3430 ns |           - |           - |           - |                   - |
         ToDateTime |  2.338 ns | 0.0742 ns | 0.0694 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.225 ns | 0.0347 ns | 0.0308 ns |           - |           - |           - |                   - |
           ToObject |  4.670 ns | 0.1160 ns | 0.1191 ns |      0.0038 |           - |           - |                24 B |
          To_String | 53.604 ns | 0.8141 ns | 0.7217 ns |      0.0038 |           - |           - |                24 B |
             ToEnum |  1.679 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
     ToEnumNullable |  1.166 ns | 0.0142 ns | 0.0126 ns |           - |           - |           - |                   - |
