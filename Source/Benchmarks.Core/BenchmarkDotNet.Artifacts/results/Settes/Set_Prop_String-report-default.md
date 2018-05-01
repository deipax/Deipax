
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  15.579 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
     FromBoolNullable |   7.192 ns | 0.0081 ns | 0.0068 ns |      - |       0 B |
             FromChar |  18.972 ns | 0.0247 ns | 0.0206 ns | 0.0076 |      32 B |
     FromCharNullable |  19.017 ns | 0.0167 ns | 0.0156 ns | 0.0076 |      32 B |
            FromSByte |  55.272 ns | 0.0654 ns | 0.0580 ns | 0.0076 |      32 B |
    FromSByteNullable |  55.163 ns | 0.0873 ns | 0.0773 ns | 0.0076 |      32 B |
             FromByte |  55.625 ns | 0.0332 ns | 0.0294 ns | 0.0076 |      32 B |
     FromByteNullable |  55.626 ns | 0.0292 ns | 0.0211 ns | 0.0076 |      32 B |
            FromShort |  55.110 ns | 0.0554 ns | 0.0491 ns | 0.0076 |      32 B |
    FromShortNullable |  55.290 ns | 0.0625 ns | 0.0584 ns | 0.0076 |      32 B |
           FromUShort |  50.746 ns | 0.0334 ns | 0.0296 ns | 0.0076 |      32 B |
   FromUShortNullable |  50.770 ns | 0.0521 ns | 0.0461 ns | 0.0076 |      32 B |
              FromInt |  57.235 ns | 0.0711 ns | 0.0594 ns | 0.0076 |      32 B |
      FromIntNullable |  57.056 ns | 0.0226 ns | 0.0188 ns | 0.0076 |      32 B |
             FromUInt |  53.211 ns | 0.0414 ns | 0.0387 ns | 0.0076 |      32 B |
     FromUIntNullable |  53.162 ns | 0.0832 ns | 0.0737 ns | 0.0076 |      32 B |
             FromLong |  59.837 ns | 0.0268 ns | 0.0250 ns | 0.0075 |      32 B |
     FromLongNullable |  59.247 ns | 0.0410 ns | 0.0364 ns | 0.0075 |      32 B |
            FromULong |  55.465 ns | 0.0640 ns | 0.0598 ns | 0.0076 |      32 B |
    FromULongNullable |  55.397 ns | 0.0306 ns | 0.0271 ns | 0.0076 |      32 B |
            FromFloat | 234.392 ns | 0.2979 ns | 0.2786 ns | 0.0074 |      32 B |
    FromFloatNullable | 233.482 ns | 0.0561 ns | 0.0371 ns | 0.0074 |      32 B |
           FromDouble | 269.820 ns | 0.1177 ns | 0.0983 ns | 0.0072 |      32 B |
   FromDoubleNullable | 270.334 ns | 0.1266 ns | 0.1057 ns | 0.0072 |      32 B |
          FromDecimal |  79.794 ns | 0.0212 ns | 0.0199 ns | 0.0075 |      32 B |
  FromDecimalNullable |  79.904 ns | 0.0240 ns | 0.0225 ns | 0.0075 |      32 B |
         FromDateTime | 453.889 ns | 1.0305 ns | 0.9639 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   7.192 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
           FromObject |   5.093 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
           FromString |   5.095 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
             FromEnum |  73.066 ns | 0.0581 ns | 0.0515 ns |      - |       0 B |
