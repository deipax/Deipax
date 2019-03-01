
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   1.0806 ns | 0.0266 ns | 0.0249 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.7965 ns | 0.0394 ns | 0.0369 ns |           - |           - |           - |                   - |
             ToChar |   0.5168 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.1244 ns | 0.0308 ns | 0.0288 ns |           - |           - |           - |                   - |
            ToSByte |   3.6115 ns | 0.0290 ns | 0.0271 ns |           - |           - |           - |                   - |
    ToSByteNullable |   6.7254 ns | 0.0490 ns | 0.0458 ns |           - |           - |           - |                   - |
             ToByte |   3.5454 ns | 0.0296 ns | 0.0277 ns |           - |           - |           - |                   - |
     ToByteNullable |   6.7739 ns | 0.0506 ns | 0.0473 ns |           - |           - |           - |                   - |
            ToShort |   3.9520 ns | 0.0152 ns | 0.0142 ns |           - |           - |           - |                   - |
    ToShortNullable |   6.7422 ns | 0.0433 ns | 0.0405 ns |           - |           - |           - |                   - |
           ToUShort |   3.6496 ns | 0.0357 ns | 0.0334 ns |           - |           - |           - |                   - |
   ToUShortNullable |   6.7127 ns | 0.0274 ns | 0.0257 ns |           - |           - |           - |                   - |
              ToInt |   2.7434 ns | 0.0239 ns | 0.0223 ns |           - |           - |           - |                   - |
      ToIntNullable |   6.0846 ns | 0.0342 ns | 0.0286 ns |           - |           - |           - |                   - |
             ToUInt |   2.5329 ns | 0.0164 ns | 0.0146 ns |           - |           - |           - |                   - |
     ToUIntNullable |   6.0608 ns | 0.0331 ns | 0.0310 ns |           - |           - |           - |                   - |
             ToLong |   3.6741 ns | 0.0336 ns | 0.0314 ns |           - |           - |           - |                   - |
     ToLongNullable |   5.1642 ns | 0.0270 ns | 0.0252 ns |           - |           - |           - |                   - |
            ToULong |   3.6509 ns | 0.0248 ns | 0.0232 ns |           - |           - |           - |                   - |
    ToULongNullable |   5.0867 ns | 0.0293 ns | 0.0274 ns |           - |           - |           - |                   - |
            ToFloat |   1.0734 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.5601 ns | 0.0292 ns | 0.0273 ns |           - |           - |           - |                   - |
           ToDouble |   1.8554 ns | 0.0202 ns | 0.0189 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.4072 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
          ToDecimal |  51.8383 ns | 0.2414 ns | 0.2258 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  61.7130 ns | 0.4590 ns | 0.4293 ns |           - |           - |           - |                   - |
         ToDateTime |   1.0705 ns | 0.0091 ns | 0.0080 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   7.6883 ns | 0.0443 ns | 0.0415 ns |           - |           - |           - |                   - |
           ToObject |   3.4738 ns | 0.0164 ns | 0.0137 ns |      0.0038 |           - |           - |                24 B |
          To_String | 279.4447 ns | 2.7220 ns | 2.5462 ns |      0.0048 |           - |           - |                32 B |
             ToEnum |  16.5677 ns | 0.0748 ns | 0.0699 ns |           - |           - |           - |                   - |
     ToEnumNullable |  20.3833 ns | 0.0766 ns | 0.0717 ns |           - |           - |           - |                   - |
