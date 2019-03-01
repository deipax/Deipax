
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 4.021 ns | 0.0107 ns | 0.0095 ns |      0.0038 |           - |           - |                24 B |
     FromBoolNullable | 1.112 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromChar | 4.057 ns | 0.0049 ns | 0.0046 ns |      0.0038 |           - |           - |                24 B |
     FromCharNullable | 1.269 ns | 0.0010 ns | 0.0008 ns |           - |           - |           - |                   - |
            FromSByte | 4.056 ns | 0.0040 ns | 0.0036 ns |      0.0038 |           - |           - |                24 B |
    FromSByteNullable | 1.160 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromByte | 4.043 ns | 0.0124 ns | 0.0116 ns |      0.0038 |           - |           - |                24 B |
     FromByteNullable | 1.120 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
            FromShort | 4.037 ns | 0.0114 ns | 0.0107 ns |      0.0038 |           - |           - |                24 B |
    FromShortNullable | 1.258 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromUShort | 4.038 ns | 0.0055 ns | 0.0051 ns |      0.0038 |           - |           - |                24 B |
   FromUShortNullable | 1.258 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
              FromInt | 4.103 ns | 0.0073 ns | 0.0068 ns |      0.0038 |           - |           - |                24 B |
      FromIntNullable | 1.260 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromUInt | 4.180 ns | 0.0084 ns | 0.0075 ns |      0.0038 |           - |           - |                24 B |
     FromUIntNullable | 1.280 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromLong | 4.174 ns | 0.0041 ns | 0.0038 ns |      0.0038 |           - |           - |                24 B |
     FromLongNullable | 1.683 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromULong | 4.119 ns | 0.0038 ns | 0.0036 ns |      0.0038 |           - |           - |                24 B |
    FromULongNullable | 1.615 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromFloat | 5.268 ns | 0.0065 ns | 0.0055 ns |      0.0038 |           - |           - |                24 B |
    FromFloatNullable | 1.253 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromDouble | 4.255 ns | 0.0036 ns | 0.0030 ns |      0.0038 |           - |           - |                24 B |
   FromDoubleNullable | 1.864 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
          FromDecimal | 5.418 ns | 0.0061 ns | 0.0057 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable | 1.735 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
         FromDateTime | 4.173 ns | 0.0055 ns | 0.0046 ns |      0.0038 |           - |           - |                24 B |
 FromDateTimeNullable | 1.643 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromObject | 1.701 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromString | 1.857 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromEnum | 4.176 ns | 0.0041 ns | 0.0036 ns |      0.0038 |           - |           - |                24 B |
     FromEnumNullable | 4.521 ns | 0.0052 ns | 0.0049 ns |      0.0038 |           - |           - |                24 B |
