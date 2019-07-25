
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 17.1938 ns | 0.0215 ns | 0.0179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 17.4054 ns | 0.0274 ns | 0.0243 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 11.9617 ns | 0.1202 ns | 0.1125 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 17.7623 ns | 0.1421 ns | 0.1260 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 | 17.1421 ns | 0.0139 ns | 0.0123 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  9.5902 ns | 0.0160 ns | 0.0150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  9.9586 ns | 0.0132 ns | 0.0117 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.7659 ns | 0.0124 ns | 0.0104 ns |  0.18 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 11.4114 ns | 0.0265 ns | 0.0248 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 11.3438 ns | 0.0124 ns | 0.0116 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9214 ns | 0.0026 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6377 ns | 0.0016 ns | 0.0014 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5923 ns | 0.0111 ns | 0.0093 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7046 ns | 0.0044 ns | 0.0041 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6194 ns | 0.0056 ns | 0.0052 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9185 ns | 0.0020 ns | 0.0017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9095 ns | 0.0031 ns | 0.0029 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.8229 ns | 0.0100 ns | 0.0078 ns |  0.90 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9787 ns | 0.0043 ns | 0.0039 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9002 ns | 0.0024 ns | 0.0021 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 17.5609 ns | 0.0249 ns | 0.0233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 17.2843 ns | 0.0354 ns | 0.0314 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 12.4372 ns | 0.0358 ns | 0.0317 ns |  0.71 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 25.0228 ns | 0.1043 ns | 0.0976 ns |  1.42 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 17.2493 ns | 0.0516 ns | 0.0457 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  9.5837 ns | 0.0128 ns | 0.0120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  9.9514 ns | 0.0192 ns | 0.0161 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.6847 ns | 0.0183 ns | 0.0153 ns |  0.18 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 11.3485 ns | 0.0160 ns | 0.0134 ns |  1.18 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 11.3441 ns | 0.0087 ns | 0.0081 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 16.9662 ns | 0.0251 ns | 0.0222 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 17.1176 ns | 0.0149 ns | 0.0125 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 12.1980 ns | 0.2635 ns | 0.2588 ns |  0.72 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 | 17.2486 ns | 0.0619 ns | 0.0579 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 16.8829 ns | 0.0121 ns | 0.0113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  9.5911 ns | 0.0141 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  9.9545 ns | 0.0111 ns | 0.0099 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.7222 ns | 0.0239 ns | 0.0212 ns |  0.18 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 11.8353 ns | 0.0289 ns | 0.0271 ns |  1.23 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 11.3395 ns | 0.0158 ns | 0.0140 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 16.9803 ns | 0.0339 ns | 0.0300 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 17.6210 ns | 0.1174 ns | 0.1098 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 11.9871 ns | 0.1751 ns | 0.1638 ns |  0.70 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 | 16.9244 ns | 0.0642 ns | 0.0600 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 16.8947 ns | 0.0180 ns | 0.0168 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  9.7139 ns | 0.0143 ns | 0.0127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 10.0850 ns | 0.0108 ns | 0.0090 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.9109 ns | 0.0206 ns | 0.0193 ns |  0.20 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 11.1652 ns | 0.0117 ns | 0.0109 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 11.1480 ns | 0.0086 ns | 0.0076 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 16.9946 ns | 0.0283 ns | 0.0264 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 17.5783 ns | 0.0221 ns | 0.0196 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 11.7988 ns | 0.1069 ns | 0.1000 ns |  0.69 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 17.4721 ns | 0.0445 ns | 0.0416 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 17.0044 ns | 0.0226 ns | 0.0212 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  9.7874 ns | 0.0208 ns | 0.0162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  9.9878 ns | 0.0257 ns | 0.0241 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.8030 ns | 0.0052 ns | 0.0040 ns |  0.18 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 11.2901 ns | 0.1624 ns | 0.1519 ns |  1.16 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 11.1487 ns | 0.0157 ns | 0.0140 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 16.9830 ns | 0.0329 ns | 0.0307 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 17.1110 ns | 0.0273 ns | 0.0255 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 11.9178 ns | 0.1348 ns | 0.1261 ns |  0.70 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 | 16.9133 ns | 0.0270 ns | 0.0240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 17.0239 ns | 0.0359 ns | 0.0336 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  9.6942 ns | 0.0117 ns | 0.0110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  9.9773 ns | 0.0097 ns | 0.0081 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.8807 ns | 0.0409 ns | 0.0383 ns |  0.19 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 12.0521 ns | 0.0655 ns | 0.0613 ns |  1.24 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 11.1483 ns | 0.0109 ns | 0.0102 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 17.1674 ns | 0.0294 ns | 0.0275 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 17.0418 ns | 0.0578 ns | 0.0513 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 12.0854 ns | 0.1748 ns | 0.1635 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 16.6589 ns | 0.0226 ns | 0.0200 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 16.9164 ns | 0.0254 ns | 0.0225 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  9.7063 ns | 0.0082 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 10.0260 ns | 0.0180 ns | 0.0150 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.8865 ns | 0.0147 ns | 0.0138 ns |  0.19 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 11.2444 ns | 0.0654 ns | 0.0611 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 11.1610 ns | 0.0108 ns | 0.0096 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 17.6310 ns | 0.0434 ns | 0.0406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 17.4463 ns | 0.0200 ns | 0.0178 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 12.4615 ns | 0.1984 ns | 0.1856 ns |  0.71 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 | 17.5647 ns | 0.0216 ns | 0.0202 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 17.1984 ns | 0.0946 ns | 0.0885 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  9.3320 ns | 0.0096 ns | 0.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 10.0804 ns | 0.0078 ns | 0.0065 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.9558 ns | 0.0047 ns | 0.0039 ns |  0.21 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 11.2842 ns | 0.0215 ns | 0.0190 ns |  1.21 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 11.0572 ns | 0.0106 ns | 0.0094 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 17.0323 ns | 0.0308 ns | 0.0257 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 17.5918 ns | 0.0230 ns | 0.0215 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 12.2144 ns | 0.2457 ns | 0.2298 ns |  0.72 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 16.8960 ns | 0.0442 ns | 0.0414 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 18.2975 ns | 0.0773 ns | 0.0685 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 10.7089 ns | 0.0662 ns | 0.0619 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 10.1613 ns | 0.0283 ns | 0.0236 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.5433 ns | 0.0581 ns | 0.0543 ns |  0.24 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 11.0454 ns | 0.0130 ns | 0.0115 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 11.2171 ns | 0.0209 ns | 0.0186 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 19.4030 ns | 0.0332 ns | 0.0311 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 19.9588 ns | 0.0205 ns | 0.0181 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  9.0863 ns | 0.0798 ns | 0.0747 ns |  0.47 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 20.1932 ns | 0.0406 ns | 0.0380 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 20.1720 ns | 0.0232 ns | 0.0206 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  9.7641 ns | 0.0112 ns | 0.0093 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 10.0509 ns | 0.0141 ns | 0.0125 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  2.2015 ns | 0.0689 ns | 0.0766 ns |  0.23 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 11.1412 ns | 0.0319 ns | 0.0298 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 11.1082 ns | 0.0119 ns | 0.0100 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 19.9393 ns | 0.0452 ns | 0.0423 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 19.6425 ns | 0.0453 ns | 0.0424 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  9.1494 ns | 0.2033 ns | 0.1902 ns |  0.46 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 | 20.0591 ns | 0.0936 ns | 0.0876 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 | 28.6957 ns | 0.0308 ns | 0.0288 ns |  1.44 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 10.8876 ns | 0.0098 ns | 0.0086 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 10.1925 ns | 0.0094 ns | 0.0073 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  2.2180 ns | 0.0114 ns | 0.0096 ns |  0.20 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 11.0681 ns | 0.0111 ns | 0.0099 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 10.9915 ns | 0.0090 ns | 0.0080 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  5.9149 ns | 0.0109 ns | 0.0091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  5.6421 ns | 0.0062 ns | 0.0058 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6576 ns | 0.0197 ns | 0.0184 ns |  0.96 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  5.6166 ns | 0.0087 ns | 0.0077 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  5.6396 ns | 0.0169 ns | 0.0158 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  1.4184 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  1.4001 ns | 0.0128 ns | 0.0100 ns |  0.99 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  1.4072 ns | 0.0402 ns | 0.0376 ns |  0.99 |    0.03 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  1.3632 ns | 0.0041 ns | 0.0036 ns |  0.96 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  1.4242 ns | 0.0038 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9166 ns | 0.0017 ns | 0.0016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7144 ns | 0.0149 ns | 0.0132 ns |  0.78 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7646 ns | 0.0076 ns | 0.0067 ns |  0.83 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9629 ns | 0.0043 ns | 0.0038 ns |  1.05 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9294 ns | 0.0048 ns | 0.0043 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4473 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.7707 ns | 0.0439 ns | 0.0389 ns |  1.22 |    0.03 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5682 ns | 0.0145 ns | 0.0136 ns |  1.08 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6423 ns | 0.0145 ns | 0.0136 ns |  1.13 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6628 ns | 0.0037 ns | 0.0034 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.0189 ns | 0.0246 ns | 0.0218 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  9.0750 ns | 0.0507 ns | 0.0474 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  8.7256 ns | 0.1187 ns | 0.1053 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  8.7864 ns | 0.0232 ns | 0.0217 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  8.8406 ns | 0.0143 ns | 0.0134 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  9.6457 ns | 0.0090 ns | 0.0075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  8.0420 ns | 0.0880 ns | 0.0823 ns |  0.83 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9346 ns | 0.0145 ns | 0.0129 ns |  0.20 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 11.3420 ns | 0.0108 ns | 0.0090 ns |  1.18 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 11.3715 ns | 0.0106 ns | 0.0082 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 16.9635 ns | 0.0308 ns | 0.0288 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 17.3475 ns | 0.1125 ns | 0.1052 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 11.9118 ns | 0.1342 ns | 0.1255 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 | 17.5711 ns | 0.0249 ns | 0.0233 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 17.6119 ns | 0.0220 ns | 0.0206 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  9.7902 ns | 0.0161 ns | 0.0143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 10.1686 ns | 0.0813 ns | 0.0760 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.9473 ns | 0.0197 ns | 0.0175 ns |  0.20 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 11.2374 ns | 0.0377 ns | 0.0353 ns |  1.15 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 12.8696 ns | 0.0535 ns | 0.0500 ns |  1.31 |    0.01 |     - |     - |     - |         - |
