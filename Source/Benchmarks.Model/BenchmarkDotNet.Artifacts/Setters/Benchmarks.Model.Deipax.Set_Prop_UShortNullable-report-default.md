
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9229 ns | 0.1394 ns | 0.0076 ns |  0.9234 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.9530 ns | 0.4658 ns | 0.0255 ns |  0.9617 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.2552 ns | 0.9043 ns | 0.0496 ns |  1.2300 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.6754 ns | 0.6386 ns | 0.0350 ns |  1.6951 ns |  1.34 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.6986 ns | 0.0113 ns | 0.0006 ns |  0.6984 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.9270 ns | 0.3526 ns | 0.0193 ns |  0.9182 ns |  1.33 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.7229 ns | 0.4059 ns | 0.0222 ns |  1.7163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.2195 ns | 0.1577 ns | 0.0086 ns |  1.2150 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  1.0500 ns | 1.3232 ns | 0.0725 ns |  1.0165 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7740 ns | 0.2948 ns | 0.0162 ns |  0.7662 ns |  0.74 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.1923 ns | 0.1422 ns | 0.0078 ns |  1.1966 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.2493 ns | 1.2749 ns | 0.0699 ns |  1.2312 ns |  1.05 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.7199 ns | 0.9900 ns | 0.0543 ns |  0.6918 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7108 ns | 0.2307 ns | 0.0126 ns |  0.7063 ns |  0.99 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.2107 ns | 0.0204 ns | 0.0011 ns |  1.2111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.3014 ns | 0.5582 ns | 0.0306 ns |  1.2940 ns |  1.07 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.7548 ns | 1.0832 ns | 0.0594 ns |  0.7391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  1.0284 ns | 0.1403 ns | 0.0077 ns |  1.0274 ns |  1.37 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2043 ns | 0.5750 ns | 0.0315 ns |  1.2212 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.5010 ns | 1.0195 ns | 0.0559 ns |  1.4819 ns |  1.25 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.7145 ns | 0.4573 ns | 0.0251 ns |  0.7085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.9446 ns | 0.0404 ns | 0.0022 ns |  0.9440 ns |  1.32 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  0.6874 ns | 0.3722 ns | 0.0204 ns |  0.6812 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  0.7206 ns | 0.4137 ns | 0.0227 ns |  0.7194 ns |  1.05 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  1.7729 ns | 0.4947 ns | 0.0271 ns |  1.7677 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  1.0583 ns | 0.3664 ns | 0.0201 ns |  1.0470 ns |  0.60 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  2.4756 ns | 2.2931 ns | 0.1257 ns |  2.5003 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.3702 ns | 2.0618 ns | 0.1130 ns |  1.3655 ns |  0.55 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  1.0200 ns | 0.7687 ns | 0.0421 ns |  1.0384 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.9955 ns | 0.3656 ns | 0.0200 ns |  0.9913 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.3070 ns | 0.4859 ns | 0.0266 ns |  1.3154 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.3179 ns | 0.4056 ns | 0.0222 ns |  1.3288 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  2.2117 ns | 0.6792 ns | 0.0372 ns |  2.1927 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.8363 ns | 0.9966 ns | 0.0546 ns |  1.8101 ns |  0.83 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.4036 ns | 0.8213 ns | 0.0450 ns |  3.4122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  2.9377 ns | 1.0413 ns | 0.0571 ns |  2.9344 ns |  0.86 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  2.0313 ns | 0.8969 ns | 0.0492 ns |  2.0209 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.9578 ns | 0.0355 ns | 0.0019 ns |  1.9583 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  3.0106 ns | 0.0926 ns | 0.0051 ns |  3.0131 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  2.9961 ns | 0.8596 ns | 0.0471 ns |  3.0199 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.1844 ns | 2.0177 ns | 0.1106 ns |  4.1434 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  3.6216 ns | 1.7396 ns | 0.0954 ns |  3.5735 ns |  0.87 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  4.9625 ns | 0.3303 ns | 0.0181 ns |  4.9620 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  3.8650 ns | 1.0689 ns | 0.0586 ns |  3.8603 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  4.5022 ns | 0.9695 ns | 0.0531 ns |  4.4783 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  3.2357 ns | 0.1837 ns | 0.0101 ns |  3.2328 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  4.9590 ns | 1.7866 ns | 0.0979 ns |  4.9324 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.9847 ns | 0.6115 ns | 0.0335 ns |  3.9833 ns |  0.80 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  7.1472 ns | 1.8456 ns | 0.1012 ns |  7.1552 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  9.0834 ns | 2.4302 ns | 0.1332 ns |  9.0414 ns |  1.27 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 13.8561 ns | 0.5740 ns | 0.0315 ns | 13.8536 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 10.4954 ns | 1.1428 ns | 0.0626 ns | 10.4698 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.7340 ns | 0.2544 ns | 0.0139 ns |  0.7282 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7699 ns | 0.7519 ns | 0.0412 ns |  0.7843 ns |  1.05 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.6095 ns | 0.4173 ns | 0.0229 ns |  1.6159 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.4085 ns | 0.4684 ns | 0.0257 ns |  1.3992 ns |  0.88 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.6559 ns | 3.3805 ns | 0.1853 ns | 12.6921 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.8681 ns | 1.8374 ns | 0.1007 ns | 11.8251 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  9.3431 ns | 1.9322 ns | 0.1059 ns |  9.3979 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  8.1185 ns | 0.9311 ns | 0.0510 ns |  8.1357 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  1.9487 ns | 0.9700 ns | 0.0532 ns |  1.9225 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  1.1388 ns | 1.3023 ns | 0.0714 ns |  1.1058 ns |  0.58 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  2.3336 ns | 0.3555 ns | 0.0195 ns |  2.3258 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.7680 ns | 0.5384 ns | 0.0295 ns |  1.7676 ns |  0.76 |    0.02 |     - |     - |     - |         - |
