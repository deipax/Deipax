
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FAIBOE : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-HDWVEN : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-QWBUFU : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-UUEYQZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-TUNFLE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.5461 ns | 0.0042 ns | 0.0035 ns |  0.5457 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.7209 ns | 0.0042 ns | 0.0039 ns |  0.7197 ns |  1.32 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.6974 ns | 0.0054 ns | 0.0051 ns |  0.6956 ns |  1.28 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6314 ns | 0.0031 ns | 0.0029 ns |  0.6315 ns |  1.16 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.8386 ns | 0.0031 ns | 0.0029 ns |  0.8383 ns |  1.54 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.5762 ns | 0.0050 ns | 0.0046 ns |  0.5766 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.7214 ns | 0.0043 ns | 0.0038 ns |  0.7212 ns |  1.25 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.6943 ns | 0.0043 ns | 0.0040 ns |  0.6943 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  0.5738 ns | 0.0137 ns | 0.0122 ns |  0.5796 ns |  1.00 |    0.03 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  0.7084 ns | 0.0061 ns | 0.0057 ns |  0.7069 ns |  1.23 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6812 ns | 0.0047 ns | 0.0041 ns |  0.6810 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7393 ns | 0.0041 ns | 0.0038 ns |  0.7382 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5404 ns | 0.0036 ns | 0.0032 ns |  0.5394 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6231 ns | 0.0038 ns | 0.0033 ns |  0.6225 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7373 ns | 0.0051 ns | 0.0047 ns |  0.7371 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.5600 ns | 0.0032 ns | 0.0027 ns |  0.5599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9694 ns | 0.0040 ns | 0.0036 ns |  0.9687 ns |  1.73 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.7952 ns | 0.0099 ns | 0.0093 ns |  0.7982 ns |  1.42 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.8943 ns | 0.0050 ns | 0.0042 ns |  0.8942 ns |  1.60 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9599 ns | 0.0028 ns | 0.0025 ns |  0.9593 ns |  1.71 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5392 ns | 0.0054 ns | 0.0045 ns |  0.5387 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7452 ns | 0.0079 ns | 0.0074 ns |  0.7468 ns |  1.38 |    0.02 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6969 ns | 0.0026 ns | 0.0023 ns |  0.6970 ns |  1.29 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5682 ns | 0.0134 ns | 0.0125 ns |  0.5737 ns |  1.05 |    0.03 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7387 ns | 0.0124 ns | 0.0116 ns |  0.7437 ns |  1.37 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.0173 ns | 0.0045 ns | 0.0040 ns |  1.0176 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.2094 ns | 0.0070 ns | 0.0066 ns |  1.2079 ns |  1.19 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.0266 ns | 0.0057 ns | 0.0050 ns |  1.0269 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9968 ns | 0.0034 ns | 0.0030 ns |  1.9974 ns |  1.96 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.0274 ns | 0.0041 ns | 0.0037 ns |  2.0271 ns |  1.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7212 ns | 0.0081 ns | 0.0076 ns |  0.7196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7360 ns | 0.0142 ns | 0.0133 ns |  0.7333 ns |  1.02 |    0.02 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7038 ns | 0.0113 ns | 0.0100 ns |  0.7091 ns |  0.98 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5650 ns | 0.0036 ns | 0.0033 ns |  0.5650 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7199 ns | 0.0036 ns | 0.0034 ns |  0.7199 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0147 ns | 0.0045 ns | 0.0040 ns |  1.0140 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1970 ns | 0.0033 ns | 0.0031 ns |  1.1970 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9876 ns | 0.0160 ns | 0.0149 ns |  0.9947 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.0431 ns | 0.0023 ns | 0.0019 ns |  2.0434 ns |  2.01 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.0707 ns | 0.0154 ns | 0.0144 ns |  2.0742 ns |  2.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.5787 ns | 0.0053 ns | 0.0050 ns |  0.5775 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.9460 ns | 0.0114 ns | 0.0096 ns |  0.9440 ns |  1.64 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.9330 ns | 0.0170 ns | 0.0142 ns |  0.9399 ns |  1.61 |    0.03 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6605 ns | 0.0050 ns | 0.0045 ns |  0.6585 ns |  1.14 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.9391 ns | 0.0039 ns | 0.0034 ns |  0.9389 ns |  1.62 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.0112 ns | 0.0042 ns | 0.0035 ns |  1.0111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1847 ns | 0.0032 ns | 0.0030 ns |  1.1856 ns |  1.17 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1569 ns | 0.0017 ns | 0.0014 ns |  1.1571 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.0177 ns | 0.0182 ns | 0.0171 ns |  2.0151 ns |  2.00 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.0493 ns | 0.0043 ns | 0.0040 ns |  2.0485 ns |  2.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.7071 ns | 0.0067 ns | 0.0063 ns |  0.7078 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9663 ns | 0.0051 ns | 0.0048 ns |  0.9665 ns |  1.37 |    0.02 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.9377 ns | 0.0141 ns | 0.0125 ns |  0.9429 ns |  1.33 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6692 ns | 0.0077 ns | 0.0064 ns |  0.6680 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.9817 ns | 0.0110 ns | 0.0102 ns |  0.9818 ns |  1.39 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0320 ns | 0.0057 ns | 0.0051 ns |  1.0317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.4950 ns | 0.0038 ns | 0.0034 ns |  1.4938 ns |  1.45 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1243 ns | 0.0045 ns | 0.0039 ns |  1.1243 ns |  1.09 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0116 ns | 0.0064 ns | 0.0060 ns |  2.0108 ns |  1.95 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0377 ns | 0.0045 ns | 0.0040 ns |  2.0369 ns |  1.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.5443 ns | 0.0046 ns | 0.0038 ns |  0.5430 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.9450 ns | 0.0044 ns | 0.0042 ns |  0.9442 ns |  1.74 |    0.02 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7389 ns | 0.0041 ns | 0.0037 ns |  0.7378 ns |  1.36 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.5871 ns | 0.0051 ns | 0.0048 ns |  0.5881 ns |  1.08 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7181 ns | 0.0039 ns | 0.0034 ns |  0.7188 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.1186 ns | 0.0026 ns | 0.0024 ns |  1.1185 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.4049 ns | 0.0065 ns | 0.0058 ns |  1.4054 ns |  1.26 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1838 ns | 0.0039 ns | 0.0035 ns |  1.1838 ns |  1.06 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9832 ns | 0.0313 ns | 0.0293 ns |  1.9698 ns |  1.77 |    0.03 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.0261 ns | 0.0195 ns | 0.0182 ns |  2.0315 ns |  1.81 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7189 ns | 0.0032 ns | 0.0028 ns |  0.7195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6948 ns | 0.0024 ns | 0.0022 ns |  0.6952 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7039 ns | 0.0035 ns | 0.0033 ns |  0.7035 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.5871 ns | 0.0050 ns | 0.0047 ns |  0.5867 ns |  0.82 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6725 ns | 0.0023 ns | 0.0022 ns |  0.6725 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1085 ns | 0.0023 ns | 0.0019 ns |  1.1083 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1432 ns | 0.0052 ns | 0.0049 ns |  1.1430 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1149 ns | 0.0163 ns | 0.0145 ns |  1.1208 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.2407 ns | 0.0037 ns | 0.0033 ns |  2.2414 ns |  2.02 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9704 ns | 0.0043 ns | 0.0040 ns |  1.9703 ns |  1.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6400 ns | 0.0032 ns | 0.0030 ns |  0.6410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.6954 ns | 0.0028 ns | 0.0026 ns |  0.6958 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7035 ns | 0.0041 ns | 0.0039 ns |  0.7032 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.6873 ns | 0.0029 ns | 0.0022 ns |  0.6880 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6944 ns | 0.0148 ns | 0.0139 ns |  0.7015 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7126 ns | 0.0055 ns | 0.0051 ns |  1.7136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7233 ns | 0.0074 ns | 0.0066 ns |  1.7227 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7362 ns | 0.0040 ns | 0.0038 ns |  1.7367 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.4433 ns | 0.0085 ns | 0.0079 ns |  2.4440 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.1118 ns | 0.0042 ns | 0.0039 ns |  2.1122 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.7016 ns | 0.0044 ns | 0.0036 ns |  0.7009 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.6980 ns | 0.0030 ns | 0.0028 ns |  0.6980 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7357 ns | 0.0095 ns | 0.0084 ns |  0.7387 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.7001 ns | 0.0073 ns | 0.0065 ns |  0.7008 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  0.6786 ns | 0.0039 ns | 0.0037 ns |  0.6783 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.7604 ns | 0.0200 ns | 0.0167 ns |  1.7667 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7213 ns | 0.0044 ns | 0.0042 ns |  1.7211 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7376 ns | 0.0062 ns | 0.0055 ns |  1.7374 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.4979 ns | 0.0215 ns | 0.0191 ns |  2.5046 ns |  1.42 |    0.02 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.1472 ns | 0.0257 ns | 0.0240 ns |  2.1604 ns |  1.22 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.7795 ns | 0.0056 ns | 0.0050 ns |  0.7787 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  1.4964 ns | 0.0054 ns | 0.0048 ns |  1.4960 ns |  1.92 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.9878 ns | 0.0039 ns | 0.0032 ns |  0.9879 ns |  1.27 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.9864 ns | 0.0147 ns | 0.0137 ns |  0.9805 ns |  1.27 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.9709 ns | 0.0044 ns | 0.0039 ns |  0.9706 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.4681 ns | 0.0066 ns | 0.0059 ns |  1.4662 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.2845 ns | 0.0046 ns | 0.0043 ns |  1.2840 ns |  0.88 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.2285 ns | 0.0028 ns | 0.0025 ns |  1.2281 ns |  0.84 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  2.0799 ns | 0.0039 ns | 0.0037 ns |  2.0792 ns |  1.42 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  2.0744 ns | 0.0045 ns | 0.0042 ns |  2.0740 ns |  1.41 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.7834 ns | 0.0040 ns | 0.0037 ns |  0.7836 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.9502 ns | 0.0055 ns | 0.0043 ns |  0.9495 ns |  1.21 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.9281 ns | 0.0139 ns | 0.0130 ns |  0.9217 ns |  1.18 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.9320 ns | 0.0072 ns | 0.0063 ns |  0.9308 ns |  1.19 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.9436 ns | 0.0191 ns | 0.0179 ns |  0.9552 ns |  1.20 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9747 ns | 0.0047 ns | 0.0044 ns |  1.9741 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  2.2335 ns | 0.0073 ns | 0.0065 ns |  2.2336 ns |  1.13 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.7066 ns | 0.0049 ns | 0.0046 ns |  1.7059 ns |  0.86 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.6601 ns | 0.0452 ns | 0.0423 ns |  2.6451 ns |  1.35 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.5725 ns | 0.0052 ns | 0.0049 ns |  2.5730 ns |  1.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  7.3855 ns | 0.0132 ns | 0.0123 ns |  7.3852 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  8.7946 ns | 0.0200 ns | 0.0178 ns |  8.8022 ns |  1.19 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.1351 ns | 0.0358 ns | 0.0335 ns |  5.1225 ns |  0.70 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  8.4245 ns | 0.0132 ns | 0.0123 ns |  8.4219 ns |  1.14 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  8.4386 ns | 0.0335 ns | 0.0297 ns |  8.4393 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 17.7874 ns | 0.0316 ns | 0.0296 ns | 17.7925 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 17.9822 ns | 0.0321 ns | 0.0300 ns | 17.9808 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 11.4938 ns | 0.1648 ns | 0.1542 ns | 11.5373 ns |  0.65 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 18.4470 ns | 0.0427 ns | 0.0357 ns | 18.4487 ns |  1.04 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 18.6956 ns | 0.0337 ns | 0.0263 ns | 18.6994 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.5660 ns | 0.0042 ns | 0.0037 ns |  0.5663 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6998 ns | 0.0065 ns | 0.0058 ns |  0.6995 ns |  1.24 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7428 ns | 0.0024 ns | 0.0023 ns |  0.7435 ns |  1.31 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7001 ns | 0.0049 ns | 0.0041 ns |  0.6998 ns |  1.24 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6812 ns | 0.0042 ns | 0.0039 ns |  0.6792 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4795 ns | 0.0059 ns | 0.0050 ns |  1.4780 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  2.0075 ns | 0.0405 ns | 0.0379 ns |  2.0117 ns |  1.36 |    0.03 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4888 ns | 0.0041 ns | 0.0038 ns |  1.4888 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  2.1406 ns | 0.0099 ns | 0.0092 ns |  2.1384 ns |  1.45 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4437 ns | 0.0084 ns | 0.0078 ns |  1.4407 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.7367 ns | 0.0187 ns | 0.0166 ns |  9.7327 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 13.9800 ns | 0.0303 ns | 0.0283 ns | 13.9750 ns |  1.44 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.7818 ns | 0.0890 ns | 0.0832 ns | 14.8222 ns |  1.52 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 12.9192 ns | 0.0182 ns | 0.0162 ns | 12.9204 ns |  1.33 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.1601 ns | 0.0270 ns | 0.0239 ns | 13.1567 ns |  1.35 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  8.4084 ns | 0.0168 ns | 0.0157 ns |  8.4068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 20.2939 ns | 0.0328 ns | 0.0290 ns | 20.2917 ns |  2.41 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 14.2829 ns | 0.0559 ns | 0.0495 ns | 14.2712 ns |  1.70 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  8.4866 ns | 0.0696 ns | 0.0651 ns |  8.4554 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 |  8.4061 ns | 0.0474 ns | 0.0443 ns |  8.3806 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6213 ns | 0.0045 ns | 0.0038 ns |  0.6207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6957 ns | 0.0050 ns | 0.0042 ns |  0.6944 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7683 ns | 0.0152 ns | 0.0134 ns |  0.7735 ns |  1.24 |    0.03 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.5884 ns | 0.0037 ns | 0.0035 ns |  0.5870 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.6733 ns | 0.0036 ns | 0.0034 ns |  0.6726 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1991 ns | 0.0040 ns | 0.0038 ns |  1.1991 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1765 ns | 0.0051 ns | 0.0043 ns |  1.1769 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1666 ns | 0.0055 ns | 0.0052 ns |  1.1655 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9858 ns | 0.0142 ns | 0.0133 ns |  1.9801 ns |  1.66 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9788 ns | 0.0204 ns | 0.0191 ns |  1.9711 ns |  1.65 |    0.02 |     - |     - |     - |         - |
