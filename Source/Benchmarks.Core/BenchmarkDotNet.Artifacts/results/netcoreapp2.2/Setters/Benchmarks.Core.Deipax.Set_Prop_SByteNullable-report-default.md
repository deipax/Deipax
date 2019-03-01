
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6726 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.9166 ns | 0.0009 ns | 0.0009 ns |           - |           - |           - |                   - |
             FromChar |  1.3660 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.3948 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromSByte |  0.6663 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.5338 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromByte |  1.3453 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.8085 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromShort |  1.7778 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.5848 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromUShort |  1.3157 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.7583 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
              FromInt |  1.7745 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.5299 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromUInt |  1.3807 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9474 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromLong |  1.7953 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.9847 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
            FromULong |  1.4113 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.5981 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
            FromFloat |  3.8246 ns | 0.0028 ns | 0.0024 ns |           - |           - |           - |                   - |
    FromFloatNullable |  5.3163 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
           FromDouble |  3.9310 ns | 0.0052 ns | 0.0048 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.7785 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
          FromDecimal | 13.8464 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 25.4221 ns | 0.0412 ns | 0.0385 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7161 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6603 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromObject | 13.7980 ns | 0.0174 ns | 0.0163 ns |           - |           - |           - |                   - |
           FromString | 42.3208 ns | 0.0608 ns | 0.0539 ns |           - |           - |           - |                   - |
             FromEnum |  1.8704 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.5857 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
