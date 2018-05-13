
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev |   Median | Allocated |
------------------- |---------:|----------:|----------:|---------:|----------:|
             ToBool | 2.370 ns | 0.0620 ns | 0.0448 ns | 2.371 ns |       0 B |
     ToBoolNullable | 4.826 ns | 0.1043 ns | 0.0975 ns | 4.783 ns |       0 B |
             ToChar | 2.300 ns | 0.0132 ns | 0.0117 ns | 2.295 ns |       0 B |
     ToCharNullable | 5.033 ns | 0.0387 ns | 0.0323 ns | 5.034 ns |       0 B |
            ToSByte | 2.325 ns | 0.0269 ns | 0.0251 ns | 2.314 ns |       0 B |
    ToSByteNullable | 5.379 ns | 0.1265 ns | 0.1183 ns | 5.343 ns |       0 B |
             ToByte | 2.324 ns | 0.0310 ns | 0.0259 ns | 2.311 ns |       0 B |
     ToByteNullable | 5.341 ns | 0.1413 ns | 0.1387 ns | 5.330 ns |       0 B |
            ToShort | 2.300 ns | 0.0048 ns | 0.0042 ns | 2.299 ns |       0 B |
    ToShortNullable | 5.272 ns | 0.0124 ns | 0.0104 ns | 5.272 ns |       0 B |
           ToUShort | 2.293 ns | 0.0044 ns | 0.0037 ns | 2.292 ns |       0 B |
   ToUShortNullable | 5.285 ns | 0.0258 ns | 0.0229 ns | 5.276 ns |       0 B |
              ToInt | 2.305 ns | 0.0167 ns | 0.0140 ns | 2.303 ns |       0 B |
      ToIntNullable | 5.218 ns | 0.0125 ns | 0.0097 ns | 5.218 ns |       0 B |
             ToUInt | 2.311 ns | 0.0103 ns | 0.0091 ns | 2.308 ns |       0 B |
     ToUIntNullable | 5.280 ns | 0.0197 ns | 0.0175 ns | 5.277 ns |       0 B |
             ToLong | 2.306 ns | 0.0228 ns | 0.0202 ns | 2.295 ns |       0 B |
     ToLongNullable | 4.108 ns | 0.0134 ns | 0.0119 ns | 4.106 ns |       0 B |
            ToULong | 2.360 ns | 0.0664 ns | 0.0589 ns | 2.346 ns |       0 B |
    ToULongNullable | 3.856 ns | 0.0112 ns | 0.0099 ns | 3.858 ns |       0 B |
            ToFloat | 2.410 ns | 0.0381 ns | 0.0318 ns | 2.398 ns |       0 B |
    ToFloatNullable | 5.268 ns | 0.0142 ns | 0.0126 ns | 5.269 ns |       0 B |
           ToDouble | 2.289 ns | 0.0292 ns | 0.0259 ns | 2.276 ns |       0 B |
   ToDoubleNullable | 4.125 ns | 0.0220 ns | 0.0195 ns | 4.123 ns |       0 B |
          ToDecimal | 3.885 ns | 0.0603 ns | 0.0534 ns | 3.881 ns |       0 B |
  ToDecimalNullable | 9.649 ns | 0.2312 ns | 0.6171 ns | 9.265 ns |       0 B |
         ToDateTime | 3.849 ns | 0.0148 ns | 0.0124 ns | 3.843 ns |       0 B |
 ToDateTimeNullable | 9.430 ns | 0.0107 ns | 0.0095 ns | 9.429 ns |       0 B |
           ToObject | 1.790 ns | 0.0028 ns | 0.0026 ns | 1.788 ns |       0 B |
          To_String | 1.314 ns | 0.0124 ns | 0.0110 ns | 1.315 ns |       0 B |
             ToEnum | 2.945 ns | 0.0901 ns | 0.1203 ns | 2.933 ns |       0 B |
     ToEnumNullable | 4.749 ns | 0.0164 ns | 0.0128 ns | 4.746 ns |       0 B |
