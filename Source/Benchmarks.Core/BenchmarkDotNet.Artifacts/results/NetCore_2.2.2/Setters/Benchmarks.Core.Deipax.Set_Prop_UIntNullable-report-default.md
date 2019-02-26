
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6563 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.9221 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromChar |  0.6354 ns | 0.0006 ns | 0.0006 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.0422 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
            FromSByte |  1.2838 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.8148 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromByte |  0.5542 ns | 0.0011 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9138 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromShort |  1.2862 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7287 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromUShort |  0.6262 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.0672 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
              FromInt |  1.3449 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8839 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromUInt |  0.7225 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromUIntNullable |  0.6999 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromLong |  1.8571 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromLongNullable |  3.0801 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
            FromULong |  1.3889 ns | 0.0010 ns | 0.0008 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.9951 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
            FromFloat |  3.4646 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.5750 ns | 0.0061 ns | 0.0058 ns |           - |           - |           - |                   - |
           FromDouble |  2.5729 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.8062 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
          FromDecimal | 12.9622 ns | 0.0048 ns | 0.0040 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.9722 ns | 0.0134 ns | 0.0126 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7202 ns | 0.0007 ns | 0.0006 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.8325 ns | 0.0038 ns | 0.0036 ns |           - |           - |           - |                   - |
           FromObject | 14.0357 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
           FromString | 39.1960 ns | 0.0475 ns | 0.0445 ns |           - |           - |           - |                   - |
             FromEnum |  1.3716 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.9025 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
