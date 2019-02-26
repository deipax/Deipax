
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.1626 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.4398 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
             FromChar |  0.7165 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9747 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromSByte |  0.7066 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1781 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromByte |  0.9276 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.2004 ns | 0.0390 ns | 0.0346 ns |           - |           - |           - |                   - |
            FromShort |  0.9318 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.2051 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
           FromUShort |  0.7295 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.2374 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
              FromInt |  0.9314 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.1744 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromUInt |  0.9155 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.2519 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromLong |  0.9171 ns | 0.0048 ns | 0.0044 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.6232 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromULong |  1.1351 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.0346 ns | 0.0014 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromFloat |  0.7107 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
    FromFloatNullable |  0.6697 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromDouble |  0.7009 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.6421 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
          FromDecimal | 10.2443 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 25.2769 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6962 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6124 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromObject | 14.4563 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
           FromString | 60.3284 ns | 0.1749 ns | 0.1636 ns |           - |           - |           - |                   - |
             FromEnum |  0.7108 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1141 ns | 0.0039 ns | 0.0035 ns |           - |           - |           - |                   - |
