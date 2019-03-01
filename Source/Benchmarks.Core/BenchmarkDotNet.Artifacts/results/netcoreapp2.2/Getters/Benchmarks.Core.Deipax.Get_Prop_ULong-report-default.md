
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.351 ns | 0.0037 ns | 0.0033 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.156 ns | 0.0305 ns | 0.0255 ns |           - |           - |           - |                   - |
             ToChar |  2.207 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.847 ns | 0.0379 ns | 0.0336 ns |           - |           - |           - |                   - |
            ToSByte |  1.443 ns | 0.0176 ns | 0.0156 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.178 ns | 0.0409 ns | 0.0383 ns |           - |           - |           - |                   - |
             ToByte |  2.122 ns | 0.0257 ns | 0.0240 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.865 ns | 0.0419 ns | 0.0327 ns |           - |           - |           - |                   - |
            ToShort |  2.097 ns | 0.0122 ns | 0.0109 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.847 ns | 0.0241 ns | 0.0213 ns |           - |           - |           - |                   - |
           ToUShort |  2.162 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.818 ns | 0.0210 ns | 0.0186 ns |           - |           - |           - |                   - |
              ToInt |  2.213 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.612 ns | 0.0258 ns | 0.0242 ns |           - |           - |           - |                   - |
             ToUInt |  1.457 ns | 0.0121 ns | 0.0108 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.155 ns | 0.0200 ns | 0.0187 ns |           - |           - |           - |                   - |
             ToLong |  1.526 ns | 0.0256 ns | 0.0240 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.086 ns | 0.0341 ns | 0.0303 ns |           - |           - |           - |                   - |
            ToULong |  1.115 ns | 0.0098 ns | 0.0091 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.821 ns | 0.0197 ns | 0.0184 ns |           - |           - |           - |                   - |
            ToFloat |  1.880 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.828 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
           ToDouble |  1.756 ns | 0.0159 ns | 0.0141 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.802 ns | 0.0033 ns | 0.0026 ns |           - |           - |           - |                   - |
          ToDecimal |  5.765 ns | 0.0838 ns | 0.0742 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.502 ns | 0.1815 ns | 0.1698 ns |           - |           - |           - |                   - |
         ToDateTime |  2.264 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.330 ns | 0.0911 ns | 0.0808 ns |           - |           - |           - |                   - |
           ToObject |  3.597 ns | 0.0022 ns | 0.0019 ns |      0.0038 |           - |           - |                24 B |
          To_String | 18.549 ns | 0.0191 ns | 0.0169 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 10.505 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
     ToEnumNullable | 15.187 ns | 0.0086 ns | 0.0072 ns |           - |           - |           - |                   - |
