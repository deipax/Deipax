
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.4029 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9803 ns | 0.0331 ns | 0.0309 ns |           - |           - |           - |                   - |
             ToChar |  1.5075 ns | 0.0173 ns | 0.0162 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.5614 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
            ToSByte |  1.2936 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.5637 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
             ToByte |  1.2882 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.5935 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
            ToShort |  1.2845 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.5955 ns | 0.0271 ns | 0.0254 ns |           - |           - |           - |                   - |
           ToUShort |  1.7183 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.5772 ns | 0.0215 ns | 0.0201 ns |           - |           - |           - |                   - |
              ToInt |  0.4100 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
      ToIntNullable |  3.9479 ns | 0.0307 ns | 0.0287 ns |           - |           - |           - |                   - |
             ToUInt |  1.2798 ns | 0.0079 ns | 0.0070 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.3796 ns | 0.0448 ns | 0.0419 ns |           - |           - |           - |                   - |
             ToLong |  0.7181 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.7530 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
            ToULong |  1.3979 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.4575 ns | 0.0211 ns | 0.0198 ns |           - |           - |           - |                   - |
            ToFloat |  0.4077 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.1694 ns | 0.0192 ns | 0.0179 ns |           - |           - |           - |                   - |
           ToDouble |  0.7958 ns | 0.0118 ns | 0.0111 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.5148 ns | 0.0079 ns | 0.0066 ns |           - |           - |           - |                   - |
          ToDecimal |  5.4681 ns | 0.0453 ns | 0.0424 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 16.7943 ns | 0.0847 ns | 0.0792 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1171 ns | 0.0174 ns | 0.0163 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.7364 ns | 0.0655 ns | 0.0580 ns |           - |           - |           - |                   - |
           ToObject |  2.3765 ns | 0.0166 ns | 0.0155 ns |      0.0038 |           - |           - |                24 B |
          To_String | 30.2559 ns | 0.2276 ns | 0.2129 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 13.7401 ns | 0.0423 ns | 0.0375 ns |           - |           - |           - |                   - |
     ToEnumNullable | 17.7943 ns | 0.0947 ns | 0.0886 ns |           - |           - |           - |                   - |
