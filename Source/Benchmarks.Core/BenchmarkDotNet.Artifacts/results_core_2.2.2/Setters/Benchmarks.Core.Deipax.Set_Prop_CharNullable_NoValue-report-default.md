
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 0.7073 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
     FromBoolNullable | 0.9381 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
             FromChar | 0.9490 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromCharNullable | 0.7068 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
            FromSByte | 1.3866 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromSByteNullable | 1.7632 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromByte | 0.7141 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromByteNullable | 1.1687 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromShort | 1.3831 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromShortNullable | 1.7441 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromUShort | 0.7221 ns | 0.0007 ns | 0.0005 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.1841 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
              FromInt | 1.8633 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
      FromIntNullable | 1.7417 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromUInt | 1.4061 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromUIntNullable | 1.8954 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
             FromLong | 1.8014 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
     FromLongNullable | 1.6973 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
            FromULong | 1.8446 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromULongNullable | 1.7613 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
            FromFloat | 0.9120 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromFloatNullable | 0.9691 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
           FromDouble | 0.9117 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.1436 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
          FromDecimal | 1.2062 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 1.8417 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
         FromDateTime | 0.7016 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 1.6353 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromObject | 2.8264 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
           FromString | 1.6294 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromEnum | 1.8400 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
     FromEnumNullable | 1.7397 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
