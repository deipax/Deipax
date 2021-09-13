
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9563 ns | 0.4040 ns | 0.0221 ns |  0.9628 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.1754 ns | 0.1187 ns | 0.0065 ns |  1.1749 ns |  1.23 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.5588 ns | 0.1627 ns | 0.0089 ns |  1.5564 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.5256 ns | 0.7330 ns | 0.0402 ns |  1.5423 ns |  0.98 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.5864 ns | 0.2981 ns | 0.0163 ns |  0.5860 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7607 ns | 0.1761 ns | 0.0097 ns |  0.7570 ns |  1.30 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.7721 ns | 0.5418 ns | 0.0297 ns |  0.7625 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.9768 ns | 0.3087 ns | 0.0169 ns |  0.9845 ns |  1.27 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.7804 ns | 0.5148 ns | 0.0282 ns |  0.7891 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7899 ns | 0.5274 ns | 0.0289 ns |  0.7835 ns |  1.01 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.1037 ns | 0.7175 ns | 0.0393 ns |  1.0855 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.3208 ns | 0.4691 ns | 0.0257 ns |  1.3082 ns |  1.20 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.9950 ns | 0.5542 ns | 0.0304 ns |  0.9789 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7602 ns | 0.5106 ns | 0.0280 ns |  0.7552 ns |  0.76 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.0975 ns | 0.1875 ns | 0.0103 ns |  1.0922 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.3419 ns | 0.5220 ns | 0.0286 ns |  1.3364 ns |  1.22 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.9982 ns | 0.8999 ns | 0.0493 ns |  0.9748 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.9611 ns | 0.1512 ns | 0.0083 ns |  0.9581 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2796 ns | 0.8010 ns | 0.0439 ns |  1.2849 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.3371 ns | 0.5122 ns | 0.0281 ns |  1.3287 ns |  1.05 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.9733 ns | 0.6550 ns | 0.0359 ns |  0.9598 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.9506 ns | 0.0825 ns | 0.0045 ns |  0.9486 ns |  0.98 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.2742 ns | 0.5226 ns | 0.0286 ns |  1.2639 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.5414 ns | 0.0177 ns | 0.0010 ns |  1.5408 ns |  1.21 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.9640 ns | 0.5301 ns | 0.0291 ns |  0.9492 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  1.0077 ns | 0.5422 ns | 0.0297 ns |  1.0018 ns |  1.05 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.3415 ns | 1.3934 ns | 0.0764 ns |  1.3380 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.3708 ns | 1.4619 ns | 0.0801 ns |  1.3392 ns |  1.03 |    0.11 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.8227 ns | 0.0758 ns | 0.0042 ns |  0.8245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.9869 ns | 0.1096 ns | 0.0060 ns |  0.9869 ns |  1.20 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.3261 ns | 0.0708 ns | 0.0039 ns |  1.3252 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.5162 ns | 0.4298 ns | 0.0236 ns |  1.5096 ns |  1.14 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.7960 ns | 0.4402 ns | 0.0241 ns |  0.7830 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.7685 ns | 0.5332 ns | 0.0292 ns |  0.7539 ns |  0.97 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.8832 ns | 2.3530 ns | 0.1290 ns |  1.8089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.9482 ns | 0.4632 ns | 0.0254 ns |  1.9445 ns |  1.04 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  1.0464 ns | 0.9172 ns | 0.0503 ns |  1.0284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.8390 ns | 0.1361 ns | 0.0075 ns |  0.8393 ns |  0.80 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  2.1809 ns | 0.4081 ns | 0.0224 ns |  2.1858 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  2.2192 ns | 0.9106 ns | 0.0499 ns |  2.2128 ns |  1.02 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  0.7716 ns | 0.4701 ns | 0.0258 ns |  0.7642 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  0.9264 ns | 0.0672 ns | 0.0037 ns |  0.9260 ns |  1.20 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  0.6954 ns | 1.0474 ns | 0.0574 ns |  0.6667 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  0.7081 ns | 0.4990 ns | 0.0274 ns |  0.6955 ns |  1.02 |    0.11 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  0.6429 ns | 0.1195 ns | 0.0066 ns |  0.6420 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  0.7331 ns | 0.4267 ns | 0.0234 ns |  0.7383 ns |  1.14 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  1.8430 ns | 0.4260 ns | 0.0234 ns |  1.8492 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  1.8385 ns | 0.7130 ns | 0.0391 ns |  1.8519 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  5.7181 ns | 1.6091 ns | 0.0882 ns |  5.7185 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  4.7085 ns | 0.2859 ns | 0.0157 ns |  4.7149 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 18.5736 ns | 0.7805 ns | 0.0428 ns | 18.5518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  5.5724 ns | 0.5218 ns | 0.0286 ns |  5.5831 ns |  0.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.8081 ns | 0.2421 ns | 0.0133 ns |  0.8147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7394 ns | 0.0502 ns | 0.0028 ns |  0.7390 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.6184 ns | 0.6613 ns | 0.0363 ns |  1.6246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.3434 ns | 1.9506 ns | 0.1069 ns |  1.3465 ns |  0.83 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 13.0990 ns | 6.9935 ns | 0.3833 ns | 13.0105 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.6793 ns | 3.3247 ns | 0.1822 ns | 11.5974 ns |  0.89 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 47.3433 ns | 0.4579 ns | 0.0251 ns | 47.3349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 40.3328 ns | 2.5903 ns | 0.1420 ns | 40.2901 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.8267 ns | 0.6599 ns | 0.0362 ns |  0.8198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7775 ns | 0.1689 ns | 0.0093 ns |  0.7757 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.3153 ns | 1.5155 ns | 0.0831 ns |  1.2796 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.3083 ns | 0.5922 ns | 0.0325 ns |  1.2962 ns |  1.00 |    0.08 |     - |     - |     - |         - |
