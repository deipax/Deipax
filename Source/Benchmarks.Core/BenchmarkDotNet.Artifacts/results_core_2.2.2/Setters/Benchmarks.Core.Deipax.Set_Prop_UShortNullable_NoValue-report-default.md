
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.3735 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1685 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
             FromChar |  0.7234 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.1827 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
            FromSByte |  1.3874 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.7612 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromByte |  0.7088 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1683 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromShort |  1.3828 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7451 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
           FromUShort |  0.7218 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.7078 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
              FromInt |  2.1225 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.7375 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
             FromUInt |  1.4104 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9014 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromLong |  1.8048 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.6933 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
            FromULong |  1.6864 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.7698 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
            FromFloat |  4.0073 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7591 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromDouble |  3.6668 ns | 0.0017 ns | 0.0013 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.8466 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
          FromDecimal | 13.5902 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  9.3410 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
         FromDateTime |  0.9069 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6157 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
           FromObject |  2.8285 ns | 0.0032 ns | 0.0028 ns |           - |           - |           - |                   - |
           FromString |  1.8778 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromEnum |  1.8712 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.7382 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
