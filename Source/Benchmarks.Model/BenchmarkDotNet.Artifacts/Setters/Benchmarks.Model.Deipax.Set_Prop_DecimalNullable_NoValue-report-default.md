
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 11.8311 ns | 1.0526 ns | 0.0577 ns | 11.8130 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  6.8873 ns | 5.6192 ns | 0.3080 ns |  6.7117 ns |  0.58 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.8469 ns | 1.0818 ns | 0.0593 ns |  1.8129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.7005 ns | 0.2937 ns | 0.0161 ns |  1.6993 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.8114 ns | 2.5292 ns | 0.1386 ns |  0.7976 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7169 ns | 0.4083 ns | 0.0224 ns |  0.7259 ns |  0.90 |    0.17 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.8429 ns | 0.1625 ns | 0.0089 ns |  0.8417 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.9624 ns | 0.7542 ns | 0.0413 ns |  0.9412 ns |  1.14 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 11.5255 ns | 1.6833 ns | 0.0923 ns | 11.5363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  6.5485 ns | 1.5066 ns | 0.0826 ns |  6.5151 ns |  0.57 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.7892 ns | 0.7808 ns | 0.0428 ns |  1.7755 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.6257 ns | 1.4180 ns | 0.0777 ns |  1.5899 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 11.5748 ns | 0.5132 ns | 0.0281 ns | 11.5742 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  6.0582 ns | 0.4491 ns | 0.0246 ns |  6.0476 ns |  0.52 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.8436 ns | 4.3918 ns | 0.2407 ns |  1.7109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.5765 ns | 0.3021 ns | 0.0166 ns |  1.5715 ns |  0.86 |    0.11 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 11.8346 ns | 0.3813 ns | 0.0209 ns | 11.8256 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  6.6628 ns | 4.7932 ns | 0.2627 ns |  6.5125 ns |  0.56 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.9214 ns | 1.8038 ns | 0.0989 ns |  1.8732 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  2.0141 ns | 0.9602 ns | 0.0526 ns |  2.0297 ns |  1.05 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 11.7750 ns | 0.6933 ns | 0.0380 ns | 11.7910 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  6.2237 ns | 4.1976 ns | 0.2301 ns |  6.1557 ns |  0.53 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.9603 ns | 2.0280 ns | 0.1112 ns |  1.9856 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.7983 ns | 0.6987 ns | 0.0383 ns |  1.7798 ns |  0.92 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 11.8050 ns | 0.6563 ns | 0.0360 ns | 11.8181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  6.8876 ns | 4.9710 ns | 0.2725 ns |  6.9675 ns |  0.58 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.8621 ns | 0.4444 ns | 0.0244 ns |  1.8484 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.7479 ns | 0.3527 ns | 0.0193 ns |  1.7398 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 11.8981 ns | 1.1036 ns | 0.0605 ns | 11.8926 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  6.0760 ns | 0.4768 ns | 0.0261 ns |  6.0821 ns |  0.51 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.9321 ns | 1.1640 ns | 0.0638 ns |  1.9133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.7503 ns | 0.4284 ns | 0.0235 ns |  1.7429 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 12.3769 ns | 1.4525 ns | 0.0796 ns | 12.3867 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  6.4063 ns | 0.2549 ns | 0.0140 ns |  6.4082 ns |  0.52 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  2.0607 ns | 0.0933 ns | 0.0051 ns |  2.0620 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  2.0433 ns | 0.1356 ns | 0.0074 ns |  2.0393 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 11.8251 ns | 0.5517 ns | 0.0302 ns | 11.8230 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  6.3241 ns | 4.4453 ns | 0.2437 ns |  6.4414 ns |  0.53 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  2.0332 ns | 0.0698 ns | 0.0038 ns |  2.0342 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  2.1663 ns | 1.6345 ns | 0.0896 ns |  2.1623 ns |  1.07 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  8.9802 ns | 1.0168 ns | 0.0557 ns |  8.9738 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  8.6444 ns | 2.1735 ns | 0.1191 ns |  8.6767 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  2.2125 ns | 0.6801 ns | 0.0373 ns |  2.1987 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  2.2617 ns | 1.0447 ns | 0.0573 ns |  2.2772 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  8.7881 ns | 0.2359 ns | 0.0129 ns |  8.7884 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  8.5051 ns | 1.4892 ns | 0.0816 ns |  8.5161 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  2.6134 ns | 0.7656 ns | 0.0420 ns |  2.5901 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  2.3998 ns | 1.4114 ns | 0.0774 ns |  2.3929 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  5.8019 ns | 0.1120 ns | 0.0061 ns |  5.8054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  5.6296 ns | 0.5300 ns | 0.0291 ns |  5.6387 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |  1.4793 ns | 0.2348 ns | 0.0129 ns |  1.4723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  1.3245 ns | 0.3299 ns | 0.0181 ns |  1.3248 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.8093 ns | 0.4034 ns | 0.0221 ns |  0.8207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7185 ns | 0.2342 ns | 0.0128 ns |  0.7228 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5223 ns | 0.0840 ns | 0.0046 ns |  1.5216 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2289 ns | 0.1256 ns | 0.0069 ns |  1.2250 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  8.8671 ns | 0.1439 ns | 0.0079 ns |  8.8693 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  3.5148 ns | 5.0273 ns | 0.2756 ns |  3.3598 ns |  0.40 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  2.0200 ns | 0.7220 ns | 0.0396 ns |  2.0337 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  2.0585 ns | 0.4452 ns | 0.0244 ns |  2.0586 ns |  1.02 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 11.9215 ns | 3.4384 ns | 0.1885 ns | 11.8404 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  6.4784 ns | 0.3282 ns | 0.0180 ns |  6.4766 ns |  0.54 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.9068 ns | 0.0606 ns | 0.0033 ns |  1.9078 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.7643 ns | 1.2229 ns | 0.0670 ns |  1.7294 ns |  0.93 |    0.03 |     - |     - |     - |         - |
