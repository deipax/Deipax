
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 0.7091 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
     FromBoolNullable | 0.7048 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromChar | 0.7244 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromCharNullable | 0.9570 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
            FromSByte | 0.7149 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromSByteNullable | 0.9485 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
             FromByte | 0.7177 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromByteNullable | 0.9539 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromShort | 0.9320 ns | 0.0034 ns | 0.0028 ns |           - |           - |           - |                   - |
    FromShortNullable | 1.1859 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromUShort | 0.9521 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.1926 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
              FromInt | 0.9305 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
      FromIntNullable | 1.1843 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromUInt | 0.6967 ns | 0.0011 ns | 0.0009 ns |           - |           - |           - |                   - |
     FromUIntNullable | 1.1670 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromLong | 0.6955 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromLongNullable | 1.4938 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromULong | 0.6952 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromULongNullable | 1.4834 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
            FromFloat | 0.9836 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
    FromFloatNullable | 1.1294 ns | 0.0008 ns | 0.0007 ns |           - |           - |           - |                   - |
           FromDouble | 1.3425 ns | 0.0025 ns | 0.0022 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.6415 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
          FromDecimal | 7.4094 ns | 0.0074 ns | 0.0066 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 9.0231 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
         FromDateTime | 0.6898 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 1.4311 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromObject | 2.8050 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
           FromString | 1.6300 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
             FromEnum | 0.6896 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromEnumNullable | 1.0775 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
