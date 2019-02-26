
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9334 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.9523 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
             FromChar |  0.9594 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.1944 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromSByte |  0.7179 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1700 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
             FromByte |  0.7098 ns | 0.0018 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1684 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromShort |  0.7087 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.0710 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromUShort |  0.8176 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.1805 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
              FromInt |  0.7147 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.1878 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
             FromUInt |  0.6842 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1596 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromLong |  0.6816 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.1243 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromULong |  1.3830 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.6720 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
            FromFloat |  2.1594 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7642 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromDouble |  1.9400 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.8504 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
          FromDecimal | 13.2451 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  9.3144 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7026 ns | 0.0029 ns | 0.0025 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6254 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromObject |  2.8603 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
           FromString |  1.8830 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromEnum |  0.9191 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.0669 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
