
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |---------:|----------:|----------:|-------:|----------:|
             FromBool | 4.883 ns | 0.0115 ns | 0.0102 ns | 0.0057 |      24 B |
     FromBoolNullable | 1.753 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
             FromChar | 5.414 ns | 0.0119 ns | 0.0111 ns | 0.0057 |      24 B |
     FromCharNullable | 1.814 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
            FromSByte | 4.886 ns | 0.0133 ns | 0.0125 ns | 0.0057 |      24 B |
    FromSByteNullable | 1.751 ns | 0.0034 ns | 0.0027 ns |      - |       0 B |
             FromByte | 4.880 ns | 0.0039 ns | 0.0033 ns | 0.0057 |      24 B |
     FromByteNullable | 2.065 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
            FromShort | 4.890 ns | 0.0133 ns | 0.0124 ns | 0.0057 |      24 B |
    FromShortNullable | 1.873 ns | 0.0182 ns | 0.0152 ns |      - |       0 B |
           FromUShort | 5.071 ns | 0.0856 ns | 0.0668 ns | 0.0057 |      24 B |
   FromUShortNullable | 1.835 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
              FromInt | 5.091 ns | 0.0278 ns | 0.0232 ns | 0.0057 |      24 B |
      FromIntNullable | 1.787 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
             FromUInt | 4.965 ns | 0.0139 ns | 0.0130 ns | 0.0057 |      24 B |
     FromUIntNullable | 1.878 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
             FromLong | 4.951 ns | 0.0098 ns | 0.0092 ns | 0.0057 |      24 B |
     FromLongNullable | 2.975 ns | 0.0296 ns | 0.0262 ns |      - |       0 B |
            FromULong | 5.169 ns | 0.0227 ns | 0.0212 ns | 0.0057 |      24 B |
    FromULongNullable | 2.352 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
            FromFloat | 5.349 ns | 0.0041 ns | 0.0037 ns | 0.0057 |      24 B |
    FromFloatNullable | 1.819 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
           FromDouble | 5.278 ns | 0.0192 ns | 0.0180 ns | 0.0057 |      24 B |
   FromDoubleNullable | 2.350 ns | 0.0030 ns | 0.0026 ns |      - |       0 B |
          FromDecimal | 6.006 ns | 0.0158 ns | 0.0148 ns | 0.0076 |      32 B |
  FromDecimalNullable | 2.362 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
         FromDateTime | 4.979 ns | 0.0099 ns | 0.0092 ns | 0.0057 |      24 B |
 FromDateTimeNullable | 2.354 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
           FromObject | 2.829 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
           FromString | 3.091 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
             FromEnum | 4.922 ns | 0.0056 ns | 0.0053 ns | 0.0057 |      24 B |
     FromEnumNullable | 1.890 ns | 0.0014 ns | 0.0014 ns |      - |       0 B |
