
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.5178 ns |  0.2462 ns | 0.0135 ns |  0.5152 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.4493 ns |  0.1613 ns | 0.0088 ns |  0.4538 ns |  0.87 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  2.4344 ns |  0.2093 ns | 0.0115 ns |  2.4408 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  0.9533 ns |  0.1723 ns | 0.0094 ns |  0.9534 ns |  0.39 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.7418 ns |  1.6066 ns | 0.0881 ns |  0.7226 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.4476 ns |  0.1236 ns | 0.0068 ns |  0.4443 ns |  0.61 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.8224 ns |  3.7471 ns | 0.2054 ns |  0.7117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.4586 ns |  0.0881 ns | 0.0048 ns |  0.4583 ns |  0.58 |    0.12 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.5547 ns |  0.4637 ns | 0.0254 ns |  0.5492 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.4612 ns |  0.1954 ns | 0.0107 ns |  0.4570 ns |  0.83 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.0660 ns |  0.5676 ns | 0.0311 ns |  1.0749 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.0346 ns |  0.6726 ns | 0.0369 ns |  1.0305 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.4820 ns |  0.2873 ns | 0.0157 ns |  0.4803 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.4568 ns |  0.1927 ns | 0.0106 ns |  0.4529 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.0583 ns |  0.4385 ns | 0.0240 ns |  1.0646 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  0.9922 ns |  0.5143 ns | 0.0282 ns |  0.9787 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.7443 ns |  0.2907 ns | 0.0159 ns |  0.7450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.6834 ns |  0.2509 ns | 0.0138 ns |  0.6845 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.0056 ns |  0.0980 ns | 0.0054 ns |  1.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2312 ns |  0.5243 ns | 0.0287 ns |  1.2457 ns |  1.22 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  1.8509 ns | 21.1011 ns | 1.1566 ns |  2.5054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7062 ns |  0.0850 ns | 0.0047 ns |  0.7069 ns |  0.64 |    0.63 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.0258 ns |  0.2023 ns | 0.0111 ns |  1.0297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.3961 ns |  2.7347 ns | 0.1499 ns |  1.4723 ns |  1.36 |    0.16 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.5261 ns |  0.2372 ns | 0.0130 ns |  0.5312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.5060 ns |  0.2531 ns | 0.0139 ns |  0.5061 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.0170 ns |  0.3853 ns | 0.0211 ns |  1.0251 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2867 ns |  0.1579 ns | 0.0087 ns |  1.2838 ns |  1.27 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.7004 ns |  0.2125 ns | 0.0116 ns |  0.7056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.6413 ns |  2.9844 ns | 0.1636 ns |  0.5693 ns |  0.91 |    0.23 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.1547 ns |  1.4591 ns | 0.0800 ns |  1.1745 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  0.9612 ns |  1.0491 ns | 0.0575 ns |  0.9624 ns |  0.83 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.8880 ns |  0.3256 ns | 0.0178 ns |  0.8899 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.7634 ns |  0.2264 ns | 0.0124 ns |  0.7653 ns |  0.86 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.6975 ns |  0.1376 ns | 0.0075 ns |  1.6942 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.7724 ns |  0.4318 ns | 0.0237 ns |  1.7653 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.7338 ns |  2.4202 ns | 0.1327 ns |  0.6638 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.5669 ns |  0.1114 ns | 0.0061 ns |  0.5675 ns |  0.79 |    0.12 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.6623 ns |  0.6301 ns | 0.0345 ns |  1.6758 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.5849 ns |  0.4127 ns | 0.0226 ns |  1.5783 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  0.8497 ns |  4.1333 ns | 0.2266 ns |  0.7311 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  0.5458 ns |  0.8804 ns | 0.0483 ns |  0.5453 ns |  0.66 |    0.11 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  1.2020 ns |  0.3138 ns | 0.0172 ns |  1.1968 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  1.1136 ns |  0.6363 ns | 0.0349 ns |  1.0980 ns |  0.93 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  0.6805 ns |  0.0396 ns | 0.0022 ns |  0.6808 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  0.7725 ns |  0.2157 ns | 0.0118 ns |  0.7691 ns |  1.14 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  1.9023 ns |  0.5939 ns | 0.0326 ns |  1.8848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  1.8901 ns |  0.2275 ns | 0.0125 ns |  1.8950 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  5.5541 ns |  6.1084 ns | 0.3348 ns |  5.3972 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  7.5966 ns |  2.7665 ns | 0.1516 ns |  7.5189 ns |  1.37 |    0.10 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 10.8106 ns |  1.1624 ns | 0.0637 ns | 10.8094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  8.6180 ns |  1.4638 ns | 0.0802 ns |  8.5996 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.6681 ns |  0.4360 ns | 0.0239 ns |  0.6571 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.6444 ns |  0.4448 ns | 0.0244 ns |  0.6441 ns |  0.97 |    0.07 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.3517 ns |  0.3517 ns | 0.0193 ns |  1.3491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.1305 ns |  0.2440 ns | 0.0134 ns |  1.1304 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.2388 ns |  1.0284 ns | 0.0564 ns |  2.2078 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0123 ns |  0.1611 ns | 0.0088 ns |  2.0082 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 13.8770 ns |  0.3503 ns | 0.0192 ns | 13.8843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 13.9182 ns |  3.1293 ns | 0.1715 ns | 13.8818 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7331 ns |  0.8498 ns | 0.0466 ns |  0.7079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  1.0616 ns |  3.4275 ns | 0.1879 ns |  1.1536 ns |  1.46 |    0.34 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.0666 ns |  1.3061 ns | 0.0716 ns |  1.0327 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  0.8775 ns |  2.9438 ns | 0.1614 ns |  0.7867 ns |  0.82 |    0.09 |     - |     - |     - |         - |
