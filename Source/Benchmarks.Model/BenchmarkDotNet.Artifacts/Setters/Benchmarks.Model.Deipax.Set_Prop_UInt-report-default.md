
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9249 ns | 0.0720 ns | 0.0039 ns |  0.9267 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.1793 ns | 0.1427 ns | 0.0078 ns |  1.1794 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.2200 ns | 0.2501 ns | 0.0137 ns |  1.2132 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.4516 ns | 0.0328 ns | 0.0018 ns |  1.4514 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.4863 ns | 0.3887 ns | 0.0213 ns |  0.4973 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7626 ns | 0.0611 ns | 0.0034 ns |  0.7643 ns |  1.57 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.9898 ns | 0.5083 ns | 0.0279 ns |  0.9960 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.2165 ns | 0.3630 ns | 0.0199 ns |  1.2209 ns |  1.23 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.9039 ns | 3.2818 ns | 0.1799 ns |  0.8853 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.9272 ns | 0.2197 ns | 0.0120 ns |  0.9218 ns |  1.05 |    0.20 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  0.9979 ns | 0.5199 ns | 0.0285 ns |  1.0087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.2135 ns | 0.6632 ns | 0.0364 ns |  1.1935 ns |  1.22 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.4705 ns | 0.3079 ns | 0.0169 ns |  0.4611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7014 ns | 0.0904 ns | 0.0050 ns |  0.7015 ns |  1.49 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  0.9580 ns | 0.0750 ns | 0.0041 ns |  0.9598 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.0223 ns | 0.4055 ns | 0.0222 ns |  1.0260 ns |  1.07 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.7045 ns | 0.3785 ns | 0.0207 ns |  0.6959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7331 ns | 0.3803 ns | 0.0208 ns |  0.7229 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  0.9783 ns | 0.1967 ns | 0.0108 ns |  0.9797 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.0159 ns | 0.0580 ns | 0.0032 ns |  1.0155 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.4805 ns | 0.2620 ns | 0.0144 ns |  0.4814 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7027 ns | 0.3080 ns | 0.0169 ns |  0.6958 ns |  1.46 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  0.9967 ns | 0.5741 ns | 0.0315 ns |  1.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.2204 ns | 0.1526 ns | 0.0084 ns |  1.2199 ns |  1.23 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.7098 ns | 0.2603 ns | 0.0143 ns |  0.7023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.7345 ns | 0.3663 ns | 0.0201 ns |  0.7282 ns |  1.04 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.1085 ns | 0.3412 ns | 0.0187 ns |  1.1099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2312 ns | 0.6106 ns | 0.0335 ns |  1.2449 ns |  1.11 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.7197 ns | 0.9280 ns | 0.0509 ns |  0.7259 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.4759 ns | 0.0918 ns | 0.0050 ns |  0.4739 ns |  0.66 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  0.9659 ns | 0.4857 ns | 0.0266 ns |  0.9527 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  0.9845 ns | 0.5511 ns | 0.0302 ns |  0.9802 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.6754 ns | 0.7439 ns | 0.0408 ns |  1.6843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.9391 ns | 0.3577 ns | 0.0196 ns |  0.9478 ns |  0.56 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.0264 ns | 1.4340 ns | 0.0786 ns |  3.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.7494 ns | 1.2185 ns | 0.0668 ns |  1.7220 ns |  0.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.6982 ns | 0.1243 ns | 0.0068 ns |  0.6959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.6932 ns | 0.1047 ns | 0.0057 ns |  0.6908 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.8497 ns | 0.5834 ns | 0.0320 ns |  1.8496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.7550 ns | 0.0840 ns | 0.0046 ns |  1.7569 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  3.5015 ns | 0.2357 ns | 0.0129 ns |  3.5000 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  3.5401 ns | 0.3577 ns | 0.0196 ns |  3.5438 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  3.5898 ns | 3.0190 ns | 0.1655 ns |  3.6196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  3.5005 ns | 0.9945 ns | 0.0545 ns |  3.4985 ns |  0.98 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  2.9889 ns | 0.1261 ns | 0.0069 ns |  2.9887 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  2.9635 ns | 0.3868 ns | 0.0212 ns |  2.9545 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  3.8666 ns | 0.8044 ns | 0.0441 ns |  3.8532 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.8586 ns | 1.2963 ns | 0.0711 ns |  3.8903 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.4585 ns | 3.1024 ns | 0.1701 ns |  6.4060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.3015 ns | 1.9697 ns | 0.1080 ns |  8.2425 ns |  1.29 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 12.4239 ns | 0.6101 ns | 0.0334 ns | 12.4176 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.4276 ns | 2.2033 ns | 0.1208 ns |  9.3716 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.6037 ns | 1.5657 ns | 0.0858 ns |  0.5952 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.5081 ns | 0.2175 ns | 0.0119 ns |  0.5020 ns |  0.85 |    0.14 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5067 ns | 0.9500 ns | 0.0521 ns |  1.5178 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2023 ns | 0.3860 ns | 0.0212 ns |  1.1901 ns |  0.80 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.1974 ns | 0.7680 ns | 0.0421 ns |  2.1894 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0725 ns | 0.0874 ns | 0.0048 ns |  2.0704 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 11.4254 ns | 0.4129 ns | 0.0226 ns | 11.4137 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 10.4609 ns | 2.9111 ns | 0.1596 ns | 10.4838 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7492 ns | 1.0536 ns | 0.0578 ns |  0.7191 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.6653 ns | 0.0266 ns | 0.0015 ns |  0.6655 ns |  0.89 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.0255 ns | 0.4856 ns | 0.0266 ns |  1.0147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.0444 ns | 0.8485 ns | 0.0465 ns |  1.0304 ns |  1.02 |    0.02 |     - |     - |     - |         - |
