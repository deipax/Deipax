
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
             FromBool | .NET Core 2.0 |  0.9229 ns | 0.0021 ns | 0.0020 ns |  0.9227 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.1726 ns | 0.0028 ns | 0.0027 ns |  1.1729 ns |  1.27 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1608 ns | 0.0022 ns | 0.0018 ns |  1.1612 ns |  1.26 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1651 ns | 0.0118 ns | 0.0110 ns |  1.1693 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9052 ns | 0.0039 ns | 0.0036 ns |  0.9061 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3760 ns | 0.0039 ns | 0.0037 ns |  1.3742 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.4002 ns | 0.0032 ns | 0.0027 ns |  1.4003 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.2040 ns | 0.0130 ns | 0.0122 ns |  1.2125 ns |  0.88 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6436 ns | 0.0059 ns | 0.0049 ns |  1.6430 ns |  1.19 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6437 ns | 0.0115 ns | 0.0107 ns |  1.6388 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6842 ns | 0.0014 ns | 0.0013 ns |  0.6840 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7397 ns | 0.0080 ns | 0.0075 ns |  0.7424 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4900 ns | 0.0011 ns | 0.0010 ns |  0.4899 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.5649 ns | 0.0022 ns | 0.0021 ns |  0.5652 ns |  0.83 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.4504 ns | 0.0015 ns | 0.0014 ns |  0.4504 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1631 ns | 0.0085 ns | 0.0079 ns |  1.1639 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1739 ns | 0.0025 ns | 0.0023 ns |  1.1738 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9574 ns | 0.0085 ns | 0.0079 ns |  0.9548 ns |  0.82 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.6235 ns | 0.0042 ns | 0.0039 ns |  1.6229 ns |  1.40 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6170 ns | 0.0038 ns | 0.0035 ns |  1.6167 ns |  1.39 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6845 ns | 0.0025 ns | 0.0023 ns |  0.6846 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7142 ns | 0.0029 ns | 0.0024 ns |  0.7144 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.4912 ns | 0.0055 ns | 0.0049 ns |  0.4892 ns |  0.72 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7166 ns | 0.0046 ns | 0.0043 ns |  0.7181 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.4389 ns | 0.0012 ns | 0.0012 ns |  0.4387 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.9158 ns | 0.0028 ns | 0.0025 ns |  0.9155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1802 ns | 0.0051 ns | 0.0047 ns |  1.1814 ns |  1.29 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9518 ns | 0.0021 ns | 0.0019 ns |  0.9520 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.5243 ns | 0.0032 ns | 0.0030 ns |  1.5241 ns |  1.66 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6549 ns | 0.0024 ns | 0.0022 ns |  1.6547 ns |  1.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7015 ns | 0.0078 ns | 0.0073 ns |  0.7044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7126 ns | 0.0014 ns | 0.0013 ns |  0.7128 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.4865 ns | 0.0015 ns | 0.0013 ns |  0.4866 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7145 ns | 0.0024 ns | 0.0020 ns |  0.7140 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.4462 ns | 0.0024 ns | 0.0022 ns |  0.4460 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1464 ns | 0.0019 ns | 0.0017 ns |  1.1465 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1729 ns | 0.0127 ns | 0.0119 ns |  1.1792 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9560 ns | 0.0093 ns | 0.0087 ns |  0.9568 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6813 ns | 0.0090 ns | 0.0080 ns |  1.6836 ns |  1.47 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6631 ns | 0.0029 ns | 0.0027 ns |  1.6632 ns |  1.45 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6876 ns | 0.0029 ns | 0.0024 ns |  0.6878 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7072 ns | 0.0018 ns | 0.0017 ns |  0.7074 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.4885 ns | 0.0017 ns | 0.0016 ns |  0.4885 ns |  0.71 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7018 ns | 0.0023 ns | 0.0021 ns |  0.7016 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  0.4533 ns | 0.0013 ns | 0.0012 ns |  0.4533 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.9243 ns | 0.0099 ns | 0.0093 ns |  0.9269 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1708 ns | 0.0024 ns | 0.0021 ns |  1.1714 ns |  1.27 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1657 ns | 0.0032 ns | 0.0029 ns |  1.1666 ns |  1.26 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6224 ns | 0.0029 ns | 0.0026 ns |  1.6225 ns |  1.76 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.6238 ns | 0.0030 ns | 0.0028 ns |  1.6231 ns |  1.76 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6859 ns | 0.0021 ns | 0.0019 ns |  0.6857 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7364 ns | 0.0038 ns | 0.0034 ns |  0.7358 ns |  1.07 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.4923 ns | 0.0054 ns | 0.0051 ns |  0.4947 ns |  0.72 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6987 ns | 0.0100 ns | 0.0093 ns |  0.7001 ns |  1.02 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.4421 ns | 0.0015 ns | 0.0014 ns |  0.4422 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1391 ns | 0.0021 ns | 0.0019 ns |  1.1395 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1735 ns | 0.0026 ns | 0.0024 ns |  1.1742 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1646 ns | 0.0022 ns | 0.0020 ns |  1.1644 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6216 ns | 0.0027 ns | 0.0025 ns |  1.6219 ns |  1.42 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6137 ns | 0.0028 ns | 0.0024 ns |  1.6134 ns |  1.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.6923 ns | 0.0085 ns | 0.0079 ns |  0.6952 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.7178 ns | 0.0020 ns | 0.0017 ns |  0.7177 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7142 ns | 0.0031 ns | 0.0029 ns |  0.7136 ns |  1.03 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.7193 ns | 0.0021 ns | 0.0018 ns |  0.7194 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.4440 ns | 0.0020 ns | 0.0019 ns |  0.4442 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.9165 ns | 0.0024 ns | 0.0023 ns |  0.9168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.1704 ns | 0.0096 ns | 0.0090 ns |  1.1665 ns |  1.28 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.9600 ns | 0.0071 ns | 0.0067 ns |  0.9618 ns |  1.05 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.6473 ns | 0.0149 ns | 0.0139 ns |  1.6535 ns |  1.80 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.6333 ns | 0.0077 ns | 0.0072 ns |  1.6342 ns |  1.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.6870 ns | 0.0023 ns | 0.0021 ns |  0.6878 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6777 ns | 0.0022 ns | 0.0019 ns |  0.6775 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6326 ns | 0.0088 ns | 0.0082 ns |  0.6297 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7029 ns | 0.0016 ns | 0.0014 ns |  0.7034 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7230 ns | 0.0025 ns | 0.0022 ns |  0.7226 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1541 ns | 0.0075 ns | 0.0070 ns |  1.1563 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1338 ns | 0.0028 ns | 0.0026 ns |  1.1331 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0877 ns | 0.0021 ns | 0.0020 ns |  1.0878 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.6351 ns | 0.0025 ns | 0.0023 ns |  1.6351 ns |  1.42 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.6514 ns | 0.0032 ns | 0.0030 ns |  1.6520 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6894 ns | 0.0025 ns | 0.0024 ns |  0.6893 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.6813 ns | 0.0067 ns | 0.0063 ns |  0.6787 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.6358 ns | 0.0099 ns | 0.0093 ns |  0.6317 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7163 ns | 0.0069 ns | 0.0065 ns |  0.7183 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.7088 ns | 0.0014 ns | 0.0013 ns |  0.7087 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.4605 ns | 0.0112 ns | 0.0105 ns |  1.4638 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.4285 ns | 0.0049 ns | 0.0044 ns |  1.4279 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.4905 ns | 0.0025 ns | 0.0023 ns |  1.4902 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.8065 ns | 0.0126 ns | 0.0118 ns |  1.8009 ns |  1.24 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.8743 ns | 0.0063 ns | 0.0059 ns |  1.8737 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.2510 ns | 0.0028 ns | 0.0026 ns |  1.2513 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.1445 ns | 0.0028 ns | 0.0027 ns |  1.1445 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.6503 ns | 0.0073 ns | 0.0068 ns |  0.6475 ns |  0.52 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6666 ns | 0.0127 ns | 0.0119 ns |  1.6721 ns |  1.33 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6382 ns | 0.0027 ns | 0.0025 ns |  1.6381 ns |  1.31 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9251 ns | 0.0044 ns | 0.0034 ns |  1.9251 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9436 ns | 0.0137 ns | 0.0128 ns |  1.9497 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.6680 ns | 0.0040 ns | 0.0035 ns |  1.6691 ns |  0.87 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.6984 ns | 0.0043 ns | 0.0038 ns |  2.6990 ns |  1.40 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.7761 ns | 0.0037 ns | 0.0033 ns |  2.7756 ns |  1.44 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.1723 ns | 0.0184 ns | 0.0144 ns |  3.1774 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.0790 ns | 0.0040 ns | 0.0037 ns |  2.0787 ns |  0.66 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.8822 ns | 0.0156 ns | 0.0146 ns |  1.8792 ns |  0.59 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.2505 ns | 0.0038 ns | 0.0035 ns |  3.2497 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.2839 ns | 0.0069 ns | 0.0064 ns |  3.2869 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.6752 ns | 0.0060 ns | 0.0056 ns |  3.6755 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.3359 ns | 0.0104 ns | 0.0097 ns |  2.3329 ns |  0.64 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  2.5265 ns | 0.0059 ns | 0.0055 ns |  2.5252 ns |  0.69 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.9584 ns | 0.0044 ns | 0.0041 ns |  3.9588 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.9333 ns | 0.0130 ns | 0.0115 ns |  3.9368 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.9917 ns | 0.0139 ns | 0.0130 ns |  2.9907 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  1.8511 ns | 0.0033 ns | 0.0031 ns |  1.8508 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.8244 ns | 0.0088 ns | 0.0082 ns |  1.8246 ns |  0.61 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2147 ns | 0.0067 ns | 0.0059 ns |  3.2140 ns |  1.07 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4404 ns | 0.0060 ns | 0.0053 ns |  3.4410 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.3345 ns | 0.0053 ns | 0.0050 ns |  4.3331 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.0791 ns | 0.0060 ns | 0.0053 ns |  3.0775 ns |  0.71 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.2753 ns | 0.0213 ns | 0.0199 ns |  3.2682 ns |  0.76 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.4135 ns | 0.0041 ns | 0.0039 ns |  4.4131 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.4238 ns | 0.0094 ns | 0.0073 ns |  4.4243 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.0763 ns | 0.0132 ns | 0.0117 ns | 13.0736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1595 ns | 0.0677 ns | 0.0634 ns | 13.1899 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.7329 ns | 0.0651 ns | 0.0609 ns |  5.7474 ns |  0.44 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.2697 ns | 0.0150 ns | 0.0133 ns | 13.2681 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.3056 ns | 0.0109 ns | 0.0102 ns | 13.3059 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.6578 ns | 0.0328 ns | 0.0274 ns | 23.6551 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.6292 ns | 0.0211 ns | 0.0197 ns | 23.6317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.6136 ns | 0.1286 ns | 0.1203 ns | 12.7064 ns |  0.53 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.0250 ns | 0.1080 ns | 0.1010 ns | 23.9758 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 23.8245 ns | 0.0324 ns | 0.0303 ns | 23.8196 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6827 ns | 0.0018 ns | 0.0016 ns |  0.6824 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6747 ns | 0.0025 ns | 0.0021 ns |  0.6746 ns |  0.99 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7082 ns | 0.0101 ns | 0.0094 ns |  0.7147 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7400 ns | 0.0020 ns | 0.0019 ns |  0.7400 ns |  1.08 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7071 ns | 0.0025 ns | 0.0024 ns |  0.7073 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.3959 ns | 0.0028 ns | 0.0025 ns |  1.3965 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.5953 ns | 0.0175 ns | 0.0164 ns |  1.5890 ns |  1.14 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4222 ns | 0.0036 ns | 0.0034 ns |  1.4231 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.5711 ns | 0.0040 ns | 0.0037 ns |  1.5710 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4200 ns | 0.0018 ns | 0.0016 ns |  1.4196 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2403 ns | 0.0132 ns | 0.0124 ns |  2.2340 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2204 ns | 0.0036 ns | 0.0034 ns |  2.2200 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1289 ns | 0.0045 ns | 0.0040 ns |  2.1284 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2380 ns | 0.0044 ns | 0.0039 ns |  2.2384 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2443 ns | 0.0023 ns | 0.0022 ns |  2.2448 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.5843 ns | 0.0492 ns | 0.0460 ns | 48.5874 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 39.4444 ns | 0.1015 ns | 0.0900 ns | 39.4016 ns |  0.81 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 11.1531 ns | 0.0747 ns | 0.0698 ns | 11.1897 ns |  0.23 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 47.4919 ns | 0.0696 ns | 0.0651 ns | 47.4936 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.3337 ns | 0.0559 ns | 0.0436 ns | 47.3379 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6873 ns | 0.0026 ns | 0.0025 ns |  0.6871 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6802 ns | 0.0069 ns | 0.0065 ns |  0.6795 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7114 ns | 0.0014 ns | 0.0013 ns |  0.7116 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7159 ns | 0.0034 ns | 0.0030 ns |  0.7161 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7238 ns | 0.0022 ns | 0.0021 ns |  0.7242 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1516 ns | 0.0048 ns | 0.0042 ns |  1.1521 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1335 ns | 0.0039 ns | 0.0036 ns |  1.1333 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0952 ns | 0.0030 ns | 0.0026 ns |  1.0958 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6228 ns | 0.0042 ns | 0.0040 ns |  1.6231 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.6317 ns | 0.0018 ns | 0.0016 ns |  1.6317 ns |  1.42 |    0.01 |     - |     - |     - |         - |
