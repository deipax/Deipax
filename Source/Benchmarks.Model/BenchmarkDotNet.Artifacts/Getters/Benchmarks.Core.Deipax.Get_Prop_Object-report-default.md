
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  3.4798 ns | 0.0052 ns | 0.0048 ns |  3.4787 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  3.6979 ns | 0.0051 ns | 0.0048 ns |  3.6989 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  3.5886 ns | 0.0223 ns | 0.0208 ns |  3.5788 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  3.4584 ns | 0.0045 ns | 0.0042 ns |  3.4584 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  3.4631 ns | 0.0050 ns | 0.0044 ns |  3.4629 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  6.5634 ns | 0.0102 ns | 0.0091 ns |  6.5619 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  6.7561 ns | 0.0196 ns | 0.0183 ns |  6.7599 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  6.5052 ns | 0.0087 ns | 0.0081 ns |  6.5076 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  6.7035 ns | 0.0134 ns | 0.0112 ns |  6.7029 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  6.6981 ns | 0.0082 ns | 0.0076 ns |  6.7009 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  3.5122 ns | 0.0068 ns | 0.0057 ns |  3.5096 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  3.6925 ns | 0.0046 ns | 0.0043 ns |  3.6925 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  3.5777 ns | 0.0074 ns | 0.0066 ns |  3.5772 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  3.4448 ns | 0.0068 ns | 0.0056 ns |  3.4445 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  3.4401 ns | 0.0052 ns | 0.0046 ns |  3.4389 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  6.5596 ns | 0.0075 ns | 0.0070 ns |  6.5579 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  6.7194 ns | 0.0310 ns | 0.0290 ns |  6.7038 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  6.5526 ns | 0.0373 ns | 0.0330 ns |  6.5622 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  6.7470 ns | 0.0244 ns | 0.0228 ns |  6.7535 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  6.7080 ns | 0.0088 ns | 0.0082 ns |  6.7066 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  3.4536 ns | 0.0044 ns | 0.0039 ns |  3.4533 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  3.6357 ns | 0.0062 ns | 0.0058 ns |  3.6366 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  3.5376 ns | 0.0107 ns | 0.0100 ns |  3.5382 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  3.4507 ns | 0.0031 ns | 0.0029 ns |  3.4502 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  3.4728 ns | 0.0155 ns | 0.0145 ns |  3.4753 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  6.6266 ns | 0.0098 ns | 0.0087 ns |  6.6273 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  6.7028 ns | 0.0087 ns | 0.0081 ns |  6.7025 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  6.5522 ns | 0.0304 ns | 0.0285 ns |  6.5644 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  6.7065 ns | 0.0079 ns | 0.0074 ns |  6.7053 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  6.6978 ns | 0.0073 ns | 0.0068 ns |  6.6961 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  3.8412 ns | 0.0038 ns | 0.0033 ns |  3.8410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  3.6379 ns | 0.0039 ns | 0.0036 ns |  3.6383 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  3.5251 ns | 0.0074 ns | 0.0069 ns |  3.5235 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  3.4440 ns | 0.0035 ns | 0.0033 ns |  3.4448 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  3.4947 ns | 0.0317 ns | 0.0297 ns |  3.5039 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  6.6024 ns | 0.0092 ns | 0.0082 ns |  6.6037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  6.6990 ns | 0.0111 ns | 0.0087 ns |  6.6967 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  6.5016 ns | 0.0063 ns | 0.0059 ns |  6.5047 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  6.7093 ns | 0.0081 ns | 0.0067 ns |  6.7109 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  6.7163 ns | 0.0074 ns | 0.0069 ns |  6.7140 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  3.4669 ns | 0.0048 ns | 0.0045 ns |  3.4678 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  3.6888 ns | 0.0070 ns | 0.0065 ns |  3.6894 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  3.5473 ns | 0.0087 ns | 0.0077 ns |  3.5452 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  3.4589 ns | 0.0160 ns | 0.0150 ns |  3.4637 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  3.4377 ns | 0.0055 ns | 0.0052 ns |  3.4379 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  6.5449 ns | 0.0107 ns | 0.0100 ns |  6.5458 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  6.7020 ns | 0.0098 ns | 0.0092 ns |  6.7057 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  6.5030 ns | 0.0043 ns | 0.0034 ns |  6.5025 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  6.7046 ns | 0.0085 ns | 0.0079 ns |  6.7055 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  6.7060 ns | 0.0068 ns | 0.0063 ns |  6.7066 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  3.8305 ns | 0.0062 ns | 0.0058 ns |  3.8311 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  3.7137 ns | 0.0174 ns | 0.0145 ns |  3.7196 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  3.5381 ns | 0.0094 ns | 0.0083 ns |  3.5393 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  3.4422 ns | 0.0047 ns | 0.0044 ns |  3.4431 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  3.7117 ns | 0.0052 ns | 0.0046 ns |  3.7123 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  6.5462 ns | 0.0076 ns | 0.0063 ns |  6.5450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  6.7095 ns | 0.0079 ns | 0.0074 ns |  6.7078 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  6.5063 ns | 0.0097 ns | 0.0090 ns |  6.5046 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  6.7050 ns | 0.0083 ns | 0.0074 ns |  6.7043 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  6.7188 ns | 0.0111 ns | 0.0104 ns |  6.7204 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  3.6936 ns | 0.0036 ns | 0.0033 ns |  3.6946 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  3.6305 ns | 0.0057 ns | 0.0054 ns |  3.6301 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  3.6281 ns | 0.0127 ns | 0.0106 ns |  3.6272 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  3.5135 ns | 0.0063 ns | 0.0055 ns |  3.5149 ns |  0.95 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  3.5698 ns | 0.0039 ns | 0.0036 ns |  3.5698 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  6.5364 ns | 0.0083 ns | 0.0077 ns |  6.5361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  6.6944 ns | 0.0112 ns | 0.0105 ns |  6.6944 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  6.5352 ns | 0.0557 ns | 0.0521 ns |  6.5108 ns |  1.00 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  6.7431 ns | 0.0286 ns | 0.0254 ns |  6.7495 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  6.7160 ns | 0.0050 ns | 0.0044 ns |  6.7165 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  3.7718 ns | 0.0279 ns | 0.0261 ns |  3.7867 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  3.6365 ns | 0.0060 ns | 0.0050 ns |  3.6361 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  3.5566 ns | 0.0055 ns | 0.0049 ns |  3.5563 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  3.4981 ns | 0.0047 ns | 0.0039 ns |  3.4972 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  3.5043 ns | 0.0032 ns | 0.0030 ns |  3.5049 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  6.5537 ns | 0.0097 ns | 0.0086 ns |  6.5518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  6.7031 ns | 0.0168 ns | 0.0140 ns |  6.6993 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  6.4994 ns | 0.0109 ns | 0.0091 ns |  6.4973 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  6.7068 ns | 0.0093 ns | 0.0087 ns |  6.7090 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  6.7149 ns | 0.0069 ns | 0.0061 ns |  6.7147 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  3.4930 ns | 0.0235 ns | 0.0220 ns |  3.4798 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  3.6090 ns | 0.0053 ns | 0.0049 ns |  3.6122 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  3.3329 ns | 0.0068 ns | 0.0057 ns |  3.3323 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  3.4765 ns | 0.0041 ns | 0.0034 ns |  3.4767 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  3.5356 ns | 0.0066 ns | 0.0062 ns |  3.5339 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  5.9508 ns | 0.0049 ns | 0.0044 ns |  5.9500 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  5.0563 ns | 0.0057 ns | 0.0053 ns |  5.0565 ns |  0.85 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  5.1896 ns | 0.0196 ns | 0.0183 ns |  5.1889 ns |  0.87 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  5.5577 ns | 0.0068 ns | 0.0063 ns |  5.5592 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  5.5662 ns | 0.0047 ns | 0.0044 ns |  5.5658 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  3.4598 ns | 0.0053 ns | 0.0047 ns |  3.4581 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  3.7528 ns | 0.0231 ns | 0.0216 ns |  3.7617 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  3.3172 ns | 0.0056 ns | 0.0052 ns |  3.3176 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  3.4771 ns | 0.0056 ns | 0.0052 ns |  3.4771 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  3.5061 ns | 0.0132 ns | 0.0123 ns |  3.5093 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  4.9695 ns | 0.0328 ns | 0.0307 ns |  4.9908 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  4.8233 ns | 0.0073 ns | 0.0065 ns |  4.8232 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  4.8862 ns | 0.0159 ns | 0.0149 ns |  4.8861 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  5.5787 ns | 0.0227 ns | 0.0177 ns |  5.5840 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  5.5418 ns | 0.0070 ns | 0.0062 ns |  5.5420 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  3.7394 ns | 0.0052 ns | 0.0049 ns |  3.7384 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  3.6740 ns | 0.0062 ns | 0.0048 ns |  3.6735 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  3.9040 ns | 0.0053 ns | 0.0049 ns |  3.9040 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  3.1641 ns | 0.0049 ns | 0.0046 ns |  3.1639 ns |  0.85 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  3.1687 ns | 0.0061 ns | 0.0054 ns |  3.1680 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  6.8220 ns | 0.0317 ns | 0.0296 ns |  6.8351 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  6.9345 ns | 0.0092 ns | 0.0086 ns |  6.9362 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  6.7358 ns | 0.0089 ns | 0.0083 ns |  6.7326 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  7.0153 ns | 0.1001 ns | 0.0936 ns |  6.9756 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  6.9451 ns | 0.0062 ns | 0.0055 ns |  6.9432 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  3.3584 ns | 0.0043 ns | 0.0040 ns |  3.3589 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  3.9025 ns | 0.0033 ns | 0.0031 ns |  3.9017 ns |  1.16 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  3.8738 ns | 0.0196 ns | 0.0184 ns |  3.8725 ns |  1.15 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  3.2880 ns | 0.0038 ns | 0.0036 ns |  3.2877 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  3.2926 ns | 0.0049 ns | 0.0046 ns |  3.2919 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  5.2631 ns | 0.0057 ns | 0.0053 ns |  5.2635 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  5.4084 ns | 0.0117 ns | 0.0104 ns |  5.4113 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  4.8874 ns | 0.0044 ns | 0.0039 ns |  4.8878 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  4.9207 ns | 0.0105 ns | 0.0098 ns |  4.9160 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  4.9304 ns | 0.0047 ns | 0.0044 ns |  4.9304 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  4.5342 ns | 0.0069 ns | 0.0065 ns |  4.5349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  4.6136 ns | 0.0077 ns | 0.0072 ns |  4.6123 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  4.3756 ns | 0.0058 ns | 0.0051 ns |  4.3755 ns |  0.96 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  8.0939 ns | 0.0101 ns | 0.0094 ns |  8.0939 ns |  1.79 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net472 |  8.1053 ns | 0.0119 ns | 0.0111 ns |  8.1053 ns |  1.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 11.5735 ns | 0.0672 ns | 0.0629 ns | 11.5937 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 11.6553 ns | 0.0250 ns | 0.0234 ns | 11.6501 ns |  1.01 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  5.2346 ns | 0.1020 ns | 0.0954 ns |  5.2572 ns |  0.45 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 11.5299 ns | 0.0175 ns | 0.0164 ns | 11.5274 ns |  1.00 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 11.4845 ns | 0.0188 ns | 0.0167 ns | 11.4856 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  4.0899 ns | 0.0297 ns | 0.0277 ns |  4.1046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  4.8401 ns | 0.0052 ns | 0.0046 ns |  4.8414 ns |  1.18 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  4.3837 ns | 0.0076 ns | 0.0072 ns |  4.3821 ns |  1.07 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  3.8008 ns | 0.0065 ns | 0.0061 ns |  3.7997 ns |  0.93 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net472 |  3.8054 ns | 0.0050 ns | 0.0044 ns |  3.8062 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 | 11.1653 ns | 0.0104 ns | 0.0098 ns | 11.1649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 | 11.4212 ns | 0.0115 ns | 0.0102 ns | 11.4237 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  5.2572 ns | 0.0323 ns | 0.0302 ns |  5.2494 ns |  0.47 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 11.2264 ns | 0.0172 ns | 0.0152 ns | 11.2282 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 11.2275 ns | 0.0114 ns | 0.0101 ns | 11.2285 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.1708 ns | 0.0120 ns | 0.0112 ns |  1.1752 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.1566 ns | 0.0021 ns | 0.0020 ns |  1.1567 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  0.9129 ns | 0.0023 ns | 0.0021 ns |  0.9128 ns |  0.78 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.4319 ns | 0.0017 ns | 0.0016 ns |  0.4315 ns |  0.37 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.4298 ns | 0.0014 ns | 0.0012 ns |  0.4295 ns |  0.37 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 | 14.3269 ns | 0.0315 ns | 0.0295 ns | 14.3254 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 | 16.4982 ns | 0.0409 ns | 0.0363 ns | 16.4919 ns |  1.15 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 | 12.5166 ns | 0.0540 ns | 0.0505 ns | 12.4962 ns |  0.87 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 | 15.4225 ns | 0.0205 ns | 0.0191 ns | 15.4201 ns |  1.08 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 | 15.5369 ns | 0.0218 ns | 0.0193 ns | 15.5424 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 | 15.2801 ns | 0.1083 ns | 0.1013 ns | 15.2284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 15.0850 ns | 0.0330 ns | 0.0308 ns | 15.0928 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 12.8354 ns | 0.0169 ns | 0.0158 ns | 12.8341 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 | 23.3825 ns | 0.0379 ns | 0.0336 ns | 23.3735 ns |  1.53 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net472 | 23.1654 ns | 0.0287 ns | 0.0269 ns | 23.1567 ns |  1.52 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.2350 ns | 0.0226 ns | 0.0200 ns | 16.2348 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.7547 ns | 0.0265 ns | 0.0248 ns | 15.7611 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.6958 ns | 0.0178 ns | 0.0166 ns | 13.6935 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 | 24.3011 ns | 0.0151 ns | 0.0118 ns | 24.3046 ns |  1.50 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 24.5718 ns | 0.0194 ns | 0.0182 ns | 24.5737 ns |  1.51 |    0.00 |     - |     - |     - |         - |
