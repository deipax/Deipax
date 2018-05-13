
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.549 ns | 0.0012 ns | 0.0010 ns |       0 B |
     FromBoolNullable |  2.079 ns | 0.0034 ns | 0.0032 ns |       0 B |
             FromChar |  1.042 ns | 0.0035 ns | 0.0031 ns |       0 B |
     FromCharNullable |  1.867 ns | 0.0620 ns | 0.0580 ns |       0 B |
            FromSByte |  1.949 ns | 0.0059 ns | 0.0055 ns |       0 B |
    FromSByteNullable |  2.672 ns | 0.0056 ns | 0.0053 ns |       0 B |
             FromByte |  1.039 ns | 0.0106 ns | 0.0094 ns |       0 B |
     FromByteNullable |  1.604 ns | 0.0053 ns | 0.0047 ns |       0 B |
            FromShort |  1.914 ns | 0.0071 ns | 0.0066 ns |       0 B |
    FromShortNullable |  3.094 ns | 0.0179 ns | 0.0167 ns |       0 B |
           FromUShort |  1.040 ns | 0.0035 ns | 0.0031 ns |       0 B |
   FromUShortNullable |  1.780 ns | 0.0115 ns | 0.0108 ns |       0 B |
              FromInt |  1.953 ns | 0.0027 ns | 0.0024 ns |       0 B |
      FromIntNullable |  2.543 ns | 0.0073 ns | 0.0068 ns |       0 B |
             FromUInt |  1.043 ns | 0.0040 ns | 0.0037 ns |       0 B |
     FromUIntNullable |  1.006 ns | 0.0026 ns | 0.0023 ns |       0 B |
             FromLong |  2.853 ns | 0.0060 ns | 0.0047 ns |       0 B |
     FromLongNullable |  4.371 ns | 0.0125 ns | 0.0117 ns |       0 B |
            FromULong |  2.147 ns | 0.0108 ns | 0.0101 ns |       0 B |
    FromULongNullable |  3.104 ns | 0.0108 ns | 0.0101 ns |       0 B |
            FromFloat |  4.671 ns | 0.0282 ns | 0.0264 ns |       0 B |
    FromFloatNullable |  5.840 ns | 0.1197 ns | 0.1378 ns |       0 B |
           FromDouble |  4.133 ns | 0.0139 ns | 0.0116 ns |       0 B |
   FromDoubleNullable |  5.273 ns | 0.0067 ns | 0.0060 ns |       0 B |
          FromDecimal | 14.496 ns | 0.0137 ns | 0.0128 ns |       0 B |
  FromDecimalNullable | 25.176 ns | 0.0241 ns | 0.0214 ns |       0 B |
         FromDateTime |  1.970 ns | 0.0218 ns | 0.0204 ns |       0 B |
 FromDateTimeNullable |  2.079 ns | 0.0062 ns | 0.0058 ns |       0 B |
           FromObject | 13.917 ns | 0.0108 ns | 0.0090 ns |       0 B |
           FromString | 72.841 ns | 0.1042 ns | 0.0975 ns |       0 B |
             FromEnum |  2.577 ns | 0.0137 ns | 0.0128 ns |       0 B |
     FromEnumNullable |  2.534 ns | 0.0068 ns | 0.0064 ns |       0 B |
