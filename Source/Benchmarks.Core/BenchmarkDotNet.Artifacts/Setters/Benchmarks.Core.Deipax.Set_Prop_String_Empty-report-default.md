
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |   3.463 ns | 0.0089 ns | 0.0083 ns |   3.463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   3.675 ns | 0.0083 ns | 0.0078 ns |   3.677 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   3.504 ns | 0.0129 ns | 0.0120 ns |   3.507 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             FromBool |        net461 |   3.657 ns | 0.0184 ns | 0.0163 ns |   3.649 ns |  1.06 |    0.01 |      - |     - |     - |         - |
             FromBool |        net472 |   3.640 ns | 0.0089 ns | 0.0079 ns |   3.643 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   2.217 ns | 0.0069 ns | 0.0064 ns |   2.217 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   2.102 ns | 0.0034 ns | 0.0032 ns |   2.102 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   2.061 ns | 0.0160 ns | 0.0150 ns |   2.055 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net461 |   2.052 ns | 0.0168 ns | 0.0149 ns |   2.056 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net472 |   2.113 ns | 0.0218 ns | 0.0204 ns |   2.112 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 |   5.014 ns | 0.0148 ns | 0.0124 ns |   5.020 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 2.2 |   5.542 ns | 0.0244 ns | 0.0228 ns |   5.536 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromChar | .NET Core 3.0 |   4.393 ns | 0.0271 ns | 0.0254 ns |   4.380 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 |   6.855 ns | 0.0590 ns | 0.0523 ns |   6.857 ns |  1.37 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromChar |        net472 |   6.651 ns | 0.0143 ns | 0.0134 ns |   6.652 ns |  1.33 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 |   2.353 ns | 0.0034 ns | 0.0032 ns |   2.353 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |   2.402 ns | 0.0036 ns | 0.0030 ns |   2.403 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |   2.013 ns | 0.0032 ns | 0.0030 ns |   2.013 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net461 |   2.078 ns | 0.0123 ns | 0.0115 ns |   2.079 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net472 |   2.058 ns | 0.0165 ns | 0.0154 ns |   2.053 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 |  29.679 ns | 0.0607 ns | 0.0538 ns |  29.670 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 2.2 |  17.928 ns | 0.0225 ns | 0.0210 ns |  17.918 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromSByte | .NET Core 3.0 |  14.090 ns | 0.0166 ns | 0.0147 ns |  14.092 ns |  0.47 |    0.00 |      - |     - |     - |         - |
            FromSByte |        net461 |  33.121 ns | 0.1925 ns | 0.1706 ns |  33.084 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromSByte |        net472 |  33.263 ns | 0.1235 ns | 0.1156 ns |  33.223 ns |  1.12 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 |   2.137 ns | 0.0076 ns | 0.0071 ns |   2.138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |   2.206 ns | 0.0039 ns | 0.0034 ns |   2.206 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |   1.953 ns | 0.0050 ns | 0.0047 ns |   1.954 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net461 |   2.203 ns | 0.0138 ns | 0.0129 ns |   2.200 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable |        net472 |   2.167 ns | 0.0087 ns | 0.0081 ns |   2.167 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 |  29.417 ns | 0.0417 ns | 0.0390 ns |  29.435 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 2.2 |  18.083 ns | 0.0269 ns | 0.0252 ns |  18.079 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromByte | .NET Core 3.0 |  13.292 ns | 0.2852 ns | 0.2668 ns |  13.081 ns |  0.45 |    0.01 |      - |     - |     - |         - |
             FromByte |        net461 |  33.814 ns | 0.2259 ns | 0.1886 ns |  33.869 ns |  1.15 |    0.01 | 0.0051 |     - |     - |      32 B |
             FromByte |        net472 |  34.059 ns | 0.2805 ns | 0.2624 ns |  34.017 ns |  1.16 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 |   2.332 ns | 0.0054 ns | 0.0048 ns |   2.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |   2.358 ns | 0.0059 ns | 0.0055 ns |   2.357 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |   2.017 ns | 0.0077 ns | 0.0064 ns |   2.017 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net461 |   2.571 ns | 0.0786 ns | 0.0735 ns |   2.548 ns |  1.10 |    0.03 |      - |     - |     - |         - |
     FromByteNullable |        net472 |   2.743 ns | 0.0068 ns | 0.0061 ns |   2.744 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 |  29.716 ns | 0.2257 ns | 0.2000 ns |  29.779 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 2.2 |  18.192 ns | 0.0769 ns | 0.0682 ns |  18.210 ns |  0.61 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromShort | .NET Core 3.0 |  13.264 ns | 0.0248 ns | 0.0220 ns |  13.262 ns |  0.45 |    0.00 |      - |     - |     - |         - |
            FromShort |        net461 |  33.572 ns | 0.1944 ns | 0.1818 ns |  33.509 ns |  1.13 |    0.01 | 0.0051 |     - |     - |      32 B |
            FromShort |        net472 |  33.374 ns | 0.3000 ns | 0.2806 ns |  33.312 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 |   2.087 ns | 0.0060 ns | 0.0056 ns |   2.087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |   2.249 ns | 0.0048 ns | 0.0040 ns |   2.251 ns |  1.08 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |   2.212 ns | 0.0035 ns | 0.0033 ns |   2.214 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    FromShortNullable |        net461 |   2.200 ns | 0.0103 ns | 0.0081 ns |   2.201 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net472 |   2.394 ns | 0.0196 ns | 0.0183 ns |   2.402 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 |  26.524 ns | 0.0315 ns | 0.0294 ns |  26.516 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 2.2 |  17.864 ns | 0.0325 ns | 0.0271 ns |  17.865 ns |  0.67 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromUShort | .NET Core 3.0 |  13.111 ns | 0.0220 ns | 0.0184 ns |  13.116 ns |  0.49 |    0.00 |      - |     - |     - |         - |
           FromUShort |        net461 |  32.562 ns | 0.3061 ns | 0.2863 ns |  32.430 ns |  1.23 |    0.01 | 0.0051 |     - |     - |      32 B |
           FromUShort |        net472 |  31.748 ns | 0.0479 ns | 0.0425 ns |  31.752 ns |  1.20 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 |   2.329 ns | 0.0067 ns | 0.0062 ns |   2.330 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |   2.070 ns | 0.0048 ns | 0.0045 ns |   2.070 ns |  0.89 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |   2.179 ns | 0.0035 ns | 0.0032 ns |   2.178 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net461 |   2.574 ns | 0.0126 ns | 0.0117 ns |   2.572 ns |  1.11 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable |        net472 |   2.543 ns | 0.0069 ns | 0.0061 ns |   2.544 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 |  29.279 ns | 0.0394 ns | 0.0369 ns |  29.277 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 2.2 |  18.143 ns | 0.0553 ns | 0.0491 ns |  18.150 ns |  0.62 |    0.00 | 0.0051 |     - |     - |      32 B |
              FromInt | .NET Core 3.0 |  12.795 ns | 0.0207 ns | 0.0173 ns |  12.797 ns |  0.44 |    0.00 |      - |     - |     - |         - |
              FromInt |        net461 |  33.336 ns | 0.6690 ns | 0.7159 ns |  32.982 ns |  1.14 |    0.03 | 0.0051 |     - |     - |      32 B |
              FromInt |        net472 |  32.291 ns | 0.1852 ns | 0.1733 ns |  32.387 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 |   2.086 ns | 0.0039 ns | 0.0037 ns |   2.086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |   2.320 ns | 0.0052 ns | 0.0049 ns |   2.320 ns |  1.11 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |   2.189 ns | 0.0183 ns | 0.0172 ns |   2.182 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      FromIntNullable |        net461 |   1.981 ns | 0.0057 ns | 0.0054 ns |   1.981 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net472 |   2.323 ns | 0.0068 ns | 0.0057 ns |   2.322 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 |  26.700 ns | 0.0515 ns | 0.0482 ns |  26.711 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 2.2 |  17.702 ns | 0.0226 ns | 0.0212 ns |  17.705 ns |  0.66 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt | .NET Core 3.0 |  12.402 ns | 0.0391 ns | 0.0366 ns |  12.399 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             FromUInt |        net461 |  31.118 ns | 0.0409 ns | 0.0363 ns |  31.121 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromUInt |        net472 |  32.314 ns | 0.1872 ns | 0.1660 ns |  32.339 ns |  1.21 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 |   2.538 ns | 0.0062 ns | 0.0052 ns |   2.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |   2.084 ns | 0.0187 ns | 0.0175 ns |   2.093 ns |  0.82 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |   2.465 ns | 0.0084 ns | 0.0070 ns |   2.465 ns |  0.97 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable |        net461 |   2.343 ns | 0.0214 ns | 0.0200 ns |   2.335 ns |  0.92 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net472 |   2.328 ns | 0.0092 ns | 0.0081 ns |   2.329 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 |  31.832 ns | 0.0293 ns | 0.0245 ns |  31.831 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 2.2 |  19.281 ns | 0.0247 ns | 0.0231 ns |  19.288 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong | .NET Core 3.0 |  12.973 ns | 0.0172 ns | 0.0152 ns |  12.973 ns |  0.41 |    0.00 |      - |     - |     - |         - |
             FromLong |        net461 |  33.306 ns | 0.0466 ns | 0.0390 ns |  33.314 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
             FromLong |        net472 |  34.915 ns | 0.0685 ns | 0.0572 ns |  34.905 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 |   2.802 ns | 0.0078 ns | 0.0073 ns |   2.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |   2.768 ns | 0.0058 ns | 0.0054 ns |   2.768 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |   2.779 ns | 0.0057 ns | 0.0053 ns |   2.780 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net461 |   2.545 ns | 0.0126 ns | 0.0112 ns |   2.547 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net472 |   2.538 ns | 0.0164 ns | 0.0153 ns |   2.544 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 |  30.902 ns | 0.0369 ns | 0.0345 ns |  30.895 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 2.2 |  20.070 ns | 0.1021 ns | 0.0955 ns |  20.109 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong | .NET Core 3.0 |  12.615 ns | 0.0199 ns | 0.0166 ns |  12.610 ns |  0.41 |    0.00 |      - |     - |     - |         - |
            FromULong |        net461 |  32.219 ns | 0.0588 ns | 0.0521 ns |  32.223 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromULong |        net472 |  32.869 ns | 0.0580 ns | 0.0514 ns |  32.862 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 |   2.897 ns | 0.0220 ns | 0.0205 ns |   2.887 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |   2.552 ns | 0.0040 ns | 0.0037 ns |   2.551 ns |  0.88 |    0.01 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |   2.561 ns | 0.0167 ns | 0.0156 ns |   2.565 ns |  0.88 |    0.01 |      - |     - |     - |         - |
    FromULongNullable |        net461 |   2.531 ns | 0.0083 ns | 0.0078 ns |   2.530 ns |  0.87 |    0.01 |      - |     - |     - |         - |
    FromULongNullable |        net472 |   2.546 ns | 0.0171 ns | 0.0160 ns |   2.542 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 |  96.959 ns | 0.1671 ns | 0.1481 ns |  96.973 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat | .NET Core 2.2 |  41.701 ns | 0.0841 ns | 0.0786 ns |  41.710 ns |  0.43 |    0.00 | 0.0051 |     - |     - |      32 B |
            FromFloat | .NET Core 3.0 |  52.848 ns | 1.0938 ns | 1.4972 ns |  52.155 ns |  0.55 |    0.02 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 |  97.215 ns | 0.2670 ns | 0.2367 ns |  97.237 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
            FromFloat |        net472 |  98.469 ns | 1.7236 ns | 1.6122 ns |  99.474 ns |  1.01 |    0.02 | 0.0050 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 |   2.310 ns | 0.0036 ns | 0.0034 ns |   2.311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |   2.250 ns | 0.0063 ns | 0.0059 ns |   2.251 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |   2.937 ns | 0.0814 ns | 0.0938 ns |   2.957 ns |  1.27 |    0.05 |      - |     - |     - |         - |
    FromFloatNullable |        net461 |   2.086 ns | 0.0060 ns | 0.0056 ns |   2.085 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net472 |   2.079 ns | 0.0041 ns | 0.0039 ns |   2.079 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 106.826 ns | 0.1571 ns | 0.1393 ns | 106.823 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble | .NET Core 2.2 |  41.394 ns | 0.0526 ns | 0.0492 ns |  41.407 ns |  0.39 |    0.00 | 0.0051 |     - |     - |      32 B |
           FromDouble | .NET Core 3.0 |  52.330 ns | 1.0148 ns | 1.0858 ns |  52.287 ns |  0.49 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 103.229 ns | 0.1346 ns | 0.1259 ns | 103.235 ns |  0.97 |    0.00 | 0.0050 |     - |     - |      32 B |
           FromDouble |        net472 | 102.675 ns | 0.1305 ns | 0.1090 ns | 102.662 ns |  0.96 |    0.00 | 0.0050 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |   2.875 ns | 0.0054 ns | 0.0050 ns |   2.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |   2.890 ns | 0.0041 ns | 0.0037 ns |   2.890 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |   2.526 ns | 0.0311 ns | 0.0291 ns |   2.535 ns |  0.88 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net461 |   2.746 ns | 0.0239 ns | 0.0212 ns |   2.743 ns |  0.96 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net472 |   2.591 ns | 0.0152 ns | 0.0142 ns |   2.593 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 |  53.573 ns | 0.0671 ns | 0.0628 ns |  53.550 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 |  46.593 ns | 0.0484 ns | 0.0429 ns |  46.599 ns |  0.87 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 |  46.641 ns | 0.3402 ns | 0.3183 ns |  46.576 ns |  0.87 |    0.01 | 0.0038 |     - |     - |      24 B |
          FromDecimal |        net461 |  49.817 ns | 0.5656 ns | 0.5290 ns |  49.866 ns |  0.93 |    0.01 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 |  49.577 ns | 0.2202 ns | 0.2059 ns |  49.599 ns |  0.93 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  11.391 ns | 0.0161 ns | 0.0142 ns |  11.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |   9.071 ns | 0.0155 ns | 0.0145 ns |   9.073 ns |  0.80 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |   9.846 ns | 0.1141 ns | 0.1067 ns |   9.848 ns |  0.87 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable |        net461 |   9.110 ns | 0.0503 ns | 0.0470 ns |   9.104 ns |  0.80 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable |        net472 |   9.072 ns | 0.0142 ns | 0.0126 ns |   9.069 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 323.632 ns | 0.4969 ns | 0.4648 ns | 323.657 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 2.2 | 273.740 ns | 0.8408 ns | 0.7021 ns | 273.416 ns |  0.85 |    0.00 | 0.0262 |     - |     - |     168 B |
         FromDateTime | .NET Core 3.0 | 225.925 ns | 1.9935 ns | 1.7672 ns | 225.996 ns |  0.70 |    0.01 | 0.0100 |     - |     - |      64 B |
         FromDateTime |        net461 | 325.231 ns | 2.5137 ns | 2.3513 ns | 324.877 ns |  1.00 |    0.01 | 0.0300 |     - |     - |     192 B |
         FromDateTime |        net472 | 320.787 ns | 0.4068 ns | 0.3805 ns | 320.726 ns |  0.99 |    0.00 | 0.0300 |     - |     - |     192 B |
                      |               |            |           |           |            |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   2.787 ns | 0.0057 ns | 0.0051 ns |   2.786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   2.656 ns | 0.0118 ns | 0.0098 ns |   2.652 ns |  0.95 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   2.964 ns | 0.0236 ns | 0.0209 ns |   2.956 ns |  1.06 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   3.440 ns | 0.0107 ns | 0.0100 ns |   3.438 ns |  1.23 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   3.095 ns | 0.0204 ns | 0.0191 ns |   3.101 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 |   2.648 ns | 0.0053 ns | 0.0049 ns |   2.648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 |   2.199 ns | 0.0067 ns | 0.0062 ns |   2.200 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 |   2.107 ns | 0.0123 ns | 0.0115 ns |   2.103 ns |  0.80 |    0.00 |      - |     - |     - |         - |
           FromObject |        net461 |   2.794 ns | 0.0210 ns | 0.0186 ns |   2.789 ns |  1.06 |    0.01 |      - |     - |     - |         - |
           FromObject |        net472 |   2.807 ns | 0.0262 ns | 0.0219 ns |   2.801 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
           FromString | .NET Core 2.0 |   1.846 ns | 0.0030 ns | 0.0028 ns |   1.845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 |   1.856 ns | 0.0023 ns | 0.0020 ns |   1.857 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 |   1.801 ns | 0.0144 ns | 0.0127 ns |   1.802 ns |  0.98 |    0.01 |      - |     - |     - |         - |
           FromString |        net461 |   1.815 ns | 0.0171 ns | 0.0151 ns |   1.807 ns |  0.98 |    0.01 |      - |     - |     - |         - |
           FromString |        net472 |   1.815 ns | 0.0032 ns | 0.0027 ns |   1.815 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 |  20.974 ns | 0.0274 ns | 0.0229 ns |  20.977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  21.391 ns | 0.0263 ns | 0.0246 ns |  21.386 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  17.154 ns | 0.3004 ns | 0.2810 ns |  17.063 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             FromEnum |        net461 |  23.540 ns | 0.1231 ns | 0.1092 ns |  23.510 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             FromEnum |        net472 |  23.278 ns | 0.0370 ns | 0.0328 ns |  23.274 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                      |               |            |           |           |            |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 |   2.349 ns | 0.0042 ns | 0.0037 ns |   2.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |   2.219 ns | 0.0060 ns | 0.0056 ns |   2.220 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |   2.514 ns | 0.0220 ns | 0.0206 ns |   2.513 ns |  1.07 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable |        net461 |   1.999 ns | 0.0200 ns | 0.0187 ns |   1.991 ns |  0.85 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable |        net472 |   2.191 ns | 0.0078 ns | 0.0069 ns |   2.189 ns |  0.93 |    0.00 |      - |     - |     - |         - |
