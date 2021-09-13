
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.6939 ns | 0.2487 ns | 0.0136 ns |  0.6886 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.7792 ns | 0.1298 ns | 0.0071 ns |  0.7759 ns |  1.12 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.0362 ns | 0.9034 ns | 0.0495 ns |  1.0117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.0318 ns | 0.1599 ns | 0.0088 ns |  1.0324 ns |  1.00 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.8100 ns | 0.7220 ns | 0.0396 ns |  0.8191 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  1.0186 ns | 0.1788 ns | 0.0098 ns |  1.0189 ns |  1.26 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.7613 ns | 0.4146 ns | 0.0227 ns |  0.7740 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.7443 ns | 0.3252 ns | 0.0178 ns |  0.7465 ns |  0.98 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.9522 ns | 0.2194 ns | 0.0120 ns |  0.9467 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  1.0144 ns | 0.2874 ns | 0.0158 ns |  1.0164 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.3500 ns | 1.1287 ns | 0.0619 ns |  1.3191 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.1179 ns | 0.1994 ns | 0.0109 ns |  1.1188 ns |  0.83 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.7557 ns | 0.8994 ns | 0.0493 ns |  0.7317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7554 ns | 0.1202 ns | 0.0066 ns |  0.7580 ns |  1.00 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.1918 ns | 0.4522 ns | 0.0248 ns |  1.1829 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.2950 ns | 0.2021 ns | 0.0111 ns |  1.3007 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.7075 ns | 0.0671 ns | 0.0037 ns |  0.7077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7944 ns | 0.0816 ns | 0.0045 ns |  0.7930 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2863 ns | 0.3681 ns | 0.0202 ns |  1.2747 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.3364 ns | 0.0785 ns | 0.0043 ns |  1.3360 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.6347 ns | 0.0960 ns | 0.0053 ns |  0.6364 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7794 ns | 0.1889 ns | 0.0104 ns |  0.7752 ns |  1.23 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.2671 ns | 1.5262 ns | 0.0837 ns |  1.2345 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.5161 ns | 1.5041 ns | 0.0824 ns |  1.5444 ns |  1.20 |    0.14 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  2.1129 ns | 0.3903 ns | 0.0214 ns |  2.1138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  1.1293 ns | 3.8296 ns | 0.2099 ns |  1.0401 ns |  0.53 |    0.10 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  2.8294 ns | 2.3596 ns | 0.1293 ns |  2.7768 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.3395 ns | 0.4611 ns | 0.0253 ns |  1.3473 ns |  0.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.8286 ns | 1.0277 ns | 0.0563 ns |  0.8183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.9618 ns | 0.1006 ns | 0.0055 ns |  0.9594 ns |  1.16 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.1995 ns | 1.7097 ns | 0.0937 ns |  1.1562 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.5517 ns | 2.4660 ns | 0.1352 ns |  1.5211 ns |  1.29 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  2.0267 ns | 0.3283 ns | 0.0180 ns |  2.0330 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  2.0322 ns | 0.1409 ns | 0.0077 ns |  2.0327 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.2763 ns | 5.1306 ns | 0.2812 ns |  3.1177 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  3.0730 ns | 0.2109 ns | 0.0116 ns |  3.0755 ns |  0.94 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  2.0840 ns | 1.1288 ns | 0.0619 ns |  2.0713 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  2.2816 ns | 1.1714 ns | 0.0642 ns |  2.2449 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  3.3823 ns | 1.0411 ns | 0.0571 ns |  3.3623 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  3.3078 ns | 0.5803 ns | 0.0318 ns |  3.3062 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  0.7702 ns | 0.1050 ns | 0.0058 ns |  0.7727 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  0.9575 ns | 0.1332 ns | 0.0073 ns |  0.9536 ns |  1.24 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  1.0023 ns | 0.4414 ns | 0.0242 ns |  0.9943 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  0.8105 ns | 0.1154 ns | 0.0063 ns |  0.8111 ns |  0.81 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  1.0252 ns | 0.8333 ns | 0.0457 ns |  1.0074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  0.8223 ns | 0.6579 ns | 0.0361 ns |  0.8345 ns |  0.80 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  1.2855 ns | 0.2749 ns | 0.0151 ns |  1.2859 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  1.5519 ns | 0.2056 ns | 0.0113 ns |  1.5471 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  1.2937 ns | 0.1744 ns | 0.0096 ns |  1.2958 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  1.3266 ns | 0.1004 ns | 0.0055 ns |  1.3253 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |  1.2727 ns | 0.5627 ns | 0.0308 ns |  1.2620 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  1.4153 ns | 1.2059 ns | 0.0661 ns |  1.3800 ns |  1.11 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  1.0073 ns | 0.4521 ns | 0.0248 ns |  0.9950 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.8773 ns | 0.5660 ns | 0.0310 ns |  0.8824 ns |  0.87 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.7224 ns | 0.2150 ns | 0.0118 ns |  1.7261 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.3557 ns | 1.3212 ns | 0.0724 ns |  1.3312 ns |  0.79 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.8020 ns | 2.3101 ns | 0.1266 ns | 12.7298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.6224 ns | 0.3631 ns | 0.0199 ns | 11.6282 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  3.3802 ns | 7.8612 ns | 0.4309 ns |  3.2584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  3.1280 ns | 0.2621 ns | 0.0144 ns |  3.1317 ns |  0.94 |    0.12 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  2.1055 ns | 1.1503 ns | 0.0631 ns |  2.0782 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.8304 ns | 0.8870 ns | 0.0486 ns |  0.8067 ns |  0.39 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  2.3764 ns | 0.1881 ns | 0.0103 ns |  2.3729 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.2788 ns | 0.1448 ns | 0.0079 ns |  1.2829 ns |  0.54 |    0.00 |     - |     - |     - |         - |
