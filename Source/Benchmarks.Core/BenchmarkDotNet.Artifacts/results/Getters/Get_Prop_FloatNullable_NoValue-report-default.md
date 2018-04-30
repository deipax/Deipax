
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.329 ns | 0.0027 ns | 0.0021 ns |       0 B |
     ToBoolNullable | 6.755 ns | 0.0014 ns | 0.0013 ns |       0 B |
             ToChar | 3.160 ns | 0.0014 ns | 0.0012 ns |       0 B |
     ToCharNullable | 6.533 ns | 0.0257 ns | 0.0228 ns |       0 B |
            ToSByte | 3.291 ns | 0.0047 ns | 0.0044 ns |       0 B |
    ToSByteNullable | 6.520 ns | 0.0079 ns | 0.0070 ns |       0 B |
             ToByte | 3.399 ns | 0.0104 ns | 0.0086 ns |       0 B |
     ToByteNullable | 6.543 ns | 0.0233 ns | 0.0206 ns |       0 B |
            ToShort | 3.282 ns | 0.0056 ns | 0.0052 ns |       0 B |
    ToShortNullable | 6.768 ns | 0.0238 ns | 0.0223 ns |       0 B |
           ToUShort | 3.313 ns | 0.0625 ns | 0.0584 ns |       0 B |
   ToUShortNullable | 6.532 ns | 0.0272 ns | 0.0254 ns |       0 B |
              ToInt | 3.318 ns | 0.0106 ns | 0.0094 ns |       0 B |
      ToIntNullable | 6.551 ns | 0.0244 ns | 0.0216 ns |       0 B |
             ToUInt | 3.375 ns | 0.0042 ns | 0.0038 ns |       0 B |
     ToUIntNullable | 6.545 ns | 0.0243 ns | 0.0203 ns |       0 B |
             ToLong | 4.036 ns | 0.0058 ns | 0.0051 ns |       0 B |
     ToLongNullable | 6.138 ns | 0.0255 ns | 0.0238 ns |       0 B |
            ToULong | 3.264 ns | 0.0050 ns | 0.0045 ns |       0 B |
    ToULongNullable | 6.142 ns | 0.0203 ns | 0.0190 ns |       0 B |
            ToFloat | 1.787 ns | 0.0102 ns | 0.0096 ns |       0 B |
    ToFloatNullable | 1.533 ns | 0.0034 ns | 0.0031 ns |       0 B |
           ToDouble | 4.060 ns | 0.0023 ns | 0.0020 ns |       0 B |
   ToDoubleNullable | 6.397 ns | 0.0070 ns | 0.0066 ns |       0 B |
          ToDecimal | 6.682 ns | 0.0062 ns | 0.0048 ns |       0 B |
  ToDecimalNullable | 6.403 ns | 0.0089 ns | 0.0079 ns |       0 B |
         ToDateTime | 4.599 ns | 0.0023 ns | 0.0020 ns |       0 B |
 ToDateTimeNullable | 6.166 ns | 0.0132 ns | 0.0123 ns |       0 B |
           ToObject | 2.043 ns | 0.0008 ns | 0.0007 ns |       0 B |
          To_String | 3.346 ns | 0.0010 ns | 0.0008 ns |       0 B |
             ToEnum | 3.513 ns | 0.0010 ns | 0.0008 ns |       0 B |
