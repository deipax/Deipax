
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 4.063 ns | 0.0085 ns | 0.0079 ns |      0.0038 |           - |           - |                24 B |
     FromBoolNullable | 1.137 ns | 0.0027 ns | 0.0026 ns |           - |           - |           - |                   - |
             FromChar | 4.110 ns | 0.0093 ns | 0.0087 ns |      0.0038 |           - |           - |                24 B |
     FromCharNullable | 1.281 ns | 0.0030 ns | 0.0026 ns |           - |           - |           - |                   - |
            FromSByte | 4.066 ns | 0.0046 ns | 0.0041 ns |      0.0038 |           - |           - |                24 B |
    FromSByteNullable | 1.178 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromByte | 4.071 ns | 0.0093 ns | 0.0087 ns |      0.0038 |           - |           - |                24 B |
     FromByteNullable | 1.134 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromShort | 4.111 ns | 0.0035 ns | 0.0033 ns |      0.0038 |           - |           - |                24 B |
    FromShortNullable | 1.282 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromUShort | 4.087 ns | 0.0054 ns | 0.0048 ns |      0.0038 |           - |           - |                24 B |
   FromUShortNullable | 1.283 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
              FromInt | 4.153 ns | 0.0057 ns | 0.0051 ns |      0.0038 |           - |           - |                24 B |
      FromIntNullable | 1.281 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromUInt | 4.325 ns | 0.0042 ns | 0.0037 ns |      0.0038 |           - |           - |                24 B |
     FromUIntNullable | 1.275 ns | 0.0007 ns | 0.0006 ns |           - |           - |           - |                   - |
             FromLong | 4.170 ns | 0.0037 ns | 0.0031 ns |      0.0038 |           - |           - |                24 B |
     FromLongNullable | 1.633 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromULong | 4.126 ns | 0.0107 ns | 0.0100 ns |      0.0038 |           - |           - |                24 B |
    FromULongNullable | 1.579 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromFloat | 4.220 ns | 0.0072 ns | 0.0063 ns |      0.0038 |           - |           - |                24 B |
    FromFloatNullable | 1.239 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromDouble | 4.251 ns | 0.0038 ns | 0.0034 ns |      0.0038 |           - |           - |                24 B |
   FromDoubleNullable | 1.890 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
          FromDecimal | 5.436 ns | 0.0053 ns | 0.0050 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable | 1.650 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
         FromDateTime | 4.163 ns | 0.0109 ns | 0.0102 ns |      0.0038 |           - |           - |                24 B |
 FromDateTimeNullable | 1.622 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
           FromObject | 1.671 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
           FromString | 1.820 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromEnum | 4.864 ns | 0.0059 ns | 0.0046 ns |      0.0038 |           - |           - |                24 B |
     FromEnumNullable | 1.276 ns | 0.0014 ns | 0.0011 ns |           - |           - |           - |                   - |
