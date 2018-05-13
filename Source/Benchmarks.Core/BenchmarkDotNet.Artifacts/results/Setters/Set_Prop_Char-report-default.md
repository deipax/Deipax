
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 0.7857 ns | 0.0020 ns | 0.0019 ns |       0 B |
     FromBoolNullable | 0.9297 ns | 0.0022 ns | 0.0019 ns |       0 B |
             FromChar | 0.8590 ns | 0.0039 ns | 0.0034 ns |       0 B |
     FromCharNullable | 1.6564 ns | 0.0103 ns | 0.0096 ns |       0 B |
            FromSByte | 1.7796 ns | 0.0031 ns | 0.0029 ns |       0 B |
    FromSByteNullable | 2.3011 ns | 0.0021 ns | 0.0017 ns |       0 B |
             FromByte | 0.7830 ns | 0.0058 ns | 0.0052 ns |       0 B |
     FromByteNullable | 1.5518 ns | 0.0033 ns | 0.0029 ns |       0 B |
            FromShort | 1.8020 ns | 0.0030 ns | 0.0028 ns |       0 B |
    FromShortNullable | 2.4128 ns | 0.0049 ns | 0.0046 ns |       0 B |
           FromUShort | 0.7820 ns | 0.0038 ns | 0.0036 ns |       0 B |
   FromUShortNullable | 1.5505 ns | 0.0026 ns | 0.0023 ns |       0 B |
              FromInt | 2.5834 ns | 0.0043 ns | 0.0040 ns |       0 B |
      FromIntNullable | 3.0889 ns | 0.0046 ns | 0.0038 ns |       0 B |
             FromUInt | 3.0680 ns | 0.0029 ns | 0.0027 ns |       0 B |
     FromUIntNullable | 2.5611 ns | 0.0107 ns | 0.0100 ns |       0 B |
             FromLong | 2.5736 ns | 0.0099 ns | 0.0093 ns |       0 B |
     FromLongNullable | 4.1071 ns | 0.0056 ns | 0.0053 ns |       0 B |
            FromULong | 2.3659 ns | 0.0093 ns | 0.0082 ns |       0 B |
    FromULongNullable | 3.8507 ns | 0.0042 ns | 0.0039 ns |       0 B |
            FromFloat | 1.0252 ns | 0.0024 ns | 0.0023 ns |       0 B |
    FromFloatNullable | 1.0152 ns | 0.0051 ns | 0.0048 ns |       0 B |
           FromDouble | 1.0249 ns | 0.0013 ns | 0.0012 ns |       0 B |
   FromDoubleNullable | 1.5518 ns | 0.0037 ns | 0.0035 ns |       0 B |
          FromDecimal | 1.5565 ns | 0.0032 ns | 0.0030 ns |       0 B |
  FromDecimalNullable | 1.5509 ns | 0.0024 ns | 0.0022 ns |       0 B |
         FromDateTime | 1.0339 ns | 0.0256 ns | 0.0240 ns |       0 B |
 FromDateTimeNullable | 1.8357 ns | 0.0030 ns | 0.0028 ns |       0 B |
           FromObject | 3.2379 ns | 0.0614 ns | 0.0575 ns |       0 B |
           FromString | 3.6162 ns | 0.0077 ns | 0.0072 ns |       0 B |
             FromEnum | 2.5818 ns | 0.0017 ns | 0.0014 ns |       0 B |
     FromEnumNullable | 3.1507 ns | 0.0044 ns | 0.0039 ns |       0 B |
