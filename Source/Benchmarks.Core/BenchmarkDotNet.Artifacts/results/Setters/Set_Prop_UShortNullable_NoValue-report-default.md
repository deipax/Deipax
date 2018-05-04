
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  6.798 ns | 0.0358 ns | 0.0335 ns |       0 B |
     FromBoolNullable |  6.541 ns | 0.0248 ns | 0.0207 ns |       0 B |
             FromChar |  6.750 ns | 0.0011 ns | 0.0009 ns |       0 B |
     FromCharNullable |  6.526 ns | 0.0148 ns | 0.0131 ns |       0 B |
            FromSByte |  6.753 ns | 0.0008 ns | 0.0007 ns |       0 B |
    FromSByteNullable |  6.780 ns | 0.0150 ns | 0.0140 ns |       0 B |
             FromByte |  6.754 ns | 0.0039 ns | 0.0037 ns |       0 B |
     FromByteNullable |  6.520 ns | 0.0118 ns | 0.0110 ns |       0 B |
            FromShort |  6.759 ns | 0.0140 ns | 0.0117 ns |       0 B |
    FromShortNullable |  6.779 ns | 0.0064 ns | 0.0059 ns |       0 B |
           FromUShort |  1.149 ns | 0.0045 ns | 0.0042 ns |       0 B |
   FromUShortNullable |  1.006 ns | 0.0032 ns | 0.0028 ns |       0 B |
              FromInt |  7.504 ns | 0.0011 ns | 0.0010 ns |       0 B |
      FromIntNullable |  6.489 ns | 0.0471 ns | 0.0418 ns |       0 B |
             FromUInt |  6.755 ns | 0.0040 ns | 0.0037 ns |       0 B |
     FromUIntNullable |  6.787 ns | 0.0176 ns | 0.0138 ns |       0 B |
             FromLong |  7.508 ns | 0.0074 ns | 0.0069 ns |       0 B |
     FromLongNullable |  7.031 ns | 0.0197 ns | 0.0175 ns |       0 B |
            FromULong |  7.270 ns | 0.0126 ns | 0.0118 ns |       0 B |
    FromULongNullable |  7.008 ns | 0.0009 ns | 0.0009 ns |       0 B |
            FromFloat |  8.932 ns | 0.0013 ns | 0.0011 ns |       0 B |
    FromFloatNullable |  6.518 ns | 0.0176 ns | 0.0147 ns |       0 B |
           FromDouble |  8.942 ns | 0.0021 ns | 0.0018 ns |       0 B |
   FromDoubleNullable |  7.029 ns | 0.0207 ns | 0.0172 ns |       0 B |
          FromDecimal | 20.580 ns | 0.0119 ns | 0.0105 ns |       0 B |
  FromDecimalNullable |  7.282 ns | 0.0053 ns | 0.0047 ns |       0 B |
         FromDateTime |  6.805 ns | 0.0089 ns | 0.0079 ns |       0 B |
 FromDateTimeNullable |  7.266 ns | 0.0046 ns | 0.0043 ns |       0 B |
           FromObject |  7.543 ns | 0.0108 ns | 0.0101 ns |       0 B |
           FromString |  7.010 ns | 0.0122 ns | 0.0115 ns |       0 B |
             FromEnum |  7.496 ns | 0.0091 ns | 0.0085 ns |       0 B |
     FromEnumNullable |  6.523 ns | 0.0035 ns | 0.0033 ns |       0 B |
