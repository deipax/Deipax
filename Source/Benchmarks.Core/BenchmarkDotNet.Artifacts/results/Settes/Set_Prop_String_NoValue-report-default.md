
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  15.611 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
     FromBoolNullable |   7.207 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
             FromChar |  19.006 ns | 0.0134 ns | 0.0119 ns | 0.0076 |      32 B |
     FromCharNullable |   7.283 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
            FromSByte |  55.510 ns | 0.0880 ns | 0.0780 ns | 0.0076 |      32 B |
    FromSByteNullable |   7.229 ns | 0.0029 ns | 0.0025 ns |      - |       0 B |
             FromByte |  55.681 ns | 0.0596 ns | 0.0558 ns | 0.0076 |      32 B |
     FromByteNullable |   7.214 ns | 0.0051 ns | 0.0048 ns |      - |       0 B |
            FromShort |  55.812 ns | 0.0617 ns | 0.0577 ns | 0.0076 |      32 B |
    FromShortNullable |   7.909 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
           FromUShort |  50.257 ns | 0.0837 ns | 0.0783 ns | 0.0076 |      32 B |
   FromUShortNullable |   7.195 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
              FromInt |  55.972 ns | 0.0334 ns | 0.0279 ns | 0.0076 |      32 B |
      FromIntNullable |   7.269 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
             FromUInt |  52.976 ns | 0.0440 ns | 0.0390 ns | 0.0076 |      32 B |
     FromUIntNullable |   7.202 ns | 0.0065 ns | 0.0058 ns |      - |       0 B |
             FromLong |  59.296 ns | 0.0568 ns | 0.0504 ns | 0.0075 |      32 B |
     FromLongNullable |   7.197 ns | 0.0011 ns | 0.0011 ns |      - |       0 B |
            FromULong |  55.476 ns | 0.0747 ns | 0.0624 ns | 0.0076 |      32 B |
    FromULongNullable |   7.208 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
            FromFloat | 154.652 ns | 0.4565 ns | 0.4270 ns | 0.0074 |      32 B |
    FromFloatNullable |   7.341 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
           FromDouble | 169.715 ns | 0.2434 ns | 0.2277 ns | 0.0074 |      32 B |
   FromDoubleNullable |   7.287 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
          FromDecimal |  75.868 ns | 0.0573 ns | 0.0479 ns | 0.0075 |      32 B |
  FromDecimalNullable |   7.205 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
         FromDateTime | 448.915 ns | 0.7772 ns | 0.7270 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   7.198 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
           FromObject |   7.205 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
           FromString |   7.199 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
             FromEnum | 143.834 ns | 0.2074 ns | 0.1940 ns | 0.0134 |      56 B |
