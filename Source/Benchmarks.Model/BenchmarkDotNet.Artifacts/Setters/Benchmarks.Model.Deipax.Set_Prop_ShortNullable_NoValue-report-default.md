
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.7595 ns | 0.1087 ns | 0.0060 ns | 0.7574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.9258 ns | 0.1386 ns | 0.0076 ns | 0.9266 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.3083 ns | 1.0972 ns | 0.0601 ns | 1.3104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.4463 ns | 0.6422 ns | 0.0352 ns | 1.4628 ns |  1.11 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.7511 ns | 0.6960 ns | 0.0381 ns | 0.7345 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.7508 ns | 0.4622 ns | 0.0253 ns | 0.7423 ns |  1.00 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.2338 ns | 0.5579 ns | 0.0306 ns | 1.2385 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.2331 ns | 0.4454 ns | 0.0244 ns | 1.2218 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.7156 ns | 0.0769 ns | 0.0042 ns | 0.7150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.7249 ns | 0.2153 ns | 0.0118 ns | 0.7215 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.1587 ns | 0.0675 ns | 0.0037 ns | 1.1587 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.2637 ns | 0.6259 ns | 0.0343 ns | 1.2444 ns |  1.09 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.6858 ns | 0.1547 ns | 0.0085 ns | 0.6831 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.7407 ns | 0.1222 ns | 0.0067 ns | 0.7400 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 0.9912 ns | 0.4693 ns | 0.0257 ns | 0.9879 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.2254 ns | 0.6436 ns | 0.0353 ns | 1.2064 ns |  1.24 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.6740 ns | 0.0769 ns | 0.0042 ns | 0.6759 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.7250 ns | 0.5163 ns | 0.0283 ns | 0.7222 ns |  1.08 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 0.9266 ns | 0.3068 ns | 0.0168 ns | 0.9208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 0.7331 ns | 0.1721 ns | 0.0094 ns | 0.7287 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.7773 ns | 0.1708 ns | 0.0094 ns | 0.7772 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.7604 ns | 0.4899 ns | 0.0269 ns | 0.7517 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.2173 ns | 0.6611 ns | 0.0362 ns | 1.2044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.1775 ns | 0.2120 ns | 0.0116 ns | 1.1783 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 1.9335 ns | 0.4808 ns | 0.0264 ns | 1.9275 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 1.8196 ns | 0.4804 ns | 0.0263 ns | 1.8062 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.8037 ns | 1.7789 ns | 0.0975 ns | 1.8016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.7764 ns | 1.5377 ns | 0.0843 ns | 1.7337 ns |  0.99 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 1.9582 ns | 0.2366 ns | 0.0130 ns | 1.9592 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.7629 ns | 0.1360 ns | 0.0075 ns | 0.7647 ns |  0.39 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.9635 ns | 7.0600 ns | 0.3870 ns | 1.7420 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.1690 ns | 1.0532 ns | 0.0577 ns | 1.1654 ns |  0.61 |    0.11 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 1.9162 ns | 0.1157 ns | 0.0063 ns | 1.9155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 1.7724 ns | 0.2181 ns | 0.0120 ns | 1.7667 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.8893 ns | 0.7710 ns | 0.0423 ns | 1.8869 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.9115 ns | 0.1866 ns | 0.0102 ns | 1.9112 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 1.7569 ns | 0.9317 ns | 0.0511 ns | 1.7762 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 1.7082 ns | 0.6245 ns | 0.0342 ns | 1.6908 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.9295 ns | 0.9974 ns | 0.0547 ns | 1.9060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.8459 ns | 1.1141 ns | 0.0611 ns | 1.8188 ns |  0.96 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 4.0475 ns | 0.2207 ns | 0.0121 ns | 4.0463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 4.2681 ns | 0.0981 ns | 0.0054 ns | 4.2707 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.7528 ns | 0.7423 ns | 0.0407 ns | 1.7380 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.7954 ns | 0.4024 ns | 0.0221 ns | 1.8075 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 4.4484 ns | 0.3271 ns | 0.0179 ns | 4.4582 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 4.3615 ns | 1.6618 ns | 0.0911 ns | 4.3120 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.0650 ns | 0.8536 ns | 0.0468 ns | 2.0440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 2.0061 ns | 0.2485 ns | 0.0136 ns | 2.0134 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 7.9438 ns | 0.0992 ns | 0.0054 ns | 7.9444 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 9.0134 ns | 1.6936 ns | 0.0928 ns | 8.9919 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 3.4636 ns | 0.6254 ns | 0.0343 ns | 3.4463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.4170 ns | 0.3353 ns | 0.0184 ns | 2.4256 ns |  0.70 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7195 ns | 0.0895 ns | 0.0049 ns | 0.7207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7480 ns | 0.9439 ns | 0.0517 ns | 0.7383 ns |  1.04 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.6391 ns | 0.8167 ns | 0.0448 ns | 1.6381 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.3072 ns | 0.5699 ns | 0.0312 ns | 1.3222 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.7575 ns | 0.7339 ns | 0.0402 ns | 2.7349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.7049 ns | 1.2742 ns | 0.0698 ns | 2.6692 ns |  0.98 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9774 ns | 0.7297 ns | 0.0400 ns | 1.9639 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.8218 ns | 0.2765 ns | 0.0152 ns | 1.8137 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 1.7600 ns | 0.0869 ns | 0.0048 ns | 1.7626 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 2.4958 ns | 3.1553 ns | 0.1730 ns | 2.3999 ns |  1.42 |    0.10 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.7436 ns | 0.6758 ns | 0.0370 ns | 1.7281 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.7269 ns | 0.1103 ns | 0.0060 ns | 1.7283 ns |  0.99 |    0.02 |     - |     - |     - |         - |
