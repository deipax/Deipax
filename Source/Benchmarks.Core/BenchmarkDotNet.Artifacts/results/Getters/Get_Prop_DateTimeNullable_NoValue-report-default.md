
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.531 ns | 0.0106 ns | 0.0094 ns |       0 B |
     ToBoolNullable | 8.665 ns | 0.1082 ns | 0.0904 ns |       0 B |
             ToChar | 1.533 ns | 0.0111 ns | 0.0092 ns |       0 B |
     ToCharNullable | 8.715 ns | 0.0850 ns | 0.0754 ns |       0 B |
            ToSByte | 1.528 ns | 0.0073 ns | 0.0064 ns |       0 B |
    ToSByteNullable | 8.595 ns | 0.0126 ns | 0.0118 ns |       0 B |
             ToByte | 1.562 ns | 0.0408 ns | 0.0361 ns |       0 B |
     ToByteNullable | 8.604 ns | 0.0310 ns | 0.0259 ns |       0 B |
            ToShort | 1.522 ns | 0.0058 ns | 0.0051 ns |       0 B |
    ToShortNullable | 8.850 ns | 0.1929 ns | 0.1710 ns |       0 B |
           ToUShort | 1.531 ns | 0.0209 ns | 0.0185 ns |       0 B |
   ToUShortNullable | 8.652 ns | 0.0504 ns | 0.0447 ns |       0 B |
              ToInt | 1.537 ns | 0.0320 ns | 0.0267 ns |       0 B |
      ToIntNullable | 8.655 ns | 0.0164 ns | 0.0146 ns |       0 B |
             ToUInt | 1.558 ns | 0.0220 ns | 0.0206 ns |       0 B |
     ToUIntNullable | 8.899 ns | 0.0562 ns | 0.0469 ns |       0 B |
             ToLong | 1.553 ns | 0.0038 ns | 0.0023 ns |       0 B |
     ToLongNullable | 2.833 ns | 0.0174 ns | 0.0145 ns |       0 B |
            ToULong | 1.538 ns | 0.0123 ns | 0.0115 ns |       0 B |
    ToULongNullable | 7.292 ns | 0.0042 ns | 0.0039 ns |       0 B |
            ToFloat | 6.255 ns | 0.0294 ns | 0.0260 ns |       0 B |
    ToFloatNullable | 9.138 ns | 0.2786 ns | 0.3720 ns |       0 B |
           ToDouble | 1.551 ns | 0.0172 ns | 0.0152 ns |       0 B |
   ToDoubleNullable | 2.837 ns | 0.0188 ns | 0.0176 ns |       0 B |
          ToDecimal | 9.994 ns | 0.0173 ns | 0.0153 ns |       0 B |
  ToDecimalNullable | 2.857 ns | 0.0230 ns | 0.0215 ns |       0 B |
         ToDateTime | 3.582 ns | 0.0040 ns | 0.0036 ns |       0 B |
 ToDateTimeNullable | 2.346 ns | 0.0402 ns | 0.0357 ns |       0 B |
           ToObject | 1.831 ns | 0.0418 ns | 0.0371 ns |       0 B |
          To_String | 2.366 ns | 0.0795 ns | 0.0947 ns |       0 B |
             ToEnum | 2.142 ns | 0.0913 ns | 0.1086 ns |       0 B |
     ToEnumNullable | 8.654 ns | 0.0731 ns | 0.0610 ns |       0 B |
