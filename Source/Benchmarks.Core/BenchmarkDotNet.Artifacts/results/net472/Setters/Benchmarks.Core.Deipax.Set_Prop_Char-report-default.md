
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 0.6678 ns | 0.0205 ns | 0.0192 ns |           - |           - |           - |                   - |
     FromBoolNullable | 0.8861 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
             FromChar | 0.6695 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
     FromCharNullable | 1.3249 ns | 0.0167 ns | 0.0157 ns |           - |           - |           - |                   - |
            FromSByte | 1.8933 ns | 0.0239 ns | 0.0224 ns |           - |           - |           - |                   - |
    FromSByteNullable | 2.2470 ns | 0.0372 ns | 0.0348 ns |           - |           - |           - |                   - |
             FromByte | 0.6862 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
     FromByteNullable | 1.7166 ns | 0.0282 ns | 0.0263 ns |           - |           - |           - |                   - |
            FromShort | 1.7579 ns | 0.0370 ns | 0.0346 ns |           - |           - |           - |                   - |
    FromShortNullable | 2.0465 ns | 0.0212 ns | 0.0199 ns |           - |           - |           - |                   - |
           FromUShort | 0.6546 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.5603 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
              FromInt | 1.5835 ns | 0.0199 ns | 0.0186 ns |           - |           - |           - |                   - |
      FromIntNullable | 2.3062 ns | 0.0202 ns | 0.0189 ns |           - |           - |           - |                   - |
             FromUInt | 1.7520 ns | 0.0126 ns | 0.0112 ns |           - |           - |           - |                   - |
     FromUIntNullable | 2.4249 ns | 0.0143 ns | 0.0120 ns |           - |           - |           - |                   - |
             FromLong | 1.8562 ns | 0.0213 ns | 0.0199 ns |           - |           - |           - |                   - |
     FromLongNullable | 2.6624 ns | 0.0354 ns | 0.0331 ns |           - |           - |           - |                   - |
            FromULong | 1.5725 ns | 0.0178 ns | 0.0166 ns |           - |           - |           - |                   - |
    FromULongNullable | 2.6793 ns | 0.0366 ns | 0.0343 ns |           - |           - |           - |                   - |
            FromFloat | 0.6807 ns | 0.0119 ns | 0.0106 ns |           - |           - |           - |                   - |
    FromFloatNullable | 0.7619 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
           FromDouble | 0.6735 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.0538 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
          FromDecimal | 1.0569 ns | 0.0069 ns | 0.0054 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 1.0697 ns | 0.0152 ns | 0.0143 ns |           - |           - |           - |                   - |
         FromDateTime | 0.6774 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 1.3847 ns | 0.0462 ns | 0.0433 ns |           - |           - |           - |                   - |
           FromObject | 2.1651 ns | 0.0213 ns | 0.0199 ns |           - |           - |           - |                   - |
           FromString | 2.4460 ns | 0.0306 ns | 0.0286 ns |           - |           - |           - |                   - |
             FromEnum | 1.5806 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
     FromEnumNullable | 2.0933 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
