
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  8.5189 ns |  6.6667 ns | 0.3654 ns |  8.3157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  7.7402 ns |  2.2410 ns | 0.1228 ns |  7.6817 ns |  0.91 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  8.6452 ns |  0.9233 ns | 0.0506 ns |  8.6183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  8.0705 ns |  0.2145 ns | 0.0118 ns |  8.0667 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  8.5520 ns |  3.3494 ns | 0.1836 ns |  8.4781 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  7.6009 ns |  0.4550 ns | 0.0249 ns |  7.6096 ns |  0.89 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  8.6467 ns |  0.6797 ns | 0.0373 ns |  8.6518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  8.1298 ns |  0.0744 ns | 0.0041 ns |  8.1308 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  8.2227 ns |  0.3020 ns | 0.0166 ns |  8.2208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  7.5955 ns |  0.6252 ns | 0.0343 ns |  7.6072 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  8.6799 ns |  0.4841 ns | 0.0265 ns |  8.6667 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  8.0946 ns |  0.4092 ns | 0.0224 ns |  8.1031 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  8.2480 ns |  0.3475 ns | 0.0190 ns |  8.2587 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  7.5597 ns |  1.1700 ns | 0.0641 ns |  7.5238 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  8.7055 ns |  0.4321 ns | 0.0237 ns |  8.7132 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  8.0563 ns |  1.0752 ns | 0.0589 ns |  8.0296 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  8.1884 ns |  0.3013 ns | 0.0165 ns |  8.1939 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  7.5349 ns |  0.3673 ns | 0.0201 ns |  7.5330 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  8.6527 ns |  0.5381 ns | 0.0295 ns |  8.6614 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  8.1363 ns |  2.5338 ns | 0.1389 ns |  8.0805 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  8.3258 ns |  0.4172 ns | 0.0229 ns |  8.3283 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  7.4971 ns |  0.4147 ns | 0.0227 ns |  7.4992 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  8.7473 ns |  0.8050 ns | 0.0441 ns |  8.7423 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  8.0768 ns |  0.7485 ns | 0.0410 ns |  8.0537 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  8.0238 ns |  0.5515 ns | 0.0302 ns |  8.0349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  7.5807 ns |  0.1883 ns | 0.0103 ns |  7.5837 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  8.6162 ns |  3.5434 ns | 0.1942 ns |  8.5386 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  8.1224 ns |  0.4899 ns | 0.0269 ns |  8.1324 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  8.1204 ns |  2.7538 ns | 0.1509 ns |  8.0382 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  7.3513 ns |  0.1640 ns | 0.0090 ns |  7.3477 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  8.4684 ns |  0.4667 ns | 0.0256 ns |  8.4681 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  7.8177 ns |  0.7324 ns | 0.0401 ns |  7.8360 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  8.4901 ns |  0.6276 ns | 0.0344 ns |  8.5003 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  8.1060 ns |  0.9889 ns | 0.0542 ns |  8.0897 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  9.7286 ns |  0.3549 ns | 0.0195 ns |  9.7291 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  9.4305 ns |  5.2868 ns | 0.2898 ns |  9.2988 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  8.3727 ns |  0.6891 ns | 0.0378 ns |  8.3810 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  8.1551 ns |  0.4668 ns | 0.0256 ns |  8.1509 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  9.6242 ns |  1.3181 ns | 0.0722 ns |  9.5912 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  9.3150 ns |  0.9061 ns | 0.0497 ns |  9.3022 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 10.3958 ns |  1.2084 ns | 0.0662 ns | 10.3695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 10.1562 ns |  1.8369 ns | 0.1007 ns | 10.1766 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 10.8483 ns |  1.7836 ns | 0.0978 ns | 10.8317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 11.5129 ns | 15.5697 ns | 0.8534 ns | 11.5197 ns |  1.06 |    0.08 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 11.9251 ns | 18.6992 ns | 1.0250 ns | 12.1198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  9.8391 ns |  0.0893 ns | 0.0049 ns |  9.8417 ns |  0.83 |    0.07 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 11.4814 ns |  0.9784 ns | 0.0536 ns | 11.4650 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 10.9497 ns |  0.8883 ns | 0.0487 ns | 10.9378 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 13.9608 ns |  4.8409 ns | 0.2653 ns | 14.0535 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 15.8753 ns |  1.3648 ns | 0.0748 ns | 15.8574 ns |  1.14 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 24.1743 ns |  1.7322 ns | 0.0949 ns | 24.1893 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 16.6663 ns |  0.3084 ns | 0.0169 ns | 16.6704 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  6.9624 ns |  0.4641 ns | 0.0254 ns |  6.9545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  3.5398 ns |  0.6294 ns | 0.0345 ns |  3.5529 ns |  0.51 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  2.1417 ns |  0.3049 ns | 0.0167 ns |  2.1391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.9259 ns |  0.9946 ns | 0.0545 ns |  1.9025 ns |  0.90 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.1070 ns |  1.3378 ns | 0.0733 ns |  2.1019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.1368 ns |  1.2584 ns | 0.0690 ns |  2.1691 ns |  1.01 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 17.0414 ns |  0.3808 ns | 0.0209 ns | 17.0340 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 15.0770 ns |  6.0706 ns | 0.3328 ns | 15.2629 ns |  0.88 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.6784 ns |  0.3025 ns | 0.0166 ns |  0.6727 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.4871 ns |  0.1643 ns | 0.0090 ns |  0.4921 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  0.9858 ns |  0.3823 ns | 0.0210 ns |  0.9912 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  0.9830 ns |  0.1301 ns | 0.0071 ns |  0.9838 ns |  1.00 |    0.02 |     - |     - |     - |         - |
