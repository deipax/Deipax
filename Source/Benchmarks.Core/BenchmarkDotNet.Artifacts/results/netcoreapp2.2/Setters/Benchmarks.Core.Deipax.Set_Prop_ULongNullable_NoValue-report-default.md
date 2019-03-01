
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6659 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1213 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
             FromChar |  0.6396 ns | 0.0020 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.0510 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromSByte |  1.3619 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.5182 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromByte |  0.5656 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9084 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromShort |  1.3518 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7189 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromUShort |  0.6254 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.0524 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
              FromInt |  1.3931 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8723 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromUInt |  0.7207 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1695 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
             FromLong |  1.3746 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.9906 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromULong |  0.7018 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.1693 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
            FromFloat |  2.5486 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7646 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromDouble |  2.0897 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9074 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
          FromDecimal | 13.1586 ns | 0.0087 ns | 0.0068 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.7014 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7100 ns | 0.0014 ns | 0.0014 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6524 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromObject |  2.8626 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
           FromString |  2.3583 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
             FromEnum |  1.4181 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.9024 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
