
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.1694 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.9496 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromChar |  0.7256 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9693 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromSByte |  0.7143 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1979 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
             FromByte |  0.9463 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9561 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromShort |  0.9367 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.2124 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
           FromUShort |  0.7345 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.1905 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
              FromInt |  0.9518 ns | 0.0010 ns | 0.0010 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.1365 ns | 0.0020 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromUInt |  0.9249 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1552 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
             FromLong |  0.9181 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.6409 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
            FromULong |  1.1358 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.8199 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromFloat |  0.6885 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromFloatNullable |  0.6852 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
           FromDouble |  0.7113 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.6825 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
          FromDecimal | 11.4925 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.4986 ns | 0.0071 ns | 0.0066 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7065 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6113 ns | 0.0013 ns | 0.0010 ns |           - |           - |           - |                   - |
           FromObject |  3.1449 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
           FromString |  2.0164 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromEnum |  0.7201 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1609 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
