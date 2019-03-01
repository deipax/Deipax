
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 0.8478 ns | 0.0189 ns | 0.0177 ns |           - |           - |           - |                   - |
     FromBoolNullable | 1.9080 ns | 0.0171 ns | 0.0160 ns |           - |           - |           - |                   - |
             FromChar | 1.2055 ns | 0.0087 ns | 0.0077 ns |           - |           - |           - |                   - |
     FromCharNullable | 0.9350 ns | 0.0095 ns | 0.0085 ns |           - |           - |           - |                   - |
            FromSByte | 0.5710 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
    FromSByteNullable | 1.9231 ns | 0.0148 ns | 0.0138 ns |           - |           - |           - |                   - |
             FromByte | 0.6517 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
     FromByteNullable | 1.9122 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
            FromShort | 0.6613 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
    FromShortNullable | 1.7933 ns | 0.0170 ns | 0.0159 ns |           - |           - |           - |                   - |
           FromUShort | 0.6266 ns | 0.0088 ns | 0.0078 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.8610 ns | 0.0193 ns | 0.0181 ns |           - |           - |           - |                   - |
              FromInt | 0.5808 ns | 0.0134 ns | 0.0126 ns |           - |           - |           - |                   - |
      FromIntNullable | 1.8322 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
             FromUInt | 0.6849 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
     FromUIntNullable | 1.8539 ns | 0.0127 ns | 0.0113 ns |           - |           - |           - |                   - |
             FromLong | 0.7459 ns | 0.0083 ns | 0.0078 ns |           - |           - |           - |                   - |
     FromLongNullable | 2.0559 ns | 0.0220 ns | 0.0206 ns |           - |           - |           - |                   - |
            FromULong | 0.7209 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
    FromULongNullable | 1.9974 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
            FromFloat | 0.7296 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
    FromFloatNullable | 1.9581 ns | 0.0134 ns | 0.0126 ns |           - |           - |           - |                   - |
           FromDouble | 0.5748 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.1125 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
          FromDecimal | 7.7094 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 8.0659 ns | 0.0332 ns | 0.0311 ns |           - |           - |           - |                   - |
         FromDateTime | 0.6732 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 2.1768 ns | 0.0136 ns | 0.0120 ns |           - |           - |           - |                   - |
           FromObject | 4.4435 ns | 0.0221 ns | 0.0207 ns |           - |           - |           - |                   - |
           FromString | 1.8376 ns | 0.0173 ns | 0.0162 ns |           - |           - |           - |                   - |
             FromEnum | 0.6085 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
     FromEnumNullable | 1.8739 ns | 0.0129 ns | 0.0120 ns |           - |           - |           - |                   - |
