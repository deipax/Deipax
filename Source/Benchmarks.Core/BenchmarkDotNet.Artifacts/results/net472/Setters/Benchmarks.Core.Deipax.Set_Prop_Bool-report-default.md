
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.7679 ns | 0.0372 ns | 0.0579 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.2454 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
             FromChar |  0.7076 ns | 0.0071 ns | 0.0066 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9545 ns | 0.0030 ns | 0.0027 ns |           - |           - |           - |                   - |
            FromSByte |  0.6936 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.7791 ns | 0.0343 ns | 0.0304 ns |           - |           - |           - |                   - |
             FromByte |  0.7311 ns | 0.0495 ns | 0.0529 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.4234 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
            FromShort |  0.7043 ns | 0.0413 ns | 0.0424 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.6559 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
           FromUShort |  0.9412 ns | 0.0116 ns | 0.0103 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.6565 ns | 0.0183 ns | 0.0163 ns |           - |           - |           - |                   - |
              FromInt |  0.7032 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.6365 ns | 0.0115 ns | 0.0102 ns |           - |           - |           - |                   - |
             FromUInt |  0.6565 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.6450 ns | 0.0147 ns | 0.0131 ns |           - |           - |           - |                   - |
             FromLong |  0.5418 ns | 0.0086 ns | 0.0081 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.8501 ns | 0.0162 ns | 0.0135 ns |           - |           - |           - |                   - |
            FromULong |  0.6487 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.9845 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
            FromFloat |  0.6754 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7422 ns | 0.0086 ns | 0.0081 ns |           - |           - |           - |                   - |
           FromDouble |  0.7142 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  2.0792 ns | 0.0043 ns | 0.0036 ns |           - |           - |           - |                   - |
          FromDecimal |  8.0834 ns | 0.0222 ns | 0.0186 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 17.5820 ns | 0.3604 ns | 0.4150 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6240 ns | 0.0352 ns | 0.0329 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3401 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
           FromObject |  2.1051 ns | 0.0195 ns | 0.0182 ns |           - |           - |           - |                   - |
           FromString |  7.6537 ns | 0.0432 ns | 0.0404 ns |           - |           - |           - |                   - |
             FromEnum |  0.6226 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.5663 ns | 0.0174 ns | 0.0155 ns |           - |           - |           - |                   - |
