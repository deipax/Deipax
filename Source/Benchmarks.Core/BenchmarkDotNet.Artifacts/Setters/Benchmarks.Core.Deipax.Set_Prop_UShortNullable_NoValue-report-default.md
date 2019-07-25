
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
             FromBool | .NET Core 2.0 |  0.9378 ns | 0.0053 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9429 ns | 0.0037 ns | 0.0031 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9194 ns | 0.0119 ns | 0.0111 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9640 ns | 0.0077 ns | 0.0072 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.8803 ns | 0.0042 ns | 0.0040 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3379 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1840 ns | 0.0035 ns | 0.0029 ns |  0.88 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9921 ns | 0.0047 ns | 0.0044 ns |  0.74 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9865 ns | 0.0155 ns | 0.0145 ns |  1.49 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1892 ns | 0.0153 ns | 0.0143 ns |  1.64 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9385 ns | 0.0052 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7116 ns | 0.0063 ns | 0.0059 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5994 ns | 0.0039 ns | 0.0032 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7374 ns | 0.0035 ns | 0.0031 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6324 ns | 0.0036 ns | 0.0034 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1711 ns | 0.0051 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.2057 ns | 0.0036 ns | 0.0030 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0953 ns | 0.0055 ns | 0.0051 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9492 ns | 0.0228 ns | 0.0213 ns |  1.67 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9101 ns | 0.0043 ns | 0.0036 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3294 ns | 0.0059 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.4313 ns | 0.0106 ns | 0.0094 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7336 ns | 0.0042 ns | 0.0039 ns |  0.55 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7881 ns | 0.0026 ns | 0.0022 ns |  1.35 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7722 ns | 0.0046 ns | 0.0043 ns |  1.33 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.8525 ns | 0.0119 ns | 0.0106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.7882 ns | 0.0034 ns | 0.0028 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1146 ns | 0.0034 ns | 0.0030 ns |  0.60 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9670 ns | 0.0075 ns | 0.0063 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9845 ns | 0.0076 ns | 0.0067 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9294 ns | 0.0039 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7284 ns | 0.0032 ns | 0.0030 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6987 ns | 0.0094 ns | 0.0088 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7136 ns | 0.0026 ns | 0.0023 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5687 ns | 0.0040 ns | 0.0034 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1672 ns | 0.0095 ns | 0.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1830 ns | 0.0039 ns | 0.0035 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1462 ns | 0.0037 ns | 0.0033 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9663 ns | 0.0051 ns | 0.0048 ns |  1.68 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9436 ns | 0.0036 ns | 0.0032 ns |  1.67 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3437 ns | 0.0128 ns | 0.0113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.4068 ns | 0.0052 ns | 0.0049 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6973 ns | 0.0027 ns | 0.0024 ns |  0.52 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.9563 ns | 0.0261 ns | 0.0244 ns |  1.45 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 |  1.7957 ns | 0.0027 ns | 0.0026 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8576 ns | 0.0072 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7731 ns | 0.0039 ns | 0.0032 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1665 ns | 0.0039 ns | 0.0037 ns |  0.63 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9304 ns | 0.0016 ns | 0.0013 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.0537 ns | 0.0031 ns | 0.0027 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.2985 ns | 0.0529 ns | 0.0543 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6996 ns | 0.0034 ns | 0.0031 ns |  0.54 |    0.02 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6792 ns | 0.0105 ns | 0.0098 ns |  0.52 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7422 ns | 0.0038 ns | 0.0036 ns |  0.57 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6294 ns | 0.0040 ns | 0.0038 ns |  0.48 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.6998 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.7433 ns | 0.0094 ns | 0.0088 ns |  1.06 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.6499 ns | 0.0017 ns | 0.0014 ns |  0.93 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  0.7482 ns | 0.0033 ns | 0.0031 ns |  1.07 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  0.6804 ns | 0.0037 ns | 0.0033 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8722 ns | 0.0107 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  2.1362 ns | 0.0027 ns | 0.0023 ns |  1.14 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.8406 ns | 0.0108 ns | 0.0096 ns |  0.98 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.9048 ns | 0.0167 ns | 0.0148 ns |  1.02 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7775 ns | 0.0080 ns | 0.0075 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.0700 ns | 0.0185 ns | 0.0173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.7696 ns | 0.0066 ns | 0.0052 ns |  0.85 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.7095 ns | 0.0041 ns | 0.0038 ns |  0.83 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9386 ns | 0.0143 ns | 0.0133 ns |  0.94 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9143 ns | 0.0044 ns | 0.0041 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4881 ns | 0.0064 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4447 ns | 0.0049 ns | 0.0046 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  1.0777 ns | 0.0048 ns | 0.0040 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.8479 ns | 0.0029 ns | 0.0027 ns |  1.24 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.9328 ns | 0.0242 ns | 0.0227 ns |  1.30 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.9562 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9304 ns | 0.0045 ns | 0.0037 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.5560 ns | 0.0144 ns | 0.0135 ns |  0.80 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9023 ns | 0.0056 ns | 0.0049 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9410 ns | 0.0044 ns | 0.0041 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8565 ns | 0.0032 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8395 ns | 0.0152 ns | 0.0142 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7037 ns | 0.0066 ns | 0.0058 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.8526 ns | 0.0056 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.9023 ns | 0.0185 ns | 0.0173 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.3024 ns | 0.0127 ns | 0.0119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7507 ns | 0.0184 ns | 0.0172 ns |  0.76 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7684 ns | 0.0094 ns | 0.0083 ns |  0.77 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.0036 ns | 0.0049 ns | 0.0038 ns |  0.87 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.0695 ns | 0.0129 ns | 0.0121 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8857 ns | 0.0066 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7375 ns | 0.0032 ns | 0.0030 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6676 ns | 0.0049 ns | 0.0046 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7809 ns | 0.0052 ns | 0.0049 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8192 ns | 0.0048 ns | 0.0040 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.8298 ns | 0.0195 ns | 0.0183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.8382 ns | 0.0048 ns | 0.0042 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7707 ns | 0.0079 ns | 0.0070 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9339 ns | 0.0046 ns | 0.0043 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.8732 ns | 0.0055 ns | 0.0046 ns |  1.57 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.9423 ns | 0.0092 ns | 0.0086 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  4.0963 ns | 0.0215 ns | 0.0191 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.8386 ns | 0.0179 ns | 0.0168 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.8241 ns | 0.0081 ns | 0.0072 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.8698 ns | 0.0143 ns | 0.0133 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.9133 ns | 0.0055 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.8743 ns | 0.0045 ns | 0.0040 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.6943 ns | 0.0060 ns | 0.0056 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9048 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  2.1238 ns | 0.0220 ns | 0.0206 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.9650 ns | 0.0129 ns | 0.0121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.6174 ns | 0.0107 ns | 0.0094 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.1645 ns | 0.0096 ns | 0.0075 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.7918 ns | 0.0069 ns | 0.0065 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.9980 ns | 0.0123 ns | 0.0109 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9759 ns | 0.0032 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9062 ns | 0.0037 ns | 0.0033 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9086 ns | 0.0057 ns | 0.0053 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.0962 ns | 0.0047 ns | 0.0044 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1679 ns | 0.0270 ns | 0.0253 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.8957 ns | 0.0258 ns | 0.0241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.8781 ns | 0.0347 ns | 0.0290 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.9623 ns | 0.1280 ns | 0.1198 ns |  0.50 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.2623 ns | 0.0754 ns | 0.0705 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.1143 ns | 0.0274 ns | 0.0229 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.6929 ns | 0.0496 ns | 0.0464 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  9.0972 ns | 0.0201 ns | 0.0188 ns |  1.05 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5489 ns | 0.0057 ns | 0.0050 ns |  0.29 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.8012 ns | 0.0212 ns | 0.0177 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.2347 ns | 0.0298 ns | 0.0264 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9269 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9759 ns | 0.0048 ns | 0.0037 ns |  1.05 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7293 ns | 0.0038 ns | 0.0031 ns |  0.79 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6839 ns | 0.0033 ns | 0.0031 ns |  0.74 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7201 ns | 0.0031 ns | 0.0029 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4742 ns | 0.0036 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6994 ns | 0.0123 ns | 0.0115 ns |  1.15 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5037 ns | 0.0119 ns | 0.0112 ns |  1.02 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6819 ns | 0.0036 ns | 0.0034 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.9561 ns | 0.0047 ns | 0.0037 ns |  1.33 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0550 ns | 0.0180 ns | 0.0159 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8746 ns | 0.0092 ns | 0.0071 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7207 ns | 0.0096 ns | 0.0080 ns |  0.89 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8542 ns | 0.0104 ns | 0.0087 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8903 ns | 0.0079 ns | 0.0070 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8489 ns | 0.0048 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  2.1389 ns | 0.0102 ns | 0.0095 ns |  1.16 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9365 ns | 0.0059 ns | 0.0053 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.8038 ns | 0.0045 ns | 0.0035 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.8430 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8901 ns | 0.0054 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.9061 ns | 0.0033 ns | 0.0030 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.6868 ns | 0.0041 ns | 0.0037 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.8552 ns | 0.0054 ns | 0.0050 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.9171 ns | 0.0060 ns | 0.0047 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8639 ns | 0.0041 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.0685 ns | 0.0664 ns | 0.0738 ns |  1.11 |    0.04 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.7421 ns | 0.0139 ns | 0.0130 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9006 ns | 0.0056 ns | 0.0044 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9414 ns | 0.0070 ns | 0.0058 ns |  1.04 |    0.00 |     - |     - |     - |         - |
