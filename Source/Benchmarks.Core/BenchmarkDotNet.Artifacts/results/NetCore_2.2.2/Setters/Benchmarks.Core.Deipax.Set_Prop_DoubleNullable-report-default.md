
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.1649 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.6150 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromChar |  0.9573 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9569 ns | 0.0010 ns | 0.0010 ns |           - |           - |           - |                   - |
            FromSByte |  0.9316 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1729 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
             FromByte |  0.6976 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1661 ns | 0.0011 ns | 0.0009 ns |           - |           - |           - |                   - |
            FromShort |  0.6942 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.1918 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
           FromUShort |  0.9536 ns | 0.0020 ns | 0.0017 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.4069 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
              FromInt |  0.9329 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.2101 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromUInt |  0.9098 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1747 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
             FromLong |  0.8993 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.6272 ns | 0.0014 ns | 0.0014 ns |           - |           - |           - |                   - |
            FromULong |  1.1336 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.8857 ns | 0.0041 ns | 0.0039 ns |           - |           - |           - |                   - |
            FromFloat |  0.7495 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.1587 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromDouble |  0.9117 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.1195 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
          FromDecimal | 10.8407 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 22.8867 ns | 0.0132 ns | 0.0123 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6938 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.9977 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromObject | 14.4769 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
           FromString | 63.0208 ns | 0.0438 ns | 0.0410 ns |           - |           - |           - |                   - |
             FromEnum |  0.8984 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1279 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
