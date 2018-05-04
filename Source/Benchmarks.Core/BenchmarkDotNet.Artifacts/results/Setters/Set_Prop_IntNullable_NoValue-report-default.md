
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  6.7524 ns | 0.0005 ns | 0.0005 ns |       0 B |
     FromBoolNullable |  6.5217 ns | 0.0139 ns | 0.0124 ns |       0 B |
             FromChar |  6.7558 ns | 0.0065 ns | 0.0060 ns |       0 B |
     FromCharNullable |  6.5129 ns | 0.0020 ns | 0.0015 ns |       0 B |
            FromSByte |  6.7550 ns | 0.0053 ns | 0.0049 ns |       0 B |
    FromSByteNullable |  6.5149 ns | 0.0018 ns | 0.0016 ns |       0 B |
             FromByte |  6.7540 ns | 0.0025 ns | 0.0021 ns |       0 B |
     FromByteNullable |  6.5139 ns | 0.0027 ns | 0.0024 ns |       0 B |
            FromShort |  6.7527 ns | 0.0005 ns | 0.0004 ns |       0 B |
    FromShortNullable |  6.5112 ns | 0.0098 ns | 0.0087 ns |       0 B |
           FromUShort |  6.7567 ns | 0.0055 ns | 0.0051 ns |       0 B |
   FromUShortNullable |  6.5171 ns | 0.0073 ns | 0.0068 ns |       0 B |
              FromInt |  0.9468 ns | 0.0014 ns | 0.0013 ns |       0 B |
      FromIntNullable |  1.2932 ns | 0.0045 ns | 0.0042 ns |       0 B |
             FromUInt |  6.7546 ns | 0.0008 ns | 0.0007 ns |       0 B |
     FromUIntNullable |  6.7708 ns | 0.0009 ns | 0.0009 ns |       0 B |
             FromLong |  7.2661 ns | 0.0008 ns | 0.0007 ns |       0 B |
     FromLongNullable |  7.0086 ns | 0.0007 ns | 0.0006 ns |       0 B |
            FromULong |  7.2398 ns | 0.0073 ns | 0.0068 ns |       0 B |
    FromULongNullable |  7.0091 ns | 0.0025 ns | 0.0022 ns |       0 B |
            FromFloat |  8.0683 ns | 0.0016 ns | 0.0013 ns |       0 B |
    FromFloatNullable |  6.5048 ns | 0.0136 ns | 0.0127 ns |       0 B |
           FromDouble |  8.0357 ns | 0.0105 ns | 0.0098 ns |       0 B |
   FromDoubleNullable |  7.0087 ns | 0.0028 ns | 0.0025 ns |       0 B |
          FromDecimal | 20.0452 ns | 0.0209 ns | 0.0196 ns |       0 B |
  FromDecimalNullable |  7.2867 ns | 0.0094 ns | 0.0088 ns |       0 B |
         FromDateTime |  6.8321 ns | 0.0147 ns | 0.0138 ns |       0 B |
 FromDateTimeNullable |  7.2629 ns | 0.0010 ns | 0.0009 ns |       0 B |
           FromObject |  7.6129 ns | 0.0558 ns | 0.0522 ns |       0 B |
           FromString |  7.0081 ns | 0.0009 ns | 0.0007 ns |       0 B |
             FromEnum |  6.7536 ns | 0.0015 ns | 0.0012 ns |       0 B |
     FromEnumNullable |  6.5129 ns | 0.0012 ns | 0.0009 ns |       0 B |
