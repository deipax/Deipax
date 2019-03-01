
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6252 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9601 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
             FromChar |  1.2529 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.8712 ns | 0.0132 ns | 0.0123 ns |           - |           - |           - |                   - |
            FromSByte |  1.7041 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.6887 ns | 0.0370 ns | 0.0346 ns |           - |           - |           - |                   - |
             FromByte |  0.6301 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9516 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
            FromShort |  1.7086 ns | 0.0143 ns | 0.0127 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.5169 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
           FromUShort |  0.6050 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8974 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
              FromInt |  1.6414 ns | 0.0149 ns | 0.0140 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.5806 ns | 0.0302 ns | 0.0282 ns |           - |           - |           - |                   - |
             FromUInt |  0.5440 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8937 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
             FromLong |  1.6336 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.8898 ns | 0.0275 ns | 0.0257 ns |           - |           - |           - |                   - |
            FromULong |  0.6386 ns | 0.0109 ns | 0.0097 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.3155 ns | 0.0146 ns | 0.0130 ns |           - |           - |           - |                   - |
            FromFloat |  3.2454 ns | 0.0224 ns | 0.0209 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.9094 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
           FromDouble |  3.2557 ns | 0.0271 ns | 0.0254 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.4824 ns | 0.0369 ns | 0.0345 ns |           - |           - |           - |                   - |
          FromDecimal | 12.6902 ns | 0.0648 ns | 0.0606 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 22.9476 ns | 0.1348 ns | 0.1261 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6888 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5700 ns | 0.0107 ns | 0.0095 ns |           - |           - |           - |                   - |
           FromObject | 13.2102 ns | 0.0796 ns | 0.0744 ns |           - |           - |           - |                   - |
           FromString | 44.7917 ns | 0.2383 ns | 0.2229 ns |           - |           - |           - |                   - |
             FromEnum |  1.6648 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.5194 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
