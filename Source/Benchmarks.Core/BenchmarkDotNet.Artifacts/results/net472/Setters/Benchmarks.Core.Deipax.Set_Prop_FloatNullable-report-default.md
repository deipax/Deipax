
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8434 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.4181 ns | 0.0134 ns | 0.0119 ns |           - |           - |           - |                   - |
             FromChar |  0.5998 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9251 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
            FromSByte |  0.6790 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9949 ns | 0.0134 ns | 0.0119 ns |           - |           - |           - |                   - |
             FromByte |  0.5873 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.0042 ns | 0.0209 ns | 0.0195 ns |           - |           - |           - |                   - |
            FromShort |  0.6709 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.8912 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
           FromUShort |  0.7150 ns | 0.0125 ns | 0.0111 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8669 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
              FromInt |  0.5934 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.9224 ns | 0.0117 ns | 0.0109 ns |           - |           - |           - |                   - |
             FromUInt |  0.7312 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9919 ns | 0.0236 ns | 0.0221 ns |           - |           - |           - |                   - |
             FromLong |  0.7542 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.2100 ns | 0.0095 ns | 0.0084 ns |           - |           - |           - |                   - |
            FromULong |  1.0978 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.4454 ns | 0.0232 ns | 0.0217 ns |           - |           - |           - |                   - |
            FromFloat |  0.6827 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
    FromFloatNullable |  0.8857 ns | 0.0095 ns | 0.0088 ns |           - |           - |           - |                   - |
           FromDouble |  0.9144 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  2.3105 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
          FromDecimal | 10.0063 ns | 0.0598 ns | 0.0559 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.2468 ns | 0.1949 ns | 0.1823 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8756 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5711 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
           FromObject | 12.7289 ns | 0.0366 ns | 0.0324 ns |           - |           - |           - |                   - |
           FromString | 57.0200 ns | 0.2832 ns | 0.2649 ns |           - |           - |           - |                   - |
             FromEnum |  0.8982 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.9383 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
