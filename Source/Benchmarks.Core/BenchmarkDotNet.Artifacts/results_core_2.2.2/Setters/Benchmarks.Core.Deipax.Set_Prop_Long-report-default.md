
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8994 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1188 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromChar |  0.4373 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.8913 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
            FromSByte |  0.4355 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.8979 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
             FromByte |  0.4400 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.8959 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
            FromShort |  0.4326 ns | 0.0011 ns | 0.0009 ns |           - |           - |           - |                   - |
    FromShortNullable |  0.8912 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromUShort |  0.4320 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.8922 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
              FromInt |  0.4429 ns | 0.0008 ns | 0.0007 ns |           - |           - |           - |                   - |
      FromIntNullable |  0.8968 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
             FromUInt |  0.7212 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1460 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
             FromLong |  0.6911 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.4897 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromULong |  1.1684 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.9862 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromFloat |  2.0883 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
    FromFloatNullable |  2.3514 ns | 0.0061 ns | 0.0051 ns |           - |           - |           - |                   - |
           FromDouble |  1.8664 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.2133 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
          FromDecimal | 13.0906 ns | 0.0050 ns | 0.0045 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.5248 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6891 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.4074 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromObject |  2.2393 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
           FromString | 39.2945 ns | 0.0895 ns | 0.0837 ns |           - |           - |           - |                   - |
             FromEnum |  1.0608 ns | 0.0024 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1472 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
