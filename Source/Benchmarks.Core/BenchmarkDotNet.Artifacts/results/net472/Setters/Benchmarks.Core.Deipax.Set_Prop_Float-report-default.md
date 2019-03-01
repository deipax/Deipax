
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8875 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.8115 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
             FromChar |  0.6650 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.8793 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
            FromSByte |  0.6744 ns | 0.0086 ns | 0.0076 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.7009 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
             FromByte |  0.8974 ns | 0.0116 ns | 0.0109 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.6871 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
            FromShort |  0.6655 ns | 0.0117 ns | 0.0109 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7245 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
           FromUShort |  0.8709 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.5883 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
              FromInt |  0.6721 ns | 0.0102 ns | 0.0090 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.5733 ns | 0.0158 ns | 0.0148 ns |           - |           - |           - |                   - |
             FromUInt |  0.6795 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.2586 ns | 0.0117 ns | 0.0109 ns |           - |           - |           - |                   - |
             FromLong |  0.6808 ns | 0.0152 ns | 0.0143 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.0120 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
            FromULong |  1.1252 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.9874 ns | 0.0132 ns | 0.0117 ns |           - |           - |           - |                   - |
            FromFloat |  0.6712 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.3312 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
           FromDouble |  0.6805 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.8550 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
          FromDecimal |  9.8175 ns | 0.0377 ns | 0.0334 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.2804 ns | 0.1270 ns | 0.1188 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6778 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.4449 ns | 0.0181 ns | 0.0161 ns |           - |           - |           - |                   - |
           FromObject |  2.1132 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
           FromString | 58.7443 ns | 0.3714 ns | 0.3475 ns |           - |           - |           - |                   - |
             FromEnum |  0.8765 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.6028 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
