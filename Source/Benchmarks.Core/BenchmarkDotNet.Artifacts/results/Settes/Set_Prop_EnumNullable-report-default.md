
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 27.177 ns | 0.0089 ns | 0.0069 ns | 0.0057 |      24 B |
     FromBoolNullable | 28.154 ns | 0.0491 ns | 0.0459 ns | 0.0057 |      24 B |
             FromChar | 27.379 ns | 0.0470 ns | 0.0416 ns | 0.0057 |      24 B |
     FromCharNullable | 27.306 ns | 0.0066 ns | 0.0055 ns | 0.0057 |      24 B |
            FromSByte | 26.942 ns | 0.0523 ns | 0.0490 ns | 0.0057 |      24 B |
    FromSByteNullable | 27.920 ns | 0.0127 ns | 0.0106 ns | 0.0057 |      24 B |
             FromByte | 26.984 ns | 0.0924 ns | 0.0864 ns | 0.0057 |      24 B |
     FromByteNullable | 27.929 ns | 0.0328 ns | 0.0307 ns | 0.0057 |      24 B |
            FromShort | 27.337 ns | 0.0492 ns | 0.0460 ns | 0.0057 |      24 B |
    FromShortNullable | 27.953 ns | 0.0065 ns | 0.0057 ns | 0.0057 |      24 B |
           FromUShort | 27.454 ns | 0.0277 ns | 0.0259 ns | 0.0057 |      24 B |
   FromUShortNullable | 27.193 ns | 0.0494 ns | 0.0462 ns | 0.0057 |      24 B |
              FromInt | 27.321 ns | 0.0224 ns | 0.0199 ns | 0.0057 |      24 B |
      FromIntNullable | 28.527 ns | 0.0912 ns | 0.0853 ns | 0.0057 |      24 B |
             FromUInt | 28.645 ns | 0.0262 ns | 0.0232 ns | 0.0057 |      24 B |
     FromUIntNullable | 28.097 ns | 0.0679 ns | 0.0635 ns | 0.0057 |      24 B |
             FromLong | 29.073 ns | 0.0077 ns | 0.0060 ns | 0.0057 |      24 B |
     FromLongNullable | 28.933 ns | 0.0243 ns | 0.0216 ns | 0.0057 |      24 B |
            FromULong | 28.451 ns | 0.0714 ns | 0.0633 ns | 0.0057 |      24 B |
    FromULongNullable | 28.589 ns | 0.0293 ns | 0.0274 ns | 0.0057 |      24 B |
            FromFloat | 29.015 ns | 0.0538 ns | 0.0449 ns | 0.0057 |      24 B |
    FromFloatNullable | 29.514 ns | 0.0457 ns | 0.0427 ns | 0.0057 |      24 B |
           FromDouble | 28.720 ns | 0.0849 ns | 0.0794 ns | 0.0057 |      24 B |
   FromDoubleNullable | 29.682 ns | 0.0335 ns | 0.0297 ns | 0.0057 |      24 B |
          FromDecimal | 46.357 ns | 0.0179 ns | 0.0159 ns | 0.0076 |      32 B |
  FromDecimalNullable | 48.377 ns | 0.0411 ns | 0.0384 ns | 0.0076 |      32 B |
         FromDateTime | 27.083 ns | 0.0246 ns | 0.0205 ns | 0.0057 |      24 B |
 FromDateTimeNullable |  7.290 ns | 0.0038 ns | 0.0035 ns |      - |       0 B |
           FromObject | 13.479 ns | 0.0044 ns | 0.0035 ns |      - |       0 B |
           FromString | 35.266 ns | 0.0386 ns | 0.0342 ns |      - |       0 B |
             FromEnum |  1.076 ns | 0.0005 ns | 0.0005 ns |      - |       0 B |
     FromEnumNullable |  1.230 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
