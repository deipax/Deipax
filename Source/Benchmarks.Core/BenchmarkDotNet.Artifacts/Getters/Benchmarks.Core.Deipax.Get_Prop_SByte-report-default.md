
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
             ToBool | .NET Core 2.0 |  1.1856 ns | 0.0049 ns | 0.0046 ns |  1.1852 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1895 ns | 0.0029 ns | 0.0026 ns |  1.1894 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.0863 ns | 0.0025 ns | 0.0024 ns |  1.0861 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4401 ns | 0.0038 ns | 0.0035 ns |  0.4389 ns |  0.37 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.7133 ns | 0.0025 ns | 0.0022 ns |  0.7132 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0082 ns | 0.0034 ns | 0.0030 ns |  4.0081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1855 ns | 0.0055 ns | 0.0052 ns |  4.1848 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9684 ns | 0.0199 ns | 0.0186 ns |  3.9771 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2070 ns | 0.0150 ns | 0.0140 ns |  4.2118 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1446 ns | 0.0062 ns | 0.0058 ns |  4.1464 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.7413 ns | 0.0045 ns | 0.0040 ns |  1.7408 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.5170 ns | 0.0031 ns | 0.0029 ns |  1.5168 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.0987 ns | 0.0019 ns | 0.0018 ns |  1.0985 ns |  0.63 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.3543 ns | 0.0030 ns | 0.0028 ns |  1.3544 ns |  0.78 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.6370 ns | 0.0043 ns | 0.0036 ns |  1.6375 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0113 ns | 0.0100 ns | 0.0089 ns |  4.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1884 ns | 0.0071 ns | 0.0067 ns |  4.1870 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9423 ns | 0.0055 ns | 0.0052 ns |  3.9415 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.8752 ns | 0.0062 ns | 0.0055 ns |  4.8749 ns |  1.22 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.8768 ns | 0.0321 ns | 0.0285 ns |  4.8843 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.1783 ns | 0.0025 ns | 0.0023 ns |  1.1781 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.1922 ns | 0.0063 ns | 0.0053 ns |  1.1939 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.1033 ns | 0.0018 ns | 0.0015 ns |  1.1034 ns |  0.94 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  0.4401 ns | 0.0018 ns | 0.0017 ns |  0.4406 ns |  0.37 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  0.7174 ns | 0.0032 ns | 0.0028 ns |  0.7178 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.0086 ns | 0.0059 ns | 0.0055 ns |  4.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4182 ns | 0.0041 ns | 0.0034 ns |  4.4187 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.1739 ns | 0.0058 ns | 0.0052 ns |  4.1735 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.1811 ns | 0.0044 ns | 0.0039 ns |  4.1822 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.1858 ns | 0.0099 ns | 0.0082 ns |  4.1859 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.6448 ns | 0.0024 ns | 0.0023 ns |  1.6448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4877 ns | 0.0025 ns | 0.0021 ns |  1.4872 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.0855 ns | 0.0027 ns | 0.0025 ns |  1.0859 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.3636 ns | 0.0091 ns | 0.0086 ns |  1.3653 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.6674 ns | 0.0059 ns | 0.0055 ns |  1.6674 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.0063 ns | 0.0046 ns | 0.0038 ns |  4.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1854 ns | 0.0057 ns | 0.0050 ns |  4.1867 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  3.9571 ns | 0.0132 ns | 0.0124 ns |  3.9541 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.8697 ns | 0.0077 ns | 0.0068 ns |  4.8715 ns |  1.22 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8806 ns | 0.0188 ns | 0.0157 ns |  4.8835 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.1903 ns | 0.0069 ns | 0.0065 ns |  1.1928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.1840 ns | 0.0038 ns | 0.0036 ns |  1.1852 ns |  0.99 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.0829 ns | 0.0022 ns | 0.0020 ns |  1.0828 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  0.4462 ns | 0.0018 ns | 0.0016 ns |  0.4464 ns |  0.37 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  0.7172 ns | 0.0045 ns | 0.0042 ns |  0.7171 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0229 ns | 0.0108 ns | 0.0101 ns |  4.0212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.2001 ns | 0.0242 ns | 0.0226 ns |  4.1978 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  3.9472 ns | 0.0048 ns | 0.0045 ns |  3.9468 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.1729 ns | 0.0048 ns | 0.0043 ns |  4.1731 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.1404 ns | 0.0059 ns | 0.0052 ns |  4.1416 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6590 ns | 0.0109 ns | 0.0097 ns |  1.6625 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.7020 ns | 0.0043 ns | 0.0040 ns |  1.7008 ns |  1.03 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.1096 ns | 0.0099 ns | 0.0092 ns |  1.1111 ns |  0.67 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.5847 ns | 0.0026 ns | 0.0024 ns |  1.5854 ns |  0.96 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.8698 ns | 0.0023 ns | 0.0020 ns |  1.8704 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0168 ns | 0.0055 ns | 0.0051 ns |  4.0161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1861 ns | 0.0066 ns | 0.0062 ns |  4.1854 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9417 ns | 0.0096 ns | 0.0085 ns |  3.9408 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.8639 ns | 0.0094 ns | 0.0088 ns |  4.8665 ns |  1.21 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.8288 ns | 0.0066 ns | 0.0055 ns |  4.8289 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1778 ns | 0.0031 ns | 0.0029 ns |  1.1789 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.1897 ns | 0.0021 ns | 0.0019 ns |  1.1899 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.0998 ns | 0.0041 ns | 0.0039 ns |  1.0999 ns |  0.93 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4429 ns | 0.0020 ns | 0.0019 ns |  0.4439 ns |  0.38 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  0.7163 ns | 0.0023 ns | 0.0022 ns |  0.7160 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0203 ns | 0.0063 ns | 0.0056 ns |  4.0192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1930 ns | 0.0129 ns | 0.0121 ns |  4.1887 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.9727 ns | 0.0165 ns | 0.0154 ns |  3.9770 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.2089 ns | 0.0125 ns | 0.0117 ns |  4.2087 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1506 ns | 0.0122 ns | 0.0108 ns |  4.1491 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6465 ns | 0.0067 ns | 0.0063 ns |  1.6472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4862 ns | 0.0026 ns | 0.0022 ns |  1.4864 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.0808 ns | 0.0029 ns | 0.0026 ns |  1.0810 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.5930 ns | 0.0027 ns | 0.0022 ns |  1.5933 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.8876 ns | 0.0026 ns | 0.0025 ns |  1.8873 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0169 ns | 0.0055 ns | 0.0046 ns |  4.0178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1909 ns | 0.0068 ns | 0.0063 ns |  4.1924 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.7106 ns | 0.0069 ns | 0.0065 ns |  3.7093 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6380 ns | 0.0038 ns | 0.0034 ns |  4.6381 ns |  1.15 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6013 ns | 0.0052 ns | 0.0049 ns |  4.6016 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.1921 ns | 0.0041 ns | 0.0039 ns |  1.1918 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1835 ns | 0.0024 ns | 0.0022 ns |  1.1828 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.0802 ns | 0.0032 ns | 0.0030 ns |  1.0811 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4442 ns | 0.0013 ns | 0.0012 ns |  0.4440 ns |  0.37 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.7134 ns | 0.0018 ns | 0.0015 ns |  0.7137 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.7859 ns | 0.0027 ns | 0.0025 ns |  1.7856 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.7971 ns | 0.0032 ns | 0.0030 ns |  1.7956 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.5394 ns | 0.0024 ns | 0.0020 ns |  1.5392 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.8832 ns | 0.0070 ns | 0.0058 ns |  1.8814 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.7974 ns | 0.0026 ns | 0.0022 ns |  1.7975 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.6306 ns | 0.0050 ns | 0.0042 ns |  1.6297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5012 ns | 0.0021 ns | 0.0019 ns |  1.5010 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.0941 ns | 0.0030 ns | 0.0026 ns |  1.0937 ns |  0.67 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.3693 ns | 0.0032 ns | 0.0028 ns |  1.3691 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.6407 ns | 0.0063 ns | 0.0059 ns |  1.6392 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.2066 ns | 0.0035 ns | 0.0031 ns |  2.2070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.3479 ns | 0.0109 ns | 0.0102 ns |  2.3437 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7874 ns | 0.0069 ns | 0.0061 ns |  1.7862 ns |  0.81 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.7980 ns | 0.0074 ns | 0.0069 ns |  2.7978 ns |  1.27 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.7429 ns | 0.0235 ns | 0.0220 ns |  2.7541 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1637 ns | 0.0028 ns | 0.0025 ns |  1.1645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.2301 ns | 0.0035 ns | 0.0031 ns |  1.2294 ns |  1.06 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1193 ns | 0.0031 ns | 0.0029 ns |  1.1191 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.6707 ns | 0.0030 ns | 0.0025 ns |  0.6706 ns |  0.58 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.9370 ns | 0.0019 ns | 0.0018 ns |  0.9371 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2766 ns | 0.0150 ns | 0.0125 ns |  4.2813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4450 ns | 0.0207 ns | 0.0194 ns |  4.4515 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2074 ns | 0.0085 ns | 0.0080 ns |  4.2067 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4137 ns | 0.0079 ns | 0.0070 ns |  4.4157 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.3790 ns | 0.0088 ns | 0.0082 ns |  4.3785 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3993 ns | 0.0036 ns | 0.0033 ns |  1.3986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2308 ns | 0.0022 ns | 0.0020 ns |  1.2308 ns |  0.88 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.0898 ns | 0.0025 ns | 0.0022 ns |  1.0895 ns |  0.78 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4335 ns | 0.0017 ns | 0.0015 ns |  0.4340 ns |  0.31 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.7434 ns | 0.0024 ns | 0.0023 ns |  0.7437 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9599 ns | 0.0037 ns | 0.0034 ns |  1.9596 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6782 ns | 0.0035 ns | 0.0033 ns |  1.6778 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.5400 ns | 0.0026 ns | 0.0022 ns |  1.5399 ns |  0.79 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.6421 ns | 0.0035 ns | 0.0031 ns |  1.6423 ns |  0.84 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.5560 ns | 0.0063 ns | 0.0056 ns |  1.5552 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0818 ns | 0.0056 ns | 0.0052 ns |  6.0813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.8053 ns | 0.0041 ns | 0.0039 ns |  5.8058 ns |  0.95 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8132 ns | 0.0149 ns | 0.0139 ns |  5.8133 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8405 ns | 0.0119 ns | 0.0105 ns |  5.8439 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.9933 ns | 0.0093 ns | 0.0082 ns |  5.9930 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.5677 ns | 0.0222 ns | 0.0185 ns | 18.5684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.5547 ns | 0.0373 ns | 0.0349 ns | 18.5550 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.0552 ns | 0.2200 ns | 0.1950 ns | 13.1390 ns |  0.70 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 17.7761 ns | 0.0237 ns | 0.0210 ns | 17.7729 ns |  0.96 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.4768 ns | 0.0778 ns | 0.0650 ns | 18.5016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3214 ns | 0.0032 ns | 0.0030 ns |  2.3214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3702 ns | 0.0052 ns | 0.0049 ns |  2.3688 ns |  1.02 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2796 ns | 0.0146 ns | 0.0137 ns |  2.2840 ns |  0.98 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1964 ns | 0.0046 ns | 0.0039 ns |  1.1954 ns |  0.52 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1107 ns | 0.0022 ns | 0.0021 ns |  1.1110 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0234 ns | 0.0106 ns | 0.0099 ns |  8.0237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  7.9570 ns | 0.0146 ns | 0.0136 ns |  7.9596 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0817 ns | 0.0058 ns | 0.0054 ns |  2.0816 ns |  0.26 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  7.9783 ns | 0.0139 ns | 0.0123 ns |  7.9790 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1724 ns | 0.0106 ns | 0.0099 ns |  8.1756 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.4466 ns | 0.0067 ns | 0.0060 ns |  3.4463 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.0045 ns | 0.0095 ns | 0.0079 ns |  4.0041 ns |  1.16 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.7145 ns | 0.0302 ns | 0.0267 ns |  3.7169 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.7083 ns | 0.0063 ns | 0.0049 ns |  2.7089 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.6959 ns | 0.0089 ns | 0.0074 ns |  2.6942 ns |  0.78 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.2171 ns | 0.0395 ns | 0.0330 ns | 29.2014 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.1068 ns | 0.0338 ns | 0.0316 ns | 17.1043 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.6991 ns | 0.0328 ns | 0.0306 ns | 12.7041 ns |  0.43 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 30.1250 ns | 0.0848 ns | 0.0751 ns | 30.1144 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.4219 ns | 0.0515 ns | 0.0482 ns | 31.4081 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.1389 ns | 0.0080 ns | 0.0067 ns | 10.1381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.2487 ns | 0.0143 ns | 0.0133 ns | 10.2495 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.1972 ns | 0.0084 ns | 0.0078 ns |  8.1954 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.3460 ns | 0.0746 ns | 0.0697 ns | 12.3379 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.2160 ns | 0.0450 ns | 0.0421 ns | 12.2043 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.5028 ns | 0.0350 ns | 0.0310 ns | 14.4983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 14.8452 ns | 0.0158 ns | 0.0132 ns | 14.8424 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.6857 ns | 0.0373 ns | 0.0331 ns | 12.6951 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.7768 ns | 0.0318 ns | 0.0298 ns | 16.7664 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.8013 ns | 0.0381 ns | 0.0319 ns | 16.8042 ns |  1.16 |    0.00 |      - |     - |     - |         - |
