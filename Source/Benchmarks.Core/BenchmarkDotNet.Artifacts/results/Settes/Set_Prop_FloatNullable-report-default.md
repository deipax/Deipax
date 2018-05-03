
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  6.7581 ns | 0.0077 ns | 0.0072 ns |       0 B |
     FromBoolNullable |  6.7659 ns | 0.0057 ns | 0.0047 ns |       0 B |
             FromChar |  6.7528 ns | 0.0012 ns | 0.0010 ns |       0 B |
     FromCharNullable |  6.5120 ns | 0.0013 ns | 0.0011 ns |       0 B |
            FromSByte |  6.7543 ns | 0.0013 ns | 0.0011 ns |       0 B |
    FromSByteNullable |  6.7684 ns | 0.0020 ns | 0.0016 ns |       0 B |
             FromByte |  6.7575 ns | 0.0057 ns | 0.0051 ns |       0 B |
     FromByteNullable |  6.7689 ns | 0.0012 ns | 0.0011 ns |       0 B |
            FromShort |  6.7531 ns | 0.0008 ns | 0.0006 ns |       0 B |
    FromShortNullable |  6.7717 ns | 0.0048 ns | 0.0045 ns |       0 B |
           FromUShort |  6.7579 ns | 0.0100 ns | 0.0094 ns |       0 B |
   FromUShortNullable |  6.7711 ns | 0.0058 ns | 0.0054 ns |       0 B |
              FromInt |  6.7595 ns | 0.0107 ns | 0.0094 ns |       0 B |
      FromIntNullable |  6.7785 ns | 0.0238 ns | 0.0211 ns |       0 B |
             FromUInt |  6.6709 ns | 0.0011 ns | 0.0010 ns |       0 B |
     FromUIntNullable |  6.7667 ns | 0.0053 ns | 0.0049 ns |       0 B |
             FromLong |  6.7516 ns | 0.0008 ns | 0.0007 ns |       0 B |
     FromLongNullable |  7.5326 ns | 0.0136 ns | 0.0128 ns |       0 B |
            FromULong |  6.7527 ns | 0.0008 ns | 0.0007 ns |       0 B |
    FromULongNullable |  7.7080 ns | 0.0071 ns | 0.0063 ns |       0 B |
            FromFloat |  0.9242 ns | 0.0016 ns | 0.0015 ns |       0 B |
    FromFloatNullable |  1.0095 ns | 0.0055 ns | 0.0049 ns |       0 B |
           FromDouble |  6.5455 ns | 0.0049 ns | 0.0046 ns |       0 B |
   FromDoubleNullable |  7.2772 ns | 0.0178 ns | 0.0167 ns |       0 B |
          FromDecimal | 13.4288 ns | 0.0144 ns | 0.0135 ns |       0 B |
  FromDecimalNullable | 26.0626 ns | 0.0448 ns | 0.0419 ns |       0 B |
         FromDateTime |  6.8602 ns | 0.0046 ns | 0.0043 ns |       0 B |
 FromDateTimeNullable |  7.2722 ns | 0.0143 ns | 0.0134 ns |       0 B |
           FromObject | 13.4152 ns | 0.0172 ns | 0.0161 ns |       0 B |
           FromString | 96.9576 ns | 0.1312 ns | 0.1227 ns |       0 B |
             FromEnum |  6.7614 ns | 0.0027 ns | 0.0025 ns |       0 B |
     FromEnumNullable |  6.7685 ns | 0.0013 ns | 0.0011 ns |       0 B |
