
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 13.815 ns | 0.0330 ns | 0.0309 ns |       0 B |
     FromBoolNullable | 14.742 ns | 0.0112 ns | 0.0093 ns |       0 B |
             FromChar | 14.086 ns | 0.0453 ns | 0.0423 ns |       0 B |
     FromCharNullable | 14.036 ns | 0.0126 ns | 0.0118 ns |       0 B |
            FromSByte | 13.644 ns | 0.0033 ns | 0.0026 ns |       0 B |
    FromSByteNullable | 14.356 ns | 0.0085 ns | 0.0075 ns |       0 B |
             FromByte | 13.601 ns | 0.0043 ns | 0.0034 ns |       0 B |
     FromByteNullable | 14.157 ns | 0.0128 ns | 0.0120 ns |       0 B |
            FromShort | 13.607 ns | 0.0055 ns | 0.0046 ns |       0 B |
    FromShortNullable | 14.051 ns | 0.0135 ns | 0.0113 ns |       0 B |
           FromUShort | 14.061 ns | 0.0048 ns | 0.0040 ns |       0 B |
   FromUShortNullable | 14.099 ns | 0.0128 ns | 0.0107 ns |       0 B |
              FromInt | 13.805 ns | 0.0269 ns | 0.0252 ns |       0 B |
      FromIntNullable | 13.984 ns | 0.0166 ns | 0.0155 ns |       0 B |
             FromUInt | 14.584 ns | 0.0076 ns | 0.0071 ns |       0 B |
     FromUIntNullable | 14.589 ns | 0.0239 ns | 0.0212 ns |       0 B |
             FromLong | 15.082 ns | 0.0085 ns | 0.0080 ns |       0 B |
     FromLongNullable | 15.407 ns | 0.0102 ns | 0.0090 ns |       0 B |
            FromULong | 14.828 ns | 0.0104 ns | 0.0087 ns |       0 B |
    FromULongNullable | 15.195 ns | 0.0403 ns | 0.0357 ns |       0 B |
            FromFloat | 16.127 ns | 0.0337 ns | 0.0315 ns |       0 B |
    FromFloatNullable | 16.373 ns | 0.0205 ns | 0.0192 ns |       0 B |
           FromDouble | 16.108 ns | 0.0084 ns | 0.0075 ns |       0 B |
   FromDoubleNullable | 17.101 ns | 0.0229 ns | 0.0214 ns |       0 B |
          FromDecimal | 33.114 ns | 0.0164 ns | 0.0128 ns |       0 B |
  FromDecimalNullable | 32.629 ns | 0.0377 ns | 0.0353 ns |       0 B |
         FromDateTime | 14.316 ns | 0.0075 ns | 0.0063 ns |       0 B |
 FromDateTimeNullable |  7.275 ns | 0.0066 ns | 0.0062 ns |       0 B |
           FromObject | 13.464 ns | 0.0075 ns | 0.0067 ns |       0 B |
           FromString | 31.746 ns | 0.0234 ns | 0.0195 ns |       0 B |
             FromEnum |  1.010 ns | 0.0059 ns | 0.0055 ns |       0 B |
     FromEnumNullable |  1.163 ns | 0.0021 ns | 0.0020 ns |       0 B |
