
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8801 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1102 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromChar |  0.4206 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.8790 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
            FromSByte |  1.0580 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.4429 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
             FromByte |  0.4224 ns | 0.0062 ns | 0.0058 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.6696 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromShort |  1.0597 ns | 0.0030 ns | 0.0026 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.5781 ns | 0.0011 ns | 0.0011 ns |           - |           - |           - |                   - |
           FromUShort |  0.4212 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.8939 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
              FromInt |  1.6004 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.9810 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromUInt |  1.1783 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.6308 ns | 0.0141 ns | 0.0118 ns |           - |           - |           - |                   - |
             FromLong |  1.6812 ns | 0.0105 ns | 0.0088 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.8938 ns | 0.0352 ns | 0.0329 ns |           - |           - |           - |                   - |
            FromULong |  1.6755 ns | 0.0083 ns | 0.0069 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.9854 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
            FromFloat |  3.8333 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.2425 ns | 0.0043 ns | 0.0036 ns |           - |           - |           - |                   - |
           FromDouble |  3.3390 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.7820 ns | 0.0080 ns | 0.0067 ns |           - |           - |           - |                   - |
          FromDecimal | 13.4672 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.1204 ns | 0.0152 ns | 0.0135 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6972 ns | 0.0056 ns | 0.0050 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.4546 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
           FromObject |  2.2292 ns | 0.0091 ns | 0.0080 ns |           - |           - |           - |                   - |
           FromString | 41.9187 ns | 0.0973 ns | 0.0862 ns |           - |           - |           - |                   - |
             FromEnum |  1.9117 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.5112 ns | 0.0052 ns | 0.0046 ns |           - |           - |           - |                   - |
