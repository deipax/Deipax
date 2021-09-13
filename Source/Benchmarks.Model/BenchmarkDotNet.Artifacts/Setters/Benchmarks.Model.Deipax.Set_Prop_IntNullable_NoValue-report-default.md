
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 1.0451 ns | 7.2676 ns | 0.3984 ns | 0.8361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 1.0755 ns | 0.9691 ns | 0.0531 ns | 1.0490 ns |  1.11 |    0.31 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.1324 ns | 0.7216 ns | 0.0396 ns | 1.1194 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.4294 ns | 0.0824 ns | 0.0045 ns | 1.4318 ns |  1.26 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.5904 ns | 0.0773 ns | 0.0042 ns | 0.5915 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.9924 ns | 0.7450 ns | 0.0408 ns | 0.9917 ns |  1.68 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.1107 ns | 0.0412 ns | 0.0023 ns | 1.1099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.1650 ns | 0.8962 ns | 0.0491 ns | 1.1401 ns |  1.05 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.7797 ns | 3.2876 ns | 0.1802 ns | 0.8818 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.7552 ns | 0.2960 ns | 0.0162 ns | 0.7484 ns |  1.01 |    0.29 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.0873 ns | 3.6472 ns | 0.1999 ns | 0.9747 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.2565 ns | 0.5119 ns | 0.0281 ns | 1.2407 ns |  1.18 |    0.21 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.5566 ns | 0.0762 ns | 0.0042 ns | 0.5558 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.7315 ns | 0.1057 ns | 0.0058 ns | 0.7297 ns |  1.31 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.0122 ns | 0.4868 ns | 0.0267 ns | 0.9982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.2599 ns | 0.9445 ns | 0.0518 ns | 1.2407 ns |  1.24 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.7442 ns | 0.3356 ns | 0.0184 ns | 0.7525 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.7335 ns | 0.3220 ns | 0.0177 ns | 0.7323 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.1287 ns | 0.3835 ns | 0.0210 ns | 1.1253 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.2751 ns | 0.1937 ns | 0.0106 ns | 1.2777 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.6444 ns | 1.1614 ns | 0.0637 ns | 0.6775 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.9579 ns | 0.5013 ns | 0.0275 ns | 0.9468 ns |  1.49 |    0.13 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.1170 ns | 0.0753 ns | 0.0041 ns | 1.1186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.1504 ns | 0.5690 ns | 0.0312 ns | 1.1530 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 0.6621 ns | 0.2844 ns | 0.0156 ns | 0.6567 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.9641 ns | 0.0867 ns | 0.0048 ns | 0.9631 ns |  1.46 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 0.7351 ns | 0.3571 ns | 0.0196 ns | 0.7313 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 0.7423 ns | 0.2577 ns | 0.0141 ns | 0.7351 ns |  1.01 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.7704 ns | 0.5122 ns | 0.0281 ns | 0.7583 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.7848 ns | 0.3884 ns | 0.0213 ns | 0.7761 ns |  1.02 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.1434 ns | 0.5532 ns | 0.0303 ns | 1.1432 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.2362 ns | 0.8491 ns | 0.0465 ns | 1.2381 ns |  1.08 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 1.9642 ns | 4.0669 ns | 0.2229 ns | 1.9351 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 2.0980 ns | 5.5948 ns | 0.3067 ns | 2.1655 ns |  1.09 |    0.25 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.9319 ns | 0.7873 ns | 0.0432 ns | 1.9486 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.9594 ns | 1.5926 ns | 0.0873 ns | 1.9504 ns |  1.02 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 1.8074 ns | 1.5592 ns | 0.0855 ns | 1.8564 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 1.7388 ns | 0.0551 ns | 0.0030 ns | 1.7373 ns |  0.96 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.9546 ns | 0.5307 ns | 0.0291 ns | 1.9392 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.8245 ns | 0.4619 ns | 0.0253 ns | 1.8351 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 3.5509 ns | 0.4265 ns | 0.0234 ns | 3.5420 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 3.8263 ns | 2.9194 ns | 0.1600 ns | 3.8010 ns |  1.08 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.7924 ns | 0.8487 ns | 0.0465 ns | 1.7763 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.8214 ns | 2.3645 ns | 0.1296 ns | 1.7551 ns |  1.02 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 3.0045 ns | 0.6592 ns | 0.0361 ns | 2.9963 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 3.0422 ns | 1.8517 ns | 0.1015 ns | 3.0646 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.0205 ns | 0.5756 ns | 0.0316 ns | 2.0150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.9956 ns | 0.4108 ns | 0.0225 ns | 2.0074 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 6.0808 ns | 0.3511 ns | 0.0192 ns | 6.0849 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 8.4670 ns | 0.4902 ns | 0.0269 ns | 8.4647 ns |  1.39 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.7050 ns | 1.0402 ns | 0.0570 ns | 2.7091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.4223 ns | 1.8927 ns | 0.1037 ns | 2.3835 ns |  0.90 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7045 ns | 0.4465 ns | 0.0245 ns | 0.7124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7726 ns | 0.1335 ns | 0.0073 ns | 0.7736 ns |  1.10 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.5724 ns | 0.8664 ns | 0.0475 ns | 1.5663 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.2221 ns | 0.9649 ns | 0.0529 ns | 1.2368 ns |  0.78 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 3.0285 ns | 0.9649 ns | 0.0529 ns | 3.0238 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.6507 ns | 0.6708 ns | 0.0368 ns | 2.6346 ns |  0.88 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9249 ns | 0.2815 ns | 0.0154 ns | 1.9170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.7891 ns | 0.1943 ns | 0.0107 ns | 1.7934 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 0.7016 ns | 0.1385 ns | 0.0076 ns | 0.6977 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.9558 ns | 0.3771 ns | 0.0207 ns | 0.9452 ns |  1.36 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.6747 ns | 0.1063 ns | 0.0058 ns | 1.6771 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.2283 ns | 0.3547 ns | 0.0194 ns | 1.2182 ns |  0.73 |    0.01 |     - |     - |     - |         - |
