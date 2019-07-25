
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
             FromBool | .NET Core 2.0 | 17.1512 ns | 0.0666 ns | 0.0590 ns | 17.1244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 17.3629 ns | 0.0908 ns | 0.0849 ns | 17.3315 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 11.8603 ns | 0.0365 ns | 0.0305 ns | 11.8525 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 | 17.5861 ns | 0.0244 ns | 0.0216 ns | 17.5882 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 17.3982 ns | 0.0317 ns | 0.0264 ns | 17.3932 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 17.5574 ns | 0.0256 ns | 0.0239 ns | 17.5572 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 17.3087 ns | 0.0132 ns | 0.0117 ns | 17.3111 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 12.5114 ns | 0.2586 ns | 0.2419 ns | 12.3012 ns |  0.71 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 17.7378 ns | 0.0178 ns | 0.0167 ns | 17.7425 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 17.8532 ns | 0.0172 ns | 0.0161 ns | 17.8552 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9210 ns | 0.0024 ns | 0.0022 ns |  0.9212 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6286 ns | 0.0025 ns | 0.0024 ns |  0.6281 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6881 ns | 0.0088 ns | 0.0083 ns |  0.6837 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7313 ns | 0.0026 ns | 0.0023 ns |  0.7313 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7333 ns | 0.0082 ns | 0.0077 ns |  0.7303 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9254 ns | 0.0054 ns | 0.0051 ns |  0.9268 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9325 ns | 0.0035 ns | 0.0031 ns |  0.9317 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9280 ns | 0.0053 ns | 0.0050 ns |  0.9263 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9809 ns | 0.0076 ns | 0.0067 ns |  0.9785 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9671 ns | 0.0022 ns | 0.0020 ns |  0.9667 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 16.9849 ns | 0.0319 ns | 0.0283 ns | 16.9797 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 17.5508 ns | 0.0195 ns | 0.0163 ns | 17.5466 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 12.0444 ns | 0.2336 ns | 0.2185 ns | 11.8962 ns |  0.71 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 16.9270 ns | 0.0403 ns | 0.0377 ns | 16.9203 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 | 17.1082 ns | 0.0199 ns | 0.0186 ns | 17.1086 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 17.2193 ns | 0.0287 ns | 0.0255 ns | 17.2210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 17.3982 ns | 0.0898 ns | 0.0840 ns | 17.3824 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 12.0948 ns | 0.1225 ns | 0.1146 ns | 12.1658 ns |  0.70 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 17.7018 ns | 0.0290 ns | 0.0242 ns | 17.7046 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 17.8522 ns | 0.0221 ns | 0.0172 ns | 17.8446 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 16.8786 ns | 0.0226 ns | 0.0211 ns | 16.8714 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 16.8697 ns | 0.0338 ns | 0.0316 ns | 16.8732 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 12.0874 ns | 0.2630 ns | 0.2460 ns | 11.8797 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 | 17.1413 ns | 0.0210 ns | 0.0175 ns | 17.1422 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 16.9031 ns | 0.0355 ns | 0.0332 ns | 16.8913 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 16.9580 ns | 0.0308 ns | 0.0273 ns | 16.9507 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 17.3351 ns | 0.0441 ns | 0.0412 ns | 17.3165 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 12.3160 ns | 0.2651 ns | 0.2480 ns | 12.5102 ns |  0.73 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 17.6677 ns | 0.0347 ns | 0.0325 ns | 17.6682 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 18.0469 ns | 0.0253 ns | 0.0237 ns | 18.0410 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 16.9955 ns | 0.0159 ns | 0.0148 ns | 16.9936 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 17.0032 ns | 0.0632 ns | 0.0592 ns | 17.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 11.6238 ns | 0.0279 ns | 0.0261 ns | 11.6149 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 17.5376 ns | 0.0309 ns | 0.0289 ns | 17.5309 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 17.5030 ns | 0.0196 ns | 0.0184 ns | 17.5087 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 17.1557 ns | 0.0266 ns | 0.0222 ns | 17.1537 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 17.1041 ns | 0.0159 ns | 0.0124 ns | 17.1045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 12.2882 ns | 0.2618 ns | 0.2449 ns | 12.0880 ns |  0.72 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 18.0541 ns | 0.0203 ns | 0.0190 ns | 18.0499 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 17.5838 ns | 0.0288 ns | 0.0255 ns | 17.5789 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 17.0037 ns | 0.0209 ns | 0.0195 ns | 17.0008 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 17.5813 ns | 0.0270 ns | 0.0253 ns | 17.5821 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 11.6754 ns | 0.0963 ns | 0.0854 ns | 11.6387 ns |  0.69 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 17.0439 ns | 0.0404 ns | 0.0378 ns | 17.0425 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 17.7294 ns | 0.0222 ns | 0.0197 ns | 17.7323 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 16.9360 ns | 0.0281 ns | 0.0262 ns | 16.9261 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 17.5020 ns | 0.0311 ns | 0.0291 ns | 17.4921 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 11.9303 ns | 0.1299 ns | 0.1215 ns | 11.8570 ns |  0.70 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 18.2217 ns | 0.0207 ns | 0.0173 ns | 18.2203 ns |  1.08 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 17.3707 ns | 0.0203 ns | 0.0190 ns | 17.3686 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 16.7158 ns | 0.0200 ns | 0.0187 ns | 16.7140 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 17.0905 ns | 0.0155 ns | 0.0137 ns | 17.0884 ns |  1.02 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 12.2128 ns | 0.1992 ns | 0.1863 ns | 12.2953 ns |  0.73 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 | 17.2184 ns | 0.0257 ns | 0.0228 ns | 17.2164 ns |  1.03 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 17.2140 ns | 0.0179 ns | 0.0167 ns | 17.2146 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 17.2805 ns | 0.0857 ns | 0.0801 ns | 17.2454 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 18.7801 ns | 0.0268 ns | 0.0251 ns | 18.7670 ns |  1.09 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 12.1802 ns | 0.0111 ns | 0.0104 ns | 12.1804 ns |  0.70 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 17.6207 ns | 0.0197 ns | 0.0165 ns | 17.6194 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 18.0739 ns | 0.0228 ns | 0.0213 ns | 18.0666 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 16.7192 ns | 0.0261 ns | 0.0218 ns | 16.7153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 16.8905 ns | 0.0399 ns | 0.0373 ns | 16.8855 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 11.7486 ns | 0.1200 ns | 0.1122 ns | 11.8181 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 16.9533 ns | 0.0166 ns | 0.0155 ns | 16.9564 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 16.8694 ns | 0.0353 ns | 0.0313 ns | 16.8724 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 17.6472 ns | 0.0199 ns | 0.0166 ns | 17.6448 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 17.3884 ns | 0.0792 ns | 0.0740 ns | 17.3575 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 12.0534 ns | 0.1314 ns | 0.1229 ns | 12.1319 ns |  0.68 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 17.3463 ns | 0.0396 ns | 0.0351 ns | 17.3418 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 18.2472 ns | 0.0204 ns | 0.0181 ns | 18.2516 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 16.7106 ns | 0.0342 ns | 0.0303 ns | 16.7122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 16.8990 ns | 0.0202 ns | 0.0179 ns | 16.8986 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 12.2238 ns | 0.1457 ns | 0.1292 ns | 12.2705 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 | 17.0944 ns | 0.0280 ns | 0.0262 ns | 17.0928 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 17.5522 ns | 0.0245 ns | 0.0217 ns | 17.5574 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 18.7334 ns | 0.0318 ns | 0.0297 ns | 18.7396 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 18.2886 ns | 0.0242 ns | 0.0226 ns | 18.2938 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 13.0828 ns | 0.2349 ns | 0.2197 ns | 13.2247 ns |  0.70 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 18.7290 ns | 0.0577 ns | 0.0539 ns | 18.7349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 18.9605 ns | 0.0252 ns | 0.0236 ns | 18.9530 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 16.8682 ns | 0.0315 ns | 0.0294 ns | 16.8633 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 17.7175 ns | 0.0462 ns | 0.0432 ns | 17.7225 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 11.9759 ns | 0.2082 ns | 0.1948 ns | 11.8698 ns |  0.71 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 17.5575 ns | 0.0155 ns | 0.0137 ns | 17.5607 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 17.0879 ns | 0.0223 ns | 0.0197 ns | 17.0915 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 17.6667 ns | 0.0354 ns | 0.0331 ns | 17.6632 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 18.3093 ns | 0.0312 ns | 0.0292 ns | 18.3221 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 12.6456 ns | 0.0575 ns | 0.0449 ns | 12.6492 ns |  0.72 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 18.9804 ns | 0.0249 ns | 0.0221 ns | 18.9785 ns |  1.07 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 18.6163 ns | 0.0119 ns | 0.0105 ns | 18.6122 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 32.4428 ns | 0.0504 ns | 0.0471 ns | 32.4476 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 32.6465 ns | 0.0762 ns | 0.0713 ns | 32.6519 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 15.9029 ns | 0.1387 ns | 0.1297 ns | 15.9284 ns |  0.49 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 33.2971 ns | 0.0735 ns | 0.0687 ns | 33.2932 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 33.8514 ns | 0.1312 ns | 0.1096 ns | 33.8784 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 32.7783 ns | 0.0755 ns | 0.0706 ns | 32.7819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 33.3903 ns | 0.0860 ns | 0.0763 ns | 33.4002 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 15.9044 ns | 0.1482 ns | 0.1386 ns | 15.9955 ns |  0.49 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 33.2537 ns | 0.0622 ns | 0.0581 ns | 33.2407 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 33.4908 ns | 0.1201 ns | 0.1065 ns | 33.4606 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 64.5470 ns | 0.0810 ns | 0.0758 ns | 64.5667 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 64.3057 ns | 0.1289 ns | 0.1142 ns | 64.2916 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 16.8420 ns | 0.2097 ns | 0.1961 ns | 16.7261 ns |  0.26 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 65.2888 ns | 0.0981 ns | 0.0918 ns | 65.2703 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 65.6135 ns | 0.7728 ns | 0.6453 ns | 65.3053 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 64.6530 ns | 0.1391 ns | 0.1301 ns | 64.6774 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 65.6406 ns | 0.2894 ns | 0.2707 ns | 65.7115 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 17.6077 ns | 0.1165 ns | 0.1033 ns | 17.6383 ns |  0.27 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 65.6189 ns | 0.0873 ns | 0.0729 ns | 65.6323 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 65.3058 ns | 0.0934 ns | 0.0780 ns | 65.3031 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  5.5973 ns | 0.0074 ns | 0.0070 ns |  5.5967 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  5.5735 ns | 0.0061 ns | 0.0057 ns |  5.5720 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6657 ns | 0.0192 ns | 0.0160 ns |  5.6707 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  5.5713 ns | 0.0120 ns | 0.0093 ns |  5.5697 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  5.5653 ns | 0.0124 ns | 0.0116 ns |  5.5642 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  1.5583 ns | 0.0060 ns | 0.0056 ns |  1.5574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  1.3644 ns | 0.0112 ns | 0.0104 ns |  1.3604 ns |  0.88 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  1.3847 ns | 0.0058 ns | 0.0054 ns |  1.3828 ns |  0.89 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  1.6178 ns | 0.0042 ns | 0.0037 ns |  1.6168 ns |  1.04 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  1.6195 ns | 0.0039 ns | 0.0037 ns |  1.6194 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9216 ns | 0.0076 ns | 0.0071 ns |  0.9190 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7183 ns | 0.0027 ns | 0.0024 ns |  0.7178 ns |  0.78 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.8881 ns | 0.0125 ns | 0.0117 ns |  0.8836 ns |  0.96 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9043 ns | 0.0075 ns | 0.0070 ns |  0.9060 ns |  0.98 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8830 ns | 0.0029 ns | 0.0024 ns |  0.8832 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4483 ns | 0.0049 ns | 0.0043 ns |  1.4489 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6468 ns | 0.0017 ns | 0.0015 ns |  1.6468 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.8814 ns | 0.0032 ns | 0.0029 ns |  1.8817 ns |  1.30 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6383 ns | 0.0035 ns | 0.0029 ns |  1.6380 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6658 ns | 0.0098 ns | 0.0087 ns |  1.6667 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 18.8988 ns | 0.0849 ns | 0.0794 ns | 18.8770 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 21.3387 ns | 0.0205 ns | 0.0192 ns | 21.3418 ns |  1.13 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 23.1396 ns | 0.0546 ns | 0.0511 ns | 23.1265 ns |  1.22 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 22.6904 ns | 0.0274 ns | 0.0243 ns | 22.6893 ns |  1.20 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 22.6175 ns | 0.0394 ns | 0.0368 ns | 22.6020 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 76.5233 ns | 0.1062 ns | 0.0886 ns | 76.5257 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 71.0841 ns | 0.1289 ns | 0.1205 ns | 71.0490 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 47.5622 ns | 0.2083 ns | 0.1949 ns | 47.4792 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 78.3126 ns | 0.1119 ns | 0.0992 ns | 78.3263 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 79.3149 ns | 0.0781 ns | 0.0610 ns | 79.3271 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 16.7659 ns | 0.0992 ns | 0.0927 ns | 16.7293 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 17.6201 ns | 0.0805 ns | 0.0753 ns | 17.5914 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 11.7544 ns | 0.1209 ns | 0.1010 ns | 11.8038 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 | 17.3228 ns | 0.0682 ns | 0.0604 ns | 17.3296 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 | 17.1643 ns | 0.0213 ns | 0.0199 ns | 17.1557 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 17.6440 ns | 0.0316 ns | 0.0280 ns | 17.6392 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 17.1448 ns | 0.0216 ns | 0.0181 ns | 17.1423 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 12.0158 ns | 0.1220 ns | 0.1141 ns | 12.0429 ns |  0.68 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 17.5752 ns | 0.0277 ns | 0.0259 ns | 17.5713 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 18.0298 ns | 0.0301 ns | 0.0267 ns | 18.0247 ns |  1.02 |    0.00 |     - |     - |     - |         - |
