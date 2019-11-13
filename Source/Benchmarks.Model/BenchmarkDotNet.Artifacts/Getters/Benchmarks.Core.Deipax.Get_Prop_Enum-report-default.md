
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
             ToBool | .NET Core 2.0 |  1.1713 ns | 0.0019 ns | 0.0016 ns |  1.1717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1529 ns | 0.0031 ns | 0.0027 ns |  1.1524 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9669 ns | 0.0024 ns | 0.0022 ns |  0.9672 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4331 ns | 0.0012 ns | 0.0011 ns |  0.4330 ns |  0.37 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.7266 ns | 0.0017 ns | 0.0016 ns |  0.7266 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9489 ns | 0.0070 ns | 0.0058 ns |  3.9486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1740 ns | 0.0066 ns | 0.0059 ns |  4.1742 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9893 ns | 0.0091 ns | 0.0085 ns |  3.9911 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1622 ns | 0.0049 ns | 0.0046 ns |  4.1616 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2106 ns | 0.0089 ns | 0.0083 ns |  4.2103 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.1999 ns | 0.0038 ns | 0.0035 ns |  2.1998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.4262 ns | 0.0047 ns | 0.0044 ns |  2.4274 ns |  1.10 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.3419 ns | 0.0214 ns | 0.0201 ns |  2.3360 ns |  1.06 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  1.3483 ns | 0.0047 ns | 0.0044 ns |  1.3474 ns |  0.61 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.6350 ns | 0.0029 ns | 0.0024 ns |  1.6352 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.6370 ns | 0.0036 ns | 0.0034 ns |  4.6373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.8597 ns | 0.0043 ns | 0.0040 ns |  4.8585 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.4425 ns | 0.0071 ns | 0.0063 ns |  4.4418 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.8567 ns | 0.0059 ns | 0.0052 ns |  4.8567 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.8671 ns | 0.0073 ns | 0.0068 ns |  4.8684 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.1511 ns | 0.0031 ns | 0.0029 ns |  2.1514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.5375 ns | 0.0068 ns | 0.0064 ns |  2.5378 ns |  1.18 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.2478 ns | 0.0029 ns | 0.0027 ns |  2.2481 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.3370 ns | 0.0033 ns | 0.0031 ns |  1.3369 ns |  0.62 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.9465 ns | 0.0027 ns | 0.0026 ns |  1.9461 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.6374 ns | 0.0074 ns | 0.0069 ns |  4.6387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.7016 ns | 0.0070 ns | 0.0059 ns |  4.7028 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.4502 ns | 0.0041 ns | 0.0036 ns |  4.4509 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8526 ns | 0.0060 ns | 0.0050 ns |  4.8528 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.9114 ns | 0.0053 ns | 0.0050 ns |  4.9124 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.1828 ns | 0.0023 ns | 0.0019 ns |  2.1833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.3138 ns | 0.0079 ns | 0.0070 ns |  2.3125 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.9236 ns | 0.0029 ns | 0.0027 ns |  1.9231 ns |  0.88 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.3461 ns | 0.0027 ns | 0.0026 ns |  1.3461 ns |  0.62 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  1.6164 ns | 0.0031 ns | 0.0029 ns |  1.6160 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.7249 ns | 0.0045 ns | 0.0040 ns |  4.7251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.8584 ns | 0.0070 ns | 0.0065 ns |  4.8595 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.4846 ns | 0.0314 ns | 0.0294 ns |  4.4893 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.9055 ns | 0.0145 ns | 0.0135 ns |  4.9089 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8606 ns | 0.0045 ns | 0.0042 ns |  4.8612 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.5407 ns | 0.0091 ns | 0.0080 ns |  2.5390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.3065 ns | 0.0041 ns | 0.0039 ns |  2.3066 ns |  0.91 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.9120 ns | 0.0025 ns | 0.0024 ns |  1.9120 ns |  0.75 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.3411 ns | 0.0026 ns | 0.0024 ns |  1.3414 ns |  0.53 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.6451 ns | 0.0030 ns | 0.0028 ns |  1.6444 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.7307 ns | 0.0185 ns | 0.0173 ns |  4.7331 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.8534 ns | 0.0072 ns | 0.0064 ns |  4.8518 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4545 ns | 0.0074 ns | 0.0069 ns |  4.4545 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8975 ns | 0.0155 ns | 0.0145 ns |  4.9031 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8593 ns | 0.0063 ns | 0.0056 ns |  4.8586 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.1655 ns | 0.0029 ns | 0.0026 ns |  2.1650 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.5339 ns | 0.0043 ns | 0.0041 ns |  2.5329 ns |  1.17 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.9565 ns | 0.0018 ns | 0.0016 ns |  1.9563 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.5859 ns | 0.0029 ns | 0.0027 ns |  1.5853 ns |  0.73 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.8896 ns | 0.0029 ns | 0.0027 ns |  1.8899 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.6858 ns | 0.0036 ns | 0.0034 ns |  4.6867 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.9093 ns | 0.0040 ns | 0.0036 ns |  4.9078 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.4513 ns | 0.0067 ns | 0.0060 ns |  4.4525 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.8675 ns | 0.0078 ns | 0.0073 ns |  4.8648 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.8633 ns | 0.0051 ns | 0.0045 ns |  4.8643 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.0445 ns | 0.0034 ns | 0.0028 ns |  1.0439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.1908 ns | 0.0050 ns | 0.0046 ns |  1.1906 ns |  1.14 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9522 ns | 0.0027 ns | 0.0025 ns |  0.9522 ns |  0.91 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4344 ns | 0.0011 ns | 0.0010 ns |  0.4343 ns |  0.42 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  0.7142 ns | 0.0089 ns | 0.0084 ns |  0.7116 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9900 ns | 0.0058 ns | 0.0054 ns |  3.9902 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1673 ns | 0.0069 ns | 0.0064 ns |  4.1684 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.9948 ns | 0.0059 ns | 0.0055 ns |  3.9944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.1664 ns | 0.0059 ns | 0.0052 ns |  4.1671 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1807 ns | 0.0098 ns | 0.0087 ns |  4.1820 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.2672 ns | 0.0039 ns | 0.0036 ns |  1.2675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4178 ns | 0.0090 ns | 0.0080 ns |  1.4191 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9661 ns | 0.0020 ns | 0.0019 ns |  0.9660 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.3371 ns | 0.0024 ns | 0.0021 ns |  1.3369 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.6280 ns | 0.0028 ns | 0.0026 ns |  1.6280 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  3.9885 ns | 0.0041 ns | 0.0037 ns |  3.9884 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1713 ns | 0.0078 ns | 0.0069 ns |  4.1717 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.7971 ns | 0.0077 ns | 0.0069 ns |  3.7956 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6246 ns | 0.0044 ns | 0.0039 ns |  4.6251 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6685 ns | 0.0044 ns | 0.0041 ns |  4.6691 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.3688 ns | 0.0037 ns | 0.0032 ns |  1.3677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1550 ns | 0.0076 ns | 0.0067 ns |  1.1573 ns |  0.84 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9528 ns | 0.0022 ns | 0.0020 ns |  0.9524 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4424 ns | 0.0053 ns | 0.0050 ns |  0.4437 ns |  0.32 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.7239 ns | 0.0018 ns | 0.0017 ns |  0.7239 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.8805 ns | 0.0184 ns | 0.0173 ns |  1.8834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.5896 ns | 0.0030 ns | 0.0026 ns |  1.5898 ns |  0.85 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.6497 ns | 0.0017 ns | 0.0016 ns |  1.6493 ns |  0.88 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.8729 ns | 0.0026 ns | 0.0020 ns |  1.8727 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.8686 ns | 0.0166 ns | 0.0155 ns |  1.8593 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.2665 ns | 0.0026 ns | 0.0023 ns |  1.2672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4076 ns | 0.0025 ns | 0.0023 ns |  1.4074 ns |  1.11 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9932 ns | 0.0025 ns | 0.0023 ns |  0.9932 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.3619 ns | 0.0055 ns | 0.0051 ns |  1.3638 ns |  1.08 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.6458 ns | 0.0029 ns | 0.0027 ns |  1.6460 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.8669 ns | 0.0048 ns | 0.0040 ns |  1.8666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.0494 ns | 0.0029 ns | 0.0026 ns |  2.0484 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.8819 ns | 0.0135 ns | 0.0127 ns |  1.8861 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.5345 ns | 0.0030 ns | 0.0028 ns |  2.5347 ns |  1.36 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.7077 ns | 0.0186 ns | 0.0174 ns |  2.6994 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1719 ns | 0.0016 ns | 0.0015 ns |  1.1719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1800 ns | 0.0033 ns | 0.0031 ns |  1.1793 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1112 ns | 0.0026 ns | 0.0024 ns |  1.1116 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.4398 ns | 0.0018 ns | 0.0017 ns |  0.4402 ns |  0.38 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.7109 ns | 0.0024 ns | 0.0020 ns |  0.7112 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2263 ns | 0.0073 ns | 0.0057 ns |  4.2251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3982 ns | 0.0034 ns | 0.0030 ns |  4.3992 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2193 ns | 0.0037 ns | 0.0035 ns |  4.2180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.3960 ns | 0.0070 ns | 0.0058 ns |  4.3953 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4058 ns | 0.0060 ns | 0.0056 ns |  4.4060 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.1723 ns | 0.0020 ns | 0.0018 ns |  1.1722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1783 ns | 0.0036 ns | 0.0033 ns |  1.1780 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2156 ns | 0.0027 ns | 0.0024 ns |  1.2159 ns |  1.04 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4299 ns | 0.0018 ns | 0.0017 ns |  0.4303 ns |  0.37 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.7153 ns | 0.0034 ns | 0.0032 ns |  0.7153 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6413 ns | 0.0036 ns | 0.0033 ns |  1.6417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.5807 ns | 0.0023 ns | 0.0020 ns |  1.5804 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.6455 ns | 0.0146 ns | 0.0136 ns |  1.6388 ns |  1.00 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.5573 ns | 0.0782 ns | 0.1146 ns |  2.5463 ns |  1.55 |    0.08 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.0978 ns | 0.0028 ns | 0.0026 ns |  2.0984 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0547 ns | 0.0064 ns | 0.0060 ns |  6.0559 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0107 ns | 0.0080 ns | 0.0075 ns |  6.0087 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0322 ns | 0.0701 ns | 0.0621 ns |  6.0476 ns |  1.00 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.0078 ns | 0.0067 ns | 0.0063 ns |  6.0070 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.7826 ns | 0.0064 ns | 0.0056 ns |  5.7817 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.4980 ns | 0.0346 ns | 0.0323 ns | 18.4762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.2188 ns | 0.0671 ns | 0.0628 ns | 18.2367 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.0496 ns | 0.2828 ns | 0.2645 ns | 12.8698 ns |  0.71 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 17.9884 ns | 0.0196 ns | 0.0174 ns | 17.9898 ns |  0.97 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 17.7637 ns | 0.0190 ns | 0.0169 ns | 17.7638 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1255 ns | 0.0178 ns | 0.0167 ns |  2.1254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3026 ns | 0.0037 ns | 0.0034 ns |  2.3025 ns |  1.08 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1074 ns | 0.0042 ns | 0.0040 ns |  2.1059 ns |  0.99 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1811 ns | 0.0021 ns | 0.0019 ns |  1.1812 ns |  0.56 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1836 ns | 0.0013 ns | 0.0011 ns |  1.1837 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1363 ns | 0.0144 ns | 0.0128 ns |  8.1349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  7.8539 ns | 0.0077 ns | 0.0072 ns |  7.8537 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9252 ns | 0.0140 ns | 0.0131 ns |  1.9186 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.6048 ns | 0.0109 ns | 0.0102 ns |  8.6037 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.3457 ns | 0.0134 ns | 0.0118 ns |  8.3427 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.5541 ns | 0.0111 ns | 0.0099 ns |  3.5563 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.0345 ns | 0.0120 ns | 0.0113 ns |  4.0296 ns |  1.14 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8178 ns | 0.0253 ns | 0.0237 ns |  3.8175 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.6830 ns | 0.0146 ns | 0.0130 ns |  2.6858 ns |  0.75 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.7202 ns | 0.0096 ns | 0.0085 ns |  2.7195 ns |  0.77 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 25.2752 ns | 0.0207 ns | 0.0194 ns | 25.2771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 2.2 | 25.3091 ns | 0.0163 ns | 0.0152 ns | 25.3092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 3.0 | 22.9778 ns | 0.1629 ns | 0.1524 ns | 23.1038 ns |  0.91 |    0.01 |      - |     - |     - |         - |
          To_String |        net461 | 27.4932 ns | 0.0238 ns | 0.0211 ns | 27.4951 ns |  1.09 |    0.00 |      - |     - |     - |         - |
          To_String |        net472 | 27.6286 ns | 0.0252 ns | 0.0236 ns | 27.6254 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  0.9509 ns | 0.0027 ns | 0.0025 ns |  0.9506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.1471 ns | 0.0090 ns | 0.0084 ns |  1.1511 ns |  1.21 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  0.9556 ns | 0.0091 ns | 0.0085 ns |  0.9587 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 |  0.4353 ns | 0.0016 ns | 0.0015 ns |  0.4352 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  0.7072 ns | 0.0026 ns | 0.0024 ns |  0.7072 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  3.9909 ns | 0.0061 ns | 0.0057 ns |  3.9927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.3956 ns | 0.0046 ns | 0.0043 ns |  4.3947 ns |  1.10 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.2283 ns | 0.0079 ns | 0.0066 ns |  4.2280 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.1643 ns | 0.0050 ns | 0.0044 ns |  4.1649 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.2154 ns | 0.0080 ns | 0.0071 ns |  4.2174 ns |  1.06 |    0.00 |      - |     - |     - |         - |
