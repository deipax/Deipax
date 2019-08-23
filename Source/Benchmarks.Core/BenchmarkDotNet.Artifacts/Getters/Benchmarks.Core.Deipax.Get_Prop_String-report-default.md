
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
             ToBool |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
             ToBool |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  2.8391 ns | 0.0054 ns | 0.0050 ns |  2.8403 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.7263 ns | 0.0149 ns | 0.0139 ns |  2.7205 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  3.4089 ns | 0.0075 ns | 0.0070 ns |  3.4072 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  2.5199 ns | 0.0069 ns | 0.0061 ns |  2.5204 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  2.6614 ns | 0.0077 ns | 0.0069 ns |  2.6602 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.5852 ns | 0.0090 ns | 0.0084 ns |  5.5825 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.5868 ns | 0.0403 ns | 0.0357 ns |  5.5752 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  5.3811 ns | 0.0080 ns | 0.0074 ns |  5.3800 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  5.5594 ns | 0.0116 ns | 0.0103 ns |  5.5583 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  5.5487 ns | 0.0055 ns | 0.0051 ns |  5.5483 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 | 48.1403 ns | 0.0702 ns | 0.0656 ns | 48.1282 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 43.3637 ns | 0.2534 ns | 0.2370 ns | 43.4910 ns |  0.90 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  9.4604 ns | 0.0223 ns | 0.0208 ns |  9.4573 ns |  0.20 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 | 45.3130 ns | 0.1103 ns | 0.1031 ns | 45.2777 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 | 45.7052 ns | 0.2024 ns | 0.1894 ns | 45.6099 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 59.1424 ns | 0.0470 ns | 0.0440 ns | 59.1640 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 49.0879 ns | 0.0601 ns | 0.0562 ns | 49.0876 ns |  0.83 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 | 11.6693 ns | 0.0414 ns | 0.0367 ns | 11.6753 ns |  0.20 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 | 47.0143 ns | 0.1144 ns | 0.1070 ns | 47.0192 ns |  0.79 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 | 46.2482 ns | 0.0592 ns | 0.0554 ns | 46.2523 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 | 47.0125 ns | 0.2887 ns | 0.2701 ns | 46.8418 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 42.4886 ns | 0.0662 ns | 0.0517 ns | 42.4871 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  9.3451 ns | 0.0340 ns | 0.0301 ns |  9.3445 ns |  0.20 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 | 44.5913 ns | 0.1150 ns | 0.1076 ns | 44.5518 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 | 45.0810 ns | 0.0513 ns | 0.0480 ns | 45.0827 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 | 47.6518 ns | 0.0802 ns | 0.0750 ns | 47.6502 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 49.1489 ns | 0.0581 ns | 0.0485 ns | 49.1575 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 | 11.3484 ns | 0.0157 ns | 0.0139 ns | 11.3478 ns |  0.24 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 | 45.0823 ns | 0.0856 ns | 0.0801 ns | 45.0788 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 | 45.5044 ns | 0.0591 ns | 0.0524 ns | 45.4958 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 | 47.7460 ns | 0.1514 ns | 0.1416 ns | 47.7245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 42.9521 ns | 0.0628 ns | 0.0587 ns | 42.9771 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  9.7164 ns | 0.0119 ns | 0.0099 ns |  9.7197 ns |  0.20 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 | 44.7350 ns | 0.0553 ns | 0.0517 ns | 44.7423 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 | 44.9297 ns | 0.0876 ns | 0.0777 ns | 44.9106 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 | 59.4374 ns | 0.0816 ns | 0.0764 ns | 59.4220 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 48.6805 ns | 0.0619 ns | 0.0579 ns | 48.6807 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 | 11.5484 ns | 0.0149 ns | 0.0124 ns | 11.5483 ns |  0.19 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 | 45.2560 ns | 0.1296 ns | 0.1213 ns | 45.2994 ns |  0.76 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 | 45.5435 ns | 0.1367 ns | 0.1279 ns | 45.5749 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 | 47.8451 ns | 0.0728 ns | 0.0681 ns | 47.8457 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 40.8502 ns | 0.0421 ns | 0.0373 ns | 40.8496 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  9.2603 ns | 0.0341 ns | 0.0319 ns |  9.2597 ns |  0.19 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 | 46.0090 ns | 0.0405 ns | 0.0338 ns | 46.0109 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 | 46.1656 ns | 0.1204 ns | 0.1126 ns | 46.1914 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 48.4124 ns | 0.2392 ns | 0.2238 ns | 48.3154 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 47.1059 ns | 0.0530 ns | 0.0496 ns | 47.1183 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 | 11.4289 ns | 0.0136 ns | 0.0128 ns | 11.4243 ns |  0.24 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 | 45.9256 ns | 0.0566 ns | 0.0502 ns | 45.9381 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 | 46.2713 ns | 0.0753 ns | 0.0668 ns | 46.2745 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 | 57.1817 ns | 0.0294 ns | 0.0245 ns | 57.1750 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 42.1343 ns | 0.0862 ns | 0.0764 ns | 42.1520 ns |  0.74 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 | 11.8065 ns | 0.0141 ns | 0.0132 ns | 11.8078 ns |  0.21 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 | 43.4120 ns | 0.0694 ns | 0.0649 ns | 43.4096 ns |  0.76 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 | 43.5052 ns | 0.0723 ns | 0.0677 ns | 43.5251 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 | 45.8050 ns | 0.0931 ns | 0.0825 ns | 45.8008 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 47.7868 ns | 0.0796 ns | 0.0665 ns | 47.7731 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 | 12.7575 ns | 0.0105 ns | 0.0093 ns | 12.7563 ns |  0.28 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 | 44.6440 ns | 0.1579 ns | 0.1400 ns | 44.6366 ns |  0.97 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 | 44.7860 ns | 0.1625 ns | 0.1520 ns | 44.8360 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 | 46.7927 ns | 0.0497 ns | 0.0465 ns | 46.7847 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 40.1213 ns | 0.0660 ns | 0.0585 ns | 40.1296 ns |  0.86 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 | 11.7091 ns | 0.0108 ns | 0.0096 ns | 11.7105 ns |  0.25 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 | 44.8799 ns | 0.0794 ns | 0.0704 ns | 44.8692 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 | 45.0299 ns | 0.0955 ns | 0.0894 ns | 45.0377 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 47.5403 ns | 0.0373 ns | 0.0311 ns | 47.5319 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 46.4507 ns | 0.0451 ns | 0.0421 ns | 46.4480 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 | 12.7602 ns | 0.0125 ns | 0.0104 ns | 12.7586 ns |  0.27 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 | 44.8071 ns | 0.0744 ns | 0.0659 ns | 44.7977 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 | 44.9610 ns | 0.1138 ns | 0.1064 ns | 44.9346 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 | 48.2725 ns | 0.0736 ns | 0.0689 ns | 48.2672 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 40.4527 ns | 0.0490 ns | 0.0458 ns | 40.4546 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 | 11.1544 ns | 0.0268 ns | 0.0251 ns | 11.1536 ns |  0.23 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 | 46.1913 ns | 0.0583 ns | 0.0545 ns | 46.1814 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 | 46.5583 ns | 0.0466 ns | 0.0436 ns | 46.5629 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 | 49.8459 ns | 0.2627 ns | 0.2457 ns | 49.9302 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 | 41.5929 ns | 0.1200 ns | 0.1122 ns | 41.5870 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 | 11.9930 ns | 0.0100 ns | 0.0084 ns | 11.9893 ns |  0.24 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 | 47.8229 ns | 0.0696 ns | 0.0651 ns | 47.8199 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 | 47.8581 ns | 0.0357 ns | 0.0316 ns | 47.8522 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 | 46.0096 ns | 0.0860 ns | 0.0762 ns | 46.0190 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 40.3892 ns | 0.0379 ns | 0.0296 ns | 40.3874 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 | 10.5861 ns | 0.0264 ns | 0.0247 ns | 10.5845 ns |  0.23 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 | 45.1231 ns | 0.0568 ns | 0.0531 ns | 45.1332 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 | 45.5114 ns | 0.0663 ns | 0.0620 ns | 45.5156 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 | 47.5585 ns | 0.0841 ns | 0.0787 ns | 47.5583 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 | 42.3696 ns | 0.0861 ns | 0.0719 ns | 42.3569 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 | 12.2108 ns | 0.0240 ns | 0.0224 ns | 12.2096 ns |  0.26 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 | 46.1214 ns | 0.1713 ns | 0.1602 ns | 46.1233 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 | 46.4519 ns | 0.1281 ns | 0.1198 ns | 46.4611 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 | 57.6540 ns | 0.0458 ns | 0.0428 ns | 57.6657 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 60.9509 ns | 0.1137 ns | 0.0949 ns | 60.9403 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 | 45.3549 ns | 0.0552 ns | 0.0461 ns | 45.3409 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 | 58.2218 ns | 0.0541 ns | 0.0506 ns | 58.2173 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 | 58.9998 ns | 0.0794 ns | 0.0743 ns | 58.9818 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 58.5590 ns | 0.1266 ns | 0.1184 ns | 58.5428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 66.6458 ns | 0.0964 ns | 0.0901 ns | 66.6292 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 | 44.5284 ns | 0.0432 ns | 0.0405 ns | 44.5337 ns |  0.76 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 | 59.5135 ns | 0.1051 ns | 0.0931 ns | 59.5402 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 | 59.2828 ns | 0.0933 ns | 0.0779 ns | 59.2772 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 | 58.8153 ns | 0.2029 ns | 0.1695 ns | 58.8760 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 | 61.8693 ns | 0.0654 ns | 0.0579 ns | 61.8712 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 | 46.0173 ns | 0.0520 ns | 0.0461 ns | 46.0197 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 | 56.9345 ns | 0.1085 ns | 0.1015 ns | 56.8789 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 | 57.1076 ns | 0.0527 ns | 0.0493 ns | 57.0987 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 | 58.9249 ns | 0.0910 ns | 0.0851 ns | 58.9142 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 | 62.1101 ns | 0.0809 ns | 0.0718 ns | 62.1344 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 | 44.9590 ns | 0.0408 ns | 0.0362 ns | 44.9621 ns |  0.76 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 | 58.4963 ns | 0.1166 ns | 0.1090 ns | 58.4845 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 | 58.5217 ns | 0.1032 ns | 0.0966 ns | 58.5248 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 | 70.0321 ns | 0.0623 ns | 0.0583 ns | 69.9979 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 | 64.4086 ns | 0.0807 ns | 0.0755 ns | 64.4005 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 | 43.6488 ns | 0.0646 ns | 0.0604 ns | 43.6438 ns |  0.62 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 | 71.8530 ns | 0.1166 ns | 0.1091 ns | 71.8356 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net472 | 71.7916 ns | 0.4081 ns | 0.3817 ns | 71.5907 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 77.5850 ns | 0.1176 ns | 0.1043 ns | 77.5845 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 72.2510 ns | 0.0725 ns | 0.0678 ns | 72.2427 ns |  0.93 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 49.0808 ns | 0.1347 ns | 0.1124 ns | 49.0652 ns |  0.63 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 79.2435 ns | 0.1377 ns | 0.1288 ns | 79.2427 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 79.6642 ns | 0.1231 ns | 0.1151 ns | 79.6584 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |         NA |        NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  2.1401 ns | 0.0047 ns | 0.0044 ns |  2.1389 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  0.9531 ns | 0.0024 ns | 0.0022 ns |  0.9531 ns |  0.45 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  0.9555 ns | 0.0052 ns | 0.0046 ns |  0.9539 ns |  0.45 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  1.6651 ns | 0.0046 ns | 0.0043 ns |  1.6662 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  1.9494 ns | 0.0020 ns | 0.0019 ns |  1.9498 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  0.9235 ns | 0.0035 ns | 0.0032 ns |  0.9239 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  0.9547 ns | 0.0136 ns | 0.0120 ns |  0.9592 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.0983 ns | 0.0020 ns | 0.0019 ns |  1.0983 ns |  1.19 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  0.4367 ns | 0.0011 ns | 0.0010 ns |  0.4366 ns |  0.47 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  0.6972 ns | 0.0014 ns | 0.0013 ns |  0.6974 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 | 21.6823 ns | 0.0199 ns | 0.0155 ns | 21.6865 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 22.9176 ns | 0.0457 ns | 0.0428 ns | 22.9097 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 16.0656 ns | 0.0284 ns | 0.0266 ns | 16.0658 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 | 28.8298 ns | 0.0644 ns | 0.0602 ns | 28.8295 ns |  1.33 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 | 29.0162 ns | 0.0367 ns | 0.0343 ns | 29.0186 ns |  1.34 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 22.1422 ns | 0.0258 ns | 0.0215 ns | 22.1363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 23.8975 ns | 0.0242 ns | 0.0227 ns | 23.9032 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 18.7289 ns | 0.0217 ns | 0.0203 ns | 18.7313 ns |  0.85 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 | 33.0746 ns | 0.0540 ns | 0.0451 ns | 33.0612 ns |  1.49 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 34.1695 ns | 0.0301 ns | 0.0267 ns | 34.1655 ns |  1.54 |    0.00 |     - |     - |     - |         - |

Benchmarks with issues:
  Get_Prop_String.ToBool: Job-XPIDXK(Toolchain=.NET Core 2.0)
  Get_Prop_String.ToBool: Job-TONOSH(Toolchain=.NET Core 2.2)
  Get_Prop_String.ToBool: Job-YEBKOB(Toolchain=.NET Core 3.0)
  Get_Prop_String.ToBool: Job-TGKQNS(Toolchain=net461)
  Get_Prop_String.ToBool: Job-PNUVLP(Toolchain=net472)
  Get_Prop_String.ToBoolNullable: Job-XPIDXK(Toolchain=.NET Core 2.0)
  Get_Prop_String.ToBoolNullable: Job-TONOSH(Toolchain=.NET Core 2.2)
  Get_Prop_String.ToBoolNullable: Job-YEBKOB(Toolchain=.NET Core 3.0)
  Get_Prop_String.ToBoolNullable: Job-TGKQNS(Toolchain=net461)
  Get_Prop_String.ToBoolNullable: Job-PNUVLP(Toolchain=net472)
  Get_Prop_String.ToDateTime: Job-XPIDXK(Toolchain=.NET Core 2.0)
  Get_Prop_String.ToDateTime: Job-TONOSH(Toolchain=.NET Core 2.2)
  Get_Prop_String.ToDateTime: Job-YEBKOB(Toolchain=.NET Core 3.0)
  Get_Prop_String.ToDateTime: Job-TGKQNS(Toolchain=net461)
  Get_Prop_String.ToDateTime: Job-PNUVLP(Toolchain=net472)
  Get_Prop_String.ToDateTimeNullable: Job-XPIDXK(Toolchain=.NET Core 2.0)
  Get_Prop_String.ToDateTimeNullable: Job-TONOSH(Toolchain=.NET Core 2.2)
  Get_Prop_String.ToDateTimeNullable: Job-YEBKOB(Toolchain=.NET Core 3.0)
  Get_Prop_String.ToDateTimeNullable: Job-TGKQNS(Toolchain=net461)
  Get_Prop_String.ToDateTimeNullable: Job-PNUVLP(Toolchain=net472)
