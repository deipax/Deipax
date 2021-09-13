
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  1.0123 ns |  0.2825 ns | 0.0155 ns |  1.0197 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.9553 ns |  0.3584 ns | 0.0196 ns |  0.9446 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.2752 ns |  0.8032 ns | 0.0440 ns |  1.2836 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.8225 ns |  5.3081 ns | 0.2910 ns |  1.9012 ns |  1.43 |    0.25 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  1.1955 ns |  4.4218 ns | 0.2424 ns |  1.1331 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7361 ns |  0.0912 ns | 0.0050 ns |  0.7341 ns |  0.63 |    0.12 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.3104 ns |  0.2348 ns | 0.0129 ns |  1.3108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.3850 ns |  2.1163 ns | 0.1160 ns |  1.3814 ns |  1.06 |    0.08 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.7523 ns |  0.0754 ns | 0.0041 ns |  0.7545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.6890 ns |  0.3010 ns | 0.0165 ns |  0.6970 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.0171 ns |  0.4984 ns | 0.0273 ns |  1.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  0.7145 ns |  1.5077 ns | 0.0826 ns |  0.6675 ns |  0.70 |    0.10 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  1.0158 ns |  0.1881 ns | 0.0103 ns |  1.0181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7625 ns |  0.3047 ns | 0.0167 ns |  0.7627 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.4049 ns |  3.2731 ns | 0.1794 ns |  1.3897 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.1343 ns |  0.4188 ns | 0.0230 ns |  1.1296 ns |  0.82 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  1.9680 ns |  0.1325 ns | 0.0073 ns |  1.9717 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  1.8240 ns |  0.2097 ns | 0.0115 ns |  1.8272 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  2.6340 ns |  0.8003 ns | 0.0439 ns |  2.6413 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  2.5824 ns |  0.5009 ns | 0.0275 ns |  2.5688 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.9846 ns |  4.1484 ns | 0.2274 ns |  1.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7741 ns |  0.1086 ns | 0.0060 ns |  0.7751 ns |  0.82 |    0.20 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.3758 ns |  0.1510 ns | 0.0083 ns |  1.3779 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.3024 ns |  2.2495 ns | 0.1233 ns |  1.2355 ns |  0.95 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  1.9608 ns |  0.1061 ns | 0.0058 ns |  1.9588 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  1.7926 ns |  0.1140 ns | 0.0062 ns |  1.7924 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  3.0590 ns |  1.9286 ns | 0.1057 ns |  3.0761 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  2.5510 ns |  0.4533 ns | 0.0248 ns |  2.5449 ns |  0.83 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.8666 ns |  0.3420 ns | 0.0187 ns |  0.8594 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.8333 ns |  0.1484 ns | 0.0081 ns |  0.8294 ns |  0.96 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.2012 ns |  0.0905 ns | 0.0050 ns |  1.1996 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.3387 ns |  0.7425 ns | 0.0407 ns |  1.3161 ns |  1.11 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.8762 ns |  0.3287 ns | 0.0180 ns |  1.8707 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.8758 ns |  0.3405 ns | 0.0187 ns |  1.8781 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.5795 ns |  0.3807 ns | 0.0209 ns |  3.5915 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  3.1465 ns |  3.5321 ns | 0.1936 ns |  3.0423 ns |  0.88 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.8315 ns |  0.1296 ns | 0.0071 ns |  0.8355 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.8387 ns |  0.0961 ns | 0.0053 ns |  0.8398 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.8254 ns |  1.8653 ns | 0.1022 ns |  1.7739 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.7565 ns |  0.0666 ns | 0.0036 ns |  1.7577 ns |  0.96 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.6446 ns |  0.4007 ns | 0.0220 ns |  4.6529 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  4.2044 ns |  0.3608 ns | 0.0198 ns |  4.2064 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  4.7720 ns |  0.7370 ns | 0.0404 ns |  4.7843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  4.6682 ns |  0.2882 ns | 0.0158 ns |  4.6742 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  4.1324 ns |  0.6377 ns | 0.0350 ns |  4.1397 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  5.0754 ns | 11.7171 ns | 0.6423 ns |  4.7750 ns |  1.23 |    0.15 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  5.0196 ns |  0.4193 ns | 0.0230 ns |  5.0287 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  5.3847 ns |  0.2686 ns | 0.0147 ns |  5.3860 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  7.3875 ns |  5.8205 ns | 0.3190 ns |  7.2066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  9.5460 ns |  4.2569 ns | 0.2333 ns |  9.4593 ns |  1.29 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 16.2283 ns | 21.8219 ns | 1.1961 ns | 16.8898 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 11.1958 ns |  1.9317 ns | 0.1059 ns | 11.2135 ns |  0.69 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.8163 ns |  0.2344 ns | 0.0128 ns |  0.8095 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  1.1944 ns |  0.8650 ns | 0.0474 ns |  1.1897 ns |  1.46 |    0.07 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5976 ns |  0.2975 ns | 0.0163 ns |  1.5921 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2368 ns |  0.0471 ns | 0.0026 ns |  1.2372 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.4278 ns |  0.4725 ns | 0.0259 ns | 12.4265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.7491 ns |  1.2989 ns | 0.0712 ns | 11.7351 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  9.6319 ns |  5.0341 ns | 0.2759 ns |  9.4777 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  8.3387 ns |  0.6493 ns | 0.0356 ns |  8.3451 ns |  0.87 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  2.0163 ns |  0.0561 ns | 0.0031 ns |  2.0150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  1.8604 ns |  0.4574 ns | 0.0251 ns |  1.8493 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  2.7512 ns |  1.9979 ns | 0.1095 ns |  2.7486 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  2.6750 ns |  0.4369 ns | 0.0239 ns |  2.6820 ns |  0.97 |    0.03 |     - |     - |     - |         - |
