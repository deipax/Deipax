
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5461 ns | 0.0034 ns | 0.0026 ns |       0 B |
     FromBoolNullable |  2.4072 ns | 0.0785 ns | 0.1074 ns |       0 B |
             FromChar |  8.3085 ns | 0.0864 ns | 0.0808 ns |       0 B |
     FromCharNullable |  1.5772 ns | 0.0241 ns | 0.0214 ns |       0 B |
            FromSByte |  0.7889 ns | 0.0078 ns | 0.0061 ns |       0 B |
    FromSByteNullable |  1.6149 ns | 0.0542 ns | 0.0480 ns |       0 B |
             FromByte |  0.9967 ns | 0.0249 ns | 0.0233 ns |       0 B |
     FromByteNullable |  1.6402 ns | 0.0222 ns | 0.0208 ns |       0 B |
            FromShort |  0.8260 ns | 0.0325 ns | 0.0304 ns |       0 B |
    FromShortNullable |  1.5749 ns | 0.0369 ns | 0.0345 ns |       0 B |
           FromUShort |  0.9158 ns | 0.0224 ns | 0.0198 ns |       0 B |
   FromUShortNullable |  1.5716 ns | 0.0150 ns | 0.0133 ns |       0 B |
              FromInt |  0.8147 ns | 0.0215 ns | 0.0179 ns |       0 B |
      FromIntNullable |  1.9481 ns | 0.0384 ns | 0.0340 ns |       0 B |
             FromUInt |  0.8099 ns | 0.0192 ns | 0.0170 ns |       0 B |
     FromUIntNullable |  1.5335 ns | 0.0127 ns | 0.0113 ns |       0 B |
             FromLong |  0.7909 ns | 0.0043 ns | 0.0038 ns |       0 B |
     FromLongNullable |  2.0816 ns | 0.0238 ns | 0.0198 ns |       0 B |
            FromULong |  1.7184 ns | 0.0587 ns | 0.0549 ns |       0 B |
    FromULongNullable |  3.1039 ns | 0.0297 ns | 0.0248 ns |       0 B |
            FromFloat |  4.9390 ns | 0.1008 ns | 0.0943 ns |       0 B |
    FromFloatNullable |  5.3982 ns | 0.0378 ns | 0.0335 ns |       0 B |
           FromDouble |  4.6634 ns | 0.0478 ns | 0.0423 ns |       0 B |
   FromDoubleNullable |  6.0269 ns | 0.0946 ns | 0.0885 ns |       0 B |
          FromDecimal | 14.9264 ns | 0.2208 ns | 0.2066 ns |       0 B |
  FromDecimalNullable | 25.8355 ns | 0.1379 ns | 0.1290 ns |       0 B |
         FromDateTime |  0.8121 ns | 0.0089 ns | 0.0074 ns |       0 B |
 FromDateTimeNullable |  1.8388 ns | 0.0217 ns | 0.0192 ns |       0 B |
           FromObject |  3.0927 ns | 0.0820 ns | 0.0767 ns |       0 B |
           FromString | 74.5320 ns | 0.3522 ns | 0.2750 ns |       0 B |
             FromEnum |  0.7877 ns | 0.0051 ns | 0.0048 ns |       0 B |
     FromEnumNullable |  1.5950 ns | 0.0327 ns | 0.0273 ns |       0 B |
