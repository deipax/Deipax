
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.6537 ns | 0.0028 ns | 0.0026 ns |  0.6533 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9130 ns | 0.0077 ns | 0.0064 ns |  0.9125 ns |  1.40 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1870 ns | 0.0329 ns | 0.0308 ns |  1.1681 ns |  1.82 |    0.05 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9014 ns | 0.0082 ns | 0.0073 ns |  0.8996 ns |  1.38 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9177 ns | 0.0171 ns | 0.0152 ns |  0.9163 ns |  1.40 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1687 ns | 0.0081 ns | 0.0075 ns |  1.1659 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.2755 ns | 0.0568 ns | 0.1147 ns |  1.2218 ns |  1.19 |    0.10 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.4169 ns | 0.0169 ns | 0.0150 ns |  1.4142 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6791 ns | 0.0356 ns | 0.0315 ns |  1.6663 ns |  1.44 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6679 ns | 0.0165 ns | 0.0138 ns |  1.6674 ns |  1.43 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.4529 ns | 0.0100 ns | 0.0089 ns |  0.4550 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4481 ns | 0.0067 ns | 0.0056 ns |  0.4457 ns |  0.99 |    0.03 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4766 ns | 0.0218 ns | 0.0204 ns |  0.4697 ns |  1.05 |    0.05 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4448 ns | 0.0376 ns | 0.0448 ns |  0.4455 ns |  0.98 |    0.08 |     - |     - |     - |         - |
             FromChar |        net472 |  0.4452 ns | 0.0075 ns | 0.0059 ns |  0.4470 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9129 ns | 0.0043 ns | 0.0036 ns |  0.9119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9154 ns | 0.0018 ns | 0.0016 ns |  0.9152 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1686 ns | 0.0069 ns | 0.0058 ns |  1.1652 ns |  1.28 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.3113 ns | 0.0230 ns | 0.0192 ns |  2.3064 ns |  2.53 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6313 ns | 0.0069 ns | 0.0065 ns |  1.6292 ns |  1.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.4431 ns | 0.0039 ns | 0.0036 ns |  0.4433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.4511 ns | 0.0069 ns | 0.0061 ns |  0.4525 ns |  1.02 |    0.02 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7020 ns | 0.0041 ns | 0.0039 ns |  0.7019 ns |  1.58 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.4398 ns | 0.0026 ns | 0.0023 ns |  0.4399 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.4345 ns | 0.0022 ns | 0.0019 ns |  0.4343 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.8612 ns | 0.0028 ns | 0.0025 ns |  0.8614 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9157 ns | 0.0054 ns | 0.0045 ns |  0.9153 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9541 ns | 0.0035 ns | 0.0030 ns |  0.9534 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.6107 ns | 0.0091 ns | 0.0080 ns |  1.6072 ns |  1.87 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6269 ns | 0.0135 ns | 0.0126 ns |  1.6252 ns |  1.89 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.4199 ns | 0.0044 ns | 0.0039 ns |  0.4187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4464 ns | 0.0036 ns | 0.0032 ns |  0.4461 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7146 ns | 0.0146 ns | 0.0136 ns |  0.7171 ns |  1.70 |    0.04 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4389 ns | 0.0020 ns | 0.0019 ns |  0.4389 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.4947 ns | 0.0370 ns | 0.0396 ns |  0.4859 ns |  1.19 |    0.10 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9280 ns | 0.0043 ns | 0.0040 ns |  0.9278 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9158 ns | 0.0033 ns | 0.0031 ns |  0.9153 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9406 ns | 0.0039 ns | 0.0033 ns |  0.9411 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6776 ns | 0.0537 ns | 0.0476 ns |  1.6709 ns |  1.81 |    0.05 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.7997 ns | 0.0134 ns | 0.0119 ns |  1.7966 ns |  1.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.4204 ns | 0.0028 ns | 0.0022 ns |  0.4202 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.5921 ns | 0.0088 ns | 0.0074 ns |  0.5901 ns |  1.41 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6999 ns | 0.0034 ns | 0.0030 ns |  0.6995 ns |  1.67 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.4414 ns | 0.0092 ns | 0.0081 ns |  0.4379 ns |  1.05 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 |  0.4373 ns | 0.0237 ns | 0.0222 ns |  0.4249 ns |  1.05 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.8731 ns | 0.0054 ns | 0.0050 ns |  0.8719 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.9244 ns | 0.0284 ns | 0.0265 ns |  0.9107 ns |  1.06 |    0.03 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1818 ns | 0.0321 ns | 0.0301 ns |  1.1661 ns |  1.35 |    0.03 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.0458 ns | 0.0250 ns | 0.0234 ns |  2.0462 ns |  2.34 |    0.03 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.6430 ns | 0.0180 ns | 0.0159 ns |  1.6445 ns |  1.88 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.4429 ns | 0.0062 ns | 0.0055 ns |  0.4406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.4601 ns | 0.0251 ns | 0.0223 ns |  0.4501 ns |  1.04 |    0.06 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.4881 ns | 0.0359 ns | 0.0413 ns |  0.4674 ns |  1.12 |    0.10 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.4514 ns | 0.0075 ns | 0.0066 ns |  0.4517 ns |  1.02 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.4357 ns | 0.0055 ns | 0.0046 ns |  0.4344 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9151 ns | 0.0029 ns | 0.0026 ns |  0.9150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.9220 ns | 0.0117 ns | 0.0091 ns |  0.9203 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0071 ns | 0.0461 ns | 0.0632 ns |  0.9890 ns |  1.12 |    0.08 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6316 ns | 0.0045 ns | 0.0040 ns |  1.6314 ns |  1.78 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6466 ns | 0.0151 ns | 0.0134 ns |  1.6421 ns |  1.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.4474 ns | 0.0063 ns | 0.0055 ns |  0.4486 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.4478 ns | 0.0015 ns | 0.0012 ns |  0.4477 ns |  1.00 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.5033 ns | 0.0155 ns | 0.0138 ns |  0.4979 ns |  1.13 |    0.04 |     - |     - |     - |         - |
              FromInt |        net461 |  0.4572 ns | 0.0238 ns | 0.0211 ns |  0.4453 ns |  1.02 |    0.04 |     - |     - |     - |         - |
              FromInt |        net472 |  0.4392 ns | 0.0114 ns | 0.0101 ns |  0.4352 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.0189 ns | 0.0157 ns | 0.0147 ns |  1.0105 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.8877 ns | 0.0065 ns | 0.0058 ns |  0.8867 ns |  0.87 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.9374 ns | 0.0070 ns | 0.0059 ns |  0.9368 ns |  0.92 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.4330 ns | 0.0109 ns | 0.0097 ns |  1.4319 ns |  1.41 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.4028 ns | 0.0149 ns | 0.0132 ns |  1.4004 ns |  1.38 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.2291 ns | 0.0100 ns | 0.0094 ns |  1.2319 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.3607 ns | 0.0381 ns | 0.0357 ns |  1.3451 ns |  1.11 |    0.03 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.5454 ns | 0.0128 ns | 0.0119 ns |  0.5480 ns |  0.44 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.6478 ns | 0.0143 ns | 0.0134 ns |  1.6503 ns |  1.34 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.5991 ns | 0.0122 ns | 0.0108 ns |  1.5968 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.7248 ns | 0.0040 ns | 0.0038 ns |  1.7246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.6921 ns | 0.0224 ns | 0.0198 ns |  1.6970 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.8311 ns | 0.0175 ns | 0.0163 ns |  0.8236 ns |  0.48 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.0865 ns | 0.0142 ns | 0.0119 ns |  2.0819 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.0819 ns | 0.0137 ns | 0.0114 ns |  2.0820 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.5741 ns | 0.0190 ns | 0.0178 ns |  1.5630 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8990 ns | 0.0170 ns | 0.0150 ns |  1.8917 ns |  1.21 |    0.02 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.9428 ns | 0.0626 ns | 0.0615 ns |  1.9132 ns |  1.24 |    0.04 |     - |     - |     - |         - |
             FromLong |        net461 |  1.5535 ns | 0.0020 ns | 0.0017 ns |  1.5530 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.5731 ns | 0.0086 ns | 0.0081 ns |  1.5740 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.9382 ns | 0.0090 ns | 0.0085 ns |  2.9410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.6633 ns | 0.0092 ns | 0.0082 ns |  2.6603 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.3247 ns | 0.0228 ns | 0.0213 ns |  3.3169 ns |  1.13 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 10.3143 ns | 0.0198 ns | 0.0176 ns | 10.3086 ns |  3.51 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.2285 ns | 0.0507 ns | 0.0474 ns |  3.2153 ns |  1.10 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.6108 ns | 0.0103 ns | 0.0086 ns |  1.6101 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.6430 ns | 0.0114 ns | 0.0095 ns |  1.6430 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.9084 ns | 0.0058 ns | 0.0048 ns |  1.9072 ns |  1.18 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6218 ns | 0.0044 ns | 0.0037 ns |  1.6206 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6339 ns | 0.0262 ns | 0.0245 ns |  1.6386 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.9299 ns | 0.0064 ns | 0.0060 ns |  2.9313 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.7451 ns | 0.0168 ns | 0.0149 ns |  2.7414 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.5997 ns | 0.0171 ns | 0.0159 ns |  2.5956 ns |  0.89 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0863 ns | 0.0090 ns | 0.0076 ns |  3.0874 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0748 ns | 0.0098 ns | 0.0087 ns |  3.0768 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5277 ns | 0.0073 ns | 0.0065 ns |  3.5272 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.5842 ns | 0.0412 ns | 0.0385 ns |  3.5824 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.4971 ns | 0.0137 ns | 0.0128 ns |  3.4989 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.5775 ns | 0.0253 ns | 0.0236 ns |  3.5739 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5096 ns | 0.0172 ns | 0.0144 ns |  3.5145 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  2.9631 ns | 0.0144 ns | 0.0134 ns |  2.9631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.1615 ns | 0.0421 ns | 0.0373 ns |  3.1504 ns |  1.07 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.3422 ns | 0.0266 ns | 0.0236 ns |  3.3361 ns |  1.13 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.4883 ns | 0.0106 ns | 0.0088 ns |  3.4887 ns |  1.18 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.4999 ns | 0.0305 ns | 0.0285 ns |  3.4937 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.3907 ns | 0.0085 ns | 0.0079 ns |  2.3895 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.6837 ns | 0.0826 ns | 0.0773 ns |  2.6805 ns |  1.12 |    0.03 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.8884 ns | 0.0166 ns | 0.0156 ns |  2.8833 ns |  1.21 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.4332 ns | 0.0665 ns | 0.0622 ns |  2.4455 ns |  1.02 |    0.03 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.4054 ns | 0.0691 ns | 0.0612 ns |  2.3763 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  3.6730 ns | 0.0330 ns | 0.0308 ns |  3.6886 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.6007 ns | 0.0251 ns | 0.0223 ns |  3.5911 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.5772 ns | 0.0383 ns | 0.0358 ns |  3.5601 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  3.7163 ns | 0.0132 ns | 0.0103 ns |  3.7132 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  3.7295 ns | 0.0426 ns | 0.0356 ns |  3.7284 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.1775 ns | 0.0187 ns | 0.0175 ns | 13.1770 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.5403 ns | 0.1621 ns | 0.1516 ns | 13.6066 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.9152 ns | 0.0266 ns | 0.0236 ns |  5.9049 ns |  0.45 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  7.3977 ns | 0.0169 ns | 0.0132 ns |  7.3965 ns |  0.56 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  7.6421 ns | 0.0776 ns | 0.0688 ns |  7.6517 ns |  0.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.9256 ns | 0.0297 ns | 0.0263 ns | 23.9204 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.9900 ns | 0.0725 ns | 0.0678 ns | 23.9868 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.7333 ns | 0.0369 ns | 0.0345 ns | 12.7278 ns |  0.53 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 18.0427 ns | 0.2617 ns | 0.2448 ns | 17.8946 ns |  0.75 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 18.2694 ns | 0.0753 ns | 0.0704 ns | 18.2886 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.4436 ns | 0.0018 ns | 0.0016 ns |  0.4437 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7154 ns | 0.0050 ns | 0.0044 ns |  0.7145 ns |  1.61 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6668 ns | 0.0082 ns | 0.0069 ns |  0.6648 ns |  1.50 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.4602 ns | 0.0058 ns | 0.0048 ns |  0.4592 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.4501 ns | 0.0068 ns | 0.0064 ns |  0.4497 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4490 ns | 0.0107 ns | 0.0095 ns |  1.4462 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4542 ns | 0.0100 ns | 0.0093 ns |  1.4515 ns |  1.00 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4337 ns | 0.0214 ns | 0.0200 ns |  1.4328 ns |  0.99 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4506 ns | 0.0057 ns | 0.0051 ns |  1.4495 ns |  1.00 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6799 ns | 0.0471 ns | 0.0417 ns |  1.6844 ns |  1.16 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2612 ns | 0.0233 ns | 0.0218 ns |  2.2673 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.3356 ns | 0.0335 ns | 0.0314 ns |  2.3294 ns |  1.03 |    0.02 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1268 ns | 0.0105 ns | 0.0093 ns |  2.1238 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2518 ns | 0.0071 ns | 0.0066 ns |  2.2500 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2696 ns | 0.0182 ns | 0.0170 ns |  2.2758 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.5418 ns | 0.0747 ns | 0.0662 ns | 47.5606 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 41.6371 ns | 0.1198 ns | 0.1000 ns | 41.6267 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.4959 ns | 0.0778 ns | 0.0649 ns | 10.5028 ns |  0.22 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 45.5090 ns | 0.1213 ns | 0.0947 ns | 45.5538 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.7324 ns | 0.3221 ns | 0.3013 ns | 46.6168 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.5640 ns | 0.0040 ns | 0.0034 ns |  0.5631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7378 ns | 0.0046 ns | 0.0038 ns |  0.7371 ns |  1.31 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6766 ns | 0.0166 ns | 0.0155 ns |  0.6699 ns |  1.19 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.4466 ns | 0.0029 ns | 0.0027 ns |  0.4474 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.4456 ns | 0.0081 ns | 0.0064 ns |  0.4444 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.9147 ns | 0.0098 ns | 0.0087 ns |  0.9132 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1865 ns | 0.0060 ns | 0.0050 ns |  1.1874 ns |  1.30 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1506 ns | 0.0129 ns | 0.0115 ns |  1.1519 ns |  1.26 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6118 ns | 0.0064 ns | 0.0050 ns |  1.6128 ns |  1.76 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.6042 ns | 0.0117 ns | 0.0109 ns |  1.6023 ns |  1.76 |    0.02 |     - |     - |     - |         - |
