
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  0.8001 ns | 0.0174 ns | 0.0163 ns |       0 B |
     FromBoolNullable |  1.6301 ns | 0.0854 ns | 0.0914 ns |       0 B |
             FromChar |  3.7045 ns | 0.0096 ns | 0.0080 ns |       0 B |
     FromCharNullable |  3.6970 ns | 0.0143 ns | 0.0119 ns |       0 B |
            FromSByte |  3.9904 ns | 0.0555 ns | 0.0519 ns |       0 B |
    FromSByteNullable |  4.7696 ns | 0.0488 ns | 0.0432 ns |       0 B |
             FromByte |  4.0686 ns | 0.0198 ns | 0.0185 ns |       0 B |
     FromByteNullable |  4.8230 ns | 0.0346 ns | 0.0307 ns |       0 B |
            FromShort |  4.2769 ns | 0.0508 ns | 0.0424 ns |       0 B |
    FromShortNullable |  4.7321 ns | 0.0786 ns | 0.0697 ns |       0 B |
           FromUShort |  4.6589 ns | 0.0447 ns | 0.0418 ns |       0 B |
   FromUShortNullable |  4.5609 ns | 0.0562 ns | 0.0526 ns |       0 B |
              FromInt |  3.9373 ns | 0.0189 ns | 0.0177 ns |       0 B |
      FromIntNullable |  4.5760 ns | 0.0591 ns | 0.0523 ns |       0 B |
             FromUInt |  4.0535 ns | 0.0264 ns | 0.0220 ns |       0 B |
     FromUIntNullable |  4.5465 ns | 0.0591 ns | 0.0553 ns |       0 B |
             FromLong |  4.7902 ns | 0.0482 ns | 0.0427 ns |       0 B |
     FromLongNullable |  4.9711 ns | 0.0986 ns | 0.0874 ns |       0 B |
            FromULong |  3.8482 ns | 0.0196 ns | 0.0173 ns |       0 B |
    FromULongNullable |  5.1796 ns | 0.1336 ns | 0.1185 ns |       0 B |
            FromFloat |  4.4606 ns | 0.0425 ns | 0.0377 ns |       0 B |
    FromFloatNullable |  4.9935 ns | 0.0093 ns | 0.0087 ns |       0 B |
           FromDouble |  4.1529 ns | 0.0069 ns | 0.0058 ns |       0 B |
   FromDoubleNullable |  4.8901 ns | 0.0012 ns | 0.0009 ns |       0 B |
          FromDecimal | 13.3663 ns | 0.0111 ns | 0.0099 ns |       0 B |
  FromDecimalNullable | 14.0546 ns | 0.0044 ns | 0.0037 ns |       0 B |
         FromDateTime |  4.4911 ns | 0.0040 ns | 0.0038 ns |       0 B |
 FromDateTimeNullable |  3.9700 ns | 0.0080 ns | 0.0075 ns |       0 B |
           FromObject |  2.7263 ns | 0.0025 ns | 0.0023 ns |       0 B |
           FromString | 10.7727 ns | 0.0032 ns | 0.0027 ns |       0 B |
             FromEnum |  4.1278 ns | 0.0034 ns | 0.0031 ns |       0 B |
     FromEnumNullable |  4.6567 ns | 0.0087 ns | 0.0081 ns |       0 B |
