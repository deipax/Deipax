
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5197 ns | 0.0038 ns | 0.0036 ns |       0 B |
     FromBoolNullable |  2.0311 ns | 0.0049 ns | 0.0043 ns |       0 B |
             FromChar |  1.9938 ns | 0.0045 ns | 0.0038 ns |       0 B |
     FromCharNullable |  2.9156 ns | 0.0050 ns | 0.0046 ns |       0 B |
            FromSByte |  1.0090 ns | 0.0059 ns | 0.0055 ns |       0 B |
    FromSByteNullable |  0.9557 ns | 0.0021 ns | 0.0020 ns |       0 B |
             FromByte |  1.9036 ns | 0.0062 ns | 0.0058 ns |       0 B |
     FromByteNullable |  2.8301 ns | 0.0012 ns | 0.0010 ns |       0 B |
            FromShort |  2.9376 ns | 0.0188 ns | 0.0167 ns |       0 B |
    FromShortNullable |  4.2623 ns | 0.0014 ns | 0.0011 ns |       0 B |
           FromUShort |  2.0074 ns | 0.0059 ns | 0.0055 ns |       0 B |
   FromUShortNullable |  2.9313 ns | 0.0029 ns | 0.0026 ns |       0 B |
              FromInt |  2.8093 ns | 0.0497 ns | 0.0465 ns |       0 B |
      FromIntNullable |  3.8692 ns | 0.0028 ns | 0.0026 ns |       0 B |
             FromUInt |  2.0485 ns | 0.0049 ns | 0.0046 ns |       0 B |
     FromUIntNullable |  2.9737 ns | 0.0034 ns | 0.0032 ns |       0 B |
             FromLong |  2.8656 ns | 0.0096 ns | 0.0085 ns |       0 B |
     FromLongNullable |  4.3405 ns | 0.0055 ns | 0.0048 ns |       0 B |
            FromULong |  2.0134 ns | 0.0094 ns | 0.0083 ns |       0 B |
    FromULongNullable |  3.1047 ns | 0.0042 ns | 0.0035 ns |       0 B |
            FromFloat |  5.6569 ns | 0.0077 ns | 0.0072 ns |       0 B |
    FromFloatNullable |  6.9294 ns | 0.0127 ns | 0.0119 ns |       0 B |
           FromDouble |  5.6215 ns | 0.0089 ns | 0.0083 ns |       0 B |
   FromDoubleNullable |  7.0718 ns | 0.0032 ns | 0.0027 ns |       0 B |
          FromDecimal | 15.7043 ns | 0.0127 ns | 0.0113 ns |       0 B |
  FromDecimalNullable | 26.2369 ns | 0.0168 ns | 0.0157 ns |       0 B |
         FromDateTime |  1.0093 ns | 0.0013 ns | 0.0012 ns |       0 B |
 FromDateTimeNullable |  1.8712 ns | 0.0010 ns | 0.0008 ns |       0 B |
           FromObject | 13.5906 ns | 0.0103 ns | 0.0096 ns |       0 B |
           FromString | 76.2166 ns | 0.0109 ns | 0.0096 ns |       0 B |
             FromEnum |  2.6759 ns | 0.0035 ns | 0.0033 ns |       0 B |
     FromEnumNullable |  3.9372 ns | 0.0051 ns | 0.0048 ns |       0 B |
