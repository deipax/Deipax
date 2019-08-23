
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
             FromBool | .NET Core 2.0 |  0.6553 ns | 0.0160 ns | 0.0149 ns |  0.6466 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9022 ns | 0.0037 ns | 0.0031 ns |  0.9019 ns |  1.38 |    0.03 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9607 ns | 0.0142 ns | 0.0133 ns |  0.9659 ns |  1.47 |    0.03 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9014 ns | 0.0148 ns | 0.0138 ns |  0.9027 ns |  1.38 |    0.04 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9022 ns | 0.0150 ns | 0.0140 ns |  0.9064 ns |  1.38 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3945 ns | 0.0237 ns | 0.0221 ns |  1.3894 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1804 ns | 0.0062 ns | 0.0058 ns |  1.1799 ns |  0.85 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.0919 ns | 0.0142 ns | 0.0133 ns |  1.0879 ns |  0.78 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6704 ns | 0.0146 ns | 0.0137 ns |  1.6680 ns |  1.20 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6341 ns | 0.0190 ns | 0.0178 ns |  1.6260 ns |  1.17 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.1890 ns | 0.1320 ns | 0.1296 ns |  1.1333 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.0693 ns | 0.0051 ns | 0.0043 ns |  1.0710 ns |  0.90 |    0.09 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6440 ns | 0.0105 ns | 0.0098 ns |  0.6478 ns |  0.54 |    0.05 |     - |     - |     - |         - |
             FromChar |        net461 |  1.5992 ns | 0.0291 ns | 0.0272 ns |  1.5937 ns |  1.35 |    0.14 |     - |     - |     - |         - |
             FromChar |        net472 |  2.2989 ns | 0.0285 ns | 0.0267 ns |  2.2790 ns |  1.95 |    0.19 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.6439 ns | 0.0440 ns | 0.0390 ns |  1.6351 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.6414 ns | 0.0387 ns | 0.0323 ns |  1.6535 ns |  1.00 |    0.03 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1076 ns | 0.0177 ns | 0.0157 ns |  1.1065 ns |  0.67 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.1234 ns | 0.0219 ns | 0.0205 ns |  2.1307 ns |  1.29 |    0.04 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.1680 ns | 0.0188 ns | 0.0175 ns |  2.1650 ns |  1.32 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.4783 ns | 0.0292 ns | 0.0258 ns |  0.4775 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.4384 ns | 0.0054 ns | 0.0048 ns |  0.4377 ns |  0.92 |    0.05 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6610 ns | 0.0111 ns | 0.0104 ns |  0.6601 ns |  1.39 |    0.08 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.4360 ns | 0.0081 ns | 0.0076 ns |  0.4371 ns |  0.91 |    0.04 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.4364 ns | 0.0169 ns | 0.0158 ns |  0.4320 ns |  0.92 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.8784 ns | 0.0191 ns | 0.0160 ns |  1.8730 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.6790 ns | 0.0034 ns | 0.0028 ns |  0.6792 ns |  0.36 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.8688 ns | 0.0150 ns | 0.0133 ns |  0.8629 ns |  0.46 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.6432 ns | 0.0143 ns | 0.0127 ns |  1.6442 ns |  0.88 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.3057 ns | 0.0196 ns | 0.0183 ns |  2.2963 ns |  1.23 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.4032 ns | 0.0016 ns | 0.0013 ns |  0.4026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4350 ns | 0.0067 ns | 0.0056 ns |  0.4343 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.4595 ns | 0.0117 ns | 0.0104 ns |  0.4577 ns |  1.14 |    0.03 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4390 ns | 0.0106 ns | 0.0100 ns |  0.4321 ns |  1.09 |    0.03 |     - |     - |     - |         - |
             FromByte |        net472 |  0.4469 ns | 0.0125 ns | 0.0117 ns |  0.4474 ns |  1.11 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9166 ns | 0.0365 ns | 0.0324 ns |  0.9132 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.6930 ns | 0.0167 ns | 0.0140 ns |  0.6939 ns |  0.76 |    0.03 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.8599 ns | 0.0151 ns | 0.0142 ns |  0.8634 ns |  0.94 |    0.04 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6582 ns | 0.0181 ns | 0.0169 ns |  1.6557 ns |  1.81 |    0.07 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6623 ns | 0.0144 ns | 0.0134 ns |  1.6700 ns |  1.82 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.4227 ns | 0.0132 ns | 0.0124 ns |  0.4210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.4422 ns | 0.0200 ns | 0.0167 ns |  0.4471 ns |  1.05 |    0.05 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.4849 ns | 0.0117 ns | 0.0104 ns |  0.4885 ns |  1.15 |    0.05 |     - |     - |     - |         - |
            FromShort |        net461 |  0.4378 ns | 0.0104 ns | 0.0098 ns |  0.4423 ns |  1.04 |    0.04 |     - |     - |     - |         - |
            FromShort |        net472 |  0.4436 ns | 0.0085 ns | 0.0079 ns |  0.4449 ns |  1.05 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.0017 ns | 0.0169 ns | 0.0158 ns |  0.9930 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.9192 ns | 0.0108 ns | 0.0101 ns |  0.9159 ns |  0.92 |    0.02 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.8960 ns | 0.0125 ns | 0.0117 ns |  0.8982 ns |  0.89 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.3877 ns | 0.0244 ns | 0.0228 ns |  1.3845 ns |  1.39 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.3908 ns | 0.0126 ns | 0.0112 ns |  1.3894 ns |  1.39 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.1466 ns | 0.0391 ns | 0.0366 ns |  1.1595 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.1111 ns | 0.0489 ns | 0.0458 ns |  1.0973 ns |  0.97 |    0.06 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6391 ns | 0.0156 ns | 0.0146 ns |  0.6313 ns |  0.56 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.5875 ns | 0.0172 ns | 0.0161 ns |  1.5948 ns |  1.39 |    0.05 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.5979 ns | 0.0145 ns | 0.0136 ns |  1.5994 ns |  1.39 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.5941 ns | 0.0076 ns | 0.0063 ns |  1.5935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.6096 ns | 0.0121 ns | 0.0113 ns |  1.6076 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9207 ns | 0.0140 ns | 0.0131 ns |  0.9271 ns |  0.58 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.1151 ns | 0.0189 ns | 0.0176 ns |  2.1104 ns |  1.33 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.2642 ns | 0.0206 ns | 0.0193 ns |  2.2680 ns |  1.42 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.6103 ns | 0.0207 ns | 0.0194 ns |  1.6040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.5847 ns | 0.0106 ns | 0.0099 ns |  1.5834 ns |  0.98 |    0.02 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.4690 ns | 0.0140 ns | 0.0131 ns |  1.4714 ns |  0.91 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.6379 ns | 0.0134 ns | 0.0125 ns |  1.6364 ns |  1.02 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6516 ns | 0.0159 ns | 0.0149 ns |  1.6569 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.1584 ns | 0.0191 ns | 0.0169 ns |  2.1507 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.0118 ns | 0.0104 ns | 0.0098 ns |  2.0071 ns |  0.93 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.9823 ns | 0.0209 ns | 0.0175 ns |  1.9915 ns |  0.92 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.1799 ns | 0.0250 ns | 0.0234 ns |  2.1809 ns |  1.01 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.1578 ns | 0.0213 ns | 0.0200 ns |  2.1601 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.5361 ns | 0.0203 ns | 0.0180 ns |  1.5334 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.7342 ns | 0.0206 ns | 0.0192 ns |  1.7340 ns |  1.13 |    0.02 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  1.4814 ns | 0.0189 ns | 0.0176 ns |  1.4877 ns |  0.96 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.6746 ns | 0.0291 ns | 0.0273 ns |  1.6804 ns |  1.09 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.5267 ns | 0.0235 ns | 0.0219 ns |  1.5265 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.9998 ns | 0.0063 ns | 0.0053 ns |  1.9978 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  2.5003 ns | 0.0223 ns | 0.0198 ns |  2.5013 ns |  1.25 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  2.1144 ns | 0.0458 ns | 0.0428 ns |  2.1034 ns |  1.06 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.3263 ns | 0.0206 ns | 0.0193 ns |  2.3217 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.3544 ns | 0.0281 ns | 0.0262 ns |  2.3547 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.5809 ns | 0.0250 ns | 0.0208 ns |  1.5847 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8754 ns | 0.0240 ns | 0.0225 ns |  1.8673 ns |  1.19 |    0.02 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7653 ns | 0.0193 ns | 0.0180 ns |  1.7675 ns |  1.12 |    0.02 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6608 ns | 0.0208 ns | 0.0195 ns |  1.6646 ns |  1.05 |    0.02 |     - |     - |     - |         - |
             FromLong |        net472 |  1.6834 ns | 0.0192 ns | 0.0179 ns |  1.6861 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.6573 ns | 0.0083 ns | 0.0070 ns |  2.6565 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.1320 ns | 0.0372 ns | 0.0310 ns |  3.1260 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.0226 ns | 0.0285 ns | 0.0266 ns |  3.0091 ns |  1.14 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.1809 ns | 0.0276 ns | 0.0258 ns |  3.1703 ns |  1.20 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.1869 ns | 0.0233 ns | 0.0218 ns |  3.1823 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.6012 ns | 0.0171 ns | 0.0143 ns |  1.6024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7566 ns | 0.0088 ns | 0.0074 ns |  1.7593 ns |  1.10 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.5458 ns | 0.0170 ns | 0.0159 ns |  1.5447 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6216 ns | 0.0177 ns | 0.0166 ns |  1.6216 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6287 ns | 0.0141 ns | 0.0131 ns |  1.6345 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.9248 ns | 0.0283 ns | 0.0265 ns |  2.9277 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.5670 ns | 0.0089 ns | 0.0079 ns |  2.5662 ns |  0.88 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.6162 ns | 0.0266 ns | 0.0222 ns |  2.6170 ns |  0.90 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0288 ns | 0.0278 ns | 0.0260 ns |  3.0394 ns |  1.04 |    0.02 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0396 ns | 0.0336 ns | 0.0315 ns |  3.0324 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.7796 ns | 0.0316 ns | 0.0264 ns |  3.7918 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.8384 ns | 0.0154 ns | 0.0144 ns |  3.8317 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.7734 ns | 0.0381 ns | 0.0357 ns |  3.7635 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.0193 ns | 0.0305 ns | 0.0285 ns |  4.0216 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.0432 ns | 0.0290 ns | 0.0271 ns |  4.0562 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.3447 ns | 0.0057 ns | 0.0048 ns |  4.3456 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.2107 ns | 0.0232 ns | 0.0206 ns |  4.2039 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.1147 ns | 0.0328 ns | 0.0307 ns |  4.1248 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.2553 ns | 0.0370 ns | 0.0346 ns |  4.2416 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.2004 ns | 0.0307 ns | 0.0287 ns |  4.2126 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.7573 ns | 0.0259 ns | 0.0229 ns |  3.7509 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.5871 ns | 0.0137 ns | 0.0129 ns |  3.5825 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.5947 ns | 0.0276 ns | 0.0258 ns |  3.6050 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2896 ns | 0.0360 ns | 0.0337 ns |  3.2779 ns |  0.87 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.3274 ns | 0.0482 ns | 0.0451 ns |  3.3123 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.4315 ns | 0.0107 ns | 0.0084 ns |  5.4297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.9954 ns | 0.0286 ns | 0.0267 ns |  4.9828 ns |  0.92 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  5.9248 ns | 0.1459 ns | 0.1433 ns |  5.9565 ns |  1.09 |    0.03 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.8681 ns | 0.0428 ns | 0.0401 ns |  4.8647 ns |  0.89 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.8650 ns | 0.0319 ns | 0.0299 ns |  4.8720 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.6225 ns | 0.0421 ns | 0.0328 ns | 13.6179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.8497 ns | 0.0683 ns | 0.0570 ns | 13.8504 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.6224 ns | 0.0407 ns | 0.0381 ns |  6.6046 ns |  0.49 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.1757 ns | 0.0757 ns | 0.0708 ns | 14.1658 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.1096 ns | 0.1114 ns | 0.1042 ns | 14.1420 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.8558 ns | 0.0377 ns | 0.0334 ns | 24.8440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.3808 ns | 0.1351 ns | 0.1198 ns | 24.3840 ns |  0.98 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.0861 ns | 0.0993 ns | 0.0929 ns | 13.0955 ns |  0.53 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.6272 ns | 0.1421 ns | 0.1330 ns | 24.5799 ns |  0.99 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.8504 ns | 0.1486 ns | 0.1390 ns | 24.8801 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.4296 ns | 0.0087 ns | 0.0081 ns |  0.4260 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6972 ns | 0.0044 ns | 0.0034 ns |  0.6965 ns |  1.63 |    0.03 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7091 ns | 0.0127 ns | 0.0112 ns |  0.7100 ns |  1.65 |    0.04 |     - |     - |     - |         - |
         FromDateTime |        net461 |  1.2856 ns | 0.0529 ns | 0.1346 ns |  1.3332 ns |  2.80 |    0.44 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7541 ns | 0.0117 ns | 0.0110 ns |  0.7480 ns |  1.76 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4406 ns | 0.0097 ns | 0.0091 ns |  1.4400 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4410 ns | 0.0105 ns | 0.0099 ns |  1.4400 ns |  1.00 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.3658 ns | 0.0131 ns | 0.0116 ns |  1.3678 ns |  0.95 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4787 ns | 0.0147 ns | 0.0137 ns |  1.4863 ns |  1.03 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4944 ns | 0.0285 ns | 0.0267 ns |  1.4883 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2665 ns | 0.0655 ns | 0.0612 ns |  2.2570 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2400 ns | 0.0099 ns | 0.0088 ns |  2.2373 ns |  0.99 |    0.03 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.2862 ns | 0.0710 ns | 0.0697 ns |  2.2695 ns |  1.01 |    0.04 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2555 ns | 0.0228 ns | 0.0213 ns |  2.2610 ns |  1.00 |    0.02 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2907 ns | 0.0206 ns | 0.0192 ns |  2.2847 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.6175 ns | 0.9104 ns | 0.8516 ns | 48.5813 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 41.9024 ns | 0.0795 ns | 0.0705 ns | 41.8993 ns |  0.86 |    0.02 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.5248 ns | 0.0807 ns | 0.0755 ns |  8.5540 ns |  0.18 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.1985 ns | 0.2921 ns | 0.2732 ns | 46.1782 ns |  0.95 |    0.02 |     - |     - |     - |         - |
           FromString |        net472 | 46.4640 ns | 0.3124 ns | 0.2922 ns | 46.5290 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.5840 ns | 0.0069 ns | 0.0061 ns |  1.5826 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.7277 ns | 0.0184 ns | 0.0172 ns |  1.7240 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.5043 ns | 0.0150 ns | 0.0140 ns |  1.5109 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6700 ns | 0.0172 ns | 0.0161 ns |  1.6744 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.6676 ns | 0.0147 ns | 0.0138 ns |  1.6647 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.1052 ns | 0.0259 ns | 0.0230 ns |  2.1006 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.3328 ns | 0.0306 ns | 0.0271 ns |  2.3150 ns |  1.11 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.9000 ns | 0.0212 ns | 0.0198 ns |  1.9060 ns |  0.90 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.3140 ns | 0.0264 ns | 0.0247 ns |  2.3088 ns |  1.10 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.3475 ns | 0.0172 ns | 0.0161 ns |  2.3418 ns |  1.12 |    0.01 |     - |     - |     - |         - |
