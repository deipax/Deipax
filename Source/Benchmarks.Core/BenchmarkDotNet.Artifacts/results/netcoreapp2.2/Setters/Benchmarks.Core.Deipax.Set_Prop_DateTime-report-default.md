
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   0.9267 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromBoolNullable |   0.9301 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
             FromChar |   0.7371 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
     FromCharNullable |   1.0692 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
            FromSByte |   0.7135 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromSByteNullable |   0.9339 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromByte |   0.7129 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromByteNullable |   0.9228 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromShort |   0.9363 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
    FromShortNullable |   1.0248 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
           FromUShort |   0.7230 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   FromUShortNullable |   1.0686 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
              FromInt |   0.7300 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
      FromIntNullable |   1.0702 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromUInt |   0.7209 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromUIntNullable |   1.0125 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromLong |   0.6833 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromLongNullable |   1.1120 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromULong |   0.8938 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
    FromULongNullable |   1.1144 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromFloat |   0.6843 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromFloatNullable |   1.1252 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
           FromDouble |   0.6726 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
   FromDoubleNullable |   1.3407 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
          FromDecimal |   1.1104 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
  FromDecimalNullable |   1.3606 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
         FromDateTime |   0.6823 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |   1.6531 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromObject |   2.2099 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromString | 312.4685 ns | 0.1655 ns | 0.1467 ns |           - |           - |           - |                   - |
             FromEnum |   0.7315 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
     FromEnumNullable |   1.0123 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
