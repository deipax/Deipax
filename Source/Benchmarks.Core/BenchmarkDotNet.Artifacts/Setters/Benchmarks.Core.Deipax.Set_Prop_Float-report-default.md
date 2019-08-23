
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
             FromBool | .NET Core 2.0 |  0.6393 ns | 0.0032 ns | 0.0028 ns |  0.6391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6768 ns | 0.0056 ns | 0.0053 ns |  0.6781 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7166 ns | 0.0027 ns | 0.0021 ns |  0.7167 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6559 ns | 0.0026 ns | 0.0021 ns |  0.6553 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6667 ns | 0.0022 ns | 0.0021 ns |  0.6670 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1347 ns | 0.0026 ns | 0.0025 ns |  1.1354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1243 ns | 0.0020 ns | 0.0018 ns |  1.1244 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.3197 ns | 0.0097 ns | 0.0091 ns |  1.3225 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.8110 ns | 0.0021 ns | 0.0019 ns |  1.8115 ns |  1.60 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.8172 ns | 0.0028 ns | 0.0026 ns |  1.8169 ns |  1.60 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6697 ns | 0.0044 ns | 0.0041 ns |  0.6707 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4422 ns | 0.0024 ns | 0.0022 ns |  0.4416 ns |  0.66 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6404 ns | 0.0024 ns | 0.0023 ns |  0.6412 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4272 ns | 0.0017 ns | 0.0016 ns |  0.4274 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.4365 ns | 0.0030 ns | 0.0028 ns |  0.4371 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.4342 ns | 0.0017 ns | 0.0016 ns |  0.4344 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.8445 ns | 0.0133 ns | 0.0125 ns |  0.8511 ns |  1.95 |    0.03 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.2506 ns | 0.0022 ns | 0.0019 ns |  1.2508 ns |  2.88 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.7096 ns | 0.0022 ns | 0.0020 ns |  0.7099 ns |  1.63 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.7019 ns | 0.0035 ns | 0.0033 ns |  0.7017 ns |  1.62 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.4352 ns | 0.0016 ns | 0.0015 ns |  0.4350 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6803 ns | 0.0024 ns | 0.0021 ns |  0.6804 ns |  1.56 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.8843 ns | 0.0120 ns | 0.0100 ns |  0.8894 ns |  2.03 |    0.03 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.4234 ns | 0.0015 ns | 0.0014 ns |  0.4236 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.4298 ns | 0.0021 ns | 0.0019 ns |  0.4292 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.9082 ns | 0.0111 ns | 0.0104 ns |  0.9135 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.8984 ns | 0.0027 ns | 0.0025 ns |  0.8990 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9525 ns | 0.0036 ns | 0.0032 ns |  0.9531 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.6351 ns | 0.0032 ns | 0.0030 ns |  1.6355 ns |  1.80 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6444 ns | 0.0025 ns | 0.0024 ns |  1.6447 ns |  1.81 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6420 ns | 0.0015 ns | 0.0014 ns |  0.6418 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6539 ns | 0.0091 ns | 0.0085 ns |  0.6586 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7170 ns | 0.0031 ns | 0.0026 ns |  0.7170 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6557 ns | 0.0057 ns | 0.0053 ns |  0.6561 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.6754 ns | 0.0023 ns | 0.0021 ns |  0.6751 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.8906 ns | 0.0024 ns | 0.0022 ns |  0.8905 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9051 ns | 0.0035 ns | 0.0032 ns |  0.9048 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.0803 ns | 0.0035 ns | 0.0032 ns |  1.0802 ns |  1.21 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6339 ns | 0.0039 ns | 0.0036 ns |  1.6334 ns |  1.83 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6444 ns | 0.0021 ns | 0.0020 ns |  1.6444 ns |  1.85 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.4186 ns | 0.0046 ns | 0.0043 ns |  0.4200 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6615 ns | 0.0028 ns | 0.0023 ns |  0.6618 ns |  1.58 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7169 ns | 0.0024 ns | 0.0023 ns |  0.7172 ns |  1.71 |    0.02 |     - |     - |     - |         - |
            FromShort |        net461 |  0.5173 ns | 0.0019 ns | 0.0018 ns |  0.5175 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.4332 ns | 0.0021 ns | 0.0018 ns |  0.4337 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.9017 ns | 0.0020 ns | 0.0019 ns |  0.9017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.9148 ns | 0.0165 ns | 0.0154 ns |  0.9048 ns |  1.01 |    0.02 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9505 ns | 0.0092 ns | 0.0086 ns |  0.9470 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6665 ns | 0.0092 ns | 0.0086 ns |  1.6677 ns |  1.85 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.7499 ns | 0.0025 ns | 0.0024 ns |  1.7504 ns |  1.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6652 ns | 0.0022 ns | 0.0019 ns |  0.6648 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6608 ns | 0.0026 ns | 0.0025 ns |  0.6612 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7172 ns | 0.0028 ns | 0.0026 ns |  0.7173 ns |  1.08 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6446 ns | 0.0031 ns | 0.0029 ns |  0.6445 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6581 ns | 0.0028 ns | 0.0026 ns |  0.6583 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9075 ns | 0.0127 ns | 0.0119 ns |  0.9134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.8985 ns | 0.0030 ns | 0.0027 ns |  0.8996 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9519 ns | 0.0037 ns | 0.0034 ns |  0.9517 ns |  1.05 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6342 ns | 0.0028 ns | 0.0026 ns |  1.6342 ns |  1.80 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.7562 ns | 0.0036 ns | 0.0032 ns |  1.7551 ns |  1.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.4347 ns | 0.0009 ns | 0.0008 ns |  0.4349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.6605 ns | 0.0105 ns | 0.0098 ns |  0.6638 ns |  1.52 |    0.02 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.1741 ns | 0.0115 ns | 0.0108 ns |  1.1665 ns |  2.70 |    0.03 |     - |     - |     - |         - |
              FromInt |        net461 |  0.4366 ns | 0.0055 ns | 0.0052 ns |  0.4382 ns |  1.00 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.4448 ns | 0.0012 ns | 0.0010 ns |  0.4447 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.8973 ns | 0.0020 ns | 0.0018 ns |  0.8970 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.8478 ns | 0.0020 ns | 0.0019 ns |  0.8482 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.8757 ns | 0.0018 ns | 0.0016 ns |  0.8758 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.6294 ns | 0.0036 ns | 0.0034 ns |  1.6287 ns |  1.82 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.6358 ns | 0.0038 ns | 0.0030 ns |  1.6360 ns |  1.82 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.6452 ns | 0.0079 ns | 0.0074 ns |  0.6470 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7297 ns | 0.0033 ns | 0.0029 ns |  0.7291 ns |  1.13 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6953 ns | 0.0028 ns | 0.0026 ns |  0.6961 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.4553 ns | 0.0015 ns | 0.0014 ns |  0.4556 ns |  0.71 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7275 ns | 0.0110 ns | 0.0102 ns |  0.7222 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  0.9673 ns | 0.0016 ns | 0.0015 ns |  0.9680 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1569 ns | 0.0144 ns | 0.0135 ns |  1.1491 ns |  1.20 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1690 ns | 0.0119 ns | 0.0111 ns |  1.1631 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.7276 ns | 0.0031 ns | 0.0029 ns |  1.7268 ns |  1.79 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.7118 ns | 0.0018 ns | 0.0016 ns |  1.7112 ns |  1.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.4480 ns | 0.0013 ns | 0.0011 ns |  0.4481 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.7064 ns | 0.0030 ns | 0.0026 ns |  0.7068 ns |  1.58 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7053 ns | 0.0024 ns | 0.0023 ns |  0.7056 ns |  1.57 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.4391 ns | 0.0019 ns | 0.0018 ns |  0.4395 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.7060 ns | 0.0016 ns | 0.0013 ns |  0.7059 ns |  1.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.5045 ns | 0.0172 ns | 0.0161 ns |  1.5118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7320 ns | 0.0025 ns | 0.0021 ns |  1.7321 ns |  1.15 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7000 ns | 0.0016 ns | 0.0015 ns |  1.7001 ns |  1.13 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.0948 ns | 0.0019 ns | 0.0017 ns |  2.0947 ns |  1.39 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.0957 ns | 0.0031 ns | 0.0026 ns |  2.0963 ns |  1.39 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9010 ns | 0.0028 ns | 0.0026 ns |  0.9018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.9266 ns | 0.0101 ns | 0.0094 ns |  0.9236 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.9606 ns | 0.0070 ns | 0.0066 ns |  0.9620 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.9000 ns | 0.0023 ns | 0.0022 ns |  0.8999 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.1614 ns | 0.0040 ns | 0.0037 ns |  1.1611 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9899 ns | 0.0110 ns | 0.0092 ns |  1.9928 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.6939 ns | 0.0041 ns | 0.0036 ns |  1.6940 ns |  0.85 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.8729 ns | 0.0017 ns | 0.0014 ns |  1.8729 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.1595 ns | 0.0037 ns | 0.0033 ns |  2.1589 ns |  1.09 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.1517 ns | 0.0098 ns | 0.0092 ns |  2.1486 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.4490 ns | 0.0013 ns | 0.0010 ns |  0.4491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.7271 ns | 0.0026 ns | 0.0025 ns |  0.7268 ns |  1.62 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.4736 ns | 0.0017 ns | 0.0016 ns |  0.4733 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.4555 ns | 0.0012 ns | 0.0011 ns |  0.4555 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.7331 ns | 0.0122 ns | 0.0114 ns |  0.7413 ns |  1.64 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.0204 ns | 0.0020 ns | 0.0018 ns |  1.0205 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.9656 ns | 0.0018 ns | 0.0015 ns |  0.9653 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.9796 ns | 0.0039 ns | 0.0031 ns |  0.9801 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.3686 ns | 0.0027 ns | 0.0026 ns |  1.3685 ns |  1.34 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.3933 ns | 0.0025 ns | 0.0023 ns |  1.3933 ns |  1.37 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.4926 ns | 0.0014 ns | 0.0013 ns |  0.4929 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.7213 ns | 0.0105 ns | 0.0098 ns |  0.7277 ns |  1.46 |    0.02 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.3355 ns | 0.0154 ns | 0.0144 ns |  1.3348 ns |  2.71 |    0.03 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.4876 ns | 0.0027 ns | 0.0023 ns |  0.4875 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.7219 ns | 0.0033 ns | 0.0026 ns |  0.7224 ns |  1.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.6454 ns | 0.0080 ns | 0.0074 ns |  1.6482 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.6131 ns | 0.0054 ns | 0.0051 ns |  1.6130 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.6421 ns | 0.0114 ns | 0.0107 ns |  1.6409 ns |  1.00 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  1.9093 ns | 0.0029 ns | 0.0027 ns |  1.9092 ns |  1.16 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  1.9047 ns | 0.0148 ns | 0.0139 ns |  1.8983 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 10.0960 ns | 0.0109 ns | 0.0102 ns | 10.0959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 10.5287 ns | 0.0511 ns | 0.0478 ns | 10.5581 ns |  1.04 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.4011 ns | 0.0056 ns | 0.0052 ns |  5.4025 ns |  0.53 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 10.3942 ns | 0.0110 ns | 0.0098 ns | 10.3953 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 10.5778 ns | 0.0139 ns | 0.0123 ns | 10.5769 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.4618 ns | 0.0147 ns | 0.0130 ns | 25.4652 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 25.5124 ns | 0.0211 ns | 0.0198 ns | 25.5086 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 18.2160 ns | 0.0244 ns | 0.0190 ns | 18.2187 ns |  0.72 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.8139 ns | 0.0150 ns | 0.0140 ns | 25.8136 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.5339 ns | 0.0181 ns | 0.0151 ns | 25.5337 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.4420 ns | 0.0097 ns | 0.0090 ns |  0.4467 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9370 ns | 0.0026 ns | 0.0023 ns |  0.9365 ns |  2.12 |    0.05 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7164 ns | 0.0095 ns | 0.0089 ns |  0.7128 ns |  1.62 |    0.03 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.4314 ns | 0.0029 ns | 0.0027 ns |  0.4309 ns |  0.98 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7019 ns | 0.0032 ns | 0.0030 ns |  0.7019 ns |  1.59 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4323 ns | 0.0022 ns | 0.0021 ns |  1.4323 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4018 ns | 0.0127 ns | 0.0119 ns |  1.3941 ns |  0.98 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.2006 ns | 0.0036 ns | 0.0033 ns |  1.1990 ns |  0.84 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4184 ns | 0.0029 ns | 0.0026 ns |  1.4185 ns |  0.99 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4141 ns | 0.0033 ns | 0.0029 ns |  1.4143 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.3334 ns | 0.0029 ns | 0.0026 ns |  2.3343 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.4393 ns | 0.0034 ns | 0.0030 ns |  2.4397 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1807 ns | 0.0042 ns | 0.0037 ns |  2.1809 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.1809 ns | 0.0029 ns | 0.0025 ns |  2.1812 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2099 ns | 0.0026 ns | 0.0024 ns |  2.2099 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 58.5032 ns | 0.0993 ns | 0.0929 ns | 58.4773 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 62.1330 ns | 0.1350 ns | 0.1263 ns | 62.1229 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 45.8579 ns | 0.0602 ns | 0.0470 ns | 45.8690 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 59.3385 ns | 0.0803 ns | 0.0751 ns | 59.3427 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 61.7594 ns | 0.0781 ns | 0.0731 ns | 61.7616 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7185 ns | 0.0016 ns | 0.0014 ns |  0.7187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7309 ns | 0.0074 ns | 0.0069 ns |  0.7279 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.4932 ns | 0.0024 ns | 0.0022 ns |  0.4937 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.6560 ns | 0.0026 ns | 0.0024 ns |  0.6564 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.9398 ns | 0.0029 ns | 0.0024 ns |  0.9405 ns |  1.31 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.9136 ns | 0.0028 ns | 0.0026 ns |  0.9136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1631 ns | 0.0043 ns | 0.0040 ns |  1.1632 ns |  1.27 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1748 ns | 0.0034 ns | 0.0032 ns |  1.1740 ns |  1.29 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6292 ns | 0.0017 ns | 0.0015 ns |  1.6295 ns |  1.78 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.6650 ns | 0.0130 ns | 0.0122 ns |  1.6723 ns |  1.82 |    0.01 |     - |     - |     - |         - |
