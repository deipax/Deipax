
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 1.0120 ns | 0.6468 ns | 0.0355 ns | 1.0005 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.9426 ns | 0.1787 ns | 0.0098 ns | 0.9472 ns |  0.93 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.4864 ns | 0.7312 ns | 0.0401 ns | 1.4896 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.1997 ns | 0.5615 ns | 0.0308 ns | 1.1875 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.7110 ns | 0.5109 ns | 0.0280 ns | 0.7242 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.5462 ns | 0.3252 ns | 0.0178 ns | 0.5467 ns |  0.77 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.2708 ns | 1.5734 ns | 0.0862 ns | 1.3163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.2456 ns | 0.8966 ns | 0.0491 ns | 1.2206 ns |  0.99 |    0.11 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.8687 ns | 3.0439 ns | 0.1668 ns | 0.9500 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 1.7399 ns | 8.4273 ns | 0.4619 ns | 1.6554 ns |  2.00 |    0.27 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.2078 ns | 2.7054 ns | 0.1483 ns | 1.1588 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.1645 ns | 0.6562 ns | 0.0360 ns | 1.1597 ns |  0.97 |    0.11 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.8179 ns | 0.1810 ns | 0.0099 ns | 0.8209 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.9274 ns | 0.1923 ns | 0.0105 ns | 0.9251 ns |  1.13 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.0047 ns | 0.5595 ns | 0.0307 ns | 0.9873 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.0061 ns | 0.1304 ns | 0.0071 ns | 1.0083 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.8495 ns | 0.9513 ns | 0.0521 ns | 0.8298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.6214 ns | 0.3534 ns | 0.0194 ns | 0.6321 ns |  0.73 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.1542 ns | 0.6751 ns | 0.0370 ns | 1.1664 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.1387 ns | 0.2798 ns | 0.0153 ns | 1.1409 ns |  0.99 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.7014 ns | 0.2704 ns | 0.0148 ns | 0.7022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.5388 ns | 0.0642 ns | 0.0035 ns | 0.5382 ns |  0.77 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.2250 ns | 0.8877 ns | 0.0487 ns | 1.2112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.1335 ns | 0.7356 ns | 0.0403 ns | 1.1159 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 0.9568 ns | 0.2445 ns | 0.0134 ns | 0.9546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.7707 ns | 0.2229 ns | 0.0122 ns | 0.7703 ns |  0.81 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.1306 ns | 0.4193 ns | 0.0230 ns | 1.1209 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.1163 ns | 0.1101 ns | 0.0060 ns | 1.1153 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.9447 ns | 0.5702 ns | 0.0313 ns | 0.9281 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.6543 ns | 0.0170 ns | 0.0009 ns | 0.6545 ns |  0.69 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.2216 ns | 0.7719 ns | 0.0423 ns | 1.2112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.1393 ns | 0.9060 ns | 0.0497 ns | 1.1454 ns |  0.93 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 0.7039 ns | 0.1503 ns | 0.0082 ns | 0.7026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 0.7160 ns | 0.3761 ns | 0.0206 ns | 0.7153 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.5985 ns | 1.0109 ns | 0.0554 ns | 1.5780 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.7775 ns | 0.2139 ns | 0.0117 ns | 1.7719 ns |  1.11 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 0.7155 ns | 0.5114 ns | 0.0280 ns | 0.7285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 0.7189 ns | 0.0382 ns | 0.0021 ns | 0.7196 ns |  1.01 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.2636 ns | 0.4766 ns | 0.0261 ns | 1.2624 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.2124 ns | 0.5523 ns | 0.0303 ns | 1.1950 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 2.4637 ns | 0.8378 ns | 0.0459 ns | 2.4433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 2.3879 ns | 2.3624 ns | 0.1295 ns | 2.4259 ns |  0.97 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 2.1224 ns | 6.2952 ns | 0.3451 ns | 1.9985 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.7850 ns | 0.5842 ns | 0.0320 ns | 1.7840 ns |  0.85 |    0.12 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 2.1345 ns | 0.6539 ns | 0.0358 ns | 2.1344 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 2.0540 ns | 0.6180 ns | 0.0339 ns | 2.0402 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.1028 ns | 2.6159 ns | 0.1434 ns | 2.0540 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 2.0251 ns | 0.2761 ns | 0.0151 ns | 2.0171 ns |  0.97 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 6.4651 ns | 0.1034 ns | 0.0057 ns | 6.4650 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 8.1443 ns | 0.1504 ns | 0.0082 ns | 8.1482 ns |  1.26 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.7396 ns | 0.3292 ns | 0.0180 ns | 2.7304 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.4648 ns | 1.1253 ns | 0.0617 ns | 2.4477 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.8019 ns | 0.4518 ns | 0.0248 ns | 0.7929 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.6568 ns | 0.0222 ns | 0.0012 ns | 0.6575 ns |  0.82 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.5599 ns | 0.4332 ns | 0.0237 ns | 1.5557 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.1948 ns | 0.1848 ns | 0.0101 ns | 1.1994 ns |  0.77 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.8063 ns | 0.1007 ns | 0.0055 ns | 2.8068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.8973 ns | 0.6801 ns | 0.0373 ns | 2.8773 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9397 ns | 0.2881 ns | 0.0158 ns | 1.9431 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.7448 ns | 0.0486 ns | 0.0027 ns | 1.7439 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 0.8664 ns | 0.4771 ns | 0.0262 ns | 0.8561 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.7138 ns | 0.1359 ns | 0.0074 ns | 0.7122 ns |  0.82 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.1320 ns | 0.1355 ns | 0.0074 ns | 1.1297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.2919 ns | 6.5111 ns | 0.3569 ns | 1.0946 ns |  1.14 |    0.32 |     - |     - |     - |         - |
