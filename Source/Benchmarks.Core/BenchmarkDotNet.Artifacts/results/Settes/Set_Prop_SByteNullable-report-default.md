
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  6.769 ns | 0.0046 ns | 0.0043 ns |       0 B |
     FromBoolNullable |  6.784 ns | 0.0035 ns | 0.0027 ns |       0 B |
             FromChar |  6.771 ns | 0.0019 ns | 0.0015 ns |       0 B |
     FromCharNullable |  6.784 ns | 0.0014 ns | 0.0013 ns |       0 B |
            FromSByte |  1.134 ns | 0.0021 ns | 0.0017 ns |       0 B |
    FromSByteNullable |  1.039 ns | 0.0011 ns | 0.0010 ns |       0 B |
             FromByte |  6.770 ns | 0.0016 ns | 0.0014 ns |       0 B |
     FromByteNullable |  6.791 ns | 0.0070 ns | 0.0062 ns |       0 B |
            FromShort |  7.385 ns | 0.0129 ns | 0.0120 ns |       0 B |
    FromShortNullable |  7.194 ns | 0.0045 ns | 0.0037 ns |       0 B |
           FromUShort |  6.770 ns | 0.0010 ns | 0.0009 ns |       0 B |
   FromUShortNullable |  6.777 ns | 0.0013 ns | 0.0011 ns |       0 B |
              FromInt |  7.521 ns | 0.0014 ns | 0.0012 ns |       0 B |
      FromIntNullable |  7.323 ns | 0.0945 ns | 0.0884 ns |       0 B |
             FromUInt |  6.770 ns | 0.0012 ns | 0.0010 ns |       0 B |
     FromUIntNullable |  6.785 ns | 0.0012 ns | 0.0011 ns |       0 B |
             FromLong |  7.520 ns | 0.0010 ns | 0.0009 ns |       0 B |
     FromLongNullable |  7.796 ns | 0.0089 ns | 0.0079 ns |       0 B |
            FromULong |  6.775 ns | 0.0090 ns | 0.0084 ns |       0 B |
    FromULongNullable |  7.551 ns | 0.0178 ns | 0.0148 ns |       0 B |
            FromFloat |  8.919 ns | 0.0027 ns | 0.0024 ns |       0 B |
    FromFloatNullable |  9.783 ns | 0.0169 ns | 0.0149 ns |       0 B |
           FromDouble |  8.874 ns | 0.0051 ns | 0.0048 ns |       0 B |
   FromDoubleNullable |  9.874 ns | 0.0176 ns | 0.0138 ns |       0 B |
          FromDecimal | 20.817 ns | 0.0046 ns | 0.0038 ns |       0 B |
  FromDecimalNullable | 25.989 ns | 0.0285 ns | 0.0222 ns |       0 B |
         FromDateTime |  6.848 ns | 0.0031 ns | 0.0026 ns |       0 B |
 FromDateTimeNullable |  7.296 ns | 0.0141 ns | 0.0132 ns |       0 B |
           FromObject | 13.883 ns | 0.0021 ns | 0.0017 ns |       0 B |
           FromString | 79.853 ns | 0.1652 ns | 0.1545 ns |       0 B |
             FromEnum |  7.510 ns | 0.0097 ns | 0.0090 ns |       0 B |
     FromEnumNullable |  7.176 ns | 0.0015 ns | 0.0013 ns |       0 B |
