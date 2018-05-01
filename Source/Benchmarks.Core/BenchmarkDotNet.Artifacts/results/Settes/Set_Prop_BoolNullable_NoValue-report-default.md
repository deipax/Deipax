
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.256 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
     FromBoolNullable |  7.746 ns | 0.0175 ns | 0.0156 ns |      - |       0 B |
             FromChar |        NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |  7.739 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
            FromSByte | 15.116 ns | 0.0313 ns | 0.0293 ns |      - |       0 B |
    FromSByteNullable |  7.796 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
             FromByte | 15.352 ns | 0.0153 ns | 0.0135 ns |      - |       0 B |
     FromByteNullable |  7.741 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
            FromShort | 15.106 ns | 0.0229 ns | 0.0203 ns |      - |       0 B |
    FromShortNullable |  7.730 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
           FromUShort | 15.106 ns | 0.0234 ns | 0.0218 ns |      - |       0 B |
   FromUShortNullable |  7.750 ns | 0.0095 ns | 0.0085 ns |      - |       0 B |
              FromInt | 15.108 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
      FromIntNullable |  7.735 ns | 0.0029 ns | 0.0022 ns |      - |       0 B |
             FromUInt | 15.110 ns | 0.0564 ns | 0.0528 ns |      - |       0 B |
     FromUIntNullable |  7.742 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
             FromLong | 15.127 ns | 0.0388 ns | 0.0363 ns |      - |       0 B |
     FromLongNullable |  7.732 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
            FromULong | 15.168 ns | 0.0537 ns | 0.0503 ns |      - |       0 B |
    FromULongNullable |  7.736 ns | 0.0057 ns | 0.0053 ns |      - |       0 B |
            FromFloat | 15.126 ns | 0.0381 ns | 0.0297 ns |      - |       0 B |
    FromFloatNullable |  7.738 ns | 0.0088 ns | 0.0073 ns |      - |       0 B |
           FromDouble | 15.393 ns | 0.0787 ns | 0.0736 ns |      - |       0 B |
   FromDoubleNullable |  8.110 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
          FromDecimal | 24.569 ns | 0.0329 ns | 0.0275 ns |      - |       0 B |
  FromDecimalNullable |  7.740 ns | 0.0073 ns | 0.0064 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.758 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
           FromObject |  7.740 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
           FromString |  7.787 ns | 0.0361 ns | 0.0302 ns |      - |       0 B |
             FromEnum | 45.119 ns | 0.0746 ns | 0.0697 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_BoolNullable_NoValue.FromChar: DefaultJob
  Set_Prop_BoolNullable_NoValue.FromDateTime: DefaultJob
