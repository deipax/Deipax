
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.7409 ns | 0.7180 ns | 0.0394 ns | 0.7382 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 1.0356 ns | 0.4733 ns | 0.0259 ns | 1.0228 ns |  1.40 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 0.7184 ns | 1.6992 ns | 0.0931 ns | 0.7715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 0.9491 ns | 3.7419 ns | 0.2051 ns | 0.9109 ns |  1.33 |    0.29 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.5869 ns | 0.1448 ns | 0.0079 ns | 0.5830 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.7390 ns | 0.0798 ns | 0.0044 ns | 0.7366 ns |  1.26 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 0.8229 ns | 0.0989 ns | 0.0054 ns | 0.8209 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 0.9753 ns | 0.1280 ns | 0.0070 ns | 0.9740 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.6319 ns | 0.1716 ns | 0.0094 ns | 0.6320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.9864 ns | 0.7681 ns | 0.0421 ns | 0.9973 ns |  1.56 |    0.09 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 0.9952 ns | 0.7271 ns | 0.0399 ns | 0.9830 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 2.0232 ns | 3.5557 ns | 0.1949 ns | 2.0851 ns |  2.04 |    0.27 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.6987 ns | 0.1148 ns | 0.0063 ns | 0.6999 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.7818 ns | 0.2594 ns | 0.0142 ns | 0.7783 ns |  1.12 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.0797 ns | 0.5849 ns | 0.0321 ns | 1.0643 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.2748 ns | 0.2430 ns | 0.0133 ns | 1.2677 ns |  1.18 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.8385 ns | 0.6105 ns | 0.0335 ns | 0.8491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 1.0030 ns | 0.2970 ns | 0.0163 ns | 1.0098 ns |  1.20 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.3792 ns | 1.4317 ns | 0.0785 ns | 1.3653 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.2941 ns | 0.2159 ns | 0.0118 ns | 1.2965 ns |  0.94 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.7681 ns | 0.2400 ns | 0.0132 ns | 0.7666 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.7811 ns | 0.2036 ns | 0.0112 ns | 0.7776 ns |  1.02 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.1470 ns | 0.1113 ns | 0.0061 ns | 1.1436 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.2579 ns | 0.2410 ns | 0.0132 ns | 1.2578 ns |  1.10 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 0.8093 ns | 0.4580 ns | 0.0251 ns | 0.8039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.8023 ns | 0.1780 ns | 0.0098 ns | 0.8012 ns |  0.99 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.3327 ns | 2.6153 ns | 0.1434 ns | 1.3023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.5161 ns | 4.8441 ns | 0.2655 ns | 1.4122 ns |  1.16 |    0.32 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.7555 ns | 0.0676 ns | 0.0037 ns | 0.7572 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.9751 ns | 4.6473 ns | 0.2547 ns | 0.9079 ns |  1.29 |    0.33 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.2386 ns | 0.2524 ns | 0.0138 ns | 1.2363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.2021 ns | 0.3867 ns | 0.0212 ns | 1.1919 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 0.7241 ns | 0.1535 ns | 0.0084 ns | 0.7208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 0.4943 ns | 0.2246 ns | 0.0123 ns | 0.4992 ns |  0.68 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.7408 ns | 1.3497 ns | 0.0740 ns | 1.7070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.5339 ns | 0.2761 ns | 0.0151 ns | 1.5256 ns |  0.88 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 0.7254 ns | 0.2338 ns | 0.0128 ns | 0.7298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 0.7013 ns | 0.3493 ns | 0.0191 ns | 0.6987 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.6504 ns | 0.3463 ns | 0.0190 ns | 1.6414 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.7611 ns | 0.2492 ns | 0.0137 ns | 1.7551 ns |  1.07 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 1.0701 ns | 0.5023 ns | 0.0275 ns | 1.0788 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 1.0370 ns | 3.8253 ns | 0.2097 ns | 0.9330 ns |  0.97 |    0.22 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.1974 ns | 0.4909 ns | 0.0269 ns | 1.1873 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.2622 ns | 0.0968 ns | 0.0053 ns | 1.2648 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 1.0370 ns | 0.4809 ns | 0.0264 ns | 1.0384 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 0.9167 ns | 1.0439 ns | 0.0572 ns | 0.9481 ns |  0.88 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 1.8646 ns | 0.8910 ns | 0.0488 ns | 1.8536 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.8143 ns | 0.3688 ns | 0.0202 ns | 1.8111 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 5.4328 ns | 0.3536 ns | 0.0194 ns | 5.4246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 7.0004 ns | 0.2470 ns | 0.0135 ns | 6.9965 ns |  1.29 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 3.0003 ns | 1.4277 ns | 0.0783 ns | 2.9740 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.8919 ns | 6.7900 ns | 0.3722 ns | 2.8159 ns |  0.96 |    0.13 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7099 ns | 0.1550 ns | 0.0085 ns | 0.7065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7341 ns | 0.1888 ns | 0.0104 ns | 0.7323 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.6766 ns | 0.3891 ns | 0.0213 ns | 1.6668 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.2755 ns | 0.2249 ns | 0.0123 ns | 1.2811 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 3.0235 ns | 5.0121 ns | 0.2747 ns | 2.8678 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.7315 ns | 0.8692 ns | 0.0476 ns | 2.7164 ns |  0.91 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.7810 ns | 0.3002 ns | 0.0165 ns | 1.7876 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.7926 ns | 0.4463 ns | 0.0245 ns | 1.7825 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 0.9668 ns | 0.0296 ns | 0.0016 ns | 0.9676 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.7540 ns | 0.0197 ns | 0.0011 ns | 0.7538 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.2219 ns | 0.3643 ns | 0.0200 ns | 1.2257 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.1556 ns | 0.3583 ns | 0.0196 ns | 1.1508 ns |  0.95 |    0.01 |     - |     - |     - |         - |
