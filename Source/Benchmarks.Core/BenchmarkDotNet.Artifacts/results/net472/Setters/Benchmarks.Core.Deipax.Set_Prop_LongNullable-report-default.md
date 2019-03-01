
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9218 ns | 0.0396 ns | 0.0351 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9844 ns | 0.0097 ns | 0.0076 ns |           - |           - |           - |                   - |
             FromChar |  0.6814 ns | 0.0128 ns | 0.0119 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.9339 ns | 0.0203 ns | 0.0190 ns |           - |           - |           - |                   - |
            FromSByte |  0.6775 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9848 ns | 0.0202 ns | 0.0189 ns |           - |           - |           - |                   - |
             FromByte |  0.2838 ns | 0.0068 ns | 0.0060 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9870 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
            FromShort |  0.6790 ns | 0.0095 ns | 0.0080 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.9130 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
           FromUShort |  0.6776 ns | 0.0103 ns | 0.0086 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8925 ns | 0.0147 ns | 0.0131 ns |           - |           - |           - |                   - |
              FromInt |  0.6917 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.9200 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
             FromUInt |  0.6826 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9297 ns | 0.0165 ns | 0.0154 ns |           - |           - |           - |                   - |
             FromLong |  0.6934 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.0777 ns | 0.0130 ns | 0.0121 ns |           - |           - |           - |                   - |
            FromULong |  1.6545 ns | 0.0182 ns | 0.0161 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.7659 ns | 0.0355 ns | 0.0332 ns |           - |           - |           - |                   - |
            FromFloat |  3.4752 ns | 0.0192 ns | 0.0180 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.7502 ns | 0.0272 ns | 0.0255 ns |           - |           - |           - |                   - |
           FromDouble |  3.3346 ns | 0.0303 ns | 0.0283 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.9933 ns | 0.0213 ns | 0.0177 ns |           - |           - |           - |                   - |
          FromDecimal | 12.9262 ns | 0.0561 ns | 0.0497 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.1218 ns | 0.1145 ns | 0.1071 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8876 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5509 ns | 0.0122 ns | 0.0108 ns |           - |           - |           - |                   - |
           FromObject | 12.6099 ns | 0.0552 ns | 0.0516 ns |           - |           - |           - |                   - |
           FromString | 44.2197 ns | 0.1863 ns | 0.1743 ns |           - |           - |           - |                   - |
             FromEnum |  0.6822 ns | 0.0121 ns | 0.0107 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.0632 ns | 0.0251 ns | 0.0223 ns |           - |           - |           - |                   - |
