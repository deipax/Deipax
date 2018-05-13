
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 8.382 ns | 0.0181 ns | 0.0169 ns |       0 B |
     ToBoolNullable | 8.888 ns | 0.0646 ns | 0.0539 ns |       0 B |
             ToChar | 1.364 ns | 0.0602 ns | 0.0761 ns |       0 B |
     ToCharNullable | 4.485 ns | 0.0303 ns | 0.0253 ns |       0 B |
            ToSByte | 8.528 ns | 0.0636 ns | 0.0531 ns |       0 B |
    ToSByteNullable | 8.974 ns | 0.0440 ns | 0.0390 ns |       0 B |
             ToByte | 8.382 ns | 0.0377 ns | 0.0315 ns |       0 B |
     ToByteNullable | 9.281 ns | 0.1202 ns | 0.1124 ns |       0 B |
            ToShort | 8.375 ns | 0.0138 ns | 0.0123 ns |       0 B |
    ToShortNullable | 8.941 ns | 0.0440 ns | 0.0412 ns |       0 B |
           ToUShort | 8.580 ns | 0.2021 ns | 0.1985 ns |       0 B |
   ToUShortNullable | 8.860 ns | 0.0137 ns | 0.0122 ns |       0 B |
              ToInt | 8.550 ns | 0.1427 ns | 0.1265 ns |       0 B |
      ToIntNullable | 9.222 ns | 0.0323 ns | 0.0287 ns |       0 B |
             ToUInt | 8.352 ns | 0.0127 ns | 0.0106 ns |       0 B |
     ToUIntNullable | 9.065 ns | 0.0150 ns | 0.0125 ns |       0 B |
             ToLong | 8.355 ns | 0.0095 ns | 0.0084 ns |       0 B |
     ToLongNullable | 9.742 ns | 0.0502 ns | 0.0363 ns |       0 B |
            ToULong | 8.412 ns | 0.1370 ns | 0.1215 ns |       0 B |
    ToULongNullable | 9.342 ns | 0.0204 ns | 0.0180 ns |       0 B |
            ToFloat | 8.425 ns | 0.0451 ns | 0.0400 ns |       0 B |
    ToFloatNullable | 8.944 ns | 0.1467 ns | 0.1301 ns |       0 B |
           ToDouble | 8.482 ns | 0.0417 ns | 0.0326 ns |       0 B |
   ToDoubleNullable | 9.903 ns | 0.0517 ns | 0.0403 ns |       0 B |
          ToDecimal | 3.624 ns | 0.0800 ns | 0.0748 ns |       0 B |
  ToDecimalNullable | 2.560 ns | 0.0024 ns | 0.0022 ns |       0 B |
         ToDateTime | 3.065 ns | 0.0034 ns | 0.0030 ns |       0 B |
 ToDateTimeNullable | 8.459 ns | 0.0152 ns | 0.0135 ns |       0 B |
           ToObject | 1.792 ns | 0.0041 ns | 0.0038 ns |       0 B |
          To_String | 8.379 ns | 0.0072 ns | 0.0060 ns |       0 B |
             ToEnum | 8.356 ns | 0.0058 ns | 0.0052 ns |       0 B |
     ToEnumNullable | 8.855 ns | 0.0080 ns | 0.0071 ns |       0 B |
