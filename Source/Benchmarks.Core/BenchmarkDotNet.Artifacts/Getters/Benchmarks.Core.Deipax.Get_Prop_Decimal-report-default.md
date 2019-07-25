
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  7.1454 ns | 0.0179 ns | 0.0149 ns |  7.1456 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  7.3905 ns | 0.0132 ns | 0.0117 ns |  7.3910 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  5.2792 ns | 0.0518 ns | 0.0459 ns |  5.2895 ns |  0.74 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  6.7186 ns | 0.0469 ns | 0.0415 ns |  6.7120 ns |  0.94 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  6.6998 ns | 0.0151 ns | 0.0141 ns |  6.7037 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 | 14.2314 ns | 0.0359 ns | 0.0300 ns | 14.2300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 14.4176 ns | 0.0231 ns | 0.0205 ns | 14.4157 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  7.3596 ns | 0.0369 ns | 0.0327 ns |  7.3603 ns |  0.52 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 | 15.3201 ns | 0.0338 ns | 0.0283 ns | 15.3308 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 | 15.5255 ns | 0.0869 ns | 0.0813 ns | 15.5658 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.2854 ns | 0.0040 ns | 0.0036 ns |  1.2842 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.2186 ns | 0.0036 ns | 0.0032 ns |  1.2188 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1660 ns | 0.0114 ns | 0.0101 ns |  1.1674 ns |  0.91 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  0.4517 ns | 0.0074 ns | 0.0069 ns |  0.4494 ns |  0.35 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  0.7143 ns | 0.0024 ns | 0.0020 ns |  0.7144 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9901 ns | 0.0084 ns | 0.0079 ns |  3.9890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2050 ns | 0.0132 ns | 0.0117 ns |  4.2026 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0238 ns | 0.0072 ns | 0.0060 ns |  4.0241 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.2536 ns | 0.0139 ns | 0.0130 ns |  4.2541 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1757 ns | 0.0090 ns | 0.0079 ns |  4.1766 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 | 13.1292 ns | 0.0426 ns | 0.0398 ns | 13.1257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 13.3527 ns | 0.0344 ns | 0.0305 ns | 13.3472 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  7.4963 ns | 0.0457 ns | 0.0428 ns |  7.4935 ns |  0.57 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 | 13.6378 ns | 0.0379 ns | 0.0336 ns | 13.6291 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 | 13.5784 ns | 0.0255 ns | 0.0239 ns | 13.5772 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 21.6978 ns | 0.1057 ns | 0.0989 ns | 21.7341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 21.7926 ns | 0.0462 ns | 0.0433 ns | 21.7813 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  9.1426 ns | 0.0180 ns | 0.0160 ns |  9.1450 ns |  0.42 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 | 22.2348 ns | 0.0292 ns | 0.0259 ns | 22.2333 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 | 21.8308 ns | 0.0399 ns | 0.0373 ns | 21.8229 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 | 13.2610 ns | 0.0472 ns | 0.0441 ns | 13.2541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 13.0963 ns | 0.0224 ns | 0.0209 ns | 13.1005 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  7.4765 ns | 0.0526 ns | 0.0466 ns |  7.4947 ns |  0.56 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 | 20.9657 ns | 0.0267 ns | 0.0249 ns | 20.9666 ns |  1.58 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 | 13.2217 ns | 0.0509 ns | 0.0476 ns | 13.2336 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 | 21.4333 ns | 0.0354 ns | 0.0331 ns | 21.4232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 21.7901 ns | 0.1214 ns | 0.1136 ns | 21.8427 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  8.9134 ns | 0.0180 ns | 0.0169 ns |  8.9115 ns |  0.42 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 | 21.9477 ns | 0.0796 ns | 0.0706 ns | 21.9683 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 | 21.8933 ns | 0.0474 ns | 0.0396 ns | 21.8796 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 | 13.3655 ns | 0.0355 ns | 0.0332 ns | 13.3536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 13.3043 ns | 0.0269 ns | 0.0238 ns | 13.2981 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  7.8066 ns | 0.3435 ns | 0.5448 ns |  7.5118 ns |  0.61 |    0.05 |      - |     - |     - |         - |
            ToShort |        net461 | 13.3053 ns | 0.0317 ns | 0.0281 ns | 13.2973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 | 13.3114 ns | 0.0281 ns | 0.0263 ns | 13.2980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 | 21.2315 ns | 0.0251 ns | 0.0222 ns | 21.2289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 21.5070 ns | 0.0318 ns | 0.0282 ns | 21.5157 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  9.1518 ns | 0.0190 ns | 0.0177 ns |  9.1518 ns |  0.43 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 | 21.8972 ns | 0.0763 ns | 0.0676 ns | 21.8724 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 | 22.3336 ns | 0.0691 ns | 0.0613 ns | 22.3146 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 | 12.9427 ns | 0.0230 ns | 0.0203 ns | 12.9360 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 13.1044 ns | 0.0229 ns | 0.0214 ns | 13.1012 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  6.8472 ns | 0.0252 ns | 0.0236 ns |  6.8493 ns |  0.53 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 | 13.0786 ns | 0.0231 ns | 0.0216 ns | 13.0737 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 | 13.0881 ns | 0.0381 ns | 0.0318 ns | 13.0788 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 21.1699 ns | 0.0406 ns | 0.0380 ns | 21.1713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 21.6393 ns | 0.0534 ns | 0.0473 ns | 21.6324 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  8.9256 ns | 0.0290 ns | 0.0271 ns |  8.9220 ns |  0.42 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 | 22.2724 ns | 0.0579 ns | 0.0514 ns | 22.2518 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 | 21.6663 ns | 0.0359 ns | 0.0300 ns | 21.6616 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 | 12.8712 ns | 0.0292 ns | 0.0259 ns | 12.8732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 13.0511 ns | 0.0131 ns | 0.0109 ns | 13.0524 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  6.2802 ns | 0.1380 ns | 0.1291 ns |  6.3507 ns |  0.49 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  6.4807 ns | 0.1499 ns | 0.1252 ns |  6.4514 ns |  0.50 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  6.5375 ns | 0.0173 ns | 0.0153 ns |  6.5382 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 | 21.0972 ns | 0.0362 ns | 0.0321 ns | 21.0918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 21.1208 ns | 0.0272 ns | 0.0212 ns | 21.1188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  8.2221 ns | 0.0291 ns | 0.0273 ns |  8.2138 ns |  0.39 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 | 14.6793 ns | 0.0235 ns | 0.0208 ns | 14.6785 ns |  0.70 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 | 14.4276 ns | 0.0499 ns | 0.0467 ns | 14.4096 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 | 12.3987 ns | 0.0256 ns | 0.0240 ns | 12.3898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 13.1806 ns | 0.0262 ns | 0.0232 ns | 13.1853 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  5.6493 ns | 0.0118 ns | 0.0104 ns |  5.6469 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 | 12.3639 ns | 0.0283 ns | 0.0265 ns | 12.3620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 | 12.4136 ns | 0.0326 ns | 0.0305 ns | 12.4025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 21.0526 ns | 0.0573 ns | 0.0508 ns | 21.0410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 20.8205 ns | 0.0400 ns | 0.0374 ns | 20.8207 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  8.0160 ns | 0.0513 ns | 0.0479 ns |  8.0449 ns |  0.38 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 | 21.1621 ns | 0.0582 ns | 0.0544 ns | 21.1685 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 | 21.1953 ns | 0.0518 ns | 0.0485 ns | 21.1797 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 | 12.6477 ns | 0.0212 ns | 0.0198 ns | 12.6533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 12.9677 ns | 0.0357 ns | 0.0316 ns | 12.9524 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  5.4934 ns | 0.0096 ns | 0.0081 ns |  5.4907 ns |  0.43 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 | 12.6383 ns | 0.0199 ns | 0.0177 ns | 12.6330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 | 12.6552 ns | 0.0180 ns | 0.0168 ns | 12.6494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 | 13.3030 ns | 0.0160 ns | 0.0142 ns | 13.3033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 | 13.5564 ns | 0.0468 ns | 0.0438 ns | 13.5455 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  5.8266 ns | 0.0088 ns | 0.0082 ns |  5.8283 ns |  0.44 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 | 13.6501 ns | 0.0304 ns | 0.0284 ns | 13.6461 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 | 13.7702 ns | 0.0342 ns | 0.0320 ns | 13.7715 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 | 12.4159 ns | 0.0268 ns | 0.0251 ns | 12.4167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 12.7820 ns | 0.0255 ns | 0.0238 ns | 12.7701 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  5.5560 ns | 0.0127 ns | 0.0113 ns |  5.5581 ns |  0.45 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 | 12.4311 ns | 0.0229 ns | 0.0214 ns | 12.4238 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 | 12.5596 ns | 0.0716 ns | 0.0669 ns | 12.5320 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 | 13.2246 ns | 0.0353 ns | 0.0313 ns | 13.2156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 | 13.1408 ns | 0.0368 ns | 0.0344 ns | 13.1293 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  5.7722 ns | 0.0273 ns | 0.0256 ns |  5.7654 ns |  0.44 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 | 13.3393 ns | 0.0259 ns | 0.0216 ns | 13.3310 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 | 13.4170 ns | 0.0550 ns | 0.0515 ns | 13.4358 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 | 10.3238 ns | 0.0122 ns | 0.0108 ns | 10.3180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 10.6527 ns | 0.0228 ns | 0.0202 ns | 10.6559 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  5.2565 ns | 0.0403 ns | 0.0377 ns |  5.2678 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  9.1130 ns | 0.0383 ns | 0.0358 ns |  9.1237 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  9.0992 ns | 0.0278 ns | 0.0247 ns |  9.0985 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 14.9347 ns | 0.0431 ns | 0.0382 ns | 14.9248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 15.3774 ns | 0.0453 ns | 0.0424 ns | 15.3649 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  7.1074 ns | 0.0171 ns | 0.0160 ns |  7.1043 ns |  0.48 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 | 15.9892 ns | 0.0297 ns | 0.0248 ns | 15.9917 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 | 15.2775 ns | 0.0365 ns | 0.0324 ns | 15.2834 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  7.5815 ns | 0.0157 ns | 0.0147 ns |  7.5790 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  9.0744 ns | 0.0182 ns | 0.0161 ns |  9.0725 ns |  1.20 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  4.8340 ns | 0.0122 ns | 0.0095 ns |  4.8320 ns |  0.64 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  6.8382 ns | 0.0105 ns | 0.0093 ns |  6.8359 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  6.6081 ns | 0.0121 ns | 0.0107 ns |  6.6046 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  7.9143 ns | 0.0219 ns | 0.0205 ns |  7.9090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  8.4010 ns | 0.0184 ns | 0.0172 ns |  8.4024 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  6.1370 ns | 0.0138 ns | 0.0129 ns |  6.1336 ns |  0.78 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  8.5940 ns | 0.0229 ns | 0.0214 ns |  8.5959 ns |  1.09 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  8.4527 ns | 0.0199 ns | 0.0186 ns |  8.4523 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  1.7515 ns | 0.0168 ns | 0.0141 ns |  1.7562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.7110 ns | 0.0044 ns | 0.0041 ns |  1.7092 ns |  0.98 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.0863 ns | 0.0027 ns | 0.0023 ns |  2.0861 ns |  1.19 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  1.6480 ns | 0.0056 ns | 0.0044 ns |  1.6492 ns |  0.94 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  1.5789 ns | 0.0063 ns | 0.0056 ns |  1.5782 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  5.6328 ns | 0.0100 ns | 0.0094 ns |  5.6290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  5.6659 ns | 0.0189 ns | 0.0177 ns |  5.6714 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  5.6476 ns | 0.0110 ns | 0.0098 ns |  5.6453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  5.8970 ns | 0.0279 ns | 0.0247 ns |  5.9060 ns |  1.05 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  5.6259 ns | 0.0260 ns | 0.0243 ns |  5.6318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0923 ns | 0.0041 ns | 0.0038 ns |  2.0926 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.2286 ns | 0.0041 ns | 0.0038 ns |  2.2275 ns |  1.07 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.0492 ns | 0.0037 ns | 0.0031 ns |  2.0506 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1958 ns | 0.0045 ns | 0.0037 ns |  1.1952 ns |  0.57 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1214 ns | 0.0043 ns | 0.0040 ns |  1.1202 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9647 ns | 0.0161 ns | 0.0143 ns |  7.9633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  7.8233 ns | 0.0192 ns | 0.0180 ns |  7.8224 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9199 ns | 0.0055 ns | 0.0052 ns |  1.9208 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1178 ns | 0.0218 ns | 0.0204 ns |  8.1109 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1319 ns | 0.0222 ns | 0.0207 ns |  8.1346 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.7806 ns | 0.0285 ns | 0.0266 ns |  3.7885 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 2.2 |  4.4186 ns | 0.0443 ns | 0.0393 ns |  4.4035 ns |  1.17 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 3.0 |  4.3447 ns | 0.0492 ns | 0.0461 ns |  4.3505 ns |  1.15 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject |        net461 |  3.2206 ns | 0.0176 ns | 0.0165 ns |  3.2213 ns |  0.85 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject |        net472 |  3.3217 ns | 0.0202 ns | 0.0189 ns |  3.3146 ns |  0.88 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 54.7576 ns | 0.2316 ns | 0.2053 ns | 54.6870 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 47.2647 ns | 0.1312 ns | 0.1163 ns | 47.2409 ns |  0.86 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 47.8017 ns | 0.0879 ns | 0.0686 ns | 47.7955 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 51.6397 ns | 0.2489 ns | 0.2078 ns | 51.6906 ns |  0.94 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 51.4396 ns | 0.0804 ns | 0.0712 ns | 51.4625 ns |  0.94 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 27.3079 ns | 0.0417 ns | 0.0370 ns | 27.3003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 26.9304 ns | 0.0378 ns | 0.0335 ns | 26.9368 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 12.6227 ns | 0.0382 ns | 0.0339 ns | 12.6328 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 22.9862 ns | 0.0290 ns | 0.0242 ns | 22.9820 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 23.0851 ns | 0.0644 ns | 0.0571 ns | 23.0958 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 31.5475 ns | 0.1251 ns | 0.1170 ns | 31.5140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 31.3432 ns | 0.0626 ns | 0.0555 ns | 31.3200 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 22.1957 ns | 0.0407 ns | 0.0340 ns | 22.2033 ns |  0.70 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 27.4847 ns | 0.0296 ns | 0.0247 ns | 27.4865 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 27.5022 ns | 0.0508 ns | 0.0424 ns | 27.4913 ns |  0.87 |    0.00 |      - |     - |     - |         - |
