
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.303 ns | 0.0150 ns | 0.0133 ns |       0 B |
     FromBoolNullable |  1.804 ns | 0.0024 ns | 0.0022 ns |       0 B |
             FromChar |  1.892 ns | 0.0065 ns | 0.0058 ns |       0 B |
     FromCharNullable |  2.467 ns | 0.0045 ns | 0.0042 ns |       0 B |
            FromSByte |  1.864 ns | 0.0072 ns | 0.0060 ns |       0 B |
    FromSByteNullable |  2.260 ns | 0.0101 ns | 0.0095 ns |       0 B |
             FromByte |  1.041 ns | 0.0047 ns | 0.0042 ns |       0 B |
     FromByteNullable |  1.046 ns | 0.0029 ns | 0.0026 ns |       0 B |
            FromShort |  2.866 ns | 0.0052 ns | 0.0049 ns |       0 B |
    FromShortNullable |  2.515 ns | 0.0162 ns | 0.0144 ns |       0 B |
           FromUShort |  1.879 ns | 0.0044 ns | 0.0039 ns |       0 B |
   FromUShortNullable |  2.569 ns | 0.0127 ns | 0.0106 ns |       0 B |
              FromInt |  3.371 ns | 0.0344 ns | 0.0322 ns |       0 B |
      FromIntNullable |  2.607 ns | 0.0037 ns | 0.0033 ns |       0 B |
             FromUInt |  1.964 ns | 0.0051 ns | 0.0042 ns |       0 B |
     FromUIntNullable |  2.609 ns | 0.0056 ns | 0.0047 ns |       0 B |
             FromLong |  2.956 ns | 0.0181 ns | 0.0169 ns |       0 B |
     FromLongNullable |  2.356 ns | 0.0009 ns | 0.0008 ns |       0 B |
            FromULong |  2.615 ns | 0.0035 ns | 0.0028 ns |       0 B |
    FromULongNullable |  2.347 ns | 0.0019 ns | 0.0015 ns |       0 B |
            FromFloat |  5.639 ns | 0.0111 ns | 0.0104 ns |       0 B |
    FromFloatNullable |  2.445 ns | 0.0056 ns | 0.0053 ns |       0 B |
           FromDouble |  5.463 ns | 0.0163 ns | 0.0137 ns |       0 B |
   FromDoubleNullable |  2.454 ns | 0.0083 ns | 0.0078 ns |       0 B |
          FromDecimal | 15.470 ns | 0.0399 ns | 0.0354 ns |       0 B |
  FromDecimalNullable |  8.487 ns | 0.0280 ns | 0.0262 ns |       0 B |
         FromDateTime |  1.240 ns | 0.0028 ns | 0.0024 ns |       0 B |
 FromDateTimeNullable |  2.156 ns | 0.0057 ns | 0.0050 ns |       0 B |
           FromObject |  3.890 ns | 0.0146 ns | 0.0130 ns |       0 B |
           FromString |  2.639 ns | 0.0065 ns | 0.0061 ns |       0 B |
             FromEnum |  3.155 ns | 0.0463 ns | 0.0433 ns |       0 B |
     FromEnumNullable |  3.051 ns | 0.0427 ns | 0.0399 ns |       0 B |
