
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
             FromBool | .NET Core 2.0 |  0.9195 ns | 0.0034 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6707 ns | 0.0050 ns | 0.0045 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9003 ns | 0.0036 ns | 0.0032 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9315 ns | 0.0027 ns | 0.0026 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6644 ns | 0.0038 ns | 0.0036 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1591 ns | 0.0063 ns | 0.0056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9285 ns | 0.0120 ns | 0.0112 ns |  0.80 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1314 ns | 0.0032 ns | 0.0030 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9385 ns | 0.0038 ns | 0.0036 ns |  1.67 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9115 ns | 0.0039 ns | 0.0030 ns |  1.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3262 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  2.1082 ns | 0.0043 ns | 0.0034 ns |  1.59 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.8771 ns | 0.0031 ns | 0.0028 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  2.1432 ns | 0.0052 ns | 0.0049 ns |  1.62 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  1.7538 ns | 0.0160 ns | 0.0150 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.8668 ns | 0.0126 ns | 0.0118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7318 ns | 0.0031 ns | 0.0029 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0483 ns | 0.0045 ns | 0.0040 ns |  0.56 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9084 ns | 0.0033 ns | 0.0029 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.8862 ns | 0.0042 ns | 0.0037 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6967 ns | 0.0025 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6679 ns | 0.0031 ns | 0.0026 ns |  0.96 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6653 ns | 0.0080 ns | 0.0075 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7317 ns | 0.0035 ns | 0.0029 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5508 ns | 0.0031 ns | 0.0029 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.6947 ns | 0.0017 ns | 0.0014 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.5336 ns | 0.0028 ns | 0.0026 ns |  0.77 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.8771 ns | 0.0025 ns | 0.0021 ns |  1.26 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  0.7210 ns | 0.0028 ns | 0.0026 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  0.5270 ns | 0.0039 ns | 0.0037 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  1.3198 ns | 0.0017 ns | 0.0015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  1.3562 ns | 0.0021 ns | 0.0018 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.9061 ns | 0.0019 ns | 0.0016 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  1.8904 ns | 0.0031 ns | 0.0029 ns |  1.43 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  1.6797 ns | 0.0045 ns | 0.0037 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.9612 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.7426 ns | 0.0037 ns | 0.0034 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9619 ns | 0.0037 ns | 0.0035 ns |  0.49 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9376 ns | 0.0035 ns | 0.0029 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9120 ns | 0.0027 ns | 0.0024 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.8486 ns | 0.0059 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.8011 ns | 0.0041 ns | 0.0032 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  2.0647 ns | 0.0033 ns | 0.0029 ns |  1.12 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  2.1021 ns | 0.0046 ns | 0.0043 ns |  1.14 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8387 ns | 0.0053 ns | 0.0047 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8409 ns | 0.0051 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7323 ns | 0.0042 ns | 0.0039 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.6913 ns | 0.0051 ns | 0.0046 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9409 ns | 0.0031 ns | 0.0029 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9142 ns | 0.0091 ns | 0.0081 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.3242 ns | 0.0051 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.3328 ns | 0.0032 ns | 0.0030 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6219 ns | 0.0094 ns | 0.0088 ns |  0.47 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.8701 ns | 0.0039 ns | 0.0034 ns |  1.41 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.7427 ns | 0.0047 ns | 0.0041 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.8595 ns | 0.0070 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.7327 ns | 0.0024 ns | 0.0021 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0662 ns | 0.0027 ns | 0.0024 ns |  0.57 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.5000 ns | 0.0038 ns | 0.0036 ns |  1.34 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.8954 ns | 0.0131 ns | 0.0122 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7923 ns | 0.0113 ns | 0.0105 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.7976 ns | 0.0050 ns | 0.0047 ns |  1.00 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.8260 ns | 0.0044 ns | 0.0039 ns |  1.02 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7677 ns | 0.0051 ns | 0.0048 ns |  0.99 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7435 ns | 0.0036 ns | 0.0030 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.8624 ns | 0.0212 ns | 0.0198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.7429 ns | 0.0141 ns | 0.0131 ns |  0.94 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.6829 ns | 0.0044 ns | 0.0042 ns |  0.90 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9105 ns | 0.0085 ns | 0.0071 ns |  1.02 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.8862 ns | 0.0052 ns | 0.0049 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4888 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.3893 ns | 0.0040 ns | 0.0038 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7230 ns | 0.0043 ns | 0.0040 ns |  0.49 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.8738 ns | 0.0060 ns | 0.0054 ns |  1.26 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  2.4263 ns | 0.0752 ns | 0.1518 ns |  1.57 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0988 ns | 0.0047 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9197 ns | 0.0026 ns | 0.0023 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0799 ns | 0.0049 ns | 0.0041 ns |  0.51 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9070 ns | 0.0063 ns | 0.0056 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9181 ns | 0.0157 ns | 0.0147 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8629 ns | 0.0038 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8180 ns | 0.0040 ns | 0.0035 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7069 ns | 0.0046 ns | 0.0043 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7656 ns | 0.0057 ns | 0.0050 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7652 ns | 0.0021 ns | 0.0017 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7393 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7733 ns | 0.0037 ns | 0.0033 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.8333 ns | 0.0078 ns | 0.0069 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.6583 ns | 0.0764 ns | 0.0750 ns |  1.54 |    0.04 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.0941 ns | 0.0095 ns | 0.0085 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4901 ns | 0.0055 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.4127 ns | 0.0101 ns | 0.0090 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7166 ns | 0.0026 ns | 0.0024 ns |  0.48 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.8972 ns | 0.0031 ns | 0.0028 ns |  1.27 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.9769 ns | 0.0027 ns | 0.0024 ns |  1.33 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.1369 ns | 0.0047 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9056 ns | 0.0028 ns | 0.0023 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.6155 ns | 0.0057 ns | 0.0051 ns |  0.76 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9588 ns | 0.0054 ns | 0.0048 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9014 ns | 0.0040 ns | 0.0038 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.7941 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.8603 ns | 0.0074 ns | 0.0062 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.9991 ns | 0.0071 ns | 0.0066 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.0115 ns | 0.0053 ns | 0.0045 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  5.3443 ns | 0.0063 ns | 0.0056 ns |  1.41 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8936 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7704 ns | 0.0041 ns | 0.0037 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7072 ns | 0.0026 ns | 0.0023 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9240 ns | 0.0048 ns | 0.0040 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9184 ns | 0.0034 ns | 0.0030 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.7821 ns | 0.0083 ns | 0.0078 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.9800 ns | 0.0240 ns | 0.0224 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.7487 ns | 0.0108 ns | 0.0101 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4058 ns | 0.0059 ns | 0.0055 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4015 ns | 0.0079 ns | 0.0066 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  2.3078 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  2.3197 ns | 0.0053 ns | 0.0050 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9404 ns | 0.0047 ns | 0.0044 ns |  0.84 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1048 ns | 0.0129 ns | 0.0121 ns |  0.91 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1261 ns | 0.0048 ns | 0.0043 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.8118 ns | 0.0718 ns | 0.0671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.9778 ns | 0.0296 ns | 0.0263 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.0043 ns | 0.1416 ns | 0.1255 ns |  0.51 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.1664 ns | 0.0342 ns | 0.0303 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.2010 ns | 0.0386 ns | 0.0342 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.2952 ns | 0.0470 ns | 0.0440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.6834 ns | 0.0202 ns | 0.0168 ns |  1.05 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5367 ns | 0.0074 ns | 0.0065 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 12.4760 ns | 0.0240 ns | 0.0201 ns |  1.50 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.0418 ns | 0.0094 ns | 0.0088 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9210 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7158 ns | 0.0033 ns | 0.0031 ns |  0.78 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7299 ns | 0.0045 ns | 0.0042 ns |  0.79 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7334 ns | 0.0037 ns | 0.0031 ns |  0.80 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7110 ns | 0.0022 ns | 0.0018 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.7982 ns | 0.0612 ns | 0.0953 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6723 ns | 0.0049 ns | 0.0046 ns |  0.94 |    0.06 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4826 ns | 0.0036 ns | 0.0034 ns |  0.83 |    0.06 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6323 ns | 0.0042 ns | 0.0033 ns |  0.90 |    0.04 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6654 ns | 0.0033 ns | 0.0030 ns |  0.94 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0165 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8583 ns | 0.0020 ns | 0.0016 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7123 ns | 0.0134 ns | 0.0119 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8504 ns | 0.0048 ns | 0.0045 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.9388 ns | 0.0074 ns | 0.0069 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8244 ns | 0.0033 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.9046 ns | 0.0054 ns | 0.0051 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9143 ns | 0.0057 ns | 0.0050 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.8131 ns | 0.0042 ns | 0.0038 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.8145 ns | 0.0047 ns | 0.0044 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8385 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  2.2136 ns | 0.0056 ns | 0.0053 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.6756 ns | 0.0053 ns | 0.0047 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7814 ns | 0.0022 ns | 0.0019 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7654 ns | 0.0028 ns | 0.0023 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8550 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.7704 ns | 0.0146 ns | 0.0137 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.6946 ns | 0.0132 ns | 0.0103 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9093 ns | 0.0022 ns | 0.0020 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9089 ns | 0.0020 ns | 0.0018 ns |  1.03 |    0.01 |     - |     - |     - |         - |
