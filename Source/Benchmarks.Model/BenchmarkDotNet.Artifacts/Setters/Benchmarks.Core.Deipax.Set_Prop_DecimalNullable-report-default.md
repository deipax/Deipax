
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
             FromBool | .NET Core 2.0 | 17.7514 ns | 0.1216 ns | 0.1137 ns | 17.8017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 17.0935 ns | 0.0304 ns | 0.0285 ns | 17.0970 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 11.6385 ns | 0.1203 ns | 0.1125 ns | 11.5772 ns |  0.66 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 17.5237 ns | 0.0225 ns | 0.0210 ns | 17.5267 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 | 16.8844 ns | 0.0834 ns | 0.0739 ns | 16.8592 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 17.4848 ns | 0.0259 ns | 0.0242 ns | 17.4842 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 17.7579 ns | 0.0242 ns | 0.0226 ns | 17.7579 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 11.9904 ns | 0.1173 ns | 0.1097 ns | 12.0484 ns |  0.69 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 18.2161 ns | 0.0355 ns | 0.0315 ns | 18.2156 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 17.7978 ns | 0.0363 ns | 0.0303 ns | 17.8005 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9195 ns | 0.0034 ns | 0.0032 ns |  0.9195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6321 ns | 0.0026 ns | 0.0021 ns |  0.6321 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7472 ns | 0.0086 ns | 0.0081 ns |  0.7505 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7266 ns | 0.0034 ns | 0.0027 ns |  0.7268 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7173 ns | 0.0061 ns | 0.0057 ns |  0.7180 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9159 ns | 0.0030 ns | 0.0028 ns |  0.9155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9084 ns | 0.0029 ns | 0.0027 ns |  0.9089 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9692 ns | 0.0032 ns | 0.0030 ns |  0.9696 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.2973 ns | 0.0020 ns | 0.0016 ns |  1.2973 ns |  1.42 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9665 ns | 0.0041 ns | 0.0034 ns |  0.9666 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 17.3232 ns | 0.0169 ns | 0.0158 ns | 17.3210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 17.5139 ns | 0.0212 ns | 0.0198 ns | 17.5086 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 11.9322 ns | 0.2296 ns | 0.2147 ns | 11.8111 ns |  0.69 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 17.0949 ns | 0.0307 ns | 0.0287 ns | 17.1012 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 | 17.0163 ns | 0.0588 ns | 0.0521 ns | 17.0218 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 17.4263 ns | 0.0519 ns | 0.0460 ns | 17.4211 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 17.2912 ns | 0.0288 ns | 0.0256 ns | 17.2792 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 12.3098 ns | 0.2573 ns | 0.2407 ns | 12.1988 ns |  0.71 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 17.5318 ns | 0.0139 ns | 0.0123 ns | 17.5316 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 17.3010 ns | 0.0256 ns | 0.0239 ns | 17.3005 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 16.8812 ns | 0.0231 ns | 0.0204 ns | 16.8788 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 17.0734 ns | 0.0355 ns | 0.0315 ns | 17.0746 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 12.1185 ns | 0.2141 ns | 0.2002 ns | 12.2486 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 | 17.1099 ns | 0.0235 ns | 0.0220 ns | 17.1148 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 18.4481 ns | 0.0320 ns | 0.0299 ns | 18.4471 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 17.1136 ns | 0.0139 ns | 0.0123 ns | 17.1118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 17.7305 ns | 0.0186 ns | 0.0165 ns | 17.7367 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 12.3286 ns | 0.2474 ns | 0.2314 ns | 12.4744 ns |  0.72 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 18.1252 ns | 0.0574 ns | 0.0537 ns | 18.1391 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 18.0413 ns | 0.0302 ns | 0.0283 ns | 18.0495 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 16.9190 ns | 0.0189 ns | 0.0147 ns | 16.9209 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 16.8085 ns | 0.0313 ns | 0.0292 ns | 16.8031 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 12.3021 ns | 0.1835 ns | 0.1716 ns | 12.2942 ns |  0.73 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 | 17.5129 ns | 0.0237 ns | 0.0222 ns | 17.5089 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 17.5317 ns | 0.0132 ns | 0.0124 ns | 17.5328 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 17.1174 ns | 0.0231 ns | 0.0216 ns | 17.1164 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 17.7305 ns | 0.0144 ns | 0.0135 ns | 17.7298 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 11.9373 ns | 0.1297 ns | 0.1213 ns | 12.0268 ns |  0.70 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 17.3298 ns | 0.0285 ns | 0.0267 ns | 17.3371 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 17.3074 ns | 0.0269 ns | 0.0239 ns | 17.3041 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 16.8992 ns | 0.0186 ns | 0.0174 ns | 16.8974 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 17.3208 ns | 0.1197 ns | 0.1120 ns | 17.3626 ns |  1.02 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 11.7042 ns | 0.1247 ns | 0.1166 ns | 11.7929 ns |  0.69 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 17.5198 ns | 0.0232 ns | 0.0217 ns | 17.5234 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 16.8340 ns | 0.0329 ns | 0.0308 ns | 16.8397 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 16.9133 ns | 0.0507 ns | 0.0423 ns | 16.9037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 17.7440 ns | 0.0296 ns | 0.0277 ns | 17.7445 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 12.4661 ns | 0.2467 ns | 0.2307 ns | 12.6378 ns |  0.74 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 18.0051 ns | 0.0346 ns | 0.0324 ns | 18.0060 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 18.0006 ns | 0.0226 ns | 0.0211 ns | 18.0073 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 16.8753 ns | 0.0265 ns | 0.0248 ns | 16.8794 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 17.4875 ns | 0.0215 ns | 0.0201 ns | 17.4888 ns |  1.04 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 11.9814 ns | 0.2255 ns | 0.2109 ns | 11.8427 ns |  0.71 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 | 17.0615 ns | 0.0251 ns | 0.0234 ns | 17.0591 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 16.8537 ns | 0.0336 ns | 0.0281 ns | 16.8509 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 17.0901 ns | 0.0267 ns | 0.0250 ns | 17.0845 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 17.7592 ns | 0.0353 ns | 0.0330 ns | 17.7627 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 11.8073 ns | 0.0139 ns | 0.0116 ns | 11.8069 ns |  0.69 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 17.3271 ns | 0.0180 ns | 0.0159 ns | 17.3290 ns |  1.01 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 17.3501 ns | 0.0343 ns | 0.0321 ns | 17.3565 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 16.7374 ns | 0.1064 ns | 0.0995 ns | 16.6929 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 16.8339 ns | 0.0360 ns | 0.0337 ns | 16.8287 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 12.0961 ns | 0.2551 ns | 0.2386 ns | 11.9981 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 16.9452 ns | 0.0183 ns | 0.0163 ns | 16.9417 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 16.9181 ns | 0.0285 ns | 0.0267 ns | 16.9211 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 16.8930 ns | 0.0288 ns | 0.0269 ns | 16.8899 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 17.2865 ns | 0.0220 ns | 0.0206 ns | 17.2905 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 12.3338 ns | 0.2274 ns | 0.2127 ns | 12.5109 ns |  0.73 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 17.7656 ns | 0.0136 ns | 0.0127 ns | 17.7634 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 17.3165 ns | 0.0221 ns | 0.0207 ns | 17.3213 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 17.5540 ns | 0.0293 ns | 0.0274 ns | 17.5560 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 17.4304 ns | 0.0188 ns | 0.0175 ns | 17.4367 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 12.1419 ns | 0.2296 ns | 0.2148 ns | 12.2728 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 | 16.8571 ns | 0.0299 ns | 0.0280 ns | 16.8558 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 17.5436 ns | 0.0170 ns | 0.0142 ns | 17.5431 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 18.6578 ns | 0.0312 ns | 0.0291 ns | 18.6609 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 18.4266 ns | 0.0143 ns | 0.0127 ns | 18.4259 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 13.1218 ns | 0.2203 ns | 0.2061 ns | 13.1892 ns |  0.70 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 18.5005 ns | 0.0224 ns | 0.0210 ns | 18.5045 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 18.4528 ns | 0.0258 ns | 0.0228 ns | 18.4519 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 16.8456 ns | 0.0173 ns | 0.0162 ns | 16.8476 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 17.0644 ns | 0.0293 ns | 0.0274 ns | 17.0566 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 11.7703 ns | 0.1043 ns | 0.0976 ns | 11.8110 ns |  0.70 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 17.0842 ns | 0.0251 ns | 0.0223 ns | 17.0771 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 27.2287 ns | 0.0306 ns | 0.0286 ns | 27.2320 ns |  1.62 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 17.5658 ns | 0.0297 ns | 0.0278 ns | 17.5639 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 18.2494 ns | 0.0216 ns | 0.0180 ns | 18.2519 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 12.3406 ns | 0.1220 ns | 0.1141 ns | 12.2759 ns |  0.70 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 18.9467 ns | 0.0245 ns | 0.0229 ns | 18.9412 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 18.4995 ns | 0.0200 ns | 0.0187 ns | 18.4925 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 32.7505 ns | 0.0877 ns | 0.0821 ns | 32.7825 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 33.1945 ns | 0.1350 ns | 0.1263 ns | 33.1341 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 15.9710 ns | 0.1330 ns | 0.1245 ns | 15.8950 ns |  0.49 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 33.2009 ns | 0.0517 ns | 0.0483 ns | 33.2113 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 33.1551 ns | 0.0636 ns | 0.0564 ns | 33.1351 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 33.1801 ns | 0.0606 ns | 0.0538 ns | 33.1826 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 32.7865 ns | 0.1258 ns | 0.1176 ns | 32.7279 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 15.8768 ns | 0.1082 ns | 0.1012 ns | 15.9252 ns |  0.48 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 33.1292 ns | 0.0770 ns | 0.0643 ns | 33.1226 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 33.1299 ns | 0.0762 ns | 0.0675 ns | 33.1121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 63.9883 ns | 0.0867 ns | 0.0811 ns | 64.0168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 63.9324 ns | 0.1356 ns | 0.1268 ns | 63.8932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 16.7770 ns | 0.1333 ns | 0.1247 ns | 16.8567 ns |  0.26 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 64.5053 ns | 0.1036 ns | 0.0969 ns | 64.4788 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 64.4429 ns | 0.1169 ns | 0.1037 ns | 64.4471 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 64.2538 ns | 0.0874 ns | 0.0818 ns | 64.2381 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 65.4479 ns | 0.0577 ns | 0.0540 ns | 65.4353 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 17.5819 ns | 0.2004 ns | 0.1875 ns | 17.5526 ns |  0.27 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 73.0513 ns | 0.0926 ns | 0.0866 ns | 73.0811 ns |  1.14 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 65.4802 ns | 0.0956 ns | 0.0848 ns | 65.5130 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  5.5800 ns | 0.0078 ns | 0.0073 ns |  5.5793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  5.5746 ns | 0.0114 ns | 0.0107 ns |  5.5764 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.7945 ns | 0.0629 ns | 0.0588 ns |  5.8102 ns |  1.04 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  5.7970 ns | 0.0182 ns | 0.0161 ns |  5.7953 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  5.6196 ns | 0.0094 ns | 0.0088 ns |  5.6178 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  1.5398 ns | 0.0060 ns | 0.0056 ns |  1.5409 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  1.3625 ns | 0.0038 ns | 0.0034 ns |  1.3630 ns |  0.88 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  1.4135 ns | 0.0040 ns | 0.0038 ns |  1.4141 ns |  0.92 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  1.3900 ns | 0.0029 ns | 0.0024 ns |  1.3897 ns |  0.90 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  1.3451 ns | 0.0040 ns | 0.0036 ns |  1.3444 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9249 ns | 0.0025 ns | 0.0023 ns |  0.9244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7211 ns | 0.0035 ns | 0.0031 ns |  0.7216 ns |  0.78 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.9378 ns | 0.0035 ns | 0.0032 ns |  0.9382 ns |  1.01 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9552 ns | 0.0038 ns | 0.0036 ns |  0.9550 ns |  1.03 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9565 ns | 0.0036 ns | 0.0034 ns |  0.9561 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4413 ns | 0.0050 ns | 0.0046 ns |  1.4401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6494 ns | 0.0181 ns | 0.0169 ns |  1.6591 ns |  1.14 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5538 ns | 0.0081 ns | 0.0068 ns |  1.5522 ns |  1.08 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6547 ns | 0.0034 ns | 0.0032 ns |  1.6544 ns |  1.15 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6307 ns | 0.0048 ns | 0.0045 ns |  1.6317 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 18.7898 ns | 0.0425 ns | 0.0397 ns | 18.7879 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 20.9050 ns | 0.0265 ns | 0.0235 ns | 20.9024 ns |  1.11 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 23.1828 ns | 0.0337 ns | 0.0315 ns | 23.1877 ns |  1.23 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 22.6226 ns | 0.0306 ns | 0.0287 ns | 22.6276 ns |  1.20 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 22.7967 ns | 0.0236 ns | 0.0221 ns | 22.7909 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 76.4036 ns | 0.1059 ns | 0.0827 ns | 76.3932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 70.6910 ns | 0.0770 ns | 0.0683 ns | 70.6815 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 47.4207 ns | 0.0439 ns | 0.0366 ns | 47.4280 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 78.1834 ns | 0.1168 ns | 0.1035 ns | 78.1944 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 78.1867 ns | 0.0944 ns | 0.0883 ns | 78.1744 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 17.3365 ns | 0.0209 ns | 0.0196 ns | 17.3360 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 17.1890 ns | 0.0148 ns | 0.0138 ns | 17.1842 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 12.0964 ns | 0.2624 ns | 0.2455 ns | 12.2727 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 | 17.0766 ns | 0.0293 ns | 0.0260 ns | 17.0823 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 17.0855 ns | 0.0189 ns | 0.0168 ns | 17.0881 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 16.8707 ns | 0.0241 ns | 0.0213 ns | 16.8712 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 18.5142 ns | 0.1180 ns | 0.1104 ns | 18.5810 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 11.9129 ns | 0.1189 ns | 0.1112 ns | 11.8488 ns |  0.71 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 18.6140 ns | 0.0184 ns | 0.0163 ns | 18.6090 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 17.5513 ns | 0.0248 ns | 0.0232 ns | 17.5512 ns |  1.04 |    0.00 |     - |     - |     - |         - |
