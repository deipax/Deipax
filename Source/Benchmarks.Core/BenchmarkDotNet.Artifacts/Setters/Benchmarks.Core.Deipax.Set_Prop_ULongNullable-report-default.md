
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9196 ns | 0.0037 ns | 0.0035 ns |  0.9189 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6729 ns | 0.0021 ns | 0.0019 ns |  0.6728 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7168 ns | 0.0024 ns | 0.0022 ns |  0.7176 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9339 ns | 0.0027 ns | 0.0024 ns |  0.9339 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9474 ns | 0.0026 ns | 0.0022 ns |  0.9472 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3813 ns | 0.0044 ns | 0.0037 ns |  1.3819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.3657 ns | 0.0039 ns | 0.0037 ns |  1.3668 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.3952 ns | 0.0028 ns | 0.0027 ns |  1.3951 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0007 ns | 0.0051 ns | 0.0048 ns |  2.0006 ns |  1.45 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.0108 ns | 0.0065 ns | 0.0061 ns |  2.0105 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9190 ns | 0.0041 ns | 0.0038 ns |  0.9195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6509 ns | 0.0026 ns | 0.0020 ns |  0.6512 ns |  0.71 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5920 ns | 0.0054 ns | 0.0045 ns |  0.5902 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6987 ns | 0.0040 ns | 0.0035 ns |  0.6989 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7397 ns | 0.0037 ns | 0.0031 ns |  0.7391 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.0037 ns | 0.0142 ns | 0.0133 ns |  1.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0908 ns | 0.0045 ns | 0.0040 ns |  1.0903 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0859 ns | 0.0030 ns | 0.0028 ns |  1.0852 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.0133 ns | 0.0073 ns | 0.0065 ns |  2.0132 ns |  2.01 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.0234 ns | 0.0083 ns | 0.0078 ns |  2.0220 ns |  2.02 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.7015 ns | 0.0034 ns | 0.0032 ns |  1.7017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3916 ns | 0.0058 ns | 0.0051 ns |  1.3934 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6270 ns | 0.0073 ns | 0.0068 ns |  0.6265 ns |  0.37 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.8977 ns | 0.0057 ns | 0.0054 ns |  1.8963 ns |  1.12 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.8885 ns | 0.0020 ns | 0.0018 ns |  1.8889 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.9892 ns | 0.0206 ns | 0.0193 ns |  1.9812 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8208 ns | 0.0033 ns | 0.0029 ns |  1.8208 ns |  0.92 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9821 ns | 0.0045 ns | 0.0038 ns |  0.9818 ns |  0.49 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.8267 ns | 0.0128 ns | 0.0120 ns |  2.8243 ns |  1.42 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.8316 ns | 0.0212 ns | 0.0198 ns |  2.8221 ns |  1.42 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9309 ns | 0.0023 ns | 0.0022 ns |  0.9312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5755 ns | 0.0037 ns | 0.0034 ns |  0.5755 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6896 ns | 0.0023 ns | 0.0021 ns |  0.6896 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.9520 ns | 0.0039 ns | 0.0036 ns |  0.9511 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.9550 ns | 0.0093 ns | 0.0087 ns |  0.9579 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9823 ns | 0.0030 ns | 0.0025 ns |  0.9824 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9281 ns | 0.0040 ns | 0.0031 ns |  0.9286 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9591 ns | 0.0034 ns | 0.0030 ns |  0.9596 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9579 ns | 0.0182 ns | 0.0171 ns |  1.9497 ns |  1.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.1105 ns | 0.0036 ns | 0.0032 ns |  2.1105 ns |  2.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3732 ns | 0.0035 ns | 0.0032 ns |  1.3747 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.4088 ns | 0.0161 ns | 0.0150 ns |  1.4160 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6075 ns | 0.0015 ns | 0.0012 ns |  0.6078 ns |  0.44 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8977 ns | 0.0121 ns | 0.0107 ns |  1.8988 ns |  1.38 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8949 ns | 0.0152 ns | 0.0135 ns |  1.8998 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.9321 ns | 0.0050 ns | 0.0041 ns |  1.9306 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7808 ns | 0.0032 ns | 0.0030 ns |  1.7805 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1276 ns | 0.0077 ns | 0.0068 ns |  1.1286 ns |  0.58 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.6685 ns | 0.0055 ns | 0.0051 ns |  2.6695 ns |  1.38 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.6722 ns | 0.0053 ns | 0.0047 ns |  2.6718 ns |  1.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9211 ns | 0.0035 ns | 0.0033 ns |  0.9209 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6499 ns | 0.0028 ns | 0.0025 ns |  0.6498 ns |  0.71 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5862 ns | 0.0025 ns | 0.0024 ns |  0.5856 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7023 ns | 0.0038 ns | 0.0034 ns |  0.7017 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7402 ns | 0.0049 ns | 0.0044 ns |  0.7393 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9913 ns | 0.0055 ns | 0.0046 ns |  0.9918 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0843 ns | 0.0034 ns | 0.0030 ns |  1.0842 ns |  1.09 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0933 ns | 0.0023 ns | 0.0021 ns |  1.0938 ns |  1.10 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0146 ns | 0.0064 ns | 0.0060 ns |  2.0149 ns |  2.03 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0217 ns | 0.0024 ns | 0.0020 ns |  2.0210 ns |  2.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.4401 ns | 0.0030 ns | 0.0024 ns |  1.4393 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.4286 ns | 0.0146 ns | 0.0137 ns |  1.4216 ns |  0.99 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7494 ns | 0.0032 ns | 0.0030 ns |  0.7497 ns |  0.52 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7685 ns | 0.0050 ns | 0.0042 ns |  1.7681 ns |  1.23 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7850 ns | 0.0125 ns | 0.0117 ns |  1.7822 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.1067 ns | 0.0040 ns | 0.0036 ns |  2.1062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.9141 ns | 0.0030 ns | 0.0028 ns |  1.9146 ns |  0.91 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0919 ns | 0.0033 ns | 0.0031 ns |  1.0914 ns |  0.52 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.6224 ns | 0.0062 ns | 0.0055 ns |  2.6221 ns |  1.24 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.6142 ns | 0.0074 ns | 0.0062 ns |  2.6144 ns |  1.24 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9076 ns | 0.0039 ns | 0.0032 ns |  0.9075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.5680 ns | 0.0063 ns | 0.0059 ns |  0.5700 ns |  0.63 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7598 ns | 0.0034 ns | 0.0032 ns |  0.7597 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7097 ns | 0.0063 ns | 0.0059 ns |  0.7080 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6607 ns | 0.0038 ns | 0.0034 ns |  0.6604 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0474 ns | 0.0039 ns | 0.0033 ns |  1.0471 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.0989 ns | 0.0032 ns | 0.0028 ns |  1.0990 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1730 ns | 0.0036 ns | 0.0030 ns |  1.1729 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9463 ns | 0.0037 ns | 0.0035 ns |  1.9470 ns |  1.86 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9276 ns | 0.0154 ns | 0.0144 ns |  1.9224 ns |  1.84 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.4509 ns | 0.0035 ns | 0.0029 ns |  1.4518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.3503 ns | 0.0037 ns | 0.0029 ns |  1.3510 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7306 ns | 0.0070 ns | 0.0066 ns |  0.7330 ns |  0.50 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7364 ns | 0.0038 ns | 0.0036 ns |  1.7363 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7323 ns | 0.0203 ns | 0.0190 ns |  1.7411 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.9481 ns | 0.0158 ns | 0.0148 ns |  1.9422 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.0659 ns | 0.0032 ns | 0.0029 ns |  2.0659 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.4274 ns | 0.0044 ns | 0.0041 ns |  1.4276 ns |  0.73 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.2295 ns | 0.0074 ns | 0.0066 ns |  3.2296 ns |  1.66 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.8894 ns | 0.0068 ns | 0.0064 ns |  2.8889 ns |  1.48 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9232 ns | 0.0034 ns | 0.0032 ns |  0.9241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.6445 ns | 0.0041 ns | 0.0039 ns |  0.6441 ns |  0.70 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7153 ns | 0.0070 ns | 0.0066 ns |  0.7182 ns |  0.77 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.7224 ns | 0.0031 ns | 0.0027 ns |  0.7220 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  0.6539 ns | 0.0070 ns | 0.0065 ns |  0.6568 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.1531 ns | 0.0181 ns | 0.0169 ns |  1.1604 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.1888 ns | 0.0041 ns | 0.0038 ns |  1.1889 ns |  1.03 |    0.02 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.1796 ns | 0.0041 ns | 0.0036 ns |  1.1778 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.4221 ns | 0.0071 ns | 0.0060 ns |  1.4194 ns |  1.23 |    0.02 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.3748 ns | 0.0159 ns | 0.0141 ns |  1.3692 ns |  1.19 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.2193 ns | 0.0082 ns | 0.0077 ns |  3.2194 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.3565 ns | 0.0069 ns | 0.0065 ns |  2.3571 ns |  0.73 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  2.3427 ns | 0.0056 ns | 0.0053 ns |  2.3426 ns |  0.73 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.4842 ns | 0.0079 ns | 0.0070 ns |  3.4854 ns |  1.08 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5121 ns | 0.0314 ns | 0.0293 ns |  3.5105 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.2466 ns | 0.0086 ns | 0.0080 ns |  4.2472 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.0259 ns | 0.0047 ns | 0.0042 ns |  3.0269 ns |  0.71 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.3485 ns | 0.0182 ns | 0.0170 ns |  3.3496 ns |  0.79 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.2657 ns | 0.0106 ns | 0.0100 ns |  4.2644 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.2741 ns | 0.0273 ns | 0.0256 ns |  4.2692 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.1096 ns | 0.0358 ns | 0.0334 ns |  3.0930 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.0867 ns | 0.0129 ns | 0.0121 ns |  2.0839 ns |  0.67 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.9436 ns | 0.0150 ns | 0.0140 ns |  1.9461 ns |  0.63 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4919 ns | 0.0159 ns | 0.0149 ns |  3.4881 ns |  1.12 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4600 ns | 0.0248 ns | 0.0232 ns |  3.4678 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.6032 ns | 0.0074 ns | 0.0069 ns |  4.6046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.2771 ns | 0.0066 ns | 0.0058 ns |  3.2752 ns |  0.71 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.2379 ns | 0.0306 ns | 0.0286 ns |  3.2211 ns |  0.70 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.0430 ns | 0.0069 ns | 0.0065 ns |  5.0436 ns |  1.10 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.0398 ns | 0.0093 ns | 0.0083 ns |  5.0373 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.0350 ns | 0.0232 ns | 0.0217 ns | 13.0332 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.2052 ns | 0.0151 ns | 0.0134 ns | 13.2086 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6459 ns | 0.0107 ns | 0.0094 ns |  5.6453 ns |  0.43 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.4443 ns | 0.0127 ns | 0.0099 ns | 13.4454 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.4532 ns | 0.0136 ns | 0.0113 ns | 13.4513 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.0706 ns | 0.0338 ns | 0.0316 ns | 24.0808 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.1969 ns | 0.1331 ns | 0.1245 ns | 24.1471 ns |  1.01 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.3636 ns | 0.2263 ns | 0.2117 ns | 13.2480 ns |  0.56 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.3240 ns | 0.0235 ns | 0.0220 ns | 24.3224 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 33.5511 ns | 0.1590 ns | 0.1488 ns | 33.6121 ns |  1.39 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9263 ns | 0.0095 ns | 0.0089 ns |  0.9244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6901 ns | 0.0069 ns | 0.0064 ns |  0.6916 ns |  0.75 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7592 ns | 0.0074 ns | 0.0070 ns |  0.7628 ns |  0.82 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7363 ns | 0.0033 ns | 0.0031 ns |  0.7358 ns |  0.79 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6732 ns | 0.0075 ns | 0.0070 ns |  0.6720 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4603 ns | 0.0038 ns | 0.0033 ns |  1.4605 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6506 ns | 0.0032 ns | 0.0026 ns |  1.6508 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4524 ns | 0.0089 ns | 0.0083 ns |  1.4496 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.7502 ns | 0.0127 ns | 0.0106 ns |  1.7551 ns |  1.20 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6498 ns | 0.0034 ns | 0.0029 ns |  1.6507 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.1919 ns | 0.0145 ns | 0.0135 ns | 10.1965 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.4644 ns | 0.0840 ns | 0.0786 ns | 14.4984 ns |  1.42 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.9964 ns | 0.0199 ns | 0.0155 ns | 14.9935 ns |  1.47 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 13.8653 ns | 0.0282 ns | 0.0264 ns | 13.8718 ns |  1.36 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.5911 ns | 0.0316 ns | 0.0264 ns | 13.5914 ns |  1.33 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.4340 ns | 0.1247 ns | 0.1167 ns | 46.4351 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 63.5397 ns | 1.2832 ns | 2.0721 ns | 62.1056 ns |  1.41 |    0.04 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.4507 ns | 0.0180 ns | 0.0160 ns | 10.4532 ns |  0.23 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.9361 ns | 0.1079 ns | 0.0956 ns | 46.9032 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.0915 ns | 0.2257 ns | 0.2111 ns | 46.1445 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.4707 ns | 0.0035 ns | 0.0027 ns |  1.4703 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.3951 ns | 0.0030 ns | 0.0025 ns |  1.3952 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.9473 ns | 0.0032 ns | 0.0029 ns |  0.9479 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7666 ns | 0.0028 ns | 0.0024 ns |  1.7672 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7404 ns | 0.0031 ns | 0.0029 ns |  1.7405 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.0524 ns | 0.0055 ns | 0.0052 ns |  2.0528 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.9018 ns | 0.0021 ns | 0.0017 ns |  1.9019 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1194 ns | 0.0034 ns | 0.0030 ns |  1.1194 ns |  0.55 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.7703 ns | 0.0074 ns | 0.0065 ns |  2.7697 ns |  1.35 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.5861 ns | 0.0054 ns | 0.0048 ns |  2.5856 ns |  1.26 |    0.00 |     - |     - |     - |         - |
