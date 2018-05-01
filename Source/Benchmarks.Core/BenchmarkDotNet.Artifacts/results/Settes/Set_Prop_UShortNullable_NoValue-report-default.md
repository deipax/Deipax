
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.359 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
     FromBoolNullable |  7.730 ns | 0.0143 ns | 0.0126 ns |      - |       0 B |
             FromChar | 16.861 ns | 0.0796 ns | 0.0706 ns |      - |       0 B |
     FromCharNullable |  7.696 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
            FromSByte | 15.859 ns | 0.0084 ns | 0.0078 ns |      - |       0 B |
    FromSByteNullable |  7.724 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
             FromByte | 15.319 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
     FromByteNullable |  7.721 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
            FromShort | 15.838 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
    FromShortNullable |  7.720 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
           FromUShort | 13.973 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
   FromUShortNullable |  7.700 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
              FromInt | 16.620 ns | 0.0309 ns | 0.0274 ns |      - |       0 B |
      FromIntNullable |  7.730 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
             FromUInt | 15.827 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
     FromUIntNullable |  8.012 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
             FromLong | 16.924 ns | 0.0094 ns | 0.0074 ns |      - |       0 B |
     FromLongNullable |  7.709 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
            FromULong | 16.602 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
    FromULongNullable |  7.721 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
            FromFloat | 19.558 ns | 0.0308 ns | 0.0289 ns |      - |       0 B |
    FromFloatNullable |  7.724 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
           FromDouble | 19.277 ns | 0.0086 ns | 0.0077 ns |      - |       0 B |
   FromDoubleNullable |  7.799 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
          FromDecimal | 26.904 ns | 0.0165 ns | 0.0146 ns |      - |       0 B |
  FromDecimalNullable |  7.726 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.718 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
           FromObject |  7.680 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
           FromString |  7.731 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
             FromEnum | 47.607 ns | 0.0234 ns | 0.0207 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_UShortNullable_NoValue.FromDateTime: DefaultJob
