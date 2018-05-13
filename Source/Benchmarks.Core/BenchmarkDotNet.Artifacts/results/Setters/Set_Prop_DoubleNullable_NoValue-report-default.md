
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 1.3012 ns | 0.0038 ns | 0.0031 ns |       0 B |
     FromBoolNullable | 2.1560 ns | 0.0768 ns | 0.0642 ns |       0 B |
             FromChar | 1.0414 ns | 0.0020 ns | 0.0017 ns |       0 B |
     FromCharNullable | 1.0201 ns | 0.0031 ns | 0.0027 ns |       0 B |
            FromSByte | 1.0445 ns | 0.0029 ns | 0.0027 ns |       0 B |
    FromSByteNullable | 1.8119 ns | 0.0045 ns | 0.0042 ns |       0 B |
             FromByte | 1.1072 ns | 0.0040 ns | 0.0036 ns |       0 B |
     FromByteNullable | 1.8138 ns | 0.0039 ns | 0.0035 ns |       0 B |
            FromShort | 1.0775 ns | 0.0047 ns | 0.0044 ns |       0 B |
    FromShortNullable | 1.8121 ns | 0.0128 ns | 0.0120 ns |       0 B |
           FromUShort | 1.0498 ns | 0.0045 ns | 0.0042 ns |       0 B |
   FromUShortNullable | 1.8126 ns | 0.0042 ns | 0.0039 ns |       0 B |
              FromInt | 1.0461 ns | 0.0050 ns | 0.0044 ns |       0 B |
      FromIntNullable | 1.8027 ns | 0.0055 ns | 0.0051 ns |       0 B |
             FromUInt | 1.0493 ns | 0.0017 ns | 0.0015 ns |       0 B |
     FromUIntNullable | 1.8127 ns | 0.0051 ns | 0.0047 ns |       0 B |
             FromLong | 1.0460 ns | 0.0046 ns | 0.0041 ns |       0 B |
     FromLongNullable | 2.3251 ns | 0.0066 ns | 0.0061 ns |       0 B |
            FromULong | 1.3635 ns | 0.0125 ns | 0.0117 ns |       0 B |
    FromULongNullable | 2.3266 ns | 0.0063 ns | 0.0059 ns |       0 B |
            FromFloat | 1.2904 ns | 0.0058 ns | 0.0055 ns |       0 B |
    FromFloatNullable | 1.8153 ns | 0.0046 ns | 0.0043 ns |       0 B |
           FromDouble | 1.0286 ns | 0.0048 ns | 0.0045 ns |       0 B |
   FromDoubleNullable | 1.8120 ns | 0.0027 ns | 0.0025 ns |       0 B |
          FromDecimal | 9.4894 ns | 0.0232 ns | 0.0217 ns |       0 B |
  FromDecimalNullable | 8.5071 ns | 0.0056 ns | 0.0052 ns |       0 B |
         FromDateTime | 0.9036 ns | 0.0040 ns | 0.0037 ns |       0 B |
 FromDateTimeNullable | 2.0700 ns | 0.0016 ns | 0.0012 ns |       0 B |
           FromObject | 4.4918 ns | 0.0072 ns | 0.0067 ns |       0 B |
           FromString | 2.6921 ns | 0.0049 ns | 0.0044 ns |       0 B |
             FromEnum | 1.0971 ns | 0.0053 ns | 0.0049 ns |       0 B |
     FromEnumNullable | 1.6432 ns | 0.0122 ns | 0.0114 ns |       0 B |
