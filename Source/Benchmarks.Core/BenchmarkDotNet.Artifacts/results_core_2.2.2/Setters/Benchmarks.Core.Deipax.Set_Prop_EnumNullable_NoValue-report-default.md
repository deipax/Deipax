
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 17.0240 ns | 0.0121 ns | 0.0108 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.0956 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromChar | 16.8728 ns | 0.0232 ns | 0.0217 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.1242 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
            FromSByte | 16.8659 ns | 0.0160 ns | 0.0149 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.1192 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
             FromByte | 16.8337 ns | 0.0058 ns | 0.0051 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.0982 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromShort | 16.8703 ns | 0.0099 ns | 0.0087 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.1007 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
           FromUShort | 16.8610 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.1791 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
              FromInt | 16.8816 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.1100 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
             FromUInt | 16.8615 ns | 0.0088 ns | 0.0078 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.1219 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromLong | 17.1898 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.2402 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromULong | 17.1771 ns | 0.0072 ns | 0.0060 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.1544 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
            FromFloat | 19.0733 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.9661 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromDouble | 19.0574 ns | 0.0150 ns | 0.0125 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  2.2187 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
          FromDecimal | 33.7326 ns | 0.0198 ns | 0.0185 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.6566 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
         FromDateTime | 11.3701 ns | 0.0087 ns | 0.0077 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  8.4975 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
           FromObject |  2.8296 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
           FromString |  1.8623 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromEnum |  0.7241 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromEnumNullable |  0.9175 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
