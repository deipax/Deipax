
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
             ToBool | .NET Core 2.0 |  1.2636 ns | 0.0032 ns | 0.0029 ns |  1.2636 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.5996 ns | 0.0047 ns | 0.0041 ns |  1.5993 ns |  1.27 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.6347 ns | 0.0048 ns | 0.0040 ns |  1.6333 ns |  1.29 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9890 ns | 0.0031 ns | 0.0029 ns |  0.9893 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9929 ns | 0.0041 ns | 0.0032 ns |  0.9929 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0232 ns | 0.0216 ns | 0.0202 ns |  4.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1677 ns | 0.0064 ns | 0.0053 ns |  4.1678 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9515 ns | 0.0067 ns | 0.0059 ns |  3.9523 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1477 ns | 0.0084 ns | 0.0070 ns |  4.1464 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1853 ns | 0.0095 ns | 0.0084 ns |  4.1828 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.6122 ns | 0.0030 ns | 0.0027 ns |  1.6125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4836 ns | 0.0166 ns | 0.0155 ns |  1.4761 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.5202 ns | 0.0103 ns | 0.0091 ns |  1.5220 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  1.3144 ns | 0.0028 ns | 0.0023 ns |  1.3146 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  1.0029 ns | 0.0030 ns | 0.0025 ns |  1.0031 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.5163 ns | 0.0054 ns | 0.0048 ns |  4.5160 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.3948 ns | 0.0040 ns | 0.0038 ns |  4.3955 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9472 ns | 0.0052 ns | 0.0049 ns |  3.9474 ns |  0.87 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3787 ns | 0.0072 ns | 0.0060 ns |  4.3778 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4101 ns | 0.0070 ns | 0.0062 ns |  4.4097 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2291 ns | 0.0052 ns | 0.0044 ns |  1.2290 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.5340 ns | 0.0035 ns | 0.0033 ns |  1.5335 ns |  1.25 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5635 ns | 0.0045 ns | 0.0042 ns |  1.5628 ns |  1.27 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9931 ns | 0.0039 ns | 0.0035 ns |  0.9924 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9983 ns | 0.0106 ns | 0.0099 ns |  0.9940 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4974 ns | 0.0247 ns | 0.0219 ns |  4.5055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.3964 ns | 0.0063 ns | 0.0056 ns |  4.3951 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0134 ns | 0.0071 ns | 0.0066 ns |  4.0133 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.3926 ns | 0.0206 ns | 0.0193 ns |  4.3828 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4110 ns | 0.0078 ns | 0.0073 ns |  4.4101 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.3091 ns | 0.0041 ns | 0.0038 ns |  1.3091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6154 ns | 0.0120 ns | 0.0106 ns |  1.6187 ns |  1.23 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.6548 ns | 0.0118 ns | 0.0098 ns |  1.6578 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9920 ns | 0.0038 ns | 0.0032 ns |  0.9919 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  1.3403 ns | 0.0145 ns | 0.0136 ns |  1.3344 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.4857 ns | 0.0216 ns | 0.0180 ns |  4.4822 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.3975 ns | 0.0128 ns | 0.0113 ns |  4.3951 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  3.9534 ns | 0.0073 ns | 0.0068 ns |  3.9543 ns |  0.88 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.3787 ns | 0.0081 ns | 0.0076 ns |  4.3807 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4069 ns | 0.0040 ns | 0.0036 ns |  4.4064 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4427 ns | 0.0067 ns | 0.0063 ns |  1.4415 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6022 ns | 0.0047 ns | 0.0039 ns |  1.6024 ns |  1.11 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6493 ns | 0.0102 ns | 0.0085 ns |  1.6515 ns |  1.14 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  1.1787 ns | 0.0020 ns | 0.0017 ns |  1.1785 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  1.2103 ns | 0.0022 ns | 0.0018 ns |  1.2102 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2282 ns | 0.0050 ns | 0.0047 ns |  4.2293 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1598 ns | 0.0044 ns | 0.0041 ns |  4.1604 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0237 ns | 0.0048 ns | 0.0044 ns |  4.0239 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.3746 ns | 0.0058 ns | 0.0051 ns |  4.3736 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4149 ns | 0.0069 ns | 0.0061 ns |  4.4155 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.2814 ns | 0.0048 ns | 0.0045 ns |  1.2807 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5306 ns | 0.0024 ns | 0.0021 ns |  1.5301 ns |  1.19 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.5652 ns | 0.0106 ns | 0.0094 ns |  1.5660 ns |  1.22 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9914 ns | 0.0045 ns | 0.0040 ns |  0.9910 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9898 ns | 0.0022 ns | 0.0017 ns |  0.9904 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.4655 ns | 0.0076 ns | 0.0064 ns |  4.4644 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4456 ns | 0.0047 ns | 0.0041 ns |  4.4453 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0197 ns | 0.0060 ns | 0.0056 ns |  4.0211 ns |  0.90 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.3817 ns | 0.0095 ns | 0.0079 ns |  4.3812 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4076 ns | 0.0046 ns | 0.0043 ns |  4.4066 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.2251 ns | 0.0033 ns | 0.0030 ns |  1.2250 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.6037 ns | 0.0040 ns | 0.0037 ns |  1.6033 ns |  1.31 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6408 ns | 0.0063 ns | 0.0056 ns |  1.6400 ns |  1.34 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9606 ns | 0.0044 ns | 0.0037 ns |  0.9593 ns |  0.78 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9595 ns | 0.0030 ns | 0.0025 ns |  0.9596 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.5057 ns | 0.0128 ns | 0.0120 ns |  4.5099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.3951 ns | 0.0046 ns | 0.0038 ns |  4.3952 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0236 ns | 0.0077 ns | 0.0072 ns |  4.0237 ns |  0.89 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.3773 ns | 0.0072 ns | 0.0064 ns |  4.3779 ns |  0.97 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4336 ns | 0.0328 ns | 0.0307 ns |  4.4144 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4680 ns | 0.0028 ns | 0.0024 ns |  1.4685 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.5035 ns | 0.0045 ns | 0.0043 ns |  1.5034 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5305 ns | 0.0039 ns | 0.0033 ns |  1.5304 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.2158 ns | 0.0043 ns | 0.0040 ns |  1.2165 ns |  0.83 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.1563 ns | 0.0018 ns | 0.0017 ns |  1.1558 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  1.1944 ns | 0.0074 ns | 0.0069 ns |  1.1950 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  1.1523 ns | 0.0102 ns | 0.0095 ns |  1.1553 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  1.1828 ns | 0.0063 ns | 0.0059 ns |  1.1837 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  1.4540 ns | 0.0041 ns | 0.0032 ns |  1.4544 ns |  1.22 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  1.1697 ns | 0.0042 ns | 0.0039 ns |  1.1688 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.2578 ns | 0.0113 ns | 0.0106 ns |  1.2542 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4046 ns | 0.0026 ns | 0.0023 ns |  1.4053 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4506 ns | 0.0048 ns | 0.0045 ns |  1.4519 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9915 ns | 0.0032 ns | 0.0028 ns |  0.9916 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  1.0183 ns | 0.0032 ns | 0.0029 ns |  1.0189 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.1269 ns | 0.0132 ns | 0.0117 ns |  2.1305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.6664 ns | 0.0034 ns | 0.0032 ns |  1.6663 ns |  0.78 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1489 ns | 0.0028 ns | 0.0022 ns |  2.1498 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.0543 ns | 0.0084 ns | 0.0070 ns |  2.0552 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.2513 ns | 0.0046 ns | 0.0040 ns |  2.2514 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4124 ns | 0.0097 ns | 0.0086 ns |  1.4093 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5995 ns | 0.0045 ns | 0.0040 ns |  1.5982 ns |  1.13 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4760 ns | 0.0064 ns | 0.0057 ns |  1.4737 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  1.1817 ns | 0.0032 ns | 0.0028 ns |  1.1815 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  1.6981 ns | 0.0611 ns | 0.1404 ns |  1.6962 ns |  1.15 |    0.10 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.8677 ns | 0.0051 ns | 0.0045 ns |  1.8676 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2958 ns | 0.0061 ns | 0.0054 ns |  2.2944 ns |  1.23 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0230 ns | 0.0051 ns | 0.0045 ns |  2.0236 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.2888 ns | 0.0129 ns | 0.0115 ns |  2.2915 ns |  1.23 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.3218 ns | 0.0059 ns | 0.0055 ns |  2.3209 ns |  1.24 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4108 ns | 0.0103 ns | 0.0091 ns |  1.4069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.5839 ns | 0.0035 ns | 0.0031 ns |  1.5839 ns |  1.12 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.5039 ns | 0.0036 ns | 0.0032 ns |  1.5040 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.1800 ns | 0.0051 ns | 0.0048 ns |  1.1787 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1681 ns | 0.0142 ns | 0.0132 ns |  1.1605 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2783 ns | 0.0080 ns | 0.0071 ns |  4.2766 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3939 ns | 0.0047 ns | 0.0042 ns |  4.3935 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2603 ns | 0.0122 ns | 0.0114 ns |  4.2599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6569 ns | 0.0207 ns | 0.0173 ns |  4.6604 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6483 ns | 0.0045 ns | 0.0042 ns |  4.6476 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6466 ns | 0.0045 ns | 0.0042 ns |  1.6453 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6290 ns | 0.0029 ns | 0.0024 ns |  1.6289 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4489 ns | 0.0044 ns | 0.0041 ns |  1.4485 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.2013 ns | 0.0031 ns | 0.0028 ns |  1.2011 ns |  0.73 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.1512 ns | 0.0026 ns | 0.0023 ns |  1.1512 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.1042 ns | 0.0029 ns | 0.0027 ns |  2.1033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0388 ns | 0.0028 ns | 0.0025 ns |  2.0397 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1495 ns | 0.0039 ns | 0.0037 ns |  2.1493 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.0828 ns | 0.0038 ns | 0.0034 ns |  2.0823 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.2308 ns | 0.0137 ns | 0.0122 ns |  2.2340 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.3622 ns | 0.0036 ns | 0.0034 ns |  2.3621 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1979 ns | 0.0045 ns | 0.0042 ns |  2.1977 ns |  0.93 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.4871 ns | 0.0065 ns | 0.0061 ns |  2.4864 ns |  1.05 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0138 ns | 0.0081 ns | 0.0076 ns |  6.0152 ns |  2.55 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0375 ns | 0.0072 ns | 0.0067 ns |  6.0375 ns |  2.56 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0116 ns | 0.0121 ns | 0.0107 ns | 10.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.6880 ns | 0.0136 ns | 0.0127 ns | 10.6855 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.2390 ns | 0.0048 ns | 0.0045 ns |  2.2383 ns |  0.22 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6430 ns | 0.0133 ns | 0.0118 ns | 10.6431 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.8274 ns | 0.0115 ns | 0.0102 ns | 10.8263 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3358 ns | 0.0071 ns | 0.0066 ns |  2.3331 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3357 ns | 0.0080 ns | 0.0066 ns |  2.3370 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1500 ns | 0.0042 ns | 0.0037 ns |  2.1491 ns |  0.92 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1520 ns | 0.0025 ns | 0.0021 ns |  1.1519 ns |  0.49 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1677 ns | 0.0029 ns | 0.0027 ns |  1.1681 ns |  0.50 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1658 ns | 0.0119 ns | 0.0106 ns |  8.1648 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2043 ns | 0.0094 ns | 0.0079 ns |  8.2056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.3657 ns | 0.0034 ns | 0.0028 ns |  2.3662 ns |  0.29 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.8853 ns | 0.0182 ns | 0.0161 ns |  8.8806 ns |  1.09 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4407 ns | 0.0449 ns | 0.0420 ns |  8.4208 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2383 ns | 0.0045 ns | 0.0037 ns |  1.2380 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4617 ns | 0.0035 ns | 0.0033 ns |  1.4607 ns |  1.18 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.6439 ns | 0.0031 ns | 0.0028 ns |  1.6431 ns |  1.33 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9777 ns | 0.0025 ns | 0.0022 ns |  0.9776 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9836 ns | 0.0035 ns | 0.0031 ns |  0.9840 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.4265 ns | 0.0062 ns | 0.0058 ns |  1.4245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.7062 ns | 0.0211 ns | 0.0197 ns |  1.6934 ns |  1.20 |    0.02 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.5527 ns | 0.0059 ns | 0.0053 ns |  1.5518 ns |  1.09 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.2686 ns | 0.0037 ns | 0.0035 ns |  1.2682 ns |  0.89 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2644 ns | 0.0035 ns | 0.0030 ns |  1.2646 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4090 ns | 0.0023 ns | 0.0018 ns |  1.4088 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6358 ns | 0.0081 ns | 0.0071 ns |  1.6378 ns |  1.16 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.4413 ns | 0.0057 ns | 0.0054 ns |  1.4407 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2660 ns | 0.0031 ns | 0.0026 ns |  1.2657 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.7870 ns | 0.0030 ns | 0.0028 ns |  1.7874 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2296 ns | 0.0049 ns | 0.0044 ns |  4.2289 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.3968 ns | 0.0057 ns | 0.0051 ns |  4.3957 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  3.9503 ns | 0.0074 ns | 0.0066 ns |  3.9497 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6628 ns | 0.0134 ns | 0.0126 ns |  4.6665 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6445 ns | 0.0103 ns | 0.0092 ns |  4.6425 ns |  1.10 |    0.00 |     - |     - |     - |         - |
