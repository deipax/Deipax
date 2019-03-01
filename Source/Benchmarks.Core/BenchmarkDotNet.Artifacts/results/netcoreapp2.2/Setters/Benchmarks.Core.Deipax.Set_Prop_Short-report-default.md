
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.1719 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.4033 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromChar |  1.0875 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.6070 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
            FromSByte |  0.7151 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.9412 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromByte |  0.7026 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9399 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromShort |  0.7005 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
    FromShortNullable |  0.9305 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
           FromUShort |  1.1919 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.6080 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
              FromInt |  2.2611 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.1815 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromUInt |  1.6409 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.4353 ns | 0.0067 ns | 0.0063 ns |           - |           - |           - |                   - |
             FromLong |  1.8198 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromLongNullable |  3.0089 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
            FromULong |  1.7078 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.4958 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
            FromFloat |  3.7967 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.1521 ns | 0.0037 ns | 0.0034 ns |           - |           - |           - |                   - |
           FromDouble |  3.4376 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.8211 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
          FromDecimal | 13.6214 ns | 0.0234 ns | 0.0207 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.1339 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6759 ns | 0.0008 ns | 0.0008 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3886 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
           FromObject |  2.2184 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
           FromString | 41.9792 ns | 0.0386 ns | 0.0342 ns |           - |           - |           - |                   - |
             FromEnum |  1.6841 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.2641 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
