
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool |        NA |        NA |        NA |    N/A |       N/A |
     FromBoolNullable |  7.746 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
             FromChar | 14.073 ns | 0.0256 ns | 0.0240 ns |      - |       0 B |
     FromCharNullable |  7.742 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
            FromSByte | 15.857 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
    FromSByteNullable |  8.670 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
             FromByte | 15.349 ns | 0.0097 ns | 0.0081 ns |      - |       0 B |
     FromByteNullable |  7.741 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
            FromShort | 15.863 ns | 0.0154 ns | 0.0120 ns |      - |       0 B |
    FromShortNullable |  7.745 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
           FromUShort | 15.364 ns | 0.0282 ns | 0.0250 ns |      - |       0 B |
   FromUShortNullable |  7.750 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
              FromInt | 16.626 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
      FromIntNullable |  7.746 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
             FromUInt | 15.990 ns | 0.1003 ns | 0.0889 ns |      - |       0 B |
     FromUIntNullable |  7.800 ns | 0.0040 ns | 0.0038 ns |      - |       0 B |
             FromLong | 16.641 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
     FromLongNullable |  7.738 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
            FromULong | 16.577 ns | 0.0142 ns | 0.0119 ns |      - |       0 B |
    FromULongNullable |  7.730 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
            FromFloat |        NA |        NA |        NA |    N/A |       N/A |
    FromFloatNullable |  7.739 ns | 0.0083 ns | 0.0077 ns |      - |       0 B |
           FromDouble |        NA |        NA |        NA |    N/A |       N/A |
   FromDoubleNullable |  7.735 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
          FromDecimal |        NA |        NA |        NA |    N/A |       N/A |
  FromDecimalNullable |  7.746 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.738 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
           FromObject |  7.769 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
           FromString |  7.740 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
             FromEnum | 46.790 ns | 0.0366 ns | 0.0324 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_CharNullable_NoValue.FromBool: DefaultJob
  Set_Prop_CharNullable_NoValue.FromFloat: DefaultJob
  Set_Prop_CharNullable_NoValue.FromDouble: DefaultJob
  Set_Prop_CharNullable_NoValue.FromDecimal: DefaultJob
  Set_Prop_CharNullable_NoValue.FromDateTime: DefaultJob
