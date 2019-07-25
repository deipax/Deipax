
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
             FromBool | .NET Core 2.0 |  0.9240 ns | 0.0100 ns | 0.0093 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6713 ns | 0.0033 ns | 0.0028 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.6907 ns | 0.0048 ns | 0.0045 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9487 ns | 0.0047 ns | 0.0044 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9516 ns | 0.0029 ns | 0.0025 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3829 ns | 0.0028 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1272 ns | 0.0036 ns | 0.0032 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1499 ns | 0.0044 ns | 0.0039 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0977 ns | 0.0023 ns | 0.0022 ns |  1.52 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1026 ns | 0.0044 ns | 0.0036 ns |  1.52 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9263 ns | 0.0050 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4334 ns | 0.0022 ns | 0.0021 ns |  0.47 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4597 ns | 0.0014 ns | 0.0013 ns |  0.50 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7437 ns | 0.0037 ns | 0.0035 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7472 ns | 0.0021 ns | 0.0019 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.6860 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.6996 ns | 0.0021 ns | 0.0020 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.6446 ns | 0.0025 ns | 0.0023 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9506 ns | 0.0034 ns | 0.0031 ns |  1.39 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9440 ns | 0.0043 ns | 0.0041 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6893 ns | 0.0022 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6682 ns | 0.0086 ns | 0.0080 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7189 ns | 0.0025 ns | 0.0022 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7251 ns | 0.0026 ns | 0.0021 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7184 ns | 0.0026 ns | 0.0023 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1522 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9009 ns | 0.0025 ns | 0.0024 ns |  0.78 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9607 ns | 0.0037 ns | 0.0029 ns |  0.83 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.7044 ns | 0.0089 ns | 0.0083 ns |  1.48 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6713 ns | 0.0033 ns | 0.0031 ns |  1.45 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9248 ns | 0.0077 ns | 0.0072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6640 ns | 0.0087 ns | 0.0081 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6859 ns | 0.0035 ns | 0.0033 ns |  0.74 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.9493 ns | 0.0038 ns | 0.0036 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.9414 ns | 0.0035 ns | 0.0033 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9237 ns | 0.0024 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9451 ns | 0.0034 ns | 0.0032 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9233 ns | 0.0035 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6879 ns | 0.0104 ns | 0.0097 ns |  1.83 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.7015 ns | 0.0104 ns | 0.0092 ns |  1.84 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6934 ns | 0.0118 ns | 0.0105 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6640 ns | 0.0031 ns | 0.0029 ns |  0.96 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6862 ns | 0.0041 ns | 0.0034 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7169 ns | 0.0023 ns | 0.0020 ns |  1.03 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7173 ns | 0.0036 ns | 0.0034 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.1473 ns | 0.0022 ns | 0.0018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.9304 ns | 0.0041 ns | 0.0037 ns |  0.81 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9208 ns | 0.0037 ns | 0.0034 ns |  0.80 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6880 ns | 0.0131 ns | 0.0122 ns |  1.47 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.6832 ns | 0.0096 ns | 0.0085 ns |  1.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9211 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6594 ns | 0.0077 ns | 0.0072 ns |  0.72 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6941 ns | 0.0026 ns | 0.0024 ns |  0.75 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.9638 ns | 0.0030 ns | 0.0027 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.9708 ns | 0.0039 ns | 0.0037 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9408 ns | 0.0042 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.9227 ns | 0.0112 ns | 0.0105 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9414 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6828 ns | 0.0062 ns | 0.0058 ns |  1.79 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.7775 ns | 0.0042 ns | 0.0033 ns |  1.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.6923 ns | 0.0038 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.6649 ns | 0.0022 ns | 0.0017 ns |  0.96 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7198 ns | 0.0025 ns | 0.0023 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.7231 ns | 0.0019 ns | 0.0017 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7239 ns | 0.0107 ns | 0.0100 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.9438 ns | 0.0065 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.8504 ns | 0.0031 ns | 0.0027 ns |  0.90 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.8756 ns | 0.0025 ns | 0.0023 ns |  0.93 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.6673 ns | 0.0041 ns | 0.0039 ns |  1.77 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.6589 ns | 0.0052 ns | 0.0046 ns |  1.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9197 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7377 ns | 0.0039 ns | 0.0036 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9295 ns | 0.0019 ns | 0.0016 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.6730 ns | 0.0038 ns | 0.0036 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6623 ns | 0.0034 ns | 0.0028 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  0.9338 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1571 ns | 0.0032 ns | 0.0028 ns |  1.24 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.9560 ns | 0.0040 ns | 0.0034 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.6526 ns | 0.0049 ns | 0.0046 ns |  1.77 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.6724 ns | 0.0097 ns | 0.0091 ns |  1.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6913 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.7155 ns | 0.0023 ns | 0.0020 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.5529 ns | 0.0031 ns | 0.0026 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.6690 ns | 0.0033 ns | 0.0031 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6628 ns | 0.0018 ns | 0.0016 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.4704 ns | 0.0216 ns | 0.0202 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7543 ns | 0.0036 ns | 0.0034 ns |  1.19 |    0.02 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7099 ns | 0.0043 ns | 0.0040 ns |  1.16 |    0.02 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.1350 ns | 0.0064 ns | 0.0057 ns |  1.45 |    0.02 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.0846 ns | 0.0141 ns | 0.0132 ns |  1.42 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.1513 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.9404 ns | 0.0025 ns | 0.0022 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7363 ns | 0.0058 ns | 0.0051 ns |  0.64 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  0.8957 ns | 0.0135 ns | 0.0126 ns |  0.78 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  0.8834 ns | 0.0022 ns | 0.0021 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9363 ns | 0.0044 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9362 ns | 0.0100 ns | 0.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.6588 ns | 0.0054 ns | 0.0046 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.2180 ns | 0.0060 ns | 0.0050 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 10.3643 ns | 0.0065 ns | 0.0061 ns |  5.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.6663 ns | 0.0038 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.9570 ns | 0.0030 ns | 0.0027 ns |  1.44 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.9331 ns | 0.0021 ns | 0.0019 ns |  1.40 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.8987 ns | 0.0106 ns | 0.0099 ns |  1.35 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.8850 ns | 0.0027 ns | 0.0024 ns |  1.33 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  0.9282 ns | 0.0027 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.9565 ns | 0.0036 ns | 0.0034 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.8830 ns | 0.0016 ns | 0.0014 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.8494 ns | 0.0037 ns | 0.0034 ns |  1.99 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.8391 ns | 0.0030 ns | 0.0028 ns |  1.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.6592 ns | 0.0117 ns | 0.0109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.7371 ns | 0.0030 ns | 0.0027 ns |  1.12 |    0.02 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.7252 ns | 0.0059 ns | 0.0053 ns |  1.10 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.6630 ns | 0.0030 ns | 0.0025 ns |  1.01 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.6561 ns | 0.0024 ns | 0.0022 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.6413 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.5319 ns | 0.0057 ns | 0.0048 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.7062 ns | 0.0043 ns | 0.0040 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  1.9611 ns | 0.0069 ns | 0.0061 ns |  1.19 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  1.9340 ns | 0.0049 ns | 0.0046 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  8.0369 ns | 0.0099 ns | 0.0092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  8.1964 ns | 0.0500 ns | 0.0468 ns |  1.02 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.4883 ns | 0.0088 ns | 0.0073 ns |  0.68 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  7.8914 ns | 0.0144 ns | 0.0128 ns |  0.98 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  8.4074 ns | 0.0158 ns | 0.0132 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.0843 ns | 0.0289 ns | 0.0256 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.2633 ns | 0.0273 ns | 0.0242 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 17.4335 ns | 0.0932 ns | 0.0872 ns |  0.75 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 23.1563 ns | 0.0366 ns | 0.0305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 23.1268 ns | 0.0320 ns | 0.0299 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9189 ns | 0.0030 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7128 ns | 0.0034 ns | 0.0027 ns |  0.78 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.5494 ns | 0.0033 ns | 0.0030 ns |  0.60 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6567 ns | 0.0014 ns | 0.0013 ns |  0.71 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6571 ns | 0.0026 ns | 0.0023 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4150 ns | 0.0184 ns | 0.0172 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4232 ns | 0.0030 ns | 0.0027 ns |  1.01 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.3628 ns | 0.0031 ns | 0.0029 ns |  0.96 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 10.6274 ns | 0.0112 ns | 0.0105 ns |  7.51 |    0.09 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.5797 ns | 0.0584 ns | 0.0819 ns |  1.13 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.3608 ns | 0.0070 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2277 ns | 0.0086 ns | 0.0076 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1784 ns | 0.0034 ns | 0.0030 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.1924 ns | 0.0042 ns | 0.0037 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.1821 ns | 0.0038 ns | 0.0032 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 58.2962 ns | 0.2987 ns | 0.2794 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 61.9297 ns | 0.3890 ns | 0.3639 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 44.5994 ns | 0.1003 ns | 0.0889 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 58.0331 ns | 0.0909 ns | 0.0806 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 59.0198 ns | 0.1153 ns | 0.1022 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.9165 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7343 ns | 0.0052 ns | 0.0046 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.5042 ns | 0.0025 ns | 0.0021 ns |  0.55 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.6701 ns | 0.0021 ns | 0.0019 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.6628 ns | 0.0024 ns | 0.0023 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.4934 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9355 ns | 0.0040 ns | 0.0033 ns |  0.63 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  0.9594 ns | 0.0036 ns | 0.0030 ns |  0.64 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6492 ns | 0.0036 ns | 0.0028 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.2971 ns | 0.0032 ns | 0.0026 ns |  1.54 |    0.00 |     - |     - |     - |         - |
