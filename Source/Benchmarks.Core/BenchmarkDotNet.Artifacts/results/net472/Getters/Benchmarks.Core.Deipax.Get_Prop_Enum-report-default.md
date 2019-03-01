
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   0.6667 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
     ToBoolNullable |   3.9404 ns | 0.0198 ns | 0.0185 ns |           - |           - |           - |                   - |
             ToChar |   1.7667 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.5807 ns | 0.0232 ns | 0.0217 ns |           - |           - |           - |                   - |
            ToSByte |   1.5407 ns | 0.0065 ns | 0.0054 ns |           - |           - |           - |                   - |
    ToSByteNullable |   4.5845 ns | 0.0212 ns | 0.0198 ns |           - |           - |           - |                   - |
             ToByte |   1.5186 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
     ToByteNullable |   4.5976 ns | 0.0321 ns | 0.0300 ns |           - |           - |           - |                   - |
            ToShort |   1.5405 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
    ToShortNullable |   4.5944 ns | 0.0314 ns | 0.0278 ns |           - |           - |           - |                   - |
           ToUShort |   1.9737 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
   ToUShortNullable |   4.5695 ns | 0.0189 ns | 0.0176 ns |           - |           - |           - |                   - |
              ToInt |   0.6597 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |
      ToIntNullable |   3.9434 ns | 0.0291 ns | 0.0272 ns |           - |           - |           - |                   - |
             ToUInt |   1.5237 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
     ToUIntNullable |   4.3550 ns | 0.0247 ns | 0.0206 ns |           - |           - |           - |                   - |
             ToLong |   0.6804 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
     ToLongNullable |   1.5904 ns | 0.0120 ns | 0.0106 ns |           - |           - |           - |                   - |
            ToULong |   1.5381 ns | 0.0163 ns | 0.0152 ns |           - |           - |           - |                   - |
    ToULongNullable |   2.4702 ns | 0.0284 ns | 0.0266 ns |           - |           - |           - |                   - |
            ToFloat |   0.6720 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.1392 ns | 0.0207 ns | 0.0194 ns |           - |           - |           - |                   - |
           ToDouble |   0.6742 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.8097 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
          ToDecimal |   5.4660 ns | 0.0345 ns | 0.0323 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  17.0666 ns | 0.0824 ns | 0.0771 ns |           - |           - |           - |                   - |
         ToDateTime |   1.1072 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   7.5291 ns | 0.0520 ns | 0.0486 ns |           - |           - |           - |                   - |
           ToObject |   2.4330 ns | 0.0335 ns | 0.0314 ns |      0.0038 |           - |           - |                24 B |
          To_String | 273.3745 ns | 1.4116 ns | 1.3204 ns |      0.0114 |           - |           - |                72 B |
             ToEnum |   0.6584 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
     ToEnumNullable |   3.9451 ns | 0.0269 ns | 0.0239 ns |           - |           - |           - |                   - |
