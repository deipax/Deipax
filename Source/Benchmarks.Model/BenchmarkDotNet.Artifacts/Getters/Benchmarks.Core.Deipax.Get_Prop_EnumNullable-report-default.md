
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
             ToBool | .NET Core 2.0 |  1.4360 ns | 0.0037 ns | 0.0035 ns |  1.4352 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6110 ns | 0.0025 ns | 0.0023 ns |  1.6116 ns |  1.12 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.5426 ns | 0.0027 ns | 0.0024 ns |  1.5428 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  1.1753 ns | 0.0028 ns | 0.0026 ns |  1.1757 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.9842 ns | 0.0031 ns | 0.0029 ns |  0.9840 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.1740 ns | 0.0044 ns | 0.0039 ns |  4.1749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.3930 ns | 0.0042 ns | 0.0035 ns |  4.3924 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.3968 ns | 0.0039 ns | 0.0035 ns |  4.3969 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.8640 ns | 0.0074 ns | 0.0069 ns |  4.8652 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.8290 ns | 0.0037 ns | 0.0035 ns |  4.8298 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.6863 ns | 0.0036 ns | 0.0034 ns |  2.6866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.5885 ns | 0.0063 ns | 0.0056 ns |  2.5893 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.8936 ns | 0.0121 ns | 0.0113 ns |  2.8938 ns |  1.08 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.3470 ns | 0.0033 ns | 0.0029 ns |  2.3471 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.0985 ns | 0.0048 ns | 0.0045 ns |  2.0998 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.0961 ns | 0.0044 ns | 0.0041 ns |  5.0957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.0867 ns | 0.0037 ns | 0.0032 ns |  5.0875 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7176 ns | 0.0274 ns | 0.0256 ns |  4.7309 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3699 ns | 0.0046 ns | 0.0043 ns |  5.3707 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.2961 ns | 0.0075 ns | 0.0062 ns |  5.2974 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.5977 ns | 0.0048 ns | 0.0045 ns |  2.5977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.9154 ns | 0.0055 ns | 0.0048 ns |  2.9146 ns |  1.12 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.6864 ns | 0.0044 ns | 0.0041 ns |  2.6862 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.3477 ns | 0.0050 ns | 0.0042 ns |  2.3468 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.0510 ns | 0.0027 ns | 0.0024 ns |  2.0519 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  5.0939 ns | 0.0072 ns | 0.0067 ns |  5.0944 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  5.0837 ns | 0.0070 ns | 0.0059 ns |  5.0858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.6273 ns | 0.0059 ns | 0.0055 ns |  4.6298 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3213 ns | 0.0060 ns | 0.0056 ns |  5.3219 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.2925 ns | 0.0072 ns | 0.0068 ns |  5.2946 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  3.1601 ns | 0.0332 ns | 0.0294 ns |  3.1644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.5938 ns | 0.0052 ns | 0.0049 ns |  2.5924 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.7813 ns | 0.0050 ns | 0.0039 ns |  2.7812 ns |  0.88 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  2.3683 ns | 0.0051 ns | 0.0048 ns |  2.3668 ns |  0.75 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  2.1151 ns | 0.0026 ns | 0.0025 ns |  2.1157 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.0837 ns | 0.0044 ns | 0.0041 ns |  5.0836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.0854 ns | 0.0061 ns | 0.0054 ns |  5.0835 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7229 ns | 0.0056 ns | 0.0052 ns |  4.7232 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3201 ns | 0.0053 ns | 0.0049 ns |  5.3196 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.2906 ns | 0.0069 ns | 0.0064 ns |  5.2892 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.8196 ns | 0.0044 ns | 0.0041 ns |  2.8189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.9058 ns | 0.0038 ns | 0.0035 ns |  2.9053 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  3.1154 ns | 0.0128 ns | 0.0114 ns |  3.1151 ns |  1.10 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  2.3345 ns | 0.0059 ns | 0.0055 ns |  2.3350 ns |  0.83 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  2.1115 ns | 0.0037 ns | 0.0035 ns |  2.1108 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.0966 ns | 0.0044 ns | 0.0042 ns |  5.0957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.0828 ns | 0.0070 ns | 0.0062 ns |  5.0829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.7369 ns | 0.0200 ns | 0.0187 ns |  4.7396 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3228 ns | 0.0063 ns | 0.0056 ns |  5.3230 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.2943 ns | 0.0034 ns | 0.0030 ns |  5.2942 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.9315 ns | 0.0114 ns | 0.0106 ns |  2.9337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.8319 ns | 0.0131 ns | 0.0109 ns |  2.8358 ns |  0.97 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.5972 ns | 0.0051 ns | 0.0048 ns |  2.5978 ns |  0.89 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.4019 ns | 0.0040 ns | 0.0038 ns |  2.4026 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.1242 ns | 0.0029 ns | 0.0026 ns |  2.1247 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  5.0876 ns | 0.0073 ns | 0.0064 ns |  5.0888 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  5.0874 ns | 0.0049 ns | 0.0046 ns |  5.0881 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.6980 ns | 0.0055 ns | 0.0052 ns |  4.6968 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3199 ns | 0.0052 ns | 0.0048 ns |  5.3193 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.2887 ns | 0.0059 ns | 0.0055 ns |  5.2880 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4347 ns | 0.0039 ns | 0.0036 ns |  1.4357 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7582 ns | 0.0108 ns | 0.0090 ns |  1.7611 ns |  1.23 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.7625 ns | 0.0020 ns | 0.0018 ns |  1.7625 ns |  1.23 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  1.4185 ns | 0.0023 ns | 0.0021 ns |  1.4190 ns |  0.99 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.1373 ns | 0.0029 ns | 0.0025 ns |  1.1374 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.1701 ns | 0.0055 ns | 0.0051 ns |  4.1713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2440 ns | 0.0036 ns | 0.0033 ns |  4.2431 ns |  1.02 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0040 ns | 0.0038 ns | 0.0034 ns |  4.0044 ns |  0.96 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4035 ns | 0.0061 ns | 0.0054 ns |  4.4055 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3721 ns | 0.0062 ns | 0.0055 ns |  4.3714 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.9197 ns | 0.0110 ns | 0.0097 ns |  1.9231 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6388 ns | 0.0029 ns | 0.0025 ns |  1.6393 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4141 ns | 0.0076 ns | 0.0071 ns |  1.4164 ns |  0.74 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.3274 ns | 0.0185 ns | 0.0173 ns |  2.3314 ns |  1.21 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.0827 ns | 0.0024 ns | 0.0019 ns |  2.0834 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.3962 ns | 0.0058 ns | 0.0055 ns |  4.3947 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.3879 ns | 0.0047 ns | 0.0041 ns |  4.3879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0077 ns | 0.0052 ns | 0.0046 ns |  4.0085 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.0940 ns | 0.0072 ns | 0.0068 ns |  5.0937 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.0666 ns | 0.0065 ns | 0.0060 ns |  5.0656 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.3836 ns | 0.0031 ns | 0.0028 ns |  1.3828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4218 ns | 0.0030 ns | 0.0027 ns |  1.4216 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.7665 ns | 0.0045 ns | 0.0042 ns |  1.7666 ns |  1.28 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.4001 ns | 0.0025 ns | 0.0024 ns |  1.3999 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.1438 ns | 0.0019 ns | 0.0016 ns |  1.1439 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.0305 ns | 0.0025 ns | 0.0024 ns |  2.0300 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8349 ns | 0.0157 ns | 0.0146 ns |  1.8354 ns |  0.90 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.3035 ns | 0.0047 ns | 0.0039 ns |  2.3044 ns |  1.13 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.1545 ns | 0.0033 ns | 0.0029 ns |  2.1535 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.0822 ns | 0.0034 ns | 0.0032 ns |  2.0825 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.9236 ns | 0.0031 ns | 0.0029 ns |  1.9246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6426 ns | 0.0025 ns | 0.0023 ns |  1.6422 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.6727 ns | 0.0035 ns | 0.0032 ns |  1.6719 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  2.4336 ns | 0.0126 ns | 0.0118 ns |  2.4389 ns |  1.27 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  2.1639 ns | 0.0036 ns | 0.0030 ns |  2.1645 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.2833 ns | 0.0136 ns | 0.0121 ns |  2.2839 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.0954 ns | 0.0045 ns | 0.0040 ns |  2.0954 ns |  0.92 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.3380 ns | 0.0076 ns | 0.0071 ns |  2.3391 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  3.1337 ns | 0.0052 ns | 0.0049 ns |  3.1344 ns |  1.37 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.8307 ns | 0.0058 ns | 0.0051 ns |  2.8320 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3296 ns | 0.0022 ns | 0.0021 ns |  1.3293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3825 ns | 0.0036 ns | 0.0034 ns |  1.3816 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4434 ns | 0.0040 ns | 0.0037 ns |  1.4438 ns |  1.09 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.4135 ns | 0.0031 ns | 0.0029 ns |  1.4134 ns |  1.06 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.7414 ns | 0.0711 ns | 0.2095 ns |  1.7783 ns |  1.29 |    0.16 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4469 ns | 0.0126 ns | 0.0112 ns |  4.4505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.6262 ns | 0.0090 ns | 0.0084 ns |  4.6262 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.6943 ns | 0.0056 ns | 0.0050 ns |  4.6947 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.0943 ns | 0.0032 ns | 0.0027 ns |  5.0949 ns |  1.15 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.0672 ns | 0.0057 ns | 0.0053 ns |  5.0674 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3113 ns | 0.0028 ns | 0.0026 ns |  1.3116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.3715 ns | 0.0025 ns | 0.0022 ns |  1.3714 ns |  1.05 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5412 ns | 0.0028 ns | 0.0025 ns |  1.5400 ns |  1.18 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.1401 ns | 0.0026 ns | 0.0023 ns |  1.1399 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.9634 ns | 0.0025 ns | 0.0021 ns |  0.9637 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.0255 ns | 0.0028 ns | 0.0026 ns |  2.0251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0803 ns | 0.0019 ns | 0.0018 ns |  2.0804 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.0245 ns | 0.0080 ns | 0.0075 ns |  2.0223 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.6038 ns | 0.0090 ns | 0.0076 ns |  2.6049 ns |  1.29 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5780 ns | 0.0106 ns | 0.0099 ns |  2.5796 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.9969 ns | 0.0096 ns | 0.0085 ns |  5.9972 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0114 ns | 0.0064 ns | 0.0060 ns |  6.0122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.1173 ns | 0.0162 ns | 0.0143 ns |  6.1207 ns |  1.02 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.2588 ns | 0.0071 ns | 0.0066 ns |  6.2592 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.2254 ns | 0.0084 ns | 0.0079 ns |  6.2260 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.6730 ns | 0.0243 ns | 0.0215 ns | 18.6727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.2910 ns | 0.0320 ns | 0.0299 ns | 18.2841 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.5287 ns | 0.0183 ns | 0.0143 ns | 12.5260 ns |  0.67 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 26.2843 ns | 0.0352 ns | 0.0294 ns | 26.2822 ns |  1.41 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.5039 ns | 0.0189 ns | 0.0177 ns | 18.4974 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0198 ns | 0.0033 ns | 0.0031 ns |  2.0200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.2999 ns | 0.0034 ns | 0.0032 ns |  2.2996 ns |  1.14 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3373 ns | 0.0080 ns | 0.0075 ns |  2.3378 ns |  1.16 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1824 ns | 0.0020 ns | 0.0019 ns |  1.1828 ns |  0.59 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.2308 ns | 0.0510 ns | 0.0748 ns |  1.2421 ns |  0.61 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9890 ns | 0.0161 ns | 0.0143 ns |  7.9919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.6049 ns | 0.0136 ns | 0.0127 ns |  8.6054 ns |  1.08 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9423 ns | 0.0023 ns | 0.0022 ns |  1.9425 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1548 ns | 0.0157 ns | 0.0147 ns |  8.1533 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4998 ns | 0.0106 ns | 0.0094 ns |  8.5008 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.7589 ns | 0.0113 ns | 0.0105 ns |  3.7563 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5371 ns | 0.0074 ns | 0.0069 ns |  4.5391 ns |  1.21 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5129 ns | 0.0329 ns | 0.0308 ns |  4.5188 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8257 ns | 0.0082 ns | 0.0072 ns |  3.8257 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.9652 ns | 0.0062 ns | 0.0055 ns |  3.9652 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 27.8017 ns | 0.0243 ns | 0.0215 ns | 27.8011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 2.2 | 28.1786 ns | 0.0361 ns | 0.0338 ns | 28.1797 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 3.0 | 23.4201 ns | 0.0497 ns | 0.0441 ns | 23.4296 ns |  0.84 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 30.5605 ns | 0.0319 ns | 0.0298 ns | 30.5582 ns |  1.10 |    0.00 |      - |     - |     - |         - |
          To_String |        net472 | 30.3123 ns | 0.0414 ns | 0.0387 ns | 30.3083 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  1.3784 ns | 0.0091 ns | 0.0076 ns |  1.3803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.9218 ns | 0.0656 ns | 0.1324 ns |  1.9160 ns |  1.38 |    0.10 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.5702 ns | 0.0030 ns | 0.0027 ns |  1.5696 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 |  2.1676 ns | 0.0028 ns | 0.0027 ns |  2.1681 ns |  1.57 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 |  1.8814 ns | 0.0035 ns | 0.0029 ns |  1.8812 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  1.0822 ns | 0.0014 ns | 0.0011 ns |  1.0822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  1.1535 ns | 0.0022 ns | 0.0020 ns |  1.1543 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  1.1751 ns | 0.0059 ns | 0.0053 ns |  1.1757 ns |  1.09 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  1.1776 ns | 0.0021 ns | 0.0018 ns |  1.1779 ns |  1.09 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  0.9221 ns | 0.0020 ns | 0.0017 ns |  0.9222 ns |  0.85 |    0.00 |      - |     - |     - |         - |
