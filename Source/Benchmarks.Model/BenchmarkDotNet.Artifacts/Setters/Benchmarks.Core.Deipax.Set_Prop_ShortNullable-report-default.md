
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
             FromBool | .NET Core 2.0 |  0.9552 ns | 0.0136 ns | 0.0128 ns |  0.9491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9334 ns | 0.0112 ns | 0.0105 ns |  0.9295 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7224 ns | 0.0112 ns | 0.0105 ns |  0.7252 ns |  0.76 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6651 ns | 0.0165 ns | 0.0154 ns |  0.6701 ns |  0.70 |    0.02 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9486 ns | 0.0190 ns | 0.0178 ns |  0.9512 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4220 ns | 0.0138 ns | 0.0129 ns |  1.4204 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1761 ns | 0.0121 ns | 0.0113 ns |  1.1807 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1086 ns | 0.0166 ns | 0.0156 ns |  1.1019 ns |  0.78 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0867 ns | 0.0228 ns | 0.0214 ns |  2.0912 ns |  1.47 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.2265 ns | 0.0384 ns | 0.0359 ns |  2.2254 ns |  1.57 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3488 ns | 0.0149 ns | 0.0140 ns |  1.3539 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.4008 ns | 0.0178 ns | 0.0167 ns |  1.4062 ns |  1.04 |    0.02 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6382 ns | 0.0146 ns | 0.0137 ns |  0.6328 ns |  0.47 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7460 ns | 0.0188 ns | 0.0176 ns |  1.7500 ns |  1.29 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  1.8152 ns | 0.0189 ns | 0.0177 ns |  1.8089 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.9873 ns | 0.0208 ns | 0.0195 ns |  1.9814 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.1562 ns | 0.0190 ns | 0.0177 ns |  0.1589 ns |  0.08 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1072 ns | 0.0145 ns | 0.0136 ns |  1.1015 ns |  0.56 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.7703 ns | 0.0314 ns | 0.0294 ns |  2.7726 ns |  1.39 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.8077 ns | 0.0286 ns | 0.0268 ns |  2.8093 ns |  1.41 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7298 ns | 0.0092 ns | 0.0086 ns |  0.7271 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.9636 ns | 0.0140 ns | 0.0131 ns |  0.9653 ns |  1.32 |    0.02 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6580 ns | 0.0127 ns | 0.0119 ns |  0.6599 ns |  0.90 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5566 ns | 0.0108 ns | 0.0101 ns |  0.5544 ns |  0.76 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7246 ns | 0.0219 ns | 0.0205 ns |  0.7202 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1956 ns | 0.0146 ns | 0.0137 ns |  1.1999 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1950 ns | 0.0132 ns | 0.0124 ns |  1.1981 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.5770 ns | 0.0570 ns | 0.1228 ns |  1.6334 ns |  1.31 |    0.10 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.0083 ns | 0.0294 ns | 0.0275 ns |  2.0084 ns |  1.68 |    0.03 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.0423 ns | 0.0171 ns | 0.0160 ns |  2.0336 ns |  1.71 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9643 ns | 0.0100 ns | 0.0094 ns |  0.9650 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7243 ns | 0.0126 ns | 0.0118 ns |  0.7282 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7542 ns | 0.0125 ns | 0.0117 ns |  0.7555 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5563 ns | 0.0107 ns | 0.0100 ns |  0.5586 ns |  0.58 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7112 ns | 0.0131 ns | 0.0123 ns |  0.7062 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0138 ns | 0.0120 ns | 0.0112 ns |  1.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9454 ns | 0.0138 ns | 0.0129 ns |  0.9498 ns |  0.93 |    0.02 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1001 ns | 0.0169 ns | 0.0158 ns |  1.1022 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9846 ns | 0.0177 ns | 0.0166 ns |  1.9870 ns |  1.96 |    0.03 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.2524 ns | 0.0199 ns | 0.0186 ns |  2.2570 ns |  2.22 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.9233 ns | 0.0454 ns | 0.0606 ns |  0.9180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7008 ns | 0.0121 ns | 0.0113 ns |  0.7061 ns |  0.76 |    0.05 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.5902 ns | 0.0151 ns | 0.0141 ns |  0.5851 ns |  0.64 |    0.04 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6283 ns | 0.0106 ns | 0.0099 ns |  0.6254 ns |  0.68 |    0.04 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7081 ns | 0.0127 ns | 0.0119 ns |  0.7040 ns |  0.77 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.7349 ns | 0.0124 ns | 0.0116 ns |  0.7353 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.7113 ns | 0.0128 ns | 0.0120 ns |  0.7139 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.7235 ns | 0.0124 ns | 0.0116 ns |  0.7243 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  0.5899 ns | 0.0098 ns | 0.0091 ns |  0.5850 ns |  0.80 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  0.7165 ns | 0.0206 ns | 0.0193 ns |  0.7047 ns |  0.98 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.8233 ns | 0.0199 ns | 0.0186 ns |  1.8279 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.3981 ns | 0.0144 ns | 0.0135 ns |  1.3997 ns |  0.77 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6627 ns | 0.0131 ns | 0.0123 ns |  0.6623 ns |  0.36 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.7675 ns | 0.0304 ns | 0.0284 ns |  1.7676 ns |  0.97 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.7958 ns | 0.0192 ns | 0.0179 ns |  1.7887 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.9976 ns | 0.0188 ns | 0.0175 ns |  2.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.7949 ns | 0.0210 ns | 0.0197 ns |  1.7976 ns |  0.90 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1099 ns | 0.0137 ns | 0.0128 ns |  1.1156 ns |  0.56 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.7879 ns | 0.0225 ns | 0.0211 ns |  2.7800 ns |  1.40 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.8096 ns | 0.0320 ns | 0.0299 ns |  2.8125 ns |  1.41 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.9034 ns | 0.0139 ns | 0.0130 ns |  1.9095 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8966 ns | 0.0186 ns | 0.0174 ns |  1.9053 ns |  1.00 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.7137 ns | 0.0163 ns | 0.0152 ns |  1.7220 ns |  0.90 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7604 ns | 0.0236 ns | 0.0221 ns |  1.7572 ns |  0.92 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7987 ns | 0.0229 ns | 0.0214 ns |  1.7996 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.6765 ns | 0.0335 ns | 0.0313 ns |  2.6838 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.6106 ns | 0.0225 ns | 0.0211 ns |  2.6074 ns |  0.98 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.3370 ns | 0.0262 ns | 0.0245 ns |  2.3303 ns |  0.87 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.9053 ns | 0.0198 ns | 0.0185 ns |  2.9095 ns |  1.09 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.8819 ns | 0.0247 ns | 0.0231 ns |  2.8859 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.8466 ns | 0.0166 ns | 0.0156 ns |  1.8440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.8097 ns | 0.0151 ns | 0.0141 ns |  1.8128 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  1.9941 ns | 0.0205 ns | 0.0192 ns |  2.0020 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7169 ns | 0.0161 ns | 0.0151 ns |  1.7223 ns |  0.93 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7206 ns | 0.0273 ns | 0.0256 ns |  1.7196 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.6111 ns | 0.0270 ns | 0.0253 ns |  2.6039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  2.5021 ns | 0.0293 ns | 0.0274 ns |  2.4845 ns |  0.96 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  2.3858 ns | 0.0205 ns | 0.0191 ns |  2.3846 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.7626 ns | 0.0444 ns | 0.0415 ns |  2.7624 ns |  1.06 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.8073 ns | 0.0264 ns | 0.0247 ns |  2.7971 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8643 ns | 0.0216 ns | 0.0202 ns |  1.8589 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  2.1213 ns | 0.0240 ns | 0.0224 ns |  2.1253 ns |  1.14 |    0.02 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.6869 ns | 0.0182 ns | 0.0170 ns |  1.6932 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7483 ns | 0.0147 ns | 0.0138 ns |  1.7532 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7445 ns | 0.0179 ns | 0.0167 ns |  1.7435 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.8958 ns | 0.0190 ns | 0.0178 ns |  2.8954 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.0529 ns | 0.0293 ns | 0.0274 ns |  3.0660 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.0741 ns | 0.0394 ns | 0.0368 ns |  3.0511 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.5054 ns | 0.0482 ns | 0.0451 ns |  3.5200 ns |  1.21 |    0.02 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.1371 ns | 0.0362 ns | 0.0338 ns |  3.1424 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.9213 ns | 0.0143 ns | 0.0134 ns |  1.9263 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7532 ns | 0.0154 ns | 0.0144 ns |  1.7442 ns |  0.91 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6228 ns | 0.0206 ns | 0.0192 ns |  1.6238 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7846 ns | 0.0173 ns | 0.0162 ns |  1.7913 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7779 ns | 0.0219 ns | 0.0205 ns |  1.7822 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  3.0313 ns | 0.0241 ns | 0.0225 ns |  3.0348 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.2465 ns | 0.0229 ns | 0.0214 ns |  3.2423 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.6501 ns | 0.0200 ns | 0.0187 ns |  2.6398 ns |  0.87 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.2890 ns | 0.0306 ns | 0.0286 ns |  3.2693 ns |  1.09 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0297 ns | 0.0308 ns | 0.0288 ns |  3.0427 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.9802 ns | 0.0258 ns | 0.0241 ns |  3.9874 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.8714 ns | 0.0296 ns | 0.0277 ns |  3.8561 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.7794 ns | 0.0397 ns | 0.0372 ns |  3.7672 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.9610 ns | 0.0287 ns | 0.0268 ns |  3.9768 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.0048 ns | 0.0428 ns | 0.0401 ns |  4.0172 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  5.3566 ns | 0.0255 ns | 0.0239 ns |  5.3590 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.7563 ns | 0.0257 ns | 0.0241 ns |  4.7484 ns |  0.89 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.3750 ns | 0.0391 ns | 0.0366 ns |  4.3738 ns |  0.82 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.7072 ns | 0.0331 ns | 0.0309 ns |  4.7168 ns |  0.88 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.6917 ns | 0.0323 ns | 0.0302 ns |  4.7022 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.9642 ns | 0.0338 ns | 0.0299 ns |  3.9629 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.8940 ns | 0.0286 ns | 0.0268 ns |  3.9084 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.9231 ns | 0.0268 ns | 0.0251 ns |  3.9190 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4426 ns | 0.0354 ns | 0.0332 ns |  3.4510 ns |  0.87 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4088 ns | 0.0272 ns | 0.0255 ns |  3.4173 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.7529 ns | 0.0329 ns | 0.0308 ns |  4.7513 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.8457 ns | 0.0443 ns | 0.0414 ns |  4.8470 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  4.8486 ns | 0.0324 ns | 0.0303 ns |  4.8559 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.6943 ns | 0.0398 ns | 0.0373 ns |  5.6898 ns |  1.20 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.6796 ns | 0.0394 ns | 0.0368 ns |  5.6896 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.8686 ns | 0.0795 ns | 0.0744 ns | 13.8240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 14.0641 ns | 0.1048 ns | 0.0980 ns | 14.1104 ns |  1.01 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.8551 ns | 0.0621 ns | 0.0581 ns |  6.8518 ns |  0.49 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.3218 ns | 0.1065 ns | 0.0997 ns | 14.3617 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.4152 ns | 0.1200 ns | 0.1123 ns | 14.4345 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.4697 ns | 0.1408 ns | 0.1317 ns | 25.4804 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.9271 ns | 0.1830 ns | 0.1712 ns | 24.9290 ns |  0.98 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.8475 ns | 0.0985 ns | 0.0922 ns | 13.8540 ns |  0.54 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.8441 ns | 0.2246 ns | 0.2100 ns | 25.7347 ns |  1.01 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.3444 ns | 0.1642 ns | 0.1536 ns | 25.3652 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9571 ns | 0.0112 ns | 0.0105 ns |  0.9625 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9689 ns | 0.0128 ns | 0.0120 ns |  0.9657 ns |  1.01 |    0.02 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7433 ns | 0.0105 ns | 0.0098 ns |  0.7475 ns |  0.78 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6960 ns | 0.0203 ns | 0.0190 ns |  0.6940 ns |  0.73 |    0.03 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8922 ns | 0.0136 ns | 0.0127 ns |  0.8960 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.6259 ns | 0.0163 ns | 0.0152 ns |  1.6243 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6621 ns | 0.0218 ns | 0.0204 ns |  1.6664 ns |  1.02 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4546 ns | 0.0160 ns | 0.0149 ns |  1.4578 ns |  0.89 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6725 ns | 0.0175 ns | 0.0164 ns |  1.6800 ns |  1.03 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6559 ns | 0.0146 ns | 0.0137 ns |  1.6614 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.9812 ns | 0.0525 ns | 0.0491 ns |  9.9922 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.1957 ns | 0.0798 ns | 0.0746 ns | 14.1719 ns |  1.42 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 29.8110 ns | 0.1283 ns | 0.1200 ns | 29.8210 ns |  2.99 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.3288 ns | 0.0892 ns | 0.0834 ns | 13.3111 ns |  1.34 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.9403 ns | 0.0962 ns | 0.0900 ns | 13.9891 ns |  1.40 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 49.0642 ns | 0.1358 ns | 0.1271 ns | 49.0968 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 43.5346 ns | 0.2565 ns | 0.2399 ns | 43.5067 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  9.1756 ns | 0.0701 ns | 0.0656 ns |  9.1898 ns |  0.19 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 47.0300 ns | 0.4280 ns | 0.4003 ns | 47.0056 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 46.1811 ns | 0.2531 ns | 0.2367 ns | 46.1658 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.9301 ns | 0.0142 ns | 0.0133 ns |  1.9358 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8435 ns | 0.0162 ns | 0.0152 ns |  1.8371 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.6770 ns | 0.0164 ns | 0.0153 ns |  1.6807 ns |  0.87 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7472 ns | 0.0175 ns | 0.0164 ns |  1.7411 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7541 ns | 0.0229 ns | 0.0215 ns |  1.7556 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  3.0438 ns | 0.0248 ns | 0.0232 ns |  3.0391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.6077 ns | 0.0301 ns | 0.0282 ns |  2.5893 ns |  0.86 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2122 ns | 0.0159 ns | 0.0148 ns |  2.2154 ns |  0.73 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.9249 ns | 0.0297 ns | 0.0277 ns |  2.9282 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.9131 ns | 0.0272 ns | 0.0255 ns |  2.8954 ns |  0.96 |    0.01 |     - |     - |     - |         - |
