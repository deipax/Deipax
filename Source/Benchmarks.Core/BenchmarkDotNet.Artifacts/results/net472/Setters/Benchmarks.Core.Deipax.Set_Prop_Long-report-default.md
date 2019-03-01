
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.0892 ns | 0.0117 ns | 0.0103 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.6745 ns | 0.0150 ns | 0.0133 ns |           - |           - |           - |                   - |
             FromChar |  0.6531 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.5466 ns | 0.0148 ns | 0.0138 ns |           - |           - |           - |                   - |
            FromSByte |  0.6802 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.6789 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
             FromByte |  0.6775 ns | 0.0099 ns | 0.0092 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.6811 ns | 0.0220 ns | 0.0195 ns |           - |           - |           - |                   - |
            FromShort |  0.6563 ns | 0.0123 ns | 0.0109 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.1709 ns | 0.0189 ns | 0.0177 ns |           - |           - |           - |                   - |
           FromUShort |  0.6662 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.5411 ns | 0.0094 ns | 0.0083 ns |           - |           - |           - |                   - |
              FromInt |  0.6899 ns | 0.0410 ns | 0.0421 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.5325 ns | 0.0081 ns | 0.0068 ns |           - |           - |           - |                   - |
             FromUInt |  0.6796 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.6195 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
             FromLong |  0.6697 ns | 0.0122 ns | 0.0115 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.7139 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
            FromULong |  1.5573 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.4906 ns | 0.0292 ns | 0.0273 ns |           - |           - |           - |                   - |
            FromFloat |  3.2991 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.7859 ns | 0.0167 ns | 0.0148 ns |           - |           - |           - |                   - |
           FromDouble |  3.7448 ns | 0.0983 ns | 0.1847 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.2735 ns | 0.0337 ns | 0.0315 ns |           - |           - |           - |                   - |
          FromDecimal | 12.6936 ns | 0.0949 ns | 0.0888 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 22.4628 ns | 0.1147 ns | 0.1073 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6836 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3195 ns | 0.0130 ns | 0.0121 ns |           - |           - |           - |                   - |
           FromObject |  3.0172 ns | 0.0285 ns | 0.0267 ns |           - |           - |           - |                   - |
           FromString | 44.2244 ns | 0.1708 ns | 0.1514 ns |           - |           - |           - |                   - |
             FromEnum |  0.6768 ns | 0.0098 ns | 0.0087 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.5424 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
