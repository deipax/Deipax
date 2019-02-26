
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9409 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1764 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromChar |  0.7317 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.0988 ns | 0.0146 ns | 0.0129 ns |           - |           - |           - |                   - |
            FromSByte |  0.7103 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1681 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromByte |  0.7089 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1714 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromShort |  0.9426 ns | 0.0018 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.1928 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromUShort |  0.7364 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.0906 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
              FromInt |  0.7118 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
      FromIntNullable |  0.9365 ns | 0.0038 ns | 0.0034 ns |           - |           - |           - |                   - |
             FromUInt |  1.3707 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8957 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
             FromLong |  1.8233 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.8100 ns | 0.0081 ns | 0.0075 ns |           - |           - |           - |                   - |
            FromULong |  1.7161 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromULongNullable |  3.0123 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
            FromFloat |  3.3878 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.5064 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
           FromDouble |  2.5620 ns | 0.0048 ns | 0.0045 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.7443 ns | 0.0064 ns | 0.0057 ns |           - |           - |           - |                   - |
          FromDecimal | 13.1088 ns | 0.0057 ns | 0.0054 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.5958 ns | 0.0164 ns | 0.0137 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7035 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6331 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromObject | 14.0395 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
           FromString | 41.1236 ns | 0.0407 ns | 0.0381 ns |           - |           - |           - |                   - |
             FromEnum |  0.6833 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1611 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
