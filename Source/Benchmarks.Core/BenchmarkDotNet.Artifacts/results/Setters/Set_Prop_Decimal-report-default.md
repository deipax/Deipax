
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |   5.480 ns | 0.0015 ns | 0.0014 ns |       0 B |
     FromBoolNullable |   6.133 ns | 0.0065 ns | 0.0060 ns |       0 B |
             FromChar |   4.942 ns | 0.0036 ns | 0.0034 ns |       0 B |
     FromCharNullable |   4.827 ns | 0.0106 ns | 0.0099 ns |       0 B |
            FromSByte |   5.195 ns | 0.0089 ns | 0.0083 ns |       0 B |
    FromSByteNullable |   5.886 ns | 0.0069 ns | 0.0064 ns |       0 B |
             FromByte |   5.637 ns | 0.0031 ns | 0.0029 ns |       0 B |
     FromByteNullable |   6.296 ns | 0.0067 ns | 0.0063 ns |       0 B |
            FromShort |   5.281 ns | 0.0091 ns | 0.0076 ns |       0 B |
    FromShortNullable |   5.619 ns | 0.0072 ns | 0.0067 ns |       0 B |
           FromUShort |   5.270 ns | 0.0093 ns | 0.0082 ns |       0 B |
   FromUShortNullable |   5.629 ns | 0.0011 ns | 0.0010 ns |       0 B |
              FromInt |   4.991 ns | 0.0060 ns | 0.0056 ns |       0 B |
      FromIntNullable |   5.610 ns | 0.0015 ns | 0.0012 ns |       0 B |
             FromUInt |   5.456 ns | 0.0085 ns | 0.0075 ns |       0 B |
     FromUIntNullable |   6.063 ns | 0.0092 ns | 0.0086 ns |       0 B |
             FromLong |   5.126 ns | 0.0053 ns | 0.0050 ns |       0 B |
     FromLongNullable |   6.392 ns | 0.0210 ns | 0.0176 ns |       0 B |
            FromULong |   5.134 ns | 0.0044 ns | 0.0039 ns |       0 B |
    FromULongNullable |   5.849 ns | 0.0047 ns | 0.0039 ns |       0 B |
            FromFloat |  26.246 ns | 0.0249 ns | 0.0208 ns |       0 B |
    FromFloatNullable |  26.846 ns | 0.0946 ns | 0.0885 ns |       0 B |
           FromDouble |  62.756 ns | 0.0497 ns | 0.0465 ns |       0 B |
   FromDoubleNullable |  64.034 ns | 0.0305 ns | 0.0271 ns |       0 B |
          FromDecimal |   1.521 ns | 0.0033 ns | 0.0030 ns |       0 B |
  FromDecimalNullable |   4.483 ns | 0.0003 ns | 0.0003 ns |       0 B |
         FromDateTime |   4.901 ns | 0.0088 ns | 0.0082 ns |       0 B |
 FromDateTimeNullable |   4.988 ns | 0.0025 ns | 0.0022 ns |       0 B |
           FromObject |   3.330 ns | 0.0243 ns | 0.0228 ns |       0 B |
           FromString | 109.822 ns | 0.0381 ns | 0.0318 ns |       0 B |
             FromEnum |   5.517 ns | 0.0050 ns | 0.0047 ns |       0 B |
     FromEnumNullable |   6.057 ns | 0.0047 ns | 0.0042 ns |       0 B |
