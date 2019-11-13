
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
             FromBool | .NET Core 2.0 |  0.7126 ns | 0.0023 ns | 0.0021 ns |  0.7134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9486 ns | 0.0126 ns | 0.0118 ns |  0.9442 ns |  1.33 |    0.02 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.0362 ns | 0.0507 ns | 0.0888 ns |  1.0246 ns |  1.44 |    0.11 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9387 ns | 0.0021 ns | 0.0020 ns |  0.9383 ns |  1.32 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6632 ns | 0.0057 ns | 0.0051 ns |  0.6617 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9472 ns | 0.0025 ns | 0.0024 ns |  0.9469 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9494 ns | 0.0026 ns | 0.0022 ns |  0.9491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.8863 ns | 0.0027 ns | 0.0026 ns |  0.8854 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9284 ns | 0.0027 ns | 0.0026 ns |  1.9279 ns |  2.04 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.8930 ns | 0.0028 ns | 0.0025 ns |  1.8932 ns |  2.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6949 ns | 0.0016 ns | 0.0013 ns |  0.6947 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.9628 ns | 0.0060 ns | 0.0056 ns |  0.9642 ns |  1.39 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.8746 ns | 0.0027 ns | 0.0022 ns |  0.8755 ns |  1.26 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7294 ns | 0.0023 ns | 0.0019 ns |  0.7299 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6291 ns | 0.0098 ns | 0.0092 ns |  0.6321 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9928 ns | 0.0030 ns | 0.0028 ns |  0.9922 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1818 ns | 0.0029 ns | 0.0025 ns |  1.1820 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0564 ns | 0.0034 ns | 0.0032 ns |  1.0568 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9109 ns | 0.0026 ns | 0.0023 ns |  1.9113 ns |  1.92 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.8789 ns | 0.0027 ns | 0.0024 ns |  1.8782 ns |  1.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5339 ns | 0.0022 ns | 0.0020 ns |  0.5342 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7199 ns | 0.0036 ns | 0.0034 ns |  0.7189 ns |  1.35 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.8752 ns | 0.0021 ns | 0.0019 ns |  0.8747 ns |  1.64 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7080 ns | 0.0024 ns | 0.0022 ns |  0.7084 ns |  1.33 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5734 ns | 0.0120 ns | 0.0112 ns |  0.5764 ns |  1.07 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.9650 ns | 0.0022 ns | 0.0020 ns |  0.9656 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1930 ns | 0.0035 ns | 0.0033 ns |  1.1929 ns |  1.24 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1279 ns | 0.0111 ns | 0.0104 ns |  1.1230 ns |  1.17 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9255 ns | 0.0034 ns | 0.0032 ns |  1.9254 ns |  2.00 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.8920 ns | 0.0030 ns | 0.0028 ns |  1.8911 ns |  1.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7158 ns | 0.0022 ns | 0.0020 ns |  0.7162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7062 ns | 0.0019 ns | 0.0018 ns |  0.7067 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6304 ns | 0.0026 ns | 0.0025 ns |  0.6301 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7054 ns | 0.0011 ns | 0.0009 ns |  0.7054 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  1.3382 ns | 0.0023 ns | 0.0018 ns |  1.3385 ns |  1.87 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9570 ns | 0.0027 ns | 0.0025 ns |  0.9575 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1717 ns | 0.0054 ns | 0.0051 ns |  1.1722 ns |  1.22 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.4886 ns | 0.0568 ns | 0.1316 ns |  1.4971 ns |  1.54 |    0.15 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9344 ns | 0.0033 ns | 0.0029 ns |  1.9344 ns |  2.02 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9051 ns | 0.0175 ns | 0.0164 ns |  1.9123 ns |  1.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6680 ns | 0.0026 ns | 0.0023 ns |  0.6676 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7104 ns | 0.0027 ns | 0.0026 ns |  0.7109 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6372 ns | 0.0054 ns | 0.0051 ns |  0.6365 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7069 ns | 0.0026 ns | 0.0025 ns |  0.7071 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6244 ns | 0.0018 ns | 0.0017 ns |  0.6241 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.1780 ns | 0.0078 ns | 0.0073 ns |  1.1759 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.0736 ns | 0.0033 ns | 0.0030 ns |  1.0732 ns |  0.91 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1043 ns | 0.0029 ns | 0.0027 ns |  1.1047 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.0474 ns | 0.0030 ns | 0.0028 ns |  2.0468 ns |  1.74 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.8762 ns | 0.0024 ns | 0.0023 ns |  1.8760 ns |  1.59 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6875 ns | 0.0024 ns | 0.0021 ns |  0.6869 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9663 ns | 0.0058 ns | 0.0051 ns |  0.9679 ns |  1.41 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5448 ns | 0.0027 ns | 0.0026 ns |  0.5447 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7313 ns | 0.0035 ns | 0.0032 ns |  0.7315 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6456 ns | 0.0099 ns | 0.0093 ns |  0.6502 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9499 ns | 0.0029 ns | 0.0026 ns |  0.9511 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1796 ns | 0.0027 ns | 0.0024 ns |  1.1804 ns |  1.24 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1853 ns | 0.0107 ns | 0.0100 ns |  1.1906 ns |  1.25 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9102 ns | 0.0041 ns | 0.0038 ns |  1.9097 ns |  2.01 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.8759 ns | 0.0026 ns | 0.0025 ns |  1.8755 ns |  1.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.5284 ns | 0.0028 ns | 0.0026 ns |  0.5284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.7068 ns | 0.0039 ns | 0.0034 ns |  0.7063 ns |  1.34 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.6739 ns | 0.0016 ns | 0.0015 ns |  0.6738 ns |  1.28 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.5661 ns | 0.0022 ns | 0.0021 ns |  0.5662 ns |  1.07 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.5610 ns | 0.0122 ns | 0.0108 ns |  0.5559 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.9522 ns | 0.0022 ns | 0.0019 ns |  0.9527 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.1930 ns | 0.0073 ns | 0.0065 ns |  1.1954 ns |  1.25 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0658 ns | 0.0276 ns | 0.0258 ns |  1.0538 ns |  1.12 |    0.03 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9093 ns | 0.0037 ns | 0.0034 ns |  1.9092 ns |  2.01 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.8789 ns | 0.0014 ns | 0.0013 ns |  1.8792 ns |  1.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7166 ns | 0.0039 ns | 0.0036 ns |  0.7172 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6728 ns | 0.0020 ns | 0.0018 ns |  0.6726 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6673 ns | 0.0024 ns | 0.0023 ns |  0.6668 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.6563 ns | 0.0025 ns | 0.0022 ns |  0.6559 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7194 ns | 0.0077 ns | 0.0072 ns |  0.7155 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.3730 ns | 0.0025 ns | 0.0023 ns |  1.3727 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1486 ns | 0.0030 ns | 0.0028 ns |  1.1486 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0468 ns | 0.0016 ns | 0.0015 ns |  1.0467 ns |  0.76 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.8807 ns | 0.0035 ns | 0.0033 ns |  1.8807 ns |  1.37 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.4451 ns | 0.0029 ns | 0.0027 ns |  2.4451 ns |  1.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.4785 ns | 0.0080 ns | 0.0062 ns |  0.4810 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.6942 ns | 0.0082 ns | 0.0076 ns |  0.6970 ns |  1.45 |    0.02 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7049 ns | 0.0037 ns | 0.0031 ns |  0.7056 ns |  1.47 |    0.02 |     - |     - |     - |         - |
             FromLong |        net461 |  0.6582 ns | 0.0031 ns | 0.0028 ns |  0.6587 ns |  1.38 |    0.02 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6934 ns | 0.0015 ns | 0.0014 ns |  0.6933 ns |  1.45 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.1451 ns | 0.0028 ns | 0.0026 ns |  1.1451 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.1056 ns | 0.0030 ns | 0.0026 ns |  1.1058 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.2439 ns | 0.0033 ns | 0.0026 ns |  1.2444 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.1524 ns | 0.0113 ns | 0.0106 ns |  1.1476 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.1740 ns | 0.0109 ns | 0.0102 ns |  1.1694 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4229 ns | 0.0068 ns | 0.0061 ns |  1.4214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.3756 ns | 0.0022 ns | 0.0017 ns |  1.3755 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7240 ns | 0.0026 ns | 0.0021 ns |  0.7241 ns |  0.51 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7028 ns | 0.0030 ns | 0.0028 ns |  1.7024 ns |  1.20 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7318 ns | 0.0033 ns | 0.0031 ns |  1.7321 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9443 ns | 0.0062 ns | 0.0058 ns |  1.9449 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9820 ns | 0.0091 ns | 0.0085 ns |  1.9842 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.4838 ns | 0.0039 ns | 0.0036 ns |  1.4825 ns |  0.76 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9594 ns | 0.0036 ns | 0.0033 ns |  1.9603 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9022 ns | 0.0022 ns | 0.0019 ns |  1.9013 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5181 ns | 0.0057 ns | 0.0050 ns |  3.5188 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.1557 ns | 0.0031 ns | 0.0029 ns |  2.1551 ns |  0.61 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.9757 ns | 0.0022 ns | 0.0020 ns |  1.9756 ns |  0.56 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.3084 ns | 0.0062 ns | 0.0058 ns |  3.3079 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.3267 ns | 0.0054 ns | 0.0045 ns |  3.3272 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8481 ns | 0.0025 ns | 0.0022 ns |  1.8483 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7914 ns | 0.0044 ns | 0.0041 ns |  1.7906 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.6739 ns | 0.0033 ns | 0.0028 ns |  1.6742 ns |  0.91 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.8803 ns | 0.0028 ns | 0.0026 ns |  1.8810 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9057 ns | 0.0029 ns | 0.0027 ns |  1.9064 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.0126 ns | 0.0053 ns | 0.0049 ns |  3.0123 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  1.9264 ns | 0.0041 ns | 0.0039 ns |  1.9268 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.5957 ns | 0.0774 ns | 0.1546 ns |  2.6562 ns |  0.88 |    0.04 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2303 ns | 0.0068 ns | 0.0063 ns |  3.2297 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2610 ns | 0.0063 ns | 0.0059 ns |  3.2608 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  2.0069 ns | 0.0308 ns | 0.0273 ns |  2.0090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.8461 ns | 0.0028 ns | 0.0026 ns |  1.8463 ns |  0.92 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.8783 ns | 0.0030 ns | 0.0028 ns |  1.8787 ns |  0.94 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.0686 ns | 0.0037 ns | 0.0034 ns |  2.0681 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1043 ns | 0.0142 ns | 0.0133 ns |  2.1119 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.3672 ns | 0.0115 ns | 0.0108 ns | 13.3663 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.4166 ns | 0.0812 ns | 0.0760 ns | 13.4410 ns |  1.00 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.7636 ns | 0.0062 ns | 0.0049 ns |  5.7633 ns |  0.43 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.4389 ns | 0.0186 ns | 0.0174 ns | 13.4364 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.4519 ns | 0.0113 ns | 0.0100 ns | 13.4508 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.1998 ns | 0.0184 ns | 0.0172 ns |  8.2027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  9.0982 ns | 0.0113 ns | 0.0105 ns |  9.0981 ns |  1.11 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5636 ns | 0.0029 ns | 0.0027 ns |  2.5631 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.1367 ns | 0.0132 ns | 0.0123 ns |  9.1309 ns |  1.11 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.2138 ns | 0.0160 ns | 0.0149 ns |  9.2169 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6901 ns | 0.0022 ns | 0.0020 ns |  0.6902 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6930 ns | 0.0018 ns | 0.0015 ns |  0.6931 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7178 ns | 0.0017 ns | 0.0015 ns |  0.7177 ns |  1.04 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.8837 ns | 0.0031 ns | 0.0028 ns |  0.8838 ns |  1.28 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9213 ns | 0.0026 ns | 0.0023 ns |  0.9213 ns |  1.34 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.5116 ns | 0.0043 ns | 0.0040 ns |  1.5104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6518 ns | 0.0190 ns | 0.0178 ns |  1.6632 ns |  1.09 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5023 ns | 0.0020 ns | 0.0019 ns |  1.5017 ns |  0.99 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6250 ns | 0.0055 ns | 0.0051 ns |  1.6249 ns |  1.07 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.8909 ns | 0.0025 ns | 0.0023 ns |  1.8914 ns |  1.25 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.5376 ns | 0.0757 ns | 0.0671 ns |  3.5287 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8603 ns | 0.0033 ns | 0.0031 ns |  2.8604 ns |  0.81 |    0.02 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7009 ns | 0.0050 ns | 0.0047 ns |  2.7015 ns |  0.76 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8396 ns | 0.0046 ns | 0.0043 ns |  2.8391 ns |  0.80 |    0.02 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8601 ns | 0.0037 ns | 0.0035 ns |  2.8599 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8306 ns | 0.0040 ns | 0.0037 ns |  1.8315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.9480 ns | 0.0027 ns | 0.0025 ns |  1.9480 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.8788 ns | 0.0027 ns | 0.0024 ns |  1.8790 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.7719 ns | 0.0057 ns | 0.0054 ns |  1.7724 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.8066 ns | 0.0098 ns | 0.0087 ns |  1.8036 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7185 ns | 0.0022 ns | 0.0020 ns |  0.7186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6760 ns | 0.0100 ns | 0.0094 ns |  0.6810 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6745 ns | 0.0023 ns | 0.0021 ns |  0.6749 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.6618 ns | 0.0023 ns | 0.0022 ns |  0.6622 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7093 ns | 0.0029 ns | 0.0027 ns |  0.7096 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.9588 ns | 0.0023 ns | 0.0022 ns |  0.9581 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1680 ns | 0.0032 ns | 0.0030 ns |  1.1681 ns |  1.22 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0557 ns | 0.0026 ns | 0.0025 ns |  1.0568 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.8807 ns | 0.0040 ns | 0.0036 ns |  1.8824 ns |  1.96 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9073 ns | 0.0035 ns | 0.0033 ns |  1.9073 ns |  1.99 |    0.01 |     - |     - |     - |         - |
