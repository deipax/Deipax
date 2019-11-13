
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
             FromBool | .NET Core 2.0 |  1.2340 ns | 0.0044 ns | 0.0037 ns |  1.2327 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9261 ns | 0.0063 ns | 0.0059 ns |  0.9242 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7110 ns | 0.0026 ns | 0.0024 ns |  0.7113 ns |  0.58 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6671 ns | 0.0023 ns | 0.0022 ns |  0.6665 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9294 ns | 0.0028 ns | 0.0026 ns |  0.9290 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1571 ns | 0.0065 ns | 0.0058 ns |  1.1584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1619 ns | 0.0041 ns | 0.0036 ns |  1.1614 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9601 ns | 0.0108 ns | 0.0101 ns |  0.9642 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.8930 ns | 0.0017 ns | 0.0014 ns |  1.8931 ns |  1.64 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9199 ns | 0.0042 ns | 0.0038 ns |  1.9207 ns |  1.66 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9150 ns | 0.0024 ns | 0.0021 ns |  0.9152 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6947 ns | 0.0022 ns | 0.0021 ns |  0.6945 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5890 ns | 0.0033 ns | 0.0031 ns |  0.5890 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6634 ns | 0.0018 ns | 0.0017 ns |  0.6634 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.9361 ns | 0.0042 ns | 0.0039 ns |  0.9371 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1579 ns | 0.0027 ns | 0.0025 ns |  1.1572 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1835 ns | 0.0028 ns | 0.0026 ns |  1.1841 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0974 ns | 0.0047 ns | 0.0044 ns |  1.0979 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.8776 ns | 0.0027 ns | 0.0024 ns |  1.8775 ns |  1.62 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.1074 ns | 0.0033 ns | 0.0029 ns |  2.1078 ns |  1.82 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3744 ns | 0.0017 ns | 0.0016 ns |  1.3746 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3228 ns | 0.0037 ns | 0.0035 ns |  1.3230 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7059 ns | 0.0022 ns | 0.0021 ns |  0.7063 ns |  0.51 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7109 ns | 0.0020 ns | 0.0019 ns |  1.7107 ns |  1.24 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.9365 ns | 0.0045 ns | 0.0042 ns |  1.9361 ns |  1.41 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.6695 ns | 0.0056 ns | 0.0052 ns |  1.6695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.7569 ns | 0.0037 ns | 0.0034 ns |  1.7574 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9118 ns | 0.0023 ns | 0.0021 ns |  0.9117 ns |  0.55 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9010 ns | 0.0046 ns | 0.0038 ns |  1.9019 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9376 ns | 0.0078 ns | 0.0073 ns |  1.9403 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9131 ns | 0.0023 ns | 0.0020 ns |  0.9131 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7113 ns | 0.0043 ns | 0.0040 ns |  0.7119 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5492 ns | 0.0017 ns | 0.0015 ns |  0.5486 ns |  0.60 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5431 ns | 0.0020 ns | 0.0016 ns |  0.5433 ns |  0.59 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7081 ns | 0.0024 ns | 0.0022 ns |  0.7086 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1478 ns | 0.0027 ns | 0.0024 ns |  1.1477 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1615 ns | 0.0039 ns | 0.0037 ns |  1.1628 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9479 ns | 0.0028 ns | 0.0026 ns |  0.9475 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9023 ns | 0.0029 ns | 0.0027 ns |  1.9031 ns |  1.66 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9211 ns | 0.0029 ns | 0.0027 ns |  1.9220 ns |  1.67 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3589 ns | 0.0056 ns | 0.0047 ns |  1.3583 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.3026 ns | 0.0042 ns | 0.0039 ns |  1.3024 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6016 ns | 0.0019 ns | 0.0017 ns |  0.6016 ns |  0.44 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.6998 ns | 0.0029 ns | 0.0024 ns |  1.6996 ns |  1.25 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8833 ns | 0.0151 ns | 0.0134 ns |  1.8878 ns |  1.39 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8301 ns | 0.0048 ns | 0.0040 ns |  1.8284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7393 ns | 0.0050 ns | 0.0044 ns |  1.7385 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0518 ns | 0.0045 ns | 0.0042 ns |  1.0513 ns |  0.58 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.8815 ns | 0.0029 ns | 0.0027 ns |  1.8814 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9039 ns | 0.0034 ns | 0.0029 ns |  1.9051 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9110 ns | 0.0036 ns | 0.0034 ns |  0.9101 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6958 ns | 0.0017 ns | 0.0016 ns |  0.6961 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5470 ns | 0.0022 ns | 0.0020 ns |  0.5472 ns |  0.60 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6165 ns | 0.0023 ns | 0.0019 ns |  0.6168 ns |  0.68 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6952 ns | 0.0022 ns | 0.0020 ns |  0.6956 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1686 ns | 0.0031 ns | 0.0029 ns |  1.1691 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1918 ns | 0.0027 ns | 0.0024 ns |  1.1923 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.2232 ns | 0.0043 ns | 0.0040 ns |  1.2227 ns |  1.05 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.1269 ns | 0.0034 ns | 0.0026 ns |  2.1271 ns |  1.82 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9213 ns | 0.0030 ns | 0.0028 ns |  1.9208 ns |  1.64 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.9638 ns | 0.0097 ns | 0.0090 ns |  1.9610 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.3625 ns | 0.0027 ns | 0.0025 ns |  1.3617 ns |  0.69 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7163 ns | 0.0033 ns | 0.0027 ns |  0.7161 ns |  0.36 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7011 ns | 0.0051 ns | 0.0040 ns |  1.7007 ns |  0.87 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7281 ns | 0.0038 ns | 0.0032 ns |  1.7290 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.9178 ns | 0.0046 ns | 0.0041 ns |  1.9178 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.8985 ns | 0.0028 ns | 0.0026 ns |  1.8993 ns |  0.99 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0484 ns | 0.0026 ns | 0.0025 ns |  1.0489 ns |  0.55 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.2578 ns | 0.0034 ns | 0.0032 ns |  2.2574 ns |  1.18 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9724 ns | 0.0054 ns | 0.0050 ns |  1.9733 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9216 ns | 0.0060 ns | 0.0056 ns |  0.9233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7047 ns | 0.0024 ns | 0.0022 ns |  0.7048 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7006 ns | 0.0027 ns | 0.0024 ns |  0.7014 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.5601 ns | 0.0028 ns | 0.0026 ns |  0.5602 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7240 ns | 0.0019 ns | 0.0018 ns |  0.7234 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  0.6894 ns | 0.0021 ns | 0.0020 ns |  0.6898 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  0.7069 ns | 0.0024 ns | 0.0023 ns |  0.7070 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.6573 ns | 0.0054 ns | 0.0048 ns |  0.6564 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.0745 ns | 0.0029 ns | 0.0027 ns |  1.0750 ns |  1.56 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  0.7145 ns | 0.0035 ns | 0.0031 ns |  0.7148 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8465 ns | 0.0028 ns | 0.0025 ns |  1.8476 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8565 ns | 0.0033 ns | 0.0031 ns |  1.8572 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.6790 ns | 0.0032 ns | 0.0028 ns |  1.6790 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6788 ns | 0.0042 ns | 0.0039 ns |  1.6781 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7040 ns | 0.0028 ns | 0.0025 ns |  1.7040 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7647 ns | 0.0074 ns | 0.0066 ns |  1.7660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7023 ns | 0.0037 ns | 0.0033 ns |  1.7024 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7901 ns | 0.0032 ns | 0.0030 ns |  1.7899 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.9820 ns | 0.0048 ns | 0.0045 ns |  1.9831 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.8926 ns | 0.0028 ns | 0.0026 ns |  1.8924 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.9177 ns | 0.0035 ns | 0.0033 ns |  1.9180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.3849 ns | 0.0031 ns | 0.0029 ns |  1.3853 ns |  0.72 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7083 ns | 0.0028 ns | 0.0026 ns |  0.7080 ns |  0.37 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7033 ns | 0.0034 ns | 0.0030 ns |  1.7041 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7317 ns | 0.0031 ns | 0.0027 ns |  1.7316 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9267 ns | 0.0036 ns | 0.0034 ns |  1.9268 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.4432 ns | 0.0762 ns | 0.2020 ns |  2.4800 ns |  1.20 |    0.10 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.4765 ns | 0.0117 ns | 0.0109 ns |  1.4708 ns |  0.77 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.8791 ns | 0.0037 ns | 0.0033 ns |  1.8796 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.1700 ns | 0.0044 ns | 0.0042 ns |  2.1707 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5538 ns | 0.0063 ns | 0.0059 ns |  3.5533 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4711 ns | 0.0050 ns | 0.0047 ns |  3.4714 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.4762 ns | 0.0044 ns | 0.0041 ns |  3.4746 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.4653 ns | 0.0221 ns | 0.0207 ns |  3.4526 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5291 ns | 0.0058 ns | 0.0054 ns |  3.5282 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8499 ns | 0.0041 ns | 0.0039 ns |  1.8496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7682 ns | 0.0037 ns | 0.0035 ns |  1.7690 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7022 ns | 0.0023 ns | 0.0019 ns |  1.7029 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.8778 ns | 0.0032 ns | 0.0030 ns |  1.8778 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9039 ns | 0.0022 ns | 0.0018 ns |  1.9047 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.6695 ns | 0.0039 ns | 0.0037 ns |  2.6685 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.5844 ns | 0.0051 ns | 0.0046 ns |  2.5822 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.0665 ns | 0.0063 ns | 0.0056 ns |  3.0672 ns |  1.15 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.5585 ns | 0.0053 ns | 0.0050 ns |  2.5592 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.5784 ns | 0.0043 ns | 0.0038 ns |  2.5788 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9257 ns | 0.0056 ns | 0.0047 ns |  1.9262 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9094 ns | 0.0249 ns | 0.0221 ns |  1.9070 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.8611 ns | 0.0023 ns | 0.0021 ns |  1.8608 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.0898 ns | 0.0032 ns | 0.0030 ns |  2.0896 ns |  1.09 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.0753 ns | 0.0065 ns | 0.0061 ns |  2.0776 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.0617 ns | 0.0209 ns | 0.0174 ns | 13.0632 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.0199 ns | 0.0184 ns | 0.0163 ns | 13.0222 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.7899 ns | 0.0083 ns | 0.0065 ns |  5.7890 ns |  0.44 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.1973 ns | 0.0125 ns | 0.0117 ns | 13.1967 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.1647 ns | 0.0149 ns | 0.0116 ns | 13.1645 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.5501 ns | 0.0154 ns | 0.0144 ns |  8.5544 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.5707 ns | 0.0201 ns | 0.0157 ns |  8.5736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5322 ns | 0.0165 ns | 0.0154 ns |  2.5249 ns |  0.30 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.2694 ns | 0.0275 ns | 0.0257 ns |  9.2585 ns |  1.08 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.6974 ns | 0.0176 ns | 0.0165 ns |  8.6988 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6892 ns | 0.0036 ns | 0.0034 ns |  0.6898 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7193 ns | 0.0023 ns | 0.0021 ns |  0.7201 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7381 ns | 0.0022 ns | 0.0020 ns |  0.7380 ns |  1.07 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6772 ns | 0.0020 ns | 0.0016 ns |  0.6772 ns |  0.98 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7514 ns | 0.0023 ns | 0.0022 ns |  0.7514 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.8181 ns | 0.0628 ns | 0.0723 ns |  1.8072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6503 ns | 0.0016 ns | 0.0014 ns |  1.6507 ns |  0.90 |    0.04 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4261 ns | 0.0030 ns | 0.0025 ns |  1.4259 ns |  0.78 |    0.03 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6433 ns | 0.0036 ns | 0.0034 ns |  1.6427 ns |  0.90 |    0.04 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6090 ns | 0.0021 ns | 0.0019 ns |  1.6093 ns |  0.88 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.9886 ns | 0.0025 ns | 0.0024 ns |  2.9885 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8336 ns | 0.0058 ns | 0.0055 ns |  2.8354 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.6936 ns | 0.0047 ns | 0.0037 ns |  2.6942 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8114 ns | 0.0061 ns | 0.0057 ns |  2.8117 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8636 ns | 0.0207 ns | 0.0194 ns |  2.8533 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8388 ns | 0.0031 ns | 0.0026 ns |  1.8377 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8822 ns | 0.0031 ns | 0.0029 ns |  1.8826 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9054 ns | 0.0039 ns | 0.0035 ns |  1.9044 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.8091 ns | 0.0135 ns | 0.0126 ns |  1.8128 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 |  1.7972 ns | 0.0028 ns | 0.0026 ns |  1.7976 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.4021 ns | 0.0023 ns | 0.0022 ns |  1.4023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.3978 ns | 0.0079 ns | 0.0074 ns |  1.3993 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7452 ns | 0.0025 ns | 0.0021 ns |  0.7455 ns |  0.53 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  2.0039 ns | 0.0032 ns | 0.0030 ns |  2.0038 ns |  1.43 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7306 ns | 0.0030 ns | 0.0024 ns |  1.7303 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8868 ns | 0.0035 ns | 0.0033 ns |  1.8868 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.1992 ns | 0.0034 ns | 0.0028 ns |  2.1998 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0931 ns | 0.0031 ns | 0.0029 ns |  1.0924 ns |  0.58 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.8914 ns | 0.0102 ns | 0.0096 ns |  1.8896 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9574 ns | 0.0019 ns | 0.0018 ns |  1.9574 ns |  1.04 |    0.00 |     - |     - |     - |         - |
