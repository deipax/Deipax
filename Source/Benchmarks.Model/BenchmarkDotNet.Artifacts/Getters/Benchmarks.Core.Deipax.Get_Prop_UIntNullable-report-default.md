
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.254 ns | 0.0046 ns | 0.0041 ns |  1.253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.602 ns | 0.0025 ns | 0.0022 ns |  1.602 ns |  1.28 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.634 ns | 0.0018 ns | 0.0016 ns |  1.634 ns |  1.30 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  1.192 ns | 0.0028 ns | 0.0025 ns |  1.192 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  1.184 ns | 0.0045 ns | 0.0042 ns |  1.184 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.227 ns | 0.0103 ns | 0.0096 ns |  4.227 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.410 ns | 0.0100 ns | 0.0078 ns |  4.408 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.410 ns | 0.0041 ns | 0.0039 ns |  4.409 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.888 ns | 0.0050 ns | 0.0044 ns |  4.888 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.863 ns | 0.0066 ns | 0.0055 ns |  4.863 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.732 ns | 0.0037 ns | 0.0029 ns |  1.732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.921 ns | 0.0020 ns | 0.0017 ns |  1.921 ns |  1.11 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.473 ns | 0.0031 ns | 0.0028 ns |  1.473 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.338 ns | 0.0052 ns | 0.0049 ns |  2.337 ns |  1.35 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.338 ns | 0.0046 ns | 0.0041 ns |  2.338 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.511 ns | 0.0198 ns | 0.0175 ns |  4.516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.397 ns | 0.0083 ns | 0.0077 ns |  4.397 ns |  0.97 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.246 ns | 0.0067 ns | 0.0056 ns |  4.245 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.296 ns | 0.0079 ns | 0.0070 ns |  5.296 ns |  1.17 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.331 ns | 0.0066 ns | 0.0059 ns |  5.332 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.458 ns | 0.0054 ns | 0.0048 ns |  1.459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.980 ns | 0.0038 ns | 0.0032 ns |  1.981 ns |  1.36 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.769 ns | 0.0127 ns | 0.0119 ns |  1.764 ns |  1.21 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.330 ns | 0.0039 ns | 0.0037 ns |  2.330 ns |  1.60 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.316 ns | 0.0049 ns | 0.0046 ns |  2.316 ns |  1.59 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.739 ns | 0.0048 ns | 0.0043 ns |  4.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.415 ns | 0.0082 ns | 0.0073 ns |  4.413 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.528 ns | 0.0042 ns | 0.0037 ns |  4.528 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.343 ns | 0.0332 ns | 0.0277 ns |  5.353 ns |  1.13 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.332 ns | 0.0071 ns | 0.0059 ns |  5.331 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.758 ns | 0.0039 ns | 0.0035 ns |  1.759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.822 ns | 0.0038 ns | 0.0035 ns |  1.821 ns |  1.04 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.570 ns | 0.0024 ns | 0.0020 ns |  1.570 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  2.409 ns | 0.0069 ns | 0.0061 ns |  2.410 ns |  1.37 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.404 ns | 0.0152 ns | 0.0135 ns |  2.410 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.463 ns | 0.0083 ns | 0.0074 ns |  4.461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.394 ns | 0.0080 ns | 0.0067 ns |  4.394 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.248 ns | 0.0086 ns | 0.0076 ns |  4.249 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.296 ns | 0.0087 ns | 0.0078 ns |  5.295 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.331 ns | 0.0088 ns | 0.0073 ns |  5.329 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.408 ns | 0.0058 ns | 0.0055 ns |  2.409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  3.030 ns | 0.0042 ns | 0.0033 ns |  3.030 ns |  1.26 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  3.031 ns | 0.0134 ns | 0.0119 ns |  3.030 ns |  1.26 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  2.326 ns | 0.0066 ns | 0.0058 ns |  2.325 ns |  0.97 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  2.384 ns | 0.0052 ns | 0.0048 ns |  2.383 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.159 ns | 0.0086 ns | 0.0076 ns |  5.158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.085 ns | 0.0070 ns | 0.0062 ns |  5.085 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.715 ns | 0.0056 ns | 0.0047 ns |  4.716 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.317 ns | 0.0150 ns | 0.0133 ns |  5.317 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.328 ns | 0.0078 ns | 0.0070 ns |  5.329 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.736 ns | 0.0119 ns | 0.0111 ns |  1.731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.978 ns | 0.0050 ns | 0.0046 ns |  1.978 ns |  1.14 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.782 ns | 0.0117 ns | 0.0104 ns |  1.785 ns |  1.03 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.411 ns | 0.0038 ns | 0.0036 ns |  2.412 ns |  1.39 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.395 ns | 0.0062 ns | 0.0058 ns |  2.395 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.461 ns | 0.0088 ns | 0.0082 ns |  4.460 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.394 ns | 0.0069 ns | 0.0065 ns |  4.394 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.253 ns | 0.0054 ns | 0.0045 ns |  4.254 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.299 ns | 0.0057 ns | 0.0054 ns |  5.300 ns |  1.19 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.327 ns | 0.0107 ns | 0.0089 ns |  5.325 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.477 ns | 0.0076 ns | 0.0072 ns |  1.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.822 ns | 0.0044 ns | 0.0039 ns |  1.822 ns |  1.23 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.577 ns | 0.0137 ns | 0.0128 ns |  1.572 ns |  1.07 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  2.377 ns | 0.0072 ns | 0.0064 ns |  2.377 ns |  1.61 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  2.345 ns | 0.0039 ns | 0.0036 ns |  2.344 ns |  1.59 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.465 ns | 0.0066 ns | 0.0058 ns |  4.464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.457 ns | 0.0066 ns | 0.0062 ns |  4.458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.960 ns | 0.0186 ns | 0.0174 ns |  3.954 ns |  0.89 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  5.066 ns | 0.0087 ns | 0.0072 ns |  5.065 ns |  1.13 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  5.156 ns | 0.0354 ns | 0.0331 ns |  5.173 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.441 ns | 0.0049 ns | 0.0046 ns |  1.440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.644 ns | 0.0035 ns | 0.0031 ns |  1.644 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.578 ns | 0.0027 ns | 0.0025 ns |  1.578 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.872 ns | 0.0045 ns | 0.0040 ns |  1.874 ns |  1.30 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.868 ns | 0.0031 ns | 0.0027 ns |  1.868 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  1.179 ns | 0.0039 ns | 0.0035 ns |  1.180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  1.161 ns | 0.0049 ns | 0.0046 ns |  1.160 ns |  0.98 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  1.117 ns | 0.0115 ns | 0.0108 ns |  1.123 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  1.138 ns | 0.0034 ns | 0.0031 ns |  1.138 ns |  0.97 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  1.167 ns | 0.0024 ns | 0.0022 ns |  1.168 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.236 ns | 0.0034 ns | 0.0030 ns |  1.235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.412 ns | 0.0034 ns | 0.0030 ns |  1.411 ns |  1.14 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.442 ns | 0.0031 ns | 0.0029 ns |  1.442 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.428 ns | 0.0033 ns | 0.0029 ns |  1.427 ns |  1.16 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.407 ns | 0.0029 ns | 0.0026 ns |  1.407 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.140 ns | 0.0026 ns | 0.0023 ns |  2.140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.850 ns | 0.0045 ns | 0.0040 ns |  1.850 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.372 ns | 0.0323 ns | 0.0302 ns |  2.359 ns |  1.11 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.126 ns | 0.0044 ns | 0.0041 ns |  2.126 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.286 ns | 0.0055 ns | 0.0049 ns |  2.284 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.409 ns | 0.0042 ns | 0.0037 ns |  1.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.600 ns | 0.0078 ns | 0.0073 ns |  1.598 ns |  1.14 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.762 ns | 0.0043 ns | 0.0040 ns |  1.763 ns |  1.25 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.396 ns | 0.0034 ns | 0.0032 ns |  1.396 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.421 ns | 0.0039 ns | 0.0036 ns |  1.420 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.129 ns | 0.0035 ns | 0.0031 ns |  2.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.293 ns | 0.0047 ns | 0.0041 ns |  2.293 ns |  1.08 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.255 ns | 0.0040 ns | 0.0031 ns |  2.256 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.511 ns | 0.0059 ns | 0.0055 ns |  2.510 ns |  1.18 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.539 ns | 0.0069 ns | 0.0061 ns |  2.539 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.640 ns | 0.0035 ns | 0.0032 ns |  1.640 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.612 ns | 0.0024 ns | 0.0019 ns |  1.612 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.651 ns | 0.0065 ns | 0.0061 ns |  1.649 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.175 ns | 0.0024 ns | 0.0021 ns |  1.175 ns |  0.72 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.146 ns | 0.0043 ns | 0.0038 ns |  1.146 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.922 ns | 0.0029 ns | 0.0025 ns |  4.923 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  5.082 ns | 0.0058 ns | 0.0051 ns |  5.083 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.709 ns | 0.0067 ns | 0.0063 ns |  4.710 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.072 ns | 0.0084 ns | 0.0074 ns |  5.070 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.106 ns | 0.0100 ns | 0.0089 ns |  5.105 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.652 ns | 0.0040 ns | 0.0035 ns |  1.652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.417 ns | 0.0179 ns | 0.0159 ns |  1.424 ns |  0.86 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.463 ns | 0.0030 ns | 0.0027 ns |  1.463 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.219 ns | 0.0036 ns | 0.0032 ns |  1.219 ns |  0.74 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.178 ns | 0.0033 ns | 0.0028 ns |  1.178 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.877 ns | 0.0134 ns | 0.0119 ns |  1.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.049 ns | 0.0038 ns | 0.0031 ns |  2.048 ns |  1.09 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.807 ns | 0.0048 ns | 0.0045 ns |  1.806 ns |  0.96 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.531 ns | 0.0107 ns | 0.0095 ns |  2.528 ns |  1.35 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.562 ns | 0.0059 ns | 0.0049 ns |  2.561 ns |  1.37 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.063 ns | 0.0045 ns | 0.0040 ns |  6.063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.081 ns | 0.0163 ns | 0.0136 ns |  6.076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.787 ns | 0.0087 ns | 0.0081 ns |  5.788 ns |  0.95 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.468 ns | 0.0149 ns | 0.0125 ns |  6.464 ns |  1.07 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.277 ns | 0.0172 ns | 0.0161 ns |  6.273 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.709 ns | 0.0218 ns | 0.0204 ns | 18.703 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.038 ns | 0.0323 ns | 0.0287 ns | 18.034 ns |  0.96 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.033 ns | 0.2547 ns | 0.2382 ns | 13.205 ns |  0.70 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 19.631 ns | 0.0240 ns | 0.0213 ns | 19.631 ns |  1.05 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.744 ns | 0.0283 ns | 0.0251 ns | 18.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.361 ns | 0.0034 ns | 0.0030 ns |  2.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.296 ns | 0.0050 ns | 0.0044 ns |  2.296 ns |  0.97 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.151 ns | 0.0045 ns | 0.0039 ns |  2.152 ns |  0.91 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.150 ns | 0.0091 ns | 0.0081 ns |  1.152 ns |  0.49 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.167 ns | 0.0025 ns | 0.0021 ns |  1.167 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.332 ns | 0.1154 ns | 0.1080 ns |  8.324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.202 ns | 0.0215 ns | 0.0202 ns |  8.202 ns |  0.98 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.353 ns | 0.0043 ns | 0.0039 ns |  2.354 ns |  0.28 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.888 ns | 0.0185 ns | 0.0173 ns |  8.888 ns |  1.07 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.514 ns | 0.0416 ns | 0.0347 ns |  8.525 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.765 ns | 0.0166 ns | 0.0138 ns |  3.762 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.476 ns | 0.0165 ns | 0.0146 ns |  4.478 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.619 ns | 0.0583 ns | 0.0545 ns |  4.616 ns |  1.23 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.756 ns | 0.0139 ns | 0.0130 ns |  3.752 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.778 ns | 0.0081 ns | 0.0063 ns |  3.778 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 26.941 ns | 0.0767 ns | 0.0680 ns | 26.916 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.241 ns | 0.0360 ns | 0.0337 ns | 17.240 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.413 ns | 0.0677 ns | 0.0633 ns | 12.377 ns |  0.46 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 30.353 ns | 0.0456 ns | 0.0427 ns | 30.345 ns |  1.13 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.545 ns | 0.0654 ns | 0.0580 ns | 31.547 ns |  1.17 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.634 ns | 0.0136 ns | 0.0120 ns | 12.633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.329 ns | 0.0161 ns | 0.0150 ns | 12.326 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.243 ns | 0.0116 ns | 0.0103 ns |  8.241 ns |  0.65 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.499 ns | 0.0732 ns | 0.0684 ns | 15.474 ns |  1.23 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.537 ns | 0.0249 ns | 0.0233 ns | 15.545 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.868 ns | 0.0596 ns | 0.0528 ns | 16.874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 17.054 ns | 0.0232 ns | 0.0206 ns | 17.054 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.885 ns | 0.0741 ns | 0.0693 ns | 12.847 ns |  0.76 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 20.090 ns | 0.0476 ns | 0.0445 ns | 20.092 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.983 ns | 0.0372 ns | 0.0311 ns | 19.987 ns |  1.18 |    0.00 |      - |     - |     - |         - |
