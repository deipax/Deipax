
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.1553 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.3859 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
             FromChar |  0.7165 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.1552 ns | 0.0011 ns | 0.0009 ns |           - |           - |           - |                   - |
            FromSByte |  1.0934 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.4726 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
             FromByte |  0.7068 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9362 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
            FromShort |  1.1596 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.6027 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
           FromUShort |  0.7169 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.0127 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
              FromInt |  1.1645 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.6221 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromUInt |  0.6725 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromUIntNullable |  0.9152 ns | 0.0030 ns | 0.0026 ns |           - |           - |           - |                   - |
             FromLong |  1.2674 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.9365 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
            FromULong |  0.6711 ns | 0.0051 ns | 0.0047 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.4038 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromFloat |  2.0785 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
    FromFloatNullable |  2.5705 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromDouble |  1.8665 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.0768 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
          FromDecimal | 13.6112 ns | 0.2767 ns | 0.2717 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.3257 ns | 0.0235 ns | 0.0220 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6714 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3901 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
           FromObject |  2.2294 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromString | 39.9113 ns | 0.0614 ns | 0.0575 ns |           - |           - |           - |                   - |
             FromEnum |  1.1585 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.1050 ns | 0.0039 ns | 0.0037 ns |           - |           - |           - |                   - |
