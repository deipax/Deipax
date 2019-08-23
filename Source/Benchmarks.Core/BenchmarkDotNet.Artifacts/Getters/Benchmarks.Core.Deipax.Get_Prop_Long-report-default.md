
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
             ToBool | .NET Core 2.0 |  1.1728 ns | 0.0045 ns | 0.0042 ns |  1.1723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1168 ns | 0.0020 ns | 0.0018 ns |  1.1171 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4009 ns | 0.0024 ns | 0.0023 ns |  1.4015 ns |  1.19 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.9534 ns | 0.0024 ns | 0.0021 ns |  0.9538 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.9527 ns | 0.0024 ns | 0.0021 ns |  0.9529 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9773 ns | 0.0332 ns | 0.0310 ns |  3.9610 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1377 ns | 0.0055 ns | 0.0051 ns |  4.1380 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0120 ns | 0.0082 ns | 0.0077 ns |  4.0122 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1954 ns | 0.0050 ns | 0.0047 ns |  4.1961 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1574 ns | 0.0075 ns | 0.0070 ns |  4.1575 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.3266 ns | 0.0042 ns | 0.0039 ns |  2.3264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.1055 ns | 0.0063 ns | 0.0056 ns |  2.1044 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.2511 ns | 0.0027 ns | 0.0024 ns |  2.2514 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.6397 ns | 0.0035 ns | 0.0033 ns |  1.6403 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.6450 ns | 0.0089 ns | 0.0075 ns |  1.6466 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.6464 ns | 0.0093 ns | 0.0078 ns |  4.6484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.8317 ns | 0.0076 ns | 0.0071 ns |  4.8317 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7441 ns | 0.0304 ns | 0.0284 ns |  4.7533 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.8679 ns | 0.0315 ns | 0.0295 ns |  4.8685 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.8389 ns | 0.0075 ns | 0.0070 ns |  4.8381 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.5616 ns | 0.0056 ns | 0.0052 ns |  2.5615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.1032 ns | 0.0055 ns | 0.0049 ns |  2.1032 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.1529 ns | 0.0050 ns | 0.0047 ns |  2.1530 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6452 ns | 0.0056 ns | 0.0052 ns |  1.6436 ns |  0.64 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.6387 ns | 0.0039 ns | 0.0033 ns |  1.6377 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.6426 ns | 0.0082 ns | 0.0068 ns |  4.6432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.8292 ns | 0.0089 ns | 0.0069 ns |  4.8304 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.4724 ns | 0.0067 ns | 0.0056 ns |  4.4743 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8827 ns | 0.0236 ns | 0.0221 ns |  4.8878 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8442 ns | 0.0088 ns | 0.0083 ns |  4.8416 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.3300 ns | 0.0031 ns | 0.0029 ns |  2.3303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.5643 ns | 0.0038 ns | 0.0036 ns |  2.5639 ns |  1.10 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.1364 ns | 0.0037 ns | 0.0033 ns |  2.1363 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6700 ns | 0.0033 ns | 0.0031 ns |  1.6696 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  1.6688 ns | 0.0047 ns | 0.0041 ns |  1.6674 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.6576 ns | 0.0072 ns | 0.0064 ns |  4.6595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.8320 ns | 0.0082 ns | 0.0073 ns |  4.8333 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7601 ns | 0.0057 ns | 0.0051 ns |  4.7585 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.8626 ns | 0.0346 ns | 0.0323 ns |  4.8476 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8991 ns | 0.0365 ns | 0.0341 ns |  4.8929 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.7599 ns | 0.0093 ns | 0.0083 ns |  2.7599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.2742 ns | 0.0046 ns | 0.0038 ns |  2.2747 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.1942 ns | 0.0045 ns | 0.0042 ns |  2.1936 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6447 ns | 0.0042 ns | 0.0039 ns |  1.6434 ns |  0.60 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.6453 ns | 0.0035 ns | 0.0031 ns |  1.6460 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.6418 ns | 0.0054 ns | 0.0045 ns |  4.6415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.8755 ns | 0.0156 ns | 0.0146 ns |  4.8792 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4823 ns | 0.0050 ns | 0.0042 ns |  4.4826 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8376 ns | 0.0092 ns | 0.0086 ns |  4.8352 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8380 ns | 0.0088 ns | 0.0078 ns |  4.8388 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.3512 ns | 0.0021 ns | 0.0020 ns |  2.3506 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.1068 ns | 0.0077 ns | 0.0072 ns |  2.1072 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.2516 ns | 0.0039 ns | 0.0035 ns |  2.2514 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.6523 ns | 0.0078 ns | 0.0069 ns |  1.6529 ns |  0.70 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.6436 ns | 0.0034 ns | 0.0030 ns |  1.6439 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.6470 ns | 0.0022 ns | 0.0020 ns |  4.6471 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.8793 ns | 0.0065 ns | 0.0060 ns |  4.8787 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.7079 ns | 0.0051 ns | 0.0048 ns |  4.7076 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.8331 ns | 0.0077 ns | 0.0068 ns |  4.8331 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.8337 ns | 0.0083 ns | 0.0077 ns |  4.8330 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  2.7351 ns | 0.0084 ns | 0.0074 ns |  2.7364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.2956 ns | 0.0046 ns | 0.0038 ns |  2.2959 ns |  0.84 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.4897 ns | 0.0121 ns | 0.0113 ns |  2.4891 ns |  0.91 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  1.6438 ns | 0.0032 ns | 0.0026 ns |  1.6438 ns |  0.60 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.6433 ns | 0.0037 ns | 0.0031 ns |  1.6428 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.6964 ns | 0.0102 ns | 0.0095 ns |  4.6976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.8326 ns | 0.0082 ns | 0.0076 ns |  4.8343 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.4816 ns | 0.0088 ns | 0.0073 ns |  4.4821 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6087 ns | 0.0092 ns | 0.0077 ns |  4.6076 ns |  0.98 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6105 ns | 0.0086 ns | 0.0076 ns |  4.6098 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  2.4798 ns | 0.0059 ns | 0.0052 ns |  2.4794 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  2.2668 ns | 0.0041 ns | 0.0038 ns |  2.2653 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  2.7861 ns | 0.0149 ns | 0.0139 ns |  2.7858 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.6719 ns | 0.0036 ns | 0.0034 ns |  1.6709 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.6685 ns | 0.0029 ns | 0.0026 ns |  1.6686 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.6421 ns | 0.0079 ns | 0.0070 ns |  4.6423 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.8765 ns | 0.0054 ns | 0.0050 ns |  4.8765 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.4806 ns | 0.0118 ns | 0.0105 ns |  4.4780 ns |  0.97 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.8430 ns | 0.0043 ns | 0.0038 ns |  4.8421 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.8374 ns | 0.0059 ns | 0.0053 ns |  4.8359 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.0831 ns | 0.0015 ns | 0.0014 ns |  1.0829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  0.8880 ns | 0.0024 ns | 0.0023 ns |  0.8874 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.1697 ns | 0.0028 ns | 0.0025 ns |  1.1706 ns |  1.08 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.7252 ns | 0.0028 ns | 0.0025 ns |  0.7249 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.7221 ns | 0.0057 ns | 0.0050 ns |  0.7228 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.5700 ns | 0.0062 ns | 0.0055 ns |  1.5691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.4675 ns | 0.0044 ns | 0.0041 ns |  1.4677 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.6883 ns | 0.0029 ns | 0.0026 ns |  1.6878 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.5676 ns | 0.0030 ns | 0.0029 ns |  1.5679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.5738 ns | 0.0036 ns | 0.0033 ns |  1.5736 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.3782 ns | 0.0051 ns | 0.0045 ns |  1.3776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.1827 ns | 0.0034 ns | 0.0028 ns |  1.1822 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.1700 ns | 0.0022 ns | 0.0019 ns |  1.1705 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.9004 ns | 0.0031 ns | 0.0029 ns |  1.9013 ns |  1.38 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.6473 ns | 0.0032 ns | 0.0030 ns |  1.6477 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.8277 ns | 0.0138 ns | 0.0122 ns |  1.8293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8853 ns | 0.0042 ns | 0.0037 ns |  1.8850 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7090 ns | 0.0055 ns | 0.0049 ns |  1.7077 ns |  0.94 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.6768 ns | 0.0059 ns | 0.0053 ns |  2.6769 ns |  1.46 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.6409 ns | 0.0063 ns | 0.0056 ns |  2.6409 ns |  1.45 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3381 ns | 0.0032 ns | 0.0028 ns |  1.3383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1034 ns | 0.0048 ns | 0.0045 ns |  1.1031 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1847 ns | 0.0038 ns | 0.0032 ns |  1.1856 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.7168 ns | 0.0023 ns | 0.0022 ns |  0.7167 ns |  0.54 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.7165 ns | 0.0022 ns | 0.0021 ns |  0.7162 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.1790 ns | 0.0054 ns | 0.0048 ns |  4.1795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3758 ns | 0.0075 ns | 0.0070 ns |  4.3770 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2458 ns | 0.0046 ns | 0.0043 ns |  4.2462 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.3870 ns | 0.0101 ns | 0.0095 ns |  4.3851 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.3788 ns | 0.0067 ns | 0.0063 ns |  4.3804 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.0838 ns | 0.0060 ns | 0.0053 ns |  1.0826 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1047 ns | 0.0048 ns | 0.0042 ns |  1.1031 ns |  1.02 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.1749 ns | 0.0040 ns | 0.0035 ns |  1.1755 ns |  1.08 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.7456 ns | 0.0034 ns | 0.0031 ns |  0.7452 ns |  0.69 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.7399 ns | 0.0024 ns | 0.0021 ns |  0.7397 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7820 ns | 0.0062 ns | 0.0055 ns |  1.7803 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.4368 ns | 0.0035 ns | 0.0033 ns |  1.4376 ns |  0.81 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7846 ns | 0.0023 ns | 0.0021 ns |  1.7844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.8055 ns | 0.0045 ns | 0.0040 ns |  1.8056 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.8060 ns | 0.0028 ns | 0.0025 ns |  1.8066 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0658 ns | 0.0061 ns | 0.0054 ns |  6.0652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.7577 ns | 0.0060 ns | 0.0050 ns |  5.7589 ns |  0.95 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.9051 ns | 0.0607 ns | 0.0567 ns |  5.8908 ns |  0.97 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.0083 ns | 0.0285 ns | 0.0266 ns |  5.9986 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.7647 ns | 0.0105 ns | 0.0099 ns |  5.7617 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.3040 ns | 0.0249 ns | 0.0233 ns | 18.2967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.4044 ns | 0.0242 ns | 0.0214 ns | 18.4082 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.9393 ns | 0.2452 ns | 0.2294 ns | 12.7992 ns |  0.71 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.9680 ns | 0.0184 ns | 0.0163 ns | 18.9695 ns |  1.04 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.6069 ns | 0.0991 ns | 0.0927 ns | 18.6337 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2690 ns | 0.0059 ns | 0.0055 ns |  2.2672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  1.8582 ns | 0.0040 ns | 0.0034 ns |  1.8573 ns |  0.82 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3482 ns | 0.0098 ns | 0.0087 ns |  2.3488 ns |  1.04 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1198 ns | 0.0053 ns | 0.0050 ns |  1.1196 ns |  0.49 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1301 ns | 0.0026 ns | 0.0022 ns |  1.1305 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9079 ns | 0.0134 ns | 0.0119 ns |  7.9058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.1208 ns | 0.0139 ns | 0.0123 ns |  8.1217 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0900 ns | 0.0027 ns | 0.0023 ns |  2.0898 ns |  0.26 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  7.9593 ns | 0.0178 ns | 0.0149 ns |  7.9552 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  7.9926 ns | 0.0524 ns | 0.0490 ns |  7.9672 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.4415 ns | 0.0086 ns | 0.0071 ns |  3.4400 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.6931 ns | 0.0072 ns | 0.0067 ns |  3.6915 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8250 ns | 0.0263 ns | 0.0246 ns |  3.8307 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.9412 ns | 0.0114 ns | 0.0107 ns |  2.9427 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.9232 ns | 0.0058 ns | 0.0049 ns |  2.9230 ns |  0.85 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 33.4121 ns | 0.0742 ns | 0.0620 ns | 33.3931 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 18.2025 ns | 0.0487 ns | 0.0407 ns | 18.2094 ns |  0.54 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 13.9219 ns | 0.0427 ns | 0.0379 ns | 13.9190 ns |  0.42 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.7574 ns | 0.1394 ns | 0.1236 ns | 31.7189 ns |  0.95 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.6474 ns | 0.0598 ns | 0.0500 ns | 31.6479 ns |  0.95 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.6285 ns | 0.0083 ns | 0.0069 ns | 10.6297 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.6886 ns | 0.0304 ns | 0.0284 ns | 10.6952 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.5867 ns | 0.0404 ns | 0.0378 ns |  8.6006 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.7975 ns | 0.0108 ns | 0.0101 ns | 12.7972 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.7156 ns | 0.0794 ns | 0.0743 ns | 12.7596 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 15.1890 ns | 0.0228 ns | 0.0213 ns | 15.1905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.4185 ns | 0.0242 ns | 0.0226 ns | 15.4179 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.9752 ns | 0.0164 ns | 0.0146 ns | 12.9739 ns |  0.85 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 17.3410 ns | 0.0184 ns | 0.0172 ns | 17.3354 ns |  1.14 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 17.4085 ns | 0.0175 ns | 0.0155 ns | 17.4098 ns |  1.15 |    0.00 |      - |     - |     - |         - |
