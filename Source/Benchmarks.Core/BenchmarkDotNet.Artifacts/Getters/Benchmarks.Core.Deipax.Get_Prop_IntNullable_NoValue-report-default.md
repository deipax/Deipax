
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
             ToBool | .NET Core 2.0 |  1.4424 ns | 0.0027 ns | 0.0024 ns |  1.4418 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.3349 ns | 0.0142 ns | 0.0133 ns |  1.3284 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4133 ns | 0.0091 ns | 0.0081 ns |  1.4101 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9647 ns | 0.0031 ns | 0.0027 ns |  0.9637 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  1.6842 ns | 0.0034 ns | 0.0030 ns |  1.6836 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9336 ns | 0.0064 ns | 0.0054 ns |  3.9334 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1244 ns | 0.0049 ns | 0.0046 ns |  4.1258 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0137 ns | 0.0042 ns | 0.0037 ns |  4.0133 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1590 ns | 0.0081 ns | 0.0072 ns |  4.1581 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1787 ns | 0.0053 ns | 0.0049 ns |  4.1788 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5424 ns | 0.0016 ns | 0.0013 ns |  1.5424 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.1624 ns | 0.0068 ns | 0.0064 ns |  1.1598 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2393 ns | 0.0033 ns | 0.0028 ns |  1.2386 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9642 ns | 0.0031 ns | 0.0029 ns |  0.9635 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9709 ns | 0.0026 ns | 0.0025 ns |  0.9705 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2276 ns | 0.0148 ns | 0.0132 ns |  4.2296 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1746 ns | 0.0238 ns | 0.0223 ns |  4.1834 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0384 ns | 0.0132 ns | 0.0103 ns |  4.0410 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4196 ns | 0.0247 ns | 0.0231 ns |  4.4296 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4576 ns | 0.0085 ns | 0.0080 ns |  4.4550 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4490 ns | 0.0038 ns | 0.0034 ns |  1.4493 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.2442 ns | 0.0035 ns | 0.0033 ns |  1.2438 ns |  0.86 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5427 ns | 0.0033 ns | 0.0029 ns |  1.5422 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9675 ns | 0.0027 ns | 0.0022 ns |  0.9681 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9961 ns | 0.0116 ns | 0.0097 ns |  0.9981 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.1695 ns | 0.0033 ns | 0.0027 ns |  4.1694 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1254 ns | 0.0039 ns | 0.0037 ns |  4.1254 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0164 ns | 0.0038 ns | 0.0036 ns |  4.0163 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.3906 ns | 0.0065 ns | 0.0054 ns |  4.3920 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4152 ns | 0.0081 ns | 0.0067 ns |  4.4145 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.5464 ns | 0.0023 ns | 0.0022 ns |  1.5457 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.1619 ns | 0.0101 ns | 0.0094 ns |  1.1574 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.7505 ns | 0.0609 ns | 0.0813 ns |  1.7721 ns |  1.13 |    0.06 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9680 ns | 0.0030 ns | 0.0027 ns |  0.9688 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9809 ns | 0.0038 ns | 0.0035 ns |  0.9805 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.1801 ns | 0.0087 ns | 0.0077 ns |  4.1787 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1273 ns | 0.0054 ns | 0.0051 ns |  4.1269 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0459 ns | 0.0220 ns | 0.0206 ns |  4.0535 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.3828 ns | 0.0060 ns | 0.0054 ns |  4.3829 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4077 ns | 0.0081 ns | 0.0076 ns |  4.4080 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4470 ns | 0.0046 ns | 0.0043 ns |  1.4475 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.2439 ns | 0.0026 ns | 0.0025 ns |  1.2437 ns |  0.86 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.2990 ns | 0.0022 ns | 0.0021 ns |  1.2993 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9681 ns | 0.0021 ns | 0.0018 ns |  0.9686 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9683 ns | 0.0029 ns | 0.0027 ns |  0.9674 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.1731 ns | 0.0075 ns | 0.0063 ns |  4.1745 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1706 ns | 0.0225 ns | 0.0199 ns |  4.1794 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0025 ns | 0.0081 ns | 0.0072 ns |  4.0018 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.3889 ns | 0.0079 ns | 0.0070 ns |  4.3879 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4150 ns | 0.0133 ns | 0.0118 ns |  4.4131 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.5428 ns | 0.0030 ns | 0.0028 ns |  1.5430 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.1626 ns | 0.0024 ns | 0.0022 ns |  1.1623 ns |  0.75 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.4454 ns | 0.0032 ns | 0.0030 ns |  1.4446 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9650 ns | 0.0032 ns | 0.0027 ns |  0.9644 ns |  0.63 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9690 ns | 0.0024 ns | 0.0021 ns |  0.9687 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.1761 ns | 0.0062 ns | 0.0052 ns |  4.1755 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1499 ns | 0.0336 ns | 0.0314 ns |  4.1275 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0146 ns | 0.0050 ns | 0.0044 ns |  4.0128 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.3883 ns | 0.0058 ns | 0.0054 ns |  4.3892 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4130 ns | 0.0058 ns | 0.0051 ns |  4.4125 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.6735 ns | 0.0038 ns | 0.0035 ns |  1.6728 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.3674 ns | 0.0026 ns | 0.0023 ns |  1.3669 ns |  0.82 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4683 ns | 0.0058 ns | 0.0051 ns |  1.4684 ns |  0.88 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9522 ns | 0.0025 ns | 0.0021 ns |  0.9521 ns |  0.57 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9843 ns | 0.0081 ns | 0.0075 ns |  0.9866 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  1.0853 ns | 0.0034 ns | 0.0030 ns |  1.0859 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  0.9023 ns | 0.0087 ns | 0.0082 ns |  0.8990 ns |  0.83 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  1.1702 ns | 0.0048 ns | 0.0040 ns |  1.1698 ns |  1.08 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  0.9351 ns | 0.0030 ns | 0.0025 ns |  0.9355 ns |  0.86 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  1.1694 ns | 0.0027 ns | 0.0022 ns |  1.1693 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5557 ns | 0.0139 ns | 0.0130 ns |  1.5522 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.1821 ns | 0.0035 ns | 0.0031 ns |  1.1825 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2463 ns | 0.0100 ns | 0.0094 ns |  1.2420 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9322 ns | 0.0048 ns | 0.0040 ns |  0.9321 ns |  0.60 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9374 ns | 0.0031 ns | 0.0028 ns |  0.9370 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4110 ns | 0.0078 ns | 0.0065 ns |  4.4121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.3544 ns | 0.0042 ns | 0.0040 ns |  4.3543 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0061 ns | 0.0079 ns | 0.0070 ns |  4.0068 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.3920 ns | 0.0071 ns | 0.0066 ns |  4.3903 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4164 ns | 0.0139 ns | 0.0130 ns |  4.4110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4094 ns | 0.0075 ns | 0.0066 ns |  1.4088 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1617 ns | 0.0024 ns | 0.0023 ns |  1.1615 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5510 ns | 0.0163 ns | 0.0152 ns |  1.5438 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9729 ns | 0.0131 ns | 0.0122 ns |  0.9675 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  1.0075 ns | 0.0027 ns | 0.0026 ns |  1.0071 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.2560 ns | 0.0037 ns | 0.0031 ns |  2.2562 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.1465 ns | 0.0704 ns | 0.1214 ns |  2.1545 ns |  0.95 |    0.06 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8842 ns | 0.0226 ns | 0.0212 ns |  1.8711 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  1.8893 ns | 0.0056 ns | 0.0052 ns |  1.8897 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1206 ns | 0.0069 ns | 0.0065 ns |  2.1207 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.5898 ns | 0.0218 ns | 0.0204 ns |  1.5964 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.1858 ns | 0.0043 ns | 0.0040 ns |  1.1843 ns |  0.75 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.5463 ns | 0.0052 ns | 0.0046 ns |  1.5457 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9333 ns | 0.0056 ns | 0.0052 ns |  0.9326 ns |  0.59 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9385 ns | 0.0038 ns | 0.0034 ns |  0.9377 ns |  0.59 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0319 ns | 0.0064 ns | 0.0057 ns |  2.0301 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8503 ns | 0.0039 ns | 0.0033 ns |  1.8509 ns |  0.91 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1041 ns | 0.0047 ns | 0.0042 ns |  2.1032 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.9918 ns | 0.0095 ns | 0.0084 ns |  1.9930 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.0851 ns | 0.0051 ns | 0.0043 ns |  2.0851 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3558 ns | 0.0171 ns | 0.0160 ns |  1.3664 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1544 ns | 0.0044 ns | 0.0039 ns |  1.1534 ns |  0.85 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4455 ns | 0.0028 ns | 0.0022 ns |  1.4458 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9975 ns | 0.0040 ns | 0.0038 ns |  0.9974 ns |  0.74 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0212 ns | 0.0106 ns | 0.0099 ns |  1.0233 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.1831 ns | 0.0056 ns | 0.0052 ns |  4.1830 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3561 ns | 0.0044 ns | 0.0041 ns |  4.3565 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2644 ns | 0.0300 ns | 0.0281 ns |  4.2499 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6136 ns | 0.0064 ns | 0.0053 ns |  4.6135 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6407 ns | 0.0054 ns | 0.0048 ns |  4.6421 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5468 ns | 0.0179 ns | 0.0167 ns |  1.5367 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.3334 ns | 0.0115 ns | 0.0102 ns |  1.3363 ns |  0.86 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5606 ns | 0.0025 ns | 0.0022 ns |  1.5597 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9941 ns | 0.0035 ns | 0.0033 ns |  0.9926 ns |  0.64 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.9900 ns | 0.0032 ns | 0.0028 ns |  0.9890 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.0125 ns | 0.0029 ns | 0.0027 ns |  2.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9269 ns | 0.0072 ns | 0.0060 ns |  1.9252 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1069 ns | 0.0060 ns | 0.0057 ns |  2.1060 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.9573 ns | 0.0053 ns | 0.0047 ns |  1.9560 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1179 ns | 0.0044 ns | 0.0039 ns |  2.1175 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2553 ns | 0.0029 ns | 0.0026 ns |  2.2554 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.0673 ns | 0.0042 ns | 0.0037 ns |  2.0666 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1304 ns | 0.0139 ns | 0.0123 ns |  2.1338 ns |  0.94 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0648 ns | 0.0380 ns | 0.0355 ns |  6.0837 ns |  2.69 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0916 ns | 0.0243 ns | 0.0227 ns |  6.0975 ns |  2.70 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  9.9558 ns | 0.0134 ns | 0.0125 ns |  9.9545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.6503 ns | 0.0662 ns | 0.0619 ns | 10.6228 ns |  1.07 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.1854 ns | 0.0035 ns | 0.0031 ns |  2.1862 ns |  0.22 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6392 ns | 0.0137 ns | 0.0128 ns | 10.6386 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6705 ns | 0.0126 ns | 0.0111 ns | 10.6684 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2560 ns | 0.0020 ns | 0.0017 ns |  2.2559 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0688 ns | 0.0034 ns | 0.0031 ns |  2.0686 ns |  0.92 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3493 ns | 0.0217 ns | 0.0203 ns |  2.3361 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.0035 ns | 0.0147 ns | 0.0138 ns |  0.9970 ns |  0.45 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.2037 ns | 0.0048 ns | 0.0043 ns |  1.2032 ns |  0.53 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8944 ns | 0.0216 ns | 0.0191 ns |  7.8901 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3420 ns | 0.0144 ns | 0.0135 ns |  8.3455 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9232 ns | 0.0039 ns | 0.0033 ns |  1.9227 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1714 ns | 0.0195 ns | 0.0183 ns |  8.1745 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 12.2634 ns | 0.0130 ns | 0.0115 ns | 12.2605 ns |  1.55 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4067 ns | 0.0023 ns | 0.0021 ns |  1.4069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4577 ns | 0.0570 ns | 0.1680 ns |  1.3642 ns |  1.06 |    0.11 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2665 ns | 0.0120 ns | 0.0106 ns |  1.2686 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9525 ns | 0.0032 ns | 0.0029 ns |  0.9525 ns |  0.68 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9559 ns | 0.0031 ns | 0.0024 ns |  0.9561 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.5658 ns | 0.0163 ns | 0.0153 ns |  1.5632 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.4174 ns | 0.0129 ns | 0.0120 ns |  1.4217 ns |  0.91 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.4129 ns | 0.0028 ns | 0.0022 ns |  1.4125 ns |  0.90 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.2618 ns | 0.0117 ns | 0.0110 ns |  1.2583 ns |  0.81 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.2760 ns | 0.0043 ns | 0.0041 ns |  1.2761 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.5337 ns | 0.0044 ns | 0.0036 ns |  1.5333 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.3168 ns | 0.0042 ns | 0.0037 ns |  1.3162 ns |  0.86 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.5558 ns | 0.0130 ns | 0.0115 ns |  1.5592 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2404 ns | 0.0027 ns | 0.0025 ns |  1.2404 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2430 ns | 0.0046 ns | 0.0038 ns |  1.2423 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.1796 ns | 0.0067 ns | 0.0062 ns |  4.1783 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.3531 ns | 0.0048 ns | 0.0042 ns |  4.3521 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0136 ns | 0.0048 ns | 0.0043 ns |  4.0133 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6624 ns | 0.0209 ns | 0.0196 ns |  4.6700 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6463 ns | 0.0088 ns | 0.0078 ns |  4.6452 ns |  1.11 |    0.00 |     - |     - |     - |         - |
