
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
             FromBool | .NET Core 2.0 |  0.7196 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.7043 ns | 0.0019 ns | 0.0017 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7077 ns | 0.0033 ns | 0.0029 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.7055 ns | 0.0022 ns | 0.0021 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.7012 ns | 0.0019 ns | 0.0017 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.7184 ns | 0.0033 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1304 ns | 0.0018 ns | 0.0016 ns |  1.57 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.7480 ns | 0.0043 ns | 0.0034 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  0.9371 ns | 0.0042 ns | 0.0039 ns |  1.30 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  0.9292 ns | 0.0027 ns | 0.0024 ns |  1.29 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9515 ns | 0.0031 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.9294 ns | 0.0045 ns | 0.0042 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.9241 ns | 0.0042 ns | 0.0037 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.9508 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.9288 ns | 0.0037 ns | 0.0029 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.7186 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.7271 ns | 0.0024 ns | 0.0021 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.6881 ns | 0.0032 ns | 0.0030 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.7210 ns | 0.0024 ns | 0.0023 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.7229 ns | 0.0017 ns | 0.0016 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3180 ns | 0.0020 ns | 0.0019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.4167 ns | 0.0031 ns | 0.0027 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7263 ns | 0.0071 ns | 0.0063 ns |  0.55 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.8858 ns | 0.0026 ns | 0.0025 ns |  1.43 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.8848 ns | 0.0018 ns | 0.0017 ns |  1.43 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.8585 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8230 ns | 0.0069 ns | 0.0061 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9833 ns | 0.0031 ns | 0.0024 ns |  0.53 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  3.1229 ns | 0.0070 ns | 0.0062 ns |  1.68 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  3.2198 ns | 0.0051 ns | 0.0045 ns |  1.73 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  1.3915 ns | 0.0543 ns | 0.0846 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7196 ns | 0.0042 ns | 0.0037 ns |  0.52 |    0.04 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.9426 ns | 0.0455 ns | 0.1175 ns |  0.67 |    0.12 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7342 ns | 0.0275 ns | 0.0257 ns |  0.53 |    0.05 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7119 ns | 0.0026 ns | 0.0021 ns |  0.52 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9934 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9469 ns | 0.0036 ns | 0.0032 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9699 ns | 0.0088 ns | 0.0073 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.2097 ns | 0.0105 ns | 0.0093 ns |  2.22 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.0026 ns | 0.0032 ns | 0.0030 ns |  2.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.2871 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  2.1256 ns | 0.0029 ns | 0.0026 ns |  1.65 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6324 ns | 0.0016 ns | 0.0014 ns |  0.49 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7352 ns | 0.0027 ns | 0.0022 ns |  1.35 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8612 ns | 0.0023 ns | 0.0021 ns |  1.45 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.9585 ns | 0.0025 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7921 ns | 0.0027 ns | 0.0022 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1195 ns | 0.0030 ns | 0.0028 ns |  0.57 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.7994 ns | 0.0076 ns | 0.0071 ns |  1.43 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  3.0826 ns | 0.0063 ns | 0.0056 ns |  1.57 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6719 ns | 0.0088 ns | 0.0082 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7055 ns | 0.0025 ns | 0.0022 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6026 ns | 0.0072 ns | 0.0068 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7242 ns | 0.0020 ns | 0.0018 ns |  1.08 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.5194 ns | 0.0551 ns | 0.0656 ns |  2.29 |    0.10 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0336 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1036 ns | 0.0018 ns | 0.0017 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1113 ns | 0.0039 ns | 0.0034 ns |  1.08 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0198 ns | 0.0059 ns | 0.0052 ns |  1.95 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.2201 ns | 0.0030 ns | 0.0028 ns |  2.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7649 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.9177 ns | 0.0165 ns | 0.0154 ns |  1.09 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.7001 ns | 0.0025 ns | 0.0022 ns |  0.96 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7657 ns | 0.0045 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7631 ns | 0.0040 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.5805 ns | 0.0075 ns | 0.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.6307 ns | 0.0140 ns | 0.0131 ns |  1.02 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.2298 ns | 0.0015 ns | 0.0014 ns |  0.86 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.9001 ns | 0.0140 ns | 0.0131 ns |  1.12 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.8447 ns | 0.0068 ns | 0.0060 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4445 ns | 0.0028 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4236 ns | 0.0050 ns | 0.0047 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7127 ns | 0.0022 ns | 0.0018 ns |  0.49 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.8273 ns | 0.0034 ns | 0.0031 ns |  1.26 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8660 ns | 0.0060 ns | 0.0053 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0541 ns | 0.0140 ns | 0.0131 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9317 ns | 0.0053 ns | 0.0049 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0663 ns | 0.0125 ns | 0.0117 ns |  0.52 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.8806 ns | 0.0069 ns | 0.0064 ns |  1.40 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.7843 ns | 0.0110 ns | 0.0103 ns |  1.36 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8170 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8487 ns | 0.0037 ns | 0.0031 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.8263 ns | 0.0027 ns | 0.0024 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7432 ns | 0.0086 ns | 0.0081 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7651 ns | 0.0037 ns | 0.0033 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.9194 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.1228 ns | 0.0056 ns | 0.0052 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.1015 ns | 0.0057 ns | 0.0054 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.1335 ns | 0.0063 ns | 0.0059 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.4454 ns | 0.0114 ns | 0.0107 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.7948 ns | 0.0035 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.9129 ns | 0.0072 ns | 0.0067 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.9576 ns | 0.0030 ns | 0.0026 ns |  1.09 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7589 ns | 0.0039 ns | 0.0036 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8043 ns | 0.0027 ns | 0.0024 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  3.0687 ns | 0.0070 ns | 0.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.0210 ns | 0.0070 ns | 0.0066 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.7190 ns | 0.0042 ns | 0.0035 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.2610 ns | 0.0060 ns | 0.0053 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0219 ns | 0.0054 ns | 0.0048 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.5242 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.9472 ns | 0.0040 ns | 0.0033 ns |  1.81 |    0.03 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.7155 ns | 0.0025 ns | 0.0023 ns |  1.37 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.6917 ns | 0.0034 ns | 0.0026 ns |  1.32 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.7079 ns | 0.0040 ns | 0.0036 ns |  1.35 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  0.6031 ns | 0.0026 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.1275 ns | 0.0022 ns | 0.0019 ns |  1.87 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.8773 ns | 0.0037 ns | 0.0033 ns |  1.46 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  0.9813 ns | 0.0036 ns | 0.0030 ns |  1.63 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.0032 ns | 0.0024 ns | 0.0020 ns |  1.66 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.7194 ns | 0.0022 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.9478 ns | 0.0069 ns | 0.0061 ns |  1.32 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.9246 ns | 0.0079 ns | 0.0074 ns |  1.29 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.6537 ns | 0.0025 ns | 0.0022 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.7113 ns | 0.0030 ns | 0.0029 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.2547 ns | 0.0021 ns | 0.0017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.1612 ns | 0.0030 ns | 0.0027 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.1557 ns | 0.0026 ns | 0.0021 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  1.1398 ns | 0.0028 ns | 0.0025 ns |  0.91 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  1.1590 ns | 0.0038 ns | 0.0034 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  1.2250 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  1.1617 ns | 0.0054 ns | 0.0051 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  1.1366 ns | 0.0040 ns | 0.0037 ns |  0.93 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  1.1690 ns | 0.0074 ns | 0.0066 ns |  0.95 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 |  1.1315 ns | 0.0034 ns | 0.0030 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  1.2956 ns | 0.0113 ns | 0.0106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  1.1463 ns | 0.0111 ns | 0.0099 ns |  0.89 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  1.3639 ns | 0.0128 ns | 0.0120 ns |  1.05 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  1.6155 ns | 0.0029 ns | 0.0027 ns |  1.25 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  1.3449 ns | 0.0031 ns | 0.0028 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6667 ns | 0.0019 ns | 0.0018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7433 ns | 0.0028 ns | 0.0027 ns |  1.11 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.8870 ns | 0.0086 ns | 0.0081 ns |  1.33 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9671 ns | 0.0490 ns | 0.1445 ns |  1.40 |    0.22 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7297 ns | 0.0026 ns | 0.0023 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4780 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6506 ns | 0.0041 ns | 0.0038 ns |  1.12 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4559 ns | 0.0082 ns | 0.0077 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6350 ns | 0.0030 ns | 0.0026 ns |  1.11 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6340 ns | 0.0029 ns | 0.0026 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.8956 ns | 0.0144 ns | 0.0127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.8048 ns | 0.0163 ns | 0.0145 ns |  1.50 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.8574 ns | 0.0803 ns | 0.0671 ns |  1.50 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.3754 ns | 0.0179 ns | 0.0168 ns |  1.35 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.4109 ns | 0.0347 ns | 0.0308 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  3.0642 ns | 0.0057 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  3.0238 ns | 0.0065 ns | 0.0051 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  2.9047 ns | 0.0034 ns | 0.0031 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  3.1310 ns | 0.0050 ns | 0.0044 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  3.1546 ns | 0.0067 ns | 0.0063 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8320 ns | 0.0117 ns | 0.0109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8747 ns | 0.0065 ns | 0.0061 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.9661 ns | 0.0049 ns | 0.0046 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7371 ns | 0.0025 ns | 0.0020 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7615 ns | 0.0029 ns | 0.0026 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.5877 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.7599 ns | 0.0064 ns | 0.0060 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2409 ns | 0.0186 ns | 0.0174 ns |  0.87 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.8294 ns | 0.0051 ns | 0.0048 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.8431 ns | 0.0050 ns | 0.0045 ns |  1.10 |    0.00 |     - |     - |     - |         - |
