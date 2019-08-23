
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4368 ns | 0.0041 ns | 0.0034 ns |  1.4360 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6106 ns | 0.0079 ns | 0.0070 ns |  1.6126 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.5401 ns | 0.0038 ns | 0.0034 ns |  1.5392 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9909 ns | 0.0027 ns | 0.0025 ns |  0.9905 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  1.5370 ns | 0.0036 ns | 0.0030 ns |  1.5366 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9305 ns | 0.0035 ns | 0.0031 ns |  3.9302 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1631 ns | 0.0064 ns | 0.0060 ns |  4.1639 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9337 ns | 0.0057 ns | 0.0053 ns |  3.9332 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1752 ns | 0.0079 ns | 0.0062 ns |  4.1745 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1408 ns | 0.0068 ns | 0.0063 ns |  4.1417 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5362 ns | 0.0038 ns | 0.0036 ns |  1.5363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4107 ns | 0.0033 ns | 0.0029 ns |  1.4105 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.3830 ns | 0.0023 ns | 0.0021 ns |  1.3832 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  1.0110 ns | 0.0066 ns | 0.0062 ns |  1.0121 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9756 ns | 0.0029 ns | 0.0026 ns |  0.9755 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2151 ns | 0.0041 ns | 0.0039 ns |  4.2150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1642 ns | 0.0056 ns | 0.0053 ns |  4.1650 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9346 ns | 0.0047 ns | 0.0044 ns |  3.9344 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4031 ns | 0.0068 ns | 0.0064 ns |  4.4022 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.3976 ns | 0.0232 ns | 0.0217 ns |  4.4067 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4385 ns | 0.0031 ns | 0.0027 ns |  1.4378 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.5352 ns | 0.0030 ns | 0.0028 ns |  1.5343 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4955 ns | 0.0095 ns | 0.0085 ns |  1.4992 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9977 ns | 0.0066 ns | 0.0062 ns |  0.9985 ns |  0.69 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9791 ns | 0.0023 ns | 0.0021 ns |  0.9797 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.1703 ns | 0.0070 ns | 0.0065 ns |  4.1708 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1762 ns | 0.0230 ns | 0.0215 ns |  4.1904 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  3.9326 ns | 0.0048 ns | 0.0040 ns |  3.9330 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4059 ns | 0.0068 ns | 0.0060 ns |  4.4052 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.3691 ns | 0.0061 ns | 0.0048 ns |  4.3692 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.5358 ns | 0.0020 ns | 0.0019 ns |  1.5354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4092 ns | 0.0034 ns | 0.0032 ns |  1.4089 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.3999 ns | 0.0019 ns | 0.0015 ns |  1.3995 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9931 ns | 0.0031 ns | 0.0028 ns |  0.9928 ns |  0.65 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9768 ns | 0.0021 ns | 0.0020 ns |  0.9772 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.1700 ns | 0.0051 ns | 0.0048 ns |  4.1699 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1607 ns | 0.0047 ns | 0.0042 ns |  4.1618 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  3.9684 ns | 0.0071 ns | 0.0063 ns |  3.9689 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4062 ns | 0.0059 ns | 0.0052 ns |  4.4050 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.3698 ns | 0.0040 ns | 0.0038 ns |  4.3699 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4396 ns | 0.0033 ns | 0.0031 ns |  1.4392 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5367 ns | 0.0028 ns | 0.0025 ns |  1.5369 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.2811 ns | 0.0025 ns | 0.0023 ns |  1.2810 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  1.1739 ns | 0.0028 ns | 0.0026 ns |  1.1741 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9852 ns | 0.0066 ns | 0.0062 ns |  0.9870 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.1712 ns | 0.0051 ns | 0.0047 ns |  4.1733 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1662 ns | 0.0023 ns | 0.0021 ns |  4.1663 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  3.9962 ns | 0.0126 ns | 0.0118 ns |  3.9990 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4016 ns | 0.0053 ns | 0.0044 ns |  4.4023 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.3705 ns | 0.0037 ns | 0.0035 ns |  4.3718 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.5413 ns | 0.0032 ns | 0.0030 ns |  1.5415 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5346 ns | 0.0097 ns | 0.0086 ns |  1.5369 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.3835 ns | 0.0019 ns | 0.0017 ns |  1.3837 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9931 ns | 0.0023 ns | 0.0021 ns |  0.9934 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9834 ns | 0.0131 ns | 0.0116 ns |  0.9779 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.1694 ns | 0.0045 ns | 0.0042 ns |  4.1687 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1596 ns | 0.0037 ns | 0.0034 ns |  4.1599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9342 ns | 0.0053 ns | 0.0047 ns |  3.9345 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4015 ns | 0.0065 ns | 0.0061 ns |  4.4038 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.3734 ns | 0.0065 ns | 0.0061 ns |  4.3758 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.4426 ns | 0.0022 ns | 0.0021 ns |  1.4428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7529 ns | 0.0031 ns | 0.0027 ns |  1.7526 ns |  1.22 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.7237 ns | 0.0081 ns | 0.0076 ns |  1.7227 ns |  1.19 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  1.1909 ns | 0.0028 ns | 0.0025 ns |  1.1915 ns |  0.83 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9817 ns | 0.0023 ns | 0.0020 ns |  0.9817 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9379 ns | 0.0050 ns | 0.0042 ns |  3.9389 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2175 ns | 0.0041 ns | 0.0038 ns |  4.2169 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.9606 ns | 0.0054 ns | 0.0051 ns |  3.9599 ns |  1.01 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4371 ns | 0.0188 ns | 0.0176 ns |  4.4410 ns |  1.13 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3711 ns | 0.0043 ns | 0.0038 ns |  4.3716 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4757 ns | 0.0022 ns | 0.0020 ns |  1.4752 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4104 ns | 0.0031 ns | 0.0029 ns |  1.4097 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4118 ns | 0.0024 ns | 0.0020 ns |  1.4119 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.1643 ns | 0.0020 ns | 0.0019 ns |  1.1642 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9436 ns | 0.0018 ns | 0.0017 ns |  0.9436 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4022 ns | 0.0044 ns | 0.0041 ns |  4.4025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.3952 ns | 0.0044 ns | 0.0041 ns |  4.3950 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9586 ns | 0.0038 ns | 0.0035 ns |  3.9603 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4033 ns | 0.0063 ns | 0.0056 ns |  4.4037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4130 ns | 0.0253 ns | 0.0237 ns |  4.4214 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.3929 ns | 0.0023 ns | 0.0021 ns |  1.3928 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4092 ns | 0.0028 ns | 0.0025 ns |  1.4093 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4758 ns | 0.0128 ns | 0.0120 ns |  1.4699 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9927 ns | 0.0024 ns | 0.0022 ns |  0.9927 ns |  0.71 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9746 ns | 0.0022 ns | 0.0021 ns |  0.9748 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.2579 ns | 0.0027 ns | 0.0024 ns |  2.2581 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8468 ns | 0.0158 ns | 0.0148 ns |  1.8539 ns |  0.82 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.7686 ns | 0.0047 ns | 0.0044 ns |  1.7688 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.4572 ns | 0.0043 ns | 0.0038 ns |  2.4568 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  1.8739 ns | 0.0042 ns | 0.0037 ns |  1.8745 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4919 ns | 0.0023 ns | 0.0022 ns |  1.4919 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4155 ns | 0.0048 ns | 0.0045 ns |  1.4151 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.3161 ns | 0.0096 ns | 0.0085 ns |  1.3202 ns |  0.88 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9587 ns | 0.0030 ns | 0.0028 ns |  0.9575 ns |  0.64 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9427 ns | 0.0022 ns | 0.0021 ns |  0.9432 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.8665 ns | 0.0028 ns | 0.0026 ns |  1.8665 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.0778 ns | 0.0027 ns | 0.0024 ns |  2.0772 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9736 ns | 0.0044 ns | 0.0042 ns |  1.9731 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.2240 ns | 0.0037 ns | 0.0035 ns |  2.2244 ns |  1.19 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  1.9195 ns | 0.0048 ns | 0.0043 ns |  1.9181 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3466 ns | 0.0046 ns | 0.0043 ns |  1.3450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4399 ns | 0.0026 ns | 0.0024 ns |  1.4403 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2104 ns | 0.0027 ns | 0.0025 ns |  1.2102 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.2119 ns | 0.0063 ns | 0.0056 ns |  1.2129 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0261 ns | 0.0139 ns | 0.0130 ns |  1.0330 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.1717 ns | 0.0049 ns | 0.0043 ns |  4.1717 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3836 ns | 0.0056 ns | 0.0050 ns |  4.3828 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2296 ns | 0.0111 ns | 0.0087 ns |  4.2305 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6333 ns | 0.0072 ns | 0.0067 ns |  4.6330 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6011 ns | 0.0059 ns | 0.0055 ns |  4.6004 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5564 ns | 0.0156 ns | 0.0146 ns |  1.5652 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.5978 ns | 0.0032 ns | 0.0029 ns |  1.5986 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.9600 ns | 0.0634 ns | 0.0593 ns |  1.9567 ns |  1.26 |    0.04 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.1462 ns | 0.0035 ns | 0.0031 ns |  1.1466 ns |  0.74 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.0052 ns | 0.0013 ns | 0.0011 ns |  1.0052 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8039 ns | 0.0029 ns | 0.0026 ns |  1.8039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0661 ns | 0.0021 ns | 0.0020 ns |  2.0657 ns |  1.15 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.0962 ns | 0.0118 ns | 0.0111 ns |  2.0999 ns |  1.16 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.4859 ns | 0.0036 ns | 0.0032 ns |  2.4851 ns |  1.38 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.0828 ns | 0.0029 ns | 0.0027 ns |  2.0826 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2409 ns | 0.0116 ns | 0.0108 ns |  2.2448 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.5234 ns | 0.0081 ns | 0.0076 ns |  2.5250 ns |  1.13 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.9963 ns | 0.0035 ns | 0.0032 ns |  1.9961 ns |  0.89 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0889 ns | 0.0106 ns | 0.0099 ns |  6.0904 ns |  2.72 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  5.9944 ns | 0.0053 ns | 0.0050 ns |  5.9939 ns |  2.68 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  9.9248 ns | 0.0212 ns | 0.0188 ns |  9.9198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.6681 ns | 0.0128 ns | 0.0120 ns | 10.6656 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.0964 ns | 0.0120 ns | 0.0112 ns |  2.0925 ns |  0.21 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6681 ns | 0.0152 ns | 0.0135 ns | 10.6689 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6997 ns | 0.0702 ns | 0.0548 ns | 10.7262 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0293 ns | 0.0028 ns | 0.0025 ns |  2.0290 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3078 ns | 0.0154 ns | 0.0144 ns |  2.2999 ns |  1.14 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2346 ns | 0.0038 ns | 0.0035 ns |  2.2354 ns |  1.10 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1829 ns | 0.0053 ns | 0.0044 ns |  1.1850 ns |  0.58 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1530 ns | 0.0504 ns | 0.0723 ns |  1.1466 ns |  0.57 |    0.04 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2850 ns | 0.0121 ns | 0.0113 ns |  8.2837 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.6226 ns | 0.0132 ns | 0.0110 ns |  8.6260 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0552 ns | 0.0574 ns | 0.0537 ns |  2.0435 ns |  0.25 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 12.2583 ns | 0.0120 ns | 0.0106 ns | 12.2570 ns |  1.48 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4990 ns | 0.0156 ns | 0.0138 ns |  8.5006 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.5722 ns | 0.0099 ns | 0.0088 ns |  1.5754 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4710 ns | 0.0067 ns | 0.0063 ns |  1.4727 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4506 ns | 0.0114 ns | 0.0106 ns |  1.4531 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9819 ns | 0.0028 ns | 0.0024 ns |  0.9820 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9642 ns | 0.0021 ns | 0.0020 ns |  0.9640 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.5495 ns | 0.0038 ns | 0.0036 ns |  1.5494 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.6031 ns | 0.0030 ns | 0.0028 ns |  1.6036 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.3988 ns | 0.0019 ns | 0.0018 ns |  1.3990 ns |  0.90 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  1.5828 ns | 0.0029 ns | 0.0026 ns |  1.5822 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2494 ns | 0.0024 ns | 0.0022 ns |  1.2496 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.5476 ns | 0.0035 ns | 0.0033 ns |  1.5466 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4201 ns | 0.0024 ns | 0.0022 ns |  1.4199 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.6158 ns | 0.0177 ns | 0.0166 ns |  1.6070 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.1660 ns | 0.0019 ns | 0.0017 ns |  1.1663 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  0.9649 ns | 0.0031 ns | 0.0029 ns |  0.9651 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  1.0871 ns | 0.0031 ns | 0.0028 ns |  1.0873 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  1.1505 ns | 0.0018 ns | 0.0015 ns |  1.1505 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  0.9241 ns | 0.0020 ns | 0.0019 ns |  0.9240 ns |  0.85 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  1.1773 ns | 0.0078 ns | 0.0069 ns |  1.1795 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  0.9319 ns | 0.0095 ns | 0.0084 ns |  0.9348 ns |  0.86 |    0.01 |     - |     - |     - |         - |
