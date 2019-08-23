
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 | 16.5886 ns | 0.0588 ns | 0.0491 ns | 16.6075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 | 16.4232 ns | 0.0194 ns | 0.0181 ns | 16.4227 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  9.4520 ns | 0.0253 ns | 0.0237 ns |  9.4556 ns |  0.57 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 | 17.0726 ns | 0.0263 ns | 0.0233 ns | 17.0739 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 | 16.9660 ns | 0.0203 ns | 0.0190 ns | 16.9612 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 | 19.8705 ns | 0.0295 ns | 0.0261 ns | 19.8719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 20.1769 ns | 0.0202 ns | 0.0179 ns | 20.1822 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 | 13.5858 ns | 0.0254 ns | 0.0225 ns | 13.5849 ns |  0.68 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 | 20.7646 ns | 0.0269 ns | 0.0238 ns | 20.7625 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 | 20.8496 ns | 0.0179 ns | 0.0167 ns | 20.8494 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  0.8671 ns | 0.0038 ns | 0.0035 ns |  0.8671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  0.9326 ns | 0.0024 ns | 0.0022 ns |  0.9330 ns |  1.08 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1674 ns | 0.0025 ns | 0.0024 ns |  1.1682 ns |  1.35 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  0.4278 ns | 0.0016 ns | 0.0014 ns |  0.4276 ns |  0.49 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  0.7243 ns | 0.0013 ns | 0.0012 ns |  0.7246 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9630 ns | 0.0055 ns | 0.0051 ns |  3.9647 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1715 ns | 0.0048 ns | 0.0042 ns |  4.1719 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0147 ns | 0.0074 ns | 0.0069 ns |  4.0149 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1444 ns | 0.0058 ns | 0.0054 ns |  4.1432 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1860 ns | 0.0104 ns | 0.0098 ns |  4.1888 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 | 23.3594 ns | 0.0227 ns | 0.0212 ns | 23.3645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 23.7686 ns | 0.0250 ns | 0.0233 ns | 23.7677 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 | 12.0688 ns | 0.1431 ns | 0.1269 ns | 12.1305 ns |  0.52 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 | 23.5565 ns | 0.0204 ns | 0.0190 ns | 23.5607 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 | 23.6898 ns | 0.0236 ns | 0.0221 ns | 23.6862 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 27.6824 ns | 0.1116 ns | 0.1044 ns | 27.7173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 27.4893 ns | 0.0277 ns | 0.0259 ns | 27.4955 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 | 15.5272 ns | 0.0151 ns | 0.0134 ns | 15.5274 ns |  0.56 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 | 27.9012 ns | 0.0140 ns | 0.0116 ns | 27.9036 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 | 27.5268 ns | 0.0257 ns | 0.0214 ns | 27.5264 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 | 23.5268 ns | 0.0348 ns | 0.0309 ns | 23.5304 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 23.5735 ns | 0.0142 ns | 0.0132 ns | 23.5725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 | 11.8535 ns | 0.0157 ns | 0.0123 ns | 11.8491 ns |  0.50 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 | 23.2964 ns | 0.0481 ns | 0.0426 ns | 23.2898 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 | 23.3904 ns | 0.0161 ns | 0.0151 ns | 23.3950 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 | 27.4802 ns | 0.0225 ns | 0.0200 ns | 27.4827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 27.5226 ns | 0.0247 ns | 0.0231 ns | 27.5203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 | 15.7351 ns | 0.1589 ns | 0.1487 ns | 15.8079 ns |  0.57 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 | 27.2085 ns | 0.0297 ns | 0.0263 ns | 27.2053 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 | 27.5105 ns | 0.0199 ns | 0.0176 ns | 27.5081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 | 24.0218 ns | 0.0367 ns | 0.0325 ns | 24.0251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 23.7862 ns | 0.0339 ns | 0.0283 ns | 23.7791 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 | 12.1542 ns | 0.0944 ns | 0.0883 ns | 12.1935 ns |  0.51 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 | 23.5717 ns | 0.0302 ns | 0.0268 ns | 23.5754 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 | 23.6801 ns | 0.0185 ns | 0.0173 ns | 23.6834 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 | 27.3509 ns | 0.0243 ns | 0.0216 ns | 27.3539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 27.7953 ns | 0.0229 ns | 0.0214 ns | 27.7938 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 | 15.5486 ns | 0.0163 ns | 0.0152 ns | 15.5534 ns |  0.57 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 | 27.7075 ns | 0.0222 ns | 0.0197 ns | 27.7102 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 | 27.9747 ns | 0.0206 ns | 0.0193 ns | 27.9716 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 | 23.5540 ns | 0.0283 ns | 0.0265 ns | 23.5424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 23.5724 ns | 0.0204 ns | 0.0191 ns | 23.5767 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 | 11.9424 ns | 0.1329 ns | 0.1243 ns | 11.8688 ns |  0.51 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 | 23.2929 ns | 0.0313 ns | 0.0293 ns | 23.2984 ns |  0.99 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 | 25.0525 ns | 0.0235 ns | 0.0219 ns | 25.0502 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 27.3180 ns | 0.0300 ns | 0.0266 ns | 27.3188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 27.3408 ns | 0.0717 ns | 0.0671 ns | 27.3502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 | 15.5586 ns | 0.0441 ns | 0.0368 ns | 15.5508 ns |  0.57 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 | 27.8302 ns | 0.1477 ns | 0.1382 ns | 27.9047 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 | 27.2862 ns | 0.0164 ns | 0.0153 ns | 27.2841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 | 22.9308 ns | 0.0188 ns | 0.0176 ns | 22.9269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 23.1140 ns | 0.0170 ns | 0.0150 ns | 23.1136 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 | 11.5457 ns | 0.1297 ns | 0.1214 ns | 11.6306 ns |  0.50 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 | 16.8189 ns | 0.0178 ns | 0.0149 ns | 16.8171 ns |  0.73 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 | 16.9231 ns | 0.0705 ns | 0.0660 ns | 16.9035 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 | 26.9877 ns | 0.0224 ns | 0.0209 ns | 26.9903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 26.7928 ns | 0.0283 ns | 0.0264 ns | 26.7867 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 | 15.3384 ns | 0.0911 ns | 0.0853 ns | 15.3789 ns |  0.57 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 | 20.5220 ns | 0.0362 ns | 0.0303 ns | 20.5098 ns |  0.76 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 | 20.1073 ns | 0.0169 ns | 0.0150 ns | 20.1092 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 | 22.9753 ns | 0.0227 ns | 0.0201 ns | 22.9723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 22.8938 ns | 0.0252 ns | 0.0235 ns | 22.8905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 | 11.3853 ns | 0.0085 ns | 0.0076 ns | 11.3866 ns |  0.50 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 | 22.6935 ns | 0.0173 ns | 0.0153 ns | 22.6905 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 | 22.8260 ns | 0.0758 ns | 0.0709 ns | 22.8290 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 26.8347 ns | 0.0678 ns | 0.0635 ns | 26.8476 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 26.8134 ns | 0.0305 ns | 0.0270 ns | 26.8087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 | 15.3774 ns | 0.1527 ns | 0.1428 ns | 15.4651 ns |  0.57 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 | 26.6865 ns | 0.0551 ns | 0.0516 ns | 26.6825 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 | 26.8479 ns | 0.0162 ns | 0.0151 ns | 26.8517 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 | 23.2331 ns | 0.0112 ns | 0.0093 ns | 23.2319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 23.5203 ns | 0.0301 ns | 0.0282 ns | 23.5233 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 | 11.5153 ns | 0.1290 ns | 0.1207 ns | 11.6010 ns |  0.50 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 | 22.9928 ns | 0.0250 ns | 0.0234 ns | 22.9922 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 | 23.1019 ns | 0.0194 ns | 0.0172 ns | 23.0993 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 | 24.3455 ns | 0.0196 ns | 0.0183 ns | 24.3437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 | 24.4135 ns | 0.0263 ns | 0.0246 ns | 24.4133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 | 13.1157 ns | 0.2188 ns | 0.2047 ns | 12.9625 ns |  0.54 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 | 24.5028 ns | 0.0314 ns | 0.0279 ns | 24.4970 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 | 33.5238 ns | 0.0193 ns | 0.0150 ns | 33.5189 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 | 22.9422 ns | 0.0240 ns | 0.0224 ns | 22.9410 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 23.0873 ns | 0.0241 ns | 0.0214 ns | 23.0889 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 | 11.1621 ns | 0.0096 ns | 0.0090 ns | 11.1594 ns |  0.49 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 | 22.9062 ns | 0.0197 ns | 0.0175 ns | 22.9081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 | 22.9391 ns | 0.0300 ns | 0.0266 ns | 22.9358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 | 24.2398 ns | 0.0692 ns | 0.0614 ns | 24.2561 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 | 24.3361 ns | 0.0914 ns | 0.0855 ns | 24.2853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 | 13.4513 ns | 0.2516 ns | 0.2354 ns | 13.5653 ns |  0.55 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 | 24.2486 ns | 0.0296 ns | 0.0262 ns | 24.2538 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 | 24.9584 ns | 0.0349 ns | 0.0273 ns | 24.9643 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 | 24.9562 ns | 0.1106 ns | 0.1035 ns | 24.9775 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 24.5228 ns | 0.0214 ns | 0.0189 ns | 24.5295 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 | 17.1062 ns | 0.0205 ns | 0.0181 ns | 17.1038 ns |  0.69 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 | 24.3442 ns | 0.0146 ns | 0.0137 ns | 24.3487 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 | 24.3420 ns | 0.0225 ns | 0.0199 ns | 24.3411 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 27.9931 ns | 0.0238 ns | 0.0223 ns | 27.9978 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 28.1802 ns | 0.0201 ns | 0.0188 ns | 28.1849 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 | 20.8365 ns | 0.1614 ns | 0.1510 ns | 20.8877 ns |  0.74 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 | 27.9540 ns | 0.0290 ns | 0.0272 ns | 27.9508 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 | 28.1326 ns | 0.0137 ns | 0.0121 ns | 28.1338 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 | 22.1456 ns | 0.0159 ns | 0.0149 ns | 22.1466 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 | 22.2791 ns | 0.1465 ns | 0.1299 ns | 22.3233 ns |  1.01 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 | 16.3885 ns | 0.0968 ns | 0.0905 ns | 16.3426 ns |  0.74 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 | 21.8094 ns | 0.0239 ns | 0.0212 ns | 21.8087 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 | 21.4359 ns | 0.0213 ns | 0.0199 ns | 21.4380 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 | 23.2112 ns | 0.0201 ns | 0.0188 ns | 23.2181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 | 23.2326 ns | 0.0172 ns | 0.0153 ns | 23.2306 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 | 17.5549 ns | 0.0276 ns | 0.0258 ns | 17.5563 ns |  0.76 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 | 22.9996 ns | 0.0207 ns | 0.0193 ns | 23.0045 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 | 23.0671 ns | 0.0182 ns | 0.0162 ns | 23.0663 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  1.8994 ns | 0.0023 ns | 0.0020 ns |  1.8995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.8649 ns | 0.0018 ns | 0.0016 ns |  1.8646 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.9630 ns | 0.0030 ns | 0.0027 ns |  1.9624 ns |  1.03 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  2.6257 ns | 0.0045 ns | 0.0042 ns |  2.6255 ns |  1.38 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  2.2109 ns | 0.0036 ns | 0.0030 ns |  2.2115 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.4589 ns | 0.0032 ns | 0.0029 ns |  1.4591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.8517 ns | 0.0028 ns | 0.0027 ns |  1.8517 ns |  1.27 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.6726 ns | 0.0045 ns | 0.0042 ns |  1.6717 ns |  1.15 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.4775 ns | 0.0029 ns | 0.0027 ns |  1.4779 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.5678 ns | 0.0041 ns | 0.0038 ns |  1.5673 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1207 ns | 0.0044 ns | 0.0037 ns |  2.1200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0840 ns | 0.0032 ns | 0.0030 ns |  2.0836 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3200 ns | 0.0016 ns | 0.0014 ns |  2.3198 ns |  1.09 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  0.9033 ns | 0.0086 ns | 0.0067 ns |  0.9054 ns |  0.43 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.3606 ns | 0.0023 ns | 0.0022 ns |  1.3607 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8973 ns | 0.0094 ns | 0.0083 ns |  7.8986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3087 ns | 0.0077 ns | 0.0072 ns |  8.3106 ns |  1.05 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9974 ns | 0.0104 ns | 0.0098 ns |  1.9992 ns |  0.25 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 12.2150 ns | 0.0206 ns | 0.0183 ns | 12.2123 ns |  1.55 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.0018 ns | 0.0515 ns | 0.0482 ns |  7.9816 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  4.1775 ns | 0.0173 ns | 0.0153 ns |  4.1730 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 2.2 |  4.9150 ns | 0.0128 ns | 0.0120 ns |  4.9137 ns |  1.18 |    0.00 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 3.0 |  4.9622 ns | 0.0320 ns | 0.0267 ns |  4.9730 ns |  1.19 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject |        net461 |  4.1439 ns | 0.0064 ns | 0.0060 ns |  4.1463 ns |  0.99 |    0.00 | 0.0051 |     - |     - |      32 B |
           ToObject |        net472 |  4.1742 ns | 0.0267 ns | 0.0250 ns |  4.1668 ns |  1.00 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 55.9271 ns | 0.1257 ns | 0.1114 ns | 55.9137 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 47.5836 ns | 0.0802 ns | 0.0711 ns | 47.5685 ns |  0.85 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 48.9338 ns | 0.0802 ns | 0.0711 ns | 48.9140 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 55.8712 ns | 0.0561 ns | 0.0468 ns | 55.8756 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 54.2339 ns | 0.0581 ns | 0.0515 ns | 54.2385 ns |  0.97 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 33.8558 ns | 0.0270 ns | 0.0253 ns | 33.8500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 32.7402 ns | 0.0509 ns | 0.0476 ns | 32.7385 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 23.0109 ns | 0.0219 ns | 0.0194 ns | 23.0104 ns |  0.68 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 28.8814 ns | 0.0390 ns | 0.0365 ns | 28.8756 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 28.9744 ns | 0.0443 ns | 0.0393 ns | 28.9691 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 38.0191 ns | 0.0595 ns | 0.0465 ns | 38.0292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 37.3004 ns | 0.0298 ns | 0.0264 ns | 37.3081 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 27.8028 ns | 0.0502 ns | 0.0445 ns | 27.8087 ns |  0.73 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 32.8617 ns | 0.0602 ns | 0.0534 ns | 32.8437 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 32.9067 ns | 0.0296 ns | 0.0277 ns | 32.9033 ns |  0.87 |    0.00 |      - |     - |     - |         - |
