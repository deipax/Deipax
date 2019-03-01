
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.6741 ns | 0.0232 ns | 0.0217 ns |           - |           - |           - |                   - |
     ToBoolNullable | 10.6855 ns | 0.0694 ns | 0.0649 ns |           - |           - |           - |                   - |
             ToChar |  0.8759 ns | 0.0107 ns | 0.0094 ns |           - |           - |           - |                   - |
     ToCharNullable | 10.6496 ns | 0.0358 ns | 0.0335 ns |           - |           - |           - |                   - |
            ToSByte |  0.8456 ns | 0.0167 ns | 0.0157 ns |           - |           - |           - |                   - |
    ToSByteNullable | 10.6072 ns | 0.0440 ns | 0.0411 ns |           - |           - |           - |                   - |
             ToByte |  0.8928 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
     ToByteNullable | 10.6598 ns | 0.0414 ns | 0.0367 ns |           - |           - |           - |                   - |
            ToShort |  0.6684 ns | 0.0063 ns | 0.0056 ns |           - |           - |           - |                   - |
    ToShortNullable | 11.9573 ns | 0.0584 ns | 0.0546 ns |           - |           - |           - |                   - |
           ToUShort |  0.8820 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
   ToUShortNullable | 11.9209 ns | 0.0458 ns | 0.0406 ns |           - |           - |           - |                   - |
              ToInt |  0.6719 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
      ToIntNullable | 11.9654 ns | 0.0659 ns | 0.0616 ns |           - |           - |           - |                   - |
             ToUInt |  0.8798 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
     ToUIntNullable | 12.0461 ns | 0.0923 ns | 0.0864 ns |           - |           - |           - |                   - |
             ToLong |  0.6824 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.5428 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
            ToULong |  0.6705 ns | 0.0163 ns | 0.0152 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.5282 ns | 0.0132 ns | 0.0123 ns |           - |           - |           - |                   - |
            ToFloat |  0.8757 ns | 0.0074 ns | 0.0058 ns |           - |           - |           - |                   - |
    ToFloatNullable | 12.0271 ns | 0.0566 ns | 0.0502 ns |           - |           - |           - |                   - |
           ToDouble |  0.6844 ns | 0.0196 ns | 0.0174 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.8153 ns | 0.0216 ns | 0.0202 ns |           - |           - |           - |                   - |
          ToDecimal | 10.3911 ns | 0.0352 ns | 0.0329 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.6887 ns | 0.0152 ns | 0.0135 ns |           - |           - |           - |                   - |
         ToDateTime |  1.4909 ns | 0.0123 ns | 0.0109 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  1.4648 ns | 0.0162 ns | 0.0152 ns |           - |           - |           - |                   - |
           ToObject |  0.9371 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
          To_String |  1.4005 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
             ToEnum |  1.4570 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
     ToEnumNullable |  9.2856 ns | 0.0305 ns | 0.0270 ns |           - |           - |           - |                   - |
