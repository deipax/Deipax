
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-UEIOLC : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-AUDEBQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-DSDLWP : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-CMETFP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-MAJXYB : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9594 ns | 0.0095 ns | 0.0074 ns |  0.9606 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6564 ns | 0.0031 ns | 0.0029 ns |  0.6557 ns |  0.68 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.3593 ns | 0.0127 ns | 0.0113 ns |  1.3640 ns |  1.42 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6597 ns | 0.0031 ns | 0.0029 ns |  0.6598 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9331 ns | 0.0040 ns | 0.0031 ns |  0.9330 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4253 ns | 0.0040 ns | 0.0033 ns |  1.4260 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1893 ns | 0.0207 ns | 0.0193 ns |  1.1987 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9666 ns | 0.0039 ns | 0.0034 ns |  0.9655 ns |  0.68 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.6447 ns | 0.0047 ns | 0.0044 ns |  2.6446 ns |  1.86 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1758 ns | 0.0044 ns | 0.0039 ns |  2.1759 ns |  1.53 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3356 ns | 0.0475 ns | 0.0421 ns |  1.3257 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.3587 ns | 0.0034 ns | 0.0031 ns |  1.3588 ns |  1.02 |    0.03 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6160 ns | 0.0024 ns | 0.0023 ns |  0.6158 ns |  0.46 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7369 ns | 0.0024 ns | 0.0021 ns |  1.7373 ns |  1.30 |    0.04 |     - |     - |     - |         - |
             FromChar |        net472 |  1.7982 ns | 0.0024 ns | 0.0023 ns |  1.7984 ns |  1.35 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  2.1098 ns | 0.0378 ns | 0.0353 ns |  2.1019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7494 ns | 0.0029 ns | 0.0024 ns |  1.7489 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1059 ns | 0.0077 ns | 0.0072 ns |  1.1072 ns |  0.52 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.7088 ns | 0.0054 ns | 0.0051 ns |  2.7067 ns |  1.28 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.7454 ns | 0.0068 ns | 0.0064 ns |  2.7446 ns |  1.30 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.2948 ns | 0.0138 ns | 0.0123 ns |  1.2905 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3912 ns | 0.0100 ns | 0.0093 ns |  1.3940 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7112 ns | 0.0018 ns | 0.0016 ns |  0.7110 ns |  0.55 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7325 ns | 0.0058 ns | 0.0054 ns |  1.7347 ns |  1.34 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7603 ns | 0.0024 ns | 0.0020 ns |  1.7609 ns |  1.36 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.8498 ns | 0.0094 ns | 0.0078 ns |  1.8487 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  2.0150 ns | 0.0040 ns | 0.0033 ns |  2.0146 ns |  1.09 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9754 ns | 0.0019 ns | 0.0015 ns |  0.9759 ns |  0.53 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.8359 ns | 0.0054 ns | 0.0050 ns |  2.8353 ns |  1.53 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.8569 ns | 0.0054 ns | 0.0051 ns |  2.8589 ns |  1.54 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7249 ns | 0.0049 ns | 0.0043 ns |  0.7249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5454 ns | 0.0025 ns | 0.0024 ns |  0.5453 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5508 ns | 0.0112 ns | 0.0104 ns |  0.5557 ns |  0.76 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5396 ns | 0.0045 ns | 0.0040 ns |  0.5380 ns |  0.74 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7074 ns | 0.0022 ns | 0.0021 ns |  0.7079 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.7254 ns | 0.0312 ns | 0.0277 ns |  0.7203 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.5470 ns | 0.0030 ns | 0.0028 ns |  0.5459 ns |  0.76 |    0.03 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.6892 ns | 0.0023 ns | 0.0021 ns |  0.6892 ns |  0.95 |    0.03 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  0.5506 ns | 0.0037 ns | 0.0033 ns |  0.5497 ns |  0.76 |    0.03 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  0.7037 ns | 0.0032 ns | 0.0030 ns |  0.7035 ns |  0.97 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.8307 ns | 0.0054 ns | 0.0050 ns |  1.8304 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.8227 ns | 0.0022 ns | 0.0020 ns |  1.8225 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  1.8311 ns | 0.0027 ns | 0.0026 ns |  1.8316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7895 ns | 0.0036 ns | 0.0033 ns |  1.7895 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8742 ns | 0.0029 ns | 0.0026 ns |  1.8742 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.6072 ns | 0.0143 ns | 0.0134 ns |  2.6013 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.7398 ns | 0.0241 ns | 0.0201 ns |  2.7431 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  2.1286 ns | 0.0037 ns | 0.0035 ns |  2.1282 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.8300 ns | 0.0161 ns | 0.0150 ns |  2.8334 ns |  1.09 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.8641 ns | 0.0067 ns | 0.0063 ns |  2.8616 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.3681 ns | 0.0402 ns | 0.0336 ns |  1.3590 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.3563 ns | 0.0017 ns | 0.0015 ns |  1.3567 ns |  0.99 |    0.02 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6911 ns | 0.0033 ns | 0.0031 ns |  0.6919 ns |  0.51 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.7601 ns | 0.0059 ns | 0.0050 ns |  1.7599 ns |  1.29 |    0.03 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.7812 ns | 0.0024 ns | 0.0021 ns |  1.7808 ns |  1.30 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.9342 ns | 0.0108 ns | 0.0101 ns |  1.9342 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.7765 ns | 0.0207 ns | 0.0173 ns |  1.7830 ns |  0.92 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0676 ns | 0.0037 ns | 0.0029 ns |  1.0680 ns |  0.55 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.8526 ns | 0.0056 ns | 0.0053 ns |  2.8530 ns |  1.47 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  3.0173 ns | 0.0058 ns | 0.0051 ns |  3.0161 ns |  1.56 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8287 ns | 0.0626 ns | 0.0696 ns |  1.8338 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  2.0969 ns | 0.0311 ns | 0.0291 ns |  2.1098 ns |  1.14 |    0.05 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6744 ns | 0.0047 ns | 0.0044 ns |  1.6730 ns |  0.91 |    0.04 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7054 ns | 0.0022 ns | 0.0020 ns |  1.7046 ns |  0.93 |    0.04 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7303 ns | 0.0036 ns | 0.0032 ns |  1.7314 ns |  0.94 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.9314 ns | 0.0176 ns | 0.0156 ns |  2.9284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.8101 ns | 0.0044 ns | 0.0041 ns |  2.8102 ns |  0.96 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.0868 ns | 0.0043 ns | 0.0040 ns |  2.0863 ns |  0.71 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.6885 ns | 0.0060 ns | 0.0053 ns |  2.6899 ns |  0.92 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.7594 ns | 0.0108 ns | 0.0101 ns |  2.7622 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4700 ns | 0.0131 ns | 0.0109 ns |  1.4665 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4106 ns | 0.0031 ns | 0.0028 ns |  1.4106 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9358 ns | 0.0028 ns | 0.0026 ns |  0.9359 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7360 ns | 0.0035 ns | 0.0031 ns |  1.7370 ns |  1.18 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7425 ns | 0.0123 ns | 0.0115 ns |  1.7396 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.7009 ns | 0.0197 ns | 0.0175 ns |  2.6955 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  2.4035 ns | 0.0053 ns | 0.0049 ns |  2.4031 ns |  0.89 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1651 ns | 0.0015 ns | 0.0013 ns |  1.1652 ns |  0.43 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.6278 ns | 0.0054 ns | 0.0051 ns |  2.6250 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.6270 ns | 0.0087 ns | 0.0082 ns |  2.6243 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8375 ns | 0.0090 ns | 0.0075 ns |  1.8387 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8092 ns | 0.0042 ns | 0.0039 ns |  1.8074 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7020 ns | 0.0021 ns | 0.0018 ns |  1.7018 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  2.5171 ns | 0.0077 ns | 0.0064 ns |  2.5172 ns |  1.37 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7056 ns | 0.0024 ns | 0.0019 ns |  1.7061 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.8086 ns | 0.0296 ns | 0.0277 ns |  2.7971 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.9431 ns | 0.0198 ns | 0.0185 ns |  2.9473 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.8412 ns | 0.0246 ns | 0.0230 ns |  2.8499 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.0630 ns | 0.0109 ns | 0.0102 ns |  3.0596 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.2820 ns | 0.0078 ns | 0.0070 ns |  3.2814 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  2.0196 ns | 0.0656 ns | 0.0729 ns |  1.9975 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7026 ns | 0.0034 ns | 0.0032 ns |  1.7029 ns |  0.84 |    0.03 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6387 ns | 0.0027 ns | 0.0024 ns |  1.6380 ns |  0.81 |    0.03 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7345 ns | 0.0042 ns | 0.0037 ns |  1.7338 ns |  0.86 |    0.03 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7269 ns | 0.0049 ns | 0.0041 ns |  1.7273 ns |  0.86 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  3.0778 ns | 0.0163 ns | 0.0152 ns |  3.0731 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.8249 ns | 0.0230 ns | 0.0192 ns |  2.8321 ns |  0.92 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.9096 ns | 0.0062 ns | 0.0058 ns |  2.9116 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.9289 ns | 0.0051 ns | 0.0046 ns |  2.9284 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.8992 ns | 0.0040 ns | 0.0038 ns |  2.8996 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.8952 ns | 0.0972 ns | 0.0812 ns |  3.8775 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.9975 ns | 0.0067 ns | 0.0062 ns |  3.9974 ns |  1.03 |    0.02 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.2119 ns | 0.0084 ns | 0.0075 ns |  4.2119 ns |  1.08 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.8723 ns | 0.0076 ns | 0.0071 ns |  3.8722 ns |  0.99 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.9062 ns | 0.0074 ns | 0.0062 ns |  3.9049 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.7217 ns | 0.0058 ns | 0.0049 ns |  4.7201 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.4299 ns | 0.0088 ns | 0.0068 ns |  4.4297 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.2503 ns | 0.0074 ns | 0.0070 ns |  4.2492 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.3534 ns | 0.0097 ns | 0.0091 ns |  4.3503 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.3082 ns | 0.0064 ns | 0.0060 ns |  4.3086 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.7844 ns | 0.0126 ns | 0.0105 ns |  3.7820 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.9335 ns | 0.0080 ns | 0.0075 ns |  3.9327 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.0833 ns | 0.0220 ns | 0.0206 ns |  4.0778 ns |  1.08 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.3316 ns | 0.0083 ns | 0.0069 ns |  3.3321 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.3842 ns | 0.0162 ns | 0.0151 ns |  3.3879 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.0576 ns | 0.0104 ns | 0.0092 ns |  5.0577 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  5.1228 ns | 0.0114 ns | 0.0095 ns |  5.1247 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  4.8408 ns | 0.0078 ns | 0.0065 ns |  4.8401 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.9533 ns | 0.0078 ns | 0.0070 ns |  4.9518 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.8467 ns | 0.0101 ns | 0.0095 ns |  4.8457 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.7271 ns | 0.0156 ns | 0.0130 ns | 13.7315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.7071 ns | 0.0210 ns | 0.0186 ns | 13.7044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.7039 ns | 0.0110 ns | 0.0098 ns |  6.7035 ns |  0.49 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.9811 ns | 0.0190 ns | 0.0178 ns | 13.9817 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.9653 ns | 0.0246 ns | 0.0206 ns | 13.9600 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.7674 ns | 0.1366 ns | 0.1211 ns | 24.8183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.6021 ns | 0.0366 ns | 0.0324 ns | 24.5944 ns |  0.99 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 14.1456 ns | 0.0501 ns | 0.0444 ns | 14.1675 ns |  0.57 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.7948 ns | 0.0307 ns | 0.0256 ns | 24.8012 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.9868 ns | 0.0180 ns | 0.0168 ns | 24.9858 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9491 ns | 0.0024 ns | 0.0021 ns |  0.9489 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7008 ns | 0.0035 ns | 0.0033 ns |  0.7010 ns |  0.74 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7587 ns | 0.0066 ns | 0.0051 ns |  0.7592 ns |  0.80 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6744 ns | 0.0033 ns | 0.0026 ns |  0.6749 ns |  0.71 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8677 ns | 0.0022 ns | 0.0021 ns |  0.8669 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4497 ns | 0.0022 ns | 0.0021 ns |  1.4495 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6487 ns | 0.0027 ns | 0.0025 ns |  1.6493 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4598 ns | 0.0084 ns | 0.0065 ns |  1.4565 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6669 ns | 0.0081 ns | 0.0076 ns |  1.6657 ns |  1.15 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6272 ns | 0.0033 ns | 0.0030 ns |  1.6271 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.8529 ns | 0.0236 ns | 0.0209 ns |  9.8521 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 13.8490 ns | 0.0223 ns | 0.0208 ns | 13.8510 ns |  1.41 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.8310 ns | 0.2524 ns | 0.2108 ns | 14.7762 ns |  1.51 |    0.02 |     - |     - |     - |         - |
           FromObject |        net461 | 13.2098 ns | 0.0167 ns | 0.0148 ns | 13.2056 ns |  1.34 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.5992 ns | 0.0124 ns | 0.0110 ns | 13.5958 ns |  1.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.3180 ns | 0.0871 ns | 0.0815 ns | 47.3143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 41.9666 ns | 0.1084 ns | 0.1014 ns | 41.9725 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  9.4949 ns | 0.0316 ns | 0.0295 ns |  9.4946 ns |  0.20 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 45.9384 ns | 0.1504 ns | 0.1334 ns | 45.9062 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.3114 ns | 0.0782 ns | 0.0653 ns | 46.2905 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8992 ns | 0.0045 ns | 0.0040 ns |  1.8982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8881 ns | 0.0174 ns | 0.0162 ns |  1.8950 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.7027 ns | 0.0031 ns | 0.0029 ns |  1.7029 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6981 ns | 0.0035 ns | 0.0031 ns |  1.6985 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7132 ns | 0.0079 ns | 0.0074 ns |  1.7147 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.6322 ns | 0.0194 ns | 0.0181 ns |  2.6363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.7000 ns | 0.0045 ns | 0.0042 ns |  2.7012 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.4367 ns | 0.0030 ns | 0.0028 ns |  2.4368 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  3.2507 ns | 0.0040 ns | 0.0038 ns |  3.2519 ns |  1.24 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.6767 ns | 0.0060 ns | 0.0053 ns |  2.6770 ns |  1.02 |    0.01 |     - |     - |     - |         - |
