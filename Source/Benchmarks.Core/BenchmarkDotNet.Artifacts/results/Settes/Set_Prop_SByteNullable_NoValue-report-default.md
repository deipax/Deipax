
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  6.745 ns | 0.0015 ns | 0.0012 ns |       0 B |
     FromBoolNullable |  6.546 ns | 0.0189 ns | 0.0168 ns |       0 B |
             FromChar |  6.767 ns | 0.0020 ns | 0.0017 ns |       0 B |
     FromCharNullable |  6.791 ns | 0.0116 ns | 0.0103 ns |       0 B |
            FromSByte |  1.149 ns | 0.0019 ns | 0.0018 ns |       0 B |
    FromSByteNullable |  1.034 ns | 0.0036 ns | 0.0033 ns |       0 B |
             FromByte |  6.776 ns | 0.0093 ns | 0.0087 ns |       0 B |
     FromByteNullable |  6.788 ns | 0.0141 ns | 0.0132 ns |       0 B |
            FromShort |  7.379 ns | 0.0049 ns | 0.0043 ns |       0 B |
    FromShortNullable |  6.532 ns | 0.0319 ns | 0.0266 ns |       0 B |
           FromUShort |  6.767 ns | 0.0014 ns | 0.0012 ns |       0 B |
   FromUShortNullable |  6.797 ns | 0.0133 ns | 0.0125 ns |       0 B |
              FromInt |  7.528 ns | 0.0092 ns | 0.0086 ns |       0 B |
      FromIntNullable |  6.545 ns | 0.0208 ns | 0.0184 ns |       0 B |
             FromUInt |  6.768 ns | 0.0018 ns | 0.0015 ns |       0 B |
     FromUIntNullable |  6.803 ns | 0.0206 ns | 0.0183 ns |       0 B |
             FromLong |  7.528 ns | 0.0098 ns | 0.0092 ns |       0 B |
     FromLongNullable |  7.030 ns | 0.0156 ns | 0.0146 ns |       0 B |
            FromULong |  6.771 ns | 0.0057 ns | 0.0051 ns |       0 B |
    FromULongNullable |  7.297 ns | 0.0137 ns | 0.0128 ns |       0 B |
            FromFloat |  9.153 ns | 0.0087 ns | 0.0081 ns |       0 B |
    FromFloatNullable |  6.541 ns | 0.0109 ns | 0.0085 ns |       0 B |
           FromDouble |  8.884 ns | 0.0113 ns | 0.0106 ns |       0 B |
   FromDoubleNullable |  7.041 ns | 0.0140 ns | 0.0124 ns |       0 B |
          FromDecimal | 20.829 ns | 0.0227 ns | 0.0212 ns |       0 B |
  FromDecimalNullable |  7.281 ns | 0.0165 ns | 0.0137 ns |       0 B |
         FromDateTime |  6.827 ns | 0.0065 ns | 0.0058 ns |       0 B |
 FromDateTimeNullable |  7.298 ns | 0.0153 ns | 0.0128 ns |       0 B |
           FromObject |  7.649 ns | 0.0070 ns | 0.0062 ns |       0 B |
           FromString |  7.043 ns | 0.0156 ns | 0.0146 ns |       0 B |
             FromEnum |  7.515 ns | 0.0080 ns | 0.0071 ns |       0 B |
     FromEnumNullable |  6.528 ns | 0.0023 ns | 0.0018 ns |       0 B |
