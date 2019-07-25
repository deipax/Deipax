
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
             FromBool | .NET Core 2.0 |  0.6878 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.7163 ns | 0.0024 ns | 0.0022 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.5446 ns | 0.0030 ns | 0.0026 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6143 ns | 0.0036 ns | 0.0032 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6227 ns | 0.0025 ns | 0.0023 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.6915 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.7196 ns | 0.0030 ns | 0.0028 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.5593 ns | 0.0085 ns | 0.0079 ns |  0.81 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  0.5492 ns | 0.0041 ns | 0.0038 ns |  0.79 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  0.5542 ns | 0.0048 ns | 0.0045 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9182 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7423 ns | 0.0092 ns | 0.0086 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5393 ns | 0.0053 ns | 0.0047 ns |  0.59 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6186 ns | 0.0032 ns | 0.0030 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6167 ns | 0.0026 ns | 0.0023 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.6911 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9586 ns | 0.0032 ns | 0.0029 ns |  1.39 |    0.02 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.7943 ns | 0.0023 ns | 0.0019 ns |  1.15 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.8755 ns | 0.0023 ns | 0.0019 ns |  1.27 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9389 ns | 0.0083 ns | 0.0078 ns |  1.36 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6835 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7177 ns | 0.0026 ns | 0.0023 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6023 ns | 0.0029 ns | 0.0026 ns |  0.88 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5634 ns | 0.0025 ns | 0.0022 ns |  0.82 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5594 ns | 0.0018 ns | 0.0015 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1473 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1970 ns | 0.0075 ns | 0.0066 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9844 ns | 0.0029 ns | 0.0027 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.0084 ns | 0.0032 ns | 0.0030 ns |  1.75 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9777 ns | 0.0032 ns | 0.0028 ns |  1.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9198 ns | 0.0026 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7164 ns | 0.0044 ns | 0.0041 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5768 ns | 0.0036 ns | 0.0028 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5568 ns | 0.0025 ns | 0.0023 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5563 ns | 0.0022 ns | 0.0020 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0205 ns | 0.0039 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1841 ns | 0.0045 ns | 0.0042 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.0114 ns | 0.0091 ns | 0.0081 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.2602 ns | 0.0202 ns | 0.0189 ns |  2.21 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9771 ns | 0.0033 ns | 0.0027 ns |  1.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6876 ns | 0.0081 ns | 0.0075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.9346 ns | 0.0037 ns | 0.0031 ns |  1.36 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7252 ns | 0.0024 ns | 0.0022 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6660 ns | 0.0106 ns | 0.0094 ns |  0.97 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6600 ns | 0.0026 ns | 0.0023 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.1654 ns | 0.0026 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1564 ns | 0.0043 ns | 0.0036 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1172 ns | 0.0037 ns | 0.0033 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9994 ns | 0.0175 ns | 0.0164 ns |  1.71 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9888 ns | 0.0022 ns | 0.0019 ns |  1.71 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9247 ns | 0.0105 ns | 0.0098 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9634 ns | 0.0032 ns | 0.0028 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6951 ns | 0.0016 ns | 0.0014 ns |  0.75 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6753 ns | 0.0029 ns | 0.0027 ns |  0.73 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6535 ns | 0.0031 ns | 0.0026 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0419 ns | 0.0029 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.2191 ns | 0.0094 ns | 0.0088 ns |  1.17 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1576 ns | 0.0026 ns | 0.0023 ns |  1.11 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0020 ns | 0.0041 ns | 0.0039 ns |  1.92 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0140 ns | 0.0051 ns | 0.0045 ns |  1.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.6892 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.9398 ns | 0.0030 ns | 0.0028 ns |  1.36 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.8603 ns | 0.0024 ns | 0.0022 ns |  1.25 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.5809 ns | 0.0074 ns | 0.0069 ns |  0.84 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.5753 ns | 0.0023 ns | 0.0020 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.1752 ns | 0.0028 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.1934 ns | 0.0044 ns | 0.0041 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1338 ns | 0.0071 ns | 0.0066 ns |  0.96 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9528 ns | 0.0035 ns | 0.0029 ns |  1.66 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9465 ns | 0.0033 ns | 0.0031 ns |  1.66 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9147 ns | 0.0015 ns | 0.0013 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6867 ns | 0.0038 ns | 0.0036 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6861 ns | 0.0107 ns | 0.0100 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7162 ns | 0.0028 ns | 0.0022 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.5848 ns | 0.0025 ns | 0.0024 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0970 ns | 0.0028 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1253 ns | 0.0041 ns | 0.0036 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1151 ns | 0.0039 ns | 0.0033 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9749 ns | 0.0073 ns | 0.0065 ns |  1.80 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9560 ns | 0.0037 ns | 0.0035 ns |  1.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.8153 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.7090 ns | 0.0102 ns | 0.0090 ns |  0.87 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.6887 ns | 0.0036 ns | 0.0032 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  0.6968 ns | 0.0032 ns | 0.0030 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.2438 ns | 0.0525 ns | 0.0785 ns |  1.54 |    0.10 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.6841 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7023 ns | 0.0115 ns | 0.0107 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.6989 ns | 0.0039 ns | 0.0035 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.1233 ns | 0.0032 ns | 0.0029 ns |  1.26 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.1198 ns | 0.0018 ns | 0.0015 ns |  1.26 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9176 ns | 0.0042 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.7107 ns | 0.0084 ns | 0.0079 ns |  0.77 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7282 ns | 0.0028 ns | 0.0025 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  0.6961 ns | 0.0034 ns | 0.0030 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  0.6895 ns | 0.0037 ns | 0.0035 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.7323 ns | 0.0136 ns | 0.0128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.6975 ns | 0.0047 ns | 0.0044 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7337 ns | 0.0124 ns | 0.0116 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.3557 ns | 0.0021 ns | 0.0019 ns |  1.36 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.1297 ns | 0.0065 ns | 0.0061 ns |  1.23 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  1.1630 ns | 0.0036 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.9865 ns | 0.0123 ns | 0.0109 ns |  0.85 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.2098 ns | 0.0023 ns | 0.0018 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.9832 ns | 0.0035 ns | 0.0031 ns |  0.85 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.9697 ns | 0.0112 ns | 0.0105 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.4610 ns | 0.0027 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.2686 ns | 0.0033 ns | 0.0029 ns |  0.87 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.2521 ns | 0.0035 ns | 0.0032 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  2.1842 ns | 0.0079 ns | 0.0074 ns |  1.50 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  2.0557 ns | 0.0064 ns | 0.0057 ns |  1.41 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.7706 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.9361 ns | 0.0048 ns | 0.0042 ns |  1.21 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.9311 ns | 0.0026 ns | 0.0023 ns |  1.21 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.9482 ns | 0.0044 ns | 0.0037 ns |  1.23 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.9202 ns | 0.0025 ns | 0.0022 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9158 ns | 0.0038 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  2.1470 ns | 0.0034 ns | 0.0032 ns |  1.12 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.7061 ns | 0.0031 ns | 0.0029 ns |  0.89 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.6031 ns | 0.0187 ns | 0.0175 ns |  1.36 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.6043 ns | 0.0030 ns | 0.0025 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  7.5245 ns | 0.0514 ns | 0.0481 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  8.8080 ns | 0.0116 ns | 0.0109 ns |  1.17 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  4.9666 ns | 0.0317 ns | 0.0296 ns |  0.66 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  8.3559 ns | 0.0204 ns | 0.0191 ns |  1.11 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 |  9.3051 ns | 0.0076 ns | 0.0063 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 17.3753 ns | 0.0153 ns | 0.0128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 17.6559 ns | 0.0372 ns | 0.0330 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 11.1855 ns | 0.1237 ns | 0.1157 ns |  0.64 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 18.0340 ns | 0.0370 ns | 0.0346 ns |  1.04 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 18.2165 ns | 0.0330 ns | 0.0292 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6850 ns | 0.0041 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7153 ns | 0.0076 ns | 0.0071 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7409 ns | 0.0060 ns | 0.0053 ns |  1.08 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7009 ns | 0.0042 ns | 0.0040 ns |  1.02 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6871 ns | 0.0025 ns | 0.0022 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4657 ns | 0.0128 ns | 0.0119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4294 ns | 0.0069 ns | 0.0061 ns |  0.97 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4417 ns | 0.0043 ns | 0.0036 ns |  0.98 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4573 ns | 0.0119 ns | 0.0111 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4551 ns | 0.0034 ns | 0.0030 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.6693 ns | 0.0101 ns | 0.0090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 13.8777 ns | 0.0160 ns | 0.0149 ns |  1.44 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.5490 ns | 0.0103 ns | 0.0092 ns |  1.50 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 13.0732 ns | 0.0717 ns | 0.0636 ns |  1.35 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 12.7351 ns | 0.0168 ns | 0.0157 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  8.4345 ns | 0.0473 ns | 0.0443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 20.1571 ns | 0.0361 ns | 0.0320 ns |  2.39 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 14.4305 ns | 0.1762 ns | 0.1648 ns |  1.71 |    0.02 |     - |     - |     - |         - |
           FromString |        net461 |  8.3941 ns | 0.0317 ns | 0.0281 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 |  8.3476 ns | 0.0220 ns | 0.0195 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6893 ns | 0.0032 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7078 ns | 0.0062 ns | 0.0055 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7540 ns | 0.0027 ns | 0.0025 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7444 ns | 0.0033 ns | 0.0030 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.5843 ns | 0.0034 ns | 0.0032 ns |  0.85 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.4063 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1543 ns | 0.0027 ns | 0.0024 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1753 ns | 0.0053 ns | 0.0050 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9856 ns | 0.0033 ns | 0.0031 ns |  1.41 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9581 ns | 0.0048 ns | 0.0045 ns |  1.39 |    0.01 |     - |     - |     - |         - |
