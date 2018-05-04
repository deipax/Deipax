
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  6.6309 ns | 0.0107 ns | 0.0095 ns |       0 B |
     FromBoolNullable |  6.5156 ns | 0.0083 ns | 0.0074 ns |       0 B |
             FromChar |  6.7536 ns | 0.0035 ns | 0.0029 ns |       0 B |
     FromCharNullable |  6.5150 ns | 0.0035 ns | 0.0031 ns |       0 B |
            FromSByte |  6.7548 ns | 0.0009 ns | 0.0007 ns |       0 B |
    FromSByteNullable |  6.7727 ns | 0.0039 ns | 0.0035 ns |       0 B |
             FromByte |  6.7544 ns | 0.0010 ns | 0.0009 ns |       0 B |
     FromByteNullable |  6.5144 ns | 0.0034 ns | 0.0030 ns |       0 B |
            FromShort |  6.7564 ns | 0.0043 ns | 0.0038 ns |       0 B |
    FromShortNullable |  6.7703 ns | 0.0048 ns | 0.0040 ns |       0 B |
           FromUShort |  6.7569 ns | 0.0061 ns | 0.0057 ns |       0 B |
   FromUShortNullable |  6.5314 ns | 0.0193 ns | 0.0171 ns |       0 B |
              FromInt |  6.7546 ns | 0.0007 ns | 0.0006 ns |       0 B |
      FromIntNullable |  6.7686 ns | 0.0140 ns | 0.0131 ns |       0 B |
             FromUInt |  0.8632 ns | 0.0034 ns | 0.0032 ns |       0 B |
     FromUIntNullable |  1.0211 ns | 0.0011 ns | 0.0010 ns |       0 B |
             FromLong |  7.5028 ns | 0.0096 ns | 0.0090 ns |       0 B |
     FromLongNullable |  7.0104 ns | 0.0078 ns | 0.0069 ns |       0 B |
            FromULong |  6.7616 ns | 0.0082 ns | 0.0077 ns |       0 B |
    FromULongNullable |  7.2637 ns | 0.0050 ns | 0.0047 ns |       0 B |
            FromFloat |  8.0659 ns | 0.0017 ns | 0.0015 ns |       0 B |
    FromFloatNullable |  6.5396 ns | 0.0221 ns | 0.0196 ns |       0 B |
           FromDouble |  8.0002 ns | 0.0012 ns | 0.0010 ns |       0 B |
   FromDoubleNullable |  7.0371 ns | 0.0135 ns | 0.0113 ns |       0 B |
          FromDecimal | 19.7257 ns | 0.0043 ns | 0.0036 ns |       0 B |
  FromDecimalNullable |  7.2998 ns | 0.0203 ns | 0.0180 ns |       0 B |
         FromDateTime |  6.8431 ns | 0.0079 ns | 0.0074 ns |       0 B |
 FromDateTimeNullable |  7.2843 ns | 0.0165 ns | 0.0147 ns |       0 B |
           FromObject |  7.7337 ns | 0.0264 ns | 0.0247 ns |       0 B |
           FromString |  7.0309 ns | 0.0168 ns | 0.0149 ns |       0 B |
             FromEnum |  6.7529 ns | 0.0019 ns | 0.0014 ns |       0 B |
     FromEnumNullable |  6.7745 ns | 0.0079 ns | 0.0074 ns |       0 B |
