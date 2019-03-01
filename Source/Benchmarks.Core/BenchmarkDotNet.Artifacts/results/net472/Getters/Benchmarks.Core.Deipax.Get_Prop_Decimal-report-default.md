
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  6.4461 ns | 0.0469 ns | 0.0438 ns |           - |           - |           - |                   - |
     ToBoolNullable | 14.2543 ns | 0.0800 ns | 0.0749 ns |           - |           - |           - |                   - |
             ToChar |  0.6847 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9453 ns | 0.0405 ns | 0.0379 ns |           - |           - |           - |                   - |
            ToSByte | 12.7028 ns | 0.0885 ns | 0.0828 ns |           - |           - |           - |                   - |
    ToSByteNullable | 20.4896 ns | 0.0828 ns | 0.0774 ns |           - |           - |           - |                   - |
             ToByte | 12.2347 ns | 0.0427 ns | 0.0399 ns |           - |           - |           - |                   - |
     ToByteNullable | 20.3406 ns | 0.1345 ns | 0.1258 ns |           - |           - |           - |                   - |
            ToShort | 12.4484 ns | 0.0527 ns | 0.0467 ns |           - |           - |           - |                   - |
    ToShortNullable | 20.5826 ns | 0.1255 ns | 0.1173 ns |           - |           - |           - |                   - |
           ToUShort | 12.2206 ns | 0.0442 ns | 0.0413 ns |           - |           - |           - |                   - |
   ToUShortNullable | 20.5194 ns | 0.1187 ns | 0.1110 ns |           - |           - |           - |                   - |
              ToInt |  5.7317 ns | 0.0235 ns | 0.0220 ns |           - |           - |           - |                   - |
      ToIntNullable | 13.2981 ns | 0.0421 ns | 0.0373 ns |           - |           - |           - |                   - |
             ToUInt | 11.9664 ns | 0.0612 ns | 0.0572 ns |           - |           - |           - |                   - |
     ToUIntNullable | 19.7857 ns | 0.1354 ns | 0.1266 ns |           - |           - |           - |                   - |
             ToLong | 11.9060 ns | 0.0768 ns | 0.0718 ns |           - |           - |           - |                   - |
     ToLongNullable | 12.8211 ns | 0.0540 ns | 0.0479 ns |           - |           - |           - |                   - |
            ToULong | 11.6040 ns | 0.0653 ns | 0.0579 ns |           - |           - |           - |                   - |
    ToULongNullable | 12.5135 ns | 0.0670 ns | 0.0627 ns |           - |           - |           - |                   - |
            ToFloat |  8.5924 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
    ToFloatNullable | 14.9608 ns | 0.1110 ns | 0.1038 ns |           - |           - |           - |                   - |
           ToDouble |  6.3473 ns | 0.0396 ns | 0.0370 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  8.5418 ns | 0.0475 ns | 0.0444 ns |           - |           - |           - |                   - |
          ToDecimal |  1.6032 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  5.4851 ns | 0.0339 ns | 0.0317 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1205 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.8461 ns | 0.0578 ns | 0.0541 ns |           - |           - |           - |                   - |
           ToObject |  2.9583 ns | 0.0249 ns | 0.0233 ns |      0.0051 |           - |           - |                32 B |
          To_String | 47.4451 ns | 0.2132 ns | 0.1994 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 21.2533 ns | 0.1307 ns | 0.1223 ns |           - |           - |           - |                   - |
     ToEnumNullable | 25.4291 ns | 0.1433 ns | 0.1340 ns |           - |           - |           - |                   - |
