
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
             FromBool | .NET Core 2.0 |  0.8788 ns | 0.0025 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.1485 ns | 0.0032 ns | 0.0030 ns |  1.31 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9429 ns | 0.0101 ns | 0.0095 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.8926 ns | 0.0026 ns | 0.0024 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1859 ns | 0.0033 ns | 0.0029 ns |  1.35 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3598 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.6142 ns | 0.0036 ns | 0.0032 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.3814 ns | 0.0033 ns | 0.0027 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0136 ns | 0.0051 ns | 0.0045 ns |  1.48 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1388 ns | 0.0093 ns | 0.0087 ns |  1.57 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.7339 ns | 0.0029 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.9234 ns | 0.0032 ns | 0.0029 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6858 ns | 0.0043 ns | 0.0038 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6284 ns | 0.0045 ns | 0.0042 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7414 ns | 0.0023 ns | 0.0021 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.6664 ns | 0.0036 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9677 ns | 0.0034 ns | 0.0031 ns |  1.45 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.7942 ns | 0.0039 ns | 0.0032 ns |  1.19 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.5673 ns | 0.0026 ns | 0.0023 ns |  2.35 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9974 ns | 0.0107 ns | 0.0100 ns |  1.50 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5899 ns | 0.0113 ns | 0.0106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.9473 ns | 0.0021 ns | 0.0019 ns |  1.61 |    0.03 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7201 ns | 0.0023 ns | 0.0019 ns |  1.22 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.6105 ns | 0.0049 ns | 0.0046 ns |  1.04 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7062 ns | 0.0017 ns | 0.0015 ns |  1.20 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1052 ns | 0.0043 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1922 ns | 0.0024 ns | 0.0020 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.0265 ns | 0.0034 ns | 0.0028 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9988 ns | 0.0075 ns | 0.0071 ns |  1.81 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.0222 ns | 0.0047 ns | 0.0039 ns |  1.83 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7626 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7207 ns | 0.0042 ns | 0.0040 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5568 ns | 0.0038 ns | 0.0036 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6618 ns | 0.0029 ns | 0.0026 ns |  0.87 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.9398 ns | 0.0040 ns | 0.0035 ns |  1.23 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0695 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1655 ns | 0.0040 ns | 0.0038 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.0242 ns | 0.0075 ns | 0.0071 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9968 ns | 0.0028 ns | 0.0024 ns |  1.87 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.0396 ns | 0.0134 ns | 0.0125 ns |  1.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6179 ns | 0.0024 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6960 ns | 0.0027 ns | 0.0024 ns |  1.13 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.5627 ns | 0.0025 ns | 0.0023 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6539 ns | 0.0021 ns | 0.0019 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  0.9484 ns | 0.0038 ns | 0.0032 ns |  1.53 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.0631 ns | 0.0032 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.2079 ns | 0.0026 ns | 0.0024 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1823 ns | 0.0033 ns | 0.0030 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9699 ns | 0.0061 ns | 0.0057 ns |  1.85 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.2592 ns | 0.0066 ns | 0.0055 ns |  2.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6712 ns | 0.0081 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9422 ns | 0.0096 ns | 0.0089 ns |  1.40 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6975 ns | 0.0028 ns | 0.0025 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6576 ns | 0.0038 ns | 0.0035 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7491 ns | 0.0179 ns | 0.0167 ns |  1.12 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0653 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.4218 ns | 0.0030 ns | 0.0027 ns |  1.33 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.2204 ns | 0.0082 ns | 0.0076 ns |  1.15 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9746 ns | 0.0067 ns | 0.0056 ns |  1.85 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0119 ns | 0.0026 ns | 0.0023 ns |  1.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.8013 ns | 0.0020 ns | 0.0019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.9496 ns | 0.0047 ns | 0.0044 ns |  1.19 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7375 ns | 0.0033 ns | 0.0031 ns |  0.92 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  0.6063 ns | 0.0024 ns | 0.0022 ns |  0.76 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7258 ns | 0.0059 ns | 0.0049 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.0426 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.2481 ns | 0.0031 ns | 0.0027 ns |  1.20 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1451 ns | 0.0038 ns | 0.0036 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9560 ns | 0.0042 ns | 0.0037 ns |  1.88 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.0021 ns | 0.0043 ns | 0.0036 ns |  1.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9198 ns | 0.0044 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.9473 ns | 0.0070 ns | 0.0062 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7453 ns | 0.0022 ns | 0.0020 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.9456 ns | 0.0039 ns | 0.0034 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.9055 ns | 0.0021 ns | 0.0020 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1114 ns | 0.0082 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.2083 ns | 0.0021 ns | 0.0018 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.2134 ns | 0.0081 ns | 0.0072 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.0094 ns | 0.0046 ns | 0.0041 ns |  1.81 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9589 ns | 0.0051 ns | 0.0045 ns |  1.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.8978 ns | 0.0025 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.9331 ns | 0.0023 ns | 0.0022 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7516 ns | 0.0028 ns | 0.0023 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7064 ns | 0.0036 ns | 0.0032 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6784 ns | 0.0029 ns | 0.0023 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7246 ns | 0.0070 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.6903 ns | 0.0046 ns | 0.0043 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.6575 ns | 0.0042 ns | 0.0037 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.4399 ns | 0.0047 ns | 0.0042 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.3333 ns | 0.0066 ns | 0.0058 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9239 ns | 0.0036 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.2005 ns | 0.0032 ns | 0.0027 ns |  1.30 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7565 ns | 0.0027 ns | 0.0024 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  0.9278 ns | 0.0055 ns | 0.0049 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  0.9030 ns | 0.0030 ns | 0.0028 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.0054 ns | 0.0084 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9200 ns | 0.0125 ns | 0.0117 ns |  0.96 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.8827 ns | 0.0042 ns | 0.0039 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.3627 ns | 0.0041 ns | 0.0038 ns |  1.18 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.3665 ns | 0.0045 ns | 0.0042 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.6050 ns | 0.0023 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.7439 ns | 0.0024 ns | 0.0020 ns |  1.23 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.0121 ns | 0.0469 ns | 0.1354 ns |  1.70 |    0.27 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.9469 ns | 0.0032 ns | 0.0029 ns |  1.56 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.8854 ns | 0.0029 ns | 0.0026 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.0549 ns | 0.0107 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.2074 ns | 0.0029 ns | 0.0027 ns |  1.14 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.1636 ns | 0.0031 ns | 0.0025 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  2.5358 ns | 0.0029 ns | 0.0026 ns |  2.40 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9400 ns | 0.0039 ns | 0.0036 ns |  1.84 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.7059 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.9316 ns | 0.0025 ns | 0.0023 ns |  1.32 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.7274 ns | 0.0023 ns | 0.0021 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  1.4024 ns | 0.0041 ns | 0.0039 ns |  1.99 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.6604 ns | 0.0034 ns | 0.0026 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.1793 ns | 0.0031 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.5528 ns | 0.0028 ns | 0.0026 ns |  1.32 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.2212 ns | 0.0025 ns | 0.0022 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  1.1788 ns | 0.0030 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  1.3056 ns | 0.0035 ns | 0.0031 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  8.7194 ns | 0.0144 ns | 0.0134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  8.6922 ns | 0.0136 ns | 0.0120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.4464 ns | 0.0093 ns | 0.0078 ns |  0.62 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  9.1565 ns | 0.0115 ns | 0.0102 ns |  1.05 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  9.9886 ns | 0.0364 ns | 0.0341 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.3540 ns | 0.0438 ns | 0.0409 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.2112 ns | 0.1268 ns | 0.1186 ns |  0.99 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 17.9176 ns | 0.1179 ns | 0.1103 ns |  0.77 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 22.9900 ns | 0.0159 ns | 0.0124 ns |  0.98 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 22.9971 ns | 0.0216 ns | 0.0192 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.7479 ns | 0.0115 ns | 0.0108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7585 ns | 0.0034 ns | 0.0032 ns |  1.01 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7485 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9235 ns | 0.0030 ns | 0.0028 ns |  1.24 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8946 ns | 0.0093 ns | 0.0087 ns |  1.20 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4731 ns | 0.0044 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6511 ns | 0.0030 ns | 0.0027 ns |  1.12 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4558 ns | 0.0047 ns | 0.0037 ns |  0.99 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6752 ns | 0.0061 ns | 0.0057 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6453 ns | 0.0033 ns | 0.0026 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.3050 ns | 0.0155 ns | 0.0137 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.6260 ns | 0.0301 ns | 0.0282 ns |  1.42 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.1818 ns | 0.0729 ns | 0.0682 ns |  1.47 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.6058 ns | 0.1217 ns | 0.1138 ns |  1.32 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.5114 ns | 0.1050 ns | 0.0982 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 56.5114 ns | 0.0833 ns | 0.0779 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 63.3015 ns | 0.0768 ns | 0.0718 ns |  1.12 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 43.7312 ns | 0.0741 ns | 0.0693 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 60.3332 ns | 0.1397 ns | 0.1307 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 58.6678 ns | 0.0777 ns | 0.0727 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8277 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.9374 ns | 0.0026 ns | 0.0023 ns |  0.51 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7223 ns | 0.0019 ns | 0.0018 ns |  0.40 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7195 ns | 0.0056 ns | 0.0052 ns |  0.39 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7000 ns | 0.0055 ns | 0.0051 ns |  0.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.0846 ns | 0.0119 ns | 0.0111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1524 ns | 0.0039 ns | 0.0036 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1727 ns | 0.0039 ns | 0.0036 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.7876 ns | 0.0037 ns | 0.0033 ns |  2.57 |    0.03 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9546 ns | 0.0060 ns | 0.0053 ns |  1.80 |    0.02 |     - |     - |     - |         - |
