
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9281 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.6200 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromChar |  0.7217 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.1846 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
            FromSByte |  1.3799 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.8079 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromByte |  0.7016 ns | 0.0014 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1600 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromShort |  1.3829 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7756 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromUShort |  0.7127 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.1854 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
              FromInt |  1.4067 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.9110 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromUInt |  0.6756 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1533 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromLong |  1.3547 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.8870 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromULong |  0.6759 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.1350 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
            FromFloat |  2.3561 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromFloatNullable |  2.9340 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromDouble |  2.0714 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.2293 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
          FromDecimal | 12.9659 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.9120 ns | 0.0112 ns | 0.0104 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6922 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6096 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromObject | 14.2152 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
           FromString | 40.1007 ns | 0.0335 ns | 0.0313 ns |           - |           - |           - |                   - |
             FromEnum |  1.4024 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.5791 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
