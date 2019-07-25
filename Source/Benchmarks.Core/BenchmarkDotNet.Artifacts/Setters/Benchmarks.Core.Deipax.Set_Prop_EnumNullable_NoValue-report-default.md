
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
             FromBool | .NET Core 2.0 | 17.1825 ns | 0.0318 ns | 0.0298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 17.3221 ns | 0.0239 ns | 0.0223 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 13.5303 ns | 0.0200 ns | 0.0187 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 | 19.7363 ns | 0.0229 ns | 0.0203 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 19.7120 ns | 0.0375 ns | 0.0351 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  2.0402 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  2.1507 ns | 0.0036 ns | 0.0034 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.9940 ns | 0.0034 ns | 0.0032 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.9425 ns | 0.0130 ns | 0.0116 ns |  1.44 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.2777 ns | 0.0074 ns | 0.0069 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 17.2518 ns | 0.0706 ns | 0.0660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 17.2229 ns | 0.0358 ns | 0.0317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 13.5862 ns | 0.0695 ns | 0.0650 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 | 19.7672 ns | 0.0344 ns | 0.0305 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 | 19.7809 ns | 0.0329 ns | 0.0292 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  2.0532 ns | 0.0135 ns | 0.0126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  2.1585 ns | 0.0045 ns | 0.0037 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.9676 ns | 0.0061 ns | 0.0057 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.6274 ns | 0.0136 ns | 0.0127 ns |  1.28 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.4321 ns | 0.0163 ns | 0.0144 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 17.1778 ns | 0.0305 ns | 0.0286 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 17.1863 ns | 0.0399 ns | 0.0374 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 13.5571 ns | 0.0587 ns | 0.0549 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 19.7683 ns | 0.0349 ns | 0.0309 ns |  1.15 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 | 19.7911 ns | 0.0390 ns | 0.0365 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  2.0428 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  2.1543 ns | 0.0036 ns | 0.0032 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.9825 ns | 0.0038 ns | 0.0036 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.2898 ns | 0.0097 ns | 0.0086 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.3133 ns | 0.0157 ns | 0.0140 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 17.2458 ns | 0.0752 ns | 0.0704 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 17.2419 ns | 0.0259 ns | 0.0242 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 13.4822 ns | 0.0162 ns | 0.0143 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 19.7771 ns | 0.0831 ns | 0.0737 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 | 19.7462 ns | 0.0248 ns | 0.0232 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  2.0521 ns | 0.0125 ns | 0.0111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  2.1530 ns | 0.0044 ns | 0.0041 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.9982 ns | 0.0082 ns | 0.0073 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.2859 ns | 0.0057 ns | 0.0045 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.2856 ns | 0.0166 ns | 0.0147 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 17.1593 ns | 0.0325 ns | 0.0304 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 17.2045 ns | 0.0291 ns | 0.0272 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 13.5293 ns | 0.0256 ns | 0.0239 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 19.9721 ns | 0.0688 ns | 0.0643 ns |  1.16 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 | 19.6873 ns | 0.0358 ns | 0.0317 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.0495 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.1666 ns | 0.0042 ns | 0.0039 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.9451 ns | 0.0062 ns | 0.0058 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.3629 ns | 0.0160 ns | 0.0150 ns |  1.15 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.3463 ns | 0.0045 ns | 0.0040 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 17.1312 ns | 0.0284 ns | 0.0238 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 17.1930 ns | 0.0306 ns | 0.0271 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 13.4939 ns | 0.0241 ns | 0.0226 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 | 19.7338 ns | 0.0583 ns | 0.0545 ns |  1.15 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 19.8398 ns | 0.0328 ns | 0.0307 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  2.0512 ns | 0.0078 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  2.2522 ns | 0.0110 ns | 0.0097 ns |  1.10 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.9455 ns | 0.0058 ns | 0.0054 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.3578 ns | 0.0072 ns | 0.0060 ns |  1.15 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.3501 ns | 0.0101 ns | 0.0085 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 17.1571 ns | 0.0418 ns | 0.0391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 17.0933 ns | 0.0259 ns | 0.0229 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 13.2108 ns | 0.0205 ns | 0.0192 ns |  0.77 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 19.7498 ns | 0.0249 ns | 0.0233 ns |  1.15 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 19.8778 ns | 0.1073 ns | 0.0951 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.0524 ns | 0.0068 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.1918 ns | 0.0047 ns | 0.0042 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.9757 ns | 0.0202 ns | 0.0189 ns |  0.96 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.3584 ns | 0.0095 ns | 0.0089 ns |  1.15 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.3617 ns | 0.0167 ns | 0.0148 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 17.2899 ns | 0.0394 ns | 0.0349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 17.1417 ns | 0.0352 ns | 0.0312 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 13.2503 ns | 0.0160 ns | 0.0150 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 | 19.9109 ns | 0.0813 ns | 0.0679 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 19.8997 ns | 0.0390 ns | 0.0365 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0832 ns | 0.0134 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  2.1824 ns | 0.0153 ns | 0.0136 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.9414 ns | 0.0045 ns | 0.0040 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.3451 ns | 0.0075 ns | 0.0063 ns |  1.13 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.4651 ns | 0.0058 ns | 0.0054 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 17.8847 ns | 0.0325 ns | 0.0254 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 17.4262 ns | 0.0384 ns | 0.0321 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 13.6895 ns | 0.0210 ns | 0.0175 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 20.2067 ns | 0.0444 ns | 0.0416 ns |  1.13 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 20.2066 ns | 0.0355 ns | 0.0332 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.9806 ns | 0.0047 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.1970 ns | 0.0229 ns | 0.0214 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.0605 ns | 0.0044 ns | 0.0041 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.3840 ns | 0.0187 ns | 0.0166 ns |  1.20 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.3599 ns | 0.0064 ns | 0.0057 ns |  1.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 17.7105 ns | 0.0281 ns | 0.0263 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 17.4512 ns | 0.0391 ns | 0.0347 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 13.7799 ns | 0.0163 ns | 0.0127 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 19.9160 ns | 0.0236 ns | 0.0210 ns |  1.12 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 20.1073 ns | 0.1051 ns | 0.0983 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.0040 ns | 0.0075 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.2632 ns | 0.0029 ns | 0.0026 ns |  1.13 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.0527 ns | 0.0548 ns | 0.0512 ns |  1.02 |    0.03 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.3718 ns | 0.0071 ns | 0.0063 ns |  1.18 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.3786 ns | 0.0078 ns | 0.0073 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 19.7288 ns | 0.0450 ns | 0.0399 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 19.3819 ns | 0.0360 ns | 0.0337 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 15.9477 ns | 0.1185 ns | 0.1109 ns |  0.81 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 22.3352 ns | 0.0335 ns | 0.0297 ns |  1.13 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 22.3380 ns | 0.0477 ns | 0.0446 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.9311 ns | 0.0181 ns | 0.0169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.0050 ns | 0.0103 ns | 0.0096 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.9514 ns | 0.0091 ns | 0.0080 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  2.2340 ns | 0.0033 ns | 0.0028 ns |  1.16 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  2.2525 ns | 0.0253 ns | 0.0224 ns |  1.17 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 19.5289 ns | 0.0441 ns | 0.0413 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 19.3694 ns | 0.0240 ns | 0.0213 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 15.8943 ns | 0.0683 ns | 0.0639 ns |  0.81 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 22.5873 ns | 0.0325 ns | 0.0288 ns |  1.16 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 22.3497 ns | 0.0629 ns | 0.0557 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9739 ns | 0.0058 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  2.1548 ns | 0.0151 ns | 0.0142 ns |  1.09 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  2.0369 ns | 0.0105 ns | 0.0082 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.6329 ns | 0.0646 ns | 0.0604 ns |  1.33 |    0.03 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.4116 ns | 0.0155 ns | 0.0137 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 35.2277 ns | 0.1681 ns | 0.1573 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 34.2777 ns | 0.1068 ns | 0.0999 ns |  0.97 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 23.6315 ns | 0.0310 ns | 0.0290 ns |  0.67 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 31.1261 ns | 0.1178 ns | 0.1102 ns |  0.88 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 30.8309 ns | 0.0601 ns | 0.0533 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.7124 ns | 0.0178 ns | 0.0166 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.9843 ns | 0.0815 ns | 0.0762 ns |  1.03 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  8.6246 ns | 0.0200 ns | 0.0177 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.9124 ns | 0.0258 ns | 0.0229 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.7799 ns | 0.0269 ns | 0.0210 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 11.9768 ns | 0.0217 ns | 0.0182 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 11.5443 ns | 0.0163 ns | 0.0153 ns |  0.96 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  7.3234 ns | 0.0135 ns | 0.0126 ns |  0.61 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 14.5357 ns | 0.0575 ns | 0.0538 ns |  1.21 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 | 14.5265 ns | 0.0348 ns | 0.0326 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 10.7156 ns | 0.0141 ns | 0.0118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  8.8312 ns | 0.0194 ns | 0.0182 ns |  0.82 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  2.4095 ns | 0.0189 ns | 0.0177 ns |  0.22 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  8.7770 ns | 0.0122 ns | 0.0096 ns |  0.82 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  8.7505 ns | 0.0230 ns | 0.0192 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.7669 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.9946 ns | 0.0215 ns | 0.0179 ns |  1.08 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.6571 ns | 0.0092 ns | 0.0086 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8552 ns | 0.0074 ns | 0.0058 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.9626 ns | 0.0151 ns | 0.0126 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.7652 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8916 ns | 0.0054 ns | 0.0050 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.6409 ns | 0.0058 ns | 0.0051 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.9274 ns | 0.0120 ns | 0.0107 ns |  1.09 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 |  1.8918 ns | 0.0044 ns | 0.0041 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7205 ns | 0.0069 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7131 ns | 0.0051 ns | 0.0047 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.8658 ns | 0.0054 ns | 0.0050 ns |  1.20 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.9513 ns | 0.0050 ns | 0.0047 ns |  1.32 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.9576 ns | 0.0103 ns | 0.0096 ns |  1.33 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.6910 ns | 0.0118 ns | 0.0111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9459 ns | 0.0035 ns | 0.0031 ns |  1.37 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  0.6323 ns | 0.0053 ns | 0.0044 ns |  0.92 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  0.7311 ns | 0.0048 ns | 0.0045 ns |  1.06 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  0.7275 ns | 0.0045 ns | 0.0040 ns |  1.05 |    0.02 |     - |     - |     - |         - |
