
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 | 16.6131 ns | 0.0428 ns | 0.0400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 | 16.5701 ns | 0.0288 ns | 0.0270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  9.4553 ns | 0.0388 ns | 0.0344 ns |  0.57 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 | 17.0832 ns | 0.0666 ns | 0.0591 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 | 17.3661 ns | 0.0863 ns | 0.0808 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 | 20.0424 ns | 0.0465 ns | 0.0435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 20.4661 ns | 0.0359 ns | 0.0318 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 | 13.4811 ns | 0.1287 ns | 0.1204 ns |  0.67 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 | 20.7778 ns | 0.0501 ns | 0.0469 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 | 20.9662 ns | 0.0649 ns | 0.0576 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  0.8754 ns | 0.0044 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.2089 ns | 0.0064 ns | 0.0057 ns |  1.38 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1388 ns | 0.0071 ns | 0.0063 ns |  1.30 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  0.7268 ns | 0.0052 ns | 0.0049 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  0.4474 ns | 0.0019 ns | 0.0017 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0022 ns | 0.0097 ns | 0.0081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2300 ns | 0.0298 ns | 0.0278 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9938 ns | 0.0090 ns | 0.0085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.2172 ns | 0.0184 ns | 0.0163 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.2028 ns | 0.0093 ns | 0.0087 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 | 23.5435 ns | 0.0403 ns | 0.0357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 24.0547 ns | 0.0561 ns | 0.0525 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 | 12.0026 ns | 0.0814 ns | 0.0761 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 | 23.7528 ns | 0.0243 ns | 0.0215 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 | 24.0143 ns | 0.0488 ns | 0.0456 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 27.7239 ns | 0.0482 ns | 0.0451 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 27.8027 ns | 0.0755 ns | 0.0669 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 | 15.6181 ns | 0.0635 ns | 0.0530 ns |  0.56 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 | 27.6976 ns | 0.0801 ns | 0.0750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 | 27.9367 ns | 0.0464 ns | 0.0434 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 | 23.7409 ns | 0.0410 ns | 0.0384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 23.7913 ns | 0.0350 ns | 0.0292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 | 12.0498 ns | 0.1461 ns | 0.1367 ns |  0.51 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 | 23.5756 ns | 0.0551 ns | 0.0489 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 | 23.7790 ns | 0.0396 ns | 0.0370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 | 27.6699 ns | 0.1499 ns | 0.1402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 27.2654 ns | 0.0402 ns | 0.0376 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 | 15.6244 ns | 0.0338 ns | 0.0316 ns |  0.56 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 | 27.6523 ns | 0.0449 ns | 0.0398 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 | 27.7682 ns | 0.0335 ns | 0.0297 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 | 23.8173 ns | 0.0336 ns | 0.0298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 24.2207 ns | 0.0408 ns | 0.0362 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 | 12.1416 ns | 0.0738 ns | 0.0654 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 | 23.8299 ns | 0.0511 ns | 0.0453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 | 24.2794 ns | 0.0422 ns | 0.0374 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 | 27.7892 ns | 0.0394 ns | 0.0349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 27.7800 ns | 0.0694 ns | 0.0615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 | 15.8474 ns | 0.1881 ns | 0.1760 ns |  0.57 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 | 36.7490 ns | 0.1665 ns | 0.1558 ns |  1.32 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 | 27.9945 ns | 0.0599 ns | 0.0531 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 | 23.5190 ns | 0.0377 ns | 0.0353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 23.5433 ns | 0.0535 ns | 0.0474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 | 11.8601 ns | 0.0088 ns | 0.0069 ns |  0.50 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 | 23.5349 ns | 0.0453 ns | 0.0424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 | 23.5111 ns | 0.0258 ns | 0.0228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 27.5869 ns | 0.0407 ns | 0.0381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 27.7347 ns | 0.0340 ns | 0.0301 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 | 15.6231 ns | 0.0336 ns | 0.0314 ns |  0.57 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 | 27.4888 ns | 0.0723 ns | 0.0677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 | 27.6958 ns | 0.0596 ns | 0.0557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 | 23.2705 ns | 0.1309 ns | 0.1224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 23.3199 ns | 0.0345 ns | 0.0323 ns |  1.00 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 | 11.6940 ns | 0.0391 ns | 0.0366 ns |  0.50 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 | 16.7667 ns | 0.0239 ns | 0.0224 ns |  0.72 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 | 16.9816 ns | 0.0282 ns | 0.0250 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 | 27.0140 ns | 0.0398 ns | 0.0332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 27.0817 ns | 0.0362 ns | 0.0339 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 | 15.2381 ns | 0.0632 ns | 0.0528 ns |  0.56 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 | 20.4697 ns | 0.0464 ns | 0.0434 ns |  0.76 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 | 20.7618 ns | 0.0357 ns | 0.0334 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 | 23.1789 ns | 0.0339 ns | 0.0283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 23.3477 ns | 0.0606 ns | 0.0567 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 | 11.4236 ns | 0.0244 ns | 0.0228 ns |  0.49 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 | 23.0459 ns | 0.1026 ns | 0.0960 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 | 22.8997 ns | 0.0314 ns | 0.0279 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 26.8524 ns | 0.0481 ns | 0.0450 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 27.1195 ns | 0.1191 ns | 0.1114 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 | 15.2977 ns | 0.2054 ns | 0.1921 ns |  0.57 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 | 27.2094 ns | 0.0377 ns | 0.0353 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 | 32.1041 ns | 0.1125 ns | 0.1052 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 | 23.4671 ns | 0.0468 ns | 0.0415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 23.5257 ns | 0.0468 ns | 0.0438 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 | 11.4970 ns | 0.1250 ns | 0.1169 ns |  0.49 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 | 23.2196 ns | 0.0440 ns | 0.0412 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 | 23.2143 ns | 0.0371 ns | 0.0347 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 | 24.6015 ns | 0.0769 ns | 0.0682 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 | 25.2931 ns | 0.0362 ns | 0.0282 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 | 12.8873 ns | 0.0252 ns | 0.0223 ns |  0.52 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 | 25.4816 ns | 0.0371 ns | 0.0329 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 | 24.7621 ns | 0.0405 ns | 0.0379 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 | 23.2139 ns | 0.1326 ns | 0.1240 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 23.2448 ns | 0.1223 ns | 0.1144 ns |  1.00 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 | 11.2745 ns | 0.0899 ns | 0.0841 ns |  0.49 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 | 23.3640 ns | 0.0256 ns | 0.0214 ns |  1.01 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 | 23.1424 ns | 0.0553 ns | 0.0517 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 | 24.3006 ns | 0.0466 ns | 0.0436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 | 24.5706 ns | 0.0659 ns | 0.0550 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 | 12.9982 ns | 0.0352 ns | 0.0294 ns |  0.53 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 | 25.1716 ns | 0.0513 ns | 0.0455 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 | 24.5068 ns | 0.0381 ns | 0.0357 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 | 24.7527 ns | 0.0717 ns | 0.0598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 24.8017 ns | 0.0512 ns | 0.0454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 | 17.3408 ns | 0.1251 ns | 0.1171 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 | 24.4898 ns | 0.0306 ns | 0.0272 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 | 24.7298 ns | 0.1112 ns | 0.0928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 28.1769 ns | 0.0449 ns | 0.0398 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 28.5338 ns | 0.0330 ns | 0.0293 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 | 20.8696 ns | 0.1363 ns | 0.1275 ns |  0.74 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 | 28.6297 ns | 0.1596 ns | 0.1493 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 | 27.9372 ns | 0.0301 ns | 0.0267 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 | 22.5206 ns | 0.0613 ns | 0.0574 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 | 22.7046 ns | 0.0386 ns | 0.0342 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 | 16.2563 ns | 0.0296 ns | 0.0247 ns |  0.72 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 | 21.6374 ns | 0.0348 ns | 0.0326 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 | 21.6453 ns | 0.0309 ns | 0.0289 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 | 23.4123 ns | 0.0544 ns | 0.0509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 | 23.6272 ns | 0.1013 ns | 0.0947 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 | 17.6726 ns | 0.0959 ns | 0.0897 ns |  0.75 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 | 23.2344 ns | 0.0388 ns | 0.0344 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 | 30.5768 ns | 0.0879 ns | 0.0779 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  1.7578 ns | 0.0151 ns | 0.0141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1122 ns | 0.0090 ns | 0.0084 ns |  1.20 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.8342 ns | 0.0083 ns | 0.0074 ns |  1.04 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  2.2311 ns | 0.0094 ns | 0.0088 ns |  1.27 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  2.2171 ns | 0.0088 ns | 0.0078 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.4624 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.9983 ns | 0.0104 ns | 0.0092 ns |  1.37 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.6205 ns | 0.0163 ns | 0.0153 ns |  1.11 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.5643 ns | 0.0049 ns | 0.0041 ns |  1.07 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.7110 ns | 0.0132 ns | 0.0124 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0923 ns | 0.0063 ns | 0.0059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.2280 ns | 0.0064 ns | 0.0057 ns |  1.07 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2980 ns | 0.0052 ns | 0.0043 ns |  1.10 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.5134 ns | 0.0579 ns | 0.0542 ns |  0.72 |    0.03 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1957 ns | 0.0062 ns | 0.0052 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9845 ns | 0.0362 ns | 0.0321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.7123 ns | 0.1248 ns | 0.1168 ns |  1.09 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9115 ns | 0.0223 ns | 0.0209 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4710 ns | 0.0284 ns | 0.0266 ns |  1.06 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2432 ns | 0.0211 ns | 0.0197 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  4.2993 ns | 0.0284 ns | 0.0266 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 2.2 |  5.1242 ns | 0.0128 ns | 0.0113 ns |  1.19 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 3.0 |  5.1126 ns | 0.0478 ns | 0.0447 ns |  1.19 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject |        net461 |  4.2352 ns | 0.0360 ns | 0.0336 ns |  0.99 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject |        net472 |  4.1809 ns | 0.0070 ns | 0.0059 ns |  0.97 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 55.6590 ns | 0.0986 ns | 0.0824 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 48.6784 ns | 0.0554 ns | 0.0462 ns |  0.87 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 49.6474 ns | 0.1330 ns | 0.1244 ns |  0.89 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 53.9948 ns | 0.1291 ns | 0.1207 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 54.3286 ns | 0.0838 ns | 0.0784 ns |  0.98 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 34.5292 ns | 0.1378 ns | 0.1222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 33.4138 ns | 0.1336 ns | 0.1116 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 23.6196 ns | 0.3820 ns | 0.3573 ns |  0.68 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 | 28.8951 ns | 0.1054 ns | 0.0880 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 29.3844 ns | 0.0492 ns | 0.0436 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 38.8042 ns | 0.1529 ns | 0.1430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 37.7840 ns | 0.0677 ns | 0.0634 ns |  0.97 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 28.0522 ns | 0.0722 ns | 0.0640 ns |  0.72 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 33.8272 ns | 0.0670 ns | 0.0627 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 33.4329 ns | 0.0867 ns | 0.0768 ns |  0.86 |    0.00 |      - |     - |     - |         - |
