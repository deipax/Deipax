
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
             FromBool | .NET Core 2.0 | 10.0593 ns | 0.0601 ns | 0.0562 ns | 10.0749 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 10.2229 ns | 0.0339 ns | 0.0300 ns | 10.2193 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  8.2842 ns | 0.0081 ns | 0.0076 ns |  8.2844 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 | 14.6429 ns | 0.0273 ns | 0.0256 ns | 14.6406 ns |  1.46 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 | 14.7998 ns | 0.0150 ns | 0.0141 ns | 14.7941 ns |  1.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 10.4396 ns | 0.0113 ns | 0.0106 ns | 10.4405 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 10.6071 ns | 0.0126 ns | 0.0111 ns | 10.6074 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  8.7513 ns | 0.0118 ns | 0.0110 ns |  8.7515 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 15.5845 ns | 0.0255 ns | 0.0239 ns | 15.5822 ns |  1.49 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 15.5804 ns | 0.0329 ns | 0.0292 ns | 15.5760 ns |  1.49 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  9.8042 ns | 0.0081 ns | 0.0076 ns |  9.8042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 10.6681 ns | 0.0660 ns | 0.0617 ns | 10.7065 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  8.3297 ns | 0.0344 ns | 0.0322 ns |  8.3183 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 | 14.6504 ns | 0.0288 ns | 0.0225 ns | 14.6500 ns |  1.49 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 | 14.9607 ns | 0.0144 ns | 0.0128 ns | 14.9603 ns |  1.53 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 10.4505 ns | 0.0095 ns | 0.0089 ns | 10.4491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 10.7368 ns | 0.0097 ns | 0.0086 ns | 10.7348 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  8.7595 ns | 0.0101 ns | 0.0094 ns |  8.7643 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 15.6986 ns | 0.0625 ns | 0.0585 ns | 15.6764 ns |  1.50 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 15.6344 ns | 0.0262 ns | 0.0245 ns | 15.6310 ns |  1.50 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  9.9468 ns | 0.0121 ns | 0.0113 ns |  9.9501 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 10.6551 ns | 0.0658 ns | 0.0615 ns | 10.6272 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  8.3474 ns | 0.0197 ns | 0.0174 ns |  8.3433 ns |  0.84 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 14.9958 ns | 0.1001 ns | 0.0936 ns | 15.0414 ns |  1.51 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 14.6767 ns | 0.0224 ns | 0.0210 ns | 14.6725 ns |  1.48 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 10.4275 ns | 0.0383 ns | 0.0358 ns | 10.4125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 10.8157 ns | 0.0143 ns | 0.0134 ns | 10.8166 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  8.7726 ns | 0.0129 ns | 0.0121 ns |  8.7755 ns |  0.84 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 15.5254 ns | 0.0215 ns | 0.0202 ns | 15.5232 ns |  1.49 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 15.5933 ns | 0.0199 ns | 0.0176 ns | 15.5965 ns |  1.50 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 10.0559 ns | 0.0418 ns | 0.0391 ns | 10.0671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 10.6002 ns | 0.0125 ns | 0.0117 ns | 10.6003 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  8.2576 ns | 0.0106 ns | 0.0094 ns |  8.2601 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 14.7237 ns | 0.0295 ns | 0.0261 ns | 14.7240 ns |  1.46 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 | 14.7192 ns | 0.0829 ns | 0.0775 ns | 14.6879 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 10.4136 ns | 0.0126 ns | 0.0118 ns | 10.4126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 10.8126 ns | 0.0186 ns | 0.0145 ns | 10.8168 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  8.7867 ns | 0.0144 ns | 0.0135 ns |  8.7834 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 15.6834 ns | 0.0973 ns | 0.0910 ns | 15.7304 ns |  1.51 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 15.5744 ns | 0.0254 ns | 0.0238 ns | 15.5735 ns |  1.50 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  9.9482 ns | 0.0137 ns | 0.0115 ns |  9.9494 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 10.5873 ns | 0.0123 ns | 0.0115 ns | 10.5887 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  8.3033 ns | 0.0149 ns | 0.0132 ns |  8.3034 ns |  0.83 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 14.9771 ns | 0.2296 ns | 0.2036 ns | 14.9461 ns |  1.51 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 | 14.6372 ns | 0.0184 ns | 0.0172 ns | 14.6389 ns |  1.47 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 10.5091 ns | 0.0647 ns | 0.0605 ns | 10.5360 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 10.8500 ns | 0.0084 ns | 0.0070 ns | 10.8470 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  8.7656 ns | 0.0089 ns | 0.0079 ns |  8.7655 ns |  0.83 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 15.7009 ns | 0.0363 ns | 0.0322 ns | 15.7004 ns |  1.49 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 15.7133 ns | 0.0962 ns | 0.0900 ns | 15.6715 ns |  1.50 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  9.9506 ns | 0.0175 ns | 0.0164 ns |  9.9525 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 10.7133 ns | 0.0543 ns | 0.0508 ns | 10.7330 ns |  1.08 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  8.2814 ns | 0.0189 ns | 0.0168 ns |  8.2806 ns |  0.83 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 | 14.8048 ns | 0.0800 ns | 0.0668 ns | 14.8211 ns |  1.49 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 | 14.6340 ns | 0.0224 ns | 0.0199 ns | 14.6331 ns |  1.47 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 10.4276 ns | 0.0150 ns | 0.0126 ns | 10.4262 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 10.8411 ns | 0.0136 ns | 0.0127 ns | 10.8398 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  8.7652 ns | 0.0090 ns | 0.0085 ns |  8.7639 ns |  0.84 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 15.5789 ns | 0.0168 ns | 0.0157 ns | 15.5848 ns |  1.49 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 15.5984 ns | 0.0232 ns | 0.0217 ns | 15.5949 ns |  1.50 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  9.7844 ns | 0.0090 ns | 0.0084 ns |  9.7835 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 10.5837 ns | 0.0133 ns | 0.0118 ns | 10.5871 ns |  1.08 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  8.1253 ns | 0.0089 ns | 0.0083 ns |  8.1269 ns |  0.83 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 14.7925 ns | 0.0300 ns | 0.0251 ns | 14.7937 ns |  1.51 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 14.9416 ns | 0.0920 ns | 0.0860 ns | 14.9836 ns |  1.53 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 10.1986 ns | 0.0139 ns | 0.0123 ns | 10.1959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 10.8116 ns | 0.0434 ns | 0.0384 ns | 10.8284 ns |  1.06 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  8.5405 ns | 0.0188 ns | 0.0157 ns |  8.5380 ns |  0.84 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 15.8080 ns | 0.0676 ns | 0.0632 ns | 15.8185 ns |  1.55 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 15.6320 ns | 0.0182 ns | 0.0161 ns | 15.6368 ns |  1.53 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  9.9607 ns | 0.0484 ns | 0.0453 ns |  9.9793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 10.4286 ns | 0.0105 ns | 0.0093 ns | 10.4274 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  8.0008 ns | 0.0101 ns | 0.0095 ns |  8.0013 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 | 14.9048 ns | 0.0216 ns | 0.0202 ns | 14.9050 ns |  1.50 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 14.9312 ns | 0.0230 ns | 0.0215 ns | 14.9250 ns |  1.50 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 10.4624 ns | 0.0931 ns | 0.0871 ns | 10.4172 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 10.6837 ns | 0.0115 ns | 0.0090 ns | 10.6839 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  8.4328 ns | 0.0121 ns | 0.0107 ns |  8.4318 ns |  0.81 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 15.9626 ns | 0.0262 ns | 0.0218 ns | 15.9589 ns |  1.53 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 16.2501 ns | 0.0769 ns | 0.0719 ns | 16.2091 ns |  1.55 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 10.5604 ns | 0.0137 ns | 0.0115 ns | 10.5599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 10.6188 ns | 0.0103 ns | 0.0097 ns | 10.6185 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  8.4563 ns | 0.0089 ns | 0.0070 ns |  8.4556 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 15.0983 ns | 0.0219 ns | 0.0194 ns | 15.0969 ns |  1.43 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 15.5289 ns | 0.0253 ns | 0.0224 ns | 15.5321 ns |  1.47 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 12.0456 ns | 0.0373 ns | 0.0349 ns | 12.0436 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 11.7719 ns | 0.0157 ns | 0.0147 ns | 11.7719 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  9.6204 ns | 0.0165 ns | 0.0155 ns |  9.6207 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 17.3477 ns | 0.1588 ns | 0.1485 ns | 17.3566 ns |  1.44 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 17.1633 ns | 0.0197 ns | 0.0154 ns | 17.1675 ns |  1.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 10.3135 ns | 0.0068 ns | 0.0060 ns | 10.3145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 10.6950 ns | 0.0142 ns | 0.0133 ns | 10.6967 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  8.5920 ns | 0.0107 ns | 0.0095 ns |  8.5949 ns |  0.83 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 15.5651 ns | 0.0159 ns | 0.0141 ns | 15.5589 ns |  1.51 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 15.1288 ns | 0.0749 ns | 0.0701 ns | 15.1383 ns |  1.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 11.7793 ns | 0.0187 ns | 0.0146 ns | 11.7824 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 11.7958 ns | 0.0211 ns | 0.0198 ns | 11.7934 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  9.6877 ns | 0.0143 ns | 0.0127 ns |  9.6882 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 16.5811 ns | 0.0191 ns | 0.0179 ns | 16.5854 ns |  1.41 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 18.2524 ns | 0.0235 ns | 0.0220 ns | 18.2526 ns |  1.55 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 12.4546 ns | 0.0073 ns | 0.0065 ns | 12.4553 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 12.2774 ns | 0.0928 ns | 0.0868 ns | 12.2372 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 10.4364 ns | 0.0152 ns | 0.0142 ns | 10.4354 ns |  0.84 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 17.0604 ns | 0.0250 ns | 0.0209 ns | 17.0655 ns |  1.37 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 16.9837 ns | 0.0401 ns | 0.0356 ns | 16.9705 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 12.8265 ns | 0.0792 ns | 0.0741 ns | 12.8585 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 12.4631 ns | 0.0170 ns | 0.0159 ns | 12.4637 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 10.9156 ns | 0.0778 ns | 0.0728 ns | 10.9018 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 17.8002 ns | 0.0282 ns | 0.0250 ns | 17.8028 ns |  1.39 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 18.3288 ns | 0.0324 ns | 0.0271 ns | 18.3303 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 12.0893 ns | 0.0151 ns | 0.0134 ns | 12.0930 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 12.1737 ns | 0.0139 ns | 0.0130 ns | 12.1729 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 10.3909 ns | 0.0129 ns | 0.0121 ns | 10.3891 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 17.0951 ns | 0.0221 ns | 0.0196 ns | 17.0934 ns |  1.41 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 16.9510 ns | 0.0261 ns | 0.0245 ns | 16.9482 ns |  1.40 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 12.9418 ns | 0.0106 ns | 0.0099 ns | 12.9419 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 13.2581 ns | 0.0688 ns | 0.0643 ns | 13.2204 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 11.2059 ns | 0.0269 ns | 0.0239 ns | 11.2008 ns |  0.87 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 18.4625 ns | 0.0884 ns | 0.0827 ns | 18.4914 ns |  1.43 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 18.4384 ns | 0.0206 ns | 0.0192 ns | 18.4438 ns |  1.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 27.6978 ns | 0.0334 ns | 0.0313 ns | 27.7009 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 27.3687 ns | 0.1579 ns | 0.1477 ns | 27.2941 ns |  0.99 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 12.9888 ns | 0.0195 ns | 0.0183 ns | 12.9894 ns |  0.47 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 25.6035 ns | 0.0319 ns | 0.0298 ns | 25.6013 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 25.5350 ns | 0.0444 ns | 0.0347 ns | 25.5247 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 32.3854 ns | 0.0615 ns | 0.0545 ns | 32.3981 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 32.1511 ns | 0.0633 ns | 0.0592 ns | 32.1366 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 24.1046 ns | 0.1235 ns | 0.1155 ns | 24.0398 ns |  0.74 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 29.7588 ns | 0.0483 ns | 0.0452 ns | 29.7571 ns |  0.92 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 29.9663 ns | 0.0496 ns | 0.0464 ns | 29.9568 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  9.2126 ns | 0.0050 ns | 0.0041 ns |  9.2133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  9.2950 ns | 0.0152 ns | 0.0142 ns |  9.2948 ns |  1.01 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  6.8137 ns | 0.0106 ns | 0.0099 ns |  6.8132 ns |  0.74 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 14.0242 ns | 0.0181 ns | 0.0160 ns | 14.0265 ns |  1.52 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 | 14.2052 ns | 0.0213 ns | 0.0178 ns | 14.2042 ns |  1.54 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.9815 ns | 0.0060 ns | 0.0050 ns |  1.9807 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  2.1161 ns | 0.0131 ns | 0.0122 ns |  2.1212 ns |  1.07 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.9150 ns | 0.0047 ns | 0.0039 ns |  1.9143 ns |  0.97 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  2.1749 ns | 0.0039 ns | 0.0035 ns |  2.1743 ns |  1.10 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  2.1439 ns | 0.0183 ns | 0.0171 ns |  2.1359 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2113 ns | 0.0046 ns | 0.0043 ns |  2.2111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2366 ns | 0.0048 ns | 0.0045 ns |  2.2380 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1493 ns | 0.0050 ns | 0.0046 ns |  2.1478 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2861 ns | 0.0095 ns | 0.0089 ns |  2.2835 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2383 ns | 0.0045 ns | 0.0040 ns |  2.2385 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 16.5177 ns | 0.0292 ns | 0.0228 ns | 16.5170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 16.2374 ns | 0.1075 ns | 0.1005 ns | 16.2504 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 16.1176 ns | 0.0288 ns | 0.0256 ns | 16.1175 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 28.9968 ns | 0.0380 ns | 0.0337 ns | 28.9997 ns |  1.76 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 27.2610 ns | 0.0310 ns | 0.0290 ns | 27.2572 ns |  1.65 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.4917 ns | 0.0014 ns | 0.0013 ns |  0.4923 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6802 ns | 0.0023 ns | 0.0021 ns |  0.6799 ns |  1.38 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7084 ns | 0.0096 ns | 0.0089 ns |  0.7045 ns |  1.44 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7255 ns | 0.0014 ns | 0.0013 ns |  0.7258 ns |  1.48 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.0564 ns | 0.0482 ns | 0.0985 ns |  1.0591 ns |  2.07 |    0.24 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.9992 ns | 0.0033 ns | 0.0031 ns |  0.9995 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9210 ns | 0.0037 ns | 0.0031 ns |  0.9221 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  0.9628 ns | 0.0033 ns | 0.0031 ns |  0.9626 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.4269 ns | 0.0161 ns | 0.0151 ns |  1.4310 ns |  1.43 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.3964 ns | 0.0025 ns | 0.0022 ns |  1.3965 ns |  1.40 |    0.00 |     - |     - |     - |         - |
