
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 1.0084 ns | 0.7590 ns | 0.0416 ns | 0.9849 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.9348 ns | 0.0959 ns | 0.0053 ns | 0.9375 ns |  0.93 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.0406 ns | 0.5213 ns | 0.0286 ns | 1.0347 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.5278 ns | 1.2471 ns | 0.0684 ns | 1.5278 ns |  1.47 |    0.11 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.5890 ns | 0.1541 ns | 0.0084 ns | 0.5867 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.7396 ns | 0.2343 ns | 0.0128 ns | 0.7418 ns |  1.26 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 0.9245 ns | 0.1532 ns | 0.0084 ns | 0.9267 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 0.7261 ns | 0.1455 ns | 0.0080 ns | 0.7284 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.7174 ns | 0.0310 ns | 0.0017 ns | 0.7166 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.6394 ns | 0.7841 ns | 0.0430 ns | 0.6157 ns |  0.89 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.2209 ns | 0.2456 ns | 0.0135 ns | 1.2252 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.0124 ns | 0.1228 ns | 0.0067 ns | 1.0157 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.9126 ns | 0.1107 ns | 0.0061 ns | 0.9138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.6208 ns | 0.2628 ns | 0.0144 ns | 0.6185 ns |  0.68 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.0552 ns | 0.9129 ns | 0.0500 ns | 1.0289 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.2766 ns | 0.7776 ns | 0.0426 ns | 1.2982 ns |  1.21 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.9113 ns | 0.0486 ns | 0.0027 ns | 0.9112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.9753 ns | 0.9107 ns | 0.0499 ns | 0.9592 ns |  1.07 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.2269 ns | 0.5231 ns | 0.0287 ns | 1.2108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.2290 ns | 0.4735 ns | 0.0260 ns | 1.2194 ns |  1.00 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.7184 ns | 0.3871 ns | 0.0212 ns | 0.7089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.7409 ns | 0.3947 ns | 0.0216 ns | 0.7424 ns |  1.03 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.2419 ns | 1.3628 ns | 0.0747 ns | 1.2153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.2127 ns | 0.2953 ns | 0.0162 ns | 1.2151 ns |  0.98 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 0.8457 ns | 1.2159 ns | 0.0666 ns | 0.8583 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.7378 ns | 0.4358 ns | 0.0239 ns | 0.7416 ns |  0.87 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.1794 ns | 0.0916 ns | 0.0050 ns | 1.1779 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.2164 ns | 1.1109 ns | 0.0609 ns | 1.1856 ns |  1.03 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 1.0334 ns | 0.3662 ns | 0.0201 ns | 1.0246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.8483 ns | 0.7671 ns | 0.0420 ns | 0.8276 ns |  0.82 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.2429 ns | 0.6175 ns | 0.0338 ns | 1.2527 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.2526 ns | 0.0293 ns | 0.0016 ns | 1.2521 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 1.0025 ns | 0.9475 ns | 0.0519 ns | 0.9820 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 0.7652 ns | 0.1037 ns | 0.0057 ns | 0.7632 ns |  0.76 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.7919 ns | 0.7219 ns | 0.0396 ns | 1.7692 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.6358 ns | 0.3398 ns | 0.0186 ns | 1.6286 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 0.9509 ns | 0.7442 ns | 0.0408 ns | 0.9288 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 0.8166 ns | 0.7766 ns | 0.0426 ns | 0.8240 ns |  0.86 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.9453 ns | 0.4584 ns | 0.0251 ns | 1.9315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.9576 ns | 0.7002 ns | 0.0384 ns | 1.9734 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 0.7551 ns | 0.9705 ns | 0.0532 ns | 0.7263 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 0.7660 ns | 0.1663 ns | 0.0091 ns | 0.7686 ns |  1.02 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 0.7150 ns | 0.0497 ns | 0.0027 ns | 0.7162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 0.6336 ns | 0.1714 ns | 0.0094 ns | 0.6284 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 0.7953 ns | 0.7921 ns | 0.0434 ns | 0.8145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 0.7099 ns | 0.5236 ns | 0.0287 ns | 0.7253 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 1.8796 ns | 1.1909 ns | 0.0653 ns | 1.8584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.8156 ns | 0.5068 ns | 0.0278 ns | 1.8018 ns |  0.97 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 5.6084 ns | 0.2911 ns | 0.0160 ns | 5.6007 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 4.3189 ns | 0.3469 ns | 0.0190 ns | 4.3187 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.7071 ns | 1.5866 ns | 0.0870 ns | 2.7355 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.3673 ns | 0.3546 ns | 0.0194 ns | 2.3627 ns |  0.87 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7639 ns | 0.3517 ns | 0.0193 ns | 0.7606 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7720 ns | 0.6043 ns | 0.0331 ns | 0.7677 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.6007 ns | 0.3688 ns | 0.0202 ns | 1.5988 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.3223 ns | 1.4306 ns | 0.0784 ns | 1.3675 ns |  0.83 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.8169 ns | 1.5643 ns | 0.0857 ns | 2.7696 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 3.0126 ns | 4.1617 ns | 0.2281 ns | 3.1280 ns |  1.07 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9858 ns | 2.0859 ns | 0.1143 ns | 1.9321 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.8758 ns | 0.4776 ns | 0.0262 ns | 1.8859 ns |  0.95 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 0.7363 ns | 0.3879 ns | 0.0213 ns | 0.7391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.7227 ns | 0.3082 ns | 0.0169 ns | 0.7132 ns |  0.98 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.1241 ns | 0.1111 ns | 0.0061 ns | 1.1276 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.2126 ns | 1.0634 ns | 0.0583 ns | 1.2011 ns |  1.08 |    0.05 |     - |     - |     - |         - |
