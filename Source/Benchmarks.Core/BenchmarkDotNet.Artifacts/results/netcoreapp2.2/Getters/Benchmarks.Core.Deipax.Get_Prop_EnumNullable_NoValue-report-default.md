
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.620 ns | 0.0362 ns | 0.0339 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.255 ns | 0.0370 ns | 0.0309 ns |           - |           - |           - |                   - |
             ToChar |  1.391 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.222 ns | 0.0055 ns | 0.0052 ns |           - |           - |           - |                   - |
            ToSByte |  1.574 ns | 0.0205 ns | 0.0182 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.207 ns | 0.0194 ns | 0.0172 ns |           - |           - |           - |                   - |
             ToByte |  1.428 ns | 0.0124 ns | 0.0104 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.208 ns | 0.0188 ns | 0.0167 ns |           - |           - |           - |                   - |
            ToShort |  1.560 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.265 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
           ToUShort |  1.424 ns | 0.0167 ns | 0.0156 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.246 ns | 0.0332 ns | 0.0310 ns |           - |           - |           - |                   - |
              ToInt |  1.773 ns | 0.0082 ns | 0.0068 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.318 ns | 0.1121 ns | 0.1200 ns |           - |           - |           - |                   - |
             ToUInt |  1.433 ns | 0.0178 ns | 0.0158 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.475 ns | 0.0288 ns | 0.0241 ns |           - |           - |           - |                   - |
             ToLong |  1.449 ns | 0.0168 ns | 0.0140 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.849 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
            ToULong |  1.442 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.104 ns | 0.0384 ns | 0.0340 ns |           - |           - |           - |                   - |
            ToFloat |  1.381 ns | 0.0032 ns | 0.0025 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.464 ns | 0.0244 ns | 0.0228 ns |           - |           - |           - |                   - |
           ToDouble |  1.606 ns | 0.0086 ns | 0.0072 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.090 ns | 0.0150 ns | 0.0133 ns |           - |           - |           - |                   - |
          ToDecimal |  2.319 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.764 ns | 0.0364 ns | 0.0322 ns |           - |           - |           - |                   - |
         ToDateTime |  2.542 ns | 0.0154 ns | 0.0120 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.282 ns | 0.0169 ns | 0.0132 ns |           - |           - |           - |                   - |
           ToObject |  1.484 ns | 0.0047 ns | 0.0037 ns |           - |           - |           - |                   - |
          To_String |  1.651 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
             ToEnum |  1.522 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
     ToEnumNullable |  1.150 ns | 0.0046 ns | 0.0041 ns |           - |           - |           - |                   - |
