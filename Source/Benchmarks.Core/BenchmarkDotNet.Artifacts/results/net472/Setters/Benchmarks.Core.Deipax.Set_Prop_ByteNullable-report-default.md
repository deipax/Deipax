
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev |     Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|-----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9308 ns | 0.0466 ns | 0.0876 ns |  0.8871 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.0631 ns | 0.0171 ns | 0.0160 ns |  2.0673 ns |           - |           - |           - |                   - |
             FromChar |  1.7702 ns | 0.0129 ns | 0.0121 ns |  1.7735 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.6598 ns | 0.0160 ns | 0.0141 ns |  2.6591 ns |           - |           - |           - |                   - |
            FromSByte |  1.7519 ns | 0.0115 ns | 0.0108 ns |  1.7527 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.7777 ns | 0.0323 ns | 0.0302 ns |  2.7655 ns |           - |           - |           - |                   - |
             FromByte |  0.6763 ns | 0.0125 ns | 0.0111 ns |  0.6737 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.6834 ns | 0.0112 ns | 0.0105 ns |  0.6817 ns |           - |           - |           - |                   - |
            FromShort |  1.9848 ns | 0.0162 ns | 0.0152 ns |  1.9808 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.6720 ns | 0.0264 ns | 0.0247 ns |  2.6667 ns |           - |           - |           - |                   - |
           FromUShort |  1.7822 ns | 0.0156 ns | 0.0146 ns |  1.7781 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.5988 ns | 0.0222 ns | 0.0207 ns |  2.6012 ns |           - |           - |           - |                   - |
              FromInt |  1.6349 ns | 0.0157 ns | 0.0146 ns |  1.6317 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.6540 ns | 0.0200 ns | 0.0187 ns |  2.6494 ns |           - |           - |           - |                   - |
             FromUInt |  1.8474 ns | 0.0148 ns | 0.0139 ns |  1.8520 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.5326 ns | 0.0274 ns | 0.0256 ns |  2.5335 ns |           - |           - |           - |                   - |
             FromLong |  1.9430 ns | 0.0128 ns | 0.0114 ns |  1.9420 ns |           - |           - |           - |                   - |
     FromLongNullable |  3.1124 ns | 0.0167 ns | 0.0157 ns |  3.1092 ns |           - |           - |           - |                   - |
            FromULong |  1.6733 ns | 0.0169 ns | 0.0158 ns |  1.6699 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.8172 ns | 0.0177 ns | 0.0166 ns |  2.8208 ns |           - |           - |           - |                   - |
            FromFloat |  3.6449 ns | 0.0290 ns | 0.0271 ns |  3.6373 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.1603 ns | 0.0416 ns | 0.0389 ns |  4.1655 ns |           - |           - |           - |                   - |
           FromDouble |  3.5309 ns | 0.0353 ns | 0.0331 ns |  3.5224 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.6688 ns | 0.0358 ns | 0.0335 ns |  4.6590 ns |           - |           - |           - |                   - |
          FromDecimal | 13.0557 ns | 0.0575 ns | 0.0538 ns | 13.0684 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.9900 ns | 0.1191 ns | 0.1114 ns | 24.0043 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8973 ns | 0.0198 ns | 0.0185 ns |  0.8972 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5284 ns | 0.0122 ns | 0.0114 ns |  1.5258 ns |           - |           - |           - |                   - |
           FromObject | 12.7713 ns | 0.0498 ns | 0.0441 ns | 12.7671 ns |           - |           - |           - |                   - |
           FromString | 44.1419 ns | 0.2864 ns | 0.2679 ns | 44.1804 ns |           - |           - |           - |                   - |
             FromEnum |  1.7726 ns | 0.0161 ns | 0.0150 ns |  1.7685 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.6265 ns | 0.0221 ns | 0.0207 ns |  2.6268 ns |           - |           - |           - |                   - |
