
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 0.7040 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
     FromBoolNullable | 0.9308 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromChar | 0.7253 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromCharNullable | 1.1583 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
            FromSByte | 1.3639 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromSByteNullable | 1.4769 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromByte | 0.7043 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
     FromByteNullable | 1.1617 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromShort | 1.0895 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
    FromShortNullable | 1.6113 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromUShort | 0.7271 ns | 0.0017 ns | 0.0014 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.1672 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
              FromInt | 1.6786 ns | 0.0043 ns | 0.0038 ns |           - |           - |           - |                   - |
      FromIntNullable | 2.5248 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
             FromUInt | 1.1616 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromUIntNullable | 1.6178 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromLong | 1.6931 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromLongNullable | 2.7527 ns | 0.0032 ns | 0.0027 ns |           - |           - |           - |                   - |
            FromULong | 1.7062 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    FromULongNullable | 2.5521 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            FromFloat | 0.7062 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
    FromFloatNullable | 0.7393 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromDouble | 0.7034 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.1302 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
          FromDecimal | 1.1312 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 1.3475 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
         FromDateTime | 0.7280 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 1.3977 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
           FromObject | 2.2326 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromString | 2.2171 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
             FromEnum | 1.6308 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromEnumNullable | 2.0150 ns | 0.0008 ns | 0.0008 ns |           - |           - |           - |                   - |
