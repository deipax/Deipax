
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.7774 ns | 0.2371 ns | 0.0130 ns | 0.7706 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 1.0008 ns | 0.5151 ns | 0.0282 ns | 1.0077 ns |  1.29 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.0545 ns | 0.7173 ns | 0.0393 ns | 1.0742 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.4533 ns | 0.5732 ns | 0.0314 ns | 1.4446 ns |  1.38 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.5843 ns | 0.0947 ns | 0.0052 ns | 0.5819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.9607 ns | 0.0549 ns | 0.0030 ns | 0.9599 ns |  1.64 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.2219 ns | 1.4982 ns | 0.0821 ns | 1.2482 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.1595 ns | 0.6416 ns | 0.0352 ns | 1.1428 ns |  0.95 |    0.09 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.7750 ns | 0.2612 ns | 0.0143 ns | 0.7766 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.7767 ns | 0.1038 ns | 0.0057 ns | 0.7759 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.0558 ns | 0.4785 ns | 0.0262 ns | 1.0614 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.3057 ns | 0.5418 ns | 0.0297 ns | 1.3029 ns |  1.24 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.5798 ns | 0.2775 ns | 0.0152 ns | 0.5871 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.7962 ns | 0.3734 ns | 0.0205 ns | 0.7961 ns |  1.37 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 0.9897 ns | 0.5797 ns | 0.0318 ns | 0.9777 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.2430 ns | 0.2158 ns | 0.0118 ns | 1.2390 ns |  1.26 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.6743 ns | 0.1334 ns | 0.0073 ns | 0.6776 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.9888 ns | 0.5364 ns | 0.0294 ns | 0.9750 ns |  1.47 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.1555 ns | 0.5477 ns | 0.0300 ns | 1.1388 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.2682 ns | 1.2188 ns | 0.0668 ns | 1.2370 ns |  1.10 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.6769 ns | 0.4754 ns | 0.0261 ns | 0.6632 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.9699 ns | 0.1686 ns | 0.0092 ns | 0.9705 ns |  1.43 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.2626 ns | 1.6296 ns | 0.0893 ns | 1.3108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.1820 ns | 0.7328 ns | 0.0402 ns | 1.1967 ns |  0.94 |    0.09 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 0.9310 ns | 0.3658 ns | 0.0201 ns | 0.9273 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.8014 ns | 0.3895 ns | 0.0213 ns | 0.7959 ns |  0.86 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.1745 ns | 0.2493 ns | 0.0137 ns | 1.1712 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.2701 ns | 0.3337 ns | 0.0183 ns | 1.2606 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.8813 ns | 0.5807 ns | 0.0318 ns | 0.8929 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.9353 ns | 0.4889 ns | 0.0268 ns | 0.9321 ns |  1.06 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 0.9771 ns | 3.8899 ns | 0.2132 ns | 0.8872 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 0.7774 ns | 2.2599 ns | 0.1239 ns | 0.7154 ns |  0.83 |    0.27 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 1.7918 ns | 0.0879 ns | 0.0048 ns | 1.7915 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 0.7595 ns | 0.1617 ns | 0.0089 ns | 0.7602 ns |  0.42 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 2.0883 ns | 1.1610 ns | 0.0636 ns | 2.1030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.5361 ns | 0.0153 ns | 0.0008 ns | 1.5357 ns |  0.74 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 0.7658 ns | 0.0538 ns | 0.0029 ns | 0.7675 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 0.7675 ns | 0.6967 ns | 0.0382 ns | 0.7477 ns |  1.00 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.6524 ns | 0.8244 ns | 0.0452 ns | 1.6433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.6504 ns | 0.6089 ns | 0.0334 ns | 1.6542 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 3.6061 ns | 1.1933 ns | 0.0654 ns | 3.5864 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 3.6656 ns | 0.6828 ns | 0.0374 ns | 3.6441 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.8453 ns | 1.1458 ns | 0.0628 ns | 1.8677 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.8221 ns | 1.0942 ns | 0.0600 ns | 1.7913 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 3.2228 ns | 0.0656 ns | 0.0036 ns | 3.2214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 3.2030 ns | 0.9728 ns | 0.0533 ns | 3.1915 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.0919 ns | 0.8021 ns | 0.0440 ns | 2.0746 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 2.0124 ns | 0.5752 ns | 0.0315 ns | 1.9953 ns |  0.96 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 6.5381 ns | 2.9744 ns | 0.1630 ns | 6.4698 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 8.5470 ns | 0.2015 ns | 0.0110 ns | 8.5499 ns |  1.31 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.6097 ns | 0.4000 ns | 0.0219 ns | 2.6117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.4502 ns | 0.2108 ns | 0.0116 ns | 2.4453 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.9520 ns | 0.1254 ns | 0.0069 ns | 0.9512 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7645 ns | 0.9649 ns | 0.0529 ns | 0.7476 ns |  0.80 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.6718 ns | 1.8998 ns | 0.1041 ns | 1.6196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.4468 ns | 0.5900 ns | 0.0323 ns | 1.4302 ns |  0.87 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.7060 ns | 0.2904 ns | 0.0159 ns | 2.7020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.6647 ns | 0.2319 ns | 0.0127 ns | 2.6674 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9086 ns | 0.1874 ns | 0.0103 ns | 1.9045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.8310 ns | 1.3968 ns | 0.0766 ns | 1.7906 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 0.7534 ns | 0.0426 ns | 0.0023 ns | 0.7536 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.7425 ns | 0.2228 ns | 0.0122 ns | 0.7377 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.1063 ns | 0.4652 ns | 0.0255 ns | 1.1201 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.2240 ns | 0.2173 ns | 0.0119 ns | 1.2209 ns |  1.11 |    0.03 |     - |     - |     - |         - |
