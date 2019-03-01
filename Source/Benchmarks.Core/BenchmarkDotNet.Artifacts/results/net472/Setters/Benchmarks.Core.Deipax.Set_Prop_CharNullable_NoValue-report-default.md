
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 0.5792 ns | 0.0247 ns | 0.0231 ns |           - |           - |           - |                   - |
     FromBoolNullable | 0.8228 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
             FromChar | 0.6289 ns | 0.0190 ns | 0.0177 ns |           - |           - |           - |                   - |
     FromCharNullable | 0.5784 ns | 0.0167 ns | 0.0156 ns |           - |           - |           - |                   - |
            FromSByte | 1.7316 ns | 0.0159 ns | 0.0133 ns |           - |           - |           - |                   - |
    FromSByteNullable | 1.9222 ns | 0.0190 ns | 0.0178 ns |           - |           - |           - |                   - |
             FromByte | 0.5559 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
     FromByteNullable | 1.9090 ns | 0.0179 ns | 0.0159 ns |           - |           - |           - |                   - |
            FromShort | 1.7261 ns | 0.0225 ns | 0.0210 ns |           - |           - |           - |                   - |
    FromShortNullable | 2.0512 ns | 0.0219 ns | 0.0205 ns |           - |           - |           - |                   - |
           FromUShort | 0.6416 ns | 0.0577 ns | 0.0511 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.8597 ns | 0.0180 ns | 0.0168 ns |           - |           - |           - |                   - |
              FromInt | 1.6483 ns | 0.0220 ns | 0.0206 ns |           - |           - |           - |                   - |
      FromIntNullable | 1.8643 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
             FromUInt | 1.7020 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
     FromUIntNullable | 1.8766 ns | 0.0238 ns | 0.0223 ns |           - |           - |           - |                   - |
             FromLong | 1.6804 ns | 0.0169 ns | 0.0150 ns |           - |           - |           - |                   - |
     FromLongNullable | 2.0109 ns | 0.0279 ns | 0.0261 ns |           - |           - |           - |                   - |
            FromULong | 1.6995 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
    FromULongNullable | 1.9872 ns | 0.0225 ns | 0.0210 ns |           - |           - |           - |                   - |
            FromFloat | 1.2594 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
    FromFloatNullable | 0.9463 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
           FromDouble | 0.5664 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.1360 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
          FromDecimal | 1.1194 ns | 0.0166 ns | 0.0155 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 1.3660 ns | 0.0324 ns | 0.0303 ns |           - |           - |           - |                   - |
         FromDateTime | 0.6949 ns | 0.0180 ns | 0.0168 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 1.5897 ns | 0.0147 ns | 0.0138 ns |           - |           - |           - |                   - |
           FromObject | 2.7508 ns | 0.0354 ns | 0.0331 ns |           - |           - |           - |                   - |
           FromString | 1.7106 ns | 0.0158 ns | 0.0148 ns |           - |           - |           - |                   - |
             FromEnum | 1.6864 ns | 0.0257 ns | 0.0240 ns |           - |           - |           - |                   - |
     FromEnumNullable | 1.9830 ns | 0.0110 ns | 0.0102 ns |           - |           - |           - |                   - |
