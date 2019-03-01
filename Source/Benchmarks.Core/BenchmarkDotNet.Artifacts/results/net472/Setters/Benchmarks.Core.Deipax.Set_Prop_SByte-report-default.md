
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8495 ns | 0.0234 ns | 0.0219 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.6738 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
             FromChar |  1.5916 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.0042 ns | 0.0189 ns | 0.0177 ns |           - |           - |           - |                   - |
            FromSByte |  0.2844 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1802 ns | 0.0162 ns | 0.0152 ns |           - |           - |           - |                   - |
             FromByte |  1.4997 ns | 0.0189 ns | 0.0167 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.1175 ns | 0.0166 ns | 0.0155 ns |           - |           - |           - |                   - |
            FromShort |  1.6202 ns | 0.0173 ns | 0.0154 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.0642 ns | 0.0207 ns | 0.0193 ns |           - |           - |           - |                   - |
           FromUShort |  1.5894 ns | 0.0154 ns | 0.0137 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.0098 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
              FromInt |  2.1539 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.0217 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
             FromUInt |  1.5459 ns | 0.0165 ns | 0.0155 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.1651 ns | 0.0216 ns | 0.0202 ns |           - |           - |           - |                   - |
             FromLong |  1.4213 ns | 0.0149 ns | 0.0132 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.6442 ns | 0.0322 ns | 0.0301 ns |           - |           - |           - |                   - |
            FromULong |  1.4957 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.8137 ns | 0.0246 ns | 0.0218 ns |           - |           - |           - |                   - |
            FromFloat |  3.7586 ns | 0.0362 ns | 0.0339 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.9615 ns | 0.0369 ns | 0.0345 ns |           - |           - |           - |                   - |
           FromDouble |  3.2734 ns | 0.0359 ns | 0.0336 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.5574 ns | 0.0326 ns | 0.0305 ns |           - |           - |           - |                   - |
          FromDecimal | 13.2089 ns | 0.0594 ns | 0.0527 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.6009 ns | 0.4081 ns | 0.3817 ns |           - |           - |           - |                   - |
         FromDateTime |  0.4466 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3575 ns | 0.0237 ns | 0.0221 ns |           - |           - |           - |                   - |
           FromObject |  2.1096 ns | 0.0144 ns | 0.0127 ns |           - |           - |           - |                   - |
           FromString | 43.7123 ns | 0.2708 ns | 0.2533 ns |           - |           - |           - |                   - |
             FromEnum |  1.5861 ns | 0.0217 ns | 0.0203 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.1741 ns | 0.0684 ns | 0.0702 ns |           - |           - |           - |                   - |
