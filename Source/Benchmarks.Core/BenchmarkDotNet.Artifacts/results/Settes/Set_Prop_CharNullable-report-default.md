
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool |        NA |        NA |        NA |    N/A |       N/A |
     FromBoolNullable |  7.723 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
             FromChar | 14.130 ns | 0.0348 ns | 0.0309 ns |      - |       0 B |
     FromCharNullable | 14.084 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
            FromSByte | 15.850 ns | 0.0136 ns | 0.0121 ns |      - |       0 B |
    FromSByteNullable | 15.841 ns | 0.0310 ns | 0.0275 ns |      - |       0 B |
             FromByte | 15.537 ns | 0.1578 ns | 0.1476 ns |      - |       0 B |
     FromByteNullable | 15.337 ns | 0.0391 ns | 0.0365 ns |      - |       0 B |
            FromShort | 15.859 ns | 0.0215 ns | 0.0180 ns |      - |       0 B |
    FromShortNullable | 15.838 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
           FromUShort | 15.508 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
   FromUShortNullable | 15.318 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
              FromInt | 16.620 ns | 0.0234 ns | 0.0207 ns |      - |       0 B |
      FromIntNullable | 16.602 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
             FromUInt | 15.927 ns | 0.0876 ns | 0.0777 ns |      - |       0 B |
     FromUIntNullable | 15.832 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
             FromLong | 16.619 ns | 0.0187 ns | 0.0175 ns |      - |       0 B |
     FromLongNullable | 16.602 ns | 0.0191 ns | 0.0169 ns |      - |       0 B |
            FromULong | 16.541 ns | 0.0339 ns | 0.0301 ns |      - |       0 B |
    FromULongNullable | 16.339 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
            FromFloat |        NA |        NA |        NA |    N/A |       N/A |
    FromFloatNullable |  7.724 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
           FromDouble |        NA |        NA |        NA |    N/A |       N/A |
   FromDoubleNullable |  7.716 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
          FromDecimal |        NA |        NA |        NA |    N/A |       N/A |
  FromDecimalNullable |  7.724 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.724 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
           FromObject | 14.064 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
           FromString | 15.079 ns | 0.0437 ns | 0.0341 ns |      - |       0 B |
             FromEnum | 47.038 ns | 0.0398 ns | 0.0332 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_CharNullable.FromBool: DefaultJob
  Set_Prop_CharNullable.FromFloat: DefaultJob
  Set_Prop_CharNullable.FromDouble: DefaultJob
  Set_Prop_CharNullable.FromDecimal: DefaultJob
  Set_Prop_CharNullable.FromDateTime: DefaultJob
