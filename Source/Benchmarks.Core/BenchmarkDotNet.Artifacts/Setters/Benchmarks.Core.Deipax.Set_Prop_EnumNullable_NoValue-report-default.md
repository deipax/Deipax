
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 16.9882 ns | 0.0334 ns | 0.0312 ns | 16.9915 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 17.1649 ns | 0.0187 ns | 0.0166 ns | 17.1640 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 13.3917 ns | 0.0162 ns | 0.0144 ns | 13.3904 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 | 19.4386 ns | 0.0239 ns | 0.0223 ns | 19.4337 ns |  1.14 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 19.5226 ns | 0.0401 ns | 0.0375 ns | 19.5144 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  2.1039 ns | 0.0042 ns | 0.0039 ns |  2.1035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  2.1364 ns | 0.0043 ns | 0.0036 ns |  2.1373 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.9742 ns | 0.0045 ns | 0.0042 ns |  1.9730 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.4661 ns | 0.0075 ns | 0.0066 ns |  2.4649 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.2481 ns | 0.0064 ns | 0.0056 ns |  2.2481 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 16.9511 ns | 0.0255 ns | 0.0226 ns | 16.9518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 17.0073 ns | 0.0276 ns | 0.0230 ns | 17.0116 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 13.4053 ns | 0.0175 ns | 0.0164 ns | 13.4039 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 | 19.4958 ns | 0.0228 ns | 0.0178 ns | 19.4937 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 | 19.5744 ns | 0.0255 ns | 0.0239 ns | 19.5763 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  2.3056 ns | 0.0052 ns | 0.0049 ns |  2.3056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  2.1416 ns | 0.0031 ns | 0.0028 ns |  2.1413 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.9377 ns | 0.0028 ns | 0.0025 ns |  1.9379 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.3289 ns | 0.0037 ns | 0.0033 ns |  2.3288 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.3627 ns | 0.0192 ns | 0.0180 ns |  2.3567 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 17.1553 ns | 0.0166 ns | 0.0155 ns | 17.1608 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 16.9495 ns | 0.0246 ns | 0.0218 ns | 16.9554 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 13.4130 ns | 0.0129 ns | 0.0115 ns | 13.4145 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 19.5814 ns | 0.0962 ns | 0.0900 ns | 19.5473 ns |  1.14 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 19.5486 ns | 0.0230 ns | 0.0192 ns | 19.5523 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  2.0127 ns | 0.0049 ns | 0.0044 ns |  2.0108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  2.1291 ns | 0.0028 ns | 0.0026 ns |  2.1296 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.9727 ns | 0.0027 ns | 0.0025 ns |  1.9730 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  3.1465 ns | 0.0051 ns | 0.0047 ns |  3.1471 ns |  1.56 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.2704 ns | 0.0048 ns | 0.0040 ns |  2.2706 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 16.9850 ns | 0.0255 ns | 0.0238 ns | 16.9866 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 16.9898 ns | 0.0144 ns | 0.0120 ns | 16.9930 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 13.5599 ns | 0.0582 ns | 0.0544 ns | 13.5711 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 19.4775 ns | 0.0231 ns | 0.0216 ns | 19.4849 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 19.5257 ns | 0.0233 ns | 0.0217 ns | 19.5225 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  2.0316 ns | 0.0027 ns | 0.0025 ns |  2.0314 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  2.1341 ns | 0.0045 ns | 0.0042 ns |  2.1350 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.9811 ns | 0.0052 ns | 0.0049 ns |  1.9799 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.2705 ns | 0.0041 ns | 0.0034 ns |  2.2698 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.2705 ns | 0.0206 ns | 0.0193 ns |  2.2567 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 16.9637 ns | 0.0361 ns | 0.0337 ns | 16.9590 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 17.1138 ns | 0.0494 ns | 0.0462 ns | 17.1282 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 13.4463 ns | 0.0604 ns | 0.0565 ns | 13.4567 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 19.5743 ns | 0.0242 ns | 0.0227 ns | 19.5745 ns |  1.15 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 19.5375 ns | 0.0233 ns | 0.0207 ns | 19.5399 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.0192 ns | 0.0035 ns | 0.0031 ns |  2.0199 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.1351 ns | 0.0076 ns | 0.0071 ns |  2.1336 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  2.0639 ns | 0.0035 ns | 0.0033 ns |  2.0644 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.3257 ns | 0.0028 ns | 0.0027 ns |  2.3259 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.5564 ns | 0.0052 ns | 0.0044 ns |  2.5557 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 17.0401 ns | 0.0170 ns | 0.0159 ns | 17.0375 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 16.9468 ns | 0.0262 ns | 0.0245 ns | 16.9474 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 13.3817 ns | 0.0155 ns | 0.0145 ns | 13.3877 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 | 19.5124 ns | 0.0321 ns | 0.0300 ns | 19.5132 ns |  1.15 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 19.5145 ns | 0.0304 ns | 0.0237 ns | 19.5098 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  2.0178 ns | 0.0030 ns | 0.0028 ns |  2.0180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  2.1626 ns | 0.0189 ns | 0.0177 ns |  2.1689 ns |  1.07 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.9465 ns | 0.0143 ns | 0.0127 ns |  1.9501 ns |  0.96 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.3471 ns | 0.0254 ns | 0.0238 ns |  2.3618 ns |  1.16 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.3565 ns | 0.0053 ns | 0.0050 ns |  2.3563 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 16.9303 ns | 0.0216 ns | 0.0202 ns | 16.9315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 16.8904 ns | 0.0200 ns | 0.0167 ns | 16.8890 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 13.1337 ns | 0.0156 ns | 0.0146 ns | 13.1361 ns |  0.78 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 19.4560 ns | 0.0291 ns | 0.0258 ns | 19.4594 ns |  1.15 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 19.5331 ns | 0.0214 ns | 0.0179 ns | 19.5352 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.0459 ns | 0.0101 ns | 0.0084 ns |  2.0448 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.2260 ns | 0.0030 ns | 0.0028 ns |  2.2255 ns |  1.09 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.9256 ns | 0.0029 ns | 0.0027 ns |  1.9256 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.3349 ns | 0.0036 ns | 0.0032 ns |  2.3350 ns |  1.14 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.3150 ns | 0.0031 ns | 0.0026 ns |  2.3152 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 16.9534 ns | 0.0194 ns | 0.0181 ns | 16.9577 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 17.1529 ns | 0.0237 ns | 0.0221 ns | 17.1575 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 13.2048 ns | 0.0477 ns | 0.0446 ns | 13.2199 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 | 19.9249 ns | 0.1303 ns | 0.1155 ns | 19.9597 ns |  1.18 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 19.6627 ns | 0.0272 ns | 0.0242 ns | 19.6614 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0242 ns | 0.0038 ns | 0.0034 ns |  2.0241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  2.1598 ns | 0.0036 ns | 0.0030 ns |  2.1594 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.9535 ns | 0.0043 ns | 0.0038 ns |  1.9526 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.3491 ns | 0.0109 ns | 0.0102 ns |  2.3469 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.3098 ns | 0.0037 ns | 0.0035 ns |  2.3090 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 17.8036 ns | 0.0260 ns | 0.0231 ns | 17.7982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 17.4509 ns | 0.0146 ns | 0.0137 ns | 17.4492 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 13.4922 ns | 0.0153 ns | 0.0143 ns | 13.4902 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 19.9785 ns | 0.0438 ns | 0.0410 ns | 19.9879 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 19.9964 ns | 0.1043 ns | 0.0976 ns | 19.9637 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.9593 ns | 0.0057 ns | 0.0053 ns |  1.9581 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.1620 ns | 0.0108 ns | 0.0101 ns |  2.1579 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.9234 ns | 0.0037 ns | 0.0035 ns |  1.9225 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.3403 ns | 0.0093 ns | 0.0087 ns |  2.3355 ns |  1.19 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.4956 ns | 0.0054 ns | 0.0048 ns |  3.4952 ns |  1.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 17.5686 ns | 0.0196 ns | 0.0183 ns | 17.5721 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 17.2807 ns | 0.0230 ns | 0.0215 ns | 17.2924 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 13.5607 ns | 0.0115 ns | 0.0102 ns | 13.5615 ns |  0.77 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 20.0332 ns | 0.2095 ns | 0.1960 ns | 19.9736 ns |  1.14 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 | 19.6717 ns | 0.0231 ns | 0.0193 ns | 19.6673 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9612 ns | 0.0030 ns | 0.0028 ns |  1.9617 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.4019 ns | 0.0052 ns | 0.0049 ns |  2.4026 ns |  1.22 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.9723 ns | 0.0044 ns | 0.0039 ns |  1.9723 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.3401 ns | 0.0072 ns | 0.0064 ns |  2.3394 ns |  1.19 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.3640 ns | 0.0280 ns | 0.0261 ns |  2.3530 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 19.3498 ns | 0.0334 ns | 0.0279 ns | 19.3498 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 19.1720 ns | 0.0164 ns | 0.0146 ns | 19.1743 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 15.7820 ns | 0.0189 ns | 0.0167 ns | 15.7843 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 22.3871 ns | 0.1395 ns | 0.1304 ns | 22.4643 ns |  1.16 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 | 22.0737 ns | 0.0280 ns | 0.0262 ns | 22.0734 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8828 ns | 0.0030 ns | 0.0028 ns |  1.8833 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.0067 ns | 0.0028 ns | 0.0026 ns |  2.0070 ns |  1.07 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.9126 ns | 0.0038 ns | 0.0036 ns |  1.9130 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  2.2237 ns | 0.0057 ns | 0.0053 ns |  2.2226 ns |  1.18 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  2.1947 ns | 0.0034 ns | 0.0027 ns |  2.1951 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 19.3612 ns | 0.0243 ns | 0.0216 ns | 19.3680 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 19.1721 ns | 0.0207 ns | 0.0194 ns | 19.1683 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 15.8443 ns | 0.0304 ns | 0.0270 ns | 15.8516 ns |  0.82 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 22.0808 ns | 0.0273 ns | 0.0228 ns | 22.0810 ns |  1.14 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 22.1790 ns | 0.1167 ns | 0.1092 ns | 22.1111 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9722 ns | 0.0065 ns | 0.0061 ns |  1.9704 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  2.1291 ns | 0.0023 ns | 0.0021 ns |  2.1287 ns |  1.08 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9267 ns | 0.0035 ns | 0.0029 ns |  1.9272 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.4128 ns | 0.0220 ns | 0.0206 ns |  2.4239 ns |  1.22 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.3336 ns | 0.0048 ns | 0.0045 ns |  2.3328 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 34.5066 ns | 0.0739 ns | 0.0691 ns | 34.4903 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 33.7919 ns | 0.0375 ns | 0.0332 ns | 33.7910 ns |  0.98 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 23.3186 ns | 0.0162 ns | 0.0152 ns | 23.3228 ns |  0.68 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 30.7030 ns | 0.0409 ns | 0.0363 ns | 30.7028 ns |  0.89 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 30.4410 ns | 0.0487 ns | 0.0431 ns | 30.4329 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.3699 ns | 0.0150 ns | 0.0133 ns |  8.3664 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.8819 ns | 0.0370 ns | 0.0346 ns |  8.8776 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  8.5028 ns | 0.0162 ns | 0.0151 ns |  8.5011 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.6880 ns | 0.0114 ns | 0.0106 ns |  8.6901 ns |  1.04 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.8917 ns | 0.0105 ns | 0.0098 ns |  8.8897 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 11.9233 ns | 0.0136 ns | 0.0128 ns | 11.9246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 11.5439 ns | 0.0490 ns | 0.0434 ns | 11.5532 ns |  0.97 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  7.2907 ns | 0.0103 ns | 0.0097 ns |  7.2902 ns |  0.61 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 14.5301 ns | 0.0274 ns | 0.0243 ns | 14.5272 ns |  1.22 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 | 14.5974 ns | 0.0188 ns | 0.0176 ns | 14.5979 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 10.5831 ns | 0.0131 ns | 0.0123 ns | 10.5833 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  8.7288 ns | 0.0121 ns | 0.0108 ns |  8.7307 ns |  0.82 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  2.4193 ns | 0.0127 ns | 0.0113 ns |  2.4193 ns |  0.23 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  8.7150 ns | 0.0119 ns | 0.0112 ns |  8.7197 ns |  0.82 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  8.6501 ns | 0.0135 ns | 0.0120 ns |  8.6501 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.7328 ns | 0.0062 ns | 0.0058 ns |  2.7316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8217 ns | 0.0063 ns | 0.0059 ns |  2.8209 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.9966 ns | 0.0071 ns | 0.0063 ns |  2.9956 ns |  1.10 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8611 ns | 0.0073 ns | 0.0065 ns |  2.8602 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8498 ns | 0.0053 ns | 0.0050 ns |  2.8485 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.7349 ns | 0.0041 ns | 0.0036 ns |  1.7353 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8817 ns | 0.0039 ns | 0.0036 ns |  1.8810 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.6408 ns | 0.0035 ns | 0.0031 ns |  1.6411 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.8783 ns | 0.0038 ns | 0.0035 ns |  1.8792 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.8688 ns | 0.0024 ns | 0.0023 ns |  1.8682 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6460 ns | 0.0028 ns | 0.0026 ns |  0.6461 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7084 ns | 0.0025 ns | 0.0022 ns |  0.7086 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7683 ns | 0.0071 ns | 0.0063 ns |  0.7696 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7056 ns | 0.0033 ns | 0.0029 ns |  0.7056 ns |  1.09 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7231 ns | 0.0035 ns | 0.0031 ns |  0.7223 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.6747 ns | 0.0025 ns | 0.0024 ns |  0.6744 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9466 ns | 0.0037 ns | 0.0032 ns |  0.9461 ns |  1.40 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  0.6583 ns | 0.0016 ns | 0.0015 ns |  0.6578 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  0.7287 ns | 0.0028 ns | 0.0025 ns |  0.7291 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  0.7083 ns | 0.0027 ns | 0.0024 ns |  0.7092 ns |  1.05 |    0.00 |     - |     - |     - |         - |
