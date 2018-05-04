
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  3.6560 ns | 0.0102 ns | 0.0096 ns |       0 B |
     FromBoolNullable |  4.7154 ns | 0.0121 ns | 0.0101 ns |       0 B |
             FromChar |  3.7435 ns | 0.0028 ns | 0.0027 ns |       0 B |
     FromCharNullable |  4.4421 ns | 0.0042 ns | 0.0033 ns |       0 B |
            FromSByte |  4.4233 ns | 0.0129 ns | 0.0120 ns |       0 B |
    FromSByteNullable |  5.1627 ns | 0.0138 ns | 0.0122 ns |       0 B |
             FromByte |  3.7114 ns | 0.0034 ns | 0.0030 ns |       0 B |
     FromByteNullable |  4.7058 ns | 0.0124 ns | 0.0110 ns |       0 B |
            FromShort |  4.3459 ns | 0.0072 ns | 0.0067 ns |       0 B |
    FromShortNullable |  4.8008 ns | 0.0123 ns | 0.0115 ns |       0 B |
           FromUShort |  3.6908 ns | 0.0048 ns | 0.0040 ns |       0 B |
   FromUShortNullable |  4.4336 ns | 0.0099 ns | 0.0088 ns |       0 B |
              FromInt |  4.6963 ns | 0.0028 ns | 0.0026 ns |       0 B |
      FromIntNullable |  4.7981 ns | 0.0090 ns | 0.0084 ns |       0 B |
             FromUInt |  3.6746 ns | 0.0026 ns | 0.0022 ns |       0 B |
     FromUIntNullable |  4.3587 ns | 0.0125 ns | 0.0104 ns |       0 B |
             FromLong |  5.5882 ns | 0.0581 ns | 0.0544 ns |       0 B |
     FromLongNullable |  4.7362 ns | 0.0180 ns | 0.0150 ns |       0 B |
            FromULong |  0.8765 ns | 0.0046 ns | 0.0043 ns |       0 B |
    FromULongNullable |  2.2840 ns | 0.0038 ns | 0.0036 ns |       0 B |
            FromFloat |  7.6120 ns | 0.0082 ns | 0.0077 ns |       0 B |
    FromFloatNullable |  8.5182 ns | 0.0133 ns | 0.0118 ns |       0 B |
           FromDouble |  7.7134 ns | 0.0110 ns | 0.0103 ns |       0 B |
   FromDoubleNullable |  8.2197 ns | 0.0194 ns | 0.0172 ns |       0 B |
          FromDecimal | 15.6434 ns | 0.0110 ns | 0.0103 ns |       0 B |
  FromDecimalNullable | 24.5775 ns | 0.0046 ns | 0.0038 ns |       0 B |
         FromDateTime |  3.6359 ns | 0.0061 ns | 0.0054 ns |       0 B |
 FromDateTimeNullable |  4.1192 ns | 0.0133 ns | 0.0125 ns |       0 B |
           FromObject |  2.6897 ns | 0.0031 ns | 0.0027 ns |       0 B |
           FromString | 74.6740 ns | 0.2202 ns | 0.1839 ns |       0 B |
             FromEnum |  4.8938 ns | 0.0068 ns | 0.0064 ns |       0 B |
     FromEnumNullable |  4.9659 ns | 0.0021 ns | 0.0017 ns |       0 B |
