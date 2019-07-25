
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
             FromBool | .NET Core 2.0 |  0.7080 ns | 0.0086 ns | 0.0080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.7107 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.6873 ns | 0.0024 ns | 0.0020 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.7009 ns | 0.0037 ns | 0.0033 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.7106 ns | 0.0032 ns | 0.0028 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9441 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1878 ns | 0.0041 ns | 0.0034 ns |  1.26 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9177 ns | 0.0027 ns | 0.0026 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.2412 ns | 0.0029 ns | 0.0026 ns |  1.31 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.2852 ns | 0.0034 ns | 0.0032 ns |  1.36 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6882 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7374 ns | 0.0032 ns | 0.0030 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4632 ns | 0.0043 ns | 0.0038 ns |  0.67 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7045 ns | 0.0027 ns | 0.0024 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7430 ns | 0.0035 ns | 0.0033 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.6895 ns | 0.0042 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9668 ns | 0.0038 ns | 0.0036 ns |  1.40 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9180 ns | 0.0026 ns | 0.0022 ns |  1.33 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9529 ns | 0.0039 ns | 0.0036 ns |  1.38 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9515 ns | 0.0031 ns | 0.0029 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6934 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7135 ns | 0.0032 ns | 0.0030 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6949 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7206 ns | 0.0023 ns | 0.0020 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7095 ns | 0.0033 ns | 0.0029 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1656 ns | 0.0054 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1937 ns | 0.0070 ns | 0.0062 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9444 ns | 0.0045 ns | 0.0040 ns |  0.81 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.6699 ns | 0.0038 ns | 0.0032 ns |  1.43 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6722 ns | 0.0039 ns | 0.0034 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9198 ns | 0.0036 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7156 ns | 0.0025 ns | 0.0022 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.4606 ns | 0.0023 ns | 0.0019 ns |  0.50 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7228 ns | 0.0025 ns | 0.0022 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7144 ns | 0.0014 ns | 0.0012 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1809 ns | 0.0158 ns | 0.0132 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1689 ns | 0.0042 ns | 0.0037 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9215 ns | 0.0026 ns | 0.0023 ns |  0.78 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6905 ns | 0.0187 ns | 0.0175 ns |  1.43 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6735 ns | 0.0030 ns | 0.0028 ns |  1.42 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3110 ns | 0.0194 ns | 0.0172 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7159 ns | 0.0021 ns | 0.0020 ns |  0.55 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.9169 ns | 0.0024 ns | 0.0023 ns |  0.70 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7024 ns | 0.0022 ns | 0.0018 ns |  0.54 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7118 ns | 0.0032 ns | 0.0029 ns |  0.54 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.5555 ns | 0.0189 ns | 0.0177 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1629 ns | 0.0023 ns | 0.0021 ns |  0.75 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9214 ns | 0.0026 ns | 0.0024 ns |  0.59 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6732 ns | 0.0048 ns | 0.0045 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.6674 ns | 0.0034 ns | 0.0030 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9315 ns | 0.0085 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9746 ns | 0.0055 ns | 0.0049 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.4658 ns | 0.0020 ns | 0.0018 ns |  0.50 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.9286 ns | 0.0032 ns | 0.0029 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.9707 ns | 0.0109 ns | 0.0102 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1626 ns | 0.0145 ns | 0.0136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.9341 ns | 0.0030 ns | 0.0028 ns |  0.80 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1412 ns | 0.0067 ns | 0.0060 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.7008 ns | 0.0144 ns | 0.0128 ns |  1.47 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6685 ns | 0.0032 ns | 0.0029 ns |  1.44 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7063 ns | 0.0261 ns | 0.0231 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.7196 ns | 0.0027 ns | 0.0024 ns |  1.02 |    0.03 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.6919 ns | 0.0065 ns | 0.0061 ns |  0.98 |    0.03 |     - |     - |     - |         - |
              FromInt |        net461 |  0.7235 ns | 0.0030 ns | 0.0028 ns |  1.03 |    0.03 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7198 ns | 0.0024 ns | 0.0022 ns |  1.02 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.4407 ns | 0.0128 ns | 0.0113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.1740 ns | 0.0022 ns | 0.0021 ns |  0.81 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1509 ns | 0.0028 ns | 0.0026 ns |  0.80 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.6648 ns | 0.0149 ns | 0.0139 ns |  1.15 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.6529 ns | 0.0037 ns | 0.0033 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9256 ns | 0.0126 ns | 0.0112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.9269 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.5100 ns | 0.0111 ns | 0.0104 ns |  0.55 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7257 ns | 0.0039 ns | 0.0036 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6661 ns | 0.0051 ns | 0.0047 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1435 ns | 0.0178 ns | 0.0158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1442 ns | 0.0036 ns | 0.0034 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.9656 ns | 0.0039 ns | 0.0037 ns |  0.84 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.6546 ns | 0.0044 ns | 0.0039 ns |  1.45 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.6233 ns | 0.0042 ns | 0.0039 ns |  1.42 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6943 ns | 0.0137 ns | 0.0128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.6774 ns | 0.0019 ns | 0.0017 ns |  0.97 |    0.02 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.8977 ns | 0.0048 ns | 0.0042 ns |  1.29 |    0.02 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7163 ns | 0.0039 ns | 0.0037 ns |  1.03 |    0.02 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6702 ns | 0.0107 ns | 0.0100 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.4241 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.4290 ns | 0.0193 ns | 0.0171 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.5222 ns | 0.0048 ns | 0.0038 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.8499 ns | 0.0024 ns | 0.0023 ns |  1.30 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.8489 ns | 0.0048 ns | 0.0045 ns |  1.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9257 ns | 0.0287 ns | 0.0240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.6843 ns | 0.0038 ns | 0.0035 ns |  0.74 |    0.02 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.9088 ns | 0.0444 ns | 0.0637 ns |  0.98 |    0.07 |     - |     - |     - |         - |
            FromULong |        net461 |  0.7347 ns | 0.0018 ns | 0.0015 ns |  0.79 |    0.02 |     - |     - |     - |         - |
            FromULong |        net472 |  0.6633 ns | 0.0029 ns | 0.0026 ns |  0.72 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.6951 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.6328 ns | 0.0023 ns | 0.0019 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.4731 ns | 0.0070 ns | 0.0062 ns |  0.87 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9664 ns | 0.0092 ns | 0.0086 ns |  1.16 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9611 ns | 0.0052 ns | 0.0048 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.7308 ns | 0.0075 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.9091 ns | 0.0029 ns | 0.0027 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.7203 ns | 0.0025 ns | 0.0023 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.7205 ns | 0.0028 ns | 0.0027 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.6832 ns | 0.0021 ns | 0.0020 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.1610 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.9902 ns | 0.0026 ns | 0.0023 ns |  0.85 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.1176 ns | 0.0063 ns | 0.0056 ns |  0.96 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.7817 ns | 0.0039 ns | 0.0035 ns |  1.53 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  2.3790 ns | 0.0175 ns | 0.0164 ns |  2.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.8732 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.7302 ns | 0.0081 ns | 0.0076 ns |  0.84 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.6661 ns | 0.0019 ns | 0.0018 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.5794 ns | 0.0027 ns | 0.0024 ns |  0.66 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.6853 ns | 0.0037 ns | 0.0035 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.7421 ns | 0.0103 ns | 0.0086 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.6209 ns | 0.0037 ns | 0.0034 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.7587 ns | 0.0135 ns | 0.0127 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.0880 ns | 0.0033 ns | 0.0031 ns |  1.20 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.0894 ns | 0.0052 ns | 0.0048 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  7.4930 ns | 0.0212 ns | 0.0188 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  7.8467 ns | 0.0152 ns | 0.0127 ns |  1.05 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.2796 ns | 0.0082 ns | 0.0068 ns |  0.70 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  8.0689 ns | 0.0478 ns | 0.0447 ns |  1.08 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 |  9.0847 ns | 0.0318 ns | 0.0298 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 16.9289 ns | 0.0101 ns | 0.0090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 17.1228 ns | 0.0218 ns | 0.0170 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 10.7045 ns | 0.0097 ns | 0.0086 ns |  0.63 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 18.0312 ns | 0.0261 ns | 0.0244 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 17.8033 ns | 0.0248 ns | 0.0207 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6966 ns | 0.0080 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6766 ns | 0.0021 ns | 0.0019 ns |  0.97 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6423 ns | 0.0031 ns | 0.0029 ns |  0.92 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7380 ns | 0.0042 ns | 0.0039 ns |  1.06 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6621 ns | 0.0012 ns | 0.0010 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.3773 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.5879 ns | 0.0028 ns | 0.0022 ns |  1.15 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.2259 ns | 0.0052 ns | 0.0048 ns |  0.89 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4160 ns | 0.0033 ns | 0.0029 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4061 ns | 0.0020 ns | 0.0018 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2471 ns | 0.0075 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2288 ns | 0.0033 ns | 0.0029 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1165 ns | 0.0192 ns | 0.0179 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2501 ns | 0.0034 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2181 ns | 0.0083 ns | 0.0077 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  8.1452 ns | 0.0149 ns | 0.0139 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 20.0250 ns | 0.0773 ns | 0.0723 ns |  2.46 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 13.8092 ns | 0.1066 ns | 0.0997 ns |  1.70 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 |  8.1238 ns | 0.0359 ns | 0.0336 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  8.1485 ns | 0.0108 ns | 0.0101 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.9225 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6795 ns | 0.0026 ns | 0.0024 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.4970 ns | 0.0018 ns | 0.0016 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7195 ns | 0.0027 ns | 0.0024 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.6606 ns | 0.0018 ns | 0.0017 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1603 ns | 0.0069 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1456 ns | 0.0051 ns | 0.0043 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1278 ns | 0.0021 ns | 0.0018 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6598 ns | 0.0038 ns | 0.0034 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.3088 ns | 0.0217 ns | 0.0203 ns |  1.99 |    0.02 |     - |     - |     - |         - |
