
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 3.752 ns | 0.0355 ns | 0.0332 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 2.2 | 4.750 ns | 0.0202 ns | 0.0179 ns |  1.27 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 3.0 | 4.339 ns | 0.0307 ns | 0.0287 ns |  1.16 |    0.02 | 0.0038 |     - |     - |      24 B |
             FromBool |        net461 | 4.189 ns | 0.0348 ns | 0.0325 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool |        net472 | 3.799 ns | 0.0381 ns | 0.0356 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 1.246 ns | 0.0138 ns | 0.0130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 1.149 ns | 0.0038 ns | 0.0034 ns |  0.92 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 1.111 ns | 0.0106 ns | 0.0099 ns |  0.89 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net461 | 1.163 ns | 0.0055 ns | 0.0048 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net472 | 1.118 ns | 0.0039 ns | 0.0036 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 | 3.911 ns | 0.0400 ns | 0.0334 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 2.2 | 4.316 ns | 0.0472 ns | 0.0419 ns |  1.10 |    0.02 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 3.0 | 4.351 ns | 0.0257 ns | 0.0240 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 | 3.909 ns | 0.0204 ns | 0.0181 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net472 | 3.803 ns | 0.0318 ns | 0.0298 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 | 1.263 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 1.303 ns | 0.0049 ns | 0.0044 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 1.340 ns | 0.0036 ns | 0.0032 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net461 | 1.307 ns | 0.0058 ns | 0.0048 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net472 | 1.268 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 | 3.773 ns | 0.0342 ns | 0.0304 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 2.2 | 4.298 ns | 0.0169 ns | 0.0150 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 3.0 | 4.386 ns | 0.0164 ns | 0.0145 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte |        net461 | 3.981 ns | 0.0267 ns | 0.0236 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte |        net472 | 3.899 ns | 0.0446 ns | 0.0395 ns |  1.03 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.229 ns | 0.0034 ns | 0.0028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.200 ns | 0.0068 ns | 0.0057 ns |  0.98 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 1.106 ns | 0.0086 ns | 0.0081 ns |  0.90 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable |        net461 | 1.163 ns | 0.0164 ns | 0.0153 ns |  0.95 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.119 ns | 0.0046 ns | 0.0041 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 | 3.738 ns | 0.0301 ns | 0.0281 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 2.2 | 4.335 ns | 0.0298 ns | 0.0278 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 3.0 | 4.884 ns | 0.0366 ns | 0.0342 ns |  1.31 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte |        net461 | 4.004 ns | 0.0118 ns | 0.0099 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte |        net472 | 3.766 ns | 0.0153 ns | 0.0136 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.235 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 1.164 ns | 0.0097 ns | 0.0091 ns |  0.94 |    0.01 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 1.092 ns | 0.0045 ns | 0.0038 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net461 | 1.168 ns | 0.0214 ns | 0.0200 ns |  0.95 |    0.02 |      - |     - |     - |         - |
     FromByteNullable |        net472 | 1.120 ns | 0.0050 ns | 0.0042 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 | 3.720 ns | 0.0104 ns | 0.0092 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 2.2 | 4.278 ns | 0.0150 ns | 0.0133 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 3.0 | 4.342 ns | 0.0318 ns | 0.0298 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromShort |        net461 | 3.963 ns | 0.0189 ns | 0.0168 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromShort |        net472 | 3.840 ns | 0.0174 ns | 0.0162 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.265 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.298 ns | 0.0041 ns | 0.0035 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.340 ns | 0.0052 ns | 0.0043 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net461 | 1.306 ns | 0.0050 ns | 0.0046 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net472 | 1.270 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 | 3.749 ns | 0.0109 ns | 0.0091 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 2.2 | 4.284 ns | 0.0079 ns | 0.0066 ns |  1.14 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 3.0 | 4.370 ns | 0.0407 ns | 0.0381 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromUShort |        net461 | 4.236 ns | 0.0154 ns | 0.0120 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromUShort |        net472 | 4.036 ns | 0.0149 ns | 0.0140 ns |  1.08 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.266 ns | 0.0029 ns | 0.0025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.320 ns | 0.0108 ns | 0.0101 ns |  1.04 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.338 ns | 0.0037 ns | 0.0030 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.303 ns | 0.0039 ns | 0.0036 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.270 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 | 4.008 ns | 0.0182 ns | 0.0162 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 2.2 | 4.425 ns | 0.0154 ns | 0.0129 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 3.0 | 4.353 ns | 0.0231 ns | 0.0204 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt |        net461 | 4.222 ns | 0.0360 ns | 0.0336 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt |        net472 | 4.059 ns | 0.0092 ns | 0.0072 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 | 1.278 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.302 ns | 0.0051 ns | 0.0045 ns |  1.02 |    0.01 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.341 ns | 0.0041 ns | 0.0038 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net461 | 1.294 ns | 0.0046 ns | 0.0043 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net472 | 1.271 ns | 0.0040 ns | 0.0035 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 | 3.737 ns | 0.0412 ns | 0.0385 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 2.2 | 4.473 ns | 0.0492 ns | 0.0460 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 3.0 | 4.712 ns | 0.0333 ns | 0.0296 ns |  1.26 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt |        net461 | 4.336 ns | 0.0236 ns | 0.0210 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt |        net472 | 4.167 ns | 0.0106 ns | 0.0089 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.262 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.318 ns | 0.0132 ns | 0.0123 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 1.343 ns | 0.0099 ns | 0.0092 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net461 | 1.322 ns | 0.0137 ns | 0.0128 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net472 | 1.302 ns | 0.0151 ns | 0.0141 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 | 3.721 ns | 0.0137 ns | 0.0121 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 2.2 | 4.400 ns | 0.0174 ns | 0.0145 ns |  1.18 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 3.0 | 4.335 ns | 0.0333 ns | 0.0311 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromLong |        net461 | 4.152 ns | 0.0206 ns | 0.0172 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong |        net472 | 4.114 ns | 0.0144 ns | 0.0120 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.721 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.926 ns | 0.0549 ns | 0.0514 ns |  1.12 |    0.03 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.689 ns | 0.0034 ns | 0.0030 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net461 | 1.533 ns | 0.0167 ns | 0.0156 ns |  0.89 |    0.01 |      - |     - |     - |         - |
     FromLongNullable |        net472 | 1.557 ns | 0.0052 ns | 0.0043 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 | 3.950 ns | 0.0176 ns | 0.0156 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 2.2 | 5.115 ns | 0.0128 ns | 0.0120 ns |  1.30 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 3.0 | 4.346 ns | 0.0256 ns | 0.0239 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromULong |        net461 | 4.207 ns | 0.0210 ns | 0.0186 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromULong |        net472 | 4.178 ns | 0.0215 ns | 0.0201 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 | 1.511 ns | 0.0054 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.764 ns | 0.0042 ns | 0.0039 ns |  1.17 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.594 ns | 0.0099 ns | 0.0092 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    FromULongNullable |        net461 | 1.497 ns | 0.0156 ns | 0.0146 ns |  0.99 |    0.01 |      - |     - |     - |         - |
    FromULongNullable |        net472 | 1.710 ns | 0.0045 ns | 0.0040 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 | 3.924 ns | 0.0283 ns | 0.0250 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 2.2 | 4.836 ns | 0.0152 ns | 0.0127 ns |  1.23 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 3.0 | 4.563 ns | 0.0329 ns | 0.0308 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 | 4.177 ns | 0.0236 ns | 0.0209 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net472 | 4.215 ns | 0.0173 ns | 0.0162 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 1.283 ns | 0.0024 ns | 0.0021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 1.278 ns | 0.0065 ns | 0.0057 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 1.494 ns | 0.0428 ns | 0.0379 ns |  1.17 |    0.03 |      - |     - |     - |         - |
    FromFloatNullable |        net461 | 1.276 ns | 0.0038 ns | 0.0031 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net472 | 1.268 ns | 0.0024 ns | 0.0021 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 3.888 ns | 0.0178 ns | 0.0166 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 2.2 | 4.428 ns | 0.0133 ns | 0.0111 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 3.0 | 4.732 ns | 0.0251 ns | 0.0210 ns |  1.22 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 4.256 ns | 0.0324 ns | 0.0303 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net472 | 4.305 ns | 0.0435 ns | 0.0407 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.571 ns | 0.0050 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.851 ns | 0.0041 ns | 0.0037 ns |  1.18 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 2.132 ns | 0.0109 ns | 0.0102 ns |  1.36 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.604 ns | 0.0151 ns | 0.0134 ns |  1.02 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.628 ns | 0.0045 ns | 0.0042 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 | 5.107 ns | 0.0110 ns | 0.0098 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 | 5.653 ns | 0.0141 ns | 0.0118 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 | 5.731 ns | 0.0144 ns | 0.0135 ns |  1.12 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net461 | 5.103 ns | 0.0444 ns | 0.0416 ns |  1.00 |    0.01 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 | 5.108 ns | 0.0085 ns | 0.0067 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |          |           |           |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 1.650 ns | 0.0097 ns | 0.0086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 1.649 ns | 0.0031 ns | 0.0026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 1.713 ns | 0.0051 ns | 0.0046 ns |  1.04 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable |        net461 | 1.661 ns | 0.0034 ns | 0.0032 ns |  1.01 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable |        net472 | 1.679 ns | 0.0052 ns | 0.0048 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 3.715 ns | 0.0127 ns | 0.0112 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 2.2 | 4.466 ns | 0.0356 ns | 0.0333 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 3.0 | 4.360 ns | 0.0248 ns | 0.0232 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime |        net461 | 4.080 ns | 0.0397 ns | 0.0371 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime |        net472 | 4.042 ns | 0.0224 ns | 0.0210 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.538 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 2.792 ns | 0.0499 ns | 0.0466 ns |  1.82 |    0.03 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.665 ns | 0.0176 ns | 0.0164 ns |  1.08 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.704 ns | 0.0047 ns | 0.0044 ns |  1.11 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.805 ns | 0.0234 ns | 0.0219 ns |  1.17 |    0.02 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 | 1.611 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 1.737 ns | 0.0055 ns | 0.0049 ns |  1.08 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 1.537 ns | 0.0083 ns | 0.0078 ns |  0.95 |    0.01 |      - |     - |     - |         - |
           FromObject |        net461 | 1.896 ns | 0.0032 ns | 0.0029 ns |  1.18 |    0.00 |      - |     - |     - |         - |
           FromObject |        net472 | 1.896 ns | 0.0053 ns | 0.0050 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
           FromString | .NET Core 2.0 | 2.989 ns | 0.0087 ns | 0.0081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 | 1.876 ns | 0.0064 ns | 0.0059 ns |  0.63 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.672 ns | 0.0079 ns | 0.0073 ns |  0.56 |    0.00 |      - |     - |     - |         - |
           FromString |        net461 | 3.425 ns | 0.0117 ns | 0.0092 ns |  1.15 |    0.00 |      - |     - |     - |         - |
           FromString |        net472 | 3.425 ns | 0.0094 ns | 0.0088 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 | 3.771 ns | 0.0185 ns | 0.0173 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 2.2 | 4.447 ns | 0.0140 ns | 0.0117 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 3.0 | 4.405 ns | 0.0274 ns | 0.0257 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net461 | 4.198 ns | 0.0235 ns | 0.0220 ns |  1.11 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net472 | 4.191 ns | 0.0140 ns | 0.0124 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 4.088 ns | 0.0195 ns | 0.0173 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
     FromEnumNullable | .NET Core 2.2 | 4.814 ns | 0.0204 ns | 0.0191 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
     FromEnumNullable | .NET Core 3.0 | 4.622 ns | 0.0343 ns | 0.0321 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
     FromEnumNullable |        net461 | 4.686 ns | 0.0253 ns | 0.0211 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
     FromEnumNullable |        net472 | 4.624 ns | 0.0149 ns | 0.0125 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
