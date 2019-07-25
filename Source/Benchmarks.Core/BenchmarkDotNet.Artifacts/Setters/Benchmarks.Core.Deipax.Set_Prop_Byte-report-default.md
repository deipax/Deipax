
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9213 ns | 0.0081 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.8933 ns | 0.0140 ns | 0.0131 ns |  0.97 |    0.02 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1500 ns | 0.0045 ns | 0.0040 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9066 ns | 0.0024 ns | 0.0021 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1752 ns | 0.0113 ns | 0.0105 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3803 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.3513 ns | 0.0131 ns | 0.0116 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1321 ns | 0.0055 ns | 0.0049 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6189 ns | 0.0062 ns | 0.0055 ns |  1.17 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6574 ns | 0.0064 ns | 0.0056 ns |  1.20 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.1542 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.0655 ns | 0.0034 ns | 0.0029 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6467 ns | 0.0045 ns | 0.0040 ns |  0.56 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.5832 ns | 0.0028 ns | 0.0025 ns |  1.37 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  1.8609 ns | 0.0033 ns | 0.0027 ns |  1.61 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.6693 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.5897 ns | 0.0052 ns | 0.0049 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1146 ns | 0.0022 ns | 0.0020 ns |  0.67 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.1731 ns | 0.0697 ns | 0.1064 ns |  1.29 |    0.08 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.3328 ns | 0.0047 ns | 0.0039 ns |  1.40 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.1267 ns | 0.0020 ns | 0.0018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.0639 ns | 0.0033 ns | 0.0028 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.4963 ns | 0.0073 ns | 0.0069 ns |  0.44 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.5625 ns | 0.0054 ns | 0.0050 ns |  1.39 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.6494 ns | 0.0042 ns | 0.0039 ns |  1.46 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.4983 ns | 0.0095 ns | 0.0089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.4800 ns | 0.0194 ns | 0.0181 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.8842 ns | 0.0025 ns | 0.0019 ns |  0.59 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.1016 ns | 0.0067 ns | 0.0063 ns |  1.40 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.1389 ns | 0.0052 ns | 0.0048 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6880 ns | 0.0018 ns | 0.0016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4298 ns | 0.0028 ns | 0.0023 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6656 ns | 0.0034 ns | 0.0030 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4292 ns | 0.0013 ns | 0.0012 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7255 ns | 0.0034 ns | 0.0030 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1506 ns | 0.0056 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.8845 ns | 0.0031 ns | 0.0028 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.7333 ns | 0.0018 ns | 0.0014 ns |  0.64 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.2886 ns | 0.0020 ns | 0.0018 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.4111 ns | 0.0079 ns | 0.0070 ns |  1.23 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.9759 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.5881 ns | 0.0039 ns | 0.0032 ns |  0.80 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  1.8941 ns | 0.0046 ns | 0.0043 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.6026 ns | 0.0043 ns | 0.0033 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8573 ns | 0.0059 ns | 0.0056 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.5325 ns | 0.0031 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.1174 ns | 0.0209 ns | 0.0196 ns |  0.84 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  2.7318 ns | 0.0038 ns | 0.0035 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.9387 ns | 0.0055 ns | 0.0048 ns |  1.16 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.3177 ns | 0.0042 ns | 0.0035 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.1555 ns | 0.0118 ns | 0.0110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.0624 ns | 0.0027 ns | 0.0023 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6445 ns | 0.0034 ns | 0.0030 ns |  0.56 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.5667 ns | 0.0036 ns | 0.0034 ns |  1.36 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.6404 ns | 0.0031 ns | 0.0027 ns |  1.42 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.6271 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.5852 ns | 0.0032 ns | 0.0030 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1116 ns | 0.0040 ns | 0.0033 ns |  0.68 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0762 ns | 0.0115 ns | 0.0107 ns |  1.28 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.1121 ns | 0.0047 ns | 0.0039 ns |  1.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8431 ns | 0.0035 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.5734 ns | 0.0030 ns | 0.0028 ns |  0.85 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.8013 ns | 0.0021 ns | 0.0017 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.6023 ns | 0.0027 ns | 0.0025 ns |  0.87 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6873 ns | 0.0022 ns | 0.0020 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.0636 ns | 0.0041 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.2700 ns | 0.0082 ns | 0.0077 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  3.2931 ns | 0.0345 ns | 0.0323 ns |  1.59 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.0062 ns | 0.0041 ns | 0.0032 ns |  0.97 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.1104 ns | 0.0146 ns | 0.0129 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.2685 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.1813 ns | 0.0021 ns | 0.0019 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6904 ns | 0.0031 ns | 0.0027 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.5891 ns | 0.0039 ns | 0.0035 ns |  1.25 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8852 ns | 0.0138 ns | 0.0129 ns |  1.49 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.7977 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.6250 ns | 0.0043 ns | 0.0040 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.9200 ns | 0.0029 ns | 0.0028 ns |  0.51 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.3095 ns | 0.0097 ns | 0.0091 ns |  1.28 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.5555 ns | 0.0063 ns | 0.0059 ns |  1.42 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.6136 ns | 0.0038 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.9187 ns | 0.0026 ns | 0.0024 ns |  1.19 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.5448 ns | 0.0034 ns | 0.0031 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6137 ns | 0.0140 ns | 0.0117 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.6662 ns | 0.0135 ns | 0.0126 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.5301 ns | 0.0197 ns | 0.0185 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.6226 ns | 0.0245 ns | 0.0229 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.9852 ns | 0.0048 ns | 0.0043 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.8292 ns | 0.0141 ns | 0.0132 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.7566 ns | 0.0057 ns | 0.0054 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8377 ns | 0.0020 ns | 0.0017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.6495 ns | 0.0118 ns | 0.0110 ns |  0.90 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.4452 ns | 0.0050 ns | 0.0047 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.5161 ns | 0.0041 ns | 0.0038 ns |  0.83 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6659 ns | 0.0037 ns | 0.0033 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.8728 ns | 0.0128 ns | 0.0120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.7552 ns | 0.0072 ns | 0.0064 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.8733 ns | 0.0060 ns | 0.0056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0359 ns | 0.0057 ns | 0.0053 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.9930 ns | 0.0064 ns | 0.0060 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.8594 ns | 0.0069 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.8947 ns | 0.0045 ns | 0.0043 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.6737 ns | 0.0208 ns | 0.0194 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.8137 ns | 0.0081 ns | 0.0076 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.8141 ns | 0.0090 ns | 0.0080 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.1918 ns | 0.0068 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.0075 ns | 0.0073 ns | 0.0069 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.0581 ns | 0.0073 ns | 0.0061 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.0332 ns | 0.0092 ns | 0.0086 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.0820 ns | 0.0108 ns | 0.0095 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.4607 ns | 0.0291 ns | 0.0272 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.7574 ns | 0.0054 ns | 0.0045 ns |  1.09 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.0674 ns | 0.0129 ns | 0.0114 ns |  1.18 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2768 ns | 0.0190 ns | 0.0178 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2632 ns | 0.0053 ns | 0.0050 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.7819 ns | 0.0154 ns | 0.0137 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  5.0039 ns | 0.0294 ns | 0.0261 ns |  1.05 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  5.1386 ns | 0.0113 ns | 0.0106 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.6720 ns | 0.0053 ns | 0.0050 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.7570 ns | 0.0066 ns | 0.0059 ns |  1.20 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.5488 ns | 0.0249 ns | 0.0208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.5107 ns | 0.0342 ns | 0.0320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.5635 ns | 0.0051 ns | 0.0043 ns |  0.48 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.8522 ns | 0.0295 ns | 0.0276 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.9060 ns | 0.0687 ns | 0.0609 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.9466 ns | 0.0147 ns | 0.0130 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.1801 ns | 0.1309 ns | 0.1225 ns |  1.01 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.1094 ns | 0.1330 ns | 0.1244 ns |  0.55 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.3905 ns | 0.0433 ns | 0.0383 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.2547 ns | 0.0208 ns | 0.0184 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6905 ns | 0.0025 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7012 ns | 0.0032 ns | 0.0030 ns |  1.02 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.4755 ns | 0.0011 ns | 0.0011 ns |  0.69 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.4377 ns | 0.0016 ns | 0.0014 ns |  0.63 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7504 ns | 0.0086 ns | 0.0080 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.3766 ns | 0.0054 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4328 ns | 0.0026 ns | 0.0024 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.2557 ns | 0.0027 ns | 0.0023 ns |  0.91 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4501 ns | 0.0173 ns | 0.0162 ns |  1.05 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4131 ns | 0.0036 ns | 0.0034 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2525 ns | 0.0148 ns | 0.0138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2416 ns | 0.0037 ns | 0.0033 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.3357 ns | 0.0039 ns | 0.0035 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2207 ns | 0.0037 ns | 0.0033 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2488 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.3160 ns | 0.0661 ns | 0.0586 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 42.4535 ns | 0.0625 ns | 0.0522 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.7594 ns | 0.1203 ns | 0.1125 ns |  0.19 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 45.9425 ns | 0.0648 ns | 0.0575 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.4126 ns | 0.0982 ns | 0.0871 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8464 ns | 0.0056 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.6976 ns | 0.0030 ns | 0.0027 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.4726 ns | 0.0030 ns | 0.0028 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6133 ns | 0.0048 ns | 0.0043 ns |  0.87 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.8551 ns | 0.0048 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.0749 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.1070 ns | 0.0062 ns | 0.0058 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.9882 ns | 0.0031 ns | 0.0029 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.0535 ns | 0.0067 ns | 0.0062 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.3311 ns | 0.0057 ns | 0.0048 ns |  1.12 |    0.00 |     - |     - |     - |         - |
