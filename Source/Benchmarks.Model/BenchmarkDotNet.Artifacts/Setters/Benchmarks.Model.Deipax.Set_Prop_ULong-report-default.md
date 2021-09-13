
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9065 ns | 0.4394 ns | 0.0241 ns |  0.9094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.1762 ns | 0.2174 ns | 0.0119 ns |  1.1757 ns |  1.30 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.0016 ns | 0.3611 ns | 0.0198 ns |  0.9912 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.2523 ns | 0.5597 ns | 0.0307 ns |  1.2372 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.4500 ns | 0.0392 ns | 0.0021 ns |  0.4499 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.4863 ns | 0.2393 ns | 0.0131 ns |  0.4828 ns |  1.08 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.9763 ns | 0.4065 ns | 0.0223 ns |  0.9658 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.0094 ns | 0.4079 ns | 0.0224 ns |  0.9968 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.8009 ns | 2.6561 ns | 0.1456 ns |  0.7228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.5311 ns | 0.0853 ns | 0.0047 ns |  0.5324 ns |  0.68 |    0.12 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  0.9595 ns | 0.5222 ns | 0.0286 ns |  0.9431 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.0544 ns | 0.8791 ns | 0.0482 ns |  1.0277 ns |  1.10 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.4881 ns | 1.1753 ns | 0.0644 ns |  0.4760 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.4949 ns | 0.0050 ns | 0.0003 ns |  0.4951 ns |  1.03 |    0.13 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.0040 ns | 0.4043 ns | 0.0222 ns |  1.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.2177 ns | 0.0733 ns | 0.0040 ns |  1.2188 ns |  1.21 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.5403 ns | 0.4336 ns | 0.0238 ns |  0.5319 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.5416 ns | 0.4670 ns | 0.0256 ns |  0.5435 ns |  1.00 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.0307 ns | 0.0740 ns | 0.0041 ns |  1.0301 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2522 ns | 0.1677 ns | 0.0092 ns |  1.2506 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.5172 ns | 0.4413 ns | 0.0242 ns |  0.5109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7357 ns | 0.2071 ns | 0.0114 ns |  0.7300 ns |  1.42 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  0.8482 ns | 0.4165 ns | 0.0228 ns |  0.8565 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.0263 ns | 0.2489 ns | 0.0136 ns |  1.0235 ns |  1.21 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.5536 ns | 0.5469 ns | 0.0300 ns |  0.5580 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.7664 ns | 0.4810 ns | 0.0264 ns |  0.7527 ns |  1.39 |    0.12 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  0.9072 ns | 0.3639 ns | 0.0199 ns |  0.9138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  0.9392 ns | 0.8191 ns | 0.0449 ns |  0.9511 ns |  1.04 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.5163 ns | 0.1452 ns | 0.0080 ns |  0.5145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.7274 ns | 0.1229 ns | 0.0067 ns |  0.7278 ns |  1.41 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.0749 ns | 0.6037 ns | 0.0331 ns |  1.0575 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  0.9913 ns | 0.5740 ns | 0.0315 ns |  0.9833 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.5252 ns | 0.3068 ns | 0.0168 ns |  0.5170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.7499 ns | 0.4423 ns | 0.0242 ns |  0.7370 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.5267 ns | 0.5911 ns | 0.0324 ns |  1.5346 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.7894 ns | 0.6391 ns | 0.0350 ns |  1.7772 ns |  1.17 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.5225 ns | 0.2780 ns | 0.0152 ns |  0.5195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.6918 ns | 0.0677 ns | 0.0037 ns |  0.6923 ns |  1.32 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.6331 ns | 2.0038 ns | 0.1098 ns |  1.6510 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.5693 ns | 0.1579 ns | 0.0087 ns |  1.5715 ns |  0.96 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  2.1010 ns | 0.7005 ns | 0.0384 ns |  2.1200 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  2.3669 ns | 1.1698 ns | 0.0641 ns |  2.3586 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  2.5587 ns | 0.0705 ns | 0.0039 ns |  2.5577 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  2.6217 ns | 0.3469 ns | 0.0190 ns |  2.6123 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  2.0850 ns | 1.1512 ns | 0.0631 ns |  2.0678 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  2.0593 ns | 0.7582 ns | 0.0416 ns |  2.0374 ns |  0.99 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  3.7093 ns | 6.1366 ns | 0.3364 ns |  3.8648 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.1607 ns | 0.3033 ns | 0.0166 ns |  3.1652 ns |  0.86 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.0483 ns | 0.3871 ns | 0.0212 ns |  6.0404 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  7.7516 ns | 1.1135 ns | 0.0610 ns |  7.7666 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 12.4065 ns | 1.0043 ns | 0.0550 ns | 12.4325 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.1361 ns | 0.2258 ns | 0.0124 ns |  9.1393 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.5363 ns | 0.3353 ns | 0.0184 ns |  0.5458 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.6927 ns | 0.1957 ns | 0.0107 ns |  0.6892 ns |  1.29 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.3604 ns | 0.7111 ns | 0.0390 ns |  1.3505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.1816 ns | 0.4516 ns | 0.0248 ns |  1.1720 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.1817 ns | 0.5287 ns | 0.0290 ns |  2.1712 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0801 ns | 0.1357 ns | 0.0074 ns |  2.0759 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 11.2186 ns | 2.5344 ns | 0.1389 ns | 11.2256 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 10.0529 ns | 4.4337 ns | 0.2430 ns |  9.9706 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.5343 ns | 0.2707 ns | 0.0148 ns |  0.5401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7596 ns | 0.8214 ns | 0.0450 ns |  0.7462 ns |  1.42 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  0.8682 ns | 0.1236 ns | 0.0068 ns |  0.8691 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.2501 ns | 0.5372 ns | 0.0294 ns |  1.2385 ns |  1.44 |    0.02 |     - |     - |     - |         - |
