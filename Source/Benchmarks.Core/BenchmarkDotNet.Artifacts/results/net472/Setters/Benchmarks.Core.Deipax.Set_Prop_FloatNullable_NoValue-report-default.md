
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 0.8417 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
     FromBoolNullable | 2.8382 ns | 0.0168 ns | 0.0157 ns |           - |           - |           - |                   - |
             FromChar | 0.6108 ns | 0.0087 ns | 0.0081 ns |           - |           - |           - |                   - |
     FromCharNullable | 0.8114 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
            FromSByte | 0.6584 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
    FromSByteNullable | 2.3215 ns | 0.0117 ns | 0.0098 ns |           - |           - |           - |                   - |
             FromByte | 0.4488 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
     FromByteNullable | 1.9152 ns | 0.0145 ns | 0.0135 ns |           - |           - |           - |                   - |
            FromShort | 0.6461 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
    FromShortNullable | 1.9377 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
           FromUShort | 0.6130 ns | 0.0101 ns | 0.0085 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.8311 ns | 0.0068 ns | 0.0060 ns |           - |           - |           - |                   - |
              FromInt | 0.5812 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
      FromIntNullable | 2.1044 ns | 0.0133 ns | 0.0118 ns |           - |           - |           - |                   - |
             FromUInt | 0.7340 ns | 0.0075 ns | 0.0066 ns |           - |           - |           - |                   - |
     FromUIntNullable | 1.9477 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
             FromLong | 0.7584 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
     FromLongNullable | 2.0233 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
            FromULong | 0.8598 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
    FromULongNullable | 2.0241 ns | 0.0200 ns | 0.0187 ns |           - |           - |           - |                   - |
            FromFloat | 0.5697 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
    FromFloatNullable | 0.6295 ns | 0.0081 ns | 0.0072 ns |           - |           - |           - |                   - |
           FromDouble | 0.6708 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.9769 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
          FromDecimal | 9.8165 ns | 0.0495 ns | 0.0463 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 8.1590 ns | 0.0580 ns | 0.0543 ns |           - |           - |           - |                   - |
         FromDateTime | 0.6633 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 1.5662 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
           FromObject | 2.7713 ns | 0.0133 ns | 0.0118 ns |           - |           - |           - |                   - |
           FromString | 1.8423 ns | 0.0182 ns | 0.0170 ns |           - |           - |           - |                   - |
             FromEnum | 0.6601 ns | 0.0101 ns | 0.0090 ns |           - |           - |           - |                   - |
     FromEnumNullable | 1.8585 ns | 0.0093 ns | 0.0082 ns |           - |           - |           - |                   - |
