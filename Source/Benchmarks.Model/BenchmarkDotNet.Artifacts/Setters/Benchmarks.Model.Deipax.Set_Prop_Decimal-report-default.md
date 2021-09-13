
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  6.2937 ns | 0.0748 ns | 0.0041 ns |  6.2959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.2010 ns | 0.3143 ns | 0.0172 ns |  1.1974 ns |  0.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  6.4389 ns | 0.3247 ns | 0.0178 ns |  6.4484 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.7230 ns | 0.6461 ns | 0.0354 ns |  1.7233 ns |  0.27 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  1.2373 ns | 2.5837 ns | 0.1416 ns |  1.3080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  1.2414 ns | 0.4244 ns | 0.0233 ns |  1.2310 ns |  1.01 |    0.14 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.5352 ns | 0.2164 ns | 0.0119 ns |  1.5359 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.4691 ns | 0.1028 ns | 0.0056 ns |  1.4676 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  6.4558 ns | 0.5549 ns | 0.0304 ns |  6.4729 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.8011 ns | 0.0188 ns | 0.0010 ns |  0.8010 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  6.8932 ns | 1.8435 ns | 0.1010 ns |  6.9405 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.2493 ns | 0.3468 ns | 0.0190 ns |  1.2559 ns |  0.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  6.1689 ns | 1.8228 ns | 0.0999 ns |  6.2150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7121 ns | 0.4763 ns | 0.0261 ns |  0.7003 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  6.3968 ns | 2.0518 ns | 0.1125 ns |  6.4574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.1332 ns | 0.5018 ns | 0.0275 ns |  1.1272 ns |  0.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  6.4216 ns | 1.1448 ns | 0.0628 ns |  6.4370 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7959 ns | 0.1960 ns | 0.0107 ns |  0.7925 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  6.4225 ns | 1.5483 ns | 0.0849 ns |  6.4175 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.6311 ns | 0.5645 ns | 0.0309 ns |  1.6353 ns |  0.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  6.4423 ns | 1.8322 ns | 0.1004 ns |  6.4914 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7582 ns | 0.2062 ns | 0.0113 ns |  0.7621 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  6.6298 ns | 1.7023 ns | 0.0933 ns |  6.6653 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.3331 ns | 0.4931 ns | 0.0270 ns |  1.3239 ns |  0.20 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  6.1135 ns | 0.4662 ns | 0.0256 ns |  6.1070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.9739 ns | 0.3183 ns | 0.0174 ns |  0.9721 ns |  0.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  7.0198 ns | 7.8963 ns | 0.4328 ns |  7.1312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.4754 ns | 0.1193 ns | 0.0065 ns |  1.4786 ns |  0.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  6.5470 ns | 1.5732 ns | 0.0862 ns |  6.5244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.9864 ns | 0.0145 ns | 0.0008 ns |  0.9867 ns |  0.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  6.4525 ns | 1.6953 ns | 0.0929 ns |  6.4730 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.4105 ns | 1.2961 ns | 0.0710 ns |  1.4308 ns |  0.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  6.4387 ns | 1.2419 ns | 0.0681 ns |  6.4443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.2269 ns | 0.3624 ns | 0.0199 ns |  1.2169 ns |  0.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  6.9552 ns | 0.1999 ns | 0.0110 ns |  6.9541 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.9444 ns | 0.4926 ns | 0.0270 ns |  1.9497 ns |  0.28 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  6.4967 ns | 0.5333 ns | 0.0292 ns |  6.4842 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.9321 ns | 0.0539 ns | 0.0030 ns |  0.9319 ns |  0.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  7.2051 ns | 0.0797 ns | 0.0044 ns |  7.2066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.8208 ns | 2.2309 ns | 0.1223 ns |  1.8105 ns |  0.25 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 10.8137 ns | 0.7199 ns | 0.0395 ns | 10.7910 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  9.3397 ns | 1.4625 ns | 0.0802 ns |  9.3251 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 10.8251 ns | 0.7950 ns | 0.0436 ns | 10.8435 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 10.0056 ns | 3.6553 ns | 0.2004 ns | 10.0123 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 12.0098 ns | 5.4899 ns | 0.3009 ns | 12.1178 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 10.1354 ns | 0.3898 ns | 0.0214 ns | 10.1258 ns |  0.84 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 12.4303 ns | 1.1932 ns | 0.0654 ns | 12.4031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 11.2277 ns | 2.0515 ns | 0.1124 ns | 11.2774 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  1.4582 ns | 2.1846 ns | 0.1197 ns |  1.4223 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  1.2248 ns | 1.0045 ns | 0.0551 ns |  1.2183 ns |  0.84 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |  3.9412 ns | 0.2430 ns | 0.0133 ns |  3.9469 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  3.9723 ns | 1.1512 ns | 0.0631 ns |  3.9412 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  1.5263 ns | 0.2102 ns | 0.0115 ns |  1.5256 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  1.5711 ns | 0.3029 ns | 0.0166 ns |  1.5687 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.9086 ns | 0.4329 ns | 0.0237 ns |  1.9023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2999 ns | 0.0813 ns | 0.0045 ns |  1.2976 ns |  0.68 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.8280 ns | 0.7117 ns | 0.0390 ns |  2.8153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.2085 ns | 0.6341 ns | 0.0348 ns |  2.2096 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 47.2140 ns | 9.5952 ns | 0.5259 ns | 47.0726 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 46.2146 ns | 7.7564 ns | 0.4252 ns | 46.3431 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  6.6478 ns | 3.1382 ns | 0.1720 ns |  6.5550 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.9654 ns | 0.3043 ns | 0.0167 ns |  0.9595 ns |  0.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  6.7253 ns | 0.5100 ns | 0.0280 ns |  6.7357 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.4079 ns | 0.2436 ns | 0.0134 ns |  1.4081 ns |  0.21 |    0.00 |     - |     - |     - |         - |
