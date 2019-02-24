
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9317 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.3664 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromChar |  0.7204 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.7237 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
            FromSByte |  0.9276 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.0191 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromByte |  0.9293 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1551 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
            FromShort |  0.9268 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.1560 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
           FromUShort |  0.9443 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.1695 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
              FromInt |  0.9292 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
      FromIntNullable |  0.9332 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromUInt |  0.6637 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1374 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
             FromLong |  0.6646 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.6840 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
            FromULong |  0.8941 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.8527 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
            FromFloat |  0.8955 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromFloatNullable |  0.8951 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromDouble |  0.6669 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.4639 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
          FromDecimal |  9.7124 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.1026 ns | 0.0160 ns | 0.0133 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6661 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  2.6746 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
           FromObject |  2.1805 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
           FromString | 60.3273 ns | 0.0804 ns | 0.0713 ns |           - |           - |           - |                   - |
             FromEnum |  0.6802 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
     FromEnumNullable |  0.8988 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
