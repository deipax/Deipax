
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 3.964 ns | 0.0268 ns | 0.0250 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 2.2 | 4.440 ns | 0.0251 ns | 0.0222 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 3.0 | 4.385 ns | 0.0411 ns | 0.0384 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool |        net461 | 3.836 ns | 0.0179 ns | 0.0167 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool |        net472 | 4.032 ns | 0.0172 ns | 0.0152 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 1.252 ns | 0.0052 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 1.145 ns | 0.0034 ns | 0.0031 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 1.117 ns | 0.0099 ns | 0.0093 ns |  0.89 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net461 | 1.134 ns | 0.0120 ns | 0.0112 ns |  0.91 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net472 | 1.146 ns | 0.0048 ns | 0.0045 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 | 4.042 ns | 0.0189 ns | 0.0158 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 2.2 | 4.276 ns | 0.0139 ns | 0.0130 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 3.0 | 4.363 ns | 0.0216 ns | 0.0192 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 | 3.821 ns | 0.0130 ns | 0.0115 ns |  0.95 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net472 | 4.029 ns | 0.0187 ns | 0.0166 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 | 1.285 ns | 0.0044 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 1.291 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 1.363 ns | 0.0045 ns | 0.0042 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     FromCharNullable |        net461 | 1.271 ns | 0.0051 ns | 0.0047 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     FromCharNullable |        net472 | 1.292 ns | 0.0049 ns | 0.0046 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 | 4.010 ns | 0.0239 ns | 0.0212 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 2.2 | 4.267 ns | 0.0097 ns | 0.0091 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 3.0 | 4.381 ns | 0.0418 ns | 0.0391 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte |        net461 | 3.996 ns | 0.0157 ns | 0.0139 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte |        net472 | 3.967 ns | 0.0316 ns | 0.0264 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.253 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.192 ns | 0.0026 ns | 0.0022 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 1.118 ns | 0.0047 ns | 0.0039 ns |  0.89 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable |        net461 | 1.125 ns | 0.0046 ns | 0.0041 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.146 ns | 0.0034 ns | 0.0027 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 | 3.931 ns | 0.0195 ns | 0.0163 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 2.2 | 4.286 ns | 0.0233 ns | 0.0206 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 3.0 | 4.395 ns | 0.0379 ns | 0.0355 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte |        net461 | 3.811 ns | 0.0171 ns | 0.0151 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte |        net472 | 3.968 ns | 0.0175 ns | 0.0155 ns |  1.01 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.255 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 1.165 ns | 0.0119 ns | 0.0111 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 1.140 ns | 0.0055 ns | 0.0046 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net461 | 1.133 ns | 0.0063 ns | 0.0059 ns |  0.90 |    0.00 |      - |     - |     - |         - |
     FromByteNullable |        net472 | 1.151 ns | 0.0053 ns | 0.0050 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 | 3.977 ns | 0.0113 ns | 0.0094 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 2.2 | 4.945 ns | 0.1212 ns | 0.1134 ns |  1.24 |    0.03 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 3.0 | 4.632 ns | 0.0426 ns | 0.0399 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromShort |        net461 | 3.826 ns | 0.0135 ns | 0.0113 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort |        net472 | 3.916 ns | 0.0151 ns | 0.0126 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.545 ns | 0.0543 ns | 0.0482 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.296 ns | 0.0092 ns | 0.0081 ns |  0.84 |    0.03 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.362 ns | 0.0052 ns | 0.0041 ns |  0.88 |    0.03 |      - |     - |     - |         - |
    FromShortNullable |        net461 | 1.272 ns | 0.0043 ns | 0.0040 ns |  0.82 |    0.03 |      - |     - |     - |         - |
    FromShortNullable |        net472 | 1.299 ns | 0.0030 ns | 0.0028 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 | 4.283 ns | 0.0242 ns | 0.0226 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 2.2 | 4.660 ns | 0.0090 ns | 0.0075 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 3.0 | 4.353 ns | 0.0292 ns | 0.0259 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromUShort |        net461 | 4.008 ns | 0.0142 ns | 0.0111 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromUShort |        net472 | 4.248 ns | 0.0168 ns | 0.0157 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.289 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.298 ns | 0.0031 ns | 0.0029 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.364 ns | 0.0058 ns | 0.0054 ns |  1.06 |    0.01 |      - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.269 ns | 0.0035 ns | 0.0033 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.303 ns | 0.0148 ns | 0.0139 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 | 3.973 ns | 0.0226 ns | 0.0211 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 2.2 | 4.403 ns | 0.0218 ns | 0.0204 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 3.0 | 4.393 ns | 0.0298 ns | 0.0279 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt |        net461 | 4.123 ns | 0.0197 ns | 0.0174 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt |        net472 | 4.240 ns | 0.0303 ns | 0.0284 ns |  1.07 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 | 1.290 ns | 0.0104 ns | 0.0097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.301 ns | 0.0109 ns | 0.0102 ns |  1.01 |    0.01 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.367 ns | 0.0025 ns | 0.0023 ns |  1.06 |    0.01 |      - |     - |     - |         - |
      FromIntNullable |        net461 | 1.859 ns | 0.0036 ns | 0.0032 ns |  1.44 |    0.01 |      - |     - |     - |         - |
      FromIntNullable |        net472 | 1.296 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 | 3.964 ns | 0.0238 ns | 0.0199 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 2.2 | 4.352 ns | 0.0212 ns | 0.0188 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 3.0 | 4.435 ns | 0.0413 ns | 0.0366 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt |        net461 | 4.354 ns | 0.0197 ns | 0.0175 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt |        net472 | 4.307 ns | 0.0307 ns | 0.0256 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.297 ns | 0.0175 ns | 0.0164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.282 ns | 0.0068 ns | 0.0053 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 1.378 ns | 0.0035 ns | 0.0032 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net461 | 1.300 ns | 0.0070 ns | 0.0065 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net472 | 1.924 ns | 0.0136 ns | 0.0127 ns |  1.48 |    0.02 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 | 3.954 ns | 0.0330 ns | 0.0309 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 2.2 | 4.377 ns | 0.0146 ns | 0.0137 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 3.0 | 4.392 ns | 0.0226 ns | 0.0201 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromLong |        net461 | 4.526 ns | 0.0327 ns | 0.0290 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromLong |        net472 | 4.272 ns | 0.0234 ns | 0.0195 ns |  1.08 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.671 ns | 0.0076 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.697 ns | 0.0035 ns | 0.0032 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.738 ns | 0.0136 ns | 0.0127 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     FromLongNullable |        net461 | 1.529 ns | 0.0104 ns | 0.0087 ns |  0.92 |    0.01 |      - |     - |     - |         - |
     FromLongNullable |        net472 | 1.945 ns | 0.0140 ns | 0.0124 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 | 3.983 ns | 0.0326 ns | 0.0305 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 2.2 | 4.357 ns | 0.0279 ns | 0.0261 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 3.0 | 4.351 ns | 0.0274 ns | 0.0243 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromULong |        net461 | 4.177 ns | 0.0252 ns | 0.0236 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromULong |        net472 | 4.144 ns | 0.0193 ns | 0.0171 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 | 1.480 ns | 0.0041 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.657 ns | 0.0050 ns | 0.0039 ns |  1.12 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.650 ns | 0.0047 ns | 0.0044 ns |  1.12 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net461 | 1.796 ns | 0.0043 ns | 0.0036 ns |  1.21 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net472 | 1.473 ns | 0.0052 ns | 0.0048 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 | 4.048 ns | 0.0287 ns | 0.0269 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 2.2 | 4.519 ns | 0.0104 ns | 0.0097 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 3.0 | 4.495 ns | 0.0341 ns | 0.0319 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 | 4.179 ns | 0.0386 ns | 0.0361 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net472 | 4.112 ns | 0.0080 ns | 0.0062 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 1.317 ns | 0.0048 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 1.246 ns | 0.0048 ns | 0.0037 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 1.285 ns | 0.0065 ns | 0.0054 ns |  0.98 |    0.01 |      - |     - |     - |         - |
    FromFloatNullable |        net461 | 1.272 ns | 0.0020 ns | 0.0017 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net472 | 1.264 ns | 0.0038 ns | 0.0034 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 4.017 ns | 0.0339 ns | 0.0317 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 2.2 | 4.491 ns | 0.0251 ns | 0.0235 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 3.0 | 4.474 ns | 0.0299 ns | 0.0280 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 4.192 ns | 0.0214 ns | 0.0200 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net472 | 4.927 ns | 0.0777 ns | 0.0727 ns |  1.23 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.528 ns | 0.0044 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.905 ns | 0.0071 ns | 0.0063 ns |  1.25 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.899 ns | 0.0044 ns | 0.0039 ns |  1.24 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.648 ns | 0.0043 ns | 0.0040 ns |  1.08 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.603 ns | 0.0056 ns | 0.0050 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 | 5.209 ns | 0.0332 ns | 0.0311 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 | 5.659 ns | 0.0187 ns | 0.0165 ns |  1.09 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 | 5.820 ns | 0.0130 ns | 0.0115 ns |  1.12 |    0.01 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net461 | 5.451 ns | 0.0138 ns | 0.0123 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 | 5.363 ns | 0.0199 ns | 0.0176 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |          |           |           |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 1.743 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 2.166 ns | 0.0043 ns | 0.0038 ns |  1.24 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 1.641 ns | 0.0048 ns | 0.0043 ns |  0.94 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable |        net461 | 1.682 ns | 0.0088 ns | 0.0082 ns |  0.96 |    0.01 |      - |     - |     - |         - |
  FromDecimalNullable |        net472 | 1.646 ns | 0.0070 ns | 0.0062 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 3.963 ns | 0.0339 ns | 0.0317 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 2.2 | 4.341 ns | 0.0149 ns | 0.0125 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 3.0 | 4.378 ns | 0.0237 ns | 0.0210 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime |        net461 | 4.042 ns | 0.0276 ns | 0.0258 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime |        net472 | 4.022 ns | 0.0158 ns | 0.0140 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.478 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.693 ns | 0.0142 ns | 0.0126 ns |  1.15 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.693 ns | 0.0188 ns | 0.0176 ns |  1.15 |    0.01 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.772 ns | 0.0036 ns | 0.0032 ns |  1.20 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.745 ns | 0.0036 ns | 0.0034 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 | 1.861 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 1.711 ns | 0.0046 ns | 0.0041 ns |  0.92 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 1.726 ns | 0.0087 ns | 0.0082 ns |  0.93 |    0.01 |      - |     - |     - |         - |
           FromObject |        net461 | 1.896 ns | 0.0045 ns | 0.0040 ns |  1.02 |    0.00 |      - |     - |     - |         - |
           FromObject |        net472 | 1.885 ns | 0.0035 ns | 0.0031 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
           FromString | .NET Core 2.0 | 2.094 ns | 0.0183 ns | 0.0171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 | 1.598 ns | 0.0023 ns | 0.0019 ns |  0.76 |    0.01 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.830 ns | 0.0080 ns | 0.0075 ns |  0.87 |    0.01 |      - |     - |     - |         - |
           FromString |        net461 | 2.492 ns | 0.0085 ns | 0.0075 ns |  1.19 |    0.01 |      - |     - |     - |         - |
           FromString |        net472 | 2.486 ns | 0.0091 ns | 0.0085 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 | 3.952 ns | 0.0285 ns | 0.0267 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 2.2 | 4.407 ns | 0.0176 ns | 0.0156 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 3.0 | 4.392 ns | 0.0311 ns | 0.0291 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net461 | 4.384 ns | 0.0247 ns | 0.0206 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net472 | 4.301 ns | 0.0305 ns | 0.0285 ns |  1.09 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 1.389 ns | 0.0022 ns | 0.0018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 1.278 ns | 0.0035 ns | 0.0033 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 1.320 ns | 0.0056 ns | 0.0052 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable |        net461 | 1.413 ns | 0.0092 ns | 0.0082 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable |        net472 | 1.413 ns | 0.0043 ns | 0.0038 ns |  1.02 |    0.00 |      - |     - |     - |         - |
