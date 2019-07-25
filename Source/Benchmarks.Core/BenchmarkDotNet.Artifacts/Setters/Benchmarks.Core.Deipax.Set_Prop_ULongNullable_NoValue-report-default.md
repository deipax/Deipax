
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
             FromBool | .NET Core 2.0 |  0.7197 ns | 0.0081 ns | 0.0072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6760 ns | 0.0036 ns | 0.0028 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9044 ns | 0.0027 ns | 0.0023 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6594 ns | 0.0045 ns | 0.0038 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9482 ns | 0.0049 ns | 0.0043 ns |  1.32 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9538 ns | 0.0040 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1486 ns | 0.0093 ns | 0.0087 ns |  1.20 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.3648 ns | 0.0038 ns | 0.0032 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.8983 ns | 0.0042 ns | 0.0039 ns |  1.99 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9513 ns | 0.0096 ns | 0.0085 ns |  2.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6890 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6473 ns | 0.0058 ns | 0.0054 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6532 ns | 0.0038 ns | 0.0036 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6294 ns | 0.0041 ns | 0.0039 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7426 ns | 0.0035 ns | 0.0033 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9699 ns | 0.0038 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0873 ns | 0.0141 ns | 0.0132 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1331 ns | 0.0073 ns | 0.0068 ns |  1.17 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.8862 ns | 0.0033 ns | 0.0031 ns |  1.94 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.5050 ns | 0.0063 ns | 0.0056 ns |  2.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.2895 ns | 0.0041 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3759 ns | 0.0061 ns | 0.0048 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6931 ns | 0.0033 ns | 0.0028 ns |  0.54 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7418 ns | 0.0052 ns | 0.0043 ns |  1.35 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.9008 ns | 0.0069 ns | 0.0058 ns |  1.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7387 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.7612 ns | 0.0068 ns | 0.0064 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1220 ns | 0.0076 ns | 0.0068 ns |  0.65 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9018 ns | 0.0049 ns | 0.0044 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9603 ns | 0.0131 ns | 0.0110 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7153 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6318 ns | 0.0025 ns | 0.0022 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.8857 ns | 0.0035 ns | 0.0032 ns |  1.24 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6722 ns | 0.0115 ns | 0.0108 ns |  0.94 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 |  0.9674 ns | 0.0065 ns | 0.0061 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9731 ns | 0.0133 ns | 0.0124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9468 ns | 0.0118 ns | 0.0111 ns |  0.97 |    0.02 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9674 ns | 0.0065 ns | 0.0058 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9011 ns | 0.0040 ns | 0.0038 ns |  1.95 |    0.03 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9479 ns | 0.0045 ns | 0.0037 ns |  2.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3752 ns | 0.0026 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.3758 ns | 0.0038 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6886 ns | 0.0026 ns | 0.0024 ns |  0.50 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7483 ns | 0.0072 ns | 0.0067 ns |  1.27 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8945 ns | 0.0036 ns | 0.0030 ns |  1.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8388 ns | 0.0095 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.8960 ns | 0.0058 ns | 0.0054 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0593 ns | 0.0153 ns | 0.0144 ns |  0.58 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.8844 ns | 0.0041 ns | 0.0036 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9287 ns | 0.0058 ns | 0.0051 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9177 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6478 ns | 0.0020 ns | 0.0018 ns |  0.71 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6547 ns | 0.0040 ns | 0.0033 ns |  0.71 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6502 ns | 0.0133 ns | 0.0104 ns |  0.71 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7429 ns | 0.0035 ns | 0.0033 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1999 ns | 0.0030 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0658 ns | 0.0042 ns | 0.0037 ns |  0.89 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1374 ns | 0.0040 ns | 0.0036 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.8919 ns | 0.0043 ns | 0.0038 ns |  1.58 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9541 ns | 0.0114 ns | 0.0107 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.4539 ns | 0.0128 ns | 0.0114 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.4303 ns | 0.0163 ns | 0.0152 ns |  0.98 |    0.02 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.9107 ns | 0.0064 ns | 0.0060 ns |  0.63 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7597 ns | 0.0132 ns | 0.0123 ns |  1.21 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7763 ns | 0.0028 ns | 0.0025 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.9377 ns | 0.0162 ns | 0.0135 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.9087 ns | 0.0062 ns | 0.0055 ns |  0.99 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0586 ns | 0.0118 ns | 0.0110 ns |  0.55 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.8867 ns | 0.0046 ns | 0.0043 ns |  0.97 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9355 ns | 0.0084 ns | 0.0079 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9197 ns | 0.0028 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.5632 ns | 0.0026 ns | 0.0024 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7182 ns | 0.0035 ns | 0.0033 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7398 ns | 0.0062 ns | 0.0055 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6644 ns | 0.0046 ns | 0.0043 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0039 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.0714 ns | 0.0026 ns | 0.0021 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.3890 ns | 0.0518 ns | 0.0509 ns |  1.38 |    0.06 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9128 ns | 0.0066 ns | 0.0059 ns |  1.91 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.2824 ns | 0.0027 ns | 0.0024 ns |  2.27 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.4423 ns | 0.0119 ns | 0.0111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.3526 ns | 0.0080 ns | 0.0071 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.6963 ns | 0.0022 ns | 0.0021 ns |  0.48 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7369 ns | 0.0062 ns | 0.0058 ns |  1.20 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7238 ns | 0.0047 ns | 0.0041 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.9249 ns | 0.0065 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.9673 ns | 0.0060 ns | 0.0057 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.4244 ns | 0.0070 ns | 0.0062 ns |  0.74 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.9596 ns | 0.0145 ns | 0.0129 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.8730 ns | 0.0057 ns | 0.0050 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9229 ns | 0.0098 ns | 0.0092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.6409 ns | 0.0036 ns | 0.0030 ns |  0.70 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.6732 ns | 0.0031 ns | 0.0029 ns |  0.73 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.6973 ns | 0.0030 ns | 0.0028 ns |  0.76 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  0.6703 ns | 0.0049 ns | 0.0046 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.1466 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.3285 ns | 0.0185 ns | 0.0173 ns |  1.16 |    0.02 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.1494 ns | 0.0043 ns | 0.0040 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.4230 ns | 0.0191 ns | 0.0178 ns |  1.24 |    0.02 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.3855 ns | 0.0098 ns | 0.0087 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.2218 ns | 0.0081 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.3468 ns | 0.0065 ns | 0.0058 ns |  0.73 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  2.1748 ns | 0.0034 ns | 0.0032 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.5048 ns | 0.0071 ns | 0.0063 ns |  1.09 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4642 ns | 0.0081 ns | 0.0068 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8875 ns | 0.0106 ns | 0.0094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7500 ns | 0.0051 ns | 0.0046 ns |  0.93 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7512 ns | 0.0093 ns | 0.0087 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9142 ns | 0.0057 ns | 0.0048 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.8970 ns | 0.0036 ns | 0.0030 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  6.0915 ns | 0.0360 ns | 0.0336 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.0710 ns | 0.0039 ns | 0.0034 ns |  0.34 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.8959 ns | 0.0039 ns | 0.0035 ns |  0.31 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4938 ns | 0.0062 ns | 0.0055 ns |  0.57 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4649 ns | 0.0115 ns | 0.0107 ns |  0.57 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  2.0046 ns | 0.0024 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9128 ns | 0.0050 ns | 0.0047 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  2.0048 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1395 ns | 0.0204 ns | 0.0191 ns |  1.07 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.0831 ns | 0.0044 ns | 0.0037 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.8591 ns | 0.0209 ns | 0.0196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1641 ns | 0.0153 ns | 0.0127 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6799 ns | 0.0121 ns | 0.0113 ns |  0.44 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.4926 ns | 0.0578 ns | 0.0541 ns |  1.05 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.4723 ns | 0.0193 ns | 0.0171 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.2168 ns | 0.0212 ns | 0.0198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.9743 ns | 0.0264 ns | 0.0234 ns |  1.09 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5582 ns | 0.0187 ns | 0.0175 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.1828 ns | 0.0637 ns | 0.0565 ns |  1.12 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.1719 ns | 0.0214 ns | 0.0200 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6898 ns | 0.0034 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6799 ns | 0.0040 ns | 0.0038 ns |  0.99 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7167 ns | 0.0030 ns | 0.0026 ns |  1.04 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7075 ns | 0.0045 ns | 0.0037 ns |  1.03 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  1.4354 ns | 0.0031 ns | 0.0029 ns |  2.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4964 ns | 0.0161 ns | 0.0142 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6623 ns | 0.0073 ns | 0.0061 ns |  1.11 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4668 ns | 0.0067 ns | 0.0059 ns |  0.98 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6856 ns | 0.0280 ns | 0.0262 ns |  1.13 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6351 ns | 0.0060 ns | 0.0050 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0646 ns | 0.0102 ns | 0.0091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8494 ns | 0.0063 ns | 0.0056 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.6643 ns | 0.0063 ns | 0.0059 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8798 ns | 0.0080 ns | 0.0075 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8679 ns | 0.0082 ns | 0.0077 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.7953 ns | 0.0042 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8698 ns | 0.0049 ns | 0.0043 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.8650 ns | 0.0039 ns | 0.0035 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.8422 ns | 0.0116 ns | 0.0108 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.7950 ns | 0.0066 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.4525 ns | 0.0109 ns | 0.0102 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.3917 ns | 0.0032 ns | 0.0028 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7244 ns | 0.0095 ns | 0.0084 ns |  0.50 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7658 ns | 0.0044 ns | 0.0041 ns |  1.22 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7613 ns | 0.0177 ns | 0.0166 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.9249 ns | 0.0136 ns | 0.0120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.9114 ns | 0.0059 ns | 0.0052 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0535 ns | 0.0026 ns | 0.0022 ns |  0.55 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9098 ns | 0.0064 ns | 0.0054 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9361 ns | 0.0141 ns | 0.0132 ns |  1.01 |    0.01 |     - |     - |     - |         - |
