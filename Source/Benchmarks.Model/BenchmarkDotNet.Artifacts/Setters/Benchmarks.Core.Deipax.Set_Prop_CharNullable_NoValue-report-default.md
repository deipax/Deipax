
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
             FromBool | .NET Core 2.0 | 0.7258 ns | 0.0063 ns | 0.0056 ns | 0.7248 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 0.7150 ns | 0.0033 ns | 0.0029 ns | 0.7154 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 0.7233 ns | 0.0157 ns | 0.0147 ns | 0.7163 ns |  1.00 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 | 0.6318 ns | 0.0057 ns | 0.0050 ns | 0.6316 ns |  0.87 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 | 0.6370 ns | 0.0153 ns | 0.0143 ns | 0.6435 ns |  0.88 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 0.7219 ns | 0.0034 ns | 0.0030 ns | 0.7219 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 0.9597 ns | 0.0150 ns | 0.0133 ns | 0.9561 ns |  1.33 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 0.9360 ns | 0.0053 ns | 0.0049 ns | 0.9352 ns |  1.30 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 1.0237 ns | 0.0034 ns | 0.0030 ns | 1.0230 ns |  1.42 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 0.8047 ns | 0.0047 ns | 0.0042 ns | 0.8050 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 0.9585 ns | 0.0052 ns | 0.0049 ns | 0.9571 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 0.9375 ns | 0.0038 ns | 0.0034 ns | 0.9382 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 0.9397 ns | 0.0144 ns | 0.0135 ns | 0.9452 ns |  0.98 |    0.02 |     - |     - |     - |         - |
             FromChar |        net461 | 0.6649 ns | 0.0027 ns | 0.0022 ns | 0.6653 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 | 0.6580 ns | 0.0048 ns | 0.0042 ns | 0.6573 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 0.7190 ns | 0.0054 ns | 0.0045 ns | 0.7192 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 0.7363 ns | 0.0056 ns | 0.0050 ns | 0.7361 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 0.6670 ns | 0.0143 ns | 0.0134 ns | 0.6608 ns |  0.93 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 0.5431 ns | 0.0064 ns | 0.0060 ns | 0.5413 ns |  0.76 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 0.5324 ns | 0.0026 ns | 0.0023 ns | 0.5323 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 1.7254 ns | 0.0046 ns | 0.0043 ns | 1.7259 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 1.4143 ns | 0.0033 ns | 0.0027 ns | 1.4148 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 0.9220 ns | 0.0018 ns | 0.0014 ns | 0.9221 ns |  0.53 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 1.7635 ns | 0.0062 ns | 0.0058 ns | 1.7616 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 | 1.7542 ns | 0.0053 ns | 0.0044 ns | 1.7560 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.7827 ns | 0.0032 ns | 0.0029 ns | 1.7828 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.7954 ns | 0.0059 ns | 0.0055 ns | 1.7948 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 1.1756 ns | 0.0147 ns | 0.0138 ns | 1.1785 ns |  0.66 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 1.9843 ns | 0.0291 ns | 0.0272 ns | 1.9795 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.9202 ns | 0.0052 ns | 0.0043 ns | 1.9204 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 0.9546 ns | 0.0020 ns | 0.0018 ns | 0.9543 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 0.7297 ns | 0.0046 ns | 0.0040 ns | 0.7294 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 0.6884 ns | 0.0052 ns | 0.0046 ns | 0.6875 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 | 0.5669 ns | 0.0032 ns | 0.0027 ns | 0.5665 ns |  0.59 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 0.5541 ns | 0.0033 ns | 0.0029 ns | 0.5539 ns |  0.58 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.2075 ns | 0.0160 ns | 0.0150 ns | 1.2134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 1.2020 ns | 0.0213 ns | 0.0189 ns | 1.1976 ns |  1.00 |    0.02 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 1.1655 ns | 0.0058 ns | 0.0055 ns | 1.1641 ns |  0.97 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 1.9321 ns | 0.0071 ns | 0.0063 ns | 1.9329 ns |  1.60 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 1.9262 ns | 0.0055 ns | 0.0043 ns | 1.9259 ns |  1.59 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 1.3241 ns | 0.0061 ns | 0.0051 ns | 1.3256 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 1.4195 ns | 0.0079 ns | 0.0074 ns | 1.4172 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 0.7080 ns | 0.0126 ns | 0.0117 ns | 0.7130 ns |  0.53 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 | 1.7617 ns | 0.0035 ns | 0.0030 ns | 1.7623 ns |  1.33 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 | 1.7524 ns | 0.0042 ns | 0.0037 ns | 1.7524 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.8592 ns | 0.0057 ns | 0.0053 ns | 1.8579 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.7889 ns | 0.0105 ns | 0.0098 ns | 1.7877 ns |  0.96 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.1735 ns | 0.0043 ns | 0.0041 ns | 1.1723 ns |  0.63 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 2.1439 ns | 0.0217 ns | 0.0203 ns | 2.1380 ns |  1.15 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 1.8981 ns | 0.0044 ns | 0.0042 ns | 1.8985 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 0.9614 ns | 0.0181 ns | 0.0169 ns | 0.9707 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 0.7138 ns | 0.0050 ns | 0.0041 ns | 0.7124 ns |  0.74 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 0.6548 ns | 0.0051 ns | 0.0048 ns | 0.6544 ns |  0.68 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 0.6424 ns | 0.0043 ns | 0.0040 ns | 0.6422 ns |  0.67 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 | 0.6369 ns | 0.0109 ns | 0.0102 ns | 0.6359 ns |  0.66 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.1924 ns | 0.0071 ns | 0.0063 ns | 1.1907 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.2242 ns | 0.0144 ns | 0.0135 ns | 1.2195 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.1594 ns | 0.0169 ns | 0.0158 ns | 1.1647 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.9038 ns | 0.0069 ns | 0.0061 ns | 1.9023 ns |  1.60 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.8924 ns | 0.0044 ns | 0.0037 ns | 1.8924 ns |  1.59 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 2.0447 ns | 0.0064 ns | 0.0056 ns | 2.0440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 2.1819 ns | 0.0239 ns | 0.0224 ns | 2.1779 ns |  1.07 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 2.0516 ns | 0.0066 ns | 0.0062 ns | 2.0517 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 1.7579 ns | 0.0088 ns | 0.0069 ns | 1.7547 ns |  0.86 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 1.7518 ns | 0.0036 ns | 0.0033 ns | 1.7511 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 1.8939 ns | 0.0153 ns | 0.0143 ns | 1.8972 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.7835 ns | 0.0085 ns | 0.0071 ns | 1.7816 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.7206 ns | 0.0226 ns | 0.0212 ns | 1.7286 ns |  0.91 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 1.9024 ns | 0.0062 ns | 0.0055 ns | 1.9022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 1.8990 ns | 0.0137 ns | 0.0122 ns | 1.8957 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 1.4969 ns | 0.0196 ns | 0.0183 ns | 1.4880 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 1.4479 ns | 0.0065 ns | 0.0054 ns | 1.4469 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 0.7185 ns | 0.0063 ns | 0.0049 ns | 0.7172 ns |  0.48 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 1.8062 ns | 0.0059 ns | 0.0052 ns | 1.8060 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 1.7860 ns | 0.0032 ns | 0.0030 ns | 1.7869 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 2.1616 ns | 0.0066 ns | 0.0061 ns | 2.1623 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.9587 ns | 0.0186 ns | 0.0174 ns | 1.9486 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 2.3889 ns | 0.0749 ns | 0.1443 ns | 2.3891 ns |  1.10 |    0.06 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 2.1256 ns | 0.0055 ns | 0.0051 ns | 2.1253 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 1.9015 ns | 0.0035 ns | 0.0031 ns | 1.9004 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 1.9314 ns | 0.0129 ns | 0.0120 ns | 1.9267 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 1.8962 ns | 0.0079 ns | 0.0066 ns | 1.8939 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 1.7244 ns | 0.0032 ns | 0.0027 ns | 1.7241 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 | 1.7836 ns | 0.0044 ns | 0.0041 ns | 1.7833 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 | 1.7571 ns | 0.0051 ns | 0.0048 ns | 1.7564 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.8272 ns | 0.0037 ns | 0.0032 ns | 1.8271 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.7458 ns | 0.0070 ns | 0.0062 ns | 1.7432 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.8582 ns | 0.0156 ns | 0.0138 ns | 1.8605 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 2.0809 ns | 0.0246 ns | 0.0230 ns | 2.0701 ns |  1.14 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 2.0334 ns | 0.0206 ns | 0.0182 ns | 2.0408 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 1.9412 ns | 0.0258 ns | 0.0241 ns | 1.9517 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 2.1534 ns | 0.0030 ns | 0.0024 ns | 2.1539 ns |  1.11 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 1.9376 ns | 0.0069 ns | 0.0057 ns | 1.9358 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 1.8063 ns | 0.0055 ns | 0.0051 ns | 1.8070 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 | 1.7808 ns | 0.0033 ns | 0.0028 ns | 1.7805 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 2.1184 ns | 0.0051 ns | 0.0040 ns | 2.1180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.8073 ns | 0.0227 ns | 0.0212 ns | 1.8165 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.7960 ns | 0.0046 ns | 0.0041 ns | 1.7960 ns |  0.85 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 1.9148 ns | 0.0041 ns | 0.0039 ns | 1.9145 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 1.9219 ns | 0.0049 ns | 0.0046 ns | 1.9198 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 0.6932 ns | 0.0026 ns | 0.0024 ns | 0.6934 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 0.9594 ns | 0.0116 ns | 0.0103 ns | 0.9548 ns |  1.38 |    0.02 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 0.6797 ns | 0.0084 ns | 0.0078 ns | 0.6816 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 0.7211 ns | 0.0036 ns | 0.0032 ns | 0.7203 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 | 0.6022 ns | 0.0076 ns | 0.0071 ns | 0.6034 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 0.7368 ns | 0.0143 ns | 0.0126 ns | 0.7410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 0.9928 ns | 0.0054 ns | 0.0045 ns | 0.9924 ns |  1.35 |    0.03 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 0.9812 ns | 0.0154 ns | 0.0144 ns | 0.9743 ns |  1.33 |    0.03 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 0.9323 ns | 0.0065 ns | 0.0058 ns | 0.9310 ns |  1.27 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 0.9540 ns | 0.0046 ns | 0.0041 ns | 0.9528 ns |  1.30 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 0.9308 ns | 0.0038 ns | 0.0034 ns | 0.9308 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 0.9526 ns | 0.0043 ns | 0.0038 ns | 0.9519 ns |  1.02 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 0.9211 ns | 0.0033 ns | 0.0029 ns | 0.9209 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 0.7293 ns | 0.0053 ns | 0.0049 ns | 0.7291 ns |  0.78 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 | 0.5831 ns | 0.0032 ns | 0.0029 ns | 0.5830 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.1162 ns | 0.0061 ns | 0.0057 ns | 1.1139 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.2253 ns | 0.0235 ns | 0.0220 ns | 1.2379 ns |  1.10 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.2017 ns | 0.0170 ns | 0.0159 ns | 1.2068 ns |  1.08 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.1851 ns | 0.0026 ns | 0.0022 ns | 1.1852 ns |  1.06 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.2090 ns | 0.0032 ns | 0.0030 ns | 1.2090 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 1.1380 ns | 0.0269 ns | 0.0238 ns | 1.1285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 1.1932 ns | 0.0064 ns | 0.0053 ns | 1.1912 ns |  1.05 |    0.02 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 1.1883 ns | 0.0044 ns | 0.0034 ns | 1.1882 ns |  1.05 |    0.02 |     - |     - |     - |         - |
          FromDecimal |        net461 | 1.2029 ns | 0.0032 ns | 0.0030 ns | 1.2020 ns |  1.06 |    0.02 |     - |     - |     - |         - |
          FromDecimal |        net472 | 1.1787 ns | 0.0045 ns | 0.0042 ns | 1.1777 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 1.2587 ns | 0.0081 ns | 0.0075 ns | 1.2580 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 1.1625 ns | 0.0036 ns | 0.0030 ns | 1.1623 ns |  0.92 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 1.1521 ns | 0.0029 ns | 0.0027 ns | 1.1522 ns |  0.92 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 1.3599 ns | 0.0033 ns | 0.0031 ns | 1.3590 ns |  1.08 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 1.4126 ns | 0.0056 ns | 0.0050 ns | 1.4113 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 0.9822 ns | 0.0223 ns | 0.0198 ns | 0.9795 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 0.7725 ns | 0.0096 ns | 0.0090 ns | 0.7742 ns |  0.79 |    0.02 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 | 0.7248 ns | 0.0037 ns | 0.0035 ns | 0.7246 ns |  0.74 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 | 0.7216 ns | 0.0213 ns | 0.0199 ns | 0.7124 ns |  0.74 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 | 0.6953 ns | 0.0053 ns | 0.0050 ns | 0.6937 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.5142 ns | 0.0194 ns | 0.0181 ns | 1.5109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.6755 ns | 0.0057 ns | 0.0048 ns | 1.6772 ns |  1.11 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.4983 ns | 0.0047 ns | 0.0042 ns | 1.4983 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.6686 ns | 0.0044 ns | 0.0041 ns | 1.6699 ns |  1.10 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.6782 ns | 0.0069 ns | 0.0054 ns | 1.6784 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 3.0714 ns | 0.0112 ns | 0.0105 ns | 3.0687 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 3.1021 ns | 0.0062 ns | 0.0058 ns | 3.1009 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 2.7557 ns | 0.0092 ns | 0.0082 ns | 2.7555 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 2.8770 ns | 0.0076 ns | 0.0071 ns | 2.8743 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 3.3399 ns | 0.0082 ns | 0.0068 ns | 3.3395 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 1.6965 ns | 0.0083 ns | 0.0069 ns | 1.6973 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 1.6691 ns | 0.0138 ns | 0.0129 ns | 1.6624 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.6290 ns | 0.0033 ns | 0.0028 ns | 1.6291 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 1.7999 ns | 0.0059 ns | 0.0053 ns | 1.7980 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 1.7863 ns | 0.0071 ns | 0.0060 ns | 1.7851 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 2.5771 ns | 0.0096 ns | 0.0080 ns | 2.5771 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 2.1344 ns | 0.0049 ns | 0.0044 ns | 2.1333 ns |  0.83 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 1.8632 ns | 0.0055 ns | 0.0049 ns | 1.8627 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 | 1.7745 ns | 0.0043 ns | 0.0033 ns | 1.7759 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 1.7652 ns | 0.0057 ns | 0.0047 ns | 1.7648 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 1.8651 ns | 0.0089 ns | 0.0083 ns | 1.8631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 1.7899 ns | 0.0293 ns | 0.0274 ns | 1.8092 ns |  0.96 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 1.6954 ns | 0.0069 ns | 0.0054 ns | 1.6949 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 1.9198 ns | 0.0045 ns | 0.0042 ns | 1.9194 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 1.9000 ns | 0.0040 ns | 0.0034 ns | 1.8998 ns |  1.02 |    0.01 |     - |     - |     - |         - |
