
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9199 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.8992 ns | 0.0210 ns | 0.0196 ns |           - |           - |           - |                   - |
             ToChar |  0.9145 ns | 0.0160 ns | 0.0133 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1397 ns | 0.0285 ns | 0.0267 ns |           - |           - |           - |                   - |
            ToSByte |  0.9153 ns | 0.0143 ns | 0.0127 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1446 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
             ToByte |  0.9133 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1321 ns | 0.0303 ns | 0.0283 ns |           - |           - |           - |                   - |
            ToShort |  0.9122 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1192 ns | 0.0164 ns | 0.0145 ns |           - |           - |           - |                   - |
           ToUShort |  0.9117 ns | 0.0134 ns | 0.0126 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1384 ns | 0.0344 ns | 0.0321 ns |           - |           - |           - |                   - |
              ToInt |  0.8798 ns | 0.0104 ns | 0.0087 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1124 ns | 0.0234 ns | 0.0219 ns |           - |           - |           - |                   - |
             ToUInt |  0.8945 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1235 ns | 0.0292 ns | 0.0273 ns |           - |           - |           - |                   - |
             ToLong |  0.8812 ns | 0.0166 ns | 0.0156 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.0277 ns | 0.0182 ns | 0.0161 ns |           - |           - |           - |                   - |
            ToULong |  0.9641 ns | 0.0104 ns | 0.0098 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.3287 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
            ToFloat |  0.9435 ns | 0.0102 ns | 0.0091 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3330 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
           ToDouble |  0.9321 ns | 0.0095 ns | 0.0085 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.0528 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
          ToDecimal |  5.8765 ns | 0.0292 ns | 0.0273 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.5877 ns | 0.0889 ns | 0.0831 ns |           - |           - |           - |                   - |
         ToDateTime |  0.9374 ns | 0.0087 ns | 0.0073 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.8879 ns | 0.0400 ns | 0.0355 ns |           - |           - |           - |                   - |
           ToObject |  0.9180 ns | 0.0242 ns | 0.0214 ns |           - |           - |           - |                   - |
          To_String |  1.3765 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
             ToEnum |  1.5205 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3763 ns | 0.0397 ns | 0.0372 ns |           - |           - |           - |                   - |
