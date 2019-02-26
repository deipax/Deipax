
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 17.0381 ns | 0.0223 ns | 0.0208 ns |           - |           - |           - |                   - |
     FromBoolNullable | 17.6044 ns | 0.0206 ns | 0.0192 ns |           - |           - |           - |                   - |
             FromChar | 16.9028 ns | 0.0152 ns | 0.0143 ns |           - |           - |           - |                   - |
     FromCharNullable | 17.3118 ns | 0.1264 ns | 0.1182 ns |           - |           - |           - |                   - |
            FromSByte | 16.8927 ns | 0.0297 ns | 0.0277 ns |           - |           - |           - |                   - |
    FromSByteNullable | 17.3298 ns | 0.0116 ns | 0.0103 ns |           - |           - |           - |                   - |
             FromByte | 16.8524 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
     FromByteNullable | 17.2792 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
            FromShort | 16.9803 ns | 0.0118 ns | 0.0105 ns |           - |           - |           - |                   - |
    FromShortNullable | 17.2941 ns | 0.0210 ns | 0.0197 ns |           - |           - |           - |                   - |
           FromUShort | 16.8388 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
   FromUShortNullable | 17.2824 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
              FromInt | 16.8592 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
      FromIntNullable | 17.2329 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
             FromUInt | 16.8439 ns | 0.0119 ns | 0.0093 ns |           - |           - |           - |                   - |
     FromUIntNullable | 17.2643 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
             FromLong | 17.1644 ns | 0.0081 ns | 0.0072 ns |           - |           - |           - |                   - |
     FromLongNullable | 18.0728 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
            FromULong | 17.1813 ns | 0.0110 ns | 0.0102 ns |           - |           - |           - |                   - |
    FromULongNullable | 17.9960 ns | 0.0172 ns | 0.0161 ns |           - |           - |           - |                   - |
            FromFloat | 19.0833 ns | 0.0155 ns | 0.0138 ns |           - |           - |           - |                   - |
    FromFloatNullable | 19.2523 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
           FromDouble | 19.0685 ns | 0.0203 ns | 0.0190 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 19.6480 ns | 0.0157 ns | 0.0140 ns |           - |           - |           - |                   - |
          FromDecimal | 39.8413 ns | 0.2372 ns | 0.2218 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 38.3556 ns | 0.0197 ns | 0.0184 ns |           - |           - |           - |                   - |
         FromDateTime | 11.3558 ns | 0.0086 ns | 0.0076 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  8.4930 ns | 0.0105 ns | 0.0088 ns |           - |           - |           - |                   - |
           FromObject | 14.0214 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
           FromString | 23.5139 ns | 0.0800 ns | 0.0748 ns |           - |           - |           - |                   - |
             FromEnum |  0.7230 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromEnumNullable |  0.9327 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
