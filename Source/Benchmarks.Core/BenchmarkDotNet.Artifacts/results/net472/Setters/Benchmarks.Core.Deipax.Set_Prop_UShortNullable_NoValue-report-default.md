
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8770 ns | 0.0162 ns | 0.0151 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9423 ns | 0.0178 ns | 0.0166 ns |           - |           - |           - |                   - |
             FromChar |  0.6692 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.8050 ns | 0.0195 ns | 0.0182 ns |           - |           - |           - |                   - |
            FromSByte |  1.7326 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9369 ns | 0.0137 ns | 0.0129 ns |           - |           - |           - |                   - |
             FromByte |  0.6927 ns | 0.0101 ns | 0.0090 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.3334 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
            FromShort |  1.7835 ns | 0.0190 ns | 0.0178 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.8160 ns | 0.0205 ns | 0.0192 ns |           - |           - |           - |                   - |
           FromUShort |  0.6688 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.6617 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
              FromInt |  1.8010 ns | 0.0104 ns | 0.0098 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8549 ns | 0.0142 ns | 0.0126 ns |           - |           - |           - |                   - |
             FromUInt |  1.7715 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9018 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
             FromLong |  1.7790 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.4793 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
            FromULong |  1.7187 ns | 0.0172 ns | 0.0161 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.8106 ns | 0.0145 ns | 0.0135 ns |           - |           - |           - |                   - |
            FromFloat |  3.5975 ns | 0.0204 ns | 0.0181 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.9051 ns | 0.0149 ns | 0.0140 ns |           - |           - |           - |                   - |
           FromDouble |  3.6512 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9736 ns | 0.0143 ns | 0.0127 ns |           - |           - |           - |                   - |
          FromDecimal | 13.1437 ns | 0.0422 ns | 0.0374 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.3402 ns | 0.0547 ns | 0.0512 ns |           - |           - |           - |                   - |
         FromDateTime |  1.0109 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6577 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
           FromObject |  2.7049 ns | 0.0116 ns | 0.0096 ns |           - |           - |           - |                   - |
           FromString |  1.7968 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
             FromEnum |  1.7886 ns | 0.0146 ns | 0.0136 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8728 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
