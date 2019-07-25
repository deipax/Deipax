
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |   1.1918 ns | 0.0052 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.1918 ns | 0.0035 ns | 0.0029 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.1435 ns | 0.0035 ns | 0.0029 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |   0.7160 ns | 0.0052 ns | 0.0049 ns |  0.60 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |   0.4884 ns | 0.0069 ns | 0.0058 ns |  0.41 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  10.1172 ns | 0.0178 ns | 0.0167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  10.2741 ns | 0.0149 ns | 0.0133 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.7376 ns | 0.0083 ns | 0.0077 ns |  0.47 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  10.2236 ns | 0.0198 ns | 0.0165 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  10.2225 ns | 0.0161 ns | 0.0151 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   1.4242 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   1.4384 ns | 0.0061 ns | 0.0057 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.1095 ns | 0.0069 ns | 0.0062 ns |  0.78 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |   0.9593 ns | 0.0112 ns | 0.0105 ns |  0.67 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |   0.6621 ns | 0.0065 ns | 0.0054 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   9.9164 ns | 0.0490 ns | 0.0459 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  10.2865 ns | 0.0112 ns | 0.0087 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.7375 ns | 0.0052 ns | 0.0048 ns |  0.48 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  10.2105 ns | 0.0192 ns | 0.0180 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  10.2433 ns | 0.0310 ns | 0.0275 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   1.1913 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   1.1906 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   1.3520 ns | 0.0043 ns | 0.0040 ns |  1.13 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |   0.7185 ns | 0.0059 ns | 0.0056 ns |  0.60 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |   0.5384 ns | 0.0043 ns | 0.0036 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   9.6347 ns | 0.0229 ns | 0.0214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  10.2792 ns | 0.0153 ns | 0.0143 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   4.7110 ns | 0.0142 ns | 0.0111 ns |  0.49 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  11.6231 ns | 0.0299 ns | 0.0265 ns |  1.21 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  10.2303 ns | 0.0304 ns | 0.0270 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   1.4286 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   1.4193 ns | 0.0041 ns | 0.0036 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   1.2055 ns | 0.0039 ns | 0.0035 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |   0.9605 ns | 0.0050 ns | 0.0046 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   0.6620 ns | 0.0047 ns | 0.0039 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  10.0654 ns | 0.0348 ns | 0.0325 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  10.2771 ns | 0.0195 ns | 0.0182 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   4.9328 ns | 0.0114 ns | 0.0095 ns |  0.49 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  10.2269 ns | 0.0189 ns | 0.0177 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  10.2141 ns | 0.0171 ns | 0.0151 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   0.9542 ns | 0.0089 ns | 0.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   1.1882 ns | 0.0048 ns | 0.0044 ns |  1.25 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   1.1364 ns | 0.0036 ns | 0.0033 ns |  1.19 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |   0.7172 ns | 0.0043 ns | 0.0038 ns |  0.75 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |   0.4847 ns | 0.0038 ns | 0.0034 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   9.5977 ns | 0.0131 ns | 0.0109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  10.2820 ns | 0.0259 ns | 0.0229 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   4.6993 ns | 0.0069 ns | 0.0064 ns |  0.49 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  10.2226 ns | 0.0231 ns | 0.0205 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  10.2249 ns | 0.0200 ns | 0.0187 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   1.1317 ns | 0.0112 ns | 0.0105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   1.4478 ns | 0.0136 ns | 0.0128 ns |  1.28 |    0.02 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   1.2361 ns | 0.0035 ns | 0.0033 ns |  1.09 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |   0.9585 ns | 0.0037 ns | 0.0035 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |   0.6564 ns | 0.0058 ns | 0.0052 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   9.6264 ns | 0.0542 ns | 0.0507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  10.2821 ns | 0.0143 ns | 0.0126 ns |  1.07 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   4.6985 ns | 0.0077 ns | 0.0065 ns |  0.49 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  10.2309 ns | 0.0315 ns | 0.0294 ns |  1.06 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  10.3497 ns | 0.0354 ns | 0.0331 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   0.9572 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   1.1879 ns | 0.0036 ns | 0.0034 ns |  1.24 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   1.3895 ns | 0.0121 ns | 0.0095 ns |  1.45 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |   0.7157 ns | 0.0030 ns | 0.0025 ns |  0.75 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |   0.5412 ns | 0.0024 ns | 0.0021 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   9.8392 ns | 0.0147 ns | 0.0130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  10.3136 ns | 0.0283 ns | 0.0265 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   4.7286 ns | 0.0075 ns | 0.0066 ns |  0.48 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  10.2207 ns | 0.0189 ns | 0.0158 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  10.2203 ns | 0.0142 ns | 0.0119 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   1.1911 ns | 0.0098 ns | 0.0091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   1.4185 ns | 0.0043 ns | 0.0040 ns |  1.19 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   1.2838 ns | 0.0046 ns | 0.0043 ns |  1.08 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |   0.9785 ns | 0.0048 ns | 0.0045 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |   0.6788 ns | 0.0081 ns | 0.0072 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  10.0462 ns | 0.0193 ns | 0.0161 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  10.3410 ns | 0.0399 ns | 0.0333 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   4.9224 ns | 0.0629 ns | 0.0588 ns |  0.49 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  10.2127 ns | 0.0185 ns | 0.0154 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  10.2269 ns | 0.0170 ns | 0.0133 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   0.9809 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   1.1909 ns | 0.0038 ns | 0.0032 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   1.2776 ns | 0.0048 ns | 0.0045 ns |  1.30 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   0.7165 ns | 0.0035 ns | 0.0031 ns |  0.73 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   0.6917 ns | 0.0074 ns | 0.0070 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   1.7603 ns | 0.0032 ns | 0.0028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   1.8031 ns | 0.0042 ns | 0.0038 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   1.6794 ns | 0.0043 ns | 0.0039 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   1.6352 ns | 0.0051 ns | 0.0047 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   1.6423 ns | 0.0063 ns | 0.0056 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   1.1630 ns | 0.0075 ns | 0.0070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   1.2102 ns | 0.0049 ns | 0.0041 ns |  1.04 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   1.2660 ns | 0.0036 ns | 0.0030 ns |  1.09 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |   0.7149 ns | 0.0046 ns | 0.0038 ns |  0.61 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |   0.4878 ns | 0.0037 ns | 0.0033 ns |  0.42 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   1.7047 ns | 0.0055 ns | 0.0049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   1.9433 ns | 0.0076 ns | 0.0064 ns |  1.14 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   1.7202 ns | 0.0156 ns | 0.0122 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   1.6710 ns | 0.0043 ns | 0.0038 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   1.6763 ns | 0.0096 ns | 0.0090 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.5715 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.4228 ns | 0.0056 ns | 0.0053 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.3098 ns | 0.0104 ns | 0.0097 ns |  0.83 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.9414 ns | 0.0095 ns | 0.0084 ns |  0.60 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.6414 ns | 0.0035 ns | 0.0030 ns |  0.41 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  10.7031 ns | 0.0432 ns | 0.0405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  10.2892 ns | 0.0198 ns | 0.0186 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.7054 ns | 0.0108 ns | 0.0096 ns |  0.44 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  10.3090 ns | 0.0264 ns | 0.0247 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  10.2325 ns | 0.0174 ns | 0.0154 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.2005 ns | 0.0069 ns | 0.0061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.6126 ns | 0.0037 ns | 0.0035 ns |  1.34 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.3075 ns | 0.0039 ns | 0.0036 ns |  1.09 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.7427 ns | 0.0052 ns | 0.0044 ns |  0.62 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.5399 ns | 0.0060 ns | 0.0056 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.9176 ns | 0.0051 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.7554 ns | 0.0060 ns | 0.0054 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.6635 ns | 0.0046 ns | 0.0041 ns |  0.87 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.7575 ns | 0.0085 ns | 0.0080 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.6397 ns | 0.0056 ns | 0.0049 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |   8.8465 ns | 0.0278 ns | 0.0246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |   8.8853 ns | 0.0236 ns | 0.0210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |   2.8250 ns | 0.0112 ns | 0.0105 ns |  0.32 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  11.4019 ns | 0.0243 ns | 0.0228 ns |  1.29 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  11.2824 ns | 0.0570 ns | 0.0533 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |   1.6818 ns | 0.0055 ns | 0.0052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |   2.0374 ns | 0.0067 ns | 0.0063 ns |  1.21 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |   2.0452 ns | 0.0034 ns | 0.0030 ns |  1.22 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |   1.8121 ns | 0.0051 ns | 0.0045 ns |  1.08 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |   1.6587 ns | 0.0039 ns | 0.0035 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   1.4868 ns | 0.0050 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   1.7844 ns | 0.0033 ns | 0.0028 ns |  1.20 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   1.7457 ns | 0.0052 ns | 0.0049 ns |  1.17 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.9110 ns | 0.0114 ns | 0.0101 ns |  1.29 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.8747 ns | 0.0052 ns | 0.0046 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   1.7388 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   1.7274 ns | 0.0051 ns | 0.0045 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.5910 ns | 0.0088 ns | 0.0074 ns |  0.91 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   1.5657 ns | 0.0060 ns | 0.0056 ns |  0.90 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   1.4642 ns | 0.0046 ns | 0.0041 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.8785 ns | 0.0286 ns | 0.0267 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   4.6626 ns | 0.0126 ns | 0.0118 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.5892 ns | 0.0487 ns | 0.0380 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   3.8707 ns | 0.0222 ns | 0.0208 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   3.8314 ns | 0.0273 ns | 0.0242 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 328.7136 ns | 1.2225 ns | 1.1435 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
          To_String | .NET Core 2.2 | 277.0185 ns | 0.6367 ns | 0.5955 ns |  0.84 |    0.00 | 0.0262 |     - |     - |     168 B |
          To_String | .NET Core 3.0 | 226.3343 ns | 0.8217 ns | 0.7284 ns |  0.69 |    0.00 | 0.0100 |     - |     - |      64 B |
          To_String |        net461 | 327.5816 ns | 1.1742 ns | 1.0409 ns |  1.00 |    0.01 | 0.0300 |     - |     - |     192 B |
          To_String |        net472 | 325.1597 ns | 1.6098 ns | 1.4270 ns |  0.99 |    0.01 | 0.0300 |     - |     - |     192 B |
                    |               |             |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  12.4473 ns | 0.0165 ns | 0.0155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  12.0626 ns | 0.0143 ns | 0.0133 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |   7.9052 ns | 0.0158 ns | 0.0148 ns |  0.64 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  14.9617 ns | 0.0421 ns | 0.0373 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  15.3147 ns | 0.0672 ns | 0.0629 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  17.4741 ns | 0.0351 ns | 0.0311 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  17.1241 ns | 0.0278 ns | 0.0260 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |   8.1401 ns | 0.0172 ns | 0.0161 ns |  0.47 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  20.7900 ns | 0.0407 ns | 0.0381 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  20.8198 ns | 0.0328 ns | 0.0306 ns |  1.19 |    0.00 |      - |     - |     - |         - |
