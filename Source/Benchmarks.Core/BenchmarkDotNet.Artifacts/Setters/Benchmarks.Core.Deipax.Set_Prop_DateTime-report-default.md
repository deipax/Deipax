
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |        Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |------------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |   0.7247 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   0.6563 ns | 0.0030 ns | 0.0028 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   0.9029 ns | 0.0034 ns | 0.0032 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |   0.4455 ns | 0.0015 ns | 0.0013 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |   0.4424 ns | 0.0017 ns | 0.0015 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   0.7350 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   0.8970 ns | 0.0029 ns | 0.0026 ns |  1.22 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   0.9210 ns | 0.0047 ns | 0.0041 ns |  1.25 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |   0.6742 ns | 0.0020 ns | 0.0018 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |   0.6713 ns | 0.0032 ns | 0.0028 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |   0.9483 ns | 0.0028 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |   0.6037 ns | 0.0046 ns | 0.0043 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |   0.6527 ns | 0.0027 ns | 0.0025 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |   0.4429 ns | 0.0028 ns | 0.0026 ns |  0.47 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |   0.4404 ns | 0.0039 ns | 0.0036 ns |  0.46 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |   0.9454 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |   1.0031 ns | 0.0046 ns | 0.0038 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |   0.8587 ns | 0.0096 ns | 0.0085 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |   0.6923 ns | 0.0045 ns | 0.0040 ns |  0.73 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |   0.6963 ns | 0.0028 ns | 0.0023 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |   0.7228 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |   0.5707 ns | 0.0027 ns | 0.0026 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |   0.6554 ns | 0.0026 ns | 0.0023 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |   0.9711 ns | 0.0026 ns | 0.0020 ns |  1.34 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |   0.4407 ns | 0.0010 ns | 0.0009 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |   0.7216 ns | 0.0024 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |   0.8600 ns | 0.0009 ns | 0.0007 ns |  1.19 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |   0.8065 ns | 0.0408 ns | 0.0340 ns |  1.12 |    0.05 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |   0.6155 ns | 0.0033 ns | 0.0029 ns |  0.85 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |   0.6245 ns | 0.0112 ns | 0.0105 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |   0.9537 ns | 0.0022 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |   0.5950 ns | 0.0042 ns | 0.0039 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |   0.7170 ns | 0.0038 ns | 0.0033 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |   0.4421 ns | 0.0018 ns | 0.0015 ns |  0.46 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |   0.4373 ns | 0.0075 ns | 0.0071 ns |  0.46 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |   0.9578 ns | 0.0075 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |   0.8993 ns | 0.0026 ns | 0.0025 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |   0.9229 ns | 0.0046 ns | 0.0043 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |   0.6450 ns | 0.0029 ns | 0.0026 ns |  0.67 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |   0.6461 ns | 0.0054 ns | 0.0048 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |   0.7346 ns | 0.0104 ns | 0.0092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |   0.6606 ns | 0.0035 ns | 0.0030 ns |  0.90 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |   0.9012 ns | 0.0014 ns | 0.0012 ns |  1.23 |    0.02 |     - |     - |     - |         - |
            FromShort |        net461 |   0.4411 ns | 0.0021 ns | 0.0019 ns |  0.60 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |   0.4468 ns | 0.0035 ns | 0.0033 ns |  0.61 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |   0.7163 ns | 0.0041 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |   1.0469 ns | 0.0044 ns | 0.0041 ns |  1.46 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |   0.9019 ns | 0.0052 ns | 0.0048 ns |  1.26 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |   0.7284 ns | 0.0137 ns | 0.0107 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |   0.7139 ns | 0.0030 ns | 0.0027 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |   0.9457 ns | 0.0025 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |   0.6028 ns | 0.0031 ns | 0.0029 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |   0.6902 ns | 0.0028 ns | 0.0025 ns |  0.73 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |   0.4534 ns | 0.0089 ns | 0.0083 ns |  0.48 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |   0.4417 ns | 0.0013 ns | 0.0011 ns |  0.47 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |   0.9443 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |   1.0190 ns | 0.0137 ns | 0.0128 ns |  1.08 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |   0.8348 ns | 0.0078 ns | 0.0069 ns |  0.88 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |   0.6907 ns | 0.0045 ns | 0.0040 ns |  0.73 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |   0.6914 ns | 0.0023 ns | 0.0021 ns |  0.73 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |   0.7258 ns | 0.0095 ns | 0.0089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |   0.6567 ns | 0.0019 ns | 0.0017 ns |  0.90 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |   0.6925 ns | 0.0030 ns | 0.0025 ns |  0.95 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |   0.4445 ns | 0.0014 ns | 0.0011 ns |  0.61 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |   0.4421 ns | 0.0027 ns | 0.0025 ns |  0.61 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |   0.7389 ns | 0.0070 ns | 0.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |   1.0003 ns | 0.0032 ns | 0.0027 ns |  1.35 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |   0.8582 ns | 0.0027 ns | 0.0025 ns |  1.16 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |   0.6932 ns | 0.0066 ns | 0.0052 ns |  0.94 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |   0.6922 ns | 0.0028 ns | 0.0027 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |   0.9513 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |   0.7201 ns | 0.0023 ns | 0.0020 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |   0.6865 ns | 0.0033 ns | 0.0029 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |   0.7277 ns | 0.0022 ns | 0.0019 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |   0.7244 ns | 0.0034 ns | 0.0030 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |   0.9492 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |   1.0844 ns | 0.0159 ns | 0.0141 ns |  1.14 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |   0.8427 ns | 0.0038 ns | 0.0036 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |   0.7246 ns | 0.0056 ns | 0.0047 ns |  0.76 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |   0.7249 ns | 0.0067 ns | 0.0059 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |   0.7229 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |   0.7082 ns | 0.0029 ns | 0.0025 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |   0.6913 ns | 0.0070 ns | 0.0062 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |   0.7091 ns | 0.0034 ns | 0.0029 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |   0.7024 ns | 0.0016 ns | 0.0014 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |   1.1262 ns | 0.0038 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |   1.1601 ns | 0.0021 ns | 0.0017 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |   1.1807 ns | 0.0033 ns | 0.0030 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |   1.1732 ns | 0.0038 ns | 0.0034 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |   1.1798 ns | 0.0129 ns | 0.0115 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |   0.9668 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |   0.9289 ns | 0.0032 ns | 0.0030 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |   0.7119 ns | 0.0040 ns | 0.0036 ns |  0.74 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |   0.7126 ns | 0.0046 ns | 0.0043 ns |  0.74 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |   0.7011 ns | 0.0026 ns | 0.0023 ns |  0.73 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |   1.1288 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |   1.1624 ns | 0.0038 ns | 0.0034 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |   1.1497 ns | 0.0039 ns | 0.0036 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |   1.1637 ns | 0.0027 ns | 0.0022 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |   1.1571 ns | 0.0040 ns | 0.0033 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |   0.6936 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |   0.7251 ns | 0.0035 ns | 0.0033 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |   0.6942 ns | 0.0029 ns | 0.0024 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |   0.7307 ns | 0.0059 ns | 0.0055 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |   0.7404 ns | 0.0081 ns | 0.0072 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |   0.7363 ns | 0.0123 ns | 0.0115 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |   1.0801 ns | 0.0023 ns | 0.0021 ns |  1.47 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |   0.8375 ns | 0.0078 ns | 0.0069 ns |  1.14 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |   0.7315 ns | 0.0020 ns | 0.0016 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |   0.7331 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |   0.9210 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |   0.7261 ns | 0.0080 ns | 0.0071 ns |  0.79 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |   0.5738 ns | 0.0032 ns | 0.0030 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |   0.7280 ns | 0.0024 ns | 0.0022 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |   0.7321 ns | 0.0024 ns | 0.0021 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |   1.1044 ns | 0.0027 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |   1.3997 ns | 0.0046 ns | 0.0043 ns |  1.27 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |   1.3795 ns | 0.0032 ns | 0.0029 ns |  1.25 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |   1.1746 ns | 0.0023 ns | 0.0020 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |   1.1684 ns | 0.0023 ns | 0.0021 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |   1.1777 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |   1.3435 ns | 0.0041 ns | 0.0039 ns |  1.14 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |   1.1478 ns | 0.0027 ns | 0.0024 ns |  0.97 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |   1.1780 ns | 0.0063 ns | 0.0056 ns |  1.00 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 |   6.2495 ns | 0.0064 ns | 0.0054 ns |  5.30 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |   1.1529 ns | 0.0120 ns | 0.0113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |   1.1562 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |   1.1401 ns | 0.0060 ns | 0.0050 ns |  0.99 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |   1.1164 ns | 0.0050 ns | 0.0045 ns |  0.97 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |   1.1142 ns | 0.0042 ns | 0.0037 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |   0.7154 ns | 0.0031 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |   0.7084 ns | 0.0047 ns | 0.0044 ns |  0.99 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |   0.4801 ns | 0.0024 ns | 0.0023 ns |  0.67 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |   0.7119 ns | 0.0047 ns | 0.0041 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |   0.7009 ns | 0.0025 ns | 0.0024 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   1.5182 ns | 0.0031 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   1.8225 ns | 0.0039 ns | 0.0034 ns |  1.20 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   1.7270 ns | 0.0029 ns | 0.0023 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   2.2575 ns | 0.0034 ns | 0.0032 ns |  1.49 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   2.0270 ns | 0.0073 ns | 0.0061 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |   2.2433 ns | 0.0047 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |   2.2424 ns | 0.0036 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |   2.1142 ns | 0.0189 ns | 0.0176 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |   2.2674 ns | 0.0031 ns | 0.0029 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |   2.2475 ns | 0.0056 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 373.8468 ns | 0.4716 ns | 0.4181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 313.8150 ns | 0.5600 ns | 0.5238 ns |  0.84 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 289.7851 ns | 0.5967 ns | 0.5290 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 650.7135 ns | 1.1012 ns | 1.0301 ns |  1.74 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 641.0515 ns | 1.0222 ns | 0.9562 ns |  1.71 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |   0.9506 ns | 0.0032 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |   0.7237 ns | 0.0031 ns | 0.0029 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |   0.6907 ns | 0.0039 ns | 0.0037 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |   0.7260 ns | 0.0026 ns | 0.0023 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |   0.7220 ns | 0.0024 ns | 0.0022 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |             |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |   0.9502 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |   1.0657 ns | 0.0035 ns | 0.0033 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |   0.8695 ns | 0.0034 ns | 0.0032 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |   0.7194 ns | 0.0024 ns | 0.0023 ns |  0.76 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |   0.7230 ns | 0.0027 ns | 0.0026 ns |  0.76 |    0.00 |     - |     - |     - |         - |
