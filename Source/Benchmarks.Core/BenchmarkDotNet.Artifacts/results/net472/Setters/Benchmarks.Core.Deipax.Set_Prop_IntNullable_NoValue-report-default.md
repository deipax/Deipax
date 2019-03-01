
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8861 ns | 0.0176 ns | 0.0164 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9293 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
             FromChar |  0.8894 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.8195 ns | 0.0212 ns | 0.0188 ns |           - |           - |           - |                   - |
            FromSByte |  0.8940 ns | 0.0158 ns | 0.0148 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9436 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
             FromByte |  0.8903 ns | 0.0109 ns | 0.0097 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.0932 ns | 0.0203 ns | 0.0190 ns |           - |           - |           - |                   - |
            FromShort |  0.8891 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.8216 ns | 0.0228 ns | 0.0202 ns |           - |           - |           - |                   - |
           FromUShort |  0.8820 ns | 0.0089 ns | 0.0084 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8797 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
              FromInt |  0.8918 ns | 0.0173 ns | 0.0162 ns |           - |           - |           - |                   - |
      FromIntNullable |  0.6720 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
             FromUInt |  1.6267 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8526 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
             FromLong |  1.7252 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.9844 ns | 0.0182 ns | 0.0171 ns |           - |           - |           - |                   - |
            FromULong |  1.7313 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.7956 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
            FromFloat |  3.1994 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.8642 ns | 0.0265 ns | 0.0248 ns |           - |           - |           - |                   - |
           FromDouble |  2.4998 ns | 0.0321 ns | 0.0301 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9596 ns | 0.0120 ns | 0.0100 ns |           - |           - |           - |                   - |
          FromDecimal | 16.5801 ns | 0.0716 ns | 0.0670 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.6606 ns | 0.0609 ns | 0.0570 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6515 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5686 ns | 0.0158 ns | 0.0140 ns |           - |           - |           - |                   - |
           FromObject |  2.6884 ns | 0.0204 ns | 0.0191 ns |           - |           - |           - |                   - |
           FromString |  1.7176 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
             FromEnum |  0.6410 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8615 ns | 0.0151 ns | 0.0142 ns |           - |           - |           - |                   - |
