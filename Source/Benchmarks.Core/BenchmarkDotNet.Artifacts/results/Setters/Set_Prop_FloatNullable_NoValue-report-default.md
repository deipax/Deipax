
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |     Median | Allocated |
--------------------- |-----------:|----------:|----------:|-----------:|----------:|
             FromBool |  1.2997 ns | 0.0014 ns | 0.0011 ns |  1.2995 ns |       0 B |
     FromBoolNullable |  1.5533 ns | 0.0040 ns | 0.0037 ns |  1.5514 ns |       0 B |
             FromChar |  1.0407 ns | 0.0028 ns | 0.0026 ns |  1.0409 ns |       0 B |
     FromCharNullable |  0.9558 ns | 0.0031 ns | 0.0026 ns |  0.9562 ns |       0 B |
            FromSByte |  1.0445 ns | 0.0041 ns | 0.0038 ns |  1.0443 ns |       0 B |
    FromSByteNullable |  1.8141 ns | 0.0013 ns | 0.0008 ns |  1.8140 ns |       0 B |
             FromByte |  1.0384 ns | 0.0014 ns | 0.0013 ns |  1.0378 ns |       0 B |
     FromByteNullable |  1.8120 ns | 0.0052 ns | 0.0049 ns |  1.8131 ns |       0 B |
            FromShort |  1.0566 ns | 0.0037 ns | 0.0034 ns |  1.0560 ns |       0 B |
    FromShortNullable |  1.8041 ns | 0.0023 ns | 0.0021 ns |  1.8031 ns |       0 B |
           FromUShort |  1.0795 ns | 0.0053 ns | 0.0047 ns |  1.0797 ns |       0 B |
   FromUShortNullable |  1.8103 ns | 0.0033 ns | 0.0031 ns |  1.8092 ns |       0 B |
              FromInt |  1.0436 ns | 0.0048 ns | 0.0045 ns |  1.0438 ns |       0 B |
      FromIntNullable |  1.5477 ns | 0.0049 ns | 0.0046 ns |  1.5470 ns |       0 B |
             FromUInt |  1.0869 ns | 0.0040 ns | 0.0038 ns |  1.0883 ns |       0 B |
     FromUIntNullable |  1.5531 ns | 0.0055 ns | 0.0052 ns |  1.5514 ns |       0 B |
             FromLong |  1.0529 ns | 0.0051 ns | 0.0048 ns |  1.0519 ns |       0 B |
     FromLongNullable |  2.3134 ns | 0.0076 ns | 0.0071 ns |  2.3099 ns |       0 B |
            FromULong |  1.9845 ns | 0.0723 ns | 0.1733 ns |  1.9102 ns |       0 B |
    FromULongNullable |  2.3225 ns | 0.0099 ns | 0.0093 ns |  2.3192 ns |       0 B |
            FromFloat |  1.2800 ns | 0.0027 ns | 0.0022 ns |  1.2796 ns |       0 B |
    FromFloatNullable |  0.9632 ns | 0.0005 ns | 0.0004 ns |  0.9631 ns |       0 B |
           FromDouble |  1.2815 ns | 0.0038 ns | 0.0036 ns |  1.2808 ns |       0 B |
   FromDoubleNullable |  2.0603 ns | 0.0029 ns | 0.0026 ns |  2.0606 ns |       0 B |
          FromDecimal | 12.6651 ns | 0.0072 ns | 0.0064 ns | 12.6631 ns |       0 B |
  FromDecimalNullable |  8.7015 ns | 0.0110 ns | 0.0092 ns |  8.7009 ns |       0 B |
         FromDateTime |  1.0428 ns | 0.0031 ns | 0.0029 ns |  1.0415 ns |       0 B |
 FromDateTimeNullable |  3.4200 ns | 0.0153 ns | 0.0143 ns |  3.4174 ns |       0 B |
           FromObject |  4.0486 ns | 0.0043 ns | 0.0040 ns |  4.0489 ns |       0 B |
           FromString |  2.4418 ns | 0.0157 ns | 0.0147 ns |  2.4370 ns |       0 B |
             FromEnum |  1.0428 ns | 0.0033 ns | 0.0031 ns |  1.0425 ns |       0 B |
     FromEnumNullable |  1.5557 ns | 0.0044 ns | 0.0041 ns |  1.5539 ns |       0 B |
