
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6556 ns | 0.0058 ns | 0.0055 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.8943 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
             FromChar |  1.3472 ns | 0.0029 ns | 0.0024 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.7167 ns | 0.0022 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromSByte |  1.3418 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.7453 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromByte |  0.5352 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.5411 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
            FromShort |  1.8150 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7002 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromUShort |  1.3469 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.7033 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
              FromInt |  1.7674 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.6988 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromUInt |  1.4027 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8944 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromLong |  1.7956 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.7516 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
            FromULong |  1.7113 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.7064 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
            FromFloat |  3.9709 ns | 0.0033 ns | 0.0027 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7552 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromDouble |  3.8963 ns | 0.0031 ns | 0.0028 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9074 ns | 0.0027 ns | 0.0026 ns |           - |           - |           - |                   - |
          FromDecimal | 13.5935 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.5543 ns | 0.0085 ns | 0.0079 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7019 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6434 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromObject |  2.8210 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
           FromString |  1.7332 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
             FromEnum |  1.8618 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.7476 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
