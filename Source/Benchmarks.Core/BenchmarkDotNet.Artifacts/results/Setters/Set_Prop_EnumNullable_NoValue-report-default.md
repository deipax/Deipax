
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 14.046 ns | 0.0114 ns | 0.0107 ns |       0 B |
     FromBoolNullable |  6.772 ns | 0.0049 ns | 0.0043 ns |       0 B |
             FromChar | 14.058 ns | 0.0060 ns | 0.0050 ns |       0 B |
     FromCharNullable |  6.785 ns | 0.0023 ns | 0.0018 ns |       0 B |
            FromSByte | 13.700 ns | 0.0087 ns | 0.0082 ns |       0 B |
    FromSByteNullable |  6.771 ns | 0.0037 ns | 0.0031 ns |       0 B |
             FromByte | 13.676 ns | 0.0224 ns | 0.0199 ns |       0 B |
     FromByteNullable |  6.772 ns | 0.0052 ns | 0.0049 ns |       0 B |
            FromShort | 14.764 ns | 0.0030 ns | 0.0023 ns |       0 B |
    FromShortNullable |  6.768 ns | 0.0019 ns | 0.0015 ns |       0 B |
           FromUShort | 14.059 ns | 0.0084 ns | 0.0075 ns |       0 B |
   FromUShortNullable |  6.770 ns | 0.0048 ns | 0.0043 ns |       0 B |
              FromInt | 13.789 ns | 0.0052 ns | 0.0049 ns |       0 B |
      FromIntNullable |  6.769 ns | 0.0021 ns | 0.0017 ns |       0 B |
             FromUInt | 14.571 ns | 0.0053 ns | 0.0042 ns |       0 B |
     FromUIntNullable |  6.779 ns | 0.0094 ns | 0.0088 ns |       0 B |
             FromLong | 15.081 ns | 0.0068 ns | 0.0060 ns |       0 B |
     FromLongNullable |  7.265 ns | 0.0040 ns | 0.0036 ns |       0 B |
            FromULong | 14.829 ns | 0.0101 ns | 0.0084 ns |       0 B |
    FromULongNullable |  7.278 ns | 0.0073 ns | 0.0061 ns |       0 B |
            FromFloat | 16.117 ns | 0.0187 ns | 0.0175 ns |       0 B |
    FromFloatNullable |  6.519 ns | 0.0097 ns | 0.0090 ns |       0 B |
           FromDouble | 16.142 ns | 0.0444 ns | 0.0394 ns |       0 B |
   FromDoubleNullable |  7.017 ns | 0.0120 ns | 0.0112 ns |       0 B |
          FromDecimal | 31.120 ns | 0.0664 ns | 0.0621 ns |       0 B |
  FromDecimalNullable | 10.640 ns | 0.0206 ns | 0.0193 ns |       0 B |
         FromDateTime | 14.530 ns | 0.0132 ns | 0.0124 ns |       0 B |
 FromDateTimeNullable |  7.284 ns | 0.0130 ns | 0.0115 ns |       0 B |
           FromObject |  7.261 ns | 0.0012 ns | 0.0011 ns |       0 B |
           FromString |  6.762 ns | 0.0109 ns | 0.0097 ns |       0 B |
             FromEnum |  1.008 ns | 0.0018 ns | 0.0017 ns |       0 B |
     FromEnumNullable |  1.226 ns | 0.0024 ns | 0.0022 ns |       0 B |
