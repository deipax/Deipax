
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  6.7550 ns | 0.0042 ns | 0.0040 ns |       0 B |
     FromBoolNullable |  6.7838 ns | 0.0229 ns | 0.0203 ns |       0 B |
             FromChar |  6.7521 ns | 0.0010 ns | 0.0008 ns |       0 B |
     FromCharNullable |  6.5294 ns | 0.0195 ns | 0.0183 ns |       0 B |
            FromSByte |  6.7561 ns | 0.0064 ns | 0.0060 ns |       0 B |
    FromSByteNullable |  6.5324 ns | 0.0148 ns | 0.0131 ns |       0 B |
             FromByte |  6.7560 ns | 0.0052 ns | 0.0049 ns |       0 B |
     FromByteNullable |  6.5331 ns | 0.0095 ns | 0.0084 ns |       0 B |
            FromShort |  6.7538 ns | 0.0050 ns | 0.0042 ns |       0 B |
    FromShortNullable |  6.5284 ns | 0.0141 ns | 0.0132 ns |       0 B |
           FromUShort |  6.7545 ns | 0.0046 ns | 0.0041 ns |       0 B |
   FromUShortNullable |  6.5305 ns | 0.0144 ns | 0.0135 ns |       0 B |
              FromInt |  0.8552 ns | 0.0021 ns | 0.0018 ns |       0 B |
      FromIntNullable |  1.0064 ns | 0.0049 ns | 0.0046 ns |       0 B |
             FromUInt |  6.7575 ns | 0.0081 ns | 0.0076 ns |       0 B |
     FromUIntNullable |  6.7931 ns | 0.0172 ns | 0.0153 ns |       0 B |
             FromLong |  7.2456 ns | 0.0066 ns | 0.0055 ns |       0 B |
     FromLongNullable |  7.7967 ns | 0.0138 ns | 0.0122 ns |       0 B |
            FromULong |  7.2281 ns | 0.0012 ns | 0.0010 ns |       0 B |
    FromULongNullable |  7.9502 ns | 0.0168 ns | 0.0149 ns |       0 B |
            FromFloat |  8.0704 ns | 0.0072 ns | 0.0068 ns |       0 B |
    FromFloatNullable |  8.3503 ns | 0.0186 ns | 0.0165 ns |       0 B |
           FromDouble |  7.8097 ns | 0.0011 ns | 0.0010 ns |       0 B |
   FromDoubleNullable |  8.9162 ns | 0.0180 ns | 0.0160 ns |       0 B |
          FromDecimal | 19.9666 ns | 0.0100 ns | 0.0094 ns |       0 B |
  FromDecimalNullable | 26.7814 ns | 0.0546 ns | 0.0484 ns |       0 B |
         FromDateTime |  6.8412 ns | 0.0111 ns | 0.0104 ns |       0 B |
 FromDateTimeNullable |  7.2889 ns | 0.0124 ns | 0.0104 ns |       0 B |
           FromObject | 13.3480 ns | 0.0101 ns | 0.0089 ns |       0 B |
           FromString | 76.7079 ns | 0.1620 ns | 0.1516 ns |       0 B |
             FromEnum |  6.7573 ns | 0.0094 ns | 0.0088 ns |       0 B |
     FromEnumNullable |  6.5106 ns | 0.0012 ns | 0.0011 ns |       0 B |
