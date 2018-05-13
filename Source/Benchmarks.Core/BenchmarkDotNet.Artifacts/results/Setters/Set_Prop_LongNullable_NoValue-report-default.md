
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.295 ns | 0.0026 ns | 0.0025 ns |       0 B |
     FromBoolNullable |  1.805 ns | 0.0036 ns | 0.0032 ns |       0 B |
             FromChar |  1.040 ns | 0.0031 ns | 0.0028 ns |       0 B |
     FromCharNullable |  1.823 ns | 0.0127 ns | 0.0113 ns |       0 B |
            FromSByte |  1.050 ns | 0.0096 ns | 0.0085 ns |       0 B |
    FromSByteNullable |  1.817 ns | 0.0121 ns | 0.0108 ns |       0 B |
             FromByte |  1.041 ns | 0.0028 ns | 0.0026 ns |       0 B |
     FromByteNullable |  1.810 ns | 0.0129 ns | 0.0121 ns |       0 B |
            FromShort |  1.046 ns | 0.0126 ns | 0.0111 ns |       0 B |
    FromShortNullable |  1.847 ns | 0.0078 ns | 0.0073 ns |       0 B |
           FromUShort |  1.042 ns | 0.0061 ns | 0.0057 ns |       0 B |
   FromUShortNullable |  1.794 ns | 0.0058 ns | 0.0048 ns |       0 B |
              FromInt |  1.073 ns | 0.0508 ns | 0.0450 ns |       0 B |
      FromIntNullable |  1.623 ns | 0.0434 ns | 0.0385 ns |       0 B |
             FromUInt |  1.036 ns | 0.0004 ns | 0.0003 ns |       0 B |
     FromUIntNullable |  1.648 ns | 0.0055 ns | 0.0052 ns |       0 B |
             FromLong |  1.185 ns | 0.0162 ns | 0.0135 ns |       0 B |
     FromLongNullable |  1.553 ns | 0.0067 ns | 0.0059 ns |       0 B |
            FromULong |  1.947 ns | 0.0073 ns | 0.0068 ns |       0 B |
    FromULongNullable |  2.905 ns | 0.0129 ns | 0.0108 ns |       0 B |
            FromFloat |  5.123 ns | 0.0120 ns | 0.0113 ns |       0 B |
    FromFloatNullable |  2.473 ns | 0.0039 ns | 0.0035 ns |       0 B |
           FromDouble |  4.611 ns | 0.0057 ns | 0.0053 ns |       0 B |
   FromDoubleNullable |  2.408 ns | 0.0087 ns | 0.0077 ns |       0 B |
          FromDecimal | 14.989 ns | 0.0042 ns | 0.0030 ns |       0 B |
  FromDecimalNullable |  8.360 ns | 0.0035 ns | 0.0029 ns |       0 B |
         FromDateTime |  1.041 ns | 0.0012 ns | 0.0011 ns |       0 B |
 FromDateTimeNullable |  1.864 ns | 0.0058 ns | 0.0055 ns |       0 B |
           FromObject |  4.124 ns | 0.0081 ns | 0.0063 ns |       0 B |
           FromString |  2.956 ns | 0.0064 ns | 0.0060 ns |       0 B |
             FromEnum |  1.040 ns | 0.0025 ns | 0.0023 ns |       0 B |
     FromEnumNullable |  2.315 ns | 0.0234 ns | 0.0219 ns |       0 B |
