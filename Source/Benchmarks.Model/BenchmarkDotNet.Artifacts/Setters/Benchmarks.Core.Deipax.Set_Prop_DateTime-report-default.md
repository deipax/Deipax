
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |        Mean |     Error |    StdDev |      Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |------------:|----------:|----------:|------------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |   0.6945 ns | 0.0116 ns | 0.0109 ns |   0.6889 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   0.6713 ns | 0.0047 ns | 0.0044 ns |   0.6712 ns |  0.97 |    0.02 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   0.7169 ns | 0.0027 ns | 0.0024 ns |   0.7167 ns |  1.03 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 |   0.4306 ns | 0.0020 ns | 0.0019 ns |   0.4302 ns |  0.62 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |   0.7031 ns | 0.0024 ns | 0.0023 ns |   0.7026 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   0.6822 ns | 0.0028 ns | 0.0026 ns |   0.6820 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   0.9082 ns | 0.0031 ns | 0.0029 ns |   0.9088 ns |  1.33 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   0.7091 ns | 0.0052 ns | 0.0048 ns |   0.7092 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |   0.6613 ns | 0.0026 ns | 0.0025 ns |   0.6617 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |   0.9268 ns | 0.0041 ns | 0.0039 ns |   0.9271 ns |  1.36 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |   0.7017 ns | 0.0136 ns | 0.0128 ns |   0.6933 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |   0.6230 ns | 0.0014 ns | 0.0013 ns |   0.6232 ns |  0.89 |    0.02 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |   0.5600 ns | 0.0029 ns | 0.0027 ns |   0.5604 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |   0.4293 ns | 0.0021 ns | 0.0017 ns |   0.4300 ns |  0.61 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |   0.7103 ns | 0.0081 ns | 0.0076 ns |   0.7137 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |   0.6898 ns | 0.0109 ns | 0.0102 ns |   0.6865 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |   1.0131 ns | 0.0064 ns | 0.0053 ns |   1.0129 ns |  1.47 |    0.02 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |   0.8312 ns | 0.0034 ns | 0.0032 ns |   0.8306 ns |  1.21 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net461 |   0.6823 ns | 0.0029 ns | 0.0026 ns |   0.6822 ns |  0.99 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |   0.7281 ns | 0.0038 ns | 0.0034 ns |   0.7284 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |   0.8328 ns | 0.0031 ns | 0.0029 ns |   0.8332 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |   0.5799 ns | 0.0032 ns | 0.0028 ns |   0.5792 ns |  0.70 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |   0.5659 ns | 0.0066 ns | 0.0058 ns |   0.5677 ns |  0.68 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |   0.4285 ns | 0.0020 ns | 0.0019 ns |   0.4290 ns |  0.51 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |   0.7244 ns | 0.0033 ns | 0.0027 ns |   0.7247 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |   0.7275 ns | 0.0036 ns | 0.0034 ns |   0.7277 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |   0.8702 ns | 0.0014 ns | 0.0012 ns |   0.8703 ns |  1.20 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |   0.8504 ns | 0.0036 ns | 0.0032 ns |   0.8505 ns |  1.17 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |   0.6078 ns | 0.0019 ns | 0.0017 ns |   0.6082 ns |  0.84 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |   0.7224 ns | 0.0030 ns | 0.0028 ns |   0.7222 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |   0.7254 ns | 0.0106 ns | 0.0099 ns |   0.7194 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |   0.5822 ns | 0.0027 ns | 0.0024 ns |   0.5829 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |   0.5993 ns | 0.0100 ns | 0.0093 ns |   0.6023 ns |  0.83 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 |   0.6992 ns | 0.0020 ns | 0.0019 ns |   0.6999 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |   0.7223 ns | 0.0025 ns | 0.0021 ns |   0.7222 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |   0.7221 ns | 0.0023 ns | 0.0022 ns |   0.7213 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |   0.9428 ns | 0.0023 ns | 0.0021 ns |   0.9426 ns |  1.31 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |   0.7169 ns | 0.0043 ns | 0.0040 ns |   0.7162 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |   0.6336 ns | 0.0023 ns | 0.0020 ns |   0.6338 ns |  0.88 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |   0.6987 ns | 0.0038 ns | 0.0031 ns |   0.6982 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |   0.6935 ns | 0.0033 ns | 0.0030 ns |   0.6936 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |   0.6737 ns | 0.0029 ns | 0.0025 ns |   0.6740 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |   0.7090 ns | 0.0040 ns | 0.0033 ns |   0.7080 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |   0.4362 ns | 0.0110 ns | 0.0092 ns |   0.4407 ns |  0.63 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |   0.7004 ns | 0.0037 ns | 0.0033 ns |   0.6996 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |   0.6357 ns | 0.0026 ns | 0.0024 ns |   0.6364 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |   1.0539 ns | 0.0026 ns | 0.0024 ns |   1.0542 ns |  1.66 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |   0.9116 ns | 0.0029 ns | 0.0024 ns |   0.9119 ns |  1.43 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |   0.8069 ns | 0.0030 ns | 0.0028 ns |   0.8071 ns |  1.27 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |   0.9220 ns | 0.0036 ns | 0.0034 ns |   0.9218 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |   0.7285 ns | 0.0074 ns | 0.0070 ns |   0.7303 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |   0.9909 ns | 0.0037 ns | 0.0033 ns |   0.9904 ns |  1.36 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |   0.5625 ns | 0.0024 ns | 0.0022 ns |   0.5623 ns |  0.77 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |   0.4299 ns | 0.0021 ns | 0.0019 ns |   0.4303 ns |  0.59 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |   0.6994 ns | 0.0031 ns | 0.0029 ns |   0.6991 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |   0.6852 ns | 0.0033 ns | 0.0029 ns |   0.6862 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |   1.0451 ns | 0.0073 ns | 0.0069 ns |   1.0463 ns |  1.52 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |   0.8589 ns | 0.0036 ns | 0.0033 ns |   0.8589 ns |  1.25 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |   0.7044 ns | 0.0135 ns | 0.0126 ns |   0.7114 ns |  1.03 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |   0.7224 ns | 0.0039 ns | 0.0034 ns |   0.7223 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |   0.6500 ns | 0.0029 ns | 0.0025 ns |   0.6501 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |   0.6730 ns | 0.0048 ns | 0.0043 ns |   0.6715 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |   0.7656 ns | 0.0030 ns | 0.0025 ns |   0.7655 ns |  1.18 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |   0.4302 ns | 0.0020 ns | 0.0017 ns |   0.4296 ns |  0.66 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |   0.7221 ns | 0.0034 ns | 0.0031 ns |   0.7220 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |   0.6831 ns | 0.0081 ns | 0.0076 ns |   0.6848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |   1.0108 ns | 0.0033 ns | 0.0031 ns |   1.0103 ns |  1.48 |    0.02 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |   0.8287 ns | 0.0024 ns | 0.0021 ns |   0.8289 ns |  1.21 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |   1.1271 ns | 0.0501 ns | 0.1338 ns |   1.1456 ns |  1.64 |    0.17 |     - |     - |     - |         - |
      FromIntNullable |        net472 |   0.7231 ns | 0.0034 ns | 0.0032 ns |   0.7229 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |   0.7178 ns | 0.0046 ns | 0.0036 ns |   0.7177 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |   0.6680 ns | 0.0027 ns | 0.0025 ns |   0.6676 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |   0.7518 ns | 0.0058 ns | 0.0051 ns |   0.7507 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |   0.7192 ns | 0.0026 ns | 0.0025 ns |   0.7199 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |   0.7179 ns | 0.0036 ns | 0.0034 ns |   0.7178 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |   0.7113 ns | 0.0033 ns | 0.0031 ns |   0.7098 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |   1.0538 ns | 0.0024 ns | 0.0022 ns |   1.0536 ns |  1.48 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |   0.9055 ns | 0.0035 ns | 0.0033 ns |   0.9044 ns |  1.27 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |   0.7147 ns | 0.0025 ns | 0.0023 ns |   0.7150 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |   0.7243 ns | 0.0055 ns | 0.0046 ns |   0.7229 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |   0.6516 ns | 0.0148 ns | 0.0138 ns |   0.6433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |   0.7127 ns | 0.0030 ns | 0.0025 ns |   0.7122 ns |  1.09 |    0.02 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |   0.7726 ns | 0.0020 ns | 0.0018 ns |   0.7725 ns |  1.19 |    0.03 |     - |     - |     - |         - |
             FromLong |        net461 |   0.7002 ns | 0.0026 ns | 0.0023 ns |   0.7003 ns |  1.08 |    0.02 |     - |     - |     - |         - |
             FromLong |        net472 |   0.7169 ns | 0.0054 ns | 0.0051 ns |   0.7187 ns |  1.10 |    0.03 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |   1.1500 ns | 0.0036 ns | 0.0033 ns |   1.1510 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |   1.1690 ns | 0.0033 ns | 0.0031 ns |   1.1690 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |   1.0754 ns | 0.0053 ns | 0.0044 ns |   1.0746 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |   1.1714 ns | 0.0022 ns | 0.0020 ns |   1.1706 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |   1.1109 ns | 0.0046 ns | 0.0038 ns |   1.1106 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |   0.7991 ns | 0.0030 ns | 0.0028 ns |   0.7984 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |   0.7453 ns | 0.0026 ns | 0.0024 ns |   0.7446 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |   0.7267 ns | 0.0029 ns | 0.0027 ns |   0.7264 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |   0.7013 ns | 0.0028 ns | 0.0023 ns |   0.7011 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |   0.7402 ns | 0.0022 ns | 0.0021 ns |   0.7402 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |   1.1508 ns | 0.0043 ns | 0.0038 ns |   1.1500 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |   1.1762 ns | 0.0116 ns | 0.0108 ns |   1.1702 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |   1.0990 ns | 0.0029 ns | 0.0025 ns |   1.0996 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |   1.1556 ns | 0.0030 ns | 0.0028 ns |   1.1564 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |   1.1188 ns | 0.0038 ns | 0.0035 ns |   1.1192 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |   0.7207 ns | 0.0029 ns | 0.0028 ns |   0.7212 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |   0.6537 ns | 0.0026 ns | 0.0024 ns |   0.6535 ns |  0.91 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |   0.7371 ns | 0.0024 ns | 0.0023 ns |   0.7374 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |   0.7196 ns | 0.0023 ns | 0.0022 ns |   0.7202 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |   0.7214 ns | 0.0029 ns | 0.0026 ns |   0.7222 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |   0.7528 ns | 0.0101 ns | 0.0094 ns |   0.7562 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |   1.0634 ns | 0.0035 ns | 0.0033 ns |   1.0635 ns |  1.41 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |   0.9246 ns | 0.0038 ns | 0.0036 ns |   0.9242 ns |  1.23 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |   0.7278 ns | 0.0037 ns | 0.0031 ns |   0.7289 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |   0.7488 ns | 0.0029 ns | 0.0026 ns |   0.7496 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |   0.9524 ns | 0.0029 ns | 0.0024 ns |   0.9534 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |   0.5705 ns | 0.0040 ns | 0.0033 ns |   0.5701 ns |  0.60 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |   0.7185 ns | 0.0031 ns | 0.0027 ns |   0.7186 ns |  0.75 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |   0.7189 ns | 0.0029 ns | 0.0027 ns |   0.7194 ns |  0.75 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |   0.7179 ns | 0.0028 ns | 0.0026 ns |   0.7181 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |   1.1450 ns | 0.0035 ns | 0.0033 ns |   1.1446 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |   1.3844 ns | 0.0029 ns | 0.0027 ns |   1.3849 ns |  1.21 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |   1.3048 ns | 0.0033 ns | 0.0031 ns |   1.3059 ns |  1.14 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |   1.1702 ns | 0.0022 ns | 0.0020 ns |   1.1706 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |   1.1100 ns | 0.0032 ns | 0.0028 ns |   1.1089 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |   1.1471 ns | 0.0028 ns | 0.0026 ns |   1.1473 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |   1.1805 ns | 0.0089 ns | 0.0079 ns |   1.1825 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |   1.0741 ns | 0.0035 ns | 0.0031 ns |   1.0738 ns |  0.94 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |   1.1660 ns | 0.0040 ns | 0.0037 ns |   1.1653 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |   1.3027 ns | 0.0029 ns | 0.0027 ns |   1.3029 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |   1.1260 ns | 0.0034 ns | 0.0031 ns |   1.1264 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |   1.1558 ns | 0.0046 ns | 0.0043 ns |   1.1547 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |   1.1547 ns | 0.0038 ns | 0.0034 ns |   1.1548 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |   1.1082 ns | 0.0034 ns | 0.0032 ns |   1.1096 ns |  0.98 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |   1.1208 ns | 0.0033 ns | 0.0030 ns |   1.1215 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |   0.5512 ns | 0.0022 ns | 0.0021 ns |   0.5518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |   0.4308 ns | 0.0021 ns | 0.0019 ns |   0.4314 ns |  0.78 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |   0.5062 ns | 0.0030 ns | 0.0026 ns |   0.5058 ns |  0.92 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |   0.7000 ns | 0.0022 ns | 0.0021 ns |   0.7000 ns |  1.27 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |   0.7433 ns | 0.0115 ns | 0.0108 ns |   0.7392 ns |  1.35 |    0.02 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   1.5371 ns | 0.0027 ns | 0.0025 ns |   1.5374 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   1.8128 ns | 0.0051 ns | 0.0045 ns |   1.8134 ns |  1.18 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   1.6388 ns | 0.0031 ns | 0.0029 ns |   1.6380 ns |  1.07 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   2.0233 ns | 0.0073 ns | 0.0069 ns |   2.0215 ns |  1.32 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   2.0420 ns | 0.0039 ns | 0.0037 ns |   2.0437 ns |  1.33 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |   2.2041 ns | 0.0049 ns | 0.0046 ns |   2.2048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |   2.2070 ns | 0.0032 ns | 0.0029 ns |   2.2073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |   2.1226 ns | 0.0075 ns | 0.0063 ns |   2.1212 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |   2.2397 ns | 0.0029 ns | 0.0027 ns |   2.2404 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |   2.2360 ns | 0.0036 ns | 0.0033 ns |   2.2357 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 373.1418 ns | 1.3531 ns | 1.1995 ns | 372.7869 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 313.7511 ns | 0.5835 ns | 0.5458 ns | 313.8423 ns |  0.84 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 293.2393 ns | 0.3664 ns | 0.3427 ns | 293.1273 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 637.0600 ns | 1.0046 ns | 0.8905 ns | 637.0213 ns |  1.71 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 645.2237 ns | 2.7478 ns | 2.5703 ns | 645.8638 ns |  1.73 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |   0.7174 ns | 0.0022 ns | 0.0018 ns |   0.7175 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |   0.6557 ns | 0.0028 ns | 0.0026 ns |   0.6553 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |   0.7448 ns | 0.0105 ns | 0.0099 ns |   0.7475 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |   0.7201 ns | 0.0028 ns | 0.0026 ns |   0.7205 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |   0.7180 ns | 0.0031 ns | 0.0029 ns |   0.7174 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |             |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |   1.2647 ns | 0.0039 ns | 0.0035 ns |   1.2650 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |   1.0383 ns | 0.0042 ns | 0.0037 ns |   1.0378 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |   0.9000 ns | 0.0031 ns | 0.0029 ns |   0.9008 ns |  0.71 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |   0.7141 ns | 0.0014 ns | 0.0012 ns |   0.7142 ns |  0.56 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |   0.7253 ns | 0.0050 ns | 0.0046 ns |   0.7241 ns |  0.57 |    0.00 |     - |     - |     - |         - |
