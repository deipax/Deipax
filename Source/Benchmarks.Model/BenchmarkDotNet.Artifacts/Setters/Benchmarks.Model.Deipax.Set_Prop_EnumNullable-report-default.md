
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 13.4698 ns |  0.4232 ns | 0.0232 ns | 13.4664 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 12.2897 ns |  0.9956 ns | 0.0546 ns | 12.2931 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 13.7575 ns |  1.0430 ns | 0.0572 ns | 13.7495 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 12.8937 ns |  0.6917 ns | 0.0379 ns | 12.8887 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 13.5208 ns |  0.7495 ns | 0.0411 ns | 13.5078 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 12.2847 ns |  0.8273 ns | 0.0453 ns | 12.3077 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 13.7848 ns |  0.6942 ns | 0.0381 ns | 13.7723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 12.9024 ns |  0.9280 ns | 0.0509 ns | 12.9154 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 14.0067 ns | 16.8479 ns | 0.9235 ns | 13.4882 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 12.2633 ns |  1.0169 ns | 0.0557 ns | 12.2889 ns |  0.88 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 13.7311 ns |  0.3093 ns | 0.0170 ns | 13.7370 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 12.8890 ns |  1.5321 ns | 0.0840 ns | 12.8468 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 13.3967 ns |  0.0979 ns | 0.0054 ns | 13.3989 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 12.1255 ns |  0.4069 ns | 0.0223 ns | 12.1168 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 13.9093 ns |  0.5052 ns | 0.0277 ns | 13.9237 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 12.7458 ns |  0.1565 ns | 0.0086 ns | 12.7419 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 13.4076 ns |  1.4409 ns | 0.0790 ns | 13.3651 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 12.7364 ns | 16.7508 ns | 0.9182 ns | 12.2229 ns |  0.95 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 13.9350 ns |  1.8030 ns | 0.0988 ns | 13.9087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 12.8929 ns |  0.5045 ns | 0.0277 ns | 12.8834 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 13.4252 ns |  1.1198 ns | 0.0614 ns | 13.4120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 12.7317 ns |  7.7342 ns | 0.4239 ns | 12.8159 ns |  0.95 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 13.7602 ns |  0.9306 ns | 0.0510 ns | 13.7663 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 12.9546 ns |  0.5480 ns | 0.0300 ns | 12.9608 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 13.1359 ns |  1.2544 ns | 0.0688 ns | 13.1113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 12.1272 ns |  0.6848 ns | 0.0375 ns | 12.1063 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 13.7755 ns |  0.3005 ns | 0.0165 ns | 13.7722 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 12.9121 ns |  0.1507 ns | 0.0083 ns | 12.9111 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 13.2599 ns |  3.3800 ns | 0.1853 ns | 13.1839 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 12.0723 ns |  0.6402 ns | 0.0351 ns | 12.0657 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 13.6493 ns |  1.3312 ns | 0.0730 ns | 13.6571 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 12.7616 ns |  0.9724 ns | 0.0533 ns | 12.7699 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 13.5485 ns |  0.2226 ns | 0.0122 ns | 13.5463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 12.7062 ns |  0.5018 ns | 0.0275 ns | 12.6982 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 14.7984 ns |  1.4189 ns | 0.0778 ns | 14.7996 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 13.7829 ns |  2.7161 ns | 0.1489 ns | 13.7781 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 13.5696 ns |  3.9636 ns | 0.2173 ns | 13.4570 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 12.6902 ns |  0.5031 ns | 0.0276 ns | 12.6951 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 14.7143 ns |  0.5615 ns | 0.0308 ns | 14.7097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 13.7571 ns |  0.0538 ns | 0.0030 ns | 13.7582 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 15.6576 ns |  1.2229 ns | 0.0670 ns | 15.6602 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 14.9414 ns |  0.6748 ns | 0.0370 ns | 14.9494 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 15.8668 ns |  2.1316 ns | 0.1168 ns | 15.8178 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 15.1363 ns |  1.1817 ns | 0.0648 ns | 15.1080 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 15.6191 ns |  1.8192 ns | 0.0997 ns | 15.5996 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 14.7084 ns |  1.8873 ns | 0.1034 ns | 14.6788 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 16.5926 ns |  0.8806 ns | 0.0483 ns | 16.6149 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 16.7437 ns | 15.5958 ns | 0.8549 ns | 16.9259 ns |  1.01 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 23.2793 ns |  3.3027 ns | 0.1810 ns | 23.3075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 20.9112 ns |  2.2092 ns | 0.1211 ns | 20.8837 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 29.2419 ns |  0.8387 ns | 0.0460 ns | 29.2161 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 21.5258 ns |  0.4392 ns | 0.0241 ns | 21.5207 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  7.5066 ns |  6.7504 ns | 0.3700 ns |  7.3964 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  3.8478 ns |  1.9998 ns | 0.1096 ns |  3.8020 ns |  0.51 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  2.9436 ns |  0.4746 ns | 0.0260 ns |  2.9309 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  2.4438 ns |  1.8130 ns | 0.0994 ns |  2.3880 ns |  0.83 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.3880 ns |  0.4240 ns | 0.0232 ns | 12.3751 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.5353 ns |  3.1615 ns | 0.1733 ns | 11.5511 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 21.4606 ns |  1.5826 ns | 0.0867 ns | 21.4649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 18.2138 ns |  2.1989 ns | 0.1205 ns | 18.1805 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7718 ns |  0.1638 ns | 0.0090 ns |  0.7668 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.9256 ns |  0.1325 ns | 0.0073 ns |  0.9229 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  0.6715 ns |  0.0395 ns | 0.0022 ns |  0.6722 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  0.7330 ns |  0.1683 ns | 0.0092 ns |  0.7352 ns |  1.09 |    0.02 |     - |     - |     - |         - |
