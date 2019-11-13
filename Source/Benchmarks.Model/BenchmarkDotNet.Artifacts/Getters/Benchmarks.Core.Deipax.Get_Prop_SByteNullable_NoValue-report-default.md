
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
             ToBool | .NET Core 2.0 |  1.4609 ns | 0.0037 ns | 0.0035 ns |  1.4604 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4069 ns | 0.0029 ns | 0.0025 ns |  1.4070 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2415 ns | 0.0030 ns | 0.0026 ns |  1.2417 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9622 ns | 0.0040 ns | 0.0038 ns |  0.9630 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9946 ns | 0.0021 ns | 0.0020 ns |  0.9946 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0407 ns | 0.0254 ns | 0.0237 ns |  4.0479 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1760 ns | 0.0064 ns | 0.0050 ns |  4.1747 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0052 ns | 0.0037 ns | 0.0031 ns |  4.0065 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1699 ns | 0.0082 ns | 0.0077 ns |  4.1696 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1515 ns | 0.0106 ns | 0.0100 ns |  4.1492 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5522 ns | 0.0047 ns | 0.0042 ns |  1.5511 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4078 ns | 0.0034 ns | 0.0028 ns |  1.4069 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2376 ns | 0.0022 ns | 0.0020 ns |  1.2379 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9652 ns | 0.0069 ns | 0.0057 ns |  0.9633 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9990 ns | 0.0064 ns | 0.0053 ns |  1.0001 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2871 ns | 0.0052 ns | 0.0048 ns |  4.2863 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4002 ns | 0.0044 ns | 0.0039 ns |  4.3994 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0098 ns | 0.0117 ns | 0.0098 ns |  4.0062 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3991 ns | 0.0061 ns | 0.0054 ns |  4.3993 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.3727 ns | 0.0051 ns | 0.0048 ns |  4.3723 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.6494 ns | 0.0039 ns | 0.0037 ns |  1.6486 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6486 ns | 0.0225 ns | 0.0210 ns |  1.6490 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4112 ns | 0.0038 ns | 0.0034 ns |  1.4116 ns |  0.86 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9496 ns | 0.0013 ns | 0.0010 ns |  0.9498 ns |  0.58 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.1833 ns | 0.0081 ns | 0.0072 ns |  1.1850 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  1.1738 ns | 0.0080 ns | 0.0075 ns |  1.1722 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  1.3645 ns | 0.0026 ns | 0.0020 ns |  1.3649 ns |  1.16 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  0.9516 ns | 0.0038 ns | 0.0033 ns |  0.9503 ns |  0.81 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  0.9636 ns | 0.0034 ns | 0.0032 ns |  0.9629 ns |  0.82 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  1.1257 ns | 0.0020 ns | 0.0019 ns |  1.1263 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.6455 ns | 0.0034 ns | 0.0030 ns |  1.6445 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.5410 ns | 0.0034 ns | 0.0032 ns |  1.5412 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5450 ns | 0.0035 ns | 0.0032 ns |  1.5459 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9636 ns | 0.0039 ns | 0.0033 ns |  0.9627 ns |  0.59 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  1.2128 ns | 0.0146 ns | 0.0136 ns |  1.2119 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2515 ns | 0.0063 ns | 0.0059 ns |  4.2508 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.3911 ns | 0.0061 ns | 0.0057 ns |  4.3916 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.1185 ns | 0.0369 ns | 0.0345 ns |  4.1210 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4430 ns | 0.0076 ns | 0.0071 ns |  4.4426 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.3766 ns | 0.0071 ns | 0.0067 ns |  4.3759 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4978 ns | 0.0065 ns | 0.0057 ns |  1.4983 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5326 ns | 0.0034 ns | 0.0030 ns |  1.5327 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.3388 ns | 0.0169 ns | 0.0158 ns |  1.3349 ns |  0.89 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9607 ns | 0.0038 ns | 0.0033 ns |  0.9605 ns |  0.64 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9933 ns | 0.0037 ns | 0.0033 ns |  0.9918 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0220 ns | 0.0050 ns | 0.0041 ns |  4.0222 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1673 ns | 0.0101 ns | 0.0094 ns |  4.1659 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0527 ns | 0.0349 ns | 0.0326 ns |  4.0618 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.3991 ns | 0.0075 ns | 0.0063 ns |  4.4004 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.3817 ns | 0.0057 ns | 0.0048 ns |  4.3817 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.8078 ns | 0.0157 ns | 0.0146 ns |  1.8091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.4741 ns | 0.0027 ns | 0.0025 ns |  1.4738 ns |  0.82 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7381 ns | 0.0114 ns | 0.0106 ns |  1.7340 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9627 ns | 0.0035 ns | 0.0029 ns |  0.9615 ns |  0.53 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9939 ns | 0.0025 ns | 0.0023 ns |  0.9942 ns |  0.55 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.2568 ns | 0.0061 ns | 0.0057 ns |  4.2574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.3961 ns | 0.0091 ns | 0.0085 ns |  4.3976 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0148 ns | 0.0134 ns | 0.0112 ns |  4.0110 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.3970 ns | 0.0067 ns | 0.0059 ns |  4.3981 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.3801 ns | 0.0083 ns | 0.0077 ns |  4.3811 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.4958 ns | 0.0039 ns | 0.0034 ns |  1.4956 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4815 ns | 0.0121 ns | 0.0095 ns |  1.4849 ns |  0.99 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.2714 ns | 0.0068 ns | 0.0064 ns |  1.2710 ns |  0.85 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9595 ns | 0.0028 ns | 0.0025 ns |  0.9598 ns |  0.64 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9976 ns | 0.0079 ns | 0.0070 ns |  0.9996 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0233 ns | 0.0080 ns | 0.0075 ns |  4.0217 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1604 ns | 0.0080 ns | 0.0075 ns |  4.1611 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0377 ns | 0.0210 ns | 0.0196 ns |  4.0453 ns |  1.00 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4476 ns | 0.0053 ns | 0.0049 ns |  4.4496 ns |  1.11 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3795 ns | 0.0085 ns | 0.0075 ns |  4.3774 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6324 ns | 0.0023 ns | 0.0021 ns |  1.6325 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6052 ns | 0.0027 ns | 0.0024 ns |  1.6049 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.6309 ns | 0.0054 ns | 0.0051 ns |  1.6310 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9286 ns | 0.0025 ns | 0.0024 ns |  0.9281 ns |  0.57 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9904 ns | 0.0074 ns | 0.0062 ns |  0.9919 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2507 ns | 0.0054 ns | 0.0048 ns |  4.2512 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.3947 ns | 0.0085 ns | 0.0080 ns |  4.3910 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9921 ns | 0.0031 ns | 0.0029 ns |  3.9922 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.3997 ns | 0.0084 ns | 0.0074 ns |  4.3993 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.3831 ns | 0.0138 ns | 0.0122 ns |  4.3786 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.5026 ns | 0.0024 ns | 0.0021 ns |  1.5032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.5979 ns | 0.0034 ns | 0.0030 ns |  1.5978 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6299 ns | 0.0024 ns | 0.0021 ns |  1.6302 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9619 ns | 0.0026 ns | 0.0024 ns |  0.9621 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9947 ns | 0.0033 ns | 0.0029 ns |  0.9941 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.2451 ns | 0.0026 ns | 0.0023 ns |  2.2451 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0507 ns | 0.0073 ns | 0.0068 ns |  2.0483 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1036 ns | 0.0036 ns | 0.0030 ns |  2.1033 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.0904 ns | 0.0035 ns | 0.0033 ns |  2.0904 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.0317 ns | 0.0030 ns | 0.0027 ns |  2.0307 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6334 ns | 0.0047 ns | 0.0044 ns |  1.6331 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4304 ns | 0.0112 ns | 0.0093 ns |  1.4332 ns |  0.88 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2421 ns | 0.0108 ns | 0.0101 ns |  1.2462 ns |  0.76 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9296 ns | 0.0035 ns | 0.0033 ns |  0.9297 ns |  0.57 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  1.0624 ns | 0.0112 ns | 0.0105 ns |  1.0678 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1746 ns | 0.0153 ns | 0.0143 ns |  2.1669 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.3495 ns | 0.0183 ns | 0.0171 ns |  2.3429 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.8683 ns | 0.0038 ns | 0.0032 ns |  1.8685 ns |  0.86 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.0751 ns | 0.0038 ns | 0.0035 ns |  2.0756 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.0338 ns | 0.0034 ns | 0.0032 ns |  2.0331 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.5296 ns | 0.0032 ns | 0.0029 ns |  1.5291 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3658 ns | 0.0054 ns | 0.0048 ns |  1.3653 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4307 ns | 0.0157 ns | 0.0122 ns |  1.4358 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9832 ns | 0.0034 ns | 0.0032 ns |  0.9819 ns |  0.64 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0205 ns | 0.0037 ns | 0.0033 ns |  1.0202 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2470 ns | 0.0063 ns | 0.0056 ns |  4.2462 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3933 ns | 0.0038 ns | 0.0034 ns |  4.3930 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2326 ns | 0.0050 ns | 0.0039 ns |  4.2345 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6245 ns | 0.0083 ns | 0.0077 ns |  4.6223 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6072 ns | 0.0063 ns | 0.0056 ns |  4.6081 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6458 ns | 0.0059 ns | 0.0055 ns |  1.6474 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.5829 ns | 0.0020 ns | 0.0017 ns |  1.5831 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2716 ns | 0.0034 ns | 0.0026 ns |  1.2721 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9840 ns | 0.0027 ns | 0.0025 ns |  0.9835 ns |  0.60 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.2100 ns | 0.0051 ns | 0.0043 ns |  1.2086 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.2549 ns | 0.0042 ns | 0.0038 ns |  2.2545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8237 ns | 0.0027 ns | 0.0025 ns |  1.8233 ns |  0.81 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1012 ns | 0.0028 ns | 0.0024 ns |  2.1012 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1147 ns | 0.0061 ns | 0.0054 ns |  2.1138 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.0873 ns | 0.0026 ns | 0.0024 ns |  2.0867 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2307 ns | 0.0073 ns | 0.0068 ns |  2.2295 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.0366 ns | 0.0051 ns | 0.0048 ns |  2.0348 ns |  0.91 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.3394 ns | 0.0039 ns | 0.0035 ns |  2.3402 ns |  1.05 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0311 ns | 0.0081 ns | 0.0076 ns |  6.0334 ns |  2.70 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.2432 ns | 0.0116 ns | 0.0103 ns |  6.2419 ns |  2.80 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0864 ns | 0.0201 ns | 0.0188 ns | 10.0908 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.6796 ns | 0.0111 ns | 0.0104 ns | 10.6815 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3574 ns | 0.0186 ns | 0.0165 ns |  2.3636 ns |  0.23 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6468 ns | 0.0100 ns | 0.0083 ns | 10.6435 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7034 ns | 0.0634 ns | 0.0593 ns | 10.7207 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3264 ns | 0.0029 ns | 0.0026 ns |  2.3267 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1032 ns | 0.0038 ns | 0.0033 ns |  2.1035 ns |  0.90 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3283 ns | 0.0145 ns | 0.0136 ns |  2.3222 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1853 ns | 0.0038 ns | 0.0036 ns |  1.1845 ns |  0.51 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1169 ns | 0.0036 ns | 0.0032 ns |  1.1174 ns |  0.48 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9869 ns | 0.0450 ns | 0.0421 ns |  7.9667 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3457 ns | 0.0147 ns | 0.0137 ns |  8.3439 ns |  1.04 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9222 ns | 0.0031 ns | 0.0028 ns |  1.9218 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1968 ns | 0.0180 ns | 0.0160 ns |  8.1967 ns |  1.03 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.5624 ns | 0.0095 ns | 0.0084 ns |  8.5623 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4619 ns | 0.0036 ns | 0.0032 ns |  1.4613 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.6116 ns | 0.0044 ns | 0.0039 ns |  1.6107 ns |  1.10 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2733 ns | 0.0030 ns | 0.0027 ns |  1.2730 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9512 ns | 0.0038 ns | 0.0034 ns |  0.9514 ns |  0.65 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9835 ns | 0.0026 ns | 0.0023 ns |  0.9834 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.6313 ns | 0.0028 ns | 0.0026 ns |  1.6305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.6033 ns | 0.0028 ns | 0.0026 ns |  1.6025 ns |  0.98 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.7261 ns | 0.0467 ns | 0.0437 ns |  1.7262 ns |  1.06 |    0.03 |     - |     - |     - |         - |
          To_String |        net461 |  1.2348 ns | 0.0025 ns | 0.0021 ns |  1.2343 ns |  0.76 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2690 ns | 0.0017 ns | 0.0016 ns |  1.2687 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6338 ns | 0.0046 ns | 0.0043 ns |  1.6341 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4377 ns | 0.0040 ns | 0.0035 ns |  1.4373 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.3288 ns | 0.0023 ns | 0.0021 ns |  1.3286 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2370 ns | 0.0040 ns | 0.0036 ns |  1.2370 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2779 ns | 0.0190 ns | 0.0158 ns |  1.2803 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2456 ns | 0.0053 ns | 0.0050 ns |  4.2442 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4171 ns | 0.0296 ns | 0.0277 ns |  4.4035 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0019 ns | 0.0072 ns | 0.0064 ns |  4.0015 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6686 ns | 0.0199 ns | 0.0186 ns |  4.6733 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6084 ns | 0.0072 ns | 0.0064 ns |  4.6084 ns |  1.09 |    0.00 |     - |     - |     - |         - |
