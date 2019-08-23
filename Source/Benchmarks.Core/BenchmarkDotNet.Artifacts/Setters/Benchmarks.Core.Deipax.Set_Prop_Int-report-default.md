
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
             FromBool | .NET Core 2.0 |  0.9452 ns | 0.0036 ns | 0.0034 ns |  0.9456 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9056 ns | 0.0025 ns | 0.0022 ns |  0.9060 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1755 ns | 0.0101 ns | 0.0094 ns |  1.1794 ns |  1.24 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1768 ns | 0.0049 ns | 0.0046 ns |  1.1759 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1751 ns | 0.0048 ns | 0.0043 ns |  1.1748 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4137 ns | 0.0026 ns | 0.0025 ns |  1.4138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1512 ns | 0.0039 ns | 0.0037 ns |  1.1516 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.3987 ns | 0.0029 ns | 0.0027 ns |  1.3981 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9292 ns | 0.0026 ns | 0.0021 ns |  1.9300 ns |  1.36 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.8515 ns | 0.0025 ns | 0.0022 ns |  1.8519 ns |  1.31 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.7186 ns | 0.0024 ns | 0.0023 ns |  0.7192 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4520 ns | 0.0013 ns | 0.0012 ns |  0.4521 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7100 ns | 0.0020 ns | 0.0017 ns |  0.7099 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7450 ns | 0.0017 ns | 0.0015 ns |  0.7452 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7391 ns | 0.0060 ns | 0.0050 ns |  0.7403 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1798 ns | 0.0034 ns | 0.0032 ns |  1.1796 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9034 ns | 0.0026 ns | 0.0025 ns |  0.9033 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0996 ns | 0.0029 ns | 0.0027 ns |  1.0986 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.6205 ns | 0.0022 ns | 0.0020 ns |  1.6210 ns |  1.37 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6512 ns | 0.0091 ns | 0.0085 ns |  1.6531 ns |  1.40 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7202 ns | 0.0022 ns | 0.0018 ns |  0.7201 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.4423 ns | 0.0018 ns | 0.0016 ns |  0.4427 ns |  0.61 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7069 ns | 0.0025 ns | 0.0022 ns |  0.7066 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7144 ns | 0.0017 ns | 0.0014 ns |  0.7141 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7214 ns | 0.0043 ns | 0.0040 ns |  0.7211 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.9603 ns | 0.0078 ns | 0.0073 ns |  0.9634 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9098 ns | 0.0022 ns | 0.0019 ns |  0.9096 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1660 ns | 0.0032 ns | 0.0030 ns |  1.1652 ns |  1.21 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.5999 ns | 0.0036 ns | 0.0034 ns |  1.5996 ns |  1.67 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6076 ns | 0.0028 ns | 0.0026 ns |  1.6071 ns |  1.67 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7174 ns | 0.0019 ns | 0.0018 ns |  0.7171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4581 ns | 0.0080 ns | 0.0075 ns |  0.4616 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7046 ns | 0.0016 ns | 0.0015 ns |  0.7050 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7175 ns | 0.0031 ns | 0.0028 ns |  0.7167 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7080 ns | 0.0018 ns | 0.0016 ns |  0.7084 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1871 ns | 0.0021 ns | 0.0018 ns |  1.1875 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9123 ns | 0.0018 ns | 0.0017 ns |  0.9129 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.0827 ns | 0.0019 ns | 0.0017 ns |  1.0824 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6040 ns | 0.0024 ns | 0.0022 ns |  1.6041 ns |  1.35 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6104 ns | 0.0034 ns | 0.0030 ns |  1.6098 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7221 ns | 0.0051 ns | 0.0045 ns |  0.7231 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.4346 ns | 0.0017 ns | 0.0016 ns |  0.4341 ns |  0.60 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6277 ns | 0.0041 ns | 0.0038 ns |  0.6277 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7128 ns | 0.0024 ns | 0.0022 ns |  0.7132 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7128 ns | 0.0043 ns | 0.0038 ns |  0.7124 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.4148 ns | 0.0029 ns | 0.0027 ns |  1.4155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.2354 ns | 0.0630 ns | 0.1856 ns |  1.2096 ns |  0.92 |    0.13 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1667 ns | 0.0024 ns | 0.0023 ns |  1.1666 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6196 ns | 0.0028 ns | 0.0025 ns |  1.6189 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9006 ns | 0.0030 ns | 0.0025 ns |  1.9006 ns |  1.34 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.7204 ns | 0.0035 ns | 0.0032 ns |  0.7200 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.4506 ns | 0.0022 ns | 0.0020 ns |  0.4506 ns |  0.63 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6428 ns | 0.0027 ns | 0.0026 ns |  0.6423 ns |  0.89 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7433 ns | 0.0041 ns | 0.0038 ns |  0.7431 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7275 ns | 0.0026 ns | 0.0020 ns |  0.7274 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1766 ns | 0.0016 ns | 0.0014 ns |  1.1765 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.9052 ns | 0.0020 ns | 0.0018 ns |  0.9050 ns |  0.77 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1761 ns | 0.0104 ns | 0.0097 ns |  1.1702 ns |  1.00 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6210 ns | 0.0038 ns | 0.0036 ns |  1.6218 ns |  1.38 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6260 ns | 0.0028 ns | 0.0026 ns |  1.6259 ns |  1.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7178 ns | 0.0026 ns | 0.0025 ns |  0.7177 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.4673 ns | 0.0078 ns | 0.0069 ns |  0.4695 ns |  0.65 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7044 ns | 0.0031 ns | 0.0029 ns |  0.7040 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  0.7176 ns | 0.0020 ns | 0.0017 ns |  0.7176 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7068 ns | 0.0023 ns | 0.0020 ns |  0.7069 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.0610 ns | 0.0020 ns | 0.0019 ns |  1.0606 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.8817 ns | 0.0027 ns | 0.0025 ns |  0.8809 ns |  0.83 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.9527 ns | 0.0022 ns | 0.0020 ns |  0.9522 ns |  0.90 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.3937 ns | 0.0019 ns | 0.0018 ns |  1.3943 ns |  1.31 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.4005 ns | 0.0021 ns | 0.0018 ns |  1.4012 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.2178 ns | 0.0020 ns | 0.0016 ns |  1.2185 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.2748 ns | 0.0033 ns | 0.0027 ns |  1.2743 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6264 ns | 0.0069 ns | 0.0065 ns |  0.6256 ns |  0.51 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.5862 ns | 0.0027 ns | 0.0025 ns |  1.5857 ns |  1.30 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.4687 ns | 0.0027 ns | 0.0024 ns |  1.4681 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.7244 ns | 0.0041 ns | 0.0036 ns |  1.7245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.6360 ns | 0.0144 ns | 0.0135 ns |  1.6447 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.8535 ns | 0.0031 ns | 0.0027 ns |  0.8541 ns |  0.49 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.2720 ns | 0.0044 ns | 0.0039 ns |  2.2720 ns |  1.32 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.2725 ns | 0.0041 ns | 0.0036 ns |  2.2718 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.6350 ns | 0.0036 ns | 0.0034 ns |  1.6348 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.6198 ns | 0.0234 ns | 0.0219 ns |  1.6122 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.8670 ns | 0.0047 ns | 0.0039 ns |  1.8665 ns |  1.14 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.5620 ns | 0.0029 ns | 0.0025 ns |  1.5622 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.5659 ns | 0.0018 ns | 0.0017 ns |  1.5656 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.3815 ns | 0.0061 ns | 0.0057 ns |  2.3822 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  4.9532 ns | 0.0407 ns | 0.0381 ns |  4.9748 ns |  2.08 |    0.02 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.5658 ns | 0.0166 ns | 0.0156 ns |  2.5748 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.5915 ns | 0.0119 ns | 0.0093 ns |  2.5914 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.5898 ns | 0.0073 ns | 0.0069 ns |  2.5894 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8671 ns | 0.0028 ns | 0.0025 ns |  1.8672 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.4884 ns | 0.0034 ns | 0.0032 ns |  1.4887 ns |  0.80 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.9157 ns | 0.0044 ns | 0.0042 ns |  1.9160 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.5859 ns | 0.0023 ns | 0.0020 ns |  1.5861 ns |  0.85 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.5919 ns | 0.0032 ns | 0.0030 ns |  1.5923 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.8869 ns | 0.0081 ns | 0.0076 ns |  2.8852 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.6865 ns | 0.0065 ns | 0.0057 ns |  2.6885 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  3.3070 ns | 0.0080 ns | 0.0075 ns |  3.3068 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0420 ns | 0.0036 ns | 0.0032 ns |  3.0413 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0454 ns | 0.0070 ns | 0.0066 ns |  3.0455 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5021 ns | 0.0045 ns | 0.0043 ns |  3.5019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4464 ns | 0.0300 ns | 0.0281 ns |  3.4267 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.4261 ns | 0.0237 ns | 0.0222 ns |  3.4145 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.3966 ns | 0.0045 ns | 0.0042 ns |  3.3955 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5614 ns | 0.0946 ns | 0.0885 ns |  3.5421 ns |  1.02 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  2.8984 ns | 0.0082 ns | 0.0068 ns |  2.8972 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.0050 ns | 0.0043 ns | 0.0040 ns |  3.0067 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.2273 ns | 0.0066 ns | 0.0062 ns |  3.2262 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.4089 ns | 0.0070 ns | 0.0065 ns |  3.4098 ns |  1.18 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.4146 ns | 0.0033 ns | 0.0031 ns |  3.4153 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.3742 ns | 0.0038 ns | 0.0035 ns |  2.3736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.5358 ns | 0.0064 ns | 0.0057 ns |  2.5351 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.7939 ns | 0.0051 ns | 0.0048 ns |  2.7935 ns |  1.18 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.3145 ns | 0.0163 ns | 0.0136 ns |  2.3113 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.3116 ns | 0.0032 ns | 0.0027 ns |  2.3113 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  3.5103 ns | 0.0045 ns | 0.0040 ns |  3.5099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.5628 ns | 0.0235 ns | 0.0220 ns |  3.5483 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.5805 ns | 0.0218 ns | 0.0204 ns |  3.5714 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  3.6160 ns | 0.0068 ns | 0.0064 ns |  3.6154 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  3.6133 ns | 0.0046 ns | 0.0043 ns |  3.6143 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.7259 ns | 0.0086 ns | 0.0080 ns | 12.7273 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.0226 ns | 0.0126 ns | 0.0118 ns | 13.0216 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.8250 ns | 0.0074 ns | 0.0065 ns |  5.8259 ns |  0.46 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  7.1779 ns | 0.0074 ns | 0.0066 ns |  7.1776 ns |  0.56 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  7.4910 ns | 0.0073 ns | 0.0068 ns |  7.4901 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.5119 ns | 0.0252 ns | 0.0236 ns | 23.5145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.5136 ns | 0.0515 ns | 0.0482 ns | 23.5107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.6559 ns | 0.1377 ns | 0.1288 ns | 12.6849 ns |  0.54 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 17.5530 ns | 0.0107 ns | 0.0095 ns | 17.5544 ns |  0.75 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 17.3362 ns | 0.0170 ns | 0.0151 ns | 17.3369 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.7161 ns | 0.0020 ns | 0.0017 ns |  0.7162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.4471 ns | 0.0116 ns | 0.0108 ns |  0.4398 ns |  0.62 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6344 ns | 0.0026 ns | 0.0023 ns |  0.6349 ns |  0.89 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6613 ns | 0.0020 ns | 0.0018 ns |  0.6611 ns |  0.92 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6672 ns | 0.0029 ns | 0.0028 ns |  0.6677 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.9661 ns | 0.0051 ns | 0.0048 ns |  1.9656 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4047 ns | 0.0036 ns | 0.0034 ns |  1.4047 ns |  0.71 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.2373 ns | 0.0035 ns | 0.0032 ns |  1.2372 ns |  0.63 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.5514 ns | 0.0028 ns | 0.0025 ns |  1.5513 ns |  0.79 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.3970 ns | 0.0025 ns | 0.0023 ns |  1.3967 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2306 ns | 0.0025 ns | 0.0022 ns |  2.2306 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2181 ns | 0.0056 ns | 0.0046 ns |  2.2181 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.0728 ns | 0.0137 ns | 0.0128 ns |  2.0774 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2291 ns | 0.0136 ns | 0.0113 ns |  2.2285 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2116 ns | 0.0035 ns | 0.0029 ns |  2.2119 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.0126 ns | 0.0646 ns | 0.0540 ns | 46.0280 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 40.4281 ns | 0.2219 ns | 0.2076 ns | 40.5619 ns |  0.88 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  9.5733 ns | 0.0136 ns | 0.0120 ns |  9.5770 ns |  0.21 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 44.8793 ns | 0.0889 ns | 0.0831 ns | 44.9018 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 44.8831 ns | 0.1181 ns | 0.1047 ns | 44.8954 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7155 ns | 0.0024 ns | 0.0023 ns |  0.7158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.4383 ns | 0.0017 ns | 0.0015 ns |  0.4378 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6157 ns | 0.0023 ns | 0.0022 ns |  0.6156 ns |  0.86 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.6617 ns | 0.0020 ns | 0.0019 ns |  0.6607 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.6633 ns | 0.0030 ns | 0.0027 ns |  0.6634 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1772 ns | 0.0023 ns | 0.0021 ns |  1.1775 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9051 ns | 0.0023 ns | 0.0021 ns |  0.9047 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0781 ns | 0.0026 ns | 0.0024 ns |  1.0781 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6017 ns | 0.0018 ns | 0.0016 ns |  1.6021 ns |  1.36 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.5788 ns | 0.0024 ns | 0.0023 ns |  1.5790 ns |  1.34 |    0.00 |     - |     - |     - |         - |
