
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |        Mean |      Error |    StdDev |      Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |------------:|-----------:|----------:|------------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |   0.7530 ns |  0.0674 ns | 0.0037 ns |   0.7520 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |   0.7009 ns |  0.0814 ns | 0.0045 ns |   0.7019 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |   0.7860 ns |  0.6505 ns | 0.0357 ns |   0.7696 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |   0.7118 ns |  0.2644 ns | 0.0145 ns |   0.7189 ns |  0.91 |    0.04 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |   0.6054 ns |  0.1652 ns | 0.0091 ns |   0.6015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |   0.5673 ns |  0.0294 ns | 0.0016 ns |   0.5678 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |   1.1371 ns |  7.7699 ns | 0.4259 ns |   0.9111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |   0.7109 ns |  0.3600 ns | 0.0197 ns |   0.7198 ns |  0.67 |    0.20 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |   0.6261 ns |  1.1183 ns | 0.0613 ns |   0.5918 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |   0.7099 ns |  0.6960 ns | 0.0382 ns |   0.6919 ns |  1.14 |    0.15 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |   1.5118 ns |  0.1436 ns | 0.0079 ns |   1.5147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |   0.6896 ns |  0.5359 ns | 0.0294 ns |   0.6920 ns |  0.46 |    0.02 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |   0.6191 ns |  0.2448 ns | 0.0134 ns |   0.6173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |   0.6185 ns |  0.1254 ns | 0.0069 ns |   0.6170 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |   0.8276 ns |  1.5174 ns | 0.0832 ns |   0.8641 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |   0.6750 ns |  0.4692 ns | 0.0257 ns |   0.6805 ns |  0.82 |    0.10 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |   0.7378 ns |  0.3951 ns | 0.0217 ns |   0.7288 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |   0.7656 ns |  1.0610 ns | 0.0582 ns |   0.7334 ns |  1.04 |    0.10 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |   0.8807 ns |  0.1512 ns | 0.0083 ns |   0.8774 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |   0.8143 ns |  0.7225 ns | 0.0396 ns |   0.8302 ns |  0.92 |    0.04 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |   0.6032 ns |  0.1360 ns | 0.0075 ns |   0.6061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |   0.5953 ns |  0.5809 ns | 0.0318 ns |   0.5874 ns |  0.99 |    0.05 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |   0.8773 ns |  0.1648 ns | 0.0090 ns |   0.8728 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |   0.8983 ns |  0.1520 ns | 0.0083 ns |   0.8996 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |   0.7208 ns |  0.3260 ns | 0.0179 ns |   0.7153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |   0.7694 ns |  0.1069 ns | 0.0059 ns |   0.7707 ns |  1.07 |    0.02 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |   0.9098 ns |  0.0648 ns | 0.0036 ns |   0.9115 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |   0.8562 ns |  0.1074 ns | 0.0059 ns |   0.8546 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |   0.7672 ns |  0.4481 ns | 0.0246 ns |   0.7615 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |   0.9211 ns |  2.6302 ns | 0.1442 ns |   0.9919 ns |  1.20 |    0.18 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |   0.9029 ns |  0.0367 ns | 0.0020 ns |   0.9023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |   0.9045 ns |  0.8279 ns | 0.0454 ns |   0.8857 ns |  1.00 |    0.05 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |   0.7691 ns |  0.1581 ns | 0.0087 ns |   0.7646 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |   0.7301 ns |  0.1747 ns | 0.0096 ns |   0.7253 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |   1.2257 ns |  0.3059 ns | 0.0168 ns |   1.2168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |   1.1787 ns |  0.6301 ns | 0.0345 ns |   1.1617 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |   0.7102 ns |  0.0335 ns | 0.0018 ns |   0.7099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |   0.7714 ns |  0.0713 ns | 0.0039 ns |   0.7703 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |   1.2414 ns |  0.2901 ns | 0.0159 ns |   1.2440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |   1.4483 ns |  0.9362 ns | 0.0513 ns |   1.4315 ns |  1.17 |    0.04 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |   0.7872 ns |  0.3805 ns | 0.0209 ns |   0.7903 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |   0.7509 ns |  0.1974 ns | 0.0108 ns |   0.7484 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |   1.1389 ns |  3.5323 ns | 0.1936 ns |   1.1953 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |   0.7605 ns |  0.3072 ns | 0.0168 ns |   0.7586 ns |  0.68 |    0.12 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |   0.7505 ns |  1.0720 ns | 0.0588 ns |   0.7199 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |   0.7475 ns |  0.3438 ns | 0.0188 ns |   0.7465 ns |  1.00 |    0.05 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |   1.4448 ns |  0.2874 ns | 0.0158 ns |   1.4514 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |   1.3967 ns |  1.1038 ns | 0.0605 ns |   1.3685 ns |  0.97 |    0.04 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |   1.2196 ns |  0.2454 ns | 0.0135 ns |   1.2189 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |   1.2302 ns |  0.6747 ns | 0.0370 ns |   1.2140 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |   1.2591 ns |  0.6998 ns | 0.0384 ns |   1.2494 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |   1.2284 ns |  0.4954 ns | 0.0272 ns |   1.2290 ns |  0.98 |    0.05 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |   0.5078 ns |  0.4272 ns | 0.0234 ns |   0.5060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |   0.7417 ns |  0.3612 ns | 0.0198 ns |   0.7499 ns |  1.46 |    0.05 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |   2.6762 ns |  0.9833 ns | 0.0539 ns |   2.6478 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |   1.9822 ns |  0.6411 ns | 0.0351 ns |   1.9820 ns |  0.74 |    0.03 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |   2.1800 ns |  0.5773 ns | 0.0316 ns |   2.1762 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |   2.1097 ns |  0.5977 ns | 0.0328 ns |   2.1264 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 304.3594 ns | 57.7705 ns | 3.1666 ns | 303.5649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 277.5133 ns | 15.5766 ns | 0.8538 ns | 277.2163 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |   0.7549 ns |  0.1376 ns | 0.0075 ns |   0.7534 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |   0.7175 ns |  0.1587 ns | 0.0087 ns |   0.7165 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |             |            |           |             |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |   0.9182 ns |  0.4811 ns | 0.0264 ns |   0.9126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |   0.7546 ns |  0.0319 ns | 0.0017 ns |   0.7551 ns |  0.82 |    0.02 |     - |     - |     - |         - |
