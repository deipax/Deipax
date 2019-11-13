
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.7071 ns | 0.0036 ns | 0.0028 ns |  0.7076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9522 ns | 0.0038 ns | 0.0036 ns |  0.9526 ns |  1.35 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7324 ns | 0.0027 ns | 0.0025 ns |  0.7316 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9459 ns | 0.0023 ns | 0.0021 ns |  0.9453 ns |  1.34 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6598 ns | 0.0024 ns | 0.0020 ns |  0.6598 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1553 ns | 0.0027 ns | 0.0026 ns |  1.1558 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.6309 ns | 0.0028 ns | 0.0024 ns |  1.6312 ns |  1.41 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.4055 ns | 0.0039 ns | 0.0035 ns |  1.4054 ns |  1.22 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9963 ns | 0.0033 ns | 0.0031 ns |  1.9966 ns |  1.73 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9506 ns | 0.0045 ns | 0.0042 ns |  1.9498 ns |  1.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6937 ns | 0.0030 ns | 0.0028 ns |  0.6934 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7292 ns | 0.0028 ns | 0.0026 ns |  0.7297 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5580 ns | 0.0016 ns | 0.0015 ns |  0.5579 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7304 ns | 0.0029 ns | 0.0026 ns |  0.7300 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6297 ns | 0.0020 ns | 0.0019 ns |  0.6301 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9821 ns | 0.0034 ns | 0.0028 ns |  0.9830 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1909 ns | 0.0030 ns | 0.0028 ns |  1.1911 ns |  1.21 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0573 ns | 0.0038 ns | 0.0032 ns |  1.0579 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.0140 ns | 0.0034 ns | 0.0032 ns |  2.0137 ns |  2.05 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.0565 ns | 0.0029 ns | 0.0024 ns |  2.0567 ns |  2.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.2848 ns | 0.0022 ns | 0.0019 ns |  1.2846 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3852 ns | 0.0069 ns | 0.0064 ns |  1.3834 ns |  1.08 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6083 ns | 0.0133 ns | 0.0118 ns |  0.6047 ns |  0.47 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7719 ns | 0.0035 ns | 0.0031 ns |  1.7716 ns |  1.38 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7373 ns | 0.0027 ns | 0.0025 ns |  1.7377 ns |  1.35 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7935 ns | 0.0118 ns | 0.0110 ns |  1.7895 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8142 ns | 0.0041 ns | 0.0038 ns |  1.8136 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9843 ns | 0.0022 ns | 0.0020 ns |  0.9847 ns |  0.55 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.8117 ns | 0.0052 ns | 0.0046 ns |  2.8120 ns |  1.57 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.7780 ns | 0.0039 ns | 0.0036 ns |  2.7778 ns |  1.55 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7074 ns | 0.0024 ns | 0.0022 ns |  0.7069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7048 ns | 0.0022 ns | 0.0017 ns |  0.7045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6835 ns | 0.0040 ns | 0.0038 ns |  0.6831 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7984 ns | 0.0080 ns | 0.0071 ns |  0.8016 ns |  1.13 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.6643 ns | 0.0030 ns | 0.0028 ns |  0.6650 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9783 ns | 0.0018 ns | 0.0016 ns |  0.9782 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1643 ns | 0.0032 ns | 0.0030 ns |  1.1644 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9601 ns | 0.0068 ns | 0.0064 ns |  0.9583 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9471 ns | 0.0031 ns | 0.0029 ns |  1.9469 ns |  1.99 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9199 ns | 0.0040 ns | 0.0037 ns |  1.9180 ns |  1.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3507 ns | 0.0091 ns | 0.0081 ns |  1.3477 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.3947 ns | 0.0029 ns | 0.0027 ns |  1.3955 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6156 ns | 0.0019 ns | 0.0018 ns |  0.6159 ns |  0.46 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7691 ns | 0.0026 ns | 0.0022 ns |  1.7695 ns |  1.31 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.7367 ns | 0.0022 ns | 0.0019 ns |  1.7366 ns |  1.29 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.9043 ns | 0.0034 ns | 0.0032 ns |  1.9045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7804 ns | 0.0028 ns | 0.0026 ns |  1.7798 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1139 ns | 0.0043 ns | 0.0040 ns |  1.1148 ns |  0.58 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.7256 ns | 0.0236 ns | 0.0221 ns |  2.7346 ns |  1.43 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.6972 ns | 0.0238 ns | 0.0223 ns |  2.6906 ns |  1.42 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6937 ns | 0.0022 ns | 0.0018 ns |  0.6938 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7306 ns | 0.0019 ns | 0.0018 ns |  0.7315 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5404 ns | 0.0025 ns | 0.0023 ns |  0.5398 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7359 ns | 0.0017 ns | 0.0016 ns |  0.7359 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6315 ns | 0.0019 ns | 0.0017 ns |  0.6318 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9778 ns | 0.0025 ns | 0.0021 ns |  0.9781 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.2048 ns | 0.0073 ns | 0.0069 ns |  1.2064 ns |  1.23 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0631 ns | 0.0022 ns | 0.0021 ns |  1.0623 ns |  1.09 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0166 ns | 0.0028 ns | 0.0023 ns |  2.0167 ns |  2.06 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0182 ns | 0.0027 ns | 0.0025 ns |  2.0183 ns |  2.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.4266 ns | 0.0027 ns | 0.0026 ns |  1.4269 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.4054 ns | 0.0041 ns | 0.0039 ns |  1.4052 ns |  0.99 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7412 ns | 0.0028 ns | 0.0026 ns |  0.7416 ns |  0.52 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7704 ns | 0.0028 ns | 0.0027 ns |  1.7698 ns |  1.24 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7411 ns | 0.0039 ns | 0.0037 ns |  1.7406 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.0080 ns | 0.0034 ns | 0.0030 ns |  2.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.9299 ns | 0.0026 ns | 0.0025 ns |  1.9292 ns |  0.96 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0699 ns | 0.0033 ns | 0.0031 ns |  1.0697 ns |  0.53 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.6829 ns | 0.0149 ns | 0.0139 ns |  2.6849 ns |  1.34 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.5856 ns | 0.0088 ns | 0.0082 ns |  2.5855 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7176 ns | 0.0138 ns | 0.0129 ns |  0.7106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6703 ns | 0.0030 ns | 0.0028 ns |  0.6701 ns |  0.93 |    0.02 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9614 ns | 0.0087 ns | 0.0077 ns |  0.9632 ns |  1.34 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.6711 ns | 0.0016 ns | 0.0015 ns |  0.6710 ns |  0.93 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7158 ns | 0.0027 ns | 0.0023 ns |  0.7157 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  0.9914 ns | 0.0024 ns | 0.0022 ns |  0.9910 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1661 ns | 0.0028 ns | 0.0026 ns |  1.1664 ns |  1.18 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0782 ns | 0.0032 ns | 0.0030 ns |  1.0794 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9283 ns | 0.0023 ns | 0.0021 ns |  1.9282 ns |  1.95 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9419 ns | 0.0028 ns | 0.0026 ns |  1.9418 ns |  1.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.4035 ns | 0.0025 ns | 0.0019 ns |  1.4034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.3893 ns | 0.0081 ns | 0.0072 ns |  1.3912 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7471 ns | 0.0025 ns | 0.0023 ns |  0.7478 ns |  0.53 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.9132 ns | 0.0161 ns | 0.0150 ns |  1.9204 ns |  1.37 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7658 ns | 0.0016 ns | 0.0015 ns |  1.7656 ns |  1.26 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.9473 ns | 0.0155 ns | 0.0145 ns |  1.9366 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.9010 ns | 0.0023 ns | 0.0021 ns |  1.9013 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.3848 ns | 0.0032 ns | 0.0030 ns |  1.3855 ns |  0.71 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.8786 ns | 0.0037 ns | 0.0034 ns |  2.8791 ns |  1.48 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.9197 ns | 0.0041 ns | 0.0034 ns |  2.9208 ns |  1.50 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.6935 ns | 0.0027 ns | 0.0025 ns |  0.6936 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.6735 ns | 0.0040 ns | 0.0038 ns |  0.6736 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.6589 ns | 0.0025 ns | 0.0023 ns |  0.6584 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.6621 ns | 0.0018 ns | 0.0016 ns |  0.6625 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  0.6951 ns | 0.0026 ns | 0.0025 ns |  0.6948 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.1442 ns | 0.0028 ns | 0.0022 ns |  1.1439 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.1252 ns | 0.0051 ns | 0.0048 ns |  1.1244 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.1505 ns | 0.0026 ns | 0.0024 ns |  1.1512 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.3622 ns | 0.0031 ns | 0.0029 ns |  1.3615 ns |  1.19 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.4088 ns | 0.0021 ns | 0.0018 ns |  1.4088 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.2865 ns | 0.0064 ns | 0.0060 ns |  3.2848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.3612 ns | 0.0031 ns | 0.0029 ns |  2.3611 ns |  0.72 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  2.3836 ns | 0.0147 ns | 0.0123 ns |  2.3869 ns |  0.73 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.3321 ns | 0.0056 ns | 0.0052 ns |  3.3312 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.3572 ns | 0.0045 ns | 0.0043 ns |  3.3572 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.9874 ns | 0.0053 ns | 0.0050 ns |  3.9869 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.9258 ns | 0.0066 ns | 0.0062 ns |  2.9256 ns |  0.73 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.2958 ns | 0.0083 ns | 0.0078 ns |  3.2941 ns |  0.83 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.0744 ns | 0.0087 ns | 0.0077 ns |  4.0745 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.0753 ns | 0.0060 ns | 0.0056 ns |  4.0743 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.2497 ns | 0.0060 ns | 0.0053 ns |  3.2504 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.1246 ns | 0.0033 ns | 0.0031 ns |  2.1245 ns |  0.65 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.9106 ns | 0.0023 ns | 0.0022 ns |  1.9111 ns |  0.59 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2596 ns | 0.0206 ns | 0.0192 ns |  3.2692 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2690 ns | 0.0034 ns | 0.0030 ns |  3.2679 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.5692 ns | 0.0071 ns | 0.0066 ns |  4.5699 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.2341 ns | 0.0055 ns | 0.0051 ns |  3.2351 ns |  0.71 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.1904 ns | 0.0055 ns | 0.0048 ns |  3.1907 ns |  0.70 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.0196 ns | 0.0056 ns | 0.0053 ns |  5.0191 ns |  1.10 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.0344 ns | 0.0062 ns | 0.0052 ns |  5.0330 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.8750 ns | 0.0111 ns | 0.0104 ns | 12.8776 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1031 ns | 0.0129 ns | 0.0115 ns | 13.1052 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6340 ns | 0.0067 ns | 0.0063 ns |  5.6345 ns |  0.44 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.2835 ns | 0.0145 ns | 0.0121 ns | 13.2832 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.3861 ns | 0.0803 ns | 0.0751 ns | 13.4374 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.0324 ns | 0.0255 ns | 0.0226 ns | 24.0281 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.9693 ns | 0.0285 ns | 0.0266 ns | 23.9724 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.9639 ns | 0.0285 ns | 0.0223 ns | 12.9665 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.3656 ns | 0.1393 ns | 0.1303 ns | 24.4450 ns |  1.01 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.8702 ns | 0.0202 ns | 0.0189 ns | 24.8690 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6991 ns | 0.0026 ns | 0.0024 ns |  0.7001 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6823 ns | 0.0016 ns | 0.0015 ns |  0.6826 ns |  0.98 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7362 ns | 0.0023 ns | 0.0022 ns |  0.7365 ns |  1.05 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6721 ns | 0.0029 ns | 0.0028 ns |  0.6710 ns |  0.96 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7033 ns | 0.0032 ns | 0.0027 ns |  0.7041 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4712 ns | 0.0032 ns | 0.0029 ns |  1.4719 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6098 ns | 0.0053 ns | 0.0042 ns |  1.6098 ns |  1.09 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4329 ns | 0.0033 ns | 0.0031 ns |  1.4330 ns |  0.97 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6332 ns | 0.0064 ns | 0.0057 ns |  1.6316 ns |  1.11 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6627 ns | 0.0110 ns | 0.0103 ns |  1.6662 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.2022 ns | 0.0130 ns | 0.0115 ns | 10.2060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.2891 ns | 0.0185 ns | 0.0164 ns | 14.2939 ns |  1.40 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.1067 ns | 0.0587 ns | 0.0549 ns | 15.1346 ns |  1.48 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.4448 ns | 0.0166 ns | 0.0155 ns | 13.4502 ns |  1.32 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.7170 ns | 0.0129 ns | 0.0121 ns | 13.7154 ns |  1.34 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.7469 ns | 0.0841 ns | 0.0787 ns | 46.7727 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 40.5687 ns | 0.0417 ns | 0.0326 ns | 40.5659 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.6605 ns | 0.2197 ns | 0.2055 ns | 10.8068 ns |  0.23 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 45.7096 ns | 0.0815 ns | 0.0763 ns | 45.7013 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.4096 ns | 0.0892 ns | 0.0835 ns | 47.4003 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.4447 ns | 0.0022 ns | 0.0021 ns |  1.4442 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.3959 ns | 0.0030 ns | 0.0028 ns |  1.3957 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.9600 ns | 0.0041 ns | 0.0034 ns |  0.9603 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7445 ns | 0.0034 ns | 0.0026 ns |  1.7450 ns |  1.21 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7542 ns | 0.0025 ns | 0.0023 ns |  1.7536 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.8227 ns | 0.0814 ns | 0.1405 ns |  2.8735 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.9201 ns | 0.0081 ns | 0.0075 ns |  1.9211 ns |  0.69 |    0.03 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0924 ns | 0.0026 ns | 0.0023 ns |  1.0924 ns |  0.39 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.9162 ns | 0.0040 ns | 0.0035 ns |  2.9162 ns |  1.05 |    0.05 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.5915 ns | 0.0032 ns | 0.0029 ns |  2.5911 ns |  0.93 |    0.05 |     - |     - |     - |         - |
