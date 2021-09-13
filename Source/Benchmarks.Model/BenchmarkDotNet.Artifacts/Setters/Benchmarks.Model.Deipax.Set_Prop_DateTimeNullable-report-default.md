
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |        Mean |       Error |    StdDev |      Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |------------:|------------:|----------:|------------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |   7.8676 ns |   1.6958 ns | 0.0930 ns |   7.8412 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |   0.9208 ns |   0.1899 ns | 0.0104 ns |   0.9156 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |   7.8780 ns |   0.2597 ns | 0.0142 ns |   7.8809 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |   0.7241 ns |   0.2888 ns | 0.0158 ns |   0.7223 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |   7.4331 ns |   0.1291 ns | 0.0071 ns |   7.4306 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |   0.5951 ns |   0.6717 ns | 0.0368 ns |   0.6067 ns |  0.08 |    0.01 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |   7.8739 ns |   1.9146 ns | 0.1049 ns |   7.9138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |   0.7250 ns |   0.1837 ns | 0.0101 ns |   0.7242 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |   7.5252 ns |   1.5232 ns | 0.0835 ns |   7.5070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |   0.4604 ns |   0.1299 ns | 0.0071 ns |   0.4574 ns |  0.06 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |   7.7051 ns |   0.6733 ns | 0.0369 ns |   7.6921 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |   0.6714 ns |   0.2902 ns | 0.0159 ns |   0.6794 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |   7.6570 ns |   1.9527 ns | 0.1070 ns |   7.6171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |   0.7077 ns |   0.4961 ns | 0.0272 ns |   0.6961 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |   7.8301 ns |   2.4820 ns | 0.1360 ns |   7.8155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |   0.4530 ns |   0.0845 ns | 0.0046 ns |   0.4556 ns |  0.06 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |   7.5966 ns |   0.7646 ns | 0.0419 ns |   7.6120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |   0.6997 ns |   0.1212 ns | 0.0066 ns |   0.6975 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |   7.5379 ns |   1.4128 ns | 0.0774 ns |   7.5180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |   0.5310 ns |   0.5405 ns | 0.0296 ns |   0.5420 ns |  0.07 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |   7.5440 ns |   2.0595 ns | 0.1129 ns |   7.5320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |   0.7095 ns |   0.3104 ns | 0.0170 ns |   0.7002 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |   7.9901 ns |   8.2980 ns | 0.4548 ns |   7.7966 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |   0.7070 ns |   0.1543 ns | 0.0085 ns |   0.7036 ns |  0.09 |    0.01 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |   7.4476 ns |   0.6999 ns | 0.0384 ns |   7.4305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |   0.5443 ns |   0.2356 ns | 0.0129 ns |   0.5466 ns |  0.07 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |   7.8447 ns |   3.0989 ns | 0.1699 ns |   7.8672 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |   0.8015 ns |   3.4205 ns | 0.1875 ns |   0.7125 ns |  0.10 |    0.03 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |   7.4764 ns |   3.7030 ns | 0.2030 ns |   7.4300 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |   0.5339 ns |   0.3185 ns | 0.0175 ns |   0.5264 ns |  0.07 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |   8.1808 ns |   7.0308 ns | 0.3854 ns |   7.9692 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |   0.5191 ns |   0.1393 ns | 0.0076 ns |   0.5184 ns |  0.06 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |   7.6377 ns |   3.0907 ns | 0.1694 ns |   7.6392 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |   0.7214 ns |   0.2387 ns | 0.0131 ns |   0.7215 ns |  0.09 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |   8.7805 ns |   1.1685 ns | 0.0641 ns |   8.8104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |   1.3050 ns |   1.2600 ns | 0.0691 ns |   1.2775 ns |  0.15 |    0.01 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |   7.5739 ns |   0.5517 ns | 0.0302 ns |   7.5705 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |   0.7268 ns |   0.4540 ns | 0.0249 ns |   0.7158 ns |  0.10 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |   8.9561 ns |   1.6837 ns | 0.0923 ns |   8.9069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |   1.2148 ns |   0.1188 ns | 0.0065 ns |   1.2176 ns |  0.14 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |   7.8647 ns |   1.2662 ns | 0.0694 ns |   7.9020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |   0.9393 ns |   0.3045 ns | 0.0167 ns |   0.9307 ns |  0.12 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |   7.8132 ns |   0.9245 ns | 0.0507 ns |   7.8228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |   0.5304 ns |   0.0024 ns | 0.0001 ns |   0.5305 ns |  0.07 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |   7.7032 ns |   1.5853 ns | 0.0869 ns |   7.6723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |   0.9317 ns |   1.5681 ns | 0.0860 ns |   0.9750 ns |  0.12 |    0.01 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |   8.5825 ns |   1.7561 ns | 0.0963 ns |   8.5284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |   1.2796 ns |   1.0733 ns | 0.0588 ns |   1.3065 ns |  0.15 |    0.01 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |   9.1791 ns |   1.6349 ns | 0.0896 ns |   9.1355 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |   1.2196 ns |   0.1525 ns | 0.0084 ns |   1.2220 ns |  0.13 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |   8.2338 ns |   1.2228 ns | 0.0670 ns |   8.2631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |   1.2255 ns |   0.8453 ns | 0.0463 ns |   1.2074 ns |  0.15 |    0.01 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |   4.4169 ns |   0.3106 ns | 0.0170 ns |   4.4197 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |   3.9141 ns |   2.3028 ns | 0.1262 ns |   3.9387 ns |  0.89 |    0.03 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |   1.4898 ns |   1.0434 ns | 0.0572 ns |   1.4595 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |   1.4531 ns |   0.6318 ns | 0.0346 ns |   1.4341 ns |  0.98 |    0.05 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  17.9586 ns |   6.0878 ns | 0.3337 ns |  18.0208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  11.9116 ns |   0.1671 ns | 0.0092 ns |  11.9090 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 311.0930 ns |  50.7801 ns | 2.7834 ns | 309.9389 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 281.6295 ns | 113.5108 ns | 6.2219 ns | 278.8483 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |   7.6275 ns |   4.5588 ns | 0.2499 ns |   7.5226 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |   0.5142 ns |   0.1456 ns | 0.0080 ns |   0.5098 ns |  0.07 |    0.00 |     - |     - |     - |         - |
                      |               |             |             |           |             |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |   8.0554 ns |   3.8955 ns | 0.2135 ns |   8.1300 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |   0.5179 ns |   0.0730 ns | 0.0040 ns |   0.5185 ns |  0.06 |    0.00 |     - |     - |     - |         - |
