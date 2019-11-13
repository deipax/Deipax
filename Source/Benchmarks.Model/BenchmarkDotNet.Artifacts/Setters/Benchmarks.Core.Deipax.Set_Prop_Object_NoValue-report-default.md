
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 3.950 ns | 0.0110 ns | 0.0103 ns | 3.950 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 2.2 | 4.271 ns | 0.0138 ns | 0.0122 ns | 4.272 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 3.0 | 4.288 ns | 0.0409 ns | 0.0383 ns | 4.285 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool |        net461 | 4.005 ns | 0.0740 ns | 0.0656 ns | 3.975 ns |  1.01 |    0.02 | 0.0038 |     - |     - |      24 B |
             FromBool |        net472 | 3.847 ns | 0.0295 ns | 0.0276 ns | 3.853 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 1.243 ns | 0.0125 ns | 0.0111 ns | 1.247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 1.139 ns | 0.0022 ns | 0.0018 ns | 1.139 ns |  0.92 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 1.058 ns | 0.0069 ns | 0.0057 ns | 1.060 ns |  0.85 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net461 | 1.158 ns | 0.0030 ns | 0.0026 ns | 1.158 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net472 | 1.154 ns | 0.0062 ns | 0.0058 ns | 1.153 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 | 4.010 ns | 0.0168 ns | 0.0141 ns | 4.005 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 2.2 | 4.280 ns | 0.0115 ns | 0.0102 ns | 4.279 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 3.0 | 4.573 ns | 0.0215 ns | 0.0201 ns | 4.579 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 | 4.192 ns | 0.1120 ns | 0.0874 ns | 4.159 ns |  1.05 |    0.02 | 0.0038 |     - |     - |      24 B |
             FromChar |        net472 | 3.922 ns | 0.0998 ns | 0.0933 ns | 3.908 ns |  0.98 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 | 1.269 ns | 0.0046 ns | 0.0043 ns | 1.267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 1.287 ns | 0.0041 ns | 0.0039 ns | 1.286 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 1.301 ns | 0.0044 ns | 0.0041 ns | 1.300 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     FromCharNullable |        net461 | 1.312 ns | 0.0036 ns | 0.0030 ns | 1.311 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net472 | 1.268 ns | 0.0089 ns | 0.0084 ns | 1.269 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 | 3.976 ns | 0.0140 ns | 0.0131 ns | 3.978 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 2.2 | 4.341 ns | 0.0166 ns | 0.0156 ns | 4.345 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 3.0 | 4.373 ns | 0.0372 ns | 0.0348 ns | 4.362 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte |        net461 | 3.899 ns | 0.0681 ns | 0.0604 ns | 3.901 ns |  0.98 |    0.02 | 0.0038 |     - |     - |      24 B |
            FromSByte |        net472 | 3.842 ns | 0.0341 ns | 0.0319 ns | 3.855 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.238 ns | 0.0045 ns | 0.0035 ns | 1.238 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.186 ns | 0.0023 ns | 0.0021 ns | 1.185 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 1.076 ns | 0.0038 ns | 0.0029 ns | 1.076 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net461 | 1.170 ns | 0.0233 ns | 0.0195 ns | 1.168 ns |  0.94 |    0.02 |      - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.120 ns | 0.0072 ns | 0.0063 ns | 1.120 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 | 3.952 ns | 0.0382 ns | 0.0358 ns | 3.945 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 2.2 | 4.250 ns | 0.0047 ns | 0.0042 ns | 4.249 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 3.0 | 4.288 ns | 0.0401 ns | 0.0313 ns | 4.288 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte |        net461 | 3.921 ns | 0.0772 ns | 0.0684 ns | 3.932 ns |  0.99 |    0.02 | 0.0038 |     - |     - |      24 B |
             FromByte |        net472 | 3.856 ns | 0.0544 ns | 0.0509 ns | 3.862 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.232 ns | 0.0033 ns | 0.0029 ns | 1.233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 1.139 ns | 0.0047 ns | 0.0042 ns | 1.138 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 1.055 ns | 0.0059 ns | 0.0046 ns | 1.054 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net461 | 1.178 ns | 0.0075 ns | 0.0070 ns | 1.182 ns |  0.96 |    0.01 |      - |     - |     - |         - |
     FromByteNullable |        net472 | 1.121 ns | 0.0071 ns | 0.0066 ns | 1.120 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 | 3.972 ns | 0.0149 ns | 0.0132 ns | 3.974 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 2.2 | 4.312 ns | 0.0180 ns | 0.0169 ns | 4.312 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 3.0 | 4.729 ns | 0.0881 ns | 0.0824 ns | 4.700 ns |  1.19 |    0.02 | 0.0038 |     - |     - |      24 B |
            FromShort |        net461 | 3.838 ns | 0.0139 ns | 0.0124 ns | 3.836 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort |        net472 | 3.791 ns | 0.0243 ns | 0.0203 ns | 3.789 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.276 ns | 0.0070 ns | 0.0065 ns | 1.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.285 ns | 0.0032 ns | 0.0030 ns | 1.285 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.317 ns | 0.0141 ns | 0.0118 ns | 1.318 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net461 | 1.295 ns | 0.0084 ns | 0.0070 ns | 1.294 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net472 | 1.279 ns | 0.0526 ns | 0.0492 ns | 1.254 ns |  1.00 |    0.04 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 | 3.933 ns | 0.0205 ns | 0.0192 ns | 3.940 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 2.2 | 4.259 ns | 0.0080 ns | 0.0067 ns | 4.259 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 3.0 | 4.387 ns | 0.0252 ns | 0.0224 ns | 4.380 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromUShort |        net461 | 4.055 ns | 0.0626 ns | 0.0586 ns | 4.060 ns |  1.03 |    0.02 | 0.0038 |     - |     - |      24 B |
           FromUShort |        net472 | 4.327 ns | 0.1035 ns | 0.0968 ns | 4.297 ns |  1.10 |    0.03 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.292 ns | 0.0051 ns | 0.0048 ns | 1.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.289 ns | 0.0051 ns | 0.0048 ns | 1.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.320 ns | 0.0254 ns | 0.0238 ns | 1.326 ns |  1.02 |    0.02 |      - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.298 ns | 0.0080 ns | 0.0071 ns | 1.297 ns |  1.00 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.263 ns | 0.0098 ns | 0.0087 ns | 1.261 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 | 3.971 ns | 0.0083 ns | 0.0073 ns | 3.971 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 2.2 | 4.337 ns | 0.0109 ns | 0.0085 ns | 4.338 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 3.0 | 4.461 ns | 0.0744 ns | 0.0660 ns | 4.484 ns |  1.12 |    0.02 | 0.0038 |     - |     - |      24 B |
              FromInt |        net461 | 3.954 ns | 0.0164 ns | 0.0146 ns | 3.955 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
              FromInt |        net472 | 4.496 ns | 0.0387 ns | 0.0362 ns | 4.490 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 | 1.286 ns | 0.0031 ns | 0.0027 ns | 1.285 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.286 ns | 0.0038 ns | 0.0035 ns | 1.286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.336 ns | 0.0134 ns | 0.0112 ns | 1.336 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      FromIntNullable |        net461 | 1.307 ns | 0.0053 ns | 0.0049 ns | 1.306 ns |  1.02 |    0.00 |      - |     - |     - |         - |
      FromIntNullable |        net472 | 1.280 ns | 0.0083 ns | 0.0077 ns | 1.283 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 | 4.061 ns | 0.0189 ns | 0.0168 ns | 4.061 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 2.2 | 4.375 ns | 0.0127 ns | 0.0119 ns | 4.371 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 3.0 | 4.414 ns | 0.0431 ns | 0.0382 ns | 4.404 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt |        net461 | 3.933 ns | 0.0193 ns | 0.0171 ns | 3.940 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromUInt |        net472 | 4.132 ns | 0.0323 ns | 0.0302 ns | 4.124 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.268 ns | 0.0046 ns | 0.0043 ns | 1.268 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.288 ns | 0.0046 ns | 0.0043 ns | 1.288 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 1.342 ns | 0.0171 ns | 0.0160 ns | 1.336 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net461 | 1.279 ns | 0.0139 ns | 0.0130 ns | 1.278 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net472 | 1.261 ns | 0.0045 ns | 0.0040 ns | 1.262 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 | 3.962 ns | 0.0198 ns | 0.0186 ns | 3.967 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 2.2 | 4.564 ns | 0.0143 ns | 0.0127 ns | 4.562 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 3.0 | 4.490 ns | 0.0691 ns | 0.0646 ns | 4.510 ns |  1.13 |    0.02 | 0.0038 |     - |     - |      24 B |
             FromLong |        net461 | 4.122 ns | 0.1150 ns | 0.1181 ns | 4.075 ns |  1.04 |    0.03 | 0.0038 |     - |     - |      24 B |
             FromLong |        net472 | 4.010 ns | 0.0320 ns | 0.0299 ns | 4.018 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.649 ns | 0.0045 ns | 0.0040 ns | 1.649 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.641 ns | 0.0075 ns | 0.0070 ns | 1.642 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.696 ns | 0.0052 ns | 0.0049 ns | 1.697 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net461 | 1.475 ns | 0.0044 ns | 0.0039 ns | 1.476 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net472 | 1.488 ns | 0.0028 ns | 0.0023 ns | 1.488 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 | 3.974 ns | 0.0204 ns | 0.0191 ns | 3.976 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 2.2 | 4.654 ns | 0.0084 ns | 0.0074 ns | 4.655 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 3.0 | 4.498 ns | 0.0889 ns | 0.0788 ns | 4.495 ns |  1.13 |    0.02 | 0.0038 |     - |     - |      24 B |
            FromULong |        net461 | 4.046 ns | 0.0651 ns | 0.0609 ns | 4.059 ns |  1.02 |    0.02 | 0.0038 |     - |     - |      24 B |
            FromULong |        net472 | 5.310 ns | 0.0116 ns | 0.0091 ns | 5.310 ns |  1.34 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 | 1.475 ns | 0.0037 ns | 0.0035 ns | 1.475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.589 ns | 0.0050 ns | 0.0047 ns | 1.589 ns |  1.08 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.577 ns | 0.0076 ns | 0.0071 ns | 1.577 ns |  1.07 |    0.01 |      - |     - |     - |         - |
    FromULongNullable |        net461 | 1.481 ns | 0.0053 ns | 0.0047 ns | 1.482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net472 | 1.518 ns | 0.0152 ns | 0.0142 ns | 1.523 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 | 4.052 ns | 0.0171 ns | 0.0160 ns | 4.056 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 2.2 | 4.527 ns | 0.0100 ns | 0.0084 ns | 4.527 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 3.0 | 5.643 ns | 0.1023 ns | 0.0957 ns | 5.642 ns |  1.39 |    0.02 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 | 4.053 ns | 0.1001 ns | 0.0936 ns | 3.996 ns |  1.00 |    0.02 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net472 | 3.812 ns | 0.0107 ns | 0.0095 ns | 3.809 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 1.300 ns | 0.0049 ns | 0.0039 ns | 1.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 1.304 ns | 0.0076 ns | 0.0072 ns | 1.305 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 1.305 ns | 0.0075 ns | 0.0070 ns | 1.306 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    FromFloatNullable |        net461 | 1.242 ns | 0.0050 ns | 0.0047 ns | 1.242 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net472 | 1.239 ns | 0.0048 ns | 0.0045 ns | 1.238 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 3.946 ns | 0.0150 ns | 0.0133 ns | 3.949 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 2.2 | 4.420 ns | 0.0066 ns | 0.0052 ns | 4.419 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 3.0 | 4.623 ns | 0.0882 ns | 0.0825 ns | 4.598 ns |  1.17 |    0.02 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 3.883 ns | 0.0898 ns | 0.0840 ns | 3.904 ns |  0.98 |    0.02 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net472 | 3.808 ns | 0.0285 ns | 0.0253 ns | 3.808 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.509 ns | 0.0068 ns | 0.0063 ns | 1.510 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.824 ns | 0.0044 ns | 0.0039 ns | 1.823 ns |  1.21 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.802 ns | 0.0087 ns | 0.0077 ns | 1.802 ns |  1.19 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.637 ns | 0.0277 ns | 0.0259 ns | 1.648 ns |  1.08 |    0.02 |      - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.742 ns | 0.0055 ns | 0.0052 ns | 1.742 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 | 5.171 ns | 0.0055 ns | 0.0049 ns | 5.172 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 | 5.677 ns | 0.0099 ns | 0.0088 ns | 5.679 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 | 6.232 ns | 0.0225 ns | 0.0199 ns | 6.226 ns |  1.21 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net461 | 5.410 ns | 0.0207 ns | 0.0184 ns | 5.412 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 | 5.376 ns | 0.0112 ns | 0.0093 ns | 5.374 ns |  1.04 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 2.205 ns | 0.0031 ns | 0.0029 ns | 2.205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 1.634 ns | 0.0035 ns | 0.0031 ns | 1.633 ns |  0.74 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 1.730 ns | 0.0041 ns | 0.0038 ns | 1.730 ns |  0.78 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable |        net461 | 2.090 ns | 0.0040 ns | 0.0036 ns | 2.090 ns |  0.95 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable |        net472 | 1.671 ns | 0.0176 ns | 0.0164 ns | 1.677 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 4.200 ns | 0.0275 ns | 0.0230 ns | 4.198 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 2.2 | 4.379 ns | 0.0099 ns | 0.0093 ns | 4.378 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 3.0 | 4.510 ns | 0.0313 ns | 0.0292 ns | 4.516 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime |        net461 | 4.045 ns | 0.0802 ns | 0.0751 ns | 4.019 ns |  0.96 |    0.02 | 0.0038 |     - |     - |      24 B |
         FromDateTime |        net472 | 3.893 ns | 0.0088 ns | 0.0078 ns | 3.890 ns |  0.93 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.455 ns | 0.0042 ns | 0.0037 ns | 1.456 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.648 ns | 0.0064 ns | 0.0060 ns | 1.647 ns |  1.13 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.717 ns | 0.0138 ns | 0.0129 ns | 1.716 ns |  1.18 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.883 ns | 0.0053 ns | 0.0047 ns | 1.883 ns |  1.29 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.761 ns | 0.0080 ns | 0.0071 ns | 1.760 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 | 1.847 ns | 0.0057 ns | 0.0053 ns | 1.848 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 1.709 ns | 0.0048 ns | 0.0042 ns | 1.709 ns |  0.92 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 1.541 ns | 0.0109 ns | 0.0102 ns | 1.543 ns |  0.83 |    0.01 |      - |     - |     - |         - |
           FromObject |        net461 | 1.620 ns | 0.0139 ns | 0.0130 ns | 1.616 ns |  0.88 |    0.01 |      - |     - |     - |         - |
           FromObject |        net472 | 1.368 ns | 0.0121 ns | 0.0113 ns | 1.371 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromString | .NET Core 2.0 | 2.103 ns | 0.0042 ns | 0.0040 ns | 2.103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 | 1.850 ns | 0.0047 ns | 0.0044 ns | 1.851 ns |  0.88 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.652 ns | 0.0066 ns | 0.0055 ns | 1.652 ns |  0.79 |    0.00 |      - |     - |     - |         - |
           FromString |        net461 | 2.432 ns | 0.0120 ns | 0.0112 ns | 2.429 ns |  1.16 |    0.01 |      - |     - |     - |         - |
           FromString |        net472 | 1.936 ns | 0.0047 ns | 0.0041 ns | 1.935 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 | 3.948 ns | 0.0151 ns | 0.0142 ns | 3.947 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 2.2 | 4.439 ns | 0.0136 ns | 0.0120 ns | 4.436 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 3.0 | 4.431 ns | 0.0411 ns | 0.0384 ns | 4.434 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net461 | 4.041 ns | 0.0139 ns | 0.0130 ns | 4.043 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net472 | 4.021 ns | 0.0232 ns | 0.0194 ns | 4.017 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 1.275 ns | 0.0048 ns | 0.0040 ns | 1.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 1.285 ns | 0.0040 ns | 0.0038 ns | 1.285 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 1.363 ns | 0.0080 ns | 0.0074 ns | 1.361 ns |  1.07 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable |        net461 | 1.372 ns | 0.0243 ns | 0.0227 ns | 1.380 ns |  1.08 |    0.02 |      - |     - |     - |         - |
     FromEnumNullable |        net472 | 1.269 ns | 0.0119 ns | 0.0112 ns | 1.265 ns |  0.99 |    0.01 |      - |     - |     - |         - |
