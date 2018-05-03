
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  4.886 ns | 0.0689 ns | 0.0645 ns |       0 B |
     FromBoolNullable |  5.073 ns | 0.0051 ns | 0.0045 ns |       0 B |
             FromChar |  4.872 ns | 0.0021 ns | 0.0018 ns |       0 B |
     FromCharNullable |  5.031 ns | 0.0009 ns | 0.0008 ns |       0 B |
            FromSByte |  5.565 ns | 0.0010 ns | 0.0008 ns |       0 B |
    FromSByteNullable |  5.987 ns | 0.0014 ns | 0.0011 ns |       0 B |
             FromByte |  4.865 ns | 0.0044 ns | 0.0042 ns |       0 B |
     FromByteNullable |  5.169 ns | 0.0076 ns | 0.0071 ns |       0 B |
            FromShort |  5.866 ns | 0.0428 ns | 0.0400 ns |       0 B |
    FromShortNullable |  5.935 ns | 0.0139 ns | 0.0130 ns |       0 B |
           FromUShort |  4.874 ns | 0.0031 ns | 0.0029 ns |       0 B |
   FromUShortNullable |  5.030 ns | 0.0094 ns | 0.0084 ns |       0 B |
              FromInt |  5.425 ns | 0.0020 ns | 0.0016 ns |       0 B |
      FromIntNullable |  5.919 ns | 0.0017 ns | 0.0013 ns |       0 B |
             FromUInt |  5.351 ns | 0.0070 ns | 0.0066 ns |       0 B |
     FromUIntNullable |  4.952 ns | 0.0019 ns | 0.0016 ns |       0 B |
             FromLong |  5.202 ns | 0.0057 ns | 0.0053 ns |       0 B |
     FromLongNullable |  5.575 ns | 0.0017 ns | 0.0014 ns |       0 B |
            FromULong |  1.016 ns | 0.0022 ns | 0.0021 ns |       0 B |
    FromULongNullable |  1.522 ns | 0.0073 ns | 0.0061 ns |       0 B |
            FromFloat |  9.612 ns | 0.0017 ns | 0.0016 ns |       0 B |
    FromFloatNullable |  5.941 ns | 0.0143 ns | 0.0127 ns |       0 B |
           FromDouble |  9.365 ns | 0.0090 ns | 0.0084 ns |       0 B |
   FromDoubleNullable |  6.664 ns | 0.0018 ns | 0.0015 ns |       0 B |
          FromDecimal | 16.487 ns | 0.0032 ns | 0.0025 ns |       0 B |
  FromDecimalNullable |  5.620 ns | 0.0024 ns | 0.0018 ns |       0 B |
         FromDateTime |  4.834 ns | 0.0039 ns | 0.0034 ns |       0 B |
 FromDateTimeNullable |  4.859 ns | 0.0052 ns | 0.0049 ns |       0 B |
           FromObject |  7.441 ns | 0.0026 ns | 0.0023 ns |       0 B |
           FromString |  5.224 ns | 0.0046 ns | 0.0036 ns |       0 B |
             FromEnum |  5.625 ns | 0.0040 ns | 0.0035 ns |       0 B |
     FromEnumNullable |  5.961 ns | 0.0074 ns | 0.0062 ns |       0 B |
