
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6413 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9829 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
             FromChar |  0.6371 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.8312 ns | 0.0131 ns | 0.0116 ns |           - |           - |           - |                   - |
            FromSByte |  0.6405 ns | 0.0083 ns | 0.0073 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9220 ns | 0.0095 ns | 0.0084 ns |           - |           - |           - |                   - |
             FromByte |  0.6276 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9277 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
            FromShort |  0.6420 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.8282 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
           FromUShort |  0.6332 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8246 ns | 0.0167 ns | 0.0156 ns |           - |           - |           - |                   - |
              FromInt |  0.6291 ns | 0.0178 ns | 0.0166 ns |           - |           - |           - |                   - |
      FromIntNullable |  0.5124 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
             FromUInt |  1.6186 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.4559 ns | 0.0126 ns | 0.0112 ns |           - |           - |           - |                   - |
             FromLong |  1.6731 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.9004 ns | 0.0252 ns | 0.0236 ns |           - |           - |           - |                   - |
            FromULong |  1.6389 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.9857 ns | 0.0198 ns | 0.0175 ns |           - |           - |           - |                   - |
            FromFloat |  3.2275 ns | 0.0253 ns | 0.0236 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.4801 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
           FromDouble |  2.5099 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.8776 ns | 0.0221 ns | 0.0196 ns |           - |           - |           - |                   - |
          FromDecimal |  7.4077 ns | 0.0852 ns | 0.0797 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 16.6363 ns | 0.0923 ns | 0.0818 ns |           - |           - |           - |                   - |
         FromDateTime |  1.3391 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5916 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
           FromObject | 12.3274 ns | 0.0446 ns | 0.0418 ns |           - |           - |           - |                   - |
           FromString | 42.6059 ns | 0.1233 ns | 0.1093 ns |           - |           - |           - |                   - |
             FromEnum |  0.5747 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8647 ns | 0.0122 ns | 0.0108 ns |           - |           - |           - |                   - |
