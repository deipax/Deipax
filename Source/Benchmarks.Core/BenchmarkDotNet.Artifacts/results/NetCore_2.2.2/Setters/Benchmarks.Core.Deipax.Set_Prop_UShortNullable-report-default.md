
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9293 ns | 0.0111 ns | 0.0099 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1648 ns | 0.0041 ns | 0.0038 ns |           - |           - |           - |                   - |
             FromChar |  0.7205 ns | 0.0020 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.0919 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
            FromSByte |  1.3793 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.8110 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromByte |  0.7004 ns | 0.0031 ns | 0.0027 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9345 ns | 0.0037 ns | 0.0031 ns |           - |           - |           - |                   - |
            FromShort |  1.3751 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7751 ns | 0.0026 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromUShort |  0.6498 ns | 0.0108 ns | 0.0096 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.6809 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
              FromInt |  2.1173 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.6032 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             FromUInt |  1.3948 ns | 0.0030 ns | 0.0027 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9007 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
             FromLong |  1.8085 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.9098 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
            FromULong |  1.6914 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.8835 ns | 0.0029 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromFloat |  4.0161 ns | 0.0059 ns | 0.0056 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.6416 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
           FromDouble |  3.5697 ns | 0.0060 ns | 0.0054 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.8274 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
          FromDecimal | 13.6690 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.4168 ns | 0.0142 ns | 0.0132 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8925 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6234 ns | 0.0037 ns | 0.0034 ns |           - |           - |           - |                   - |
           FromObject | 13.9831 ns | 0.0112 ns | 0.0100 ns |           - |           - |           - |                   - |
           FromString | 41.0141 ns | 0.0439 ns | 0.0411 ns |           - |           - |           - |                   - |
             FromEnum |  1.8586 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.5280 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
