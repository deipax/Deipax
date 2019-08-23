
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |   3.505 ns | 0.0293 ns | 0.0274 ns |   3.520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   3.469 ns | 0.0071 ns | 0.0066 ns |   3.469 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   3.429 ns | 0.0057 ns | 0.0044 ns |   3.430 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             FromBool |        net461 |   3.323 ns | 0.0030 ns | 0.0026 ns |   3.323 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             FromBool |        net472 |   3.323 ns | 0.0051 ns | 0.0048 ns |   3.323 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   2.250 ns | 0.0068 ns | 0.0064 ns |   2.250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   2.442 ns | 0.0763 ns | 0.1928 ns |   2.483 ns |  1.10 |    0.09 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   2.216 ns | 0.0026 ns | 0.0023 ns |   2.215 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable |        net461 |   1.977 ns | 0.0183 ns | 0.0171 ns |   1.985 ns |  0.88 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net472 |   1.950 ns | 0.0036 ns | 0.0034 ns |   1.949 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 |   5.016 ns | 0.0190 ns | 0.0178 ns |   5.004 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 2.2 |   4.965 ns | 0.0111 ns | 0.0103 ns |   4.963 ns |  0.99 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 3.0 |   4.394 ns | 0.0245 ns | 0.0217 ns |   4.401 ns |  0.88 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 |   6.610 ns | 0.0122 ns | 0.0114 ns |   6.608 ns |  1.32 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar |        net472 |   6.735 ns | 0.0602 ns | 0.0534 ns |   6.756 ns |  1.34 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 |   5.505 ns | 0.0303 ns | 0.0284 ns |   5.504 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromCharNullable | .NET Core 2.2 |   5.339 ns | 0.0106 ns | 0.0099 ns |   5.337 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromCharNullable | .NET Core 3.0 |   5.330 ns | 0.0335 ns | 0.0297 ns |   5.333 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
     FromCharNullable |        net461 |   7.456 ns | 0.0218 ns | 0.0193 ns |   7.452 ns |  1.35 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromCharNullable |        net472 |   7.452 ns | 0.0234 ns | 0.0219 ns |   7.445 ns |  1.35 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 |  29.479 ns | 0.0422 ns | 0.0395 ns |  29.483 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 2.2 |  18.013 ns | 0.0500 ns | 0.0443 ns |  18.016 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 3.0 |  13.870 ns | 0.0163 ns | 0.0136 ns |  13.876 ns |  0.47 |    0.00 |      - |     - |     - |         - |
            FromSByte |        net461 |  32.760 ns | 0.0409 ns | 0.0342 ns |  32.768 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte |        net472 |  32.341 ns | 0.0558 ns | 0.0466 ns |  32.344 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  30.225 ns | 0.1347 ns | 0.1194 ns |  30.200 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromSByteNullable | .NET Core 2.2 |  19.297 ns | 0.0281 ns | 0.0263 ns |  19.305 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromSByteNullable | .NET Core 3.0 |  14.217 ns | 0.0380 ns | 0.0337 ns |  14.218 ns |  0.47 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net461 |  32.527 ns | 0.0452 ns | 0.0423 ns |  32.537 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromSByteNullable |        net472 |  32.642 ns | 0.0746 ns | 0.0697 ns |  32.622 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 |  30.231 ns | 0.1335 ns | 0.1249 ns |  30.267 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 2.2 |  17.877 ns | 0.0293 ns | 0.0274 ns |  17.869 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 3.0 |  13.557 ns | 0.0835 ns | 0.0740 ns |  13.581 ns |  0.45 |    0.00 |      - |     - |     - |         - |
             FromByte |        net461 |  32.538 ns | 0.0556 ns | 0.0493 ns |  32.556 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromByte |        net472 |  32.619 ns | 0.0574 ns | 0.0537 ns |  32.606 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 |  30.287 ns | 0.0627 ns | 0.0523 ns |  30.290 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromByteNullable | .NET Core 2.2 |  19.164 ns | 0.0332 ns | 0.0277 ns |  19.160 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromByteNullable | .NET Core 3.0 |  13.563 ns | 0.0645 ns | 0.0604 ns |  13.538 ns |  0.45 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net461 |  33.380 ns | 0.2089 ns | 0.1954 ns |  33.410 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
     FromByteNullable |        net472 |  33.020 ns | 0.0423 ns | 0.0375 ns |  33.024 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 |  29.417 ns | 0.1122 ns | 0.1050 ns |  29.440 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 2.2 |  18.126 ns | 0.0174 ns | 0.0163 ns |  18.130 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 3.0 |  13.152 ns | 0.0185 ns | 0.0173 ns |  13.153 ns |  0.45 |    0.00 |      - |     - |     - |         - |
            FromShort |        net461 |  32.703 ns | 0.0370 ns | 0.0346 ns |  32.705 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort |        net472 |  32.422 ns | 0.0737 ns | 0.0690 ns |  32.434 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 |  29.876 ns | 0.0648 ns | 0.0575 ns |  29.874 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromShortNullable | .NET Core 2.2 |  18.634 ns | 0.0403 ns | 0.0357 ns |  18.631 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromShortNullable | .NET Core 3.0 |  14.275 ns | 0.1176 ns | 0.1100 ns |  14.230 ns |  0.48 |    0.00 |      - |     - |     - |         - |
    FromShortNullable |        net461 |  32.593 ns | 0.0480 ns | 0.0449 ns |  32.592 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromShortNullable |        net472 |  32.687 ns | 0.0514 ns | 0.0455 ns |  32.681 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 |  28.329 ns | 0.0439 ns | 0.0411 ns |  28.316 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 2.2 |  17.564 ns | 0.0259 ns | 0.0229 ns |  17.565 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 3.0 |  12.714 ns | 0.0169 ns | 0.0158 ns |  12.713 ns |  0.45 |    0.00 |      - |     - |     - |         - |
           FromUShort |        net461 |  31.447 ns | 0.2167 ns | 0.1921 ns |  31.502 ns |  1.11 |    0.01 | 0.0051 |     - |     - |      32 B |
           FromUShort |        net472 |  31.438 ns | 0.0368 ns | 0.0307 ns |  31.447 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  27.697 ns | 0.0492 ns | 0.0460 ns |  27.705 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
   FromUShortNullable | .NET Core 2.2 |  18.264 ns | 0.0362 ns | 0.0321 ns |  18.263 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
   FromUShortNullable | .NET Core 3.0 |  13.986 ns | 0.1646 ns | 0.1540 ns |  14.046 ns |  0.50 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable |        net461 |  32.440 ns | 0.0513 ns | 0.0455 ns |  32.442 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
   FromUShortNullable |        net472 |  32.166 ns | 0.0423 ns | 0.0396 ns |  32.171 ns |  1.16 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 |  29.280 ns | 0.0840 ns | 0.0744 ns |  29.268 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 2.2 |  17.943 ns | 0.0324 ns | 0.0303 ns |  17.943 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 3.0 |  13.093 ns | 0.0515 ns | 0.0482 ns |  13.089 ns |  0.45 |    0.00 |      - |     - |     - |         - |
              FromInt |        net461 |  31.768 ns | 0.0576 ns | 0.0539 ns |  31.751 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt |        net472 |  31.600 ns | 0.0515 ns | 0.0430 ns |  31.598 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 |  30.005 ns | 0.0357 ns | 0.0334 ns |  30.009 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
      FromIntNullable | .NET Core 2.2 |  18.502 ns | 0.0242 ns | 0.0226 ns |  18.497 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
      FromIntNullable | .NET Core 3.0 |  13.582 ns | 0.0482 ns | 0.0451 ns |  13.575 ns |  0.45 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net461 |  33.449 ns | 0.1567 ns | 0.1389 ns |  33.486 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
      FromIntNullable |        net472 |  33.231 ns | 0.0405 ns | 0.0359 ns |  33.232 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 |  27.369 ns | 0.0456 ns | 0.0426 ns |  27.353 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 2.2 |  17.656 ns | 0.0289 ns | 0.0256 ns |  17.654 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 3.0 |  12.252 ns | 0.0597 ns | 0.0558 ns |  12.269 ns |  0.45 |    0.00 |      - |     - |     - |         - |
             FromUInt |        net461 |  30.822 ns | 0.0530 ns | 0.0470 ns |  30.808 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt |        net472 |  31.021 ns | 0.0588 ns | 0.0522 ns |  31.022 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  28.488 ns | 0.0579 ns | 0.0513 ns |  28.480 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromUIntNullable | .NET Core 2.2 |  18.028 ns | 0.0346 ns | 0.0307 ns |  18.035 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromUIntNullable | .NET Core 3.0 |  13.367 ns | 0.0267 ns | 0.0250 ns |  13.360 ns |  0.47 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable |        net461 |  32.163 ns | 0.0470 ns | 0.0439 ns |  32.164 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromUIntNullable |        net472 |  32.510 ns | 0.0576 ns | 0.0538 ns |  32.500 ns |  1.14 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 |  32.800 ns | 0.0658 ns | 0.0583 ns |  32.788 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 2.2 |  19.333 ns | 0.0351 ns | 0.0329 ns |  19.330 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 3.0 |  14.243 ns | 0.0276 ns | 0.0244 ns |  14.244 ns |  0.43 |    0.00 |      - |     - |     - |         - |
             FromLong |        net461 |  34.595 ns | 0.1902 ns | 0.1686 ns |  34.657 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromLong |        net472 |  33.879 ns | 0.0701 ns | 0.0586 ns |  33.869 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 |  33.898 ns | 0.0567 ns | 0.0531 ns |  33.898 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromLongNullable | .NET Core 2.2 |  21.045 ns | 0.0316 ns | 0.0295 ns |  21.042 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromLongNullable | .NET Core 3.0 |  15.757 ns | 0.0281 ns | 0.0249 ns |  15.759 ns |  0.46 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net461 |  37.170 ns | 0.0580 ns | 0.0543 ns |  37.174 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
     FromLongNullable |        net472 |  34.413 ns | 0.0645 ns | 0.0571 ns |  34.422 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 |  31.092 ns | 0.0409 ns | 0.0383 ns |  31.084 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 2.2 |  19.482 ns | 0.0393 ns | 0.0367 ns |  19.490 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 3.0 |  12.970 ns | 0.2509 ns | 0.2347 ns |  12.798 ns |  0.42 |    0.01 |      - |     - |     - |         - |
            FromULong |        net461 |  32.075 ns | 0.0667 ns | 0.0624 ns |  32.082 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong |        net472 |  32.315 ns | 0.0380 ns | 0.0297 ns |  32.323 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 |  32.196 ns | 0.0865 ns | 0.0767 ns |  32.191 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromULongNullable | .NET Core 2.2 |  20.369 ns | 0.0216 ns | 0.0192 ns |  20.369 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
    FromULongNullable | .NET Core 3.0 |  14.597 ns | 0.0303 ns | 0.0284 ns |  14.603 ns |  0.45 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net461 |  34.110 ns | 0.1899 ns | 0.1776 ns |  34.178 ns |  1.06 |    0.01 | 0.0051 |     - |     - |      32 B |
    FromULongNullable |        net472 |  34.073 ns | 0.0587 ns | 0.0549 ns |  34.076 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 | 162.602 ns | 0.3370 ns | 0.3152 ns | 162.594 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat | .NET Core 2.2 | 105.701 ns | 0.3780 ns | 0.3351 ns | 105.784 ns |  0.65 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat | .NET Core 3.0 | 112.667 ns | 0.3814 ns | 0.3184 ns | 112.759 ns |  0.69 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 | 279.097 ns | 0.3406 ns | 0.3186 ns | 279.102 ns |  1.72 |    0.00 | 0.0048 |     - |     - |      32 B |
            FromFloat |        net472 | 279.374 ns | 0.3558 ns | 0.3328 ns | 279.371 ns |  1.72 |    0.00 | 0.0048 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 164.185 ns | 0.3249 ns | 0.3040 ns | 164.188 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
    FromFloatNullable | .NET Core 2.2 | 103.739 ns | 0.1464 ns | 0.1370 ns | 103.704 ns |  0.63 |    0.00 | 0.0050 |     - |     - |      32 B |
    FromFloatNullable | .NET Core 3.0 | 110.449 ns | 0.1083 ns | 0.1013 ns | 110.449 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
    FromFloatNullable |        net461 | 279.133 ns | 0.3199 ns | 0.2992 ns | 279.255 ns |  1.70 |    0.00 | 0.0048 |     - |     - |      32 B |
    FromFloatNullable |        net472 | 280.024 ns | 0.4570 ns | 0.3816 ns | 279.936 ns |  1.71 |    0.00 | 0.0048 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 191.558 ns | 0.5833 ns | 0.5171 ns | 191.388 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble | .NET Core 2.2 | 107.761 ns | 0.1670 ns | 0.1562 ns | 107.790 ns |  0.56 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble | .NET Core 3.0 | 110.611 ns | 0.1561 ns | 0.1460 ns | 110.639 ns |  0.58 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 304.412 ns | 2.5567 ns | 2.3915 ns | 304.967 ns |  1.59 |    0.01 | 0.0048 |     - |     - |      32 B |
           FromDouble |        net472 | 296.121 ns | 0.4460 ns | 0.3954 ns | 296.189 ns |  1.55 |    0.00 | 0.0048 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 190.566 ns | 0.2762 ns | 0.2584 ns | 190.518 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
   FromDoubleNullable | .NET Core 2.2 | 111.313 ns | 0.1589 ns | 0.1409 ns | 111.298 ns |  0.58 |    0.00 | 0.0050 |     - |     - |      32 B |
   FromDoubleNullable | .NET Core 3.0 | 112.012 ns | 0.2181 ns | 0.1933 ns | 112.041 ns |  0.59 |    0.00 | 0.0038 |     - |     - |      24 B |
   FromDoubleNullable |        net461 | 296.908 ns | 0.4687 ns | 0.4155 ns | 296.852 ns |  1.56 |    0.00 | 0.0048 |     - |     - |      32 B |
   FromDoubleNullable |        net472 | 297.306 ns | 0.3232 ns | 0.3023 ns | 297.417 ns |  1.56 |    0.00 | 0.0048 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 |  55.468 ns | 0.0717 ns | 0.0636 ns |  55.457 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 |  48.768 ns | 0.0634 ns | 0.0562 ns |  48.753 ns |  0.88 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 |  49.984 ns | 0.1710 ns | 0.1600 ns |  49.960 ns |  0.90 |    0.00 | 0.0038 |     - |     - |      24 B |
          FromDecimal |        net461 |  51.792 ns | 0.0520 ns | 0.0461 ns |  51.788 ns |  0.93 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 |  51.978 ns | 0.0804 ns | 0.0752 ns |  51.935 ns |  0.94 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  57.165 ns | 0.1700 ns | 0.1420 ns |  57.198 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
  FromDecimalNullable | .NET Core 2.2 |  49.669 ns | 0.0825 ns | 0.0772 ns |  49.693 ns |  0.87 |    0.00 | 0.0051 |     - |     - |      32 B |
  FromDecimalNullable | .NET Core 3.0 |  50.352 ns | 0.0700 ns | 0.0621 ns |  50.338 ns |  0.88 |    0.00 | 0.0038 |     - |     - |      24 B |
  FromDecimalNullable |        net461 |  57.506 ns | 0.0980 ns | 0.0917 ns |  57.522 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
  FromDecimalNullable |        net472 |  57.028 ns | 0.0787 ns | 0.0698 ns |  57.021 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 323.422 ns | 0.6740 ns | 0.6305 ns | 323.262 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 2.2 | 276.059 ns | 0.3424 ns | 0.3203 ns | 275.973 ns |  0.85 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 3.0 | 221.440 ns | 0.2594 ns | 0.2427 ns | 221.376 ns |  0.68 |    0.00 | 0.0100 |     - |     - |      64 B |
         FromDateTime |        net461 | 323.089 ns | 0.6302 ns | 0.5895 ns | 323.116 ns |  1.00 |    0.00 | 0.0300 |     - |     - |     192 B |
         FromDateTime |        net472 | 326.401 ns | 0.7598 ns | 0.6735 ns | 326.295 ns |  1.01 |    0.00 | 0.0300 |     - |     - |     192 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   3.438 ns | 0.0063 ns | 0.0059 ns |   3.438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   2.671 ns | 0.0091 ns | 0.0085 ns |   2.673 ns |  0.78 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   3.023 ns | 0.0065 ns | 0.0060 ns |   3.025 ns |  0.88 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   2.960 ns | 0.0075 ns | 0.0071 ns |   2.961 ns |  0.86 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   2.991 ns | 0.0202 ns | 0.0189 ns |   2.995 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 |   2.623 ns | 0.0065 ns | 0.0058 ns |   2.621 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 |   2.140 ns | 0.0028 ns | 0.0027 ns |   2.141 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 |   2.045 ns | 0.0137 ns | 0.0115 ns |   2.049 ns |  0.78 |    0.00 |      - |     - |     - |         - |
           FromObject |        net461 |   2.765 ns | 0.0055 ns | 0.0052 ns |   2.767 ns |  1.05 |    0.00 |      - |     - |     - |         - |
           FromObject |        net472 |   2.814 ns | 0.0051 ns | 0.0048 ns |   2.814 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromString | .NET Core 2.0 |   1.875 ns | 0.0043 ns | 0.0040 ns |   1.875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 |   1.604 ns | 0.0032 ns | 0.0029 ns |   1.605 ns |  0.86 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 |   1.507 ns | 0.0030 ns | 0.0028 ns |   1.506 ns |  0.80 |    0.00 |      - |     - |     - |         - |
           FromString |        net461 |   1.591 ns | 0.0030 ns | 0.0027 ns |   1.591 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           FromString |        net472 |   1.879 ns | 0.0030 ns | 0.0025 ns |   1.879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 |  25.402 ns | 0.0295 ns | 0.0276 ns |  25.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  26.318 ns | 0.0278 ns | 0.0260 ns |  26.320 ns |  1.04 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  23.115 ns | 0.0220 ns | 0.0206 ns |  23.117 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             FromEnum |        net461 |  31.134 ns | 0.0560 ns | 0.0524 ns |  31.121 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             FromEnum |        net472 |  30.755 ns | 0.0363 ns | 0.0322 ns |  30.757 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  26.347 ns | 0.1511 ns | 0.1413 ns |  26.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  26.621 ns | 0.0237 ns | 0.0221 ns |  26.620 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  23.763 ns | 0.0912 ns | 0.0808 ns |  23.790 ns |  0.90 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable |        net461 |  31.855 ns | 0.0372 ns | 0.0329 ns |  31.856 ns |  1.21 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable |        net472 |  31.592 ns | 0.0363 ns | 0.0340 ns |  31.597 ns |  1.20 |    0.01 |      - |     - |     - |         - |
