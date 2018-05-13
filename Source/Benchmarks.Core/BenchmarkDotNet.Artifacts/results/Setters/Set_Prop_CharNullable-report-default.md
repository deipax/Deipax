
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.0074 ns | 0.0016 ns | 0.0014 ns |       0 B |
     FromBoolNullable |  0.9162 ns | 0.0035 ns | 0.0033 ns |       0 B |
             FromChar |  1.0207 ns | 0.0074 ns | 0.0066 ns |       0 B |
     FromCharNullable |  0.9074 ns | 0.0030 ns | 0.0028 ns |       0 B |
            FromSByte |  1.9196 ns | 0.0058 ns | 0.0051 ns |       0 B |
    FromSByteNullable |  2.8768 ns | 0.0025 ns | 0.0021 ns |       0 B |
             FromByte |  0.9972 ns | 0.0048 ns | 0.0043 ns |       0 B |
     FromByteNullable |  1.6864 ns | 0.0028 ns | 0.0025 ns |       0 B |
            FromShort |  1.9236 ns | 0.0028 ns | 0.0026 ns |       0 B |
    FromShortNullable |  3.9716 ns | 0.0234 ns | 0.0207 ns |       0 B |
           FromUShort |  1.0467 ns | 0.0089 ns | 0.0084 ns |       0 B |
   FromUShortNullable |  2.4639 ns | 0.0315 ns | 0.0295 ns |       0 B |
              FromInt |  2.6614 ns | 0.0050 ns | 0.0045 ns |       0 B |
      FromIntNullable |  3.8656 ns | 0.0048 ns | 0.0042 ns |       0 B |
             FromUInt |  1.9985 ns | 0.0049 ns | 0.0041 ns |       0 B |
     FromUIntNullable |  2.9980 ns | 0.0020 ns | 0.0017 ns |       0 B |
             FromLong |  2.6614 ns | 0.0109 ns | 0.0102 ns |       0 B |
     FromLongNullable |  4.3480 ns | 0.0060 ns | 0.0056 ns |       0 B |
            FromULong |  2.5729 ns | 0.0041 ns | 0.0039 ns |       0 B |
    FromULongNullable |  4.3713 ns | 0.0049 ns | 0.0043 ns |       0 B |
            FromFloat |  1.0114 ns | 0.0049 ns | 0.0046 ns |       0 B |
    FromFloatNullable |  1.1054 ns | 0.0026 ns | 0.0024 ns |       0 B |
           FromDouble |  1.0249 ns | 0.0010 ns | 0.0008 ns |       0 B |
   FromDoubleNullable |  1.8057 ns | 0.0052 ns | 0.0044 ns |       0 B |
          FromDecimal |  1.7728 ns | 0.0014 ns | 0.0012 ns |       0 B |
  FromDecimalNullable |  1.5426 ns | 0.0037 ns | 0.0032 ns |       0 B |
         FromDateTime |  1.1790 ns | 0.0042 ns | 0.0035 ns |       0 B |
 FromDateTimeNullable |  1.8967 ns | 0.0006 ns | 0.0005 ns |       0 B |
           FromObject | 13.5892 ns | 0.0418 ns | 0.0391 ns |       0 B |
           FromString |  4.1997 ns | 0.0058 ns | 0.0055 ns |       0 B |
             FromEnum |  2.8583 ns | 0.0064 ns | 0.0060 ns |       0 B |
     FromEnumNullable |  3.9442 ns | 0.0046 ns | 0.0041 ns |       0 B |
