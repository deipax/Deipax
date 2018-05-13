
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.555 ns | 0.0044 ns | 0.0041 ns |       0 B |
     FromBoolNullable |  2.065 ns | 0.0056 ns | 0.0052 ns |       0 B |
             FromChar |  1.193 ns | 0.0053 ns | 0.0045 ns |       0 B |
     FromCharNullable |  2.093 ns | 0.0161 ns | 0.0150 ns |       0 B |
            FromSByte |  1.893 ns | 0.0067 ns | 0.0063 ns |       0 B |
    FromSByteNullable |  2.642 ns | 0.0059 ns | 0.0052 ns |       0 B |
             FromByte |  1.042 ns | 0.0059 ns | 0.0052 ns |       0 B |
     FromByteNullable |  1.724 ns | 0.0064 ns | 0.0059 ns |       0 B |
            FromShort |  1.919 ns | 0.0050 ns | 0.0047 ns |       0 B |
    FromShortNullable |  2.787 ns | 0.0064 ns | 0.0060 ns |       0 B |
           FromUShort |  1.043 ns | 0.0051 ns | 0.0048 ns |       0 B |
   FromUShortNullable |  2.439 ns | 0.0115 ns | 0.0107 ns |       0 B |
              FromInt |  1.926 ns | 0.0048 ns | 0.0038 ns |       0 B |
      FromIntNullable |  2.756 ns | 0.0012 ns | 0.0010 ns |       0 B |
             FromUInt |  1.081 ns | 0.0066 ns | 0.0062 ns |       0 B |
     FromUIntNullable |  2.376 ns | 0.0170 ns | 0.0159 ns |       0 B |
             FromLong |  1.970 ns | 0.0034 ns | 0.0031 ns |       0 B |
     FromLongNullable |  3.085 ns | 0.0009 ns | 0.0008 ns |       0 B |
            FromULong |  1.160 ns | 0.0557 ns | 0.0619 ns |       0 B |
    FromULongNullable |  1.652 ns | 0.0051 ns | 0.0045 ns |       0 B |
            FromFloat |  4.902 ns | 0.0118 ns | 0.0111 ns |       0 B |
    FromFloatNullable |  6.252 ns | 0.0118 ns | 0.0110 ns |       0 B |
           FromDouble |  4.711 ns | 0.0027 ns | 0.0024 ns |       0 B |
   FromDoubleNullable |  6.586 ns | 0.0157 ns | 0.0147 ns |       0 B |
          FromDecimal | 14.693 ns | 0.0162 ns | 0.0152 ns |       0 B |
  FromDecimalNullable | 29.696 ns | 0.0371 ns | 0.0347 ns |       0 B |
         FromDateTime |  1.205 ns | 0.0060 ns | 0.0057 ns |       0 B |
 FromDateTimeNullable |  1.860 ns | 0.0054 ns | 0.0050 ns |       0 B |
           FromObject | 16.067 ns | 0.0276 ns | 0.0245 ns |       0 B |
           FromString | 72.317 ns | 0.1641 ns | 0.1535 ns |       0 B |
             FromEnum |  2.053 ns | 0.0040 ns | 0.0038 ns |       0 B |
     FromEnumNullable |  2.785 ns | 0.0086 ns | 0.0080 ns |       0 B |
