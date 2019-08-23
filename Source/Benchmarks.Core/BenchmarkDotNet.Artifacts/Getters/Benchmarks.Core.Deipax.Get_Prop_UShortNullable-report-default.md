
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
             ToBool | .NET Core 2.0 |  1.4941 ns | 0.0034 ns | 0.0030 ns |  1.4942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.2790 ns | 0.0025 ns | 0.0023 ns |  1.2794 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2830 ns | 0.0036 ns | 0.0030 ns |  1.2833 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  1.1806 ns | 0.0033 ns | 0.0029 ns |  1.1806 ns |  0.79 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  1.0222 ns | 0.0093 ns | 0.0087 ns |  1.0252 ns |  0.68 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.4380 ns | 0.0059 ns | 0.0055 ns |  4.4386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4081 ns | 0.0056 ns | 0.0050 ns |  4.4073 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2548 ns | 0.0156 ns | 0.0146 ns |  4.2504 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.6090 ns | 0.0079 ns | 0.0074 ns |  4.6090 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.6753 ns | 0.0045 ns | 0.0040 ns |  4.6753 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.4604 ns | 0.0031 ns | 0.0029 ns |  1.4607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4017 ns | 0.0036 ns | 0.0032 ns |  1.4021 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.6310 ns | 0.0029 ns | 0.0027 ns |  1.6305 ns |  1.12 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.1767 ns | 0.0023 ns | 0.0022 ns |  1.1765 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  0.9658 ns | 0.0034 ns | 0.0030 ns |  0.9663 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2331 ns | 0.0308 ns | 0.0288 ns |  4.2411 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4033 ns | 0.0107 ns | 0.0100 ns |  4.4022 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0353 ns | 0.0244 ns | 0.0228 ns |  4.0439 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3792 ns | 0.0059 ns | 0.0056 ns |  4.3809 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.3901 ns | 0.0098 ns | 0.0087 ns |  4.3891 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4103 ns | 0.0025 ns | 0.0023 ns |  1.4095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.7567 ns | 0.0141 ns | 0.0131 ns |  1.7620 ns |  1.25 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.7052 ns | 0.0037 ns | 0.0033 ns |  1.7050 ns |  1.21 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.4261 ns | 0.0021 ns | 0.0019 ns |  2.4258 ns |  1.72 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.1519 ns | 0.0047 ns | 0.0042 ns |  2.1526 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4351 ns | 0.0086 ns | 0.0071 ns |  4.4339 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4137 ns | 0.0084 ns | 0.0078 ns |  4.4159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.5085 ns | 0.0228 ns | 0.0213 ns |  4.5107 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3693 ns | 0.0072 ns | 0.0060 ns |  5.3692 ns |  1.21 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3190 ns | 0.0058 ns | 0.0054 ns |  5.3179 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.6815 ns | 0.0022 ns | 0.0020 ns |  1.6820 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.7903 ns | 0.0038 ns | 0.0033 ns |  1.7909 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5343 ns | 0.0064 ns | 0.0057 ns |  1.5321 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  2.3644 ns | 0.0041 ns | 0.0036 ns |  2.3643 ns |  1.41 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.0758 ns | 0.0046 ns | 0.0041 ns |  2.0763 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.4327 ns | 0.0092 ns | 0.0081 ns |  4.4335 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.6371 ns | 0.0072 ns | 0.0064 ns |  4.6369 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.4628 ns | 0.0078 ns | 0.0061 ns |  4.4625 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.2999 ns | 0.0058 ns | 0.0051 ns |  5.2992 ns |  1.20 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3118 ns | 0.0100 ns | 0.0083 ns |  5.3097 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4193 ns | 0.0103 ns | 0.0092 ns |  1.4213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4573 ns | 0.0078 ns | 0.0069 ns |  1.4556 ns |  1.03 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.4159 ns | 0.0029 ns | 0.0027 ns |  1.4168 ns |  1.00 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  2.3956 ns | 0.0101 ns | 0.0084 ns |  2.3943 ns |  1.69 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  2.1435 ns | 0.0032 ns | 0.0028 ns |  2.1433 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4409 ns | 0.0090 ns | 0.0084 ns |  4.4376 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4095 ns | 0.0079 ns | 0.0073 ns |  4.4090 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4645 ns | 0.0092 ns | 0.0086 ns |  4.4639 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3627 ns | 0.0098 ns | 0.0087 ns |  5.3644 ns |  1.21 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3142 ns | 0.0061 ns | 0.0057 ns |  5.3152 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.3527 ns | 0.0024 ns | 0.0020 ns |  1.3534 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.6507 ns | 0.0032 ns | 0.0028 ns |  1.6507 ns |  1.22 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.5808 ns | 0.0141 ns | 0.0125 ns |  1.5859 ns |  1.17 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.8671 ns | 0.0029 ns | 0.0024 ns |  1.8674 ns |  1.38 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.8452 ns | 0.0064 ns | 0.0057 ns |  1.8448 ns |  1.36 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  0.9260 ns | 0.0040 ns | 0.0037 ns |  0.9258 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  0.9728 ns | 0.0031 ns | 0.0027 ns |  0.9732 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  0.9563 ns | 0.0039 ns | 0.0033 ns |  0.9566 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  1.1995 ns | 0.0051 ns | 0.0048 ns |  1.1986 ns |  1.30 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  0.9316 ns | 0.0036 ns | 0.0030 ns |  0.9309 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1722 ns | 0.0037 ns | 0.0033 ns |  1.1721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5505 ns | 0.0041 ns | 0.0034 ns |  1.5506 ns |  1.32 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.2492 ns | 0.0026 ns | 0.0022 ns |  1.2503 ns |  1.07 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  1.4252 ns | 0.0021 ns | 0.0019 ns |  1.4248 ns |  1.22 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.0331 ns | 0.0031 ns | 0.0029 ns |  1.0330 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2312 ns | 0.0305 ns | 0.0286 ns |  4.2424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4238 ns | 0.0303 ns | 0.0283 ns |  4.4074 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0042 ns | 0.0080 ns | 0.0071 ns |  4.0040 ns |  0.95 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4017 ns | 0.0306 ns | 0.0286 ns |  4.3920 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3826 ns | 0.0054 ns | 0.0050 ns |  4.3811 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4004 ns | 0.0034 ns | 0.0032 ns |  1.4021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4184 ns | 0.0035 ns | 0.0033 ns |  1.4184 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2536 ns | 0.0030 ns | 0.0025 ns |  1.2533 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.4448 ns | 0.0106 ns | 0.0099 ns |  1.4405 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.6206 ns | 0.0602 ns | 0.1736 ns |  1.6381 ns |  1.09 |    0.12 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2006 ns | 0.0055 ns | 0.0052 ns |  4.2011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4072 ns | 0.0071 ns | 0.0067 ns |  4.4072 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0093 ns | 0.0120 ns | 0.0112 ns |  4.0050 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.3900 ns | 0.0063 ns | 0.0059 ns |  4.3903 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4397 ns | 0.0063 ns | 0.0059 ns |  4.4379 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.2376 ns | 0.0023 ns | 0.0022 ns |  1.2375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2642 ns | 0.0154 ns | 0.0137 ns |  1.2700 ns |  1.02 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5286 ns | 0.0048 ns | 0.0037 ns |  1.5280 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.1826 ns | 0.0023 ns | 0.0022 ns |  1.1827 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.9524 ns | 0.0046 ns | 0.0043 ns |  0.9534 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.7605 ns | 0.0044 ns | 0.0039 ns |  1.7596 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8784 ns | 0.0031 ns | 0.0026 ns |  1.8781 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1097 ns | 0.0040 ns | 0.0037 ns |  2.1099 ns |  1.20 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.5732 ns | 0.0083 ns | 0.0078 ns |  2.5739 ns |  1.46 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.3045 ns | 0.0141 ns | 0.0132 ns |  2.3071 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.4466 ns | 0.0130 ns | 0.0122 ns |  1.4514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2432 ns | 0.0037 ns | 0.0033 ns |  1.2431 ns |  0.86 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2547 ns | 0.0035 ns | 0.0033 ns |  1.2539 ns |  0.87 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  1.4662 ns | 0.0024 ns | 0.0021 ns |  1.4665 ns |  1.01 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  1.1546 ns | 0.0028 ns | 0.0024 ns |  1.1543 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.7647 ns | 0.0031 ns | 0.0029 ns |  1.7645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8808 ns | 0.0043 ns | 0.0038 ns |  1.8810 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.8892 ns | 0.0166 ns | 0.0147 ns |  1.8962 ns |  1.07 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.4901 ns | 0.0061 ns | 0.0054 ns |  2.4898 ns |  1.41 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.3884 ns | 0.0061 ns | 0.0054 ns |  2.3887 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4522 ns | 0.0037 ns | 0.0035 ns |  1.4513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.6385 ns | 0.0043 ns | 0.0038 ns |  1.6380 ns |  1.13 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4902 ns | 0.0041 ns | 0.0038 ns |  1.4887 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.1712 ns | 0.0029 ns | 0.0027 ns |  1.1707 ns |  0.81 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.0069 ns | 0.0021 ns | 0.0018 ns |  1.0068 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4296 ns | 0.0050 ns | 0.0044 ns |  4.4300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.6407 ns | 0.0213 ns | 0.0178 ns |  4.6356 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.4867 ns | 0.0309 ns | 0.0289 ns |  4.4784 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.8485 ns | 0.0042 ns | 0.0035 ns |  4.8498 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8817 ns | 0.0299 ns | 0.0279 ns |  4.8962 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3988 ns | 0.0038 ns | 0.0034 ns |  1.3998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4487 ns | 0.0040 ns | 0.0037 ns |  1.4474 ns |  1.04 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4554 ns | 0.0041 ns | 0.0039 ns |  1.4557 ns |  1.04 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.4455 ns | 0.0040 ns | 0.0038 ns |  1.4448 ns |  1.03 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.1274 ns | 0.0044 ns | 0.0041 ns |  1.1272 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7141 ns | 0.0218 ns | 0.0193 ns |  1.7032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8694 ns | 0.0025 ns | 0.0021 ns |  1.8691 ns |  1.09 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8673 ns | 0.0057 ns | 0.0053 ns |  1.8666 ns |  1.09 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.5765 ns | 0.0135 ns | 0.0127 ns |  2.5779 ns |  1.50 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5507 ns | 0.0184 ns | 0.0172 ns |  2.5413 ns |  1.49 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0378 ns | 0.0114 ns | 0.0106 ns |  6.0400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0351 ns | 0.0069 ns | 0.0065 ns |  6.0351 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8380 ns | 0.0101 ns | 0.0089 ns |  5.8365 ns |  0.97 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.2497 ns | 0.0071 ns | 0.0066 ns |  6.2485 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.2551 ns | 0.0098 ns | 0.0092 ns |  6.2561 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.0458 ns | 0.0327 ns | 0.0306 ns | 18.0501 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.7549 ns | 0.0346 ns | 0.0289 ns | 18.7485 ns |  1.04 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.6927 ns | 0.1042 ns | 0.0975 ns | 12.6914 ns |  0.70 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.2868 ns | 0.0183 ns | 0.0162 ns | 18.2877 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.2396 ns | 0.0265 ns | 0.0247 ns | 18.2461 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0802 ns | 0.0047 ns | 0.0044 ns |  2.0797 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3245 ns | 0.0035 ns | 0.0033 ns |  2.3249 ns |  1.12 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3367 ns | 0.0026 ns | 0.0022 ns |  2.3369 ns |  1.12 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1297 ns | 0.0033 ns | 0.0030 ns |  1.1296 ns |  0.54 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.0127 ns | 0.0113 ns | 0.0106 ns |  1.0179 ns |  0.49 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9077 ns | 0.0165 ns | 0.0138 ns |  7.9048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4398 ns | 0.0074 ns | 0.0065 ns |  8.4381 ns |  1.07 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9231 ns | 0.0026 ns | 0.0020 ns |  1.9230 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 17.3704 ns | 0.0165 ns | 0.0154 ns | 17.3732 ns |  2.20 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1571 ns | 0.0109 ns | 0.0091 ns |  8.1532 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8328 ns | 0.0092 ns | 0.0077 ns |  3.8301 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5509 ns | 0.0328 ns | 0.0291 ns |  4.5650 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5992 ns | 0.0610 ns | 0.0571 ns |  4.5899 ns |  1.20 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.7688 ns | 0.0083 ns | 0.0069 ns |  3.7658 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7345 ns | 0.0090 ns | 0.0070 ns |  3.7340 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 26.7305 ns | 0.0574 ns | 0.0509 ns | 26.7325 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.2701 ns | 0.0360 ns | 0.0337 ns | 17.2568 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.8565 ns | 0.0368 ns | 0.0344 ns | 12.8492 ns |  0.48 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.2471 ns | 0.0337 ns | 0.0263 ns | 31.2518 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.7178 ns | 0.0348 ns | 0.0308 ns | 30.7228 ns |  1.15 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.6656 ns | 0.0178 ns | 0.0149 ns | 12.6656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.4048 ns | 0.0168 ns | 0.0141 ns | 12.4054 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.4325 ns | 0.0111 ns | 0.0098 ns |  8.4323 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.2574 ns | 0.1272 ns | 0.1190 ns | 15.1948 ns |  1.20 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.1745 ns | 0.0186 ns | 0.0165 ns | 15.1731 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.6895 ns | 0.0323 ns | 0.0302 ns | 16.6882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.6777 ns | 0.0390 ns | 0.0365 ns | 16.6712 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.1749 ns | 0.0218 ns | 0.0204 ns | 13.1690 ns |  0.79 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.7973 ns | 0.0315 ns | 0.0279 ns | 19.7988 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.8546 ns | 0.1642 ns | 0.1536 ns | 19.8939 ns |  1.19 |    0.01 |      - |     - |     - |         - |
