
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 1.1633 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromBoolNullable | 1.3915 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromChar | 0.9515 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromCharNullable | 0.9670 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
            FromSByte | 0.9392 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromSByteNullable | 1.1758 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
             FromByte | 0.7106 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
     FromByteNullable | 0.9550 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromShort | 0.7035 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromShortNullable | 1.1806 ns | 0.0025 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromUShort | 0.9560 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.2487 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
              FromInt | 0.9298 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
      FromIntNullable | 1.1925 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromUInt | 0.9059 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromUIntNullable | 1.1603 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromLong | 0.9107 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromLongNullable | 1.4396 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
            FromULong | 1.1366 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
    FromULongNullable | 1.6392 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
            FromFloat | 0.7596 ns | 0.0010 ns | 0.0008 ns |           - |           - |           - |                   - |
    FromFloatNullable | 1.1839 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
           FromDouble | 0.9093 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.1199 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
          FromDecimal | 8.2033 ns | 0.0053 ns | 0.0047 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 8.4283 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
         FromDateTime | 0.7143 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 1.6165 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromObject | 3.1178 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
           FromString | 1.9801 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromEnum | 0.9057 ns | 0.0043 ns | 0.0038 ns |           - |           - |           - |                   - |
     FromEnumNullable | 1.1604 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
