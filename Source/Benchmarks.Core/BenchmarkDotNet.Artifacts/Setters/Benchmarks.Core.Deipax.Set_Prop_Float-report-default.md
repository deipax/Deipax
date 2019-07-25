
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
             FromBool | .NET Core 2.0 |  0.9280 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6836 ns | 0.0127 ns | 0.0112 ns |  0.74 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7302 ns | 0.0033 ns | 0.0031 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9501 ns | 0.0023 ns | 0.0021 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6700 ns | 0.0027 ns | 0.0026 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3857 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1262 ns | 0.0075 ns | 0.0067 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1842 ns | 0.0030 ns | 0.0025 ns |  0.85 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.1060 ns | 0.0043 ns | 0.0038 ns |  1.52 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.8222 ns | 0.0038 ns | 0.0036 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9336 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4386 ns | 0.0151 ns | 0.0134 ns |  0.47 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4960 ns | 0.0029 ns | 0.0026 ns |  0.53 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7470 ns | 0.0051 ns | 0.0047 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.4302 ns | 0.0037 ns | 0.0035 ns |  0.46 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.6945 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.7174 ns | 0.0206 ns | 0.0192 ns |  1.03 |    0.02 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.6849 ns | 0.0034 ns | 0.0030 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9379 ns | 0.0034 ns | 0.0030 ns |  1.35 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.0589 ns | 0.0099 ns | 0.0093 ns |  1.52 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6911 ns | 0.0023 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6458 ns | 0.0020 ns | 0.0017 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7252 ns | 0.0026 ns | 0.0023 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5797 ns | 0.0038 ns | 0.0034 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.4232 ns | 0.0014 ns | 0.0012 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1544 ns | 0.0080 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.8950 ns | 0.0036 ns | 0.0033 ns |  0.78 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9544 ns | 0.0023 ns | 0.0019 ns |  0.83 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.6810 ns | 0.0029 ns | 0.0025 ns |  1.46 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6486 ns | 0.0077 ns | 0.0072 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9347 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6707 ns | 0.0038 ns | 0.0034 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7218 ns | 0.0033 ns | 0.0029 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.9433 ns | 0.0068 ns | 0.0060 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.6524 ns | 0.0018 ns | 0.0016 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9334 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9046 ns | 0.0020 ns | 0.0018 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9666 ns | 0.0028 ns | 0.0026 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6788 ns | 0.0034 ns | 0.0030 ns |  1.80 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.8337 ns | 0.0047 ns | 0.0044 ns |  1.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6933 ns | 0.0022 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6568 ns | 0.0035 ns | 0.0033 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7211 ns | 0.0025 ns | 0.0022 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7179 ns | 0.0033 ns | 0.0029 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.4506 ns | 0.0020 ns | 0.0018 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.1451 ns | 0.0027 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.9949 ns | 0.0024 ns | 0.0021 ns |  0.87 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9612 ns | 0.0023 ns | 0.0021 ns |  0.84 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6889 ns | 0.0036 ns | 0.0034 ns |  1.48 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.8027 ns | 0.0050 ns | 0.0047 ns |  1.57 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9258 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6751 ns | 0.0051 ns | 0.0048 ns |  0.73 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7286 ns | 0.0043 ns | 0.0038 ns |  0.79 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.9582 ns | 0.0037 ns | 0.0033 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6563 ns | 0.0019 ns | 0.0015 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9344 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.8959 ns | 0.0025 ns | 0.0022 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9555 ns | 0.0038 ns | 0.0034 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6772 ns | 0.0033 ns | 0.0031 ns |  1.80 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6525 ns | 0.0101 ns | 0.0094 ns |  1.77 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.6931 ns | 0.0032 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.6578 ns | 0.0032 ns | 0.0029 ns |  0.95 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7091 ns | 0.0064 ns | 0.0060 ns |  1.02 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.7196 ns | 0.0045 ns | 0.0040 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.4396 ns | 0.0018 ns | 0.0017 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.9782 ns | 0.0440 ns | 0.0432 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.8626 ns | 0.0066 ns | 0.0059 ns |  0.88 |    0.04 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.7595 ns | 0.0608 ns | 0.1384 ns |  1.73 |    0.26 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.6613 ns | 0.0040 ns | 0.0037 ns |  1.70 |    0.07 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.6396 ns | 0.0120 ns | 0.0112 ns |  1.68 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9235 ns | 0.0035 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7350 ns | 0.0083 ns | 0.0077 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6836 ns | 0.0028 ns | 0.0026 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.6633 ns | 0.0024 ns | 0.0023 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7227 ns | 0.0023 ns | 0.0020 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0022 ns | 0.0177 ns | 0.0157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1456 ns | 0.0019 ns | 0.0017 ns |  1.14 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1762 ns | 0.0033 ns | 0.0031 ns |  1.17 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9748 ns | 0.0034 ns | 0.0031 ns |  1.97 |    0.03 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.7231 ns | 0.0048 ns | 0.0045 ns |  1.72 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.7179 ns | 0.0073 ns | 0.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.7160 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.6903 ns | 0.0024 ns | 0.0023 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.6614 ns | 0.0022 ns | 0.0019 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.7259 ns | 0.0024 ns | 0.0021 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.4693 ns | 0.0244 ns | 0.0228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7500 ns | 0.0068 ns | 0.0064 ns |  1.19 |    0.02 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.6939 ns | 0.0028 ns | 0.0026 ns |  1.15 |    0.02 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.1561 ns | 0.0037 ns | 0.0033 ns |  1.47 |    0.02 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.1046 ns | 0.0030 ns | 0.0027 ns |  1.43 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.2148 ns | 0.0489 ns | 0.0457 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.9364 ns | 0.0025 ns | 0.0023 ns |  0.77 |    0.03 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.9351 ns | 0.0055 ns | 0.0046 ns |  0.77 |    0.03 |     - |     - |     - |         - |
            FromULong |        net461 |  1.1275 ns | 0.0027 ns | 0.0025 ns |  0.93 |    0.03 |     - |     - |     - |         - |
            FromULong |        net472 |  1.1718 ns | 0.0039 ns | 0.0034 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9628 ns | 0.0265 ns | 0.0235 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7034 ns | 0.0113 ns | 0.0101 ns |  0.87 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7074 ns | 0.0074 ns | 0.0069 ns |  0.87 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.0972 ns | 0.0030 ns | 0.0028 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.1338 ns | 0.0067 ns | 0.0056 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.6720 ns | 0.0103 ns | 0.0097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.7264 ns | 0.0036 ns | 0.0034 ns |  1.08 |    0.02 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.6931 ns | 0.0017 ns | 0.0015 ns |  1.03 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.6725 ns | 0.0042 ns | 0.0039 ns |  1.00 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.7226 ns | 0.0022 ns | 0.0021 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.1032 ns | 0.0641 ns | 0.0599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.9738 ns | 0.0056 ns | 0.0049 ns |  0.88 |    0.05 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.9381 ns | 0.0026 ns | 0.0023 ns |  0.85 |    0.04 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.3742 ns | 0.0038 ns | 0.0036 ns |  1.25 |    0.06 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.4270 ns | 0.0029 ns | 0.0027 ns |  1.30 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.6677 ns | 0.0122 ns | 0.0114 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.7322 ns | 0.0048 ns | 0.0045 ns |  1.10 |    0.02 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.6863 ns | 0.0022 ns | 0.0017 ns |  1.03 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.6629 ns | 0.0014 ns | 0.0012 ns |  0.99 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.7250 ns | 0.0033 ns | 0.0031 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.6867 ns | 0.0471 ns | 0.0441 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.6178 ns | 0.0051 ns | 0.0048 ns |  0.96 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.6192 ns | 0.0098 ns | 0.0091 ns |  0.96 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  1.8697 ns | 0.0053 ns | 0.0049 ns |  1.11 |    0.03 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  1.9073 ns | 0.0077 ns | 0.0072 ns |  1.13 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 10.4028 ns | 0.0518 ns | 0.0433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 10.5706 ns | 0.0156 ns | 0.0121 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.7906 ns | 0.0058 ns | 0.0051 ns |  0.56 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 10.2131 ns | 0.0102 ns | 0.0096 ns |  0.98 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 10.8151 ns | 0.0783 ns | 0.0733 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.7620 ns | 0.0989 ns | 0.0925 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 25.9229 ns | 0.0338 ns | 0.0316 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 18.5144 ns | 0.1684 ns | 0.1575 ns |  0.72 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.9202 ns | 0.0298 ns | 0.0264 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.6311 ns | 0.0284 ns | 0.0238 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6926 ns | 0.0057 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9337 ns | 0.0024 ns | 0.0023 ns |  1.35 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6929 ns | 0.0024 ns | 0.0022 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6654 ns | 0.0042 ns | 0.0035 ns |  0.96 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7092 ns | 0.0036 ns | 0.0030 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4164 ns | 0.0092 ns | 0.0086 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4308 ns | 0.0055 ns | 0.0051 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4660 ns | 0.0038 ns | 0.0034 ns |  1.03 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4085 ns | 0.0028 ns | 0.0026 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4133 ns | 0.0041 ns | 0.0036 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.4119 ns | 0.0350 ns | 0.0310 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2185 ns | 0.0047 ns | 0.0040 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1779 ns | 0.0027 ns | 0.0024 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8396 ns | 0.0024 ns | 0.0022 ns |  1.18 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2551 ns | 0.0053 ns | 0.0042 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 58.2497 ns | 0.2086 ns | 0.1850 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 61.4461 ns | 0.2550 ns | 0.2260 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 45.6131 ns | 0.0496 ns | 0.0414 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 60.2645 ns | 0.0931 ns | 0.0871 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 59.3919 ns | 0.0942 ns | 0.0881 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7348 ns | 0.0141 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.9576 ns | 0.0022 ns | 0.0019 ns |  1.30 |    0.02 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7109 ns | 0.0051 ns | 0.0048 ns |  0.97 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.8832 ns | 0.0027 ns | 0.0024 ns |  1.20 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.9595 ns | 0.0078 ns | 0.0065 ns |  1.30 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1713 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9498 ns | 0.0041 ns | 0.0037 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1652 ns | 0.0039 ns | 0.0036 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6532 ns | 0.0040 ns | 0.0035 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.6661 ns | 0.0051 ns | 0.0047 ns |  1.42 |    0.01 |     - |     - |     - |         - |
