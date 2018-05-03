
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  3.953 ns | 0.0136 ns | 0.0121 ns |       0 B |
     FromBoolNullable |  4.658 ns | 0.0020 ns | 0.0017 ns |       0 B |
             FromChar |  3.656 ns | 0.0018 ns | 0.0016 ns |       0 B |
     FromCharNullable |  3.663 ns | 0.0043 ns | 0.0040 ns |       0 B |
            FromSByte |  3.801 ns | 0.0008 ns | 0.0006 ns |       0 B |
    FromSByteNullable |  4.730 ns | 0.0096 ns | 0.0085 ns |       0 B |
             FromByte |  4.067 ns | 0.0042 ns | 0.0037 ns |       0 B |
     FromByteNullable |  4.747 ns | 0.0048 ns | 0.0040 ns |       0 B |
            FromShort |  3.785 ns | 0.0021 ns | 0.0017 ns |       0 B |
    FromShortNullable |  4.541 ns | 0.0080 ns | 0.0067 ns |       0 B |
           FromUShort |  3.836 ns | 0.0051 ns | 0.0043 ns |       0 B |
   FromUShortNullable |  4.488 ns | 0.0113 ns | 0.0106 ns |       0 B |
              FromInt |  3.723 ns | 0.0007 ns | 0.0006 ns |       0 B |
      FromIntNullable |  4.510 ns | 0.0025 ns | 0.0022 ns |       0 B |
             FromUInt |  3.908 ns | 0.0050 ns | 0.0047 ns |       0 B |
     FromUIntNullable |  4.492 ns | 0.0014 ns | 0.0012 ns |       0 B |
             FromLong |  3.593 ns | 0.0097 ns | 0.0076 ns |       0 B |
     FromLongNullable |  4.836 ns | 0.0119 ns | 0.0105 ns |       0 B |
            FromULong |  3.769 ns | 0.1255 ns | 0.1112 ns |       0 B |
    FromULongNullable |  5.360 ns | 0.0058 ns | 0.0045 ns |       0 B |
            FromFloat |  4.126 ns | 0.0041 ns | 0.0038 ns |       0 B |
    FromFloatNullable |  4.550 ns | 0.0044 ns | 0.0035 ns |       0 B |
           FromDouble |  1.097 ns | 0.0017 ns | 0.0016 ns |       0 B |
   FromDoubleNullable |  2.029 ns | 0.0005 ns | 0.0004 ns |       0 B |
          FromDecimal | 10.621 ns | 0.0045 ns | 0.0042 ns |       0 B |
  FromDecimalNullable | 21.356 ns | 0.0007 ns | 0.0005 ns |       0 B |
         FromDateTime |  3.638 ns | 0.0033 ns | 0.0029 ns |       0 B |
 FromDateTimeNullable |  3.839 ns | 0.0011 ns | 0.0009 ns |       0 B |
           FromObject |  3.362 ns | 0.0036 ns | 0.0033 ns |       0 B |
           FromString | 94.458 ns | 0.1189 ns | 0.1112 ns |       0 B |
             FromEnum |  4.568 ns | 0.0060 ns | 0.0056 ns |       0 B |
     FromEnumNullable |  4.615 ns | 0.0012 ns | 0.0009 ns |       0 B |
