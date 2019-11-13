
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
             FromBool | .NET Core 2.0 |  0.9162 ns | 0.0092 ns | 0.0086 ns |  0.9189 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.1751 ns | 0.0046 ns | 0.0043 ns |  1.1742 ns |  1.28 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9489 ns | 0.0029 ns | 0.0027 ns |  0.9491 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.8827 ns | 0.0027 ns | 0.0025 ns |  0.8831 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1688 ns | 0.0031 ns | 0.0029 ns |  1.1693 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3759 ns | 0.0027 ns | 0.0026 ns |  1.3761 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.3987 ns | 0.0027 ns | 0.0025 ns |  1.3988 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1683 ns | 0.0027 ns | 0.0024 ns |  1.1683 ns |  0.85 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6166 ns | 0.0027 ns | 0.0025 ns |  1.6172 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6579 ns | 0.0059 ns | 0.0055 ns |  1.6581 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6862 ns | 0.0021 ns | 0.0019 ns |  0.6863 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7201 ns | 0.0041 ns | 0.0036 ns |  0.7202 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4923 ns | 0.0078 ns | 0.0073 ns |  0.4960 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4330 ns | 0.0037 ns | 0.0033 ns |  0.4322 ns |  0.63 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7386 ns | 0.0149 ns | 0.0132 ns |  0.7346 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1365 ns | 0.0130 ns | 0.0121 ns |  1.1421 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1741 ns | 0.0025 ns | 0.0023 ns |  1.1751 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1654 ns | 0.0021 ns | 0.0018 ns |  1.1651 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.6053 ns | 0.0040 ns | 0.0038 ns |  1.6061 ns |  1.41 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6542 ns | 0.0090 ns | 0.0085 ns |  1.6561 ns |  1.46 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.1207 ns | 0.0026 ns | 0.0025 ns |  1.1206 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.0853 ns | 0.0025 ns | 0.0023 ns |  1.0853 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.4905 ns | 0.0015 ns | 0.0013 ns |  0.4904 ns |  0.44 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.4902 ns | 0.0021 ns | 0.0020 ns |  1.4900 ns |  1.33 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.6167 ns | 0.0028 ns | 0.0024 ns |  1.6157 ns |  1.44 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7634 ns | 0.0020 ns | 0.0018 ns |  1.7631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.4963 ns | 0.0103 ns | 0.0097 ns |  1.5002 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9501 ns | 0.0073 ns | 0.0069 ns |  0.9520 ns |  0.54 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.1007 ns | 0.0146 ns | 0.0137 ns |  2.0972 ns |  1.19 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.2968 ns | 0.0033 ns | 0.0028 ns |  2.2970 ns |  1.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6851 ns | 0.0022 ns | 0.0020 ns |  0.6851 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7142 ns | 0.0016 ns | 0.0015 ns |  0.7144 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  1.0961 ns | 0.0022 ns | 0.0020 ns |  1.0961 ns |  1.60 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4252 ns | 0.0020 ns | 0.0018 ns |  0.4249 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7143 ns | 0.0022 ns | 0.0020 ns |  0.7146 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.2762 ns | 0.0024 ns | 0.0022 ns |  1.2764 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9482 ns | 0.0055 ns | 0.0048 ns |  0.9474 ns |  0.74 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9573 ns | 0.0094 ns | 0.0088 ns |  0.9516 ns |  0.75 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.8815 ns | 0.0033 ns | 0.0027 ns |  1.8811 ns |  1.47 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6511 ns | 0.0036 ns | 0.0034 ns |  1.6514 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.1310 ns | 0.0099 ns | 0.0092 ns |  1.1265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.1775 ns | 0.0017 ns | 0.0015 ns |  1.1773 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.4896 ns | 0.0012 ns | 0.0012 ns |  0.4896 ns |  0.43 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.4900 ns | 0.0015 ns | 0.0011 ns |  1.4905 ns |  1.32 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.6227 ns | 0.0039 ns | 0.0030 ns |  1.6237 ns |  1.44 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.6198 ns | 0.0020 ns | 0.0019 ns |  1.6196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.6075 ns | 0.0024 ns | 0.0021 ns |  1.6083 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9455 ns | 0.0025 ns | 0.0022 ns |  0.9452 ns |  0.58 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.4754 ns | 0.0041 ns | 0.0038 ns |  2.4761 ns |  1.53 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.7794 ns | 0.0057 ns | 0.0051 ns |  2.7792 ns |  1.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6871 ns | 0.0039 ns | 0.0033 ns |  0.6877 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7309 ns | 0.0133 ns | 0.0124 ns |  0.7248 ns |  1.06 |    0.02 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.4863 ns | 0.0033 ns | 0.0031 ns |  0.4871 ns |  0.71 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.4364 ns | 0.0022 ns | 0.0019 ns |  0.4365 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7250 ns | 0.0044 ns | 0.0039 ns |  0.7245 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1502 ns | 0.0137 ns | 0.0128 ns |  1.1582 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1700 ns | 0.0025 ns | 0.0024 ns |  1.1701 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9440 ns | 0.0025 ns | 0.0022 ns |  0.9440 ns |  0.82 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.5994 ns | 0.0025 ns | 0.0024 ns |  1.5994 ns |  1.39 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6375 ns | 0.0126 ns | 0.0118 ns |  1.6317 ns |  1.42 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.2625 ns | 0.0020 ns | 0.0019 ns |  1.2621 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.1565 ns | 0.0022 ns | 0.0020 ns |  1.1566 ns |  0.92 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7217 ns | 0.0078 ns | 0.0073 ns |  0.7247 ns |  0.57 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.5919 ns | 0.0027 ns | 0.0025 ns |  1.5921 ns |  1.26 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6335 ns | 0.0042 ns | 0.0039 ns |  1.6333 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.7235 ns | 0.0029 ns | 0.0027 ns |  1.7228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.6238 ns | 0.0082 ns | 0.0077 ns |  1.6198 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.9352 ns | 0.0034 ns | 0.0032 ns |  0.9353 ns |  0.54 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9945 ns | 0.0042 ns | 0.0035 ns |  1.9953 ns |  1.16 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.0839 ns | 0.0031 ns | 0.0028 ns |  2.0854 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.1002 ns | 0.0064 ns | 0.0060 ns |  1.1013 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6822 ns | 0.0016 ns | 0.0015 ns |  0.6820 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6279 ns | 0.0024 ns | 0.0022 ns |  0.6282 ns |  0.57 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.4322 ns | 0.0010 ns | 0.0009 ns |  0.4326 ns |  0.39 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6662 ns | 0.0081 ns | 0.0076 ns |  0.6609 ns |  0.61 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1461 ns | 0.0031 ns | 0.0029 ns |  1.1457 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  0.9022 ns | 0.0021 ns | 0.0019 ns |  0.9028 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0862 ns | 0.0022 ns | 0.0019 ns |  1.0866 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.6168 ns | 0.0045 ns | 0.0040 ns |  1.6168 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.6082 ns | 0.0024 ns | 0.0023 ns |  1.6084 ns |  1.40 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.6580 ns | 0.0018 ns | 0.0015 ns |  1.6576 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.2819 ns | 0.0087 ns | 0.0081 ns |  1.2778 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7019 ns | 0.0019 ns | 0.0018 ns |  0.7026 ns |  0.42 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.5775 ns | 0.0046 ns | 0.0040 ns |  1.5778 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.8742 ns | 0.0054 ns | 0.0048 ns |  1.8730 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.6864 ns | 0.0099 ns | 0.0093 ns |  1.6884 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.8946 ns | 0.0033 ns | 0.0031 ns |  1.8932 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.4789 ns | 0.0020 ns | 0.0019 ns |  1.4793 ns |  0.88 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.7036 ns | 0.0078 ns | 0.0073 ns |  2.7017 ns |  1.60 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.8650 ns | 0.0038 ns | 0.0032 ns |  2.8645 ns |  1.70 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.6853 ns | 0.0029 ns | 0.0025 ns |  0.6854 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.6773 ns | 0.0034 ns | 0.0032 ns |  0.6762 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7100 ns | 0.0073 ns | 0.0068 ns |  0.7074 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.4376 ns | 0.0020 ns | 0.0018 ns |  0.4380 ns |  0.64 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.1075 ns | 0.0035 ns | 0.0031 ns |  1.1066 ns |  1.62 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.5366 ns | 0.0123 ns | 0.0115 ns |  1.5314 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.4177 ns | 0.0104 ns | 0.0098 ns |  1.4133 ns |  0.92 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.4541 ns | 0.0026 ns | 0.0023 ns |  1.4542 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.7840 ns | 0.0033 ns | 0.0026 ns |  1.7844 ns |  1.16 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.7291 ns | 0.0035 ns | 0.0031 ns |  1.7297 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.1304 ns | 0.0052 ns | 0.0049 ns |  3.1296 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.0798 ns | 0.0030 ns | 0.0028 ns |  2.0793 ns |  0.66 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.9272 ns | 0.0040 ns | 0.0031 ns |  1.9281 ns |  0.62 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.1860 ns | 0.0060 ns | 0.0056 ns |  4.1854 ns |  1.34 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5077 ns | 0.0046 ns | 0.0043 ns |  3.5081 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.6565 ns | 0.0052 ns | 0.0046 ns |  3.6557 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.6882 ns | 0.0037 ns | 0.0035 ns |  2.6882 ns |  0.74 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  2.3671 ns | 0.0048 ns | 0.0040 ns |  2.3667 ns |  0.65 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.0095 ns | 0.0061 ns | 0.0051 ns |  4.0086 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.0069 ns | 0.0083 ns | 0.0074 ns |  4.0073 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.1542 ns | 0.0120 ns | 0.0100 ns |  3.1565 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  1.9402 ns | 0.0023 ns | 0.0019 ns |  1.9406 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.9523 ns | 0.0026 ns | 0.0024 ns |  1.9523 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2368 ns | 0.0240 ns | 0.0225 ns |  3.2227 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2407 ns | 0.0179 ns | 0.0167 ns |  3.2316 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.6089 ns | 0.0054 ns | 0.0051 ns |  4.6090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.0806 ns | 0.0042 ns | 0.0037 ns |  3.0812 ns |  0.67 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.1164 ns | 0.0058 ns | 0.0051 ns |  3.1160 ns |  0.68 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.5340 ns | 0.0067 ns | 0.0063 ns |  4.5323 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.4730 ns | 0.0061 ns | 0.0057 ns |  4.4729 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.9702 ns | 0.0178 ns | 0.0167 ns | 12.9720 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 12.9407 ns | 0.0140 ns | 0.0124 ns | 12.9393 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6446 ns | 0.0416 ns | 0.0389 ns |  5.6705 ns |  0.44 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.1817 ns | 0.0147 ns | 0.0137 ns | 13.1815 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.1602 ns | 0.0142 ns | 0.0126 ns | 13.1566 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.1499 ns | 0.0173 ns | 0.0162 ns | 24.1511 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.4348 ns | 0.1251 ns | 0.1170 ns | 23.3748 ns |  0.97 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.3619 ns | 0.1026 ns | 0.0960 ns | 12.3149 ns |  0.51 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 23.6990 ns | 0.1106 ns | 0.1035 ns | 23.7482 ns |  0.98 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 23.5452 ns | 0.0205 ns | 0.0192 ns | 23.5508 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6869 ns | 0.0030 ns | 0.0028 ns |  0.6869 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6763 ns | 0.0030 ns | 0.0028 ns |  0.6769 ns |  0.98 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7061 ns | 0.0026 ns | 0.0023 ns |  0.7066 ns |  1.03 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.4503 ns | 0.0021 ns | 0.0020 ns |  0.4502 ns |  0.66 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6578 ns | 0.0024 ns | 0.0022 ns |  0.6583 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.3969 ns | 0.0021 ns | 0.0019 ns |  1.3967 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.3803 ns | 0.0030 ns | 0.0026 ns |  1.3807 ns |  0.99 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.2288 ns | 0.0088 ns | 0.0082 ns |  1.2314 ns |  0.88 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6331 ns | 0.0055 ns | 0.0051 ns |  1.6331 ns |  1.17 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6916 ns | 0.0036 ns | 0.0032 ns |  1.6919 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2327 ns | 0.0035 ns | 0.0031 ns |  2.2321 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2449 ns | 0.0211 ns | 0.0198 ns |  2.2314 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.2850 ns | 0.0023 ns | 0.0020 ns |  2.2851 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2153 ns | 0.0156 ns | 0.0146 ns |  2.2067 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2137 ns | 0.0160 ns | 0.0149 ns |  2.2049 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.9126 ns | 0.1018 ns | 0.0952 ns | 46.8887 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 40.3575 ns | 0.0574 ns | 0.0537 ns | 40.3691 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.3017 ns | 0.0395 ns | 0.0350 ns | 10.2933 ns |  0.22 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 45.6758 ns | 0.0626 ns | 0.0586 ns | 45.6684 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.3404 ns | 0.0550 ns | 0.0488 ns | 46.3453 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.2915 ns | 0.0015 ns | 0.0014 ns |  1.2919 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.1458 ns | 0.0017 ns | 0.0014 ns |  1.1461 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6354 ns | 0.0046 ns | 0.0043 ns |  0.6368 ns |  0.49 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.5974 ns | 0.0072 ns | 0.0068 ns |  1.5956 ns |  1.24 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.5902 ns | 0.0029 ns | 0.0027 ns |  1.5904 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8377 ns | 0.0041 ns | 0.0032 ns |  1.8377 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.6163 ns | 0.0111 ns | 0.0098 ns |  1.6201 ns |  0.88 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  0.8582 ns | 0.0016 ns | 0.0015 ns |  0.8580 ns |  0.47 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.0661 ns | 0.0101 ns | 0.0090 ns |  2.0681 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.2588 ns | 0.0166 ns | 0.0155 ns |  2.2477 ns |  1.23 |    0.01 |     - |     - |     - |         - |
