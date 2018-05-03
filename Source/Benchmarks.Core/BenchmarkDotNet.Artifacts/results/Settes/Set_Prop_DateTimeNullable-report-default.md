
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |   5.104 ns | 0.0192 ns | 0.0170 ns |       0 B |
     FromBoolNullable |   5.029 ns | 0.0069 ns | 0.0065 ns |       0 B |
             FromChar |   5.285 ns | 0.0105 ns | 0.0098 ns |       0 B |
     FromCharNullable |   5.086 ns | 0.0104 ns | 0.0097 ns |       0 B |
            FromSByte |   5.205 ns | 0.0060 ns | 0.0057 ns |       0 B |
    FromSByteNullable |   4.906 ns | 0.0039 ns | 0.0032 ns |       0 B |
             FromByte |   5.233 ns | 0.0093 ns | 0.0082 ns |       0 B |
     FromByteNullable |   5.689 ns | 0.0143 ns | 0.0134 ns |       0 B |
            FromShort |   5.207 ns | 0.0073 ns | 0.0069 ns |       0 B |
    FromShortNullable |   5.109 ns | 0.0044 ns | 0.0034 ns |       0 B |
           FromUShort |   5.209 ns | 0.0056 ns | 0.0047 ns |       0 B |
   FromUShortNullable |   5.066 ns | 0.0109 ns | 0.0102 ns |       0 B |
              FromInt |   4.907 ns | 0.0042 ns | 0.0037 ns |       0 B |
      FromIntNullable |   6.003 ns | 0.1234 ns | 0.1154 ns |       0 B |
             FromUInt |   5.673 ns | 0.0046 ns | 0.0041 ns |       0 B |
     FromUIntNullable |   5.085 ns | 0.0165 ns | 0.0154 ns |       0 B |
             FromLong |   4.920 ns | 0.0053 ns | 0.0050 ns |       0 B |
     FromLongNullable |   5.501 ns | 0.0038 ns | 0.0034 ns |       0 B |
            FromULong |   4.901 ns | 0.0035 ns | 0.0031 ns |       0 B |
    FromULongNullable |   6.057 ns | 0.0149 ns | 0.0125 ns |       0 B |
            FromFloat |   5.099 ns | 0.0059 ns | 0.0052 ns |       0 B |
    FromFloatNullable |   5.086 ns | 0.0169 ns | 0.0158 ns |       0 B |
           FromDouble |   4.885 ns | 0.0026 ns | 0.0021 ns |       0 B |
   FromDoubleNullable |   5.176 ns | 0.0052 ns | 0.0049 ns |       0 B |
          FromDecimal |   5.179 ns | 0.0035 ns | 0.0029 ns |       0 B |
  FromDecimalNullable |   5.440 ns | 0.0029 ns | 0.0025 ns |       0 B |
         FromDateTime |   6.804 ns | 0.0030 ns | 0.0022 ns |       0 B |
 FromDateTimeNullable |   1.641 ns | 0.0026 ns | 0.0023 ns |       0 B |
           FromObject |  13.494 ns | 0.0076 ns | 0.0059 ns |       0 B |
           FromString | 553.440 ns | 0.2799 ns | 0.2338 ns |       0 B |
             FromEnum |   5.827 ns | 0.0155 ns | 0.0129 ns |       0 B |
     FromEnumNullable |   5.655 ns | 0.0041 ns | 0.0038 ns |       0 B |
