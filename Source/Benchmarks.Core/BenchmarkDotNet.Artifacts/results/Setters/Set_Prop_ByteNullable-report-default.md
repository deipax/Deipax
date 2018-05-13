
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.553 ns | 0.0023 ns | 0.0019 ns |       0 B |
     FromBoolNullable |  2.062 ns | 0.0021 ns | 0.0019 ns |       0 B |
             FromChar |  1.898 ns | 0.0048 ns | 0.0040 ns |       0 B |
     FromCharNullable |  2.791 ns | 0.0289 ns | 0.0257 ns |       0 B |
            FromSByte |  1.888 ns | 0.0248 ns | 0.0232 ns |       0 B |
    FromSByteNullable |  2.701 ns | 0.0055 ns | 0.0052 ns |       0 B |
             FromByte |  1.041 ns | 0.0060 ns | 0.0056 ns |       0 B |
     FromByteNullable |  1.050 ns | 0.0029 ns | 0.0027 ns |       0 B |
            FromShort |  2.890 ns | 0.0065 ns | 0.0054 ns |       0 B |
    FromShortNullable |  4.340 ns | 0.0135 ns | 0.0120 ns |       0 B |
           FromUShort |  1.894 ns | 0.0065 ns | 0.0061 ns |       0 B |
   FromUShortNullable |  2.822 ns | 0.0064 ns | 0.0060 ns |       0 B |
              FromInt |  2.649 ns | 0.0230 ns | 0.0215 ns |       0 B |
      FromIntNullable |  3.713 ns | 0.0016 ns | 0.0013 ns |       0 B |
             FromUInt |  1.958 ns | 0.0099 ns | 0.0092 ns |       0 B |
     FromUIntNullable |  2.761 ns | 0.0010 ns | 0.0008 ns |       0 B |
             FromLong |  2.826 ns | 0.0154 ns | 0.0137 ns |       0 B |
     FromLongNullable |  4.365 ns | 0.0070 ns | 0.0065 ns |       0 B |
            FromULong |  2.587 ns | 0.0121 ns | 0.0113 ns |       0 B |
    FromULongNullable |  4.364 ns | 0.0048 ns | 0.0042 ns |       0 B |
            FromFloat |  5.627 ns | 0.0013 ns | 0.0011 ns |       0 B |
    FromFloatNullable |  6.796 ns | 0.0087 ns | 0.0082 ns |       0 B |
           FromDouble |  5.465 ns | 0.0056 ns | 0.0047 ns |       0 B |
   FromDoubleNullable |  6.791 ns | 0.0127 ns | 0.0119 ns |       0 B |
          FromDecimal | 15.699 ns | 0.0077 ns | 0.0069 ns |       0 B |
  FromDecimalNullable | 26.138 ns | 0.0968 ns | 0.0858 ns |       0 B |
         FromDateTime |  1.039 ns | 0.0021 ns | 0.0017 ns |       0 B |
 FromDateTimeNullable |  2.147 ns | 0.0292 ns | 0.0273 ns |       0 B |
           FromObject | 13.671 ns | 0.0230 ns | 0.0204 ns |       0 B |
           FromString | 75.990 ns | 0.1386 ns | 0.1158 ns |       0 B |
             FromEnum |  2.675 ns | 0.0072 ns | 0.0068 ns |       0 B |
     FromEnumNullable |  3.847 ns | 0.0075 ns | 0.0067 ns |       0 B |
