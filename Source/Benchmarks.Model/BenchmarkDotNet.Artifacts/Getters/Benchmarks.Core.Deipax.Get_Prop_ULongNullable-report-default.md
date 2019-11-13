
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
             ToBool | .NET Core 2.0 |  1.1666 ns | 0.0048 ns | 0.0040 ns |  1.1662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6258 ns | 0.0167 ns | 0.0156 ns |  1.6347 ns |  1.39 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4138 ns | 0.0028 ns | 0.0024 ns |  1.4133 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.9709 ns | 0.0038 ns | 0.0034 ns |  0.9708 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  1.1777 ns | 0.0105 ns | 0.0099 ns |  1.1732 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2028 ns | 0.0082 ns | 0.0077 ns |  4.2032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.3946 ns | 0.0059 ns | 0.0055 ns |  4.3947 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.4380 ns | 0.0071 ns | 0.0067 ns |  4.4382 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.8412 ns | 0.0079 ns | 0.0074 ns |  4.8407 ns |  1.15 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.8393 ns | 0.0061 ns | 0.0057 ns |  4.8390 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.6385 ns | 0.0070 ns | 0.0065 ns |  2.6399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.6302 ns | 0.0191 ns | 0.0178 ns |  2.6213 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.8190 ns | 0.0065 ns | 0.0054 ns |  2.8179 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.0810 ns | 0.0090 ns | 0.0079 ns |  2.0796 ns |  0.79 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.3897 ns | 0.0104 ns | 0.0097 ns |  2.3925 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.3557 ns | 0.0067 ns | 0.0056 ns |  5.3557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.0970 ns | 0.0065 ns | 0.0057 ns |  5.0967 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.6676 ns | 0.0063 ns | 0.0056 ns |  4.6693 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3125 ns | 0.0130 ns | 0.0121 ns |  5.3115 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.3073 ns | 0.0094 ns | 0.0088 ns |  5.3058 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4150 ns | 0.0034 ns | 0.0030 ns |  1.4155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6405 ns | 0.0044 ns | 0.0036 ns |  1.6393 ns |  1.16 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.2616 ns | 0.0145 ns | 0.0136 ns |  1.2539 ns |  0.89 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.1020 ns | 0.0141 ns | 0.0132 ns |  2.1069 ns |  1.49 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.3747 ns | 0.0043 ns | 0.0040 ns |  2.3737 ns |  1.68 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4365 ns | 0.0119 ns | 0.0111 ns |  4.4346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4174 ns | 0.0060 ns | 0.0056 ns |  4.4162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.2301 ns | 0.0038 ns | 0.0036 ns |  4.2307 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3040 ns | 0.0090 ns | 0.0084 ns |  5.3052 ns |  1.20 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3041 ns | 0.0066 ns | 0.0055 ns |  5.3033 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.8529 ns | 0.0040 ns | 0.0036 ns |  2.8540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.6161 ns | 0.0047 ns | 0.0044 ns |  2.6157 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.9375 ns | 0.0161 ns | 0.0151 ns |  2.9399 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  2.0596 ns | 0.0075 ns | 0.0070 ns |  2.0581 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.3640 ns | 0.0080 ns | 0.0071 ns |  2.3660 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.3541 ns | 0.0050 ns | 0.0045 ns |  5.3531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.1349 ns | 0.0229 ns | 0.0214 ns |  5.1443 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7071 ns | 0.0101 ns | 0.0095 ns |  4.7062 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3618 ns | 0.0085 ns | 0.0079 ns |  5.3607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3168 ns | 0.0091 ns | 0.0085 ns |  5.3148 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.5734 ns | 0.0095 ns | 0.0084 ns |  2.5752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.9030 ns | 0.0046 ns | 0.0038 ns |  2.9023 ns |  1.13 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.8735 ns | 0.0041 ns | 0.0035 ns |  2.8724 ns |  1.12 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  2.0433 ns | 0.0029 ns | 0.0027 ns |  2.0437 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  2.3383 ns | 0.0017 ns | 0.0013 ns |  2.3384 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.3627 ns | 0.0093 ns | 0.0083 ns |  5.3634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.1033 ns | 0.0258 ns | 0.0228 ns |  5.0940 ns |  0.95 |    0.01 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.6698 ns | 0.0043 ns | 0.0038 ns |  4.6695 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3045 ns | 0.0106 ns | 0.0083 ns |  5.3044 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3117 ns | 0.0082 ns | 0.0073 ns |  5.3120 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.9105 ns | 0.0086 ns | 0.0081 ns |  2.9097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.8078 ns | 0.0085 ns | 0.0080 ns |  2.8100 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.6758 ns | 0.0088 ns | 0.0082 ns |  2.6768 ns |  0.92 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.0698 ns | 0.0041 ns | 0.0036 ns |  2.0702 ns |  0.71 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.3355 ns | 0.0105 ns | 0.0098 ns |  2.3383 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  5.3611 ns | 0.0065 ns | 0.0061 ns |  5.3607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  5.0942 ns | 0.0059 ns | 0.0055 ns |  5.0951 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.7063 ns | 0.0122 ns | 0.0114 ns |  4.7108 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3039 ns | 0.0079 ns | 0.0066 ns |  5.3030 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3072 ns | 0.0094 ns | 0.0084 ns |  5.3072 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  2.5663 ns | 0.0044 ns | 0.0039 ns |  2.5662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.9310 ns | 0.0130 ns | 0.0115 ns |  2.9350 ns |  1.14 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.4562 ns | 0.0108 ns | 0.0101 ns |  2.4561 ns |  0.96 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  2.0620 ns | 0.0027 ns | 0.0023 ns |  2.0620 ns |  0.80 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  2.3525 ns | 0.0054 ns | 0.0045 ns |  2.3520 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  5.1805 ns | 0.0078 ns | 0.0069 ns |  5.1792 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  5.0983 ns | 0.0092 ns | 0.0081 ns |  5.0987 ns |  0.98 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.6932 ns | 0.0057 ns | 0.0051 ns |  4.6935 ns |  0.91 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  5.0742 ns | 0.0086 ns | 0.0080 ns |  5.0749 ns |  0.98 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  5.0766 ns | 0.0071 ns | 0.0055 ns |  5.0770 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.7540 ns | 0.0060 ns | 0.0053 ns |  1.7526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6623 ns | 0.0135 ns | 0.0126 ns |  1.6662 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.3850 ns | 0.0026 ns | 0.0022 ns |  1.3842 ns |  0.79 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.0845 ns | 0.0045 ns | 0.0043 ns |  2.0839 ns |  1.19 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.3521 ns | 0.0037 ns | 0.0035 ns |  2.3528 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4350 ns | 0.0090 ns | 0.0084 ns |  4.4336 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4037 ns | 0.0144 ns | 0.0120 ns |  4.4002 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2366 ns | 0.0078 ns | 0.0065 ns |  4.2356 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.3070 ns | 0.0107 ns | 0.0089 ns |  5.3071 ns |  1.20 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.2969 ns | 0.0065 ns | 0.0061 ns |  5.2953 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4758 ns | 0.0039 ns | 0.0036 ns |  1.4763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6881 ns | 0.0026 ns | 0.0022 ns |  1.6884 ns |  1.14 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.3919 ns | 0.0139 ns | 0.0130 ns |  1.3971 ns |  0.94 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  2.0694 ns | 0.0031 ns | 0.0029 ns |  2.0703 ns |  1.40 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  2.3521 ns | 0.0114 ns | 0.0107 ns |  2.3570 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.1683 ns | 0.0040 ns | 0.0037 ns |  2.1699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.5112 ns | 0.0055 ns | 0.0052 ns |  2.5100 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1159 ns | 0.0038 ns | 0.0035 ns |  2.1166 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  3.1334 ns | 0.0078 ns | 0.0073 ns |  3.1330 ns |  1.45 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  3.1965 ns | 0.0045 ns | 0.0040 ns |  3.1969 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.3907 ns | 0.0140 ns | 0.0131 ns |  1.3825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6776 ns | 0.0128 ns | 0.0120 ns |  1.6824 ns |  1.21 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.5342 ns | 0.0171 ns | 0.0151 ns |  1.5277 ns |  1.10 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  1.8405 ns | 0.0036 ns | 0.0030 ns |  1.8407 ns |  1.32 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  1.8711 ns | 0.0051 ns | 0.0045 ns |  1.8712 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.6800 ns | 0.0046 ns | 0.0043 ns |  1.6794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.5974 ns | 0.0070 ns | 0.0062 ns |  1.5961 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.5284 ns | 0.0045 ns | 0.0042 ns |  1.5277 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.5091 ns | 0.0056 ns | 0.0052 ns |  1.5078 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.5958 ns | 0.0173 ns | 0.0162 ns |  1.5998 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.5270 ns | 0.0020 ns | 0.0018 ns |  1.5271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.8161 ns | 0.0054 ns | 0.0048 ns |  1.8143 ns |  1.19 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6797 ns | 0.0026 ns | 0.0024 ns |  1.6799 ns |  1.10 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.1505 ns | 0.0081 ns | 0.0072 ns |  1.1523 ns |  0.75 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.4349 ns | 0.0031 ns | 0.0028 ns |  1.4352 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.8952 ns | 0.0046 ns | 0.0040 ns |  4.8946 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  5.0969 ns | 0.0066 ns | 0.0059 ns |  5.0957 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.6966 ns | 0.0315 ns | 0.0295 ns |  4.7120 ns |  0.96 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.0718 ns | 0.0112 ns | 0.0105 ns |  5.0717 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.0705 ns | 0.0088 ns | 0.0083 ns |  5.0705 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6967 ns | 0.0029 ns | 0.0027 ns |  1.6973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.8206 ns | 0.0037 ns | 0.0034 ns |  1.8201 ns |  1.07 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.6668 ns | 0.0066 ns | 0.0059 ns |  1.6670 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.3375 ns | 0.0037 ns | 0.0033 ns |  1.3361 ns |  0.79 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.6684 ns | 0.0167 ns | 0.0156 ns |  1.6622 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.3933 ns | 0.0040 ns | 0.0033 ns |  2.3933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.3228 ns | 0.0111 ns | 0.0104 ns |  2.3262 ns |  0.97 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8995 ns | 0.0184 ns | 0.0172 ns |  1.8891 ns |  0.79 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.5317 ns | 0.0074 ns | 0.0066 ns |  2.5320 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5371 ns | 0.0115 ns | 0.0108 ns |  2.5350 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0565 ns | 0.0167 ns | 0.0156 ns |  6.0523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0586 ns | 0.0453 ns | 0.0424 ns |  6.0343 ns |  1.00 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0724 ns | 0.0056 ns | 0.0049 ns |  6.0724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.2985 ns | 0.0315 ns | 0.0279 ns |  6.3057 ns |  1.04 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.3164 ns | 0.0119 ns | 0.0106 ns |  6.3146 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.0627 ns | 0.0244 ns | 0.0228 ns | 18.0568 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.3694 ns | 0.0820 ns | 0.0727 ns | 18.3557 ns |  1.02 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.1315 ns | 0.2152 ns | 0.2013 ns | 13.2131 ns |  0.73 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.9043 ns | 0.0269 ns | 0.0239 ns | 18.9002 ns |  1.05 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.5152 ns | 0.0507 ns | 0.0474 ns | 18.4985 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  1.8399 ns | 0.0040 ns | 0.0033 ns |  1.8403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3034 ns | 0.0055 ns | 0.0049 ns |  2.3034 ns |  1.25 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1367 ns | 0.0040 ns | 0.0033 ns |  2.1375 ns |  1.16 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  0.9951 ns | 0.0024 ns | 0.0023 ns |  0.9951 ns |  0.54 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1305 ns | 0.0036 ns | 0.0032 ns |  1.1306 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9803 ns | 0.0448 ns | 0.0419 ns |  7.9595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4766 ns | 0.0092 ns | 0.0071 ns |  8.4766 ns |  1.06 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9106 ns | 0.0188 ns | 0.0175 ns |  1.9156 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2303 ns | 0.0219 ns | 0.0205 ns |  8.2345 ns |  1.03 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.6731 ns | 0.0520 ns | 0.0487 ns |  8.6525 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8559 ns | 0.0334 ns | 0.0313 ns |  3.8535 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5394 ns | 0.0177 ns | 0.0157 ns |  4.5376 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5159 ns | 0.0311 ns | 0.0291 ns |  4.5255 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.7280 ns | 0.0087 ns | 0.0077 ns |  3.7293 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.9808 ns | 0.0219 ns | 0.0195 ns |  3.9754 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 30.3405 ns | 0.1152 ns | 0.1022 ns | 30.3371 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 19.3802 ns | 0.0269 ns | 0.0239 ns | 19.3738 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.8200 ns | 0.0218 ns | 0.0204 ns | 12.8221 ns |  0.42 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.2675 ns | 0.0758 ns | 0.0709 ns | 31.2695 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.1974 ns | 0.0571 ns | 0.0506 ns | 31.1834 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 13.1776 ns | 0.0865 ns | 0.0809 ns | 13.1589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 13.9620 ns | 0.0678 ns | 0.0635 ns | 13.9746 ns |  1.06 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.6723 ns | 0.0085 ns | 0.0080 ns |  8.6743 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.5072 ns | 0.0228 ns | 0.0213 ns | 15.5146 ns |  1.18 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.6628 ns | 0.0199 ns | 0.0186 ns | 15.6539 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 17.0471 ns | 0.0212 ns | 0.0188 ns | 17.0469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 17.0971 ns | 0.0251 ns | 0.0235 ns | 17.0910 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.3965 ns | 0.0172 ns | 0.0161 ns | 13.3976 ns |  0.79 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 20.1656 ns | 0.0254 ns | 0.0237 ns | 20.1720 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.0307 ns | 0.0434 ns | 0.0406 ns | 20.0340 ns |  1.18 |    0.00 |      - |     - |     - |         - |
