
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 0.9521 ns | 0.0041 ns | 0.0038 ns | 0.9513 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 1.1454 ns | 0.0024 ns | 0.0023 ns | 1.1453 ns |  1.20 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 0.9647 ns | 0.0054 ns | 0.0048 ns | 0.9647 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 0.8841 ns | 0.0025 ns | 0.0023 ns | 0.8845 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 1.1420 ns | 0.0074 ns | 0.0062 ns | 1.1413 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 0.9787 ns | 0.0035 ns | 0.0033 ns | 0.9788 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 1.7102 ns | 0.0605 ns | 0.0536 ns | 1.7243 ns |  1.75 |    0.06 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 1.1860 ns | 0.0018 ns | 0.0015 ns | 1.1864 ns |  1.21 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 1.9265 ns | 0.0035 ns | 0.0031 ns | 1.9270 ns |  1.97 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 2.0042 ns | 0.0023 ns | 0.0022 ns | 2.0043 ns |  2.05 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 0.6931 ns | 0.0034 ns | 0.0032 ns | 0.6930 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 0.9249 ns | 0.0023 ns | 0.0022 ns | 0.9250 ns |  1.33 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 1.3326 ns | 0.0019 ns | 0.0017 ns | 1.3326 ns |  1.92 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 | 0.6220 ns | 0.0025 ns | 0.0023 ns | 0.6224 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 | 0.7073 ns | 0.0026 ns | 0.0024 ns | 0.7077 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 0.6925 ns | 0.0041 ns | 0.0038 ns | 0.6922 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 0.9669 ns | 0.0024 ns | 0.0022 ns | 0.9672 ns |  1.40 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 0.7862 ns | 0.0063 ns | 0.0053 ns | 0.7877 ns |  1.14 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 0.9058 ns | 0.0136 ns | 0.0127 ns | 0.9137 ns |  1.31 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 1.0085 ns | 0.0029 ns | 0.0026 ns | 1.0085 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 0.5807 ns | 0.0026 ns | 0.0023 ns | 0.5804 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 0.9560 ns | 0.0061 ns | 0.0054 ns | 0.9570 ns |  1.65 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 0.6956 ns | 0.0026 ns | 0.0023 ns | 0.6950 ns |  1.20 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 0.5826 ns | 0.0036 ns | 0.0032 ns | 0.5824 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 0.7328 ns | 0.0050 ns | 0.0047 ns | 0.7340 ns |  1.26 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 0.9911 ns | 0.0019 ns | 0.0017 ns | 0.9914 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.1920 ns | 0.0022 ns | 0.0020 ns | 1.1922 ns |  1.20 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 0.9433 ns | 0.0036 ns | 0.0032 ns | 0.9437 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 1.9275 ns | 0.0055 ns | 0.0046 ns | 1.9290 ns |  1.94 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.9534 ns | 0.0052 ns | 0.0049 ns | 1.9534 ns |  1.97 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 0.7186 ns | 0.0032 ns | 0.0028 ns | 0.7182 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 0.7145 ns | 0.0030 ns | 0.0025 ns | 0.7153 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 0.5826 ns | 0.0026 ns | 0.0023 ns | 0.5824 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 0.6876 ns | 0.0064 ns | 0.0059 ns | 0.6889 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 | 0.9444 ns | 0.0029 ns | 0.0024 ns | 0.9443 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.0004 ns | 0.0026 ns | 0.0024 ns | 1.0001 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 0.9425 ns | 0.0019 ns | 0.0018 ns | 0.9424 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 0.9750 ns | 0.0030 ns | 0.0028 ns | 0.9749 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 1.9271 ns | 0.0041 ns | 0.0038 ns | 1.9281 ns |  1.93 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 1.9784 ns | 0.0034 ns | 0.0030 ns | 1.9782 ns |  1.98 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 0.6097 ns | 0.0028 ns | 0.0026 ns | 0.6093 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 0.6938 ns | 0.0059 ns | 0.0049 ns | 0.6925 ns |  1.14 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 0.5780 ns | 0.0026 ns | 0.0023 ns | 0.5788 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 | 0.6476 ns | 0.0026 ns | 0.0022 ns | 0.6476 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 | 0.9291 ns | 0.0024 ns | 0.0023 ns | 0.9290 ns |  1.52 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 0.9906 ns | 0.0034 ns | 0.0031 ns | 0.9896 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.1724 ns | 0.0032 ns | 0.0030 ns | 1.1723 ns |  1.18 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.0990 ns | 0.0025 ns | 0.0024 ns | 1.0989 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 1.9064 ns | 0.0157 ns | 0.0147 ns | 1.9124 ns |  1.92 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 1.9513 ns | 0.0155 ns | 0.0145 ns | 1.9557 ns |  1.97 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 0.6929 ns | 0.0039 ns | 0.0033 ns | 0.6919 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 0.9446 ns | 0.0055 ns | 0.0048 ns | 0.9447 ns |  1.36 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 0.7039 ns | 0.0077 ns | 0.0072 ns | 0.7061 ns |  1.02 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 0.6352 ns | 0.0021 ns | 0.0017 ns | 0.6348 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 | 0.6931 ns | 0.0033 ns | 0.0026 ns | 0.6937 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 0.9879 ns | 0.0036 ns | 0.0032 ns | 0.9877 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.4082 ns | 0.0034 ns | 0.0032 ns | 1.4080 ns |  1.43 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.1700 ns | 0.0030 ns | 0.0026 ns | 1.1702 ns |  1.18 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.9217 ns | 0.0203 ns | 0.0180 ns | 1.9299 ns |  1.95 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.9599 ns | 0.0165 ns | 0.0146 ns | 1.9524 ns |  1.98 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 0.5544 ns | 0.0028 ns | 0.0026 ns | 0.5537 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 0.9448 ns | 0.0022 ns | 0.0019 ns | 0.9448 ns |  1.70 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 0.7232 ns | 0.0018 ns | 0.0016 ns | 0.7228 ns |  1.30 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 | 0.6044 ns | 0.0104 ns | 0.0097 ns | 0.6020 ns |  1.09 |    0.02 |     - |     - |     - |         - |
              FromInt |        net472 | 0.7332 ns | 0.0124 ns | 0.0116 ns | 0.7277 ns |  1.32 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 1.0077 ns | 0.0036 ns | 0.0032 ns | 1.0075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.1990 ns | 0.0043 ns | 0.0041 ns | 1.1989 ns |  1.19 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.1177 ns | 0.0034 ns | 0.0030 ns | 1.1174 ns |  1.11 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 1.8811 ns | 0.0042 ns | 0.0040 ns | 1.8812 ns |  1.87 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 1.9119 ns | 0.0042 ns | 0.0040 ns | 1.9124 ns |  1.90 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 0.7156 ns | 0.0033 ns | 0.0029 ns | 0.7147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 1.0425 ns | 0.0022 ns | 0.0021 ns | 1.0423 ns |  1.46 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 0.7417 ns | 0.0104 ns | 0.0087 ns | 0.7453 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 0.9430 ns | 0.0021 ns | 0.0018 ns | 0.9433 ns |  1.32 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 0.9326 ns | 0.0108 ns | 0.0101 ns | 0.9377 ns |  1.30 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.0148 ns | 0.0023 ns | 0.0021 ns | 1.0149 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.1920 ns | 0.0030 ns | 0.0028 ns | 1.1912 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 1.1247 ns | 0.0031 ns | 0.0029 ns | 1.1248 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 1.9056 ns | 0.0053 ns | 0.0047 ns | 1.9070 ns |  1.88 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 1.9153 ns | 0.0041 ns | 0.0038 ns | 1.9164 ns |  1.89 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 0.6265 ns | 0.0013 ns | 0.0011 ns | 0.6268 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 0.9347 ns | 0.0040 ns | 0.0035 ns | 0.9343 ns |  1.49 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 0.7489 ns | 0.0026 ns | 0.0023 ns | 0.7491 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 0.7079 ns | 0.0128 ns | 0.0120 ns | 0.7148 ns |  1.13 |    0.02 |     - |     - |     - |         - |
             FromLong |        net472 | 0.7114 ns | 0.0037 ns | 0.0033 ns | 0.7102 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.7599 ns | 0.0076 ns | 0.0067 ns | 1.7616 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.4679 ns | 0.0036 ns | 0.0031 ns | 1.4684 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.6602 ns | 0.0029 ns | 0.0027 ns | 1.6599 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 2.1149 ns | 0.0036 ns | 0.0034 ns | 2.1143 ns |  1.20 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 2.1291 ns | 0.0276 ns | 0.0258 ns | 2.1407 ns |  1.21 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 0.9281 ns | 0.0024 ns | 0.0022 ns | 0.9280 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 1.1985 ns | 0.0025 ns | 0.0024 ns | 1.1989 ns |  1.29 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 0.7536 ns | 0.0022 ns | 0.0021 ns | 0.7538 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 0.9175 ns | 0.0026 ns | 0.0024 ns | 0.9178 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 0.9660 ns | 0.0072 ns | 0.0060 ns | 0.9657 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 1.5291 ns | 0.0028 ns | 0.0026 ns | 1.5299 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.6361 ns | 0.0082 ns | 0.0077 ns | 1.6342 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.6941 ns | 0.0101 ns | 0.0079 ns | 1.6961 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 2.1043 ns | 0.0044 ns | 0.0041 ns | 2.1036 ns |  1.38 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 2.3506 ns | 0.0153 ns | 0.0143 ns | 2.3539 ns |  1.54 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 0.7319 ns | 0.0079 ns | 0.0066 ns | 0.7329 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 0.7417 ns | 0.0024 ns | 0.0022 ns | 0.7414 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 0.7331 ns | 0.0026 ns | 0.0024 ns | 0.7337 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 0.9428 ns | 0.0036 ns | 0.0028 ns | 0.9432 ns |  1.29 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 | 0.9358 ns | 0.0028 ns | 0.0025 ns | 0.9364 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 1.0127 ns | 0.0029 ns | 0.0026 ns | 1.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 1.1987 ns | 0.0032 ns | 0.0025 ns | 1.1991 ns |  1.18 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 1.1381 ns | 0.0022 ns | 0.0020 ns | 1.1381 ns |  1.12 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 2.4793 ns | 0.0026 ns | 0.0024 ns | 2.4798 ns |  2.45 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 2.0615 ns | 0.0049 ns | 0.0038 ns | 2.0614 ns |  2.04 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 0.9640 ns | 0.0022 ns | 0.0020 ns | 0.9638 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 0.9311 ns | 0.0029 ns | 0.0026 ns | 0.9320 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 0.5878 ns | 0.0023 ns | 0.0022 ns | 0.5876 ns |  0.61 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 0.7133 ns | 0.0030 ns | 0.0028 ns | 0.7144 ns |  0.74 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 0.7164 ns | 0.0121 ns | 0.0108 ns | 0.7128 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.1561 ns | 0.0030 ns | 0.0028 ns | 1.1555 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.1301 ns | 0.0025 ns | 0.0023 ns | 1.1304 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.6870 ns | 0.0037 ns | 0.0035 ns | 1.6870 ns |  1.46 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.1876 ns | 0.0077 ns | 0.0072 ns | 1.1857 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.1331 ns | 0.0052 ns | 0.0048 ns | 1.1325 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 8.3879 ns | 0.0284 ns | 0.0221 ns | 8.3922 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 8.3006 ns | 0.0567 ns | 0.0503 ns | 8.3111 ns |  0.99 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 5.2546 ns | 0.0104 ns | 0.0087 ns | 5.2538 ns |  0.63 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 7.9900 ns | 0.0152 ns | 0.0142 ns | 7.9864 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 7.9904 ns | 0.0152 ns | 0.0135 ns | 7.9891 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 8.1656 ns | 0.0141 ns | 0.0132 ns | 8.1642 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 8.7184 ns | 0.0149 ns | 0.0132 ns | 8.7204 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 3.1366 ns | 0.0899 ns | 0.1775 ns | 3.1901 ns |  0.37 |    0.04 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 8.6397 ns | 0.0288 ns | 0.0255 ns | 8.6365 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 8.5516 ns | 0.0684 ns | 0.0640 ns | 8.5804 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 0.6909 ns | 0.0019 ns | 0.0017 ns | 0.6911 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 0.7575 ns | 0.0027 ns | 0.0024 ns | 0.7576 ns |  1.10 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 | 0.7412 ns | 0.0040 ns | 0.0031 ns | 0.7416 ns |  1.07 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 0.9142 ns | 0.0033 ns | 0.0029 ns | 0.9138 ns |  1.32 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 | 0.9578 ns | 0.0025 ns | 0.0023 ns | 0.9580 ns |  1.39 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.4802 ns | 0.0034 ns | 0.0031 ns | 1.4813 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.6363 ns | 0.0037 ns | 0.0034 ns | 1.6364 ns |  1.11 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.4215 ns | 0.0028 ns | 0.0026 ns | 1.4214 ns |  0.96 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.6676 ns | 0.0060 ns | 0.0056 ns | 1.6682 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.6225 ns | 0.0046 ns | 0.0041 ns | 1.6239 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 3.1794 ns | 0.0139 ns | 0.0123 ns | 3.1760 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 3.1483 ns | 0.0039 ns | 0.0037 ns | 3.1481 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 2.8306 ns | 0.0165 ns | 0.0129 ns | 2.8262 ns |  0.89 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 3.3424 ns | 0.0058 ns | 0.0054 ns | 3.3433 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 2.9590 ns | 0.0078 ns | 0.0073 ns | 2.9601 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 1.9102 ns | 0.0033 ns | 0.0030 ns | 1.9110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 1.9943 ns | 0.0036 ns | 0.0031 ns | 1.9943 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.8384 ns | 0.0036 ns | 0.0034 ns | 1.8390 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 1.9339 ns | 0.0104 ns | 0.0086 ns | 1.9328 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 1.9995 ns | 0.0175 ns | 0.0164 ns | 1.9935 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 0.7123 ns | 0.0024 ns | 0.0022 ns | 0.7113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 1.0611 ns | 0.0029 ns | 0.0027 ns | 1.0611 ns |  1.49 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 0.7269 ns | 0.0023 ns | 0.0021 ns | 0.7272 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 | 0.7093 ns | 0.0023 ns | 0.0021 ns | 0.7097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 0.7221 ns | 0.0126 ns | 0.0112 ns | 0.7266 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 1.0211 ns | 0.0050 ns | 0.0042 ns | 1.0225 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 1.1815 ns | 0.0014 ns | 0.0013 ns | 1.1819 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 1.1299 ns | 0.0034 ns | 0.0032 ns | 1.1299 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 1.9106 ns | 0.0032 ns | 0.0028 ns | 1.9113 ns |  1.87 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 1.9283 ns | 0.0067 ns | 0.0063 ns | 1.9292 ns |  1.89 |    0.01 |     - |     - |     - |         - |
