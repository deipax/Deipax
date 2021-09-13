
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.9669 ns | 0.9079 ns | 0.0498 ns | 0.9424 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.9901 ns | 0.2477 ns | 0.0136 ns | 0.9972 ns |  1.03 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.1839 ns | 0.0266 ns | 0.0015 ns | 1.1838 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.4630 ns | 0.9014 ns | 0.0494 ns | 1.4351 ns |  1.24 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.7805 ns | 0.5961 ns | 0.0327 ns | 0.7803 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.9559 ns | 0.1245 ns | 0.0068 ns | 0.9573 ns |  1.23 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.2092 ns | 0.3430 ns | 0.0188 ns | 1.2014 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.1552 ns | 0.6034 ns | 0.0331 ns | 1.1435 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.7394 ns | 0.2763 ns | 0.0151 ns | 0.7316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.8352 ns | 1.1605 ns | 0.0636 ns | 0.8335 ns |  1.13 |    0.11 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 0.9808 ns | 0.0655 ns | 0.0036 ns | 0.9804 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.0900 ns | 0.4323 ns | 0.0237 ns | 1.0780 ns |  1.11 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 1.0642 ns | 1.8473 ns | 0.1013 ns | 1.1104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.7614 ns | 0.5510 ns | 0.0302 ns | 0.7628 ns |  0.72 |    0.10 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 0.9946 ns | 0.4517 ns | 0.0248 ns | 0.9886 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.2269 ns | 0.1714 ns | 0.0094 ns | 1.2284 ns |  1.23 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.6651 ns | 0.5096 ns | 0.0279 ns | 0.6532 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.9761 ns | 0.4603 ns | 0.0252 ns | 0.9685 ns |  1.47 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.3235 ns | 6.4183 ns | 0.3518 ns | 1.1282 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.4623 ns | 0.0596 ns | 0.0033 ns | 1.4609 ns |  1.15 |    0.27 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.5890 ns | 0.5615 ns | 0.0308 ns | 0.5807 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.9717 ns | 0.4570 ns | 0.0250 ns | 0.9582 ns |  1.65 |    0.10 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 0.6380 ns | 0.0459 ns | 0.0025 ns | 0.6375 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 0.7204 ns | 0.2873 ns | 0.0157 ns | 0.7164 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 1.7881 ns | 0.1849 ns | 0.0101 ns | 1.7906 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 1.0242 ns | 0.3957 ns | 0.0217 ns | 1.0189 ns |  0.57 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 2.1411 ns | 6.0652 ns | 0.3325 ns | 2.2951 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.2605 ns | 0.6350 ns | 0.0348 ns | 1.2554 ns |  0.60 |    0.12 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.9587 ns | 0.6822 ns | 0.0374 ns | 0.9739 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.9421 ns | 0.2560 ns | 0.0140 ns | 0.9377 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.4980 ns | 6.4168 ns | 0.3517 ns | 1.6997 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.2353 ns | 0.5159 ns | 0.0283 ns | 1.2219 ns |  0.86 |    0.23 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 1.9528 ns | 1.2966 ns | 0.0711 ns | 1.9183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 1.9412 ns | 0.3395 ns | 0.0186 ns | 1.9349 ns |  0.99 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 2.0169 ns | 2.5388 ns | 0.1392 ns | 2.0179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.8608 ns | 0.6012 ns | 0.0330 ns | 1.8745 ns |  0.93 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 1.6944 ns | 0.0339 ns | 0.0019 ns | 1.6940 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 2.1247 ns | 0.7514 ns | 0.0412 ns | 2.1111 ns |  1.25 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 2.0050 ns | 1.0719 ns | 0.0588 ns | 2.0136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.8675 ns | 0.6999 ns | 0.0384 ns | 1.8463 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 4.0830 ns | 0.9821 ns | 0.0538 ns | 4.0572 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 3.6228 ns | 1.0878 ns | 0.0596 ns | 3.5957 ns |  0.89 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.8424 ns | 1.3627 ns | 0.0747 ns | 1.8409 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.8005 ns | 0.6602 ns | 0.0362 ns | 1.8116 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 4.4168 ns | 1.6684 ns | 0.0915 ns | 4.4037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 3.2149 ns | 0.6942 ns | 0.0381 ns | 3.2189 ns |  0.73 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.0791 ns | 0.6665 ns | 0.0365 ns | 2.0620 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 2.0131 ns | 1.4368 ns | 0.0788 ns | 1.9820 ns |  0.97 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 7.3279 ns | 0.1382 ns | 0.0076 ns | 7.3264 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 9.1303 ns | 4.3458 ns | 0.2382 ns | 9.2249 ns |  1.25 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.6930 ns | 0.6945 ns | 0.0381 ns | 2.7023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.4150 ns | 0.1804 ns | 0.0099 ns | 2.4136 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7914 ns | 1.3258 ns | 0.0727 ns | 0.7957 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7946 ns | 0.3332 ns | 0.0183 ns | 0.8019 ns |  1.01 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 2.2595 ns | 6.8603 ns | 0.3760 ns | 2.4756 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.4370 ns | 0.8455 ns | 0.0463 ns | 1.4128 ns |  0.65 |    0.14 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.7403 ns | 0.2818 ns | 0.0154 ns | 2.7381 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.6407 ns | 0.1029 ns | 0.0056 ns | 2.6397 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 2.2364 ns | 1.0270 ns | 0.0563 ns | 2.2062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.8764 ns | 0.0589 ns | 0.0032 ns | 1.8764 ns |  0.84 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 1.7770 ns | 0.5685 ns | 0.0312 ns | 1.7600 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.9373 ns | 0.3580 ns | 0.0196 ns | 0.9273 ns |  0.53 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.7301 ns | 0.1701 ns | 0.0093 ns | 1.7285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.2192 ns | 0.2754 ns | 0.0151 ns | 1.2119 ns |  0.70 |    0.01 |     - |     - |     - |         - |
