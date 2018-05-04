
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  3.662 ns | 0.0144 ns | 0.0128 ns |       0 B |
     FromBoolNullable |  4.582 ns | 0.0379 ns | 0.0317 ns |       0 B |
             FromChar |  4.301 ns | 0.0134 ns | 0.0112 ns |       0 B |
     FromCharNullable |  4.825 ns | 0.0310 ns | 0.0275 ns |       0 B |
            FromSByte |  3.689 ns | 0.0073 ns | 0.0068 ns |       0 B |
    FromSByteNullable |  4.658 ns | 0.0283 ns | 0.0265 ns |       0 B |
             FromByte |  3.718 ns | 0.0020 ns | 0.0017 ns |       0 B |
     FromByteNullable |  4.591 ns | 0.0014 ns | 0.0012 ns |       0 B |
            FromShort |  1.007 ns | 0.0026 ns | 0.0025 ns |       0 B |
    FromShortNullable |  1.774 ns | 0.0021 ns | 0.0019 ns |       0 B |
           FromUShort |  4.414 ns | 0.0502 ns | 0.0470 ns |       0 B |
   FromUShortNullable |  4.799 ns | 0.0080 ns | 0.0071 ns |       0 B |
              FromInt |  4.704 ns | 0.0221 ns | 0.0207 ns |       0 B |
      FromIntNullable |  6.181 ns | 0.0046 ns | 0.0043 ns |       0 B |
             FromUInt |  4.922 ns | 0.0076 ns | 0.0071 ns |       0 B |
     FromUIntNullable |  5.356 ns | 0.0094 ns | 0.0088 ns |       0 B |
             FromLong |  4.694 ns | 0.0116 ns | 0.0109 ns |       0 B |
     FromLongNullable |  6.117 ns | 0.0016 ns | 0.0013 ns |       0 B |
            FromULong |  4.410 ns | 0.0054 ns | 0.0048 ns |       0 B |
    FromULongNullable |  6.115 ns | 0.0013 ns | 0.0010 ns |       0 B |
            FromFloat |  8.287 ns | 0.0382 ns | 0.0358 ns |       0 B |
    FromFloatNullable |  9.334 ns | 0.0104 ns | 0.0092 ns |       0 B |
           FromDouble |  8.316 ns | 0.0670 ns | 0.0560 ns |       0 B |
   FromDoubleNullable |  9.339 ns | 0.0123 ns | 0.0115 ns |       0 B |
          FromDecimal | 16.174 ns | 0.0045 ns | 0.0038 ns |       0 B |
  FromDecimalNullable | 25.448 ns | 0.0103 ns | 0.0097 ns |       0 B |
         FromDateTime |  3.636 ns | 0.0017 ns | 0.0013 ns |       0 B |
 FromDateTimeNullable |  3.907 ns | 0.0056 ns | 0.0052 ns |       0 B |
           FromObject |  2.703 ns | 0.0267 ns | 0.0236 ns |       0 B |
           FromString | 77.937 ns | 0.0815 ns | 0.0763 ns |       0 B |
             FromEnum |  4.876 ns | 0.0066 ns | 0.0059 ns |       0 B |
     FromEnumNullable |  5.488 ns | 0.0141 ns | 0.0125 ns |       0 B |
