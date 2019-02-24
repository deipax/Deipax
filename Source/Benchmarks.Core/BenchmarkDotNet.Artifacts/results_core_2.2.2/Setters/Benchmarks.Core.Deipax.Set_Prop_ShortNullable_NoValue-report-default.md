
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9358 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1743 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromChar |  1.3864 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.7415 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromSByte |  0.9384 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1649 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromByte |  0.7111 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1651 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
            FromShort |  0.7217 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromShortNullable |  0.7208 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromUShort |  1.3806 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.7354 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
              FromInt |  2.2140 ns | 0.0027 ns | 0.0026 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.7636 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
             FromUInt |  1.7886 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.7313 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
             FromLong |  2.0541 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.0375 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
            FromULong |  1.7050 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.7639 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
            FromFloat |  3.8070 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7498 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromDouble |  3.9398 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.8504 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
          FromDecimal | 13.8000 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  9.0578 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
         FromDateTime |  0.9013 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6188 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
           FromObject |  2.8200 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
           FromString |  1.8685 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromEnum |  1.7910 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.7254 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
