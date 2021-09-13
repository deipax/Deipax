
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 11.5514 ns |  1.1657 ns | 0.0639 ns | 11.5295 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  6.7364 ns |  0.9195 ns | 0.0504 ns |  6.7644 ns |  0.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 12.0603 ns |  1.1145 ns | 0.0611 ns | 12.0550 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  7.2409 ns |  0.5041 ns | 0.0276 ns |  7.2535 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.5984 ns |  0.0944 ns | 0.0052 ns |  0.6003 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7481 ns |  0.3667 ns | 0.0201 ns |  0.7437 ns |  1.25 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.9326 ns |  0.8625 ns | 0.0473 ns |  0.9110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.9521 ns |  0.2154 ns | 0.0118 ns |  0.9490 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 11.7428 ns |  1.6283 ns | 0.0893 ns | 11.7433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  6.5167 ns |  1.3917 ns | 0.0763 ns |  6.4739 ns |  0.55 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 12.3236 ns |  8.3544 ns | 0.4579 ns | 12.1354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  6.9629 ns |  0.2376 ns | 0.0130 ns |  6.9610 ns |  0.57 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 11.8401 ns |  4.3392 ns | 0.2378 ns | 11.7935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  6.0534 ns |  0.3959 ns | 0.0217 ns |  6.0537 ns |  0.51 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 12.0316 ns |  5.1439 ns | 0.2820 ns | 11.9212 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  7.0419 ns |  5.4842 ns | 0.3006 ns |  7.1997 ns |  0.59 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 11.5615 ns |  0.5727 ns | 0.0314 ns | 11.5638 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  6.9546 ns |  0.7623 ns | 0.0418 ns |  6.9722 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 12.1207 ns |  1.3816 ns | 0.0757 ns | 12.0799 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  6.9729 ns |  1.1969 ns | 0.0656 ns |  6.9546 ns |  0.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 11.8631 ns |  1.9423 ns | 0.1065 ns | 11.8721 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  6.5924 ns |  0.9501 ns | 0.0521 ns |  6.5671 ns |  0.56 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 12.0678 ns |  0.7891 ns | 0.0433 ns | 12.0625 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  6.8851 ns |  2.1871 ns | 0.1199 ns |  6.9057 ns |  0.57 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 12.5681 ns | 11.3508 ns | 0.6222 ns | 12.4337 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  6.9689 ns |  0.4717 ns | 0.0259 ns |  6.9591 ns |  0.56 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 11.9940 ns |  1.0891 ns | 0.0597 ns | 11.9726 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  7.2497 ns |  3.8720 ns | 0.2122 ns |  7.3581 ns |  0.60 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 12.2631 ns |  0.5717 ns | 0.0313 ns | 12.2515 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  6.0028 ns |  1.5031 ns | 0.0824 ns |  6.0126 ns |  0.49 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 11.8018 ns |  1.2148 ns | 0.0666 ns | 11.8100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  6.6590 ns |  0.9069 ns | 0.0497 ns |  6.6338 ns |  0.56 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 11.7920 ns |  0.8090 ns | 0.0443 ns | 11.7981 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  6.8960 ns |  1.3066 ns | 0.0716 ns |  6.8703 ns |  0.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 12.8458 ns |  1.8215 ns | 0.0998 ns | 12.8015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  7.3910 ns |  1.3901 ns | 0.0762 ns |  7.3484 ns |  0.58 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 12.4148 ns |  4.4586 ns | 0.2444 ns | 12.3048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  6.3205 ns |  4.7875 ns | 0.2624 ns |  6.4691 ns |  0.51 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 12.4618 ns |  2.5697 ns | 0.1409 ns | 12.5265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  7.7317 ns |  4.6027 ns | 0.2523 ns |  7.8579 ns |  0.62 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 15.7079 ns |  0.1440 ns | 0.0079 ns | 15.7108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 14.0716 ns |  1.4600 ns | 0.0800 ns | 14.0471 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 15.9886 ns |  1.3842 ns | 0.0759 ns | 15.9842 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 14.5686 ns |  9.5902 ns | 0.5257 ns | 14.4442 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 16.6870 ns |  2.4564 ns | 0.1346 ns | 16.6125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 12.8012 ns |  1.5521 ns | 0.0851 ns | 12.8264 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 17.4628 ns |  2.5694 ns | 0.1408 ns | 17.4160 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 13.7670 ns |  2.2378 ns | 0.1227 ns | 13.7737 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  5.6691 ns |  1.1017 ns | 0.0604 ns |  5.6854 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  5.5978 ns |  0.9921 ns | 0.0544 ns |  5.6272 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |  1.6724 ns |  5.8349 ns | 0.3198 ns |  1.5111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  1.3125 ns |  0.4349 ns | 0.0238 ns |  1.3146 ns |  0.80 |    0.15 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  1.0259 ns |  0.6545 ns | 0.0359 ns |  1.0416 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7570 ns |  0.6668 ns | 0.0365 ns |  0.7380 ns |  0.74 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.7003 ns |  2.5711 ns | 0.1409 ns |  1.6410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2740 ns |  1.1268 ns | 0.0618 ns |  1.2632 ns |  0.75 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 19.5153 ns |  3.6555 ns | 0.2004 ns | 19.4283 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 13.5057 ns |  3.6756 ns | 0.2015 ns | 13.3966 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 50.7030 ns | 14.1252 ns | 0.7743 ns | 50.6290 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 50.1328 ns | 38.5135 ns | 2.1111 ns | 48.9523 ns |  0.99 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 12.0220 ns |  5.2162 ns | 0.2859 ns | 11.8601 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  6.4939 ns |  0.3370 ns | 0.0185 ns |  6.4966 ns |  0.54 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 11.7924 ns |  0.8562 ns | 0.0469 ns | 11.8121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  7.4277 ns |  0.3910 ns | 0.0214 ns |  7.4266 ns |  0.63 |    0.00 |     - |     - |     - |         - |
