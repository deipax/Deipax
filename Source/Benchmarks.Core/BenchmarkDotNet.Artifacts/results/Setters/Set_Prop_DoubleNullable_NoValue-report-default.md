
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  4.843 ns | 0.0059 ns | 0.0055 ns |       0 B |
     FromBoolNullable |  5.135 ns | 0.0011 ns | 0.0010 ns |       0 B |
             FromChar |  4.609 ns | 0.0116 ns | 0.0103 ns |       0 B |
     FromCharNullable |  4.544 ns | 0.0030 ns | 0.0028 ns |       0 B |
            FromSByte |  5.051 ns | 0.0129 ns | 0.0107 ns |       0 B |
    FromSByteNullable |  5.099 ns | 0.0011 ns | 0.0008 ns |       0 B |
             FromByte |  5.059 ns | 0.0069 ns | 0.0058 ns |       0 B |
     FromByteNullable |  5.155 ns | 0.0042 ns | 0.0039 ns |       0 B |
            FromShort |  5.063 ns | 0.0119 ns | 0.0111 ns |       0 B |
    FromShortNullable |  4.888 ns | 0.0021 ns | 0.0017 ns |       0 B |
           FromUShort |  5.535 ns | 0.0051 ns | 0.0046 ns |       0 B |
   FromUShortNullable |  5.024 ns | 0.0019 ns | 0.0016 ns |       0 B |
              FromInt |  4.825 ns | 0.0072 ns | 0.0056 ns |       0 B |
      FromIntNullable |  4.847 ns | 0.0052 ns | 0.0048 ns |       0 B |
             FromUInt |  5.195 ns | 0.0077 ns | 0.0060 ns |       0 B |
     FromUIntNullable |  4.850 ns | 0.0033 ns | 0.0025 ns |       0 B |
             FromLong |  4.696 ns | 0.0093 ns | 0.0078 ns |       0 B |
     FromLongNullable |  5.605 ns | 0.0016 ns | 0.0014 ns |       0 B |
            FromULong |  4.838 ns | 0.0008 ns | 0.0006 ns |       0 B |
    FromULongNullable |  5.390 ns | 0.0074 ns | 0.0069 ns |       0 B |
            FromFloat |  6.054 ns | 0.0248 ns | 0.0232 ns |       0 B |
    FromFloatNullable |  4.871 ns | 0.0063 ns | 0.0056 ns |       0 B |
           FromDouble |  1.055 ns | 0.0016 ns | 0.0015 ns |       0 B |
   FromDoubleNullable |  1.828 ns | 0.0035 ns | 0.0031 ns |       0 B |
          FromDecimal | 11.303 ns | 0.0091 ns | 0.0080 ns |       0 B |
  FromDecimalNullable |  6.652 ns | 0.0013 ns | 0.0010 ns |       0 B |
         FromDateTime |  4.850 ns | 0.0033 ns | 0.0026 ns |       0 B |
 FromDateTimeNullable |  4.855 ns | 0.0051 ns | 0.0045 ns |       0 B |
           FromObject |  7.377 ns | 0.0010 ns | 0.0008 ns |       0 B |
           FromString |  6.558 ns | 0.0031 ns | 0.0027 ns |       0 B |
             FromEnum |  5.174 ns | 0.0018 ns | 0.0014 ns |       0 B |
     FromEnumNullable |  5.262 ns | 0.0006 ns | 0.0005 ns |       0 B |
