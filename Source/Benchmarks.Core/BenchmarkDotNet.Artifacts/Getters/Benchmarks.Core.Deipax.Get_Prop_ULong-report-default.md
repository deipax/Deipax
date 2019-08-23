
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  0.8565 ns | 0.0047 ns | 0.0042 ns |  0.8555 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4073 ns | 0.0033 ns | 0.0028 ns |  1.4081 ns |  1.64 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.3269 ns | 0.0041 ns | 0.0038 ns |  1.3266 ns |  1.55 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.9521 ns | 0.0022 ns | 0.0021 ns |  0.9519 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.6746 ns | 0.0038 ns | 0.0036 ns |  0.6742 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9760 ns | 0.0121 ns | 0.0107 ns |  3.9749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2282 ns | 0.0035 ns | 0.0031 ns |  4.2288 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9511 ns | 0.0056 ns | 0.0052 ns |  3.9509 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1607 ns | 0.0081 ns | 0.0072 ns |  4.1605 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1811 ns | 0.0060 ns | 0.0053 ns |  4.1831 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.0408 ns | 0.0057 ns | 0.0051 ns |  2.0406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.3790 ns | 0.0075 ns | 0.0070 ns |  2.3779 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.2580 ns | 0.0102 ns | 0.0096 ns |  2.2540 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  1.6489 ns | 0.0017 ns | 0.0015 ns |  1.6492 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.3635 ns | 0.0037 ns | 0.0031 ns |  1.3634 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.6641 ns | 0.0066 ns | 0.0062 ns |  4.6647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.8693 ns | 0.0076 ns | 0.0064 ns |  4.8721 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.4753 ns | 0.0070 ns | 0.0062 ns |  4.4764 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.6217 ns | 0.0060 ns | 0.0053 ns |  4.6202 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.6449 ns | 0.0065 ns | 0.0061 ns |  4.6447 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.1868 ns | 0.0030 ns | 0.0028 ns |  1.1868 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4625 ns | 0.0016 ns | 0.0014 ns |  1.4623 ns |  1.23 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.2052 ns | 0.0097 ns | 0.0091 ns |  1.2045 ns |  1.02 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6373 ns | 0.0033 ns | 0.0029 ns |  1.6374 ns |  1.38 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.5396 ns | 0.0033 ns | 0.0031 ns |  1.5393 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.0202 ns | 0.0059 ns | 0.0055 ns |  4.0197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1706 ns | 0.0049 ns | 0.0043 ns |  4.1699 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0065 ns | 0.0103 ns | 0.0091 ns |  4.0053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.6644 ns | 0.0173 ns | 0.0153 ns |  4.6673 ns |  1.16 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.6409 ns | 0.0082 ns | 0.0077 ns |  4.6374 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.2462 ns | 0.0026 ns | 0.0023 ns |  2.2462 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.6090 ns | 0.0060 ns | 0.0050 ns |  2.6061 ns |  1.16 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.2505 ns | 0.0039 ns | 0.0033 ns |  2.2511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6778 ns | 0.0030 ns | 0.0028 ns |  1.6779 ns |  0.75 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3784 ns | 0.0094 ns | 0.0083 ns |  1.3812 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.7142 ns | 0.0047 ns | 0.0041 ns |  4.7142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.8620 ns | 0.0083 ns | 0.0077 ns |  4.8630 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.4711 ns | 0.0068 ns | 0.0064 ns |  4.4720 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6180 ns | 0.0047 ns | 0.0039 ns |  4.6169 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6424 ns | 0.0043 ns | 0.0038 ns |  4.6421 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.2425 ns | 0.0064 ns | 0.0060 ns |  2.2408 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.3391 ns | 0.0043 ns | 0.0038 ns |  2.3387 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.1525 ns | 0.0055 ns | 0.0049 ns |  2.1520 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6501 ns | 0.0029 ns | 0.0027 ns |  1.6499 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.3616 ns | 0.0115 ns | 0.0102 ns |  1.3645 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.7178 ns | 0.0175 ns | 0.0164 ns |  4.7092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.8698 ns | 0.0084 ns | 0.0074 ns |  4.8693 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.5234 ns | 0.0053 ns | 0.0050 ns |  4.5254 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6111 ns | 0.0073 ns | 0.0065 ns |  4.6113 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6427 ns | 0.0047 ns | 0.0039 ns |  4.6431 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.2599 ns | 0.0064 ns | 0.0060 ns |  2.2592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.7288 ns | 0.0134 ns | 0.0118 ns |  2.7315 ns |  1.21 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.3354 ns | 0.0028 ns | 0.0027 ns |  2.3365 ns |  1.03 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.6552 ns | 0.0036 ns | 0.0034 ns |  1.6551 ns |  0.73 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.3661 ns | 0.0034 ns | 0.0031 ns |  1.3663 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.6733 ns | 0.0158 ns | 0.0140 ns |  4.6679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.8698 ns | 0.0148 ns | 0.0132 ns |  4.8668 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.4112 ns | 0.0067 ns | 0.0060 ns |  4.4121 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6185 ns | 0.0081 ns | 0.0067 ns |  4.6204 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6439 ns | 0.0058 ns | 0.0054 ns |  4.6434 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  2.3050 ns | 0.0041 ns | 0.0038 ns |  2.3047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.3335 ns | 0.0063 ns | 0.0056 ns |  2.3322 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.6178 ns | 0.0508 ns | 0.0451 ns |  2.6346 ns |  1.14 |    0.02 |      - |     - |     - |         - |
              ToInt |        net461 |  1.7178 ns | 0.0135 ns | 0.0120 ns |  1.7123 ns |  0.75 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.3641 ns | 0.0022 ns | 0.0018 ns |  1.3646 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.4574 ns | 0.0377 ns | 0.0352 ns |  4.4370 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.6464 ns | 0.0088 ns | 0.0078 ns |  4.6460 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.4207 ns | 0.0046 ns | 0.0041 ns |  4.4223 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6201 ns | 0.0096 ns | 0.0090 ns |  4.6209 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6917 ns | 0.0201 ns | 0.0188 ns |  4.6960 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.2560 ns | 0.0038 ns | 0.0036 ns |  1.2562 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4761 ns | 0.0038 ns | 0.0032 ns |  1.4757 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.1735 ns | 0.0114 ns | 0.0106 ns |  1.1788 ns |  0.93 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.6615 ns | 0.0029 ns | 0.0027 ns |  1.6612 ns |  1.32 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.3655 ns | 0.0040 ns | 0.0035 ns |  1.3650 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2012 ns | 0.0124 ns | 0.0104 ns |  4.2008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1762 ns | 0.0053 ns | 0.0044 ns |  4.1763 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9488 ns | 0.0055 ns | 0.0049 ns |  3.9503 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6255 ns | 0.0062 ns | 0.0058 ns |  4.6264 ns |  1.10 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6440 ns | 0.0092 ns | 0.0081 ns |  4.6426 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.3138 ns | 0.0068 ns | 0.0061 ns |  1.3121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.5516 ns | 0.0026 ns | 0.0023 ns |  1.5509 ns |  1.18 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.3286 ns | 0.0054 ns | 0.0050 ns |  1.3281 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  1.6535 ns | 0.0027 ns | 0.0025 ns |  1.6543 ns |  1.26 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  1.3642 ns | 0.0044 ns | 0.0036 ns |  1.3638 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9809 ns | 0.0051 ns | 0.0045 ns |  1.9816 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.2071 ns | 0.0140 ns | 0.0124 ns |  2.2101 ns |  1.11 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.7000 ns | 0.0023 ns | 0.0022 ns |  1.6998 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  3.1101 ns | 0.0064 ns | 0.0050 ns |  3.1091 ns |  1.57 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.7936 ns | 0.0044 ns | 0.0036 ns |  2.7951 ns |  1.41 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  0.9366 ns | 0.0025 ns | 0.0024 ns |  0.9364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2002 ns | 0.0023 ns | 0.0021 ns |  1.2002 ns |  1.28 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.1729 ns | 0.0031 ns | 0.0028 ns |  1.1727 ns |  1.25 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  0.7262 ns | 0.0019 ns | 0.0016 ns |  0.7260 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  0.4428 ns | 0.0019 ns | 0.0018 ns |  0.4435 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.4250 ns | 0.0035 ns | 0.0033 ns |  1.4256 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8573 ns | 0.0074 ns | 0.0066 ns |  1.8567 ns |  1.30 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.8788 ns | 0.0185 ns | 0.0173 ns |  1.8846 ns |  1.32 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.5965 ns | 0.0029 ns | 0.0027 ns |  1.5973 ns |  1.12 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.6175 ns | 0.0030 ns | 0.0026 ns |  1.6174 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3787 ns | 0.0045 ns | 0.0040 ns |  1.3775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.5319 ns | 0.0095 ns | 0.0084 ns |  1.5292 ns |  1.11 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.8648 ns | 0.0053 ns | 0.0047 ns |  1.8639 ns |  1.35 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.9531 ns | 0.0052 ns | 0.0046 ns |  0.9517 ns |  0.69 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.6685 ns | 0.0030 ns | 0.0027 ns |  0.6685 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.6587 ns | 0.0075 ns | 0.0063 ns |  4.6592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.8658 ns | 0.0085 ns | 0.0076 ns |  4.8658 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.4727 ns | 0.0070 ns | 0.0058 ns |  4.4719 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.8837 ns | 0.0339 ns | 0.0317 ns |  4.9016 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8747 ns | 0.0062 ns | 0.0058 ns |  4.8739 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.2926 ns | 0.0043 ns | 0.0036 ns |  1.2934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.9034 ns | 0.0642 ns | 0.0631 ns |  1.9005 ns |  1.48 |    0.05 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5570 ns | 0.0068 ns | 0.0057 ns |  1.5555 ns |  1.20 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.9732 ns | 0.0026 ns | 0.0023 ns |  0.9736 ns |  0.75 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.6752 ns | 0.0034 ns | 0.0029 ns |  0.6762 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.1011 ns | 0.0087 ns | 0.0077 ns |  2.1000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9072 ns | 0.0041 ns | 0.0039 ns |  1.9070 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.9366 ns | 0.0057 ns | 0.0048 ns |  1.9384 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.0262 ns | 0.0039 ns | 0.0035 ns |  2.0262 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1379 ns | 0.0092 ns | 0.0081 ns |  2.1405 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.8059 ns | 0.0070 ns | 0.0058 ns |  5.8060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.8647 ns | 0.0083 ns | 0.0078 ns |  5.8617 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0004 ns | 0.1323 ns | 0.1238 ns |  5.9138 ns |  1.03 |    0.02 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.7700 ns | 0.0086 ns | 0.0076 ns |  5.7700 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.0300 ns | 0.0047 ns | 0.0044 ns |  6.0289 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 19.0263 ns | 0.0681 ns | 0.0637 ns | 19.0369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.0389 ns | 0.0141 ns | 0.0118 ns | 18.0394 ns |  0.95 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.7531 ns | 0.0901 ns | 0.0842 ns | 12.7865 ns |  0.67 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 17.7855 ns | 0.0177 ns | 0.0166 ns | 17.7889 ns |  0.93 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.0571 ns | 0.0168 ns | 0.0149 ns | 18.0609 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0780 ns | 0.0028 ns | 0.0026 ns |  2.0781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3614 ns | 0.0049 ns | 0.0046 ns |  2.3606 ns |  1.14 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.5240 ns | 0.0657 ns | 0.0615 ns |  2.5443 ns |  1.21 |    0.03 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1257 ns | 0.0114 ns | 0.0107 ns |  1.1217 ns |  0.54 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1871 ns | 0.0066 ns | 0.0062 ns |  1.1845 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9041 ns | 0.0131 ns | 0.0122 ns |  7.9033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.1137 ns | 0.0122 ns | 0.0095 ns |  8.1160 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0259 ns | 0.0078 ns | 0.0073 ns |  2.0244 ns |  0.26 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4118 ns | 0.0208 ns | 0.0184 ns |  8.4158 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2848 ns | 0.0177 ns | 0.0157 ns |  8.2833 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.4288 ns | 0.0141 ns | 0.0125 ns |  3.4257 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.9754 ns | 0.0063 ns | 0.0059 ns |  3.9764 ns |  1.16 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.9117 ns | 0.0321 ns | 0.0301 ns |  3.9126 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.6952 ns | 0.0066 ns | 0.0062 ns |  2.6932 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.8282 ns | 0.0098 ns | 0.0082 ns |  2.8277 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.9310 ns | 0.0481 ns | 0.0426 ns | 29.9181 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 19.2114 ns | 0.0295 ns | 0.0261 ns | 19.2174 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 11.8465 ns | 0.0244 ns | 0.0228 ns | 11.8458 ns |  0.40 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 30.9641 ns | 0.0734 ns | 0.0687 ns | 30.9444 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.5357 ns | 0.0719 ns | 0.0638 ns | 30.5293 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.4104 ns | 0.0203 ns | 0.0190 ns | 10.4095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.5437 ns | 0.0218 ns | 0.0204 ns | 10.5413 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.6148 ns | 0.0119 ns | 0.0105 ns |  8.6154 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.8101 ns | 0.0136 ns | 0.0121 ns | 12.8103 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.5463 ns | 0.0096 ns | 0.0080 ns | 12.5476 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.9739 ns | 0.0242 ns | 0.0226 ns | 14.9717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.3646 ns | 0.0204 ns | 0.0181 ns | 15.3708 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.9463 ns | 0.0128 ns | 0.0120 ns | 12.9450 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 17.5977 ns | 0.0966 ns | 0.0904 ns | 17.6336 ns |  1.18 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 17.4299 ns | 0.0375 ns | 0.0351 ns | 17.4224 ns |  1.16 |    0.00 |      - |     - |     - |         - |
