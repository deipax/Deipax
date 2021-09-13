
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  1.0215 ns | 0.2803 ns | 0.0154 ns |  1.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.2431 ns | 0.9115 ns | 0.0500 ns |  1.2558 ns |  1.22 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.0505 ns | 0.0915 ns | 0.0050 ns |  1.0521 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.2374 ns | 0.2127 ns | 0.0117 ns |  1.2387 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.5523 ns | 0.1700 ns | 0.0093 ns |  0.5570 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7483 ns | 0.2985 ns | 0.0164 ns |  0.7462 ns |  1.35 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.1455 ns | 0.9544 ns | 0.0523 ns |  1.1742 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.2720 ns | 0.6499 ns | 0.0356 ns |  1.2749 ns |  1.11 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.6151 ns | 2.3439 ns | 0.1285 ns |  0.6217 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7418 ns | 0.5900 ns | 0.0323 ns |  0.7233 ns |  1.24 |    0.23 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  0.7997 ns | 0.3236 ns | 0.0177 ns |  0.8094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.0167 ns | 0.6756 ns | 0.0370 ns |  1.0208 ns |  1.27 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.5172 ns | 0.2111 ns | 0.0116 ns |  0.5218 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.6890 ns | 0.1151 ns | 0.0063 ns |  0.6910 ns |  1.33 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  0.7816 ns | 0.2283 ns | 0.0125 ns |  0.7827 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  0.9895 ns | 0.4955 ns | 0.0272 ns |  0.9817 ns |  1.27 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.5192 ns | 0.3273 ns | 0.0179 ns |  0.5183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.6886 ns | 0.0573 ns | 0.0031 ns |  0.6887 ns |  1.33 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  0.9753 ns | 0.4969 ns | 0.0272 ns |  0.9635 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  0.9781 ns | 0.4870 ns | 0.0267 ns |  0.9679 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.5917 ns | 1.1070 ns | 0.0607 ns |  0.5867 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7794 ns | 0.3046 ns | 0.0167 ns |  0.7835 ns |  1.32 |    0.11 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.0267 ns | 0.3037 ns | 0.0166 ns |  1.0238 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.2315 ns | 0.2169 ns | 0.0119 ns |  1.2299 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  1.5880 ns | 0.3341 ns | 0.0183 ns |  1.5982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  1.7966 ns | 0.5954 ns | 0.0326 ns |  1.7820 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.9209 ns | 0.8372 ns | 0.0459 ns |  1.9321 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  2.9504 ns | 1.4045 ns | 0.0770 ns |  2.9477 ns |  1.54 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  1.5704 ns | 0.5305 ns | 0.0291 ns |  1.5616 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.7454 ns | 0.3074 ns | 0.0169 ns |  0.7519 ns |  0.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  2.4571 ns | 4.1093 ns | 0.2252 ns |  2.3385 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  0.9146 ns | 0.6769 ns | 0.0371 ns |  0.9132 ns |  0.37 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.5665 ns | 0.0963 ns | 0.0053 ns |  1.5659 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.9102 ns | 0.0977 ns | 0.0054 ns |  1.9100 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  2.7342 ns | 0.1876 ns | 0.0103 ns |  2.7331 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  3.2336 ns | 1.5590 ns | 0.0855 ns |  3.2231 ns |  1.18 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  1.6127 ns | 1.4150 ns | 0.0776 ns |  1.6330 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.6149 ns | 1.1378 ns | 0.0624 ns |  1.5853 ns |  1.00 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  2.7880 ns | 0.9599 ns | 0.0526 ns |  2.7623 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  3.0234 ns | 0.5025 ns | 0.0275 ns |  3.0182 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.0643 ns | 1.7604 ns | 0.0965 ns |  4.0128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  4.0441 ns | 1.4823 ns | 0.0812 ns |  4.0861 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  4.4819 ns | 1.2639 ns | 0.0693 ns |  4.4466 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  4.7637 ns | 0.4993 ns | 0.0274 ns |  4.7605 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  3.9178 ns | 0.1146 ns | 0.0063 ns |  3.9157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  3.8721 ns | 0.2192 ns | 0.0120 ns |  3.8753 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  5.5912 ns | 1.0608 ns | 0.0581 ns |  5.5584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  5.0121 ns | 1.4403 ns | 0.0789 ns |  4.9731 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.9078 ns | 0.6418 ns | 0.0352 ns |  6.9258 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.9963 ns | 0.4195 ns | 0.0230 ns |  9.0052 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 13.2575 ns | 1.5161 ns | 0.0831 ns | 13.2660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 10.2961 ns | 6.3153 ns | 0.3462 ns | 10.2497 ns |  0.78 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.5198 ns | 0.0813 ns | 0.0045 ns |  0.5205 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.4820 ns | 0.2370 ns | 0.0130 ns |  0.4763 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5032 ns | 1.1536 ns | 0.0632 ns |  1.4766 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2322 ns | 0.4568 ns | 0.0250 ns |  1.2232 ns |  0.82 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.1934 ns | 0.3130 ns | 0.0172 ns |  2.1842 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0890 ns | 0.4807 ns | 0.0263 ns |  2.0874 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  9.7536 ns | 1.4664 ns | 0.0804 ns |  9.7120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  7.8251 ns | 1.5695 ns | 0.0860 ns |  7.7776 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  1.6084 ns | 0.7678 ns | 0.0421 ns |  1.6247 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  1.9628 ns | 0.6161 ns | 0.0338 ns |  1.9553 ns |  1.22 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  2.0261 ns | 0.9688 ns | 0.0531 ns |  2.0505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  2.0154 ns | 1.0105 ns | 0.0554 ns |  2.0404 ns |  1.00 |    0.05 |     - |     - |     - |         - |
