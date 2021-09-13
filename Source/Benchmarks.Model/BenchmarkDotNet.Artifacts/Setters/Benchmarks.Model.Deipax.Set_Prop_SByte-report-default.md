
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9706 ns |  0.1643 ns | 0.0090 ns |  0.9705 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.2211 ns |  0.1350 ns | 0.0074 ns |  1.2229 ns |  1.26 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.0118 ns |  0.0459 ns | 0.0025 ns |  1.0111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.3050 ns |  0.1526 ns | 0.0084 ns |  1.3093 ns |  1.29 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.5531 ns |  0.3716 ns | 0.0204 ns |  0.5472 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.5354 ns |  0.2042 ns | 0.0112 ns |  0.5311 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.1156 ns |  0.5114 ns | 0.0280 ns |  1.1111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.0521 ns |  0.1509 ns | 0.0083 ns |  1.0502 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.5325 ns |  0.3216 ns | 0.0176 ns |  0.5396 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7735 ns |  0.1468 ns | 0.0080 ns |  0.7742 ns |  1.45 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  0.8505 ns |  0.1304 ns | 0.0071 ns |  0.8486 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.0531 ns |  0.2135 ns | 0.0117 ns |  1.0592 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.5487 ns |  0.2173 ns | 0.0119 ns |  0.5423 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7802 ns |  0.3747 ns | 0.0205 ns |  0.7848 ns |  1.42 |    0.07 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.0663 ns |  0.6056 ns | 0.0332 ns |  1.0584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.3125 ns |  0.1998 ns | 0.0110 ns |  1.3132 ns |  1.23 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  2.0052 ns |  2.2691 ns | 0.1244 ns |  1.9346 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  2.0425 ns |  0.1464 ns | 0.0080 ns |  2.0461 ns |  1.02 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  2.2821 ns |  0.7752 ns | 0.0425 ns |  2.2623 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  2.5398 ns |  4.7265 ns | 0.2591 ns |  2.4111 ns |  1.11 |    0.13 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.7890 ns |  0.2374 ns | 0.0130 ns |  0.7888 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.9705 ns |  0.2694 ns | 0.0148 ns |  0.9702 ns |  1.23 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.2256 ns |  3.7388 ns | 0.2049 ns |  1.1896 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.0608 ns |  2.9012 ns | 0.1590 ns |  1.0051 ns |  0.87 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  1.6398 ns |  0.2337 ns | 0.0128 ns |  1.6346 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  1.7853 ns |  0.0999 ns | 0.0055 ns |  1.7842 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  2.0589 ns |  0.2040 ns | 0.0112 ns |  2.0625 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  2.5273 ns |  3.6912 ns | 0.2023 ns |  2.4115 ns |  1.23 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  1.2340 ns |  0.1174 ns | 0.0064 ns |  1.2304 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  1.0247 ns |  0.3751 ns | 0.0206 ns |  1.0171 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.2265 ns |  0.4450 ns | 0.0244 ns |  1.2157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.2492 ns |  0.1392 ns | 0.0076 ns |  1.2495 ns |  1.02 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.7273 ns |  1.6453 ns | 0.0902 ns |  1.6978 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  2.1114 ns |  1.7559 ns | 0.0962 ns |  2.1057 ns |  1.22 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.3071 ns |  1.0559 ns | 0.0579 ns |  3.2919 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  2.7740 ns |  0.6856 ns | 0.0376 ns |  2.7923 ns |  0.84 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.7004 ns |  0.3438 ns | 0.0188 ns |  0.6997 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.8147 ns |  0.1355 ns | 0.0074 ns |  0.8160 ns |  1.16 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.9313 ns |  0.3921 ns | 0.0215 ns |  1.9361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.5268 ns |  0.0451 ns | 0.0025 ns |  1.5273 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.4439 ns |  0.4748 ns | 0.0260 ns |  4.4384 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  4.8176 ns |  0.6839 ns | 0.0375 ns |  4.8269 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  4.4642 ns |  0.7490 ns | 0.0411 ns |  4.4518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  6.0996 ns | 13.8126 ns | 0.7571 ns |  5.8018 ns |  1.37 |    0.18 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  4.2046 ns |  0.2181 ns | 0.0120 ns |  4.2065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  4.9372 ns |  0.9100 ns | 0.0499 ns |  4.9397 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  5.8828 ns |  1.2929 ns | 0.0709 ns |  5.8688 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  5.7017 ns |  6.2669 ns | 0.3435 ns |  5.5284 ns |  0.97 |    0.07 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  7.2567 ns |  0.2219 ns | 0.0122 ns |  7.2628 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  9.3040 ns |  0.1806 ns | 0.0099 ns |  9.3009 ns |  1.28 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 13.6615 ns |  1.1151 ns | 0.0611 ns | 13.6594 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 10.2328 ns |  1.3990 ns | 0.0767 ns | 10.2114 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.7204 ns |  0.7857 ns | 0.0431 ns |  0.6997 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7399 ns |  0.6790 ns | 0.0372 ns |  0.7349 ns |  1.03 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5424 ns |  0.2461 ns | 0.0135 ns |  1.5367 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2832 ns |  0.2414 ns | 0.0132 ns |  1.2790 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.4580 ns |  5.9897 ns | 0.3283 ns |  2.3352 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.1882 ns |  0.3497 ns | 0.0192 ns |  2.1791 ns |  0.90 |    0.11 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  9.4846 ns |  0.7269 ns | 0.0398 ns |  9.5025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  8.2511 ns |  0.8347 ns | 0.0458 ns |  8.2322 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  1.7654 ns |  0.7258 ns | 0.0398 ns |  1.7753 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  1.8178 ns |  0.0914 ns | 0.0050 ns |  1.8197 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.9930 ns |  0.0440 ns | 0.0024 ns |  1.9933 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  2.9442 ns |  0.5648 ns | 0.0310 ns |  2.9332 ns |  1.48 |    0.02 |     - |     - |     - |         - |
