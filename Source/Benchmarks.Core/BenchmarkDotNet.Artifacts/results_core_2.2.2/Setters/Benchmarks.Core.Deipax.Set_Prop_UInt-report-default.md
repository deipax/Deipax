
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.1521 ns | 0.0020 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.3839 ns | 0.0030 ns | 0.0026 ns |           - |           - |           - |                   - |
             FromChar |  0.7126 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.1500 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromSByte |  1.1639 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.4767 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
             FromByte |  0.6907 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1643 ns | 0.0026 ns | 0.0022 ns |           - |           - |           - |                   - |
            FromShort |  1.1115 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.5680 ns | 0.0033 ns | 0.0030 ns |           - |           - |           - |                   - |
           FromUShort |  0.7092 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.1635 ns | 0.0087 ns | 0.0081 ns |           - |           - |           - |                   - |
              FromInt |  1.2857 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.6354 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromUInt |  0.6632 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1242 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromLong |  1.8085 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.5401 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
            FromULong |  1.1337 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.8908 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
            FromFloat |  3.4762 ns | 0.0048 ns | 0.0045 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.0603 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
           FromDouble |  2.5261 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.3886 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
          FromDecimal | 12.8669 ns | 0.0044 ns | 0.0039 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.2456 ns | 0.0117 ns | 0.0103 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6628 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3860 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromObject |  2.2152 ns | 0.0047 ns | 0.0043 ns |           - |           - |           - |                   - |
           FromString | 38.5471 ns | 0.0552 ns | 0.0516 ns |           - |           - |           - |                   - |
             FromEnum |  1.3036 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.6261 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
