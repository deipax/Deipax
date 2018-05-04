
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  4.849 ns | 0.0031 ns | 0.0026 ns |       0 B |
     FromBoolNullable |  5.066 ns | 0.0011 ns | 0.0008 ns |       0 B |
             FromChar |  4.800 ns | 0.0012 ns | 0.0010 ns |       0 B |
     FromCharNullable |  4.866 ns | 0.0054 ns | 0.0051 ns |       0 B |
            FromSByte |  4.787 ns | 0.0034 ns | 0.0030 ns |       0 B |
    FromSByteNullable |  5.085 ns | 0.0077 ns | 0.0072 ns |       0 B |
             FromByte |  4.848 ns | 0.0043 ns | 0.0038 ns |       0 B |
     FromByteNullable |  5.192 ns | 0.0123 ns | 0.0115 ns |       0 B |
            FromShort |  5.555 ns | 0.0092 ns | 0.0086 ns |       0 B |
    FromShortNullable |  4.878 ns | 0.0102 ns | 0.0090 ns |       0 B |
           FromUShort |  5.551 ns | 0.0011 ns | 0.0010 ns |       0 B |
   FromUShortNullable |  4.880 ns | 0.0093 ns | 0.0087 ns |       0 B |
              FromInt |  5.117 ns | 0.1221 ns | 0.1142 ns |       0 B |
      FromIntNullable |  4.908 ns | 0.0013 ns | 0.0010 ns |       0 B |
             FromUInt |  5.328 ns | 0.0047 ns | 0.0044 ns |       0 B |
     FromUIntNullable |  4.926 ns | 0.0016 ns | 0.0013 ns |       0 B |
             FromLong |  1.052 ns | 0.0017 ns | 0.0015 ns |       0 B |
     FromLongNullable |  1.775 ns | 0.0037 ns | 0.0034 ns |       0 B |
            FromULong |  5.356 ns | 0.0018 ns | 0.0016 ns |       0 B |
    FromULongNullable |  5.824 ns | 0.0013 ns | 0.0012 ns |       0 B |
            FromFloat |  8.641 ns | 0.0109 ns | 0.0102 ns |       0 B |
    FromFloatNullable |  6.242 ns | 0.0012 ns | 0.0010 ns |       0 B |
           FromDouble |  8.919 ns | 0.0010 ns | 0.0009 ns |       0 B |
   FromDoubleNullable |  5.814 ns | 0.0026 ns | 0.0021 ns |       0 B |
          FromDecimal | 16.695 ns | 0.0071 ns | 0.0059 ns |       0 B |
  FromDecimalNullable |  5.635 ns | 0.0028 ns | 0.0025 ns |       0 B |
         FromDateTime |  4.848 ns | 0.0009 ns | 0.0007 ns |       0 B |
 FromDateTimeNullable |  4.850 ns | 0.0008 ns | 0.0007 ns |       0 B |
           FromObject |  7.529 ns | 0.0054 ns | 0.0050 ns |       0 B |
           FromString |  5.228 ns | 0.0010 ns | 0.0008 ns |       0 B |
             FromEnum |  5.312 ns | 0.0009 ns | 0.0008 ns |       0 B |
     FromEnumNullable |  5.064 ns | 0.0011 ns | 0.0009 ns |       0 B |
