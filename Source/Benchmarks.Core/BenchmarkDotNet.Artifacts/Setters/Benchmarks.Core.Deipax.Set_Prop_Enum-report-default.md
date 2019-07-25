
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 12.1397 ns | 0.0710 ns | 0.0630 ns |  1.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 12.2786 ns | 0.0171 ns | 0.0151 ns |  1.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  8.3764 ns | 0.0716 ns | 0.0670 ns |  0.69 |     - |     - |     - |         - |
             FromBool |        net461 | 15.0161 ns | 0.0366 ns | 0.0342 ns |  1.24 |     - |     - |     - |         - |
             FromBool |        net472 | 15.1417 ns | 0.0213 ns | 0.0167 ns |  1.25 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 12.5019 ns | 0.0358 ns | 0.0299 ns |  1.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 12.4843 ns | 0.0239 ns | 0.0212 ns |  1.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  8.9013 ns | 0.0555 ns | 0.0519 ns |  0.71 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 15.9583 ns | 0.0237 ns | 0.0222 ns |  1.28 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 15.7652 ns | 0.0535 ns | 0.0501 ns |  1.26 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
             FromChar | .NET Core 2.0 | 12.0728 ns | 0.0152 ns | 0.0135 ns |  1.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 12.2150 ns | 0.0243 ns | 0.0203 ns |  1.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  8.3632 ns | 0.0121 ns | 0.0113 ns |  0.69 |     - |     - |     - |         - |
             FromChar |        net461 | 15.1846 ns | 0.0422 ns | 0.0353 ns |  1.26 |     - |     - |     - |         - |
             FromChar |        net472 | 15.0169 ns | 0.0234 ns | 0.0208 ns |  1.24 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 12.5641 ns | 0.0237 ns | 0.0221 ns |  1.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 12.6130 ns | 0.0636 ns | 0.0564 ns |  1.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  8.8190 ns | 0.0255 ns | 0.0213 ns |  0.70 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 15.7779 ns | 0.0255 ns | 0.0226 ns |  1.26 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 15.8754 ns | 0.0188 ns | 0.0157 ns |  1.26 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
            FromSByte | .NET Core 2.0 | 12.1000 ns | 0.0294 ns | 0.0246 ns |  1.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 12.2661 ns | 0.0195 ns | 0.0182 ns |  1.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  8.3862 ns | 0.0374 ns | 0.0331 ns |  0.69 |     - |     - |     - |         - |
            FromSByte |        net461 | 15.0535 ns | 0.0297 ns | 0.0264 ns |  1.24 |     - |     - |     - |         - |
            FromSByte |        net472 | 15.0465 ns | 0.0236 ns | 0.0184 ns |  1.24 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 12.5633 ns | 0.0184 ns | 0.0163 ns |  1.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 12.5359 ns | 0.0269 ns | 0.0238 ns |  1.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  8.7827 ns | 0.0260 ns | 0.0243 ns |  0.70 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 15.8211 ns | 0.0263 ns | 0.0233 ns |  1.26 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 15.8197 ns | 0.1053 ns | 0.0985 ns |  1.26 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
             FromByte | .NET Core 2.0 | 12.0557 ns | 0.0190 ns | 0.0148 ns |  1.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 12.2320 ns | 0.0118 ns | 0.0098 ns |  1.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  8.3379 ns | 0.0225 ns | 0.0188 ns |  0.69 |     - |     - |     - |         - |
             FromByte |        net461 | 14.9928 ns | 0.0281 ns | 0.0263 ns |  1.24 |     - |     - |     - |         - |
             FromByte |        net472 | 14.9864 ns | 0.0246 ns | 0.0206 ns |  1.24 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 12.5080 ns | 0.0163 ns | 0.0144 ns |  1.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 12.4741 ns | 0.0243 ns | 0.0215 ns |  1.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  8.8360 ns | 0.0231 ns | 0.0205 ns |  0.71 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 15.9264 ns | 0.0269 ns | 0.0238 ns |  1.27 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 15.7925 ns | 0.0371 ns | 0.0329 ns |  1.26 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
            FromShort | .NET Core 2.0 | 12.0957 ns | 0.0093 ns | 0.0082 ns |  1.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 12.3370 ns | 0.0586 ns | 0.0548 ns |  1.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  8.3490 ns | 0.0176 ns | 0.0165 ns |  0.69 |     - |     - |     - |         - |
            FromShort |        net461 | 15.1321 ns | 0.0388 ns | 0.0344 ns |  1.25 |     - |     - |     - |         - |
            FromShort |        net472 | 15.2439 ns | 0.0277 ns | 0.0231 ns |  1.26 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 12.5782 ns | 0.0287 ns | 0.0269 ns |  1.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 12.4758 ns | 0.0259 ns | 0.0230 ns |  0.99 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  8.8254 ns | 0.0213 ns | 0.0178 ns |  0.70 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 15.8221 ns | 0.0237 ns | 0.0210 ns |  1.26 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 15.8845 ns | 0.0456 ns | 0.0404 ns |  1.26 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
           FromUShort | .NET Core 2.0 | 12.0902 ns | 0.0285 ns | 0.0267 ns |  1.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 12.2248 ns | 0.0364 ns | 0.0304 ns |  1.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  8.3215 ns | 0.0214 ns | 0.0200 ns |  0.69 |     - |     - |     - |         - |
           FromUShort |        net461 | 15.0433 ns | 0.0346 ns | 0.0307 ns |  1.24 |     - |     - |     - |         - |
           FromUShort |        net472 | 15.0223 ns | 0.0372 ns | 0.0311 ns |  1.24 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 12.5314 ns | 0.0185 ns | 0.0173 ns |  1.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 12.4887 ns | 0.0169 ns | 0.0158 ns |  1.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  8.8421 ns | 0.0101 ns | 0.0090 ns |  0.71 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 15.7952 ns | 0.0306 ns | 0.0272 ns |  1.26 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 15.9013 ns | 0.0249 ns | 0.0220 ns |  1.27 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
              FromInt | .NET Core 2.0 | 12.1028 ns | 0.0189 ns | 0.0177 ns |  1.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 12.2220 ns | 0.0391 ns | 0.0346 ns |  1.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  8.1926 ns | 0.0175 ns | 0.0137 ns |  0.68 |     - |     - |     - |         - |
              FromInt |        net461 | 15.1393 ns | 0.0175 ns | 0.0164 ns |  1.25 |     - |     - |     - |         - |
              FromInt |        net472 | 15.2982 ns | 0.0559 ns | 0.0523 ns |  1.26 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 12.5886 ns | 0.0141 ns | 0.0125 ns |  1.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 12.5190 ns | 0.0834 ns | 0.0780 ns |  0.99 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  8.5701 ns | 0.0177 ns | 0.0166 ns |  0.68 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 15.7688 ns | 0.0623 ns | 0.0583 ns |  1.25 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 15.7600 ns | 0.0272 ns | 0.0255 ns |  1.25 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
             FromUInt | .NET Core 2.0 | 12.0697 ns | 0.0228 ns | 0.0214 ns |  1.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 11.9795 ns | 0.0200 ns | 0.0178 ns |  0.99 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  8.0696 ns | 0.0180 ns | 0.0159 ns |  0.67 |     - |     - |     - |         - |
             FromUInt |        net461 | 15.5460 ns | 0.0286 ns | 0.0239 ns |  1.29 |     - |     - |     - |         - |
             FromUInt |        net472 | 15.5310 ns | 0.0288 ns | 0.0255 ns |  1.29 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 12.5502 ns | 0.0197 ns | 0.0184 ns |  1.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 12.5261 ns | 0.0630 ns | 0.0589 ns |  1.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  8.5155 ns | 0.0246 ns | 0.0206 ns |  0.68 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 16.0444 ns | 0.0271 ns | 0.0240 ns |  1.28 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 16.0310 ns | 0.0368 ns | 0.0344 ns |  1.28 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
             FromLong | .NET Core 2.0 | 12.8778 ns | 0.0632 ns | 0.0560 ns |  1.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 12.2643 ns | 0.0223 ns | 0.0197 ns |  0.95 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  8.5802 ns | 0.0197 ns | 0.0175 ns |  0.67 |     - |     - |     - |         - |
             FromLong |        net461 | 15.8080 ns | 0.0523 ns | 0.0464 ns |  1.23 |     - |     - |     - |         - |
             FromLong |        net472 | 15.8293 ns | 0.0302 ns | 0.0267 ns |  1.23 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 14.1505 ns | 0.0574 ns | 0.0509 ns |  1.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 13.3995 ns | 0.0963 ns | 0.0901 ns |  0.95 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  9.6742 ns | 0.0181 ns | 0.0161 ns |  0.68 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 17.3877 ns | 0.0513 ns | 0.0455 ns |  1.23 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 18.4326 ns | 0.0263 ns | 0.0246 ns |  1.30 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
            FromULong | .NET Core 2.0 | 12.6049 ns | 0.0221 ns | 0.0207 ns |  1.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 12.2894 ns | 0.0168 ns | 0.0157 ns |  0.97 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  8.5810 ns | 0.0200 ns | 0.0156 ns |  0.68 |     - |     - |     - |         - |
            FromULong |        net461 | 15.5970 ns | 0.0448 ns | 0.0374 ns |  1.24 |     - |     - |     - |         - |
            FromULong |        net472 | 15.7325 ns | 0.0447 ns | 0.0396 ns |  1.25 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 13.9280 ns | 0.0286 ns | 0.0268 ns |  1.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 13.4450 ns | 0.0132 ns | 0.0117 ns |  0.97 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  9.8361 ns | 0.0235 ns | 0.0196 ns |  0.71 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 17.1225 ns | 0.0489 ns | 0.0458 ns |  1.23 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 16.7765 ns | 0.0359 ns | 0.0318 ns |  1.20 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
            FromFloat | .NET Core 2.0 | 14.6838 ns | 0.0293 ns | 0.0274 ns |  1.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 13.9742 ns | 0.0245 ns | 0.0229 ns |  0.95 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 10.4476 ns | 0.0301 ns | 0.0267 ns |  0.71 |     - |     - |     - |         - |
            FromFloat |        net461 | 17.4903 ns | 0.0668 ns | 0.0593 ns |  1.19 |     - |     - |     - |         - |
            FromFloat |        net472 | 17.5881 ns | 0.0613 ns | 0.0573 ns |  1.20 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 15.0290 ns | 0.0842 ns | 0.0788 ns |  1.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 14.2428 ns | 0.0447 ns | 0.0418 ns |  0.95 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 10.9074 ns | 0.0157 ns | 0.0139 ns |  0.73 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 17.9248 ns | 0.0487 ns | 0.0432 ns |  1.19 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 17.9909 ns | 0.0324 ns | 0.0270 ns |  1.20 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
           FromDouble | .NET Core 2.0 | 14.5026 ns | 0.0172 ns | 0.0144 ns |  1.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 13.9681 ns | 0.0221 ns | 0.0196 ns |  0.96 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 10.4140 ns | 0.0168 ns | 0.0131 ns |  0.72 |     - |     - |     - |         - |
           FromDouble |        net461 | 17.6627 ns | 0.0408 ns | 0.0362 ns |  1.22 |     - |     - |     - |         - |
           FromDouble |        net472 | 17.4575 ns | 0.0802 ns | 0.0750 ns |  1.20 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 15.1043 ns | 0.0349 ns | 0.0327 ns |  1.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 14.9800 ns | 0.0923 ns | 0.0864 ns |  0.99 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 11.3549 ns | 0.0194 ns | 0.0152 ns |  0.75 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 18.5561 ns | 0.0460 ns | 0.0430 ns |  1.23 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 18.5218 ns | 0.0321 ns | 0.0285 ns |  1.23 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 29.9717 ns | 0.0544 ns | 0.0509 ns |  1.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 29.0189 ns | 0.0514 ns | 0.0481 ns |  0.97 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 13.1128 ns | 0.0938 ns | 0.0878 ns |  0.44 |     - |     - |     - |         - |
          FromDecimal |        net461 | 27.6145 ns | 0.0335 ns | 0.0297 ns |  0.92 |     - |     - |     - |         - |
          FromDecimal |        net472 | 25.7914 ns | 0.0681 ns | 0.0603 ns |  0.86 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 34.5558 ns | 0.0645 ns | 0.0538 ns |  1.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 33.9408 ns | 0.0966 ns | 0.0856 ns |  0.98 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 24.6331 ns | 0.1671 ns | 0.1563 ns |  0.71 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 30.1357 ns | 0.0720 ns | 0.0638 ns |  0.87 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 30.1064 ns | 0.0598 ns | 0.0530 ns |  0.87 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 11.2605 ns | 0.0132 ns | 0.0117 ns |  1.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 11.2950 ns | 0.0204 ns | 0.0191 ns |  1.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  6.9679 ns | 0.0482 ns | 0.0428 ns |  0.62 |     - |     - |     - |         - |
         FromDateTime |        net461 | 14.1620 ns | 0.0316 ns | 0.0295 ns |  1.26 |     - |     - |     - |         - |
         FromDateTime |        net472 | 14.4855 ns | 0.0268 ns | 0.0237 ns |  1.29 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.9384 ns | 0.0090 ns | 0.0084 ns |  1.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  2.1373 ns | 0.0067 ns | 0.0056 ns |  1.10 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.9384 ns | 0.0076 ns | 0.0067 ns |  1.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  2.1897 ns | 0.0175 ns | 0.0164 ns |  1.13 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  2.1674 ns | 0.0038 ns | 0.0034 ns |  1.12 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.5303 ns | 0.0043 ns | 0.0038 ns |  1.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.7834 ns | 0.0202 ns | 0.0189 ns |  1.10 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.3148 ns | 0.0041 ns | 0.0036 ns |  0.91 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2403 ns | 0.0032 ns | 0.0028 ns |  0.89 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2439 ns | 0.0040 ns | 0.0035 ns |  0.89 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
           FromString | .NET Core 2.0 | 22.0102 ns | 0.0367 ns | 0.0343 ns |  1.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 24.0782 ns | 0.0438 ns | 0.0410 ns |  1.09 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 19.7004 ns | 0.0595 ns | 0.0528 ns |  0.89 |     - |     - |     - |         - |
           FromString |        net461 | 29.7554 ns | 0.0886 ns | 0.0828 ns |  1.35 |     - |     - |     - |         - |
           FromString |        net472 | 30.1388 ns | 0.1288 ns | 0.1141 ns |  1.37 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6920 ns | 0.0038 ns | 0.0034 ns |  1.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7210 ns | 0.0034 ns | 0.0032 ns |  1.04 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7141 ns | 0.0049 ns | 0.0046 ns |  1.03 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.4441 ns | 0.0028 ns | 0.0024 ns |  0.64 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.4447 ns | 0.0021 ns | 0.0020 ns |  0.64 |     - |     - |     - |         - |
                      |               |            |           |           |       |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1673 ns | 0.0119 ns | 0.0112 ns |  1.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9554 ns | 0.0074 ns | 0.0069 ns |  0.82 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1638 ns | 0.0056 ns | 0.0053 ns |  1.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.4223 ns | 0.0041 ns | 0.0038 ns |  1.22 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.4044 ns | 0.0049 ns | 0.0046 ns |  1.20 |     - |     - |     - |         - |
