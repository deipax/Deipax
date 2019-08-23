
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FAIBOE : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-HDWVEN : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-QWBUFU : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-UUEYQZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-TUNFLE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 0.5846 ns | 0.0033 ns | 0.0030 ns | 0.5849 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 0.4400 ns | 0.0020 ns | 0.0019 ns | 0.4399 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 1.1459 ns | 0.0496 ns | 0.0679 ns | 1.1394 ns |  1.95 |    0.14 |     - |     - |     - |         - |
             FromBool |        net461 | 0.7076 ns | 0.0051 ns | 0.0046 ns | 0.7077 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 | 0.7338 ns | 0.0162 ns | 0.0152 ns | 0.7261 ns |  1.26 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 0.4435 ns | 0.0043 ns | 0.0041 ns | 0.4428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 0.6716 ns | 0.0041 ns | 0.0038 ns | 0.6709 ns |  1.51 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 0.9313 ns | 0.0117 ns | 0.0109 ns | 0.9350 ns |  2.10 |    0.03 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 0.9402 ns | 0.0039 ns | 0.0034 ns | 0.9394 ns |  2.12 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 0.9625 ns | 0.0108 ns | 0.0096 ns | 0.9637 ns |  2.17 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 0.4468 ns | 0.0018 ns | 0.0015 ns | 0.4467 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 1.0500 ns | 0.0037 ns | 0.0033 ns | 1.0502 ns |  2.35 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 0.6929 ns | 0.0040 ns | 0.0037 ns | 0.6938 ns |  1.55 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 | 0.7110 ns | 0.0058 ns | 0.0052 ns | 0.7118 ns |  1.59 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 | 0.7396 ns | 0.0037 ns | 0.0035 ns | 0.7397 ns |  1.66 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 1.0252 ns | 0.0089 ns | 0.0084 ns | 1.0278 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 0.9119 ns | 0.0054 ns | 0.0047 ns | 0.9115 ns |  0.89 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 0.9539 ns | 0.0082 ns | 0.0073 ns | 0.9524 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 1.5032 ns | 0.0044 ns | 0.0039 ns | 1.5020 ns |  1.47 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 1.5405 ns | 0.0066 ns | 0.0062 ns | 1.5398 ns |  1.50 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 1.1134 ns | 0.0037 ns | 0.0034 ns | 1.1134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 1.3519 ns | 0.0067 ns | 0.0059 ns | 1.3516 ns |  1.21 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 0.7010 ns | 0.0073 ns | 0.0068 ns | 0.7020 ns |  0.63 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 1.6664 ns | 0.0054 ns | 0.0042 ns | 1.6655 ns |  1.50 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 1.8527 ns | 0.0177 ns | 0.0138 ns | 1.8553 ns |  1.66 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.4737 ns | 0.0045 ns | 0.0042 ns | 1.4719 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.4658 ns | 0.0044 ns | 0.0039 ns | 1.4653 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 1.3664 ns | 0.0568 ns | 0.1053 ns | 1.3496 ns |  0.96 |    0.07 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 2.5828 ns | 0.0088 ns | 0.0078 ns | 2.5820 ns |  1.75 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 2.5746 ns | 0.0063 ns | 0.0059 ns | 2.5748 ns |  1.75 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 0.5747 ns | 0.0088 ns | 0.0078 ns | 0.5768 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 0.4389 ns | 0.0054 ns | 0.0050 ns | 0.4379 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 0.6941 ns | 0.0035 ns | 0.0029 ns | 0.6945 ns |  1.21 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 | 0.7386 ns | 0.0217 ns | 0.0203 ns | 0.7284 ns |  1.28 |    0.03 |     - |     - |     - |         - |
             FromByte |        net472 | 0.7163 ns | 0.0030 ns | 0.0025 ns | 0.7160 ns |  1.25 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 0.8962 ns | 0.0057 ns | 0.0054 ns | 0.8950 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 0.9175 ns | 0.0097 ns | 0.0086 ns | 0.9201 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 1.1686 ns | 0.0154 ns | 0.0137 ns | 1.1738 ns |  1.30 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 1.6904 ns | 0.0054 ns | 0.0050 ns | 1.6902 ns |  1.89 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 1.7152 ns | 0.0209 ns | 0.0196 ns | 1.7230 ns |  1.91 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 1.1554 ns | 0.0023 ns | 0.0022 ns | 1.1559 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 1.0738 ns | 0.0060 ns | 0.0057 ns | 1.0759 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 0.9088 ns | 0.0024 ns | 0.0020 ns | 0.9094 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 1.8975 ns | 0.0092 ns | 0.0087 ns | 1.8991 ns |  1.64 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 | 1.8798 ns | 0.0077 ns | 0.0072 ns | 1.8783 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.6488 ns | 0.0148 ns | 0.0131 ns | 1.6493 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.6025 ns | 0.0045 ns | 0.0042 ns | 1.6020 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.5192 ns | 0.0444 ns | 0.0415 ns | 1.5178 ns |  0.92 |    0.03 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 2.1565 ns | 0.0084 ns | 0.0075 ns | 2.1542 ns |  1.31 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 2.1555 ns | 0.0082 ns | 0.0077 ns | 2.1538 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 0.4439 ns | 0.0022 ns | 0.0021 ns | 0.4441 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 0.4417 ns | 0.0111 ns | 0.0092 ns | 0.4451 ns |  1.00 |    0.02 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 0.7075 ns | 0.0072 ns | 0.0060 ns | 0.7097 ns |  1.59 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 | 0.7103 ns | 0.0039 ns | 0.0037 ns | 0.7095 ns |  1.60 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 | 0.7547 ns | 0.0031 ns | 0.0024 ns | 0.7545 ns |  1.70 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 0.9091 ns | 0.0041 ns | 0.0036 ns | 0.9092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 0.9021 ns | 0.0030 ns | 0.0025 ns | 0.9020 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.1254 ns | 0.0061 ns | 0.0054 ns | 1.1249 ns |  1.24 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.6643 ns | 0.0222 ns | 0.0208 ns | 1.6737 ns |  1.83 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.7329 ns | 0.0041 ns | 0.0039 ns | 1.7331 ns |  1.91 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 1.6111 ns | 0.0064 ns | 0.0060 ns | 1.6090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 1.9532 ns | 0.0129 ns | 0.0120 ns | 1.9561 ns |  1.21 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 1.6217 ns | 0.0059 ns | 0.0052 ns | 1.6225 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 1.6774 ns | 0.0179 ns | 0.0167 ns | 1.6702 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 | 1.6665 ns | 0.0038 ns | 0.0034 ns | 1.6661 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 2.0226 ns | 0.0110 ns | 0.0097 ns | 2.0232 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 2.2979 ns | 0.0043 ns | 0.0036 ns | 2.2983 ns |  1.14 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.8809 ns | 0.0092 ns | 0.0086 ns | 1.8795 ns |  0.93 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 2.2208 ns | 0.0218 ns | 0.0204 ns | 2.2280 ns |  1.10 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 2.2263 ns | 0.0140 ns | 0.0131 ns | 2.2201 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 1.2576 ns | 0.0058 ns | 0.0052 ns | 1.2572 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 1.1717 ns | 0.0054 ns | 0.0051 ns | 1.1710 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 0.6765 ns | 0.0060 ns | 0.0050 ns | 0.6741 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 | 1.6554 ns | 0.0050 ns | 0.0047 ns | 1.6561 ns |  1.32 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 1.6077 ns | 0.0162 ns | 0.0152 ns | 1.6007 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.7262 ns | 0.0114 ns | 0.0106 ns | 1.7205 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 2.1638 ns | 0.0144 ns | 0.0128 ns | 2.1692 ns |  1.25 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 0.9121 ns | 0.0055 ns | 0.0052 ns | 0.9123 ns |  0.53 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 2.8232 ns | 0.0072 ns | 0.0067 ns | 2.8234 ns |  1.64 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 2.7586 ns | 0.0075 ns | 0.0070 ns | 2.7587 ns |  1.60 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 1.6131 ns | 0.0128 ns | 0.0120 ns | 1.6168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 1.9480 ns | 0.0048 ns | 0.0045 ns | 1.9489 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 1.9158 ns | 0.0046 ns | 0.0041 ns | 1.9166 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 | 1.6750 ns | 0.0056 ns | 0.0052 ns | 1.6740 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 | 1.6317 ns | 0.0062 ns | 0.0055 ns | 1.6307 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 2.6526 ns | 0.0064 ns | 0.0057 ns | 2.6510 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 2.8202 ns | 0.0059 ns | 0.0049 ns | 2.8222 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 2.8893 ns | 0.0121 ns | 0.0107 ns | 2.8856 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 2.9314 ns | 0.0074 ns | 0.0066 ns | 2.9305 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 2.8258 ns | 0.0068 ns | 0.0057 ns | 2.8269 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 1.6501 ns | 0.0048 ns | 0.0045 ns | 1.6492 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 1.9537 ns | 0.0097 ns | 0.0090 ns | 1.9569 ns |  1.18 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 1.8805 ns | 0.0081 ns | 0.0076 ns | 1.8829 ns |  1.14 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 1.6534 ns | 0.0058 ns | 0.0048 ns | 1.6523 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 1.6040 ns | 0.0057 ns | 0.0054 ns | 1.6029 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 3.2272 ns | 0.0195 ns | 0.0183 ns | 3.2305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 2.8984 ns | 0.0107 ns | 0.0095 ns | 2.8958 ns |  0.90 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 3.2742 ns | 0.0166 ns | 0.0155 ns | 3.2783 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 2.6258 ns | 0.0061 ns | 0.0054 ns | 2.6266 ns |  0.81 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 2.6153 ns | 0.0077 ns | 0.0072 ns | 2.6135 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 0.4702 ns | 0.0034 ns | 0.0032 ns | 0.4695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 0.7398 ns | 0.0165 ns | 0.0154 ns | 0.7322 ns |  1.57 |    0.03 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 0.4933 ns | 0.0028 ns | 0.0027 ns | 0.4929 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 0.7290 ns | 0.0151 ns | 0.0141 ns | 0.7360 ns |  1.55 |    0.03 |     - |     - |     - |         - |
            FromFloat |        net472 | 0.6721 ns | 0.0035 ns | 0.0027 ns | 0.6714 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 0.4454 ns | 0.0028 ns | 0.0022 ns | 0.4450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 0.7357 ns | 0.0052 ns | 0.0049 ns | 0.7357 ns |  1.65 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 0.6551 ns | 0.0036 ns | 0.0030 ns | 0.6545 ns |  1.47 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 0.7486 ns | 0.0045 ns | 0.0040 ns | 0.7479 ns |  1.68 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 0.7199 ns | 0.0036 ns | 0.0034 ns | 0.7197 ns |  1.62 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 0.4911 ns | 0.0054 ns | 0.0045 ns | 0.4916 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 0.7297 ns | 0.0033 ns | 0.0026 ns | 0.7297 ns |  1.49 |    0.02 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 0.7097 ns | 0.0144 ns | 0.0135 ns | 0.7164 ns |  1.44 |    0.04 |     - |     - |     - |         - |
           FromDouble |        net461 | 0.7254 ns | 0.0035 ns | 0.0033 ns | 0.7253 ns |  1.48 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net472 | 0.6703 ns | 0.0047 ns | 0.0044 ns | 0.6698 ns |  1.37 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.1986 ns | 0.0065 ns | 0.0054 ns | 1.1971 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.1827 ns | 0.0025 ns | 0.0020 ns | 1.1829 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.1546 ns | 0.0042 ns | 0.0039 ns | 1.1549 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.1446 ns | 0.0182 ns | 0.0170 ns | 1.1511 ns |  0.95 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.1459 ns | 0.0217 ns | 0.0203 ns | 1.1374 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 1.1957 ns | 0.0042 ns | 0.0037 ns | 1.1944 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 1.1930 ns | 0.0067 ns | 0.0062 ns | 1.1928 ns |  1.00 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 1.1926 ns | 0.0046 ns | 0.0038 ns | 1.1932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 1.1261 ns | 0.0039 ns | 0.0032 ns | 1.1264 ns |  0.94 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 1.1312 ns | 0.0043 ns | 0.0038 ns | 1.1307 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 1.1753 ns | 0.0044 ns | 0.0037 ns | 1.1759 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 1.1395 ns | 0.0035 ns | 0.0031 ns | 1.1394 ns |  0.97 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 1.2542 ns | 0.0150 ns | 0.0141 ns | 1.2591 ns |  1.07 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 1.1273 ns | 0.0038 ns | 0.0036 ns | 1.1263 ns |  0.96 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 1.3908 ns | 0.0040 ns | 0.0037 ns | 1.3910 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 0.4451 ns | 0.0037 ns | 0.0035 ns | 0.4463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 0.7091 ns | 0.0062 ns | 0.0051 ns | 0.7072 ns |  1.59 |    0.02 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 | 0.4853 ns | 0.0055 ns | 0.0048 ns | 0.4838 ns |  1.09 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 | 0.7520 ns | 0.0203 ns | 0.0190 ns | 0.7630 ns |  1.69 |    0.05 |     - |     - |     - |         - |
         FromDateTime |        net472 | 0.6693 ns | 0.0018 ns | 0.0014 ns | 0.6698 ns |  1.50 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 2.0521 ns | 0.0055 ns | 0.0046 ns | 2.0529 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.4415 ns | 0.0071 ns | 0.0067 ns | 1.4420 ns |  0.70 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.2672 ns | 0.0064 ns | 0.0054 ns | 1.2666 ns |  0.62 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.6054 ns | 0.0049 ns | 0.0038 ns | 1.6060 ns |  0.78 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.4083 ns | 0.0045 ns | 0.0040 ns | 1.4075 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 2.2329 ns | 0.0028 ns | 0.0025 ns | 2.2331 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 2.2628 ns | 0.0065 ns | 0.0061 ns | 2.2614 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 2.1390 ns | 0.0249 ns | 0.0233 ns | 2.1520 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 2.2730 ns | 0.0062 ns | 0.0058 ns | 2.2727 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 2.2801 ns | 0.0146 ns | 0.0122 ns | 2.2840 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 2.5585 ns | 0.0064 ns | 0.0056 ns | 2.5571 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 2.2446 ns | 0.0030 ns | 0.0024 ns | 2.2449 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 2.9825 ns | 0.0117 ns | 0.0109 ns | 2.9793 ns |  1.17 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 | 2.5905 ns | 0.0232 ns | 0.0217 ns | 2.5830 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 2.5109 ns | 0.0057 ns | 0.0053 ns | 2.5095 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 1.5915 ns | 0.0049 ns | 0.0046 ns | 1.5907 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 1.8978 ns | 0.0114 ns | 0.0101 ns | 1.8972 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 1.4784 ns | 0.0037 ns | 0.0033 ns | 1.4779 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 | 1.7772 ns | 0.0034 ns | 0.0032 ns | 1.7760 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 1.6363 ns | 0.0066 ns | 0.0062 ns | 1.6346 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 2.0207 ns | 0.0064 ns | 0.0054 ns | 2.0196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 2.1746 ns | 0.0039 ns | 0.0037 ns | 2.1746 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 2.6755 ns | 0.0211 ns | 0.0187 ns | 2.6804 ns |  1.32 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 2.2003 ns | 0.0243 ns | 0.0227 ns | 2.2082 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 2.1799 ns | 0.0419 ns | 0.0392 ns | 2.1737 ns |  1.08 |    0.02 |     - |     - |     - |         - |
