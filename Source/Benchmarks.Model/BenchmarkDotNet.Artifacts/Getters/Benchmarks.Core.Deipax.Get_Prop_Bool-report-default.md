
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
             ToBool | .NET Core 2.0 |  1.1809 ns | 0.0147 ns | 0.0130 ns |  1.1800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1676 ns | 0.0032 ns | 0.0029 ns |  1.1675 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.1860 ns | 0.0088 ns | 0.0082 ns |  1.1873 ns |  1.00 |    0.02 |      - |     - |     - |         - |
             ToBool |        net461 |  0.7208 ns | 0.0018 ns | 0.0016 ns |  0.7213 ns |  0.61 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4373 ns | 0.0063 ns | 0.0059 ns |  0.4347 ns |  0.37 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0752 ns | 0.0334 ns | 0.0279 ns |  4.0811 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4306 ns | 0.0230 ns | 0.0215 ns |  4.4370 ns |  1.09 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2771 ns | 0.0261 ns | 0.0244 ns |  4.2853 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1765 ns | 0.0056 ns | 0.0053 ns |  4.1757 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1670 ns | 0.0064 ns | 0.0053 ns |  4.1678 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.1962 ns | 0.0158 ns | 0.0148 ns |  1.1941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.1940 ns | 0.0039 ns | 0.0034 ns |  1.1941 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1840 ns | 0.0150 ns | 0.0141 ns |  1.1806 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  0.7197 ns | 0.0039 ns | 0.0031 ns |  0.7196 ns |  0.60 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  0.4313 ns | 0.0017 ns | 0.0015 ns |  0.4314 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0403 ns | 0.0481 ns | 0.0450 ns |  4.0303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2361 ns | 0.0268 ns | 0.0238 ns |  4.2327 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0575 ns | 0.0210 ns | 0.0186 ns |  4.0619 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.2119 ns | 0.0051 ns | 0.0042 ns |  4.2121 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1984 ns | 0.0248 ns | 0.0232 ns |  4.2053 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.1887 ns | 0.0228 ns | 0.0202 ns |  1.1829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.5115 ns | 0.0023 ns | 0.0021 ns |  1.5115 ns |  1.27 |    0.02 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5079 ns | 0.0160 ns | 0.0150 ns |  1.5075 ns |  1.27 |    0.02 |      - |     - |     - |         - |
            ToSByte |        net461 |  0.9242 ns | 0.0034 ns | 0.0030 ns |  0.9248 ns |  0.78 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  0.6773 ns | 0.0021 ns | 0.0019 ns |  0.6775 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  3.9156 ns | 0.0357 ns | 0.0317 ns |  3.9222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1604 ns | 0.0050 ns | 0.0047 ns |  4.1598 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0087 ns | 0.0173 ns | 0.0145 ns |  4.0088 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.2140 ns | 0.0124 ns | 0.0116 ns |  4.2154 ns |  1.08 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.1859 ns | 0.0257 ns | 0.0241 ns |  4.1690 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.6164 ns | 0.0324 ns | 0.0287 ns |  1.6150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.5083 ns | 0.0019 ns | 0.0015 ns |  1.5082 ns |  0.93 |    0.02 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5038 ns | 0.0113 ns | 0.0094 ns |  1.5020 ns |  0.93 |    0.02 |      - |     - |     - |         - |
             ToByte |        net461 |  0.9260 ns | 0.0030 ns | 0.0028 ns |  0.9269 ns |  0.57 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  0.6843 ns | 0.0052 ns | 0.0046 ns |  0.6836 ns |  0.42 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.0852 ns | 0.0232 ns | 0.0217 ns |  4.0976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1576 ns | 0.0062 ns | 0.0058 ns |  4.1584 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0311 ns | 0.0194 ns | 0.0172 ns |  4.0291 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.2045 ns | 0.0257 ns | 0.0240 ns |  4.2016 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.1675 ns | 0.0067 ns | 0.0063 ns |  4.1687 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4912 ns | 0.0124 ns | 0.0116 ns |  1.4963 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5099 ns | 0.0032 ns | 0.0029 ns |  1.5091 ns |  1.01 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.5205 ns | 0.0100 ns | 0.0093 ns |  1.5223 ns |  1.02 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  0.9528 ns | 0.0036 ns | 0.0032 ns |  0.9522 ns |  0.64 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  0.6785 ns | 0.0017 ns | 0.0014 ns |  0.6785 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0602 ns | 0.0078 ns | 0.0069 ns |  4.0612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1630 ns | 0.0060 ns | 0.0050 ns |  4.1641 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0526 ns | 0.0407 ns | 0.0380 ns |  4.0455 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.1730 ns | 0.0091 ns | 0.0076 ns |  4.1726 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.1694 ns | 0.0058 ns | 0.0052 ns |  4.1684 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.5765 ns | 0.0160 ns | 0.0142 ns |  1.5780 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5315 ns | 0.0039 ns | 0.0037 ns |  1.5294 ns |  0.97 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.5052 ns | 0.0089 ns | 0.0083 ns |  1.5024 ns |  0.96 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  0.9513 ns | 0.0040 ns | 0.0037 ns |  0.9503 ns |  0.60 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  0.6799 ns | 0.0034 ns | 0.0030 ns |  0.6791 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0982 ns | 0.0823 ns | 0.0730 ns |  4.0798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1634 ns | 0.0026 ns | 0.0024 ns |  4.1634 ns |  1.02 |    0.02 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0768 ns | 0.0426 ns | 0.0399 ns |  4.0705 ns |  1.00 |    0.02 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.1762 ns | 0.0077 ns | 0.0068 ns |  4.1755 ns |  1.02 |    0.02 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.1710 ns | 0.0075 ns | 0.0071 ns |  4.1691 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4856 ns | 0.0055 ns | 0.0049 ns |  1.4858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5094 ns | 0.0026 ns | 0.0023 ns |  1.5091 ns |  1.02 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.5085 ns | 0.0164 ns | 0.0153 ns |  1.5028 ns |  1.02 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  0.9231 ns | 0.0034 ns | 0.0030 ns |  0.9232 ns |  0.62 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  0.6771 ns | 0.0028 ns | 0.0025 ns |  0.6770 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0682 ns | 0.0244 ns | 0.0217 ns |  4.0593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2014 ns | 0.0136 ns | 0.0114 ns |  4.2045 ns |  1.03 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0436 ns | 0.0286 ns | 0.0254 ns |  4.0416 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.1673 ns | 0.0096 ns | 0.0086 ns |  4.1672 ns |  1.02 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1790 ns | 0.0229 ns | 0.0214 ns |  4.1688 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5702 ns | 0.0293 ns | 0.0244 ns |  1.5594 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.5110 ns | 0.0041 ns | 0.0037 ns |  1.5098 ns |  0.96 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5205 ns | 0.0168 ns | 0.0157 ns |  1.5158 ns |  0.97 |    0.02 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.9267 ns | 0.0036 ns | 0.0034 ns |  0.9267 ns |  0.59 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.6805 ns | 0.0042 ns | 0.0037 ns |  0.6800 ns |  0.43 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0957 ns | 0.0377 ns | 0.0353 ns |  4.1011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1725 ns | 0.0083 ns | 0.0069 ns |  4.1748 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0265 ns | 0.0279 ns | 0.0261 ns |  4.0137 ns |  0.98 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.1711 ns | 0.0057 ns | 0.0050 ns |  4.1709 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.1639 ns | 0.0038 ns | 0.0030 ns |  4.1640 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4632 ns | 0.0170 ns | 0.0150 ns |  1.4575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.5096 ns | 0.0040 ns | 0.0036 ns |  1.5095 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5245 ns | 0.0183 ns | 0.0172 ns |  1.5299 ns |  1.04 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  0.9499 ns | 0.0029 ns | 0.0027 ns |  0.9506 ns |  0.65 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  0.6755 ns | 0.0029 ns | 0.0027 ns |  0.6754 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.8001 ns | 0.0331 ns | 0.0293 ns |  1.7877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.3133 ns | 0.0691 ns | 0.0613 ns |  2.3170 ns |  1.29 |    0.04 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1258 ns | 0.0093 ns | 0.0078 ns |  2.1219 ns |  1.18 |    0.02 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.1976 ns | 0.0170 ns | 0.0133 ns |  2.2038 ns |  1.22 |    0.02 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1007 ns | 0.0037 ns | 0.0034 ns |  2.1019 ns |  1.17 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.4854 ns | 0.0025 ns | 0.0024 ns |  1.4853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5327 ns | 0.0116 ns | 0.0109 ns |  1.5347 ns |  1.03 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4980 ns | 0.0037 ns | 0.0033 ns |  1.4973 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  0.9537 ns | 0.0038 ns | 0.0035 ns |  0.9519 ns |  0.64 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  0.6820 ns | 0.0093 ns | 0.0087 ns |  0.6777 ns |  0.46 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0453 ns | 0.0167 ns | 0.0157 ns |  2.0485 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.9828 ns | 0.0194 ns | 0.0181 ns |  1.9786 ns |  0.97 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9588 ns | 0.0034 ns | 0.0030 ns |  1.9590 ns |  0.96 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.0241 ns | 0.0060 ns | 0.0050 ns |  2.0234 ns |  0.99 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.8418 ns | 0.0031 ns | 0.0029 ns |  1.8419 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3268 ns | 0.0168 ns | 0.0157 ns |  1.3207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4907 ns | 0.0133 ns | 0.0125 ns |  1.4885 ns |  1.12 |    0.02 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4552 ns | 0.0144 ns | 0.0120 ns |  1.4578 ns |  1.10 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.9203 ns | 0.0023 ns | 0.0021 ns |  0.9206 ns |  0.69 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.6769 ns | 0.0023 ns | 0.0022 ns |  0.6771 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.3960 ns | 0.0027 ns | 0.0024 ns |  4.3967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.6749 ns | 0.0322 ns | 0.0301 ns |  4.6570 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2395 ns | 0.0069 ns | 0.0064 ns |  4.2372 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6666 ns | 0.0276 ns | 0.0258 ns |  4.6810 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6678 ns | 0.0207 ns | 0.0193 ns |  4.6744 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5391 ns | 0.0047 ns | 0.0042 ns |  1.5399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.5061 ns | 0.0187 ns | 0.0175 ns |  1.5114 ns |  0.98 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4397 ns | 0.0019 ns | 0.0017 ns |  1.4397 ns |  0.94 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.9212 ns | 0.0031 ns | 0.0027 ns |  0.9197 ns |  0.60 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.6869 ns | 0.0109 ns | 0.0102 ns |  0.6819 ns |  0.45 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.0102 ns | 0.0110 ns | 0.0092 ns |  2.0072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.2813 ns | 0.0216 ns | 0.0202 ns |  2.2803 ns |  1.14 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.2577 ns | 0.0221 ns | 0.0207 ns |  2.2649 ns |  1.12 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1521 ns | 0.0042 ns | 0.0039 ns |  2.1516 ns |  1.07 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1057 ns | 0.0065 ns | 0.0061 ns |  2.1046 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.7689 ns | 0.0084 ns | 0.0078 ns |  5.7671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0365 ns | 0.0307 ns | 0.0287 ns |  6.0306 ns |  1.05 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8375 ns | 0.0062 ns | 0.0052 ns |  5.8368 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  9.9287 ns | 0.0093 ns | 0.0083 ns |  9.9257 ns |  1.72 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8302 ns | 0.0232 ns | 0.0217 ns |  5.8391 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.6726 ns | 0.0296 ns | 0.0247 ns | 18.6696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.8936 ns | 0.1099 ns | 0.1028 ns | 18.8889 ns |  1.01 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.6707 ns | 0.1107 ns | 0.1036 ns | 12.6539 ns |  0.68 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.0955 ns | 0.1067 ns | 0.0998 ns | 18.1474 ns |  0.97 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.2820 ns | 0.0198 ns | 0.0185 ns | 18.2755 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3137 ns | 0.0235 ns | 0.0219 ns |  2.3203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3728 ns | 0.0161 ns | 0.0151 ns |  2.3780 ns |  1.03 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3206 ns | 0.0035 ns | 0.0033 ns |  2.3210 ns |  1.00 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1727 ns | 0.0029 ns | 0.0026 ns |  1.1726 ns |  0.51 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1816 ns | 0.0031 ns | 0.0029 ns |  1.1812 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2537 ns | 0.0591 ns | 0.0553 ns |  8.2298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.1623 ns | 0.0551 ns | 0.0515 ns |  8.1610 ns |  0.99 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0877 ns | 0.0129 ns | 0.0121 ns |  2.0822 ns |  0.25 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1724 ns | 0.0144 ns | 0.0135 ns |  8.1724 ns |  0.99 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  7.9752 ns | 0.0100 ns | 0.0093 ns |  7.9723 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.2195 ns | 0.0124 ns | 0.0110 ns |  3.2203 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.8339 ns | 0.0272 ns | 0.0241 ns |  3.8373 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8184 ns | 0.0249 ns | 0.0221 ns |  3.8223 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.6713 ns | 0.0076 ns | 0.0067 ns |  2.6708 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.6535 ns | 0.0086 ns | 0.0081 ns |  2.6525 ns |  0.82 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  2.7149 ns | 0.0155 ns | 0.0145 ns |  2.7145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 2.2 |  3.2492 ns | 0.0247 ns | 0.0219 ns |  3.2580 ns |  1.20 |    0.01 |      - |     - |     - |         - |
          To_String | .NET Core 3.0 |  2.6206 ns | 0.0052 ns | 0.0046 ns |  2.6211 ns |  0.97 |    0.01 |      - |     - |     - |         - |
          To_String |        net461 |  2.3589 ns | 0.0058 ns | 0.0049 ns |  2.3577 ns |  0.87 |    0.01 |      - |     - |     - |         - |
          To_String |        net472 |  2.1443 ns | 0.0123 ns | 0.0115 ns |  2.1474 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  9.9119 ns | 0.0922 ns | 0.0862 ns |  9.9190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.2743 ns | 0.0677 ns | 0.0633 ns | 10.2554 ns |  1.04 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.3457 ns | 0.0084 ns | 0.0078 ns |  8.3459 ns |  0.84 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.0671 ns | 0.0102 ns | 0.0096 ns | 12.0659 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.1220 ns | 0.0174 ns | 0.0163 ns | 12.1124 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.2715 ns | 0.0746 ns | 0.0661 ns | 14.2540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.1889 ns | 0.1034 ns | 0.0967 ns | 15.1938 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.6294 ns | 0.0104 ns | 0.0092 ns | 12.6299 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.7959 ns | 0.0184 ns | 0.0163 ns | 16.8016 ns |  1.18 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.7349 ns | 0.0223 ns | 0.0197 ns | 16.7337 ns |  1.17 |    0.01 |      - |     - |     - |         - |
