
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 1.0101 ns | 0.0015 ns | 0.0014 ns |       0 B |
     FromBoolNullable | 0.9493 ns | 0.0051 ns | 0.0040 ns |       0 B |
             FromChar | 1.0745 ns | 0.0076 ns | 0.0071 ns |       0 B |
     FromCharNullable | 1.0604 ns | 0.0032 ns | 0.0030 ns |       0 B |
            FromSByte | 1.9186 ns | 0.0034 ns | 0.0028 ns |       0 B |
    FromSByteNullable | 2.2273 ns | 0.0026 ns | 0.0023 ns |       0 B |
             FromByte | 1.0586 ns | 0.0018 ns | 0.0017 ns |       0 B |
     FromByteNullable | 1.7741 ns | 0.0021 ns | 0.0020 ns |       0 B |
            FromShort | 1.9222 ns | 0.0062 ns | 0.0058 ns |       0 B |
    FromShortNullable | 2.4245 ns | 0.0063 ns | 0.0056 ns |       0 B |
           FromUShort | 1.1467 ns | 0.0016 ns | 0.0012 ns |       0 B |
   FromUShortNullable | 1.7752 ns | 0.0032 ns | 0.0030 ns |       0 B |
              FromInt | 2.7398 ns | 0.0057 ns | 0.0053 ns |       0 B |
      FromIntNullable | 2.4716 ns | 0.0055 ns | 0.0051 ns |       0 B |
             FromUInt | 2.0128 ns | 0.0126 ns | 0.0118 ns |       0 B |
     FromUIntNullable | 3.1790 ns | 0.0037 ns | 0.0034 ns |       0 B |
             FromLong | 2.6977 ns | 0.0313 ns | 0.0293 ns |       0 B |
     FromLongNullable | 2.8426 ns | 0.0357 ns | 0.0334 ns |       0 B |
            FromULong | 2.6139 ns | 0.0028 ns | 0.0025 ns |       0 B |
    FromULongNullable | 2.6030 ns | 0.0101 ns | 0.0089 ns |       0 B |
            FromFloat | 1.0263 ns | 0.0040 ns | 0.0035 ns |       0 B |
    FromFloatNullable | 1.1987 ns | 0.0028 ns | 0.0026 ns |       0 B |
           FromDouble | 1.0259 ns | 0.0019 ns | 0.0017 ns |       0 B |
   FromDoubleNullable | 1.7078 ns | 0.0049 ns | 0.0046 ns |       0 B |
          FromDecimal | 1.7732 ns | 0.0028 ns | 0.0023 ns |       0 B |
  FromDecimalNullable | 1.6059 ns | 0.0019 ns | 0.0015 ns |       0 B |
         FromDateTime | 1.0093 ns | 0.0029 ns | 0.0027 ns |       0 B |
 FromDateTimeNullable | 2.4378 ns | 0.0026 ns | 0.0023 ns |       0 B |
           FromObject | 3.8611 ns | 0.0062 ns | 0.0055 ns |       0 B |
           FromString | 2.1721 ns | 0.0017 ns | 0.0013 ns |       0 B |
             FromEnum | 2.8409 ns | 0.0065 ns | 0.0061 ns |       0 B |
     FromEnumNullable | 2.9619 ns | 0.0039 ns | 0.0030 ns |       0 B |
