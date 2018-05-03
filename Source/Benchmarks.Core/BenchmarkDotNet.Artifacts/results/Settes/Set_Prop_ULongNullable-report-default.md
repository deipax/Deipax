
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  4.708 ns | 0.0011 ns | 0.0010 ns |       0 B |
     FromBoolNullable |  5.643 ns | 0.0110 ns | 0.0103 ns |       0 B |
             FromChar |  4.762 ns | 0.0050 ns | 0.0047 ns |       0 B |
     FromCharNullable |  5.357 ns | 0.0042 ns | 0.0039 ns |       0 B |
            FromSByte |  5.574 ns | 0.0024 ns | 0.0020 ns |       0 B |
    FromSByteNullable |  6.685 ns | 0.0051 ns | 0.0045 ns |       0 B |
             FromByte |  4.808 ns | 0.0024 ns | 0.0020 ns |       0 B |
     FromByteNullable |  5.779 ns | 0.0044 ns | 0.0037 ns |       0 B |
            FromShort |  5.544 ns | 0.0146 ns | 0.0114 ns |       0 B |
    FromShortNullable |  6.665 ns | 0.0045 ns | 0.0042 ns |       0 B |
           FromUShort |  5.488 ns | 0.0101 ns | 0.0089 ns |       0 B |
   FromUShortNullable |  5.298 ns | 0.0027 ns | 0.0024 ns |       0 B |
              FromInt |  5.553 ns | 0.0014 ns | 0.0013 ns |       0 B |
      FromIntNullable |  6.669 ns | 0.0059 ns | 0.0049 ns |       0 B |
             FromUInt |  5.191 ns | 0.0194 ns | 0.0182 ns |       0 B |
     FromUIntNullable |  5.459 ns | 0.0024 ns | 0.0022 ns |       0 B |
             FromLong |  5.216 ns | 0.0181 ns | 0.0160 ns |       0 B |
     FromLongNullable |  6.390 ns | 0.0052 ns | 0.0049 ns |       0 B |
            FromULong |  1.011 ns | 0.0038 ns | 0.0034 ns |       0 B |
    FromULongNullable |  1.521 ns | 0.0013 ns | 0.0012 ns |       0 B |
            FromFloat |  9.626 ns | 0.0087 ns | 0.0081 ns |       0 B |
    FromFloatNullable | 11.187 ns | 0.0089 ns | 0.0083 ns |       0 B |
           FromDouble |  9.359 ns | 0.0015 ns | 0.0012 ns |       0 B |
   FromDoubleNullable | 10.412 ns | 0.0047 ns | 0.0041 ns |       0 B |
          FromDecimal | 16.490 ns | 0.0027 ns | 0.0025 ns |       0 B |
  FromDecimalNullable | 21.377 ns | 0.0065 ns | 0.0054 ns |       0 B |
         FromDateTime |  4.827 ns | 0.0016 ns | 0.0014 ns |       0 B |
 FromDateTimeNullable |  4.852 ns | 0.0029 ns | 0.0025 ns |       0 B |
           FromObject | 13.433 ns | 0.0068 ns | 0.0057 ns |       0 B |
           FromString | 75.993 ns | 0.0704 ns | 0.0588 ns |       0 B |
             FromEnum |  5.617 ns | 0.0064 ns | 0.0060 ns |       0 B |
     FromEnumNullable |  6.797 ns | 0.0034 ns | 0.0027 ns |       0 B |
