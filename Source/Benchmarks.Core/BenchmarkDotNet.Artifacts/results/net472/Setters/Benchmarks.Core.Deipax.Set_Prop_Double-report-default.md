
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8580 ns | 0.0097 ns | 0.0090 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9623 ns | 0.0179 ns | 0.0168 ns |           - |           - |           - |                   - |
             FromChar |  0.5122 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.8744 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
            FromSByte |  0.6787 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.7938 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
             FromByte |  0.8993 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.6783 ns | 0.0050 ns | 0.0042 ns |           - |           - |           - |                   - |
            FromShort |  0.6758 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.5991 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
           FromUShort |  0.8641 ns | 0.0069 ns | 0.0064 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.5844 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
              FromInt |  0.6730 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.5735 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
             FromUInt |  0.6895 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.5792 ns | 0.0095 ns | 0.0079 ns |           - |           - |           - |                   - |
             FromLong |  0.6767 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.9544 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
            FromULong |  0.8829 ns | 0.0096 ns | 0.0085 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.0905 ns | 0.0089 ns | 0.0074 ns |           - |           - |           - |                   - |
            FromFloat |  0.8795 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.8450 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
           FromDouble |  0.6729 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.8335 ns | 0.0165 ns | 0.0155 ns |           - |           - |           - |                   - |
          FromDecimal |  8.3006 ns | 0.0725 ns | 0.0678 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 21.7042 ns | 0.0675 ns | 0.0631 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6804 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  2.4235 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
           FromObject |  2.0889 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |
           FromString | 56.5604 ns | 0.3428 ns | 0.3207 ns |           - |           - |           - |                   - |
             FromEnum |  0.6735 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.5855 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
