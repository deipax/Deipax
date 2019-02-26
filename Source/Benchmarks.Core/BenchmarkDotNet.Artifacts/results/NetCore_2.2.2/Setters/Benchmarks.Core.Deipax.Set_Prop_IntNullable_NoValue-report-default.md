
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9426 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1722 ns | 0.0027 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromChar |  1.3755 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.1808 ns | 0.0018 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromSByte |  0.7100 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.9546 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
             FromByte |  0.7109 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1679 ns | 0.0022 ns | 0.0018 ns |           - |           - |           - |                   - |
            FromShort |  0.9319 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.1881 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromUShort |  0.7252 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.1811 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
              FromInt |  0.7123 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
      FromIntNullable |  0.9429 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
             FromUInt |  1.3658 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9001 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
             FromLong |  1.8420 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.6987 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
            FromULong |  1.7113 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.7374 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
            FromFloat |  3.3962 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7612 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromDouble |  2.5623 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.8550 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
          FromDecimal | 13.1247 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  9.0454 ns | 0.0161 ns | 0.0134 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6963 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6334 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromObject |  2.8357 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
           FromString |  1.8787 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromEnum |  0.6857 ns | 0.0009 ns | 0.0009 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1608 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
