
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.298 ns | 0.0055 ns | 0.0049 ns |       0 B |
     FromBoolNullable |  1.812 ns | 0.0072 ns | 0.0068 ns |       0 B |
             FromChar |  1.039 ns | 0.0024 ns | 0.0022 ns |       0 B |
     FromCharNullable |  1.808 ns | 0.0055 ns | 0.0052 ns |       0 B |
            FromSByte |  1.945 ns | 0.0056 ns | 0.0052 ns |       0 B |
    FromSByteNullable |  2.287 ns | 0.0072 ns | 0.0060 ns |       0 B |
             FromByte |  1.042 ns | 0.0041 ns | 0.0038 ns |       0 B |
     FromByteNullable |  1.809 ns | 0.0049 ns | 0.0046 ns |       0 B |
            FromShort |  1.884 ns | 0.0052 ns | 0.0049 ns |       0 B |
    FromShortNullable |  2.780 ns | 0.0067 ns | 0.0063 ns |       0 B |
           FromUShort |  1.037 ns | 0.0065 ns | 0.0057 ns |       0 B |
   FromUShortNullable |  1.809 ns | 0.0049 ns | 0.0043 ns |       0 B |
              FromInt |  1.867 ns | 0.0033 ns | 0.0026 ns |       0 B |
      FromIntNullable |  2.533 ns | 0.0048 ns | 0.0045 ns |       0 B |
             FromUInt |  1.041 ns | 0.0044 ns | 0.0039 ns |       0 B |
     FromUIntNullable |  2.102 ns | 0.0363 ns | 0.0322 ns |       0 B |
             FromLong |  1.936 ns | 0.0053 ns | 0.0050 ns |       0 B |
     FromLongNullable |  2.510 ns | 0.0007 ns | 0.0006 ns |       0 B |
            FromULong |  1.053 ns | 0.0124 ns | 0.0116 ns |       0 B |
    FromULongNullable |  1.643 ns | 0.0055 ns | 0.0052 ns |       0 B |
            FromFloat |  4.895 ns | 0.0075 ns | 0.0067 ns |       0 B |
    FromFloatNullable |  2.686 ns | 0.0057 ns | 0.0051 ns |       0 B |
           FromDouble |  4.678 ns | 0.0012 ns | 0.0010 ns |       0 B |
   FromDoubleNullable |  2.353 ns | 0.0024 ns | 0.0022 ns |       0 B |
          FromDecimal | 14.694 ns | 0.0099 ns | 0.0088 ns |       0 B |
  FromDecimalNullable |  8.583 ns | 0.0148 ns | 0.0138 ns |       0 B |
         FromDateTime |  1.042 ns | 0.0028 ns | 0.0026 ns |       0 B |
 FromDateTimeNullable |  3.418 ns | 0.0618 ns | 0.0547 ns |       0 B |
           FromObject |  4.058 ns | 0.0087 ns | 0.0081 ns |       0 B |
           FromString |  2.616 ns | 0.0067 ns | 0.0063 ns |       0 B |
             FromEnum |  2.028 ns | 0.0037 ns | 0.0035 ns |       0 B |
     FromEnumNullable |  3.798 ns | 0.0333 ns | 0.0311 ns |       0 B |
