
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9152 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9307 ns | 0.0286 ns | 0.0267 ns |           - |           - |           - |                   - |
             ToChar |  0.9148 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1643 ns | 0.0380 ns | 0.0356 ns |           - |           - |           - |                   - |
            ToSByte |  0.9149 ns | 0.0116 ns | 0.0109 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1458 ns | 0.0241 ns | 0.0225 ns |           - |           - |           - |                   - |
             ToByte |  0.9338 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1296 ns | 0.0216 ns | 0.0191 ns |           - |           - |           - |                   - |
            ToShort |  0.9142 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1469 ns | 0.0338 ns | 0.0316 ns |           - |           - |           - |                   - |
           ToUShort |  0.9230 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1616 ns | 0.0351 ns | 0.0329 ns |           - |           - |           - |                   - |
              ToInt |  0.8863 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1470 ns | 0.0300 ns | 0.0280 ns |           - |           - |           - |                   - |
             ToUInt |  0.8878 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1487 ns | 0.0322 ns | 0.0301 ns |           - |           - |           - |                   - |
             ToLong |  1.2404 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.5499 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
            ToULong |  0.8924 ns | 0.0085 ns | 0.0079 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.7716 ns | 0.0111 ns | 0.0098 ns |           - |           - |           - |                   - |
            ToFloat |  0.9501 ns | 0.0132 ns | 0.0123 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3535 ns | 0.0257 ns | 0.0241 ns |           - |           - |           - |                   - |
           ToDouble |  0.9600 ns | 0.0156 ns | 0.0122 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.9977 ns | 0.0150 ns | 0.0133 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6888 ns | 0.0411 ns | 0.0365 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.8388 ns | 0.0491 ns | 0.0460 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1053 ns | 0.0114 ns | 0.0095 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.9970 ns | 0.0517 ns | 0.0484 ns |           - |           - |           - |                   - |
           ToObject |  0.9160 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
          To_String |  1.2503 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
             ToEnum |  1.2154 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3712 ns | 0.0286 ns | 0.0267 ns |           - |           - |           - |                   - |
