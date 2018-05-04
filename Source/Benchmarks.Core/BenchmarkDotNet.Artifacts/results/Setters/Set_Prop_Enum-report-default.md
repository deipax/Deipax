
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 12.771 ns | 0.0076 ns | 0.0067 ns |       0 B |
     FromBoolNullable | 14.077 ns | 0.0545 ns | 0.0484 ns |       0 B |
             FromChar | 13.116 ns | 0.0163 ns | 0.0136 ns |       0 B |
     FromCharNullable | 13.749 ns | 0.0564 ns | 0.0528 ns |       0 B |
            FromSByte | 14.014 ns | 0.1208 ns | 0.1009 ns |       0 B |
    FromSByteNullable | 13.822 ns | 0.0044 ns | 0.0037 ns |       0 B |
             FromByte | 12.577 ns | 0.0269 ns | 0.0225 ns |       0 B |
     FromByteNullable | 14.045 ns | 0.0115 ns | 0.0102 ns |       0 B |
            FromShort | 12.565 ns | 0.0123 ns | 0.0109 ns |       0 B |
    FromShortNullable | 14.389 ns | 0.0159 ns | 0.0148 ns |       0 B |
           FromUShort | 12.561 ns | 0.0143 ns | 0.0120 ns |       0 B |
   FromUShortNullable | 13.849 ns | 0.0139 ns | 0.0130 ns |       0 B |
              FromInt | 12.514 ns | 0.0137 ns | 0.0121 ns |       0 B |
      FromIntNullable | 13.827 ns | 0.0201 ns | 0.0188 ns |       0 B |
             FromUInt | 13.224 ns | 0.0075 ns | 0.0070 ns |       0 B |
     FromUIntNullable | 15.109 ns | 0.0104 ns | 0.0087 ns |       0 B |
             FromLong | 13.713 ns | 0.0085 ns | 0.0071 ns |       0 B |
     FromLongNullable | 15.914 ns | 0.0232 ns | 0.0181 ns |       0 B |
            FromULong | 13.306 ns | 0.0321 ns | 0.0300 ns |       0 B |
    FromULongNullable | 15.924 ns | 0.0232 ns | 0.0217 ns |       0 B |
            FromFloat | 15.087 ns | 0.0190 ns | 0.0158 ns |       0 B |
    FromFloatNullable | 16.717 ns | 0.0199 ns | 0.0186 ns |       0 B |
           FromDouble | 15.086 ns | 0.0144 ns | 0.0127 ns |       0 B |
   FromDoubleNullable | 17.375 ns | 0.0397 ns | 0.0371 ns |       0 B |
          FromDecimal | 25.487 ns | 0.1439 ns | 0.1346 ns |       0 B |
  FromDecimalNullable | 26.798 ns | 0.0231 ns | 0.0217 ns |       0 B |
         FromDateTime | 15.730 ns | 0.0222 ns | 0.0174 ns |       0 B |
 FromDateTimeNullable |  4.276 ns | 0.0098 ns | 0.0092 ns |       0 B |
           FromObject |  2.750 ns | 0.0022 ns | 0.0020 ns |       0 B |
           FromString | 30.236 ns | 0.0514 ns | 0.0481 ns |       0 B |
             FromEnum |  1.059 ns | 0.0032 ns | 0.0030 ns |       0 B |
     FromEnumNullable |  1.580 ns | 0.0028 ns | 0.0026 ns |       0 B |
