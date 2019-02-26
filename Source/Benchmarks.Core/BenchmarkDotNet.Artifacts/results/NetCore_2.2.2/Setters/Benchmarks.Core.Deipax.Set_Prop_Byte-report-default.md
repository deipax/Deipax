
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8907 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1138 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
             FromChar |  1.0576 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.5757 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
            FromSByte |  1.0630 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.4496 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
             FromByte |  0.4275 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.8851 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromShort |  1.5646 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.8472 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
           FromUShort |  1.0642 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.5837 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
              FromInt |  2.1694 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.2569 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromUInt |  1.1813 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.6231 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromLong |  1.6210 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.5888 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromULong |  1.6121 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.6776 ns | 0.0037 ns | 0.0033 ns |           - |           - |           - |                   - |
            FromFloat |  3.8702 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.9780 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
           FromDouble |  3.6885 ns | 0.0043 ns | 0.0038 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.9480 ns | 0.0041 ns | 0.0038 ns |           - |           - |           - |                   - |
          FromDecimal | 13.4152 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.0731 ns | 0.1063 ns | 0.0994 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6819 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.4470 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromObject |  2.2283 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromString | 41.7544 ns | 0.0733 ns | 0.0685 ns |           - |           - |           - |                   - |
             FromEnum |  1.7199 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.0868 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
