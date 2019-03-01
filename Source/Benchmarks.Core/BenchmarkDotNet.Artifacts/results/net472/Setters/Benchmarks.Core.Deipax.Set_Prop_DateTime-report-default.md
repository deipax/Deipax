
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   0.6670 ns | 0.0158 ns | 0.0148 ns |           - |           - |           - |                   - |
     FromBoolNullable |   0.8829 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
             FromChar |   0.6667 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
     FromCharNullable |   0.7013 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
            FromSByte |   0.6638 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
    FromSByteNullable |   0.6797 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
             FromByte |   0.6656 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
     FromByteNullable |   0.6876 ns | 0.0108 ns | 0.0095 ns |           - |           - |           - |                   - |
            FromShort |   0.6689 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
    FromShortNullable |   0.8881 ns | 0.0181 ns | 0.0170 ns |           - |           - |           - |                   - |
           FromUShort |   0.6636 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
   FromUShortNullable |   0.7019 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
              FromInt |   0.6659 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
      FromIntNullable |   1.0465 ns | 0.0102 ns | 0.0090 ns |           - |           - |           - |                   - |
             FromUInt |   0.6204 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
     FromUIntNullable |   0.7200 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
             FromLong |   0.6167 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
     FromLongNullable |   1.0759 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
            FromULong |   0.6176 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
    FromULongNullable |   1.0705 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
            FromFloat |   0.6222 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
    FromFloatNullable |   0.7341 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
           FromDouble |   0.6309 ns | 0.0152 ns | 0.0142 ns |           - |           - |           - |                   - |
   FromDoubleNullable |   1.0655 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
          FromDecimal |   1.2657 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
  FromDecimalNullable |   1.3002 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
         FromDateTime |   0.6194 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |   1.9290 ns | 0.0140 ns | 0.0124 ns |           - |           - |           - |                   - |
           FromObject |   2.0960 ns | 0.0152 ns | 0.0134 ns |           - |           - |           - |                   - |
           FromString | 605.9271 ns | 3.7945 ns | 3.5494 ns |           - |           - |           - |                   - |
             FromEnum |   0.6263 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
     FromEnumNullable |   0.7148 ns | 0.0152 ns | 0.0142 ns |           - |           - |           - |                   - |
