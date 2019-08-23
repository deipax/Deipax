
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
             FromBool | .NET Core 2.0 | 11.6864 ns | 0.0673 ns | 0.0630 ns | 11.7115 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 11.2946 ns | 0.0145 ns | 0.0135 ns | 11.2927 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  6.3306 ns | 0.1186 ns | 0.1110 ns |  6.2574 ns |  0.54 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 11.5265 ns | 0.0142 ns | 0.0132 ns | 11.5293 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 11.3076 ns | 0.0166 ns | 0.0156 ns | 11.3129 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 11.5674 ns | 0.0175 ns | 0.0163 ns | 11.5655 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 11.9454 ns | 0.0770 ns | 0.0720 ns | 11.9049 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  6.6899 ns | 0.0956 ns | 0.0894 ns |  6.7213 ns |  0.58 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 11.9264 ns | 0.0122 ns | 0.0114 ns | 11.9272 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 11.9886 ns | 0.0214 ns | 0.0200 ns | 11.9836 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9815 ns | 0.0034 ns | 0.0030 ns |  0.9810 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.2399 ns | 0.0031 ns | 0.0027 ns |  1.2397 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  1.0079 ns | 0.0039 ns | 0.0037 ns |  1.0079 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 | 11.0965 ns | 0.0112 ns | 0.0104 ns | 11.0980 ns | 11.31 |    0.04 |     - |     - |     - |         - |
             FromChar |        net472 | 16.3650 ns | 0.0157 ns | 0.0147 ns | 16.3631 ns | 16.67 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.2279 ns | 0.0119 ns | 0.0111 ns |  1.2233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.4394 ns | 0.0039 ns | 0.0033 ns |  1.4404 ns |  1.17 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.4198 ns | 0.0207 ns | 0.0194 ns |  1.4182 ns |  1.16 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 11.5580 ns | 0.0164 ns | 0.0154 ns | 11.5629 ns |  9.41 |    0.09 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 11.4318 ns | 0.0702 ns | 0.0622 ns | 11.4532 ns |  9.32 |    0.10 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 11.3444 ns | 0.0205 ns | 0.0192 ns | 11.3449 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 11.3237 ns | 0.0182 ns | 0.0170 ns | 11.3271 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  6.3518 ns | 0.1218 ns | 0.1139 ns |  6.2610 ns |  0.56 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 11.3341 ns | 0.0185 ns | 0.0173 ns | 11.3320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 | 11.3088 ns | 0.0105 ns | 0.0093 ns | 11.3090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 11.5768 ns | 0.0294 ns | 0.0275 ns | 11.5673 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 11.5523 ns | 0.0160 ns | 0.0142 ns | 11.5534 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  6.5623 ns | 0.1171 ns | 0.1095 ns |  6.4954 ns |  0.57 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 11.5588 ns | 0.0076 ns | 0.0071 ns | 11.5565 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 11.7307 ns | 0.0124 ns | 0.0110 ns | 11.7338 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 11.3444 ns | 0.0254 ns | 0.0225 ns | 11.3421 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 11.0831 ns | 0.0134 ns | 0.0118 ns | 11.0828 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  6.3246 ns | 0.1211 ns | 0.1133 ns |  6.2541 ns |  0.56 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 | 11.0894 ns | 0.0153 ns | 0.0143 ns | 11.0912 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 11.1712 ns | 0.0753 ns | 0.0704 ns | 11.2186 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 11.7990 ns | 0.0180 ns | 0.0169 ns | 11.7929 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 11.5386 ns | 0.0126 ns | 0.0118 ns | 11.5388 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  6.8060 ns | 0.1609 ns | 0.2092 ns |  6.9250 ns |  0.57 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 11.7686 ns | 0.0285 ns | 0.0238 ns | 11.7625 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 11.5404 ns | 0.0462 ns | 0.0410 ns | 11.5222 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 11.1301 ns | 0.0340 ns | 0.0318 ns | 11.1195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 11.3240 ns | 0.0195 ns | 0.0173 ns | 11.3219 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  6.4297 ns | 0.1315 ns | 0.1230 ns |  6.4720 ns |  0.58 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 | 11.3308 ns | 0.0137 ns | 0.0121 ns | 11.3314 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 11.1562 ns | 0.0707 ns | 0.0661 ns | 11.2004 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 11.8013 ns | 0.0178 ns | 0.0166 ns | 11.8056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 11.5601 ns | 0.0143 ns | 0.0134 ns | 11.5605 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  6.5908 ns | 0.1277 ns | 0.1195 ns |  6.5019 ns |  0.56 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 11.5473 ns | 0.0131 ns | 0.0116 ns | 11.5500 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 11.5368 ns | 0.0178 ns | 0.0166 ns | 11.5358 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 11.3155 ns | 0.0201 ns | 0.0188 ns | 11.3096 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 11.2931 ns | 0.0119 ns | 0.0099 ns | 11.2928 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  6.3408 ns | 0.1272 ns | 0.1190 ns |  6.2552 ns |  0.56 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 11.3385 ns | 0.0146 ns | 0.0130 ns | 11.3373 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 11.0756 ns | 0.0175 ns | 0.0164 ns | 11.0715 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 11.6794 ns | 0.0670 ns | 0.0626 ns | 11.7122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 11.5705 ns | 0.0317 ns | 0.0247 ns | 11.5738 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  6.6485 ns | 0.1188 ns | 0.1111 ns |  6.7141 ns |  0.57 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 11.5664 ns | 0.0168 ns | 0.0140 ns | 11.5688 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 11.8924 ns | 0.0729 ns | 0.0681 ns | 11.9223 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 11.3365 ns | 0.0188 ns | 0.0167 ns | 11.3333 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 11.0935 ns | 0.0156 ns | 0.0139 ns | 11.0919 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  6.3522 ns | 0.1257 ns | 0.1176 ns |  6.2706 ns |  0.56 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 | 11.4609 ns | 0.0849 ns | 0.0709 ns | 11.4765 ns |  1.01 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 | 11.3175 ns | 0.0156 ns | 0.0146 ns | 11.3155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 11.7965 ns | 0.0135 ns | 0.0127 ns | 11.7939 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 11.5325 ns | 0.0134 ns | 0.0125 ns | 11.5360 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  6.6540 ns | 0.1503 ns | 0.1406 ns |  6.7078 ns |  0.56 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 11.5683 ns | 0.0256 ns | 0.0227 ns | 11.5592 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 11.5342 ns | 0.0163 ns | 0.0152 ns | 11.5322 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 11.0867 ns | 0.0090 ns | 0.0080 ns | 11.0855 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 11.3914 ns | 0.0720 ns | 0.0673 ns | 11.4278 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  6.3976 ns | 0.1249 ns | 0.1169 ns |  6.3154 ns |  0.58 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 11.1192 ns | 0.0108 ns | 0.0101 ns | 11.1199 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 11.3275 ns | 0.0170 ns | 0.0142 ns | 11.3306 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 11.3569 ns | 0.0327 ns | 0.0306 ns | 11.3496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 11.2993 ns | 0.0100 ns | 0.0093 ns | 11.3004 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  6.6415 ns | 0.1217 ns | 0.1138 ns |  6.6032 ns |  0.58 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 11.9000 ns | 0.0775 ns | 0.0725 ns | 11.9394 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 11.5411 ns | 0.0154 ns | 0.0144 ns | 11.5387 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 11.6976 ns | 0.0098 ns | 0.0092 ns | 11.6967 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 11.5329 ns | 0.0130 ns | 0.0115 ns | 11.5305 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  6.4865 ns | 0.1306 ns | 0.1222 ns |  6.4074 ns |  0.55 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 | 11.5930 ns | 0.0156 ns | 0.0138 ns | 11.5980 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 11.3064 ns | 0.0177 ns | 0.0165 ns | 11.3062 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 12.2932 ns | 0.0251 ns | 0.0235 ns | 12.2886 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 12.5020 ns | 0.0983 ns | 0.0919 ns | 12.4437 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  7.1052 ns | 0.1227 ns | 0.1148 ns |  7.1909 ns |  0.58 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 12.6435 ns | 0.0190 ns | 0.0168 ns | 12.6408 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 12.9672 ns | 0.0681 ns | 0.0637 ns | 12.9337 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 11.0896 ns | 0.0173 ns | 0.0161 ns | 11.0870 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 11.0564 ns | 0.0080 ns | 0.0071 ns | 11.0561 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  6.4184 ns | 0.1210 ns | 0.1132 ns |  6.3227 ns |  0.58 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 11.2105 ns | 0.0779 ns | 0.0728 ns | 11.2497 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 | 11.2878 ns | 0.0178 ns | 0.0166 ns | 11.2871 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 12.3055 ns | 0.0111 ns | 0.0104 ns | 12.3048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 12.0491 ns | 0.0339 ns | 0.0300 ns | 12.0331 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  7.1161 ns | 0.1469 ns | 0.1374 ns |  7.0266 ns |  0.58 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 12.2887 ns | 0.0117 ns | 0.0104 ns | 12.2881 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 12.2743 ns | 0.0165 ns | 0.0146 ns | 12.2736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 23.0198 ns | 0.0404 ns | 0.0378 ns | 23.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 23.0014 ns | 0.0209 ns | 0.0185 ns | 23.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 10.9568 ns | 0.0109 ns | 0.0102 ns | 10.9585 ns |  0.48 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 23.4852 ns | 0.1447 ns | 0.1354 ns | 23.5462 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 | 23.2248 ns | 0.0240 ns | 0.0224 ns | 23.2247 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 23.0555 ns | 0.0392 ns | 0.0306 ns | 23.0572 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 22.9874 ns | 0.0220 ns | 0.0195 ns | 22.9866 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 10.9455 ns | 0.0131 ns | 0.0123 ns | 10.9473 ns |  0.47 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 28.9253 ns | 0.0727 ns | 0.0680 ns | 28.9201 ns |  1.25 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 34.2724 ns | 0.1130 ns | 0.1002 ns | 34.2248 ns |  1.49 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 53.4903 ns | 0.0663 ns | 0.0588 ns | 53.5082 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 54.0057 ns | 0.2973 ns | 0.2781 ns | 54.0982 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 11.9438 ns | 0.0501 ns | 0.0469 ns | 11.9597 ns |  0.22 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 53.7429 ns | 0.0674 ns | 0.0631 ns | 53.7233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 53.5825 ns | 0.0546 ns | 0.0511 ns | 53.5597 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 54.0593 ns | 0.0899 ns | 0.0797 ns | 54.0425 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 54.1476 ns | 0.0433 ns | 0.0405 ns | 54.1396 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 12.3267 ns | 0.0104 ns | 0.0092 ns | 12.3265 ns |  0.23 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 62.2366 ns | 0.2859 ns | 0.2675 ns | 62.3127 ns |  1.15 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 61.5650 ns | 0.0728 ns | 0.0681 ns | 61.5404 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  1.1814 ns | 0.0126 ns | 0.0112 ns |  1.1848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  1.1661 ns | 0.0041 ns | 0.0032 ns |  1.1659 ns |  0.99 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  1.3183 ns | 0.0026 ns | 0.0024 ns |  1.3181 ns |  1.12 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  1.4103 ns | 0.0048 ns | 0.0045 ns |  1.4117 ns |  1.19 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 10.4876 ns | 0.0431 ns | 0.0403 ns | 10.5005 ns |  8.88 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  3.9778 ns | 0.0033 ns | 0.0028 ns |  3.9776 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  3.9788 ns | 0.0328 ns | 0.0307 ns |  3.9993 ns |  1.00 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  3.9960 ns | 0.0168 ns | 0.0157 ns |  4.0016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  3.9266 ns | 0.0070 ns | 0.0065 ns |  3.9267 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  3.9562 ns | 0.0095 ns | 0.0089 ns |  3.9576 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  1.2577 ns | 0.0052 ns | 0.0048 ns |  1.2579 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  1.1865 ns | 0.0027 ns | 0.0024 ns |  1.1860 ns |  0.94 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  1.4227 ns | 0.0023 ns | 0.0021 ns |  1.4228 ns |  1.13 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 11.2287 ns | 0.0570 ns | 0.0533 ns | 11.2356 ns |  8.93 |    0.05 |     - |     - |     - |         - |
         FromDateTime |        net472 | 11.0678 ns | 0.0158 ns | 0.0148 ns | 11.0645 ns |  8.80 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  7.9992 ns | 0.0564 ns | 0.0528 ns |  7.9813 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  7.9723 ns | 0.0152 ns | 0.0142 ns |  7.9741 ns |  1.00 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.7416 ns | 0.0038 ns | 0.0034 ns |  1.7414 ns |  0.22 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 12.0355 ns | 0.0178 ns | 0.0167 ns | 12.0362 ns |  1.50 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 12.1261 ns | 0.0848 ns | 0.0793 ns | 12.0757 ns |  1.52 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  8.4554 ns | 0.0099 ns | 0.0087 ns |  8.4549 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  8.2233 ns | 0.0589 ns | 0.0551 ns |  8.2595 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.3290 ns | 0.0038 ns | 0.0036 ns |  2.3285 ns |  0.28 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  8.4113 ns | 0.0592 ns | 0.0554 ns |  8.4333 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  8.2156 ns | 0.0120 ns | 0.0112 ns |  8.2166 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 76.1224 ns | 0.3930 ns | 0.3677 ns | 76.2454 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 71.4486 ns | 0.0912 ns | 0.0854 ns | 71.4549 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 43.5365 ns | 0.0502 ns | 0.0469 ns | 43.5548 ns |  0.57 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 75.0501 ns | 0.1055 ns | 0.0987 ns | 75.0527 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 74.7961 ns | 0.0901 ns | 0.0799 ns | 74.8292 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 11.1100 ns | 0.0161 ns | 0.0143 ns | 11.1057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 11.0797 ns | 0.0219 ns | 0.0205 ns | 11.0740 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  6.4845 ns | 0.1159 ns | 0.1084 ns |  6.5407 ns |  0.58 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 | 11.1099 ns | 0.0140 ns | 0.0125 ns | 11.1082 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 11.1959 ns | 0.0664 ns | 0.0621 ns | 11.2261 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 11.9199 ns | 0.0666 ns | 0.0623 ns | 11.9403 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 11.5342 ns | 0.0162 ns | 0.0143 ns | 11.5312 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  6.6554 ns | 0.1233 ns | 0.1153 ns |  6.6091 ns |  0.56 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 11.9490 ns | 0.0542 ns | 0.0480 ns | 11.9573 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 11.7746 ns | 0.0132 ns | 0.0123 ns | 11.7731 ns |  0.99 |    0.01 |     - |     - |     - |         - |
