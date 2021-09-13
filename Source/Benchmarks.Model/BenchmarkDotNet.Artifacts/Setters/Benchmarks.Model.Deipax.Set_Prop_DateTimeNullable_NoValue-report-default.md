
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 7.8780 ns | 0.0567 ns | 0.0031 ns | 7.8796 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.9339 ns | 0.0770 ns | 0.0042 ns | 0.9321 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 7.9111 ns | 1.5596 ns | 0.0855 ns | 7.9447 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.2249 ns | 0.1223 ns | 0.0067 ns | 1.2279 ns |  0.15 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 7.6589 ns | 3.0065 ns | 0.1648 ns | 7.6522 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.7474 ns | 0.5767 ns | 0.0316 ns | 0.7431 ns |  0.10 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 7.7140 ns | 0.6828 ns | 0.0374 ns | 7.7251 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 0.8272 ns | 0.6301 ns | 0.0345 ns | 0.8182 ns |  0.11 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 7.7052 ns | 1.8233 ns | 0.0999 ns | 7.7260 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.8556 ns | 0.7177 ns | 0.0393 ns | 0.8383 ns |  0.11 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 7.8501 ns | 0.7656 ns | 0.0420 ns | 7.8293 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.0691 ns | 0.5331 ns | 0.0292 ns | 1.0813 ns |  0.14 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 7.8344 ns | 7.5639 ns | 0.4146 ns | 7.6609 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.8160 ns | 0.4147 ns | 0.0227 ns | 0.8083 ns |  0.10 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 7.8120 ns | 1.4365 ns | 0.0787 ns | 7.8086 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 0.8341 ns | 0.1376 ns | 0.0075 ns | 0.8298 ns |  0.11 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 7.4659 ns | 0.6438 ns | 0.0353 ns | 7.4758 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 1.0969 ns | 0.0305 ns | 0.0017 ns | 1.0965 ns |  0.15 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 7.9130 ns | 0.9078 ns | 0.0498 ns | 7.9317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 0.7678 ns | 0.7247 ns | 0.0397 ns | 0.7482 ns |  0.10 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 7.5839 ns | 0.5244 ns | 0.0287 ns | 7.5834 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.7390 ns | 0.2978 ns | 0.0163 ns | 0.7321 ns |  0.10 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 7.9414 ns | 4.3741 ns | 0.2398 ns | 7.9470 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 0.7575 ns | 0.1925 ns | 0.0106 ns | 0.7534 ns |  0.10 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 7.5880 ns | 1.2598 ns | 0.0691 ns | 7.5981 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.7739 ns | 0.2335 ns | 0.0128 ns | 0.7759 ns |  0.10 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 7.8291 ns | 2.3307 ns | 0.1278 ns | 7.7856 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.0172 ns | 1.1748 ns | 0.0644 ns | 1.0147 ns |  0.13 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 7.5380 ns | 1.2867 ns | 0.0705 ns | 7.5274 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.7108 ns | 0.1919 ns | 0.0105 ns | 0.7087 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 7.5617 ns | 0.9498 ns | 0.0521 ns | 7.5496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 0.7023 ns | 0.4605 ns | 0.0252 ns | 0.6906 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 7.7137 ns | 0.7394 ns | 0.0405 ns | 7.7205 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 0.9266 ns | 0.2132 ns | 0.0117 ns | 0.9203 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 8.3678 ns | 3.5386 ns | 0.1940 ns | 8.4090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.2442 ns | 0.8582 ns | 0.0470 ns | 1.2410 ns |  0.15 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 7.4661 ns | 0.8883 ns | 0.0487 ns | 7.4461 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 0.9240 ns | 0.6744 ns | 0.0370 ns | 0.9050 ns |  0.12 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 8.5131 ns | 1.5385 ns | 0.0843 ns | 8.5559 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.1884 ns | 0.3228 ns | 0.0177 ns | 1.1896 ns |  0.14 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 7.4672 ns | 1.0319 ns | 0.0566 ns | 7.4652 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 0.9245 ns | 0.0329 ns | 0.0018 ns | 0.9246 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 7.9478 ns | 3.3585 ns | 0.1841 ns | 7.9039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.2973 ns | 0.2429 ns | 0.0133 ns | 1.3006 ns |  0.16 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 7.8147 ns | 0.9558 ns | 0.0524 ns | 7.8008 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 0.7031 ns | 0.0657 ns | 0.0036 ns | 0.7039 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 9.0191 ns | 3.1027 ns | 0.1701 ns | 9.0644 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.2690 ns | 1.2118 ns | 0.0664 ns | 1.2996 ns |  0.14 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 9.0344 ns | 2.8823 ns | 0.1580 ns | 9.1070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 1.2029 ns | 0.3500 ns | 0.0192 ns | 1.1985 ns |  0.13 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 8.4172 ns | 4.2731 ns | 0.2342 ns | 8.3602 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 1.2383 ns | 0.0123 ns | 0.0007 ns | 1.2386 ns |  0.15 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 3.9627 ns | 0.3253 ns | 0.0178 ns | 3.9616 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 4.4259 ns | 0.3964 ns | 0.0217 ns | 4.4191 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.5000 ns | 0.1542 ns | 0.0085 ns | 1.4981 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.4304 ns | 0.6461 ns | 0.0354 ns | 1.4170 ns |  0.95 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 8.8402 ns | 0.1028 ns | 0.0056 ns | 8.8394 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.8499 ns | 1.6759 ns | 0.0919 ns | 2.7999 ns |  0.32 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 7.9561 ns | 1.8908 ns | 0.1036 ns | 7.8974 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.5490 ns | 0.0399 ns | 0.0022 ns | 1.5488 ns |  0.19 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 7.4810 ns | 1.8770 ns | 0.1029 ns | 7.4385 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.7257 ns | 0.7638 ns | 0.0419 ns | 0.7246 ns |  0.10 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 7.8749 ns | 0.7905 ns | 0.0433 ns | 7.8928 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 0.6975 ns | 0.0575 ns | 0.0032 ns | 0.6957 ns |  0.09 |    0.00 |     - |     - |     - |         - |
