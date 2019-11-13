
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
             FromBool | .NET Core 2.0 | 17.1628 ns | 0.1205 ns | 0.1127 ns | 17.2068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 17.0267 ns | 0.0247 ns | 0.0231 ns | 17.0249 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 13.4212 ns | 0.0126 ns | 0.0118 ns | 13.4209 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 19.4802 ns | 0.0210 ns | 0.0176 ns | 19.4820 ns |  1.13 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 | 19.5458 ns | 0.0234 ns | 0.0207 ns | 19.5494 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 17.4933 ns | 0.0184 ns | 0.0172 ns | 17.4955 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 17.4248 ns | 0.0200 ns | 0.0187 ns | 17.4219 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 13.8047 ns | 0.0211 ns | 0.0197 ns | 13.8035 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 20.3833 ns | 0.0301 ns | 0.0282 ns | 20.3957 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 20.3581 ns | 0.0202 ns | 0.0189 ns | 20.3577 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 17.2233 ns | 0.0241 ns | 0.0201 ns | 17.2214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 17.0362 ns | 0.0195 ns | 0.0183 ns | 17.0348 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 13.4799 ns | 0.0397 ns | 0.0331 ns | 13.4842 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 | 19.5075 ns | 0.0203 ns | 0.0180 ns | 19.5025 ns |  1.13 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 | 19.5870 ns | 0.0412 ns | 0.0366 ns | 19.5913 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 17.7419 ns | 0.1064 ns | 0.0995 ns | 17.6989 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 17.3664 ns | 0.0255 ns | 0.0226 ns | 17.3679 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 13.7592 ns | 0.0157 ns | 0.0146 ns | 13.7599 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 20.3708 ns | 0.0248 ns | 0.0232 ns | 20.3699 ns |  1.15 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 20.3437 ns | 0.0314 ns | 0.0278 ns | 20.3332 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 17.0168 ns | 0.0252 ns | 0.0236 ns | 17.0165 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 16.9635 ns | 0.0218 ns | 0.0204 ns | 16.9686 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 13.3738 ns | 0.0152 ns | 0.0142 ns | 13.3721 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 19.7032 ns | 0.1054 ns | 0.0986 ns | 19.6703 ns |  1.16 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 19.5505 ns | 0.0273 ns | 0.0242 ns | 19.5490 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 17.4268 ns | 0.0238 ns | 0.0223 ns | 17.4287 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 17.5444 ns | 0.1018 ns | 0.0952 ns | 17.5919 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 13.9288 ns | 0.0779 ns | 0.0729 ns | 13.9542 ns |  0.80 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 20.3655 ns | 0.0191 ns | 0.0170 ns | 20.3668 ns |  1.17 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 20.3736 ns | 0.0276 ns | 0.0230 ns | 20.3733 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 17.1050 ns | 0.0964 ns | 0.0902 ns | 17.0654 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 16.9661 ns | 0.0159 ns | 0.0149 ns | 16.9673 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 13.3266 ns | 0.0188 ns | 0.0176 ns | 13.3273 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 19.5214 ns | 0.0249 ns | 0.0208 ns | 19.5205 ns |  1.14 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 | 19.7448 ns | 0.0632 ns | 0.0591 ns | 19.7597 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 17.5911 ns | 0.0289 ns | 0.0270 ns | 17.5865 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 17.4529 ns | 0.0204 ns | 0.0191 ns | 17.4446 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 13.7043 ns | 0.0196 ns | 0.0183 ns | 13.7010 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 20.3350 ns | 0.0222 ns | 0.0208 ns | 20.3287 ns |  1.16 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 20.3705 ns | 0.0639 ns | 0.0598 ns | 20.3500 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 16.9915 ns | 0.0268 ns | 0.0224 ns | 16.9935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 17.0856 ns | 0.1230 ns | 0.1150 ns | 17.1478 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 13.3731 ns | 0.0885 ns | 0.0828 ns | 13.3369 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 19.6044 ns | 0.0318 ns | 0.0297 ns | 19.6047 ns |  1.15 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 19.5257 ns | 0.0259 ns | 0.0243 ns | 19.5187 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 17.4650 ns | 0.1044 ns | 0.0977 ns | 17.4216 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 17.4657 ns | 0.0229 ns | 0.0214 ns | 17.4653 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 13.9367 ns | 0.0143 ns | 0.0127 ns | 13.9396 ns |  0.80 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 20.4846 ns | 0.0289 ns | 0.0241 ns | 20.4835 ns |  1.17 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 20.3526 ns | 0.0204 ns | 0.0181 ns | 20.3498 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 17.1319 ns | 0.0253 ns | 0.0236 ns | 17.1304 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 16.9676 ns | 0.0159 ns | 0.0141 ns | 16.9698 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 13.3724 ns | 0.0122 ns | 0.0115 ns | 13.3726 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 | 19.5356 ns | 0.0362 ns | 0.0302 ns | 19.5251 ns |  1.14 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 19.5496 ns | 0.0313 ns | 0.0293 ns | 19.5411 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 17.6612 ns | 0.0276 ns | 0.0258 ns | 17.6660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 17.3615 ns | 0.0110 ns | 0.0097 ns | 17.3610 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 13.8870 ns | 0.0622 ns | 0.0582 ns | 13.9092 ns |  0.79 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 20.3770 ns | 0.0317 ns | 0.0248 ns | 20.3809 ns |  1.15 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 20.3724 ns | 0.0213 ns | 0.0189 ns | 20.3710 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 16.9880 ns | 0.0615 ns | 0.0545 ns | 16.9642 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 17.1238 ns | 0.0676 ns | 0.0599 ns | 17.1446 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 13.0590 ns | 0.0244 ns | 0.0216 ns | 13.0572 ns |  0.77 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 19.6189 ns | 0.1135 ns | 0.1061 ns | 19.6845 ns |  1.15 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 | 19.5702 ns | 0.0341 ns | 0.0319 ns | 19.5704 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 17.4612 ns | 0.0153 ns | 0.0143 ns | 17.4610 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 17.4069 ns | 0.0333 ns | 0.0295 ns | 17.4103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 13.7019 ns | 0.0471 ns | 0.0441 ns | 13.6907 ns |  0.78 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 20.4079 ns | 0.0301 ns | 0.0281 ns | 20.4101 ns |  1.17 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 20.3916 ns | 0.0196 ns | 0.0183 ns | 20.3920 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 16.8713 ns | 0.0177 ns | 0.0157 ns | 16.8759 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 16.9728 ns | 0.0236 ns | 0.0209 ns | 16.9739 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 13.2655 ns | 0.0646 ns | 0.0573 ns | 13.2920 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 | 19.7667 ns | 0.0252 ns | 0.0223 ns | 19.7607 ns |  1.17 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 19.7433 ns | 0.0258 ns | 0.0228 ns | 19.7480 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 17.4471 ns | 0.0249 ns | 0.0233 ns | 17.4495 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 17.5205 ns | 0.1063 ns | 0.0995 ns | 17.5820 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 13.6169 ns | 0.0253 ns | 0.0236 ns | 13.6156 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 20.7925 ns | 0.1372 ns | 0.1283 ns | 20.8832 ns |  1.19 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 20.6558 ns | 0.0341 ns | 0.0302 ns | 20.6588 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 17.7083 ns | 0.0195 ns | 0.0173 ns | 17.7074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 17.2725 ns | 0.0226 ns | 0.0211 ns | 17.2706 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 13.6076 ns | 0.0216 ns | 0.0202 ns | 13.6028 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 19.9445 ns | 0.0211 ns | 0.0197 ns | 19.9503 ns |  1.13 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 19.9786 ns | 0.0189 ns | 0.0167 ns | 19.9774 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 18.5226 ns | 0.0223 ns | 0.0209 ns | 18.5217 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 18.1602 ns | 0.0232 ns | 0.0205 ns | 18.1643 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 14.7487 ns | 0.0193 ns | 0.0181 ns | 14.7445 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 21.5418 ns | 0.0412 ns | 0.0385 ns | 21.5342 ns |  1.16 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 21.5247 ns | 0.0160 ns | 0.0150 ns | 21.5292 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 17.4412 ns | 0.0221 ns | 0.0206 ns | 17.4421 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 17.2669 ns | 0.0254 ns | 0.0225 ns | 17.2602 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 13.6005 ns | 0.0165 ns | 0.0146 ns | 13.5996 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 19.7860 ns | 0.1343 ns | 0.1256 ns | 19.8555 ns |  1.13 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 | 19.6534 ns | 0.0403 ns | 0.0357 ns | 19.6504 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 18.3470 ns | 0.0276 ns | 0.0245 ns | 18.3450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 18.1159 ns | 0.0179 ns | 0.0149 ns | 18.1094 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 14.8121 ns | 0.0199 ns | 0.0186 ns | 14.8130 ns |  0.81 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 21.2916 ns | 0.0215 ns | 0.0201 ns | 21.2910 ns |  1.16 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 21.2718 ns | 0.0271 ns | 0.0240 ns | 21.2749 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 19.6770 ns | 0.0772 ns | 0.0722 ns | 19.7016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 19.1965 ns | 0.0231 ns | 0.0216 ns | 19.1997 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 15.8887 ns | 0.0461 ns | 0.0431 ns | 15.8975 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 22.0103 ns | 0.0470 ns | 0.0417 ns | 21.9997 ns |  1.12 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 | 22.0889 ns | 0.0368 ns | 0.0326 ns | 22.0980 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 19.5512 ns | 0.0196 ns | 0.0183 ns | 19.5552 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 19.3435 ns | 0.0198 ns | 0.0185 ns | 19.3472 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 15.9362 ns | 0.0234 ns | 0.0207 ns | 15.9345 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 22.5619 ns | 0.1653 ns | 0.1546 ns | 22.6461 ns |  1.15 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 22.3865 ns | 0.0343 ns | 0.0287 ns | 22.3912 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 19.3151 ns | 0.0313 ns | 0.0278 ns | 19.3147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 19.1923 ns | 0.0222 ns | 0.0174 ns | 19.1950 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 15.6639 ns | 0.0199 ns | 0.0176 ns | 15.6623 ns |  0.81 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 22.0377 ns | 0.0143 ns | 0.0126 ns | 22.0429 ns |  1.14 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 22.2921 ns | 0.0200 ns | 0.0187 ns | 22.2915 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 20.1063 ns | 0.1375 ns | 0.1286 ns | 20.1862 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 19.7995 ns | 0.0171 ns | 0.0151 ns | 19.8005 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 16.6782 ns | 0.0169 ns | 0.0150 ns | 16.6835 ns |  0.83 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 23.0102 ns | 0.0256 ns | 0.0227 ns | 23.0017 ns |  1.14 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 23.0356 ns | 0.0271 ns | 0.0226 ns | 23.0348 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 34.6474 ns | 0.0427 ns | 0.0378 ns | 34.6470 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 33.8386 ns | 0.0436 ns | 0.0408 ns | 33.8468 ns |  0.98 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 23.2962 ns | 0.0309 ns | 0.0274 ns | 23.2933 ns |  0.67 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 30.7607 ns | 0.1695 ns | 0.1585 ns | 30.8341 ns |  0.89 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 30.4835 ns | 0.0551 ns | 0.0515 ns | 30.4873 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 39.3978 ns | 0.0528 ns | 0.0468 ns | 39.4074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 38.7660 ns | 0.0481 ns | 0.0426 ns | 38.7735 ns |  0.98 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 29.2649 ns | 0.0449 ns | 0.0420 ns | 29.2724 ns |  0.74 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 34.7872 ns | 0.0437 ns | 0.0409 ns | 34.7831 ns |  0.88 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 35.0859 ns | 0.0396 ns | 0.0351 ns | 35.0921 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 11.8155 ns | 0.0101 ns | 0.0089 ns | 11.8166 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 11.3834 ns | 0.0108 ns | 0.0101 ns | 11.3824 ns |  0.96 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  7.3478 ns | 0.0121 ns | 0.0113 ns |  7.3499 ns |  0.62 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 14.3148 ns | 0.0178 ns | 0.0158 ns | 14.3114 ns |  1.21 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 | 14.3054 ns | 0.0238 ns | 0.0223 ns | 14.3140 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 10.0716 ns | 0.0112 ns | 0.0105 ns | 10.0714 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  8.5148 ns | 0.0173 ns | 0.0162 ns |  8.5188 ns |  0.85 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  2.4228 ns | 0.0170 ns | 0.0142 ns |  2.4262 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  8.8540 ns | 0.0710 ns | 0.0665 ns |  8.8153 ns |  0.88 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  8.6740 ns | 0.0088 ns | 0.0082 ns |  8.6733 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.6095 ns | 0.0182 ns | 0.0162 ns |  9.6089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.0922 ns | 0.0205 ns | 0.0181 ns | 14.0904 ns |  1.47 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.8517 ns | 0.0180 ns | 0.0151 ns | 14.8539 ns |  1.55 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 13.3529 ns | 0.0207 ns | 0.0183 ns | 13.3521 ns |  1.39 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.4973 ns | 0.0104 ns | 0.0097 ns | 13.4945 ns |  1.40 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 20.9647 ns | 0.0308 ns | 0.0288 ns | 20.9646 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 21.6008 ns | 0.0415 ns | 0.0388 ns | 21.6125 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 19.7354 ns | 0.0239 ns | 0.0211 ns | 19.7406 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 32.3154 ns | 0.0391 ns | 0.0347 ns | 32.3149 ns |  1.54 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 34.0885 ns | 0.0610 ns | 0.0540 ns | 34.0811 ns |  1.63 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.0065 ns | 0.0023 ns | 0.0022 ns |  1.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7238 ns | 0.0028 ns | 0.0026 ns |  0.7242 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.9447 ns | 0.0039 ns | 0.0036 ns |  0.9436 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7164 ns | 0.0110 ns | 0.0103 ns |  0.7222 ns |  0.71 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7209 ns | 0.0029 ns | 0.0027 ns |  0.7206 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.9846 ns | 0.0024 ns | 0.0021 ns |  0.9843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9355 ns | 0.0183 ns | 0.0172 ns |  0.9452 ns |  0.95 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  0.6704 ns | 0.0074 ns | 0.0066 ns |  0.6716 ns |  0.68 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  0.7138 ns | 0.0022 ns | 0.0021 ns |  0.7139 ns |  0.72 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  0.7078 ns | 0.0029 ns | 0.0027 ns |  0.7078 ns |  0.72 |    0.00 |     - |     - |     - |         - |
