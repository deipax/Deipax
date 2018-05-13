
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |    Median | Allocated |
--------------------- |----------:|----------:|----------:|----------:|----------:|
             FromBool |  1.521 ns | 0.0049 ns | 0.0044 ns |  1.521 ns |       0 B |
     FromBoolNullable |  2.035 ns | 0.0031 ns | 0.0028 ns |  2.035 ns |       0 B |
             FromChar |  1.007 ns | 0.0024 ns | 0.0020 ns |  1.006 ns |       0 B |
     FromCharNullable |  1.095 ns | 0.0077 ns | 0.0060 ns |  1.093 ns |       0 B |
            FromSByte |  1.022 ns | 0.0100 ns | 0.0084 ns |  1.021 ns |       0 B |
    FromSByteNullable |  1.990 ns | 0.0132 ns | 0.0123 ns |  1.987 ns |       0 B |
             FromByte |  1.260 ns | 0.0069 ns | 0.0061 ns |  1.258 ns |       0 B |
     FromByteNullable |  1.797 ns | 0.0073 ns | 0.0061 ns |  1.795 ns |       0 B |
            FromShort |  1.019 ns | 0.0069 ns | 0.0065 ns |  1.019 ns |       0 B |
    FromShortNullable |  2.785 ns | 0.0685 ns | 0.0641 ns |  2.788 ns |       0 B |
           FromUShort |  1.015 ns | 0.0115 ns | 0.0096 ns |  1.011 ns |       0 B |
   FromUShortNullable |  2.194 ns | 0.0231 ns | 0.0216 ns |  2.190 ns |       0 B |
              FromInt |  1.085 ns | 0.0146 ns | 0.0122 ns |  1.088 ns |       0 B |
      FromIntNullable |  6.179 ns | 0.2126 ns | 0.6134 ns |  5.996 ns |       0 B |
             FromUInt |  1.075 ns | 0.0111 ns | 0.0098 ns |  1.074 ns |       0 B |
     FromUIntNullable |  3.232 ns | 0.0784 ns | 0.0695 ns |  3.234 ns |       0 B |
             FromLong |  1.010 ns | 0.0089 ns | 0.0079 ns |  1.014 ns |       0 B |
     FromLongNullable |  2.544 ns | 0.0047 ns | 0.0044 ns |  2.542 ns |       0 B |
            FromULong |  1.352 ns | 0.0116 ns | 0.0103 ns |  1.354 ns |       0 B |
    FromULongNullable |  3.057 ns | 0.0033 ns | 0.0030 ns |  3.057 ns |       0 B |
            FromFloat |  1.238 ns | 0.0094 ns | 0.0088 ns |  1.240 ns |       0 B |
    FromFloatNullable |  1.017 ns | 0.0033 ns | 0.0031 ns |  1.017 ns |       0 B |
           FromDouble |  1.031 ns | 0.0022 ns | 0.0021 ns |  1.031 ns |       0 B |
   FromDoubleNullable |  2.296 ns | 0.0071 ns | 0.0067 ns |  2.292 ns |       0 B |
          FromDecimal | 11.667 ns | 0.0110 ns | 0.0103 ns | 11.667 ns |       0 B |
  FromDecimalNullable | 26.459 ns | 0.0147 ns | 0.0130 ns | 26.451 ns |       0 B |
         FromDateTime |  1.807 ns | 0.0226 ns | 0.0200 ns |  1.807 ns |       0 B |
 FromDateTimeNullable |  1.878 ns | 0.0038 ns | 0.0036 ns |  1.879 ns |       0 B |
           FromObject | 13.439 ns | 0.0158 ns | 0.0140 ns | 13.441 ns |       0 B |
           FromString | 94.707 ns | 0.0853 ns | 0.0756 ns | 94.676 ns |       0 B |
             FromEnum |  1.025 ns | 0.0018 ns | 0.0016 ns |  1.024 ns |       0 B |
     FromEnumNullable |  2.473 ns | 0.0188 ns | 0.0176 ns |  2.472 ns |       0 B |
