
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 16.7809 ns | 0.0203 ns | 0.0180 ns |           - |           - |           - |                   - |
     FromBoolNullable | 17.4969 ns | 0.0216 ns | 0.0191 ns |           - |           - |           - |                   - |
             FromChar |  0.7239 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.0052 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromSByte | 17.2833 ns | 0.0065 ns | 0.0060 ns |           - |           - |           - |                   - |
    FromSByteNullable | 17.2258 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
             FromByte | 17.0006 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
     FromByteNullable | 17.6737 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
            FromShort | 17.3106 ns | 0.0089 ns | 0.0079 ns |           - |           - |           - |                   - |
    FromShortNullable | 17.2212 ns | 0.0098 ns | 0.0087 ns |           - |           - |           - |                   - |
           FromUShort | 17.4387 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
   FromUShortNullable | 17.6846 ns | 0.0088 ns | 0.0083 ns |           - |           - |           - |                   - |
              FromInt | 16.9765 ns | 0.0126 ns | 0.0117 ns |           - |           - |           - |                   - |
      FromIntNullable | 17.7168 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
             FromUInt | 16.7569 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
     FromUIntNullable | 17.6750 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
             FromLong | 16.7531 ns | 0.0121 ns | 0.0108 ns |           - |           - |           - |                   - |
     FromLongNullable | 17.6522 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
            FromULong | 16.9761 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
    FromULongNullable | 17.9281 ns | 0.0141 ns | 0.0118 ns |           - |           - |           - |                   - |
            FromFloat | 32.8194 ns | 0.0670 ns | 0.0626 ns |           - |           - |           - |                   - |
    FromFloatNullable | 33.0844 ns | 0.0270 ns | 0.0253 ns |           - |           - |           - |                   - |
           FromDouble | 63.8444 ns | 0.0451 ns | 0.0400 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 64.0517 ns | 0.0494 ns | 0.0462 ns |           - |           - |           - |                   - |
          FromDecimal |  5.5294 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  1.3903 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7071 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6226 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromObject | 20.6666 ns | 0.0327 ns | 0.0306 ns |           - |           - |           - |                   - |
           FromString | 70.9393 ns | 0.0582 ns | 0.0544 ns |           - |           - |           - |                   - |
             FromEnum | 17.4653 ns | 0.0197 ns | 0.0184 ns |           - |           - |           - |                   - |
     FromEnumNullable | 16.9957 ns | 0.0139 ns | 0.0123 ns |           - |           - |           - |                   - |
