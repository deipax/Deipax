
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.7443 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
     ToBoolNullable |  1.1060 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
             ToChar |  0.6766 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9407 ns | 0.0274 ns | 0.0256 ns |           - |           - |           - |                   - |
            ToSByte |  1.5500 ns | 0.0152 ns | 0.0142 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.3574 ns | 0.0182 ns | 0.0161 ns |           - |           - |           - |                   - |
             ToByte |  1.5549 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.3747 ns | 0.0254 ns | 0.0237 ns |           - |           - |           - |                   - |
            ToShort |  1.6459 ns | 0.0096 ns | 0.0085 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.3980 ns | 0.0258 ns | 0.0241 ns |           - |           - |           - |                   - |
           ToUShort |  1.5646 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.3556 ns | 0.0217 ns | 0.0203 ns |           - |           - |           - |                   - |
              ToInt |  1.5298 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3789 ns | 0.0285 ns | 0.0266 ns |           - |           - |           - |                   - |
             ToUInt |  1.5285 ns | 0.0148 ns | 0.0138 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.3779 ns | 0.0391 ns | 0.0366 ns |           - |           - |           - |                   - |
             ToLong |  1.5425 ns | 0.0156 ns | 0.0138 ns |           - |           - |           - |                   - |
     ToLongNullable |  3.2051 ns | 0.0245 ns | 0.0229 ns |           - |           - |           - |                   - |
            ToULong |  1.5598 ns | 0.0155 ns | 0.0129 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.6887 ns | 0.0250 ns | 0.0233 ns |           - |           - |           - |                   - |
            ToFloat |  1.7685 ns | 0.0242 ns | 0.0226 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.8136 ns | 0.0254 ns | 0.0225 ns |           - |           - |           - |                   - |
           ToDouble |  1.3286 ns | 0.0166 ns | 0.0156 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.6551 ns | 0.0252 ns | 0.0235 ns |           - |           - |           - |                   - |
          ToDecimal |  6.3540 ns | 0.0410 ns | 0.0384 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.4348 ns | 0.0961 ns | 0.0899 ns |           - |           - |           - |                   - |
         ToDateTime |  1.3276 ns | 0.0210 ns | 0.0196 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.9478 ns | 0.0311 ns | 0.0291 ns |           - |           - |           - |                   - |
           ToObject |  3.4609 ns | 0.0227 ns | 0.0201 ns |      0.0038 |           - |           - |                24 B |
          To_String |  3.0553 ns | 0.0253 ns | 0.0237 ns |           - |           - |           - |                   - |
             ToEnum | 14.0888 ns | 0.1318 ns | 0.1233 ns |           - |           - |           - |                   - |
     ToEnumNullable | 18.3686 ns | 0.0781 ns | 0.0731 ns |           - |           - |           - |                   - |
