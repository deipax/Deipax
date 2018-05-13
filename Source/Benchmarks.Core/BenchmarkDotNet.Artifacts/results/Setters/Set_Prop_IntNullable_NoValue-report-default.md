
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.2635 ns | 0.0031 ns | 0.0028 ns |       0 B |
     FromBoolNullable |  1.7788 ns | 0.0030 ns | 0.0027 ns |       0 B |
             FromChar |  1.0125 ns | 0.0103 ns | 0.0086 ns |       0 B |
     FromCharNullable |  1.8016 ns | 0.0335 ns | 0.0297 ns |       0 B |
            FromSByte |  1.0110 ns | 0.0042 ns | 0.0039 ns |       0 B |
    FromSByteNullable |  1.7829 ns | 0.0207 ns | 0.0193 ns |       0 B |
             FromByte |  1.0063 ns | 0.0017 ns | 0.0016 ns |       0 B |
     FromByteNullable |  1.7857 ns | 0.0147 ns | 0.0130 ns |       0 B |
            FromShort |  1.0074 ns | 0.0030 ns | 0.0026 ns |       0 B |
    FromShortNullable |  2.0760 ns | 0.0719 ns | 0.0706 ns |       0 B |
           FromUShort |  1.0820 ns | 0.0060 ns | 0.0050 ns |       0 B |
   FromUShortNullable |  1.7553 ns | 0.0059 ns | 0.0055 ns |       0 B |
              FromInt |  1.0025 ns | 0.0030 ns | 0.0026 ns |       0 B |
      FromIntNullable |  0.9525 ns | 0.0039 ns | 0.0035 ns |       0 B |
             FromUInt |  2.0162 ns | 0.0033 ns | 0.0031 ns |       0 B |
     FromUIntNullable |  2.4420 ns | 0.0067 ns | 0.0059 ns |       0 B |
             FromLong |  2.5735 ns | 0.0061 ns | 0.0057 ns |       0 B |
     FromLongNullable |  2.6154 ns | 0.0181 ns | 0.0160 ns |       0 B |
            FromULong |  2.5937 ns | 0.0060 ns | 0.0056 ns |       0 B |
    FromULongNullable |  3.0147 ns | 0.0783 ns | 0.0654 ns |       0 B |
            FromFloat |  4.6746 ns | 0.0123 ns | 0.0115 ns |       0 B |
    FromFloatNullable |  2.4713 ns | 0.0076 ns | 0.0064 ns |       0 B |
           FromDouble |  4.3160 ns | 0.0341 ns | 0.0319 ns |       0 B |
   FromDoubleNullable |  2.6751 ns | 0.0859 ns | 0.0919 ns |       0 B |
          FromDecimal | 15.2518 ns | 0.2318 ns | 0.2055 ns |       0 B |
  FromDecimalNullable |  8.5506 ns | 0.0949 ns | 0.0888 ns |       0 B |
         FromDateTime |  1.1401 ns | 0.0573 ns | 0.1459 ns |       0 B |
 FromDateTimeNullable |  2.0436 ns | 0.0743 ns | 0.1112 ns |       0 B |
           FromObject |  4.3006 ns | 0.1204 ns | 0.3357 ns |       0 B |
           FromString |  2.5957 ns | 0.0864 ns | 0.1536 ns |       0 B |
             FromEnum |  1.0775 ns | 0.0560 ns | 0.0524 ns |       0 B |
     FromEnumNullable |  1.5155 ns | 0.0609 ns | 0.0509 ns |       0 B |
