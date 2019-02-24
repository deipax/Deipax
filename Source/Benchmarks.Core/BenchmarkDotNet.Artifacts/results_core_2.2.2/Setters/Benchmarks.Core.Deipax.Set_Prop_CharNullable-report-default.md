
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6069 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.8481 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
             FromChar |  0.6540 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.5230 ns | 0.0011 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromSByte |  1.3494 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.7857 ns | 0.0043 ns | 0.0038 ns |           - |           - |           - |                   - |
             FromByte |  0.5477 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.0391 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromShort |  1.3427 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7427 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromUShort |  0.6251 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.0234 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
              FromInt |  1.7686 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.5747 ns | 0.0031 ns | 0.0027 ns |           - |           - |           - |                   - |
             FromUInt |  1.4027 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9062 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromLong |  1.7959 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromLongNullable |  3.1292 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
            FromULong |  1.8498 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
    FromULongNullable |  3.0756 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
            FromFloat |  0.9320 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromFloatNullable |  0.9534 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
           FromDouble |  0.9522 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.1622 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
          FromDecimal |  1.1668 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  1.1601 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6966 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6428 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
           FromObject | 14.0045 ns | 0.0102 ns | 0.0090 ns |           - |           - |           - |                   - |
           FromString |  2.9999 ns | 0.0034 ns | 0.0028 ns |           - |           - |           - |                   - |
             FromEnum |  1.8684 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromEnumNullable |  3.1800 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
