
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  15.614 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
     FromBoolNullable |   7.212 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
             FromChar |  19.027 ns | 0.0311 ns | 0.0276 ns | 0.0076 |      32 B |
     FromCharNullable |   7.201 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
            FromSByte |  55.911 ns | 0.0795 ns | 0.0743 ns | 0.0076 |      32 B |
    FromSByteNullable |   7.197 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
             FromByte |  55.927 ns | 0.0483 ns | 0.0429 ns | 0.0076 |      32 B |
     FromByteNullable |   7.205 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
            FromShort |  58.211 ns | 0.0268 ns | 0.0251 ns | 0.0076 |      32 B |
    FromShortNullable |   7.195 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
           FromUShort |  50.136 ns | 0.0199 ns | 0.0167 ns | 0.0076 |      32 B |
   FromUShortNullable |   7.290 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
              FromInt |  55.961 ns | 0.0202 ns | 0.0179 ns | 0.0076 |      32 B |
      FromIntNullable |   7.238 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
             FromUInt |  52.900 ns | 0.0518 ns | 0.0485 ns | 0.0076 |      32 B |
     FromUIntNullable |   7.212 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
             FromLong |  58.924 ns | 0.0207 ns | 0.0173 ns | 0.0075 |      32 B |
     FromLongNullable |   7.477 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
            FromULong |  55.515 ns | 0.0397 ns | 0.0352 ns | 0.0076 |      32 B |
    FromULongNullable |   7.206 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
            FromFloat | 153.912 ns | 0.4207 ns | 0.3730 ns | 0.0074 |      32 B |
    FromFloatNullable |   7.213 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
           FromDouble | 169.177 ns | 0.0327 ns | 0.0290 ns | 0.0074 |      32 B |
   FromDoubleNullable |   7.203 ns | 0.0039 ns | 0.0036 ns |      - |       0 B |
          FromDecimal |  75.810 ns | 0.0309 ns | 0.0273 ns | 0.0075 |      32 B |
  FromDecimalNullable |   7.208 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
         FromDateTime | 450.677 ns | 0.6912 ns | 0.6465 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   7.460 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
           FromObject |   5.124 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
           FromString |   5.128 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
             FromEnum | 140.983 ns | 0.3581 ns | 0.3349 ns | 0.0134 |      56 B |
