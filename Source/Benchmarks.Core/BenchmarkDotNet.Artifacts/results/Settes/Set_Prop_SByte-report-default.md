
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 12.816 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
     FromBoolNullable | 12.812 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
             FromChar | 14.085 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
     FromCharNullable | 14.132 ns | 0.0092 ns | 0.0076 ns |      - |       0 B |
            FromSByte |  3.344 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
    FromSByteNullable |  3.344 ns | 0.0021 ns | 0.0015 ns |      - |       0 B |
             FromByte | 13.315 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
     FromByteNullable | 13.326 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
            FromShort | 14.076 ns | 0.0070 ns | 0.0066 ns |      - |       0 B |
    FromShortNullable | 14.104 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
           FromUShort | 13.308 ns | 0.0073 ns | 0.0057 ns |      - |       0 B |
   FromUShortNullable | 13.316 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
              FromInt | 13.834 ns | 0.0205 ns | 0.0182 ns |      - |       0 B |
      FromIntNullable | 13.866 ns | 0.0156 ns | 0.0130 ns |      - |       0 B |
             FromUInt | 13.330 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
     FromUIntNullable | 13.313 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
             FromLong | 14.145 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
     FromLongNullable | 14.085 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
            FromULong | 13.335 ns | 0.0094 ns | 0.0073 ns |      - |       0 B |
    FromULongNullable | 13.328 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
            FromFloat | 16.451 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
    FromFloatNullable | 16.419 ns | 0.0391 ns | 0.0327 ns |      - |       0 B |
           FromDouble | 16.514 ns | 0.0325 ns | 0.0288 ns |      - |       0 B |
   FromDoubleNullable | 16.241 ns | 0.1324 ns | 0.1106 ns |      - |       0 B |
          FromDecimal | 23.634 ns | 0.2384 ns | 0.1991 ns |      - |       0 B |
  FromDecimalNullable | 24.133 ns | 0.4681 ns | 0.4378 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  6.948 ns | 0.0569 ns | 0.0532 ns |      - |       0 B |
           FromObject |  3.374 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
           FromString | 88.615 ns | 0.7777 ns | 0.6072 ns |      - |       0 B |
             FromEnum | 44.491 ns | 0.6815 ns | 0.6042 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_SByte.FromDateTime: DefaultJob
