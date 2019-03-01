
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.0862 ns | 0.0128 ns | 0.0113 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.6664 ns | 0.0109 ns | 0.0096 ns |           - |           - |           - |                   - |
             FromChar |  0.6532 ns | 0.0174 ns | 0.0163 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.5377 ns | 0.0148 ns | 0.0131 ns |           - |           - |           - |                   - |
            FromSByte |  1.5702 ns | 0.0182 ns | 0.0170 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.2081 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
             FromByte |  0.6684 ns | 0.0097 ns | 0.0086 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.7587 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
            FromShort |  1.7568 ns | 0.0146 ns | 0.0136 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.3942 ns | 0.0235 ns | 0.0220 ns |           - |           - |           - |                   - |
           FromUShort |  0.6550 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.5548 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
              FromInt |  1.5593 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.0147 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
             FromUInt |  0.6669 ns | 0.0118 ns | 0.0111 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.6073 ns | 0.0127 ns | 0.0118 ns |           - |           - |           - |                   - |
             FromLong |  1.5477 ns | 0.0194 ns | 0.0172 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.5043 ns | 0.0267 ns | 0.0250 ns |           - |           - |           - |                   - |
            FromULong |  0.6661 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.6332 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
            FromFloat |  3.4565 ns | 0.0185 ns | 0.0155 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.7796 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
           FromDouble |  3.2814 ns | 0.0255 ns | 0.0226 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.2974 ns | 0.0256 ns | 0.0240 ns |           - |           - |           - |                   - |
          FromDecimal | 12.5482 ns | 0.0853 ns | 0.0798 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 22.3091 ns | 0.1045 ns | 0.0977 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6809 ns | 0.0115 ns | 0.0102 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3243 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
           FromObject |  2.1336 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
           FromString | 44.8554 ns | 0.2112 ns | 0.1976 ns |           - |           - |           - |                   - |
             FromEnum |  1.5608 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.1882 ns | 0.0179 ns | 0.0168 ns |           - |           - |           - |                   - |
