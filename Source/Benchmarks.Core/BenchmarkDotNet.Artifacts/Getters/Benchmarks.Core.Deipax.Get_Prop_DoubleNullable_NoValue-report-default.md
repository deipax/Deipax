
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
             ToBool | .NET Core 2.0 |  1.4559 ns | 0.0042 ns | 0.0037 ns |  1.4554 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4606 ns | 0.0021 ns | 0.0016 ns |  1.4611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.3915 ns | 0.0020 ns | 0.0018 ns |  1.3918 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  1.1835 ns | 0.0026 ns | 0.0024 ns |  1.1839 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.8911 ns | 0.0037 ns | 0.0034 ns |  0.8908 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2457 ns | 0.0047 ns | 0.0044 ns |  4.2471 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4022 ns | 0.0062 ns | 0.0048 ns |  4.4037 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.1784 ns | 0.0052 ns | 0.0046 ns |  4.1798 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.3824 ns | 0.0094 ns | 0.0084 ns |  4.3853 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.3994 ns | 0.0064 ns | 0.0057 ns |  4.3981 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.1881 ns | 0.0023 ns | 0.0020 ns |  1.1877 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4254 ns | 0.0020 ns | 0.0018 ns |  1.4252 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.3237 ns | 0.0055 ns | 0.0051 ns |  1.3249 ns |  1.11 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  0.7220 ns | 0.0024 ns | 0.0021 ns |  0.7220 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.5329 ns | 0.0033 ns | 0.0031 ns |  0.5323 ns |  0.45 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0462 ns | 0.0050 ns | 0.0046 ns |  4.0453 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4482 ns | 0.0051 ns | 0.0048 ns |  4.4482 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.1797 ns | 0.0045 ns | 0.0038 ns |  4.1808 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3784 ns | 0.0055 ns | 0.0052 ns |  4.3782 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.3904 ns | 0.0063 ns | 0.0059 ns |  4.3913 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4629 ns | 0.0018 ns | 0.0016 ns |  1.4632 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.5028 ns | 0.0024 ns | 0.0022 ns |  1.5028 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4367 ns | 0.0025 ns | 0.0022 ns |  1.4369 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9472 ns | 0.0118 ns | 0.0110 ns |  0.9500 ns |  0.65 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.6612 ns | 0.0042 ns | 0.0039 ns |  0.6611 ns |  0.45 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4862 ns | 0.0050 ns | 0.0042 ns |  4.4843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4039 ns | 0.0041 ns | 0.0038 ns |  4.4038 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.1777 ns | 0.0046 ns | 0.0043 ns |  4.1781 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.6136 ns | 0.0052 ns | 0.0046 ns |  4.6130 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.6273 ns | 0.0070 ns | 0.0065 ns |  4.6290 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.6534 ns | 0.0041 ns | 0.0036 ns |  1.6525 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6532 ns | 0.0039 ns | 0.0032 ns |  1.6527 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4929 ns | 0.0026 ns | 0.0024 ns |  1.4931 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  1.2060 ns | 0.0030 ns | 0.0027 ns |  1.2066 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  0.8885 ns | 0.0022 ns | 0.0021 ns |  0.8891 ns |  0.54 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.4845 ns | 0.0037 ns | 0.0033 ns |  4.4840 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4091 ns | 0.0043 ns | 0.0038 ns |  4.4087 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.1781 ns | 0.0073 ns | 0.0065 ns |  4.1781 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.5978 ns | 0.0086 ns | 0.0076 ns |  4.5959 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6783 ns | 0.0048 ns | 0.0045 ns |  4.6794 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4624 ns | 0.0026 ns | 0.0022 ns |  1.4625 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6395 ns | 0.0035 ns | 0.0033 ns |  1.6395 ns |  1.12 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.5472 ns | 0.0025 ns | 0.0023 ns |  1.5465 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9362 ns | 0.0024 ns | 0.0023 ns |  0.9355 ns |  0.64 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.6541 ns | 0.0025 ns | 0.0024 ns |  0.6539 ns |  0.45 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4775 ns | 0.0053 ns | 0.0050 ns |  4.4769 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4053 ns | 0.0039 ns | 0.0035 ns |  4.4061 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.1836 ns | 0.0088 ns | 0.0082 ns |  4.1809 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6070 ns | 0.0061 ns | 0.0057 ns |  4.6071 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6284 ns | 0.0064 ns | 0.0060 ns |  4.6300 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6572 ns | 0.0172 ns | 0.0161 ns |  1.6467 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.4908 ns | 0.0033 ns | 0.0031 ns |  1.4908 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.3915 ns | 0.0024 ns | 0.0022 ns |  1.3915 ns |  0.84 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9427 ns | 0.0038 ns | 0.0035 ns |  0.9425 ns |  0.57 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.6557 ns | 0.0023 ns | 0.0022 ns |  0.6555 ns |  0.40 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.4774 ns | 0.0058 ns | 0.0055 ns |  4.4779 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4078 ns | 0.0038 ns | 0.0036 ns |  4.4078 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.1705 ns | 0.0038 ns | 0.0036 ns |  4.1694 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6362 ns | 0.0272 ns | 0.0241 ns |  4.6442 ns |  1.04 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6240 ns | 0.0057 ns | 0.0053 ns |  4.6241 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.4579 ns | 0.0024 ns | 0.0023 ns |  1.4580 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4686 ns | 0.0020 ns | 0.0018 ns |  1.4682 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4089 ns | 0.0032 ns | 0.0028 ns |  1.4090 ns |  0.97 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  1.1773 ns | 0.0019 ns | 0.0018 ns |  1.1769 ns |  0.81 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9191 ns | 0.0059 ns | 0.0055 ns |  0.9209 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.4954 ns | 0.0295 ns | 0.0276 ns |  4.5166 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4076 ns | 0.0034 ns | 0.0031 ns |  4.4080 ns |  0.98 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.1794 ns | 0.0059 ns | 0.0052 ns |  4.1779 ns |  0.93 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6079 ns | 0.0060 ns | 0.0056 ns |  4.6091 ns |  1.03 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6288 ns | 0.0041 ns | 0.0038 ns |  4.6282 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6335 ns | 0.0034 ns | 0.0030 ns |  1.6332 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6485 ns | 0.0024 ns | 0.0022 ns |  1.6484 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5805 ns | 0.0053 ns | 0.0047 ns |  1.5814 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.2051 ns | 0.0032 ns | 0.0028 ns |  1.2051 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.8928 ns | 0.0038 ns | 0.0036 ns |  0.8916 ns |  0.55 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4746 ns | 0.0054 ns | 0.0048 ns |  4.4739 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4371 ns | 0.0133 ns | 0.0118 ns |  4.4409 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.1807 ns | 0.0042 ns | 0.0033 ns |  4.1802 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6385 ns | 0.0215 ns | 0.0201 ns |  4.6430 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6292 ns | 0.0059 ns | 0.0055 ns |  4.6302 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4475 ns | 0.0027 ns | 0.0024 ns |  1.4471 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6357 ns | 0.0014 ns | 0.0013 ns |  1.6357 ns |  1.13 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5510 ns | 0.0023 ns | 0.0022 ns |  1.5511 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  1.1703 ns | 0.0026 ns | 0.0024 ns |  1.1702 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.8893 ns | 0.0022 ns | 0.0021 ns |  0.8893 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.3890 ns | 0.0020 ns | 0.0019 ns |  2.3891 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.1040 ns | 0.0035 ns | 0.0033 ns |  2.1040 ns |  0.88 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8723 ns | 0.0024 ns | 0.0021 ns |  1.8728 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.0720 ns | 0.0036 ns | 0.0034 ns |  2.0720 ns |  0.87 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1231 ns | 0.0032 ns | 0.0028 ns |  2.1235 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6365 ns | 0.0029 ns | 0.0026 ns |  1.6368 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6659 ns | 0.0017 ns | 0.0016 ns |  1.6657 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.5546 ns | 0.0025 ns | 0.0024 ns |  1.5554 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  1.1849 ns | 0.0029 ns | 0.0027 ns |  1.1851 ns |  0.72 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.8969 ns | 0.0028 ns | 0.0025 ns |  0.8965 ns |  0.55 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9923 ns | 0.0024 ns | 0.0021 ns |  1.9923 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1019 ns | 0.0038 ns | 0.0032 ns |  2.1021 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.8854 ns | 0.0073 ns | 0.0061 ns |  1.8866 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.0784 ns | 0.0051 ns | 0.0047 ns |  2.0791 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.0955 ns | 0.0068 ns | 0.0057 ns |  2.0949 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4734 ns | 0.0028 ns | 0.0026 ns |  1.4736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.6165 ns | 0.0019 ns | 0.0017 ns |  1.6165 ns |  1.10 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.5725 ns | 0.0027 ns | 0.0024 ns |  1.5721 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.1821 ns | 0.0152 ns | 0.0142 ns |  1.1861 ns |  0.80 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  0.8964 ns | 0.0040 ns | 0.0036 ns |  0.8973 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2414 ns | 0.0049 ns | 0.0046 ns |  4.2415 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4093 ns | 0.0076 ns | 0.0072 ns |  4.4099 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.1775 ns | 0.0045 ns | 0.0042 ns |  4.1774 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6033 ns | 0.0065 ns | 0.0060 ns |  4.6011 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6828 ns | 0.0065 ns | 0.0058 ns |  4.6820 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4745 ns | 0.0190 ns | 0.0178 ns |  1.4822 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.5419 ns | 0.0027 ns | 0.0024 ns |  1.5420 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4630 ns | 0.0032 ns | 0.0030 ns |  1.4635 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9740 ns | 0.0028 ns | 0.0026 ns |  0.9738 ns |  0.66 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.9435 ns | 0.0023 ns | 0.0022 ns |  0.9432 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8544 ns | 0.0032 ns | 0.0030 ns |  1.8536 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8650 ns | 0.0028 ns | 0.0026 ns |  1.8653 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.5866 ns | 0.0149 ns | 0.0139 ns |  1.5927 ns |  0.86 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.6102 ns | 0.0028 ns | 0.0026 ns |  1.6102 ns |  0.87 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.6516 ns | 0.0072 ns | 0.0067 ns |  1.6544 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.3321 ns | 0.0194 ns | 0.0182 ns |  2.3219 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1753 ns | 0.0030 ns | 0.0025 ns |  2.1759 ns |  0.93 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1022 ns | 0.0084 ns | 0.0075 ns |  2.0993 ns |  0.90 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0134 ns | 0.0043 ns | 0.0040 ns |  6.0139 ns |  2.58 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0236 ns | 0.0056 ns | 0.0052 ns |  6.0219 ns |  2.58 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0174 ns | 0.0084 ns | 0.0079 ns | 10.0192 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 12.0634 ns | 0.0121 ns | 0.0114 ns | 12.0695 ns |  1.20 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3209 ns | 0.0048 ns | 0.0045 ns |  2.3206 ns |  0.23 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.7233 ns | 0.0357 ns | 0.0334 ns | 10.7357 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6426 ns | 0.0135 ns | 0.0120 ns | 10.6408 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3239 ns | 0.0022 ns | 0.0021 ns |  2.3241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3512 ns | 0.0050 ns | 0.0044 ns |  2.3507 ns |  1.01 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2366 ns | 0.0031 ns | 0.0029 ns |  2.2364 ns |  0.96 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.3474 ns | 0.0020 ns | 0.0018 ns |  1.3476 ns |  0.58 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.4105 ns | 0.0032 ns | 0.0027 ns |  1.4107 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9462 ns | 0.0076 ns | 0.0071 ns |  7.9490 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4033 ns | 0.0285 ns | 0.0266 ns |  8.4066 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.8698 ns | 0.0030 ns | 0.0027 ns |  1.8701 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1733 ns | 0.0160 ns | 0.0149 ns |  8.1713 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1171 ns | 0.0233 ns | 0.0218 ns |  8.1073 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.6411 ns | 0.0036 ns | 0.0032 ns |  1.6406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.8837 ns | 0.0051 ns | 0.0043 ns |  1.8824 ns |  1.15 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.5017 ns | 0.0126 ns | 0.0118 ns |  1.5054 ns |  0.91 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9767 ns | 0.0025 ns | 0.0023 ns |  0.9763 ns |  0.60 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9728 ns | 0.0062 ns | 0.0058 ns |  0.9738 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.6348 ns | 0.0021 ns | 0.0018 ns |  1.6352 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.4957 ns | 0.0026 ns | 0.0020 ns |  1.4955 ns |  0.91 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.5641 ns | 0.0031 ns | 0.0028 ns |  1.5642 ns |  0.96 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  1.1994 ns | 0.0026 ns | 0.0024 ns |  1.1994 ns |  0.73 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.1687 ns | 0.0032 ns | 0.0030 ns |  1.1693 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6354 ns | 0.0033 ns | 0.0029 ns |  1.6359 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6707 ns | 0.0023 ns | 0.0021 ns |  1.6705 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.3855 ns | 0.0024 ns | 0.0021 ns |  1.3852 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2011 ns | 0.0023 ns | 0.0022 ns |  1.2011 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.1683 ns | 0.0057 ns | 0.0050 ns |  1.1675 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.5224 ns | 0.0067 ns | 0.0060 ns |  4.5231 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.6403 ns | 0.0039 ns | 0.0037 ns |  4.6402 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.1663 ns | 0.0059 ns | 0.0055 ns |  4.1667 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.8380 ns | 0.0073 ns | 0.0068 ns |  4.8385 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.8602 ns | 0.0069 ns | 0.0064 ns |  4.8605 ns |  1.07 |    0.00 |     - |     - |     - |         - |
