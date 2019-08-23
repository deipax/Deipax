
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
             FromBool | .NET Core 2.0 |  0.7153 ns | 0.0128 ns | 0.0120 ns |  0.7106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9230 ns | 0.0045 ns | 0.0042 ns |  0.9226 ns |  1.29 |    0.02 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1644 ns | 0.0023 ns | 0.0021 ns |  1.1633 ns |  1.63 |    0.03 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1495 ns | 0.0018 ns | 0.0017 ns |  1.1497 ns |  1.61 |    0.03 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1520 ns | 0.0033 ns | 0.0029 ns |  1.1520 ns |  1.61 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1620 ns | 0.0121 ns | 0.0113 ns |  1.1601 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1425 ns | 0.0050 ns | 0.0044 ns |  1.1424 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1670 ns | 0.0035 ns | 0.0030 ns |  1.1669 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6607 ns | 0.0037 ns | 0.0034 ns |  1.6596 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6393 ns | 0.0029 ns | 0.0027 ns |  1.6401 ns |  1.41 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.4614 ns | 0.0120 ns | 0.0112 ns |  0.4589 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4437 ns | 0.0014 ns | 0.0013 ns |  0.4440 ns |  0.96 |    0.02 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7069 ns | 0.0017 ns | 0.0016 ns |  0.7073 ns |  1.53 |    0.04 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6998 ns | 0.0018 ns | 0.0017 ns |  0.6995 ns |  1.52 |    0.04 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7016 ns | 0.0015 ns | 0.0012 ns |  0.7022 ns |  1.52 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9266 ns | 0.0150 ns | 0.0141 ns |  0.9241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9083 ns | 0.0063 ns | 0.0059 ns |  0.9072 ns |  0.98 |    0.02 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1676 ns | 0.0018 ns | 0.0017 ns |  1.1672 ns |  1.26 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.6236 ns | 0.0023 ns | 0.0022 ns |  1.6241 ns |  1.75 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6217 ns | 0.0030 ns | 0.0028 ns |  1.6217 ns |  1.75 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  2.0808 ns | 0.0297 ns | 0.0278 ns |  2.0847 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.1068 ns | 0.0070 ns | 0.0065 ns |  1.1081 ns |  0.53 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7086 ns | 0.0023 ns | 0.0019 ns |  0.7090 ns |  0.34 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.6336 ns | 0.0036 ns | 0.0034 ns |  1.6337 ns |  0.79 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.6389 ns | 0.0024 ns | 0.0021 ns |  1.6388 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.4682 ns | 0.0164 ns | 0.0153 ns |  1.4699 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.4568 ns | 0.0024 ns | 0.0022 ns |  1.4569 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9492 ns | 0.0016 ns | 0.0014 ns |  0.9489 ns |  0.65 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.3252 ns | 0.0030 ns | 0.0028 ns |  2.3259 ns |  1.58 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.3322 ns | 0.0107 ns | 0.0100 ns |  2.3290 ns |  1.59 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.4914 ns | 0.0117 ns | 0.0109 ns |  0.4857 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4410 ns | 0.0015 ns | 0.0014 ns |  0.4412 ns |  0.90 |    0.02 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.4942 ns | 0.0015 ns | 0.0014 ns |  0.4948 ns |  1.01 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7112 ns | 0.0094 ns | 0.0087 ns |  0.7150 ns |  1.45 |    0.04 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7229 ns | 0.0027 ns | 0.0025 ns |  0.7243 ns |  1.47 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9513 ns | 0.0131 ns | 0.0122 ns |  0.9500 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.6843 ns | 0.0026 ns | 0.0024 ns |  0.6841 ns |  0.72 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9570 ns | 0.0046 ns | 0.0043 ns |  0.9573 ns |  1.01 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6643 ns | 0.0024 ns | 0.0022 ns |  1.6647 ns |  1.75 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6603 ns | 0.0030 ns | 0.0028 ns |  1.6598 ns |  1.75 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.1231 ns | 0.0165 ns | 0.0155 ns |  1.1276 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.0725 ns | 0.0019 ns | 0.0016 ns |  1.0724 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7061 ns | 0.0014 ns | 0.0013 ns |  0.7063 ns |  0.63 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  1.6310 ns | 0.0038 ns | 0.0035 ns |  1.6313 ns |  1.45 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 |  1.6286 ns | 0.0023 ns | 0.0020 ns |  1.6289 ns |  1.45 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.6110 ns | 0.0216 ns | 0.0202 ns |  1.6113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.5987 ns | 0.0032 ns | 0.0030 ns |  1.5979 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1779 ns | 0.0128 ns | 0.0120 ns |  1.1849 ns |  0.73 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.5871 ns | 0.0235 ns | 0.0220 ns |  2.5966 ns |  1.61 |    0.03 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.5322 ns | 0.0061 ns | 0.0057 ns |  2.5330 ns |  1.57 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.4702 ns | 0.0091 ns | 0.0085 ns |  0.4671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.4436 ns | 0.0009 ns | 0.0008 ns |  0.4434 ns |  0.94 |    0.02 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.4946 ns | 0.0013 ns | 0.0012 ns |  0.4950 ns |  1.05 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6998 ns | 0.0026 ns | 0.0023 ns |  0.6999 ns |  1.49 |    0.03 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6994 ns | 0.0021 ns | 0.0019 ns |  0.6998 ns |  1.49 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0248 ns | 0.0571 ns | 0.0477 ns |  1.0155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.9106 ns | 0.0030 ns | 0.0027 ns |  0.9103 ns |  0.89 |    0.04 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9372 ns | 0.0018 ns | 0.0016 ns |  0.9371 ns |  0.92 |    0.04 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9455 ns | 0.0031 ns | 0.0029 ns |  1.9456 ns |  1.90 |    0.08 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.4122 ns | 0.0032 ns | 0.0030 ns |  1.4128 ns |  1.38 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.6306 ns | 0.0445 ns | 0.0416 ns |  1.6252 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.6005 ns | 0.0022 ns | 0.0020 ns |  1.6004 ns |  0.98 |    0.02 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6495 ns | 0.0107 ns | 0.0100 ns |  1.6535 ns |  1.01 |    0.02 |     - |     - |     - |         - |
              FromInt |        net461 |  1.8768 ns | 0.0055 ns | 0.0051 ns |  1.8778 ns |  1.15 |    0.03 |     - |     - |     - |         - |
              FromInt |        net472 |  1.8677 ns | 0.0028 ns | 0.0026 ns |  1.8673 ns |  1.15 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.1516 ns | 0.0085 ns | 0.0066 ns |  2.1508 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.0057 ns | 0.0026 ns | 0.0021 ns |  2.0057 ns |  0.93 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.8647 ns | 0.0020 ns | 0.0018 ns |  1.8646 ns |  0.87 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.7904 ns | 0.0050 ns | 0.0047 ns |  2.7908 ns |  1.30 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.7979 ns | 0.0040 ns | 0.0034 ns |  2.7979 ns |  1.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  2.0643 ns | 0.0064 ns | 0.0057 ns |  2.0623 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.1642 ns | 0.0142 ns | 0.0133 ns |  1.1679 ns |  0.56 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7060 ns | 0.0022 ns | 0.0021 ns |  0.7064 ns |  0.34 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.8590 ns | 0.0033 ns | 0.0030 ns |  1.8594 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8738 ns | 0.0151 ns | 0.0141 ns |  1.8677 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.7056 ns | 0.0097 ns | 0.0086 ns |  1.7061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.5976 ns | 0.0029 ns | 0.0027 ns |  1.5971 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1664 ns | 0.0078 ns | 0.0069 ns |  1.1631 ns |  0.68 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.7865 ns | 0.0031 ns | 0.0029 ns |  2.7867 ns |  1.63 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.7830 ns | 0.0041 ns | 0.0036 ns |  2.7825 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.6603 ns | 0.0601 ns | 0.0668 ns |  1.6265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8757 ns | 0.0027 ns | 0.0025 ns |  1.8756 ns |  1.12 |    0.05 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  2.3553 ns | 0.0731 ns | 0.1821 ns |  2.3769 ns |  1.43 |    0.14 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6497 ns | 0.0028 ns | 0.0025 ns |  1.6506 ns |  0.99 |    0.04 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7719 ns | 0.0060 ns | 0.0056 ns |  1.7729 ns |  1.06 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.7105 ns | 0.0330 ns | 0.0275 ns |  2.7224 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.9299 ns | 0.0182 ns | 0.0161 ns |  2.9340 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.9106 ns | 0.0103 ns | 0.0092 ns |  2.9130 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.0135 ns | 0.0039 ns | 0.0034 ns |  3.0143 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.8252 ns | 0.0032 ns | 0.0030 ns |  2.8244 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.6078 ns | 0.0016 ns | 0.0015 ns |  1.6073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.4969 ns | 0.0041 ns | 0.0032 ns |  1.4970 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6269 ns | 0.0120 ns | 0.0112 ns |  1.6329 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6451 ns | 0.0036 ns | 0.0034 ns |  1.6467 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6582 ns | 0.0036 ns | 0.0034 ns |  1.6582 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.8974 ns | 0.0170 ns | 0.0159 ns |  2.9040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.0340 ns | 0.0058 ns | 0.0055 ns |  3.0350 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.8928 ns | 0.0036 ns | 0.0034 ns |  2.8928 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.5961 ns | 0.0051 ns | 0.0045 ns |  2.5957 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.6013 ns | 0.0102 ns | 0.0095 ns |  2.5985 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.6401 ns | 0.0084 ns | 0.0074 ns |  3.6403 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.7893 ns | 0.0062 ns | 0.0052 ns |  3.7900 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.1029 ns | 0.0067 ns | 0.0063 ns |  4.1016 ns |  1.13 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.7997 ns | 0.0058 ns | 0.0051 ns |  3.8002 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.8862 ns | 0.0074 ns | 0.0066 ns |  3.8859 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.3601 ns | 0.0214 ns | 0.0201 ns |  4.3475 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.2101 ns | 0.0050 ns | 0.0044 ns |  4.2095 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.5436 ns | 0.0377 ns | 0.0353 ns |  4.5565 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.2061 ns | 0.0064 ns | 0.0060 ns |  4.2071 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.1874 ns | 0.0079 ns | 0.0074 ns |  4.1860 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.7204 ns | 0.0141 ns | 0.0132 ns |  3.7163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.3070 ns | 0.0044 ns | 0.0039 ns |  3.3077 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.1523 ns | 0.0038 ns | 0.0035 ns |  4.1524 ns |  1.12 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.5394 ns | 0.0059 ns | 0.0055 ns |  3.5401 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.5402 ns | 0.0072 ns | 0.0067 ns |  3.5390 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.1585 ns | 0.0097 ns | 0.0086 ns |  5.1593 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.7643 ns | 0.0055 ns | 0.0052 ns |  4.7627 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  5.1291 ns | 0.0055 ns | 0.0052 ns |  5.1297 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.6985 ns | 0.0070 ns | 0.0062 ns |  4.6971 ns |  0.91 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.7385 ns | 0.0139 ns | 0.0130 ns |  4.7399 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.5119 ns | 0.0145 ns | 0.0136 ns | 13.5070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.5385 ns | 0.0698 ns | 0.0653 ns | 13.5774 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.2753 ns | 0.0779 ns | 0.0729 ns |  7.3190 ns |  0.54 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.7373 ns | 0.0215 ns | 0.0201 ns | 13.7410 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.7308 ns | 0.0194 ns | 0.0182 ns | 13.7383 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.9964 ns | 0.0842 ns | 0.0788 ns | 24.0361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.9901 ns | 0.0197 ns | 0.0184 ns | 23.9884 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.0599 ns | 0.1419 ns | 0.1327 ns | 12.9557 ns |  0.54 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.4302 ns | 0.0271 ns | 0.0253 ns | 24.4354 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.2115 ns | 0.0320 ns | 0.0299 ns | 24.2221 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6637 ns | 0.0056 ns | 0.0052 ns |  0.6618 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.4328 ns | 0.0014 ns | 0.0013 ns |  0.4326 ns |  0.65 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.9083 ns | 0.0106 ns | 0.0099 ns |  0.9122 ns |  1.37 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7365 ns | 0.0022 ns | 0.0021 ns |  0.7365 ns |  1.11 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7412 ns | 0.0024 ns | 0.0023 ns |  0.7413 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4581 ns | 0.0045 ns | 0.0040 ns |  1.4584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4313 ns | 0.0049 ns | 0.0038 ns |  1.4310 ns |  0.98 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.3800 ns | 0.0018 ns | 0.0016 ns |  1.3800 ns |  0.95 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4109 ns | 0.0030 ns | 0.0027 ns |  1.4101 ns |  0.97 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6068 ns | 0.0598 ns | 0.0689 ns |  1.6021 ns |  1.10 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2030 ns | 0.0035 ns | 0.0033 ns |  2.2029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2100 ns | 0.0031 ns | 0.0029 ns |  2.2097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.0693 ns | 0.0026 ns | 0.0022 ns |  2.0689 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.4308 ns | 0.0044 ns | 0.0034 ns |  2.4315 ns |  1.10 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8888 ns | 0.0064 ns | 0.0060 ns |  2.8869 ns |  1.31 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.9550 ns | 0.2139 ns | 0.2001 ns | 46.9415 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 42.1414 ns | 0.0452 ns | 0.0423 ns | 42.1210 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.4718 ns | 0.0175 ns | 0.0164 ns |  8.4741 ns |  0.18 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.5330 ns | 0.0656 ns | 0.0581 ns | 46.5374 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.9187 ns | 0.1025 ns | 0.0959 ns | 46.9334 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.5751 ns | 0.0036 ns | 0.0028 ns |  1.5746 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.5991 ns | 0.0115 ns | 0.0108 ns |  1.5941 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.6262 ns | 0.0029 ns | 0.0026 ns |  1.6254 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6461 ns | 0.0041 ns | 0.0036 ns |  1.6460 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.6541 ns | 0.0045 ns | 0.0038 ns |  1.6551 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.9854 ns | 0.0029 ns | 0.0027 ns |  1.9851 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.9917 ns | 0.0041 ns | 0.0038 ns |  1.9926 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.8635 ns | 0.0028 ns | 0.0026 ns |  1.8636 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.2662 ns | 0.0035 ns | 0.0031 ns |  2.2662 ns |  1.14 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.2337 ns | 0.0073 ns | 0.0069 ns |  2.2361 ns |  1.13 |    0.00 |     - |     - |     - |         - |
