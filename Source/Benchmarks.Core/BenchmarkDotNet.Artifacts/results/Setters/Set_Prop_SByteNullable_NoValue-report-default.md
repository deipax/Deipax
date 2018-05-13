
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.2639 ns | 0.0030 ns | 0.0027 ns |       0 B |
     FromBoolNullable |  1.7785 ns | 0.0070 ns | 0.0062 ns |       0 B |
             FromChar |  2.0133 ns | 0.0027 ns | 0.0023 ns |       0 B |
     FromCharNullable |  2.5537 ns | 0.0031 ns | 0.0029 ns |       0 B |
            FromSByte |  1.5436 ns | 0.0051 ns | 0.0048 ns |       0 B |
    FromSByteNullable |  0.9571 ns | 0.0037 ns | 0.0034 ns |       0 B |
             FromByte |  1.9031 ns | 0.0057 ns | 0.0048 ns |       0 B |
     FromByteNullable |  2.3350 ns | 0.0040 ns | 0.0038 ns |       0 B |
            FromShort |  3.0001 ns | 0.0075 ns | 0.0062 ns |       0 B |
    FromShortNullable |  2.5054 ns | 0.0043 ns | 0.0041 ns |       0 B |
           FromUShort |  2.0725 ns | 0.0053 ns | 0.0049 ns |       0 B |
   FromUShortNullable |  2.5314 ns | 0.0043 ns | 0.0040 ns |       0 B |
              FromInt |  2.7279 ns | 0.0134 ns | 0.0112 ns |       0 B |
      FromIntNullable |  2.4085 ns | 0.0046 ns | 0.0041 ns |       0 B |
             FromUInt |  2.0454 ns | 0.0078 ns | 0.0069 ns |       0 B |
     FromUIntNullable |  2.4487 ns | 0.0044 ns | 0.0037 ns |       0 B |
             FromLong |  3.2680 ns | 0.0368 ns | 0.0326 ns |       0 B |
     FromLongNullable |  2.2966 ns | 0.0025 ns | 0.0022 ns |       0 B |
            FromULong |  2.0390 ns | 0.0057 ns | 0.0053 ns |       0 B |
    FromULongNullable |  2.9935 ns | 0.0040 ns | 0.0037 ns |       0 B |
            FromFloat |  5.6253 ns | 0.0140 ns | 0.0124 ns |       0 B |
    FromFloatNullable |  3.2259 ns | 0.0262 ns | 0.0245 ns |       0 B |
           FromDouble |  5.6267 ns | 0.0044 ns | 0.0039 ns |       0 B |
   FromDoubleNullable |  2.3432 ns | 0.0021 ns | 0.0016 ns |       0 B |
          FromDecimal | 15.9543 ns | 0.0112 ns | 0.0105 ns |       0 B |
  FromDecimalNullable |  9.0727 ns | 0.0093 ns | 0.0087 ns |       0 B |
         FromDateTime |  1.2667 ns | 0.0020 ns | 0.0015 ns |       0 B |
 FromDateTimeNullable |  1.9101 ns | 0.0031 ns | 0.0029 ns |       0 B |
           FromObject |  3.8737 ns | 0.0080 ns | 0.0071 ns |       0 B |
           FromString |  2.5685 ns | 0.0041 ns | 0.0036 ns |       0 B |
             FromEnum |  2.6756 ns | 0.0014 ns | 0.0012 ns |       0 B |
     FromEnumNullable |  2.9922 ns | 0.0190 ns | 0.0177 ns |       0 B |
