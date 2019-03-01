
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |         NA |        NA |        NA |           - |           - |           - |                   - |
     ToBoolNullable |         NA |        NA |        NA |           - |           - |           - |                   - |
             ToChar |  2.1323 ns | 0.0130 ns | 0.0121 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.2337 ns | 0.0328 ns | 0.0306 ns |           - |           - |           - |                   - |
            ToSByte | 42.9384 ns | 0.3353 ns | 0.3137 ns |           - |           - |           - |                   - |
    ToSByteNullable | 42.8862 ns | 0.1940 ns | 0.1720 ns |           - |           - |           - |                   - |
             ToByte | 42.9737 ns | 0.2414 ns | 0.2258 ns |           - |           - |           - |                   - |
     ToByteNullable | 43.0221 ns | 0.2845 ns | 0.2661 ns |           - |           - |           - |                   - |
            ToShort | 42.7306 ns | 0.2802 ns | 0.2621 ns |           - |           - |           - |                   - |
    ToShortNullable | 43.0353 ns | 0.2290 ns | 0.2030 ns |           - |           - |           - |                   - |
           ToUShort | 43.5883 ns | 0.2964 ns | 0.2773 ns |           - |           - |           - |                   - |
   ToUShortNullable | 44.4251 ns | 0.3348 ns | 0.3131 ns |           - |           - |           - |                   - |
              ToInt | 41.9337 ns | 0.2136 ns | 0.1783 ns |           - |           - |           - |                   - |
      ToIntNullable | 42.3962 ns | 0.2275 ns | 0.2016 ns |           - |           - |           - |                   - |
             ToUInt | 42.6712 ns | 0.2973 ns | 0.2781 ns |           - |           - |           - |                   - |
     ToUIntNullable | 43.4256 ns | 0.6563 ns | 0.6139 ns |           - |           - |           - |                   - |
             ToLong | 43.5205 ns | 0.3425 ns | 0.3203 ns |           - |           - |           - |                   - |
     ToLongNullable | 44.8965 ns | 0.2330 ns | 0.2066 ns |           - |           - |           - |                   - |
            ToULong | 43.6346 ns | 0.2683 ns | 0.2510 ns |           - |           - |           - |                   - |
    ToULongNullable | 45.4499 ns | 0.2039 ns | 0.1907 ns |           - |           - |           - |                   - |
            ToFloat | 56.0952 ns | 0.1568 ns | 0.1467 ns |           - |           - |           - |                   - |
    ToFloatNullable | 56.3237 ns | 0.3825 ns | 0.3578 ns |           - |           - |           - |                   - |
           ToDouble | 56.2703 ns | 0.3361 ns | 0.2980 ns |           - |           - |           - |                   - |
   ToDoubleNullable | 57.6738 ns | 0.4476 ns | 0.4187 ns |           - |           - |           - |                   - |
          ToDecimal | 67.7106 ns | 0.4145 ns | 0.3674 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 76.0863 ns | 0.3756 ns | 0.3330 ns |           - |           - |           - |                   - |
         ToDateTime |         NA |        NA |        NA |           - |           - |           - |                   - |
 ToDateTimeNullable |         NA |        NA |        NA |           - |           - |           - |                   - |
           ToObject |  1.8442 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
          To_String |  0.4088 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
             ToEnum | 25.5010 ns | 0.1640 ns | 0.1534 ns |           - |           - |           - |                   - |
     ToEnumNullable | 28.4877 ns | 0.1308 ns | 0.1224 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  Get_Prop_String.ToBool: DefaultJob
  Get_Prop_String.ToBoolNullable: DefaultJob
  Get_Prop_String.ToDateTime: DefaultJob
  Get_Prop_String.ToDateTimeNullable: DefaultJob
