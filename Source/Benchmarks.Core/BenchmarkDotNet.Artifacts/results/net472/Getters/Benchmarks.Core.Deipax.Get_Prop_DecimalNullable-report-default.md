
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool | 16.1170 ns | 0.0954 ns | 0.0892 ns |           - |           - |           - |                   - |
     ToBoolNullable | 19.5565 ns | 0.1089 ns | 0.1018 ns |           - |           - |           - |                   - |
             ToChar |  0.4071 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9430 ns | 0.0347 ns | 0.0325 ns |           - |           - |           - |                   - |
            ToSByte | 22.4886 ns | 0.1399 ns | 0.1309 ns |           - |           - |           - |                   - |
    ToSByteNullable | 26.1098 ns | 0.1004 ns | 0.0939 ns |           - |           - |           - |                   - |
             ToByte | 22.0454 ns | 0.1157 ns | 0.1083 ns |           - |           - |           - |                   - |
     ToByteNullable | 26.3019 ns | 0.1604 ns | 0.1422 ns |           - |           - |           - |                   - |
            ToShort | 22.0233 ns | 0.1238 ns | 0.1158 ns |           - |           - |           - |                   - |
    ToShortNullable | 25.9483 ns | 0.1288 ns | 0.1205 ns |           - |           - |           - |                   - |
           ToUShort | 21.8884 ns | 0.0868 ns | 0.0812 ns |           - |           - |           - |                   - |
   ToUShortNullable | 30.5739 ns | 0.1302 ns | 0.1218 ns |           - |           - |           - |                   - |
              ToInt | 15.5367 ns | 0.0983 ns | 0.0919 ns |           - |           - |           - |                   - |
      ToIntNullable | 18.8180 ns | 0.0814 ns | 0.0762 ns |           - |           - |           - |                   - |
             ToUInt | 21.5228 ns | 0.0766 ns | 0.0679 ns |           - |           - |           - |                   - |
     ToUIntNullable | 25.4888 ns | 0.1768 ns | 0.1654 ns |           - |           - |           - |                   - |
             ToLong | 21.8553 ns | 0.0942 ns | 0.0835 ns |           - |           - |           - |                   - |
     ToLongNullable | 23.2203 ns | 0.1480 ns | 0.1385 ns |           - |           - |           - |                   - |
            ToULong | 21.7030 ns | 0.1219 ns | 0.1081 ns |           - |           - |           - |                   - |
    ToULongNullable | 22.8488 ns | 0.0922 ns | 0.0770 ns |           - |           - |           - |                   - |
            ToFloat | 22.8462 ns | 0.1127 ns | 0.1054 ns |           - |           - |           - |                   - |
    ToFloatNullable | 26.2457 ns | 0.1279 ns | 0.1197 ns |           - |           - |           - |                   - |
           ToDouble | 20.5208 ns | 0.1032 ns | 0.0915 ns |           - |           - |           - |                   - |
   ToDoubleNullable | 21.8945 ns | 0.1083 ns | 0.1013 ns |           - |           - |           - |                   - |
          ToDecimal |  2.0894 ns | 0.0206 ns | 0.0192 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.4253 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
         ToDateTime |  0.9172 ns | 0.0112 ns | 0.0099 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.6475 ns | 0.0579 ns | 0.0542 ns |           - |           - |           - |                   - |
           ToObject |  3.8213 ns | 0.0223 ns | 0.0209 ns |      0.0051 |           - |           - |                32 B |
          To_String | 53.2157 ns | 0.1607 ns | 0.1503 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 27.5933 ns | 0.1867 ns | 0.1746 ns |           - |           - |           - |                   - |
     ToEnumNullable | 30.9093 ns | 0.1546 ns | 0.1446 ns |           - |           - |           - |                   - |
