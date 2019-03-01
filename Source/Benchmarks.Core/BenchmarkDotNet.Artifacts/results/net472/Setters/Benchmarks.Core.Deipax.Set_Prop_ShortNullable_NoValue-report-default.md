
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8790 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9274 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
             FromChar |  1.7684 ns | 0.0152 ns | 0.0143 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.7971 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
            FromSByte |  0.6979 ns | 0.0152 ns | 0.0142 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9336 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
             FromByte |  0.6898 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9393 ns | 0.0161 ns | 0.0150 ns |           - |           - |           - |                   - |
            FromShort |  0.6944 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
    FromShortNullable |  0.6656 ns | 0.0119 ns | 0.0106 ns |           - |           - |           - |                   - |
           FromUShort |  1.7632 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8759 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
              FromInt |  1.6647 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8758 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
             FromUInt |  1.6550 ns | 0.0157 ns | 0.0146 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8777 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
             FromLong |  1.7613 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.8948 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
            FromULong |  1.7046 ns | 0.0094 ns | 0.0083 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.8166 ns | 0.0123 ns | 0.0109 ns |           - |           - |           - |                   - |
            FromFloat |  3.6731 ns | 0.0205 ns | 0.0182 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.8684 ns | 0.0087 ns | 0.0073 ns |           - |           - |           - |                   - |
           FromDouble |  3.4300 ns | 0.0311 ns | 0.0260 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9522 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
          FromDecimal | 13.2708 ns | 0.0675 ns | 0.0632 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.2818 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8896 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5238 ns | 0.0128 ns | 0.0114 ns |           - |           - |           - |                   - |
           FromObject |  2.6973 ns | 0.0177 ns | 0.0157 ns |           - |           - |           - |                   - |
           FromString |  1.7221 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
             FromEnum |  1.6760 ns | 0.0172 ns | 0.0152 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8870 ns | 0.0166 ns | 0.0155 ns |           - |           - |           - |                   - |
