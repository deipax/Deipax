
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6735 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.9133 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromChar |  0.6381 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.0548 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
            FromSByte |  1.2875 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.7394 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromByte |  0.5537 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9076 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
            FromShort |  1.2773 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7166 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromUShort |  0.6276 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.0527 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
              FromInt |  1.3481 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8727 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromUInt |  0.5658 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromUIntNullable |  0.7063 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
             FromLong |  1.8511 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.7692 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromULong |  1.3898 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.9007 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
            FromFloat |  3.4676 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7602 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromDouble |  2.5817 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9022 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
          FromDecimal | 12.9958 ns | 0.0073 ns | 0.0065 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.6550 ns | 0.0130 ns | 0.0121 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7064 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6553 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
           FromObject |  2.8376 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
           FromString |  1.8859 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
             FromEnum |  1.3770 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.2868 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
