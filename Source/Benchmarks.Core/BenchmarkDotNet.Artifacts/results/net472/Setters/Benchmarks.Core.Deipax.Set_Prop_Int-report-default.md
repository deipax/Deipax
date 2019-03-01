
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8409 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.6638 ns | 0.0145 ns | 0.0135 ns |           - |           - |           - |                   - |
             FromChar |  0.4030 ns | 0.0087 ns | 0.0077 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.5117 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
            FromSByte |  0.4065 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.6270 ns | 0.0138 ns | 0.0123 ns |           - |           - |           - |                   - |
             FromByte |  0.4068 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.6243 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
            FromShort |  0.4075 ns | 0.0053 ns | 0.0049 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.5141 ns | 0.0131 ns | 0.0117 ns |           - |           - |           - |                   - |
           FromUShort |  0.4205 ns | 0.0067 ns | 0.0062 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.5645 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
              FromInt |  0.4219 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.3072 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
             FromUInt |  1.5061 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9334 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
             FromLong |  1.5115 ns | 0.0143 ns | 0.0133 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.8604 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
            FromULong |  1.5182 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.8490 ns | 0.0266 ns | 0.0248 ns |           - |           - |           - |                   - |
            FromFloat |  3.2414 ns | 0.0268 ns | 0.0251 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.2303 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
           FromDouble |  2.2202 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.4624 ns | 0.0278 ns | 0.0260 ns |           - |           - |           - |                   - |
          FromDecimal |  9.0652 ns | 0.0457 ns | 0.0427 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 16.2407 ns | 0.0876 ns | 0.0820 ns |           - |           - |           - |                   - |
         FromDateTime |  0.4555 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3523 ns | 0.0158 ns | 0.0147 ns |           - |           - |           - |                   - |
           FromObject |  2.1142 ns | 0.0161 ns | 0.0134 ns |           - |           - |           - |                   - |
           FromString | 43.4188 ns | 0.3131 ns | 0.2929 ns |           - |           - |           - |                   - |
             FromEnum |  0.4204 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.5422 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
