
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   7.071 ns | 0.0556 ns | 0.0520 ns |           - |           - |           - |                   - |
     FromBoolNullable |   7.329 ns | 0.0421 ns | 0.0373 ns |           - |           - |           - |                   - |
             FromChar |   7.067 ns | 0.0513 ns | 0.0480 ns |           - |           - |           - |                   - |
     FromCharNullable |   7.202 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
            FromSByte |   7.118 ns | 0.0259 ns | 0.0230 ns |           - |           - |           - |                   - |
    FromSByteNullable |   7.492 ns | 0.0527 ns | 0.0493 ns |           - |           - |           - |                   - |
             FromByte |   7.319 ns | 0.0437 ns | 0.0387 ns |           - |           - |           - |                   - |
     FromByteNullable |   7.428 ns | 0.0263 ns | 0.0233 ns |           - |           - |           - |                   - |
            FromShort |   7.061 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
    FromShortNullable |   7.214 ns | 0.0468 ns | 0.0437 ns |           - |           - |           - |                   - |
           FromUShort |   7.043 ns | 0.0540 ns | 0.0479 ns |           - |           - |           - |                   - |
   FromUShortNullable |   7.159 ns | 0.0329 ns | 0.0292 ns |           - |           - |           - |                   - |
              FromInt |   7.149 ns | 0.0471 ns | 0.0441 ns |           - |           - |           - |                   - |
      FromIntNullable |   7.229 ns | 0.0338 ns | 0.0316 ns |           - |           - |           - |                   - |
             FromUInt |   7.247 ns | 0.0650 ns | 0.0608 ns |           - |           - |           - |                   - |
     FromUIntNullable |   7.539 ns | 0.0666 ns | 0.0623 ns |           - |           - |           - |                   - |
             FromLong |   7.084 ns | 0.0435 ns | 0.0407 ns |           - |           - |           - |                   - |
     FromLongNullable |   7.567 ns | 0.0752 ns | 0.0704 ns |           - |           - |           - |                   - |
            FromULong |   7.139 ns | 0.0467 ns | 0.0437 ns |           - |           - |           - |                   - |
    FromULongNullable |   7.541 ns | 0.0388 ns | 0.0363 ns |           - |           - |           - |                   - |
            FromFloat |   7.520 ns | 0.0607 ns | 0.0568 ns |           - |           - |           - |                   - |
    FromFloatNullable |   7.642 ns | 0.0871 ns | 0.0815 ns |           - |           - |           - |                   - |
           FromDouble |   7.486 ns | 0.0593 ns | 0.0554 ns |           - |           - |           - |                   - |
   FromDoubleNullable |   7.906 ns | 0.0531 ns | 0.0497 ns |           - |           - |           - |                   - |
          FromDecimal |   7.654 ns | 0.0509 ns | 0.0451 ns |           - |           - |           - |                   - |
  FromDecimalNullable |   7.908 ns | 0.0647 ns | 0.0605 ns |           - |           - |           - |                   - |
         FromDateTime |   5.024 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |   1.331 ns | 0.0158 ns | 0.0148 ns |           - |           - |           - |                   - |
           FromObject |  19.987 ns | 0.1184 ns | 0.1108 ns |           - |           - |           - |                   - |
           FromString | 618.182 ns | 3.8808 ns | 3.6301 ns |           - |           - |           - |                   - |
             FromEnum |  10.723 ns | 0.0783 ns | 0.0732 ns |           - |           - |           - |                   - |
     FromEnumNullable |   7.452 ns | 0.0434 ns | 0.0362 ns |           - |           - |           - |                   - |
