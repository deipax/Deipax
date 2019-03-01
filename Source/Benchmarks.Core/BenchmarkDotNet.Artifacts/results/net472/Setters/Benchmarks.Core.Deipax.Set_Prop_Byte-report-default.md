
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.0888 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.7452 ns | 0.0161 ns | 0.0143 ns |           - |           - |           - |                   - |
             FromChar |  1.7412 ns | 0.0138 ns | 0.0122 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.0365 ns | 0.0210 ns | 0.0196 ns |           - |           - |           - |                   - |
            FromSByte |  1.5990 ns | 0.0114 ns | 0.0101 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.1107 ns | 0.0163 ns | 0.0145 ns |           - |           - |           - |                   - |
             FromByte |  0.6839 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.3249 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
            FromShort |  1.7590 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.1843 ns | 0.0269 ns | 0.0252 ns |           - |           - |           - |                   - |
           FromUShort |  1.4639 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.1381 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
              FromInt |  1.5551 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.9954 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
             FromUInt |  1.7698 ns | 0.0105 ns | 0.0088 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.4014 ns | 0.0273 ns | 0.0256 ns |           - |           - |           - |                   - |
             FromLong |  1.5536 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.5611 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
            FromULong |  1.5480 ns | 0.0140 ns | 0.0117 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.7823 ns | 0.0340 ns | 0.0301 ns |           - |           - |           - |                   - |
            FromFloat |  3.5646 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.8706 ns | 0.0390 ns | 0.0365 ns |           - |           - |           - |                   - |
           FromDouble |  3.2067 ns | 0.0308 ns | 0.0288 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.3833 ns | 0.0226 ns | 0.0211 ns |           - |           - |           - |                   - |
          FromDecimal | 12.9571 ns | 0.0496 ns | 0.0464 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 22.9525 ns | 0.1504 ns | 0.1407 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6690 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3478 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
           FromObject |  2.1320 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
           FromString | 43.7253 ns | 0.1360 ns | 0.1273 ns |           - |           - |           - |                   - |
             FromEnum |  2.2008 ns | 0.0172 ns | 0.0161 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.1827 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
