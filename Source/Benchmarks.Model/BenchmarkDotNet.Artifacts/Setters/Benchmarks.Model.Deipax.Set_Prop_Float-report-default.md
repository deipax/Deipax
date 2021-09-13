
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  1.0394 ns |  0.4641 ns | 0.0254 ns |  1.0268 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.7626 ns |  0.7525 ns | 0.0412 ns |  0.7622 ns |  0.73 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.5580 ns |  1.1827 ns | 0.0648 ns |  1.5904 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.2798 ns |  1.0800 ns | 0.0592 ns |  1.2776 ns |  0.82 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.7482 ns |  0.4346 ns | 0.0238 ns |  0.7417 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7034 ns |  0.2697 ns | 0.0148 ns |  0.6957 ns |  0.94 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.7365 ns |  0.8001 ns | 0.0439 ns |  0.7188 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.7210 ns |  0.4295 ns | 0.0235 ns |  0.7310 ns |  0.98 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.9402 ns |  0.5223 ns | 0.0286 ns |  0.9305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.6064 ns |  1.1065 ns | 0.0606 ns |  0.6343 ns |  0.65 |    0.08 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.2871 ns |  1.2181 ns | 0.0668 ns |  1.3118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.0668 ns |  0.1022 ns | 0.0056 ns |  1.0686 ns |  0.83 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.9447 ns |  0.2336 ns | 0.0128 ns |  0.9476 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.5314 ns |  0.2639 ns | 0.0145 ns |  0.5283 ns |  0.56 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.2548 ns |  1.0794 ns | 0.0592 ns |  1.2275 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.2184 ns |  0.4366 ns | 0.0239 ns |  1.2048 ns |  0.97 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.9736 ns |  0.3303 ns | 0.0181 ns |  0.9795 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7531 ns |  0.8713 ns | 0.0478 ns |  0.7732 ns |  0.77 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2830 ns |  0.6754 ns | 0.0370 ns |  1.2671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.0403 ns |  1.0125 ns | 0.0555 ns |  1.0120 ns |  0.81 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.9610 ns |  0.3710 ns | 0.0203 ns |  0.9509 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.5125 ns |  0.2245 ns | 0.0123 ns |  0.5079 ns |  0.53 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.2108 ns |  0.0884 ns | 0.0048 ns |  1.2129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.0392 ns |  0.7379 ns | 0.0404 ns |  1.0586 ns |  0.86 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.9380 ns |  0.2834 ns | 0.0155 ns |  0.9335 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.7138 ns |  0.2813 ns | 0.0154 ns |  0.7168 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.0423 ns |  0.4660 ns | 0.0255 ns |  1.0474 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.0624 ns |  0.8523 ns | 0.0467 ns |  1.0871 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.6038 ns |  0.3536 ns | 0.0194 ns |  0.6136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.7831 ns |  0.3124 ns | 0.0171 ns |  0.7749 ns |  1.30 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.0759 ns |  0.4330 ns | 0.0237 ns |  1.0649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.3023 ns |  1.5404 ns | 0.0844 ns |  1.2647 ns |  1.21 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.5609 ns |  0.4031 ns | 0.0221 ns |  0.5636 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.7430 ns |  0.3001 ns | 0.0164 ns |  0.7362 ns |  1.33 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.8362 ns |  0.5583 ns | 0.0306 ns |  1.8459 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.7513 ns |  1.7370 ns | 0.0952 ns |  1.6991 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.7869 ns |  0.0179 ns | 0.0010 ns |  0.7873 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.9805 ns |  0.1762 ns | 0.0097 ns |  0.9768 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.7875 ns |  0.8099 ns | 0.0444 ns |  1.8040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.9784 ns |  0.2320 ns | 0.0127 ns |  1.9722 ns |  1.11 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  0.5216 ns |  0.0405 ns | 0.0022 ns |  0.5223 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  0.6664 ns |  0.1908 ns | 0.0105 ns |  0.6605 ns |  1.28 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  1.0819 ns |  0.8638 ns | 0.0473 ns |  1.0781 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  1.0571 ns |  0.2697 ns | 0.0148 ns |  1.0577 ns |  0.98 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  0.8464 ns |  0.4245 ns | 0.0233 ns |  0.8569 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  0.6987 ns |  0.0638 ns | 0.0035 ns |  0.6994 ns |  0.83 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  1.7436 ns |  0.5021 ns | 0.0275 ns |  1.7341 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  1.8931 ns |  0.4588 ns | 0.0251 ns |  1.8824 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  5.7150 ns |  4.0549 ns | 0.2223 ns |  5.6451 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  4.3842 ns |  0.1875 ns | 0.0103 ns |  4.3834 ns |  0.77 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 18.4835 ns |  0.8102 ns | 0.0444 ns | 18.4705 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  5.3996 ns |  0.2617 ns | 0.0143 ns |  5.3931 ns |  0.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.5518 ns |  0.5188 ns | 0.0284 ns |  0.5484 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7188 ns |  0.7207 ns | 0.0395 ns |  0.7351 ns |  1.30 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.4025 ns |  0.6757 ns | 0.0370 ns |  1.3858 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.1951 ns |  0.6788 ns | 0.0372 ns |  1.1782 ns |  0.85 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.2870 ns |  0.3543 ns | 0.0194 ns |  2.2796 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0952 ns |  0.9083 ns | 0.0498 ns |  2.0742 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 48.0022 ns | 23.6317 ns | 1.2953 ns | 47.6627 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 40.3932 ns | 10.8512 ns | 0.5948 ns | 40.3952 ns |  0.84 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.5498 ns |  0.4697 ns | 0.0257 ns |  0.5375 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7484 ns |  0.0603 ns | 0.0033 ns |  0.7498 ns |  1.36 |    0.07 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.0554 ns |  0.7080 ns | 0.0388 ns |  1.0660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.0445 ns |  0.0210 ns | 0.0012 ns |  1.0444 ns |  0.99 |    0.04 |     - |     - |     - |         - |
