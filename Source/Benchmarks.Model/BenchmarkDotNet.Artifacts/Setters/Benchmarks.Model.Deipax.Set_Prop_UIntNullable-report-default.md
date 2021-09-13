
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9799 ns | 0.2394 ns | 0.0131 ns |  0.9817 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.7301 ns | 0.1447 ns | 0.0079 ns |  0.7331 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.2696 ns | 0.3220 ns | 0.0177 ns |  1.2625 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.4577 ns | 0.7098 ns | 0.0389 ns |  1.4447 ns |  1.15 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.7274 ns | 0.1645 ns | 0.0090 ns |  0.7249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.6906 ns | 0.3030 ns | 0.0166 ns |  0.6817 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.1660 ns | 0.4583 ns | 0.0251 ns |  1.1583 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.2128 ns | 1.0576 ns | 0.0580 ns |  1.2221 ns |  1.04 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.9535 ns | 0.3550 ns | 0.0195 ns |  0.9592 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7052 ns | 0.6225 ns | 0.0341 ns |  0.6939 ns |  0.74 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.2642 ns | 0.6993 ns | 0.0383 ns |  1.2679 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.1905 ns | 0.9482 ns | 0.0520 ns |  1.1788 ns |  0.94 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.6584 ns | 0.0422 ns | 0.0023 ns |  0.6590 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.6517 ns | 0.2063 ns | 0.0113 ns |  0.6466 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.1410 ns | 0.0371 ns | 0.0020 ns |  1.1417 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.0236 ns | 0.1074 ns | 0.0059 ns |  1.0264 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.6824 ns | 0.3084 ns | 0.0169 ns |  0.6758 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7663 ns | 0.5128 ns | 0.0281 ns |  0.7727 ns |  1.12 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.1315 ns | 0.0524 ns | 0.0029 ns |  1.1320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.1800 ns | 0.2525 ns | 0.0138 ns |  1.1799 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.7219 ns | 1.9993 ns | 0.1096 ns |  0.6648 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7251 ns | 0.4346 ns | 0.0238 ns |  0.7380 ns |  1.02 |    0.13 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.3664 ns | 2.1255 ns | 0.1165 ns |  1.4044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.2104 ns | 0.1761 ns | 0.0097 ns |  1.2120 ns |  0.89 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.9933 ns | 0.2967 ns | 0.0163 ns |  0.9845 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.7869 ns | 0.4100 ns | 0.0225 ns |  0.7747 ns |  0.79 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.2728 ns | 0.6139 ns | 0.0337 ns |  1.2587 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2199 ns | 0.6338 ns | 0.0347 ns |  1.2118 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.6823 ns | 0.2567 ns | 0.0141 ns |  0.6863 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  1.0287 ns | 0.2926 ns | 0.0160 ns |  1.0213 ns |  1.51 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.2184 ns | 5.1466 ns | 0.2821 ns |  1.3339 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  0.6464 ns | 0.1333 ns | 0.0073 ns |  0.6447 ns |  0.55 |    0.15 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.9944 ns | 0.1281 ns | 0.0070 ns |  1.9982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.8035 ns | 0.1239 ns | 0.0068 ns |  0.8045 ns |  0.40 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.4929 ns | 1.0596 ns | 0.0581 ns |  3.4736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.8105 ns | 0.3016 ns | 0.0165 ns |  1.8032 ns |  0.52 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.6923 ns | 0.3319 ns | 0.0182 ns |  0.6824 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.8183 ns | 0.4496 ns | 0.0246 ns |  0.8258 ns |  1.18 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.8713 ns | 0.5870 ns | 0.0322 ns |  1.8881 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.7527 ns | 0.4582 ns | 0.0251 ns |  1.7443 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  3.6036 ns | 0.7427 ns | 0.0407 ns |  3.5957 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  3.6273 ns | 1.0996 ns | 0.0603 ns |  3.6066 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  3.8384 ns | 1.4020 ns | 0.0769 ns |  3.8208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  3.7390 ns | 0.2145 ns | 0.0118 ns |  3.7354 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  3.1552 ns | 0.2755 ns | 0.0151 ns |  3.1580 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  3.2986 ns | 1.8156 ns | 0.0995 ns |  3.3372 ns |  1.05 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  4.2411 ns | 0.3611 ns | 0.0198 ns |  4.2392 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  4.1124 ns | 0.6110 ns | 0.0335 ns |  4.1299 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.4110 ns | 0.3968 ns | 0.0218 ns |  6.4148 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.3761 ns | 1.7033 ns | 0.0934 ns |  8.3398 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 13.0666 ns | 0.7466 ns | 0.0409 ns | 13.0753 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.7963 ns | 2.4915 ns | 0.1366 ns |  9.7237 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.7520 ns | 0.3040 ns | 0.0167 ns |  0.7454 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7806 ns | 0.3374 ns | 0.0185 ns |  0.7809 ns |  1.04 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.6026 ns | 0.4735 ns | 0.0260 ns |  1.6101 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.4455 ns | 0.3310 ns | 0.0181 ns |  1.4451 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.0837 ns | 0.1674 ns | 0.0092 ns | 12.0859 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.3389 ns | 0.3730 ns | 0.0204 ns | 11.3328 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 11.1697 ns | 0.1860 ns | 0.0102 ns | 11.1742 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  9.7251 ns | 1.7088 ns | 0.0937 ns |  9.6932 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7073 ns | 0.4277 ns | 0.0234 ns |  0.6961 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7868 ns | 0.5009 ns | 0.0275 ns |  0.7758 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.1214 ns | 0.8854 ns | 0.0485 ns |  1.1383 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.2697 ns | 0.1784 ns | 0.0098 ns |  1.2679 ns |  1.13 |    0.06 |     - |     - |     - |         - |
