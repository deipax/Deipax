
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.214 ns | 0.0239 ns | 0.0224 ns |       0 B |
     FromBoolNullable |  1.099 ns | 0.0035 ns | 0.0033 ns |       0 B |
             FromChar |  6.795 ns | 0.0201 ns | 0.0178 ns |       0 B |
     FromCharNullable |  6.653 ns | 0.0546 ns | 0.0511 ns |       0 B |
            FromSByte |  6.832 ns | 0.0510 ns | 0.0426 ns |       0 B |
    FromSByteNullable |  6.568 ns | 0.0534 ns | 0.0446 ns |       0 B |
             FromByte |  6.838 ns | 0.0782 ns | 0.0693 ns |       0 B |
     FromByteNullable |  6.569 ns | 0.0243 ns | 0.0203 ns |       0 B |
            FromShort |  6.829 ns | 0.0730 ns | 0.0683 ns |       0 B |
    FromShortNullable |  6.524 ns | 0.0087 ns | 0.0063 ns |       0 B |
           FromUShort |  6.805 ns | 0.0558 ns | 0.0522 ns |       0 B |
   FromUShortNullable |  6.546 ns | 0.0160 ns | 0.0142 ns |       0 B |
              FromInt |  6.783 ns | 0.0172 ns | 0.0160 ns |       0 B |
      FromIntNullable |  6.557 ns | 0.0377 ns | 0.0353 ns |       0 B |
             FromUInt |  6.790 ns | 0.0310 ns | 0.0275 ns |       0 B |
     FromUIntNullable |  6.521 ns | 0.0057 ns | 0.0051 ns |       0 B |
             FromLong |  6.840 ns | 0.0590 ns | 0.0523 ns |       0 B |
     FromLongNullable |  7.057 ns | 0.0374 ns | 0.0331 ns |       0 B |
            FromULong |  6.807 ns | 0.0434 ns | 0.0385 ns |       0 B |
    FromULongNullable |  7.055 ns | 0.0499 ns | 0.0416 ns |       0 B |
            FromFloat |  6.522 ns | 0.0267 ns | 0.0209 ns |       0 B |
    FromFloatNullable |  6.565 ns | 0.0160 ns | 0.0125 ns |       0 B |
           FromDouble |  6.536 ns | 0.0100 ns | 0.0084 ns |       0 B |
   FromDoubleNullable |  7.098 ns | 0.0630 ns | 0.0559 ns |       0 B |
          FromDecimal | 13.321 ns | 0.2937 ns | 0.3016 ns |       0 B |
  FromDecimalNullable |  7.303 ns | 0.0532 ns | 0.0471 ns |       0 B |
         FromDateTime |  6.868 ns | 0.0357 ns | 0.0333 ns |       0 B |
 FromDateTimeNullable |  7.318 ns | 0.0558 ns | 0.0494 ns |       0 B |
           FromObject |  7.548 ns | 0.0145 ns | 0.0121 ns |       0 B |
           FromString |  6.768 ns | 0.0097 ns | 0.0086 ns |       0 B |
             FromEnum |  6.904 ns | 0.0677 ns | 0.0633 ns |       0 B |
     FromEnumNullable |  6.525 ns | 0.0052 ns | 0.0046 ns |       0 B |
