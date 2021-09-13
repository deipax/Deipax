
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |        Mean |      Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|-----------:|----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |   0.9283 ns |  0.4744 ns | 0.0260 ns |   0.9141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |   0.9532 ns |  0.0345 ns | 0.0019 ns |   0.9525 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |   3.9692 ns |  0.7833 ns | 0.0429 ns |   3.9747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |   3.8154 ns |  0.0541 ns | 0.0030 ns |   3.8139 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |   0.9413 ns |  0.5849 ns | 0.0321 ns |   0.9441 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |   1.2163 ns |  0.1791 ns | 0.0098 ns |   1.2185 ns |  1.29 |    0.05 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |   4.2634 ns |  8.9365 ns | 0.4898 ns |   3.9933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |   3.8123 ns |  0.1752 ns | 0.0096 ns |   3.8103 ns |  0.90 |    0.10 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |   1.0527 ns |  0.3011 ns | 0.0165 ns |   1.0569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |   0.9412 ns |  0.2456 ns | 0.0135 ns |   0.9452 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |   3.9683 ns |  0.1100 ns | 0.0060 ns |   3.9676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |   3.8225 ns |  0.3532 ns | 0.0194 ns |   3.8121 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |   0.9075 ns |  0.6266 ns | 0.0343 ns |   0.8905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |   0.9387 ns |  0.1978 ns | 0.0108 ns |   0.9331 ns |  1.04 |    0.05 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |   3.9579 ns |  0.1157 ns | 0.0063 ns |   3.9583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |   3.7921 ns |  0.2112 ns | 0.0116 ns |   3.7930 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |   1.0175 ns |  2.4194 ns | 0.1326 ns |   1.0569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |   0.9342 ns |  0.2036 ns | 0.0112 ns |   0.9289 ns |  0.93 |    0.12 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |   3.9880 ns |  0.1371 ns | 0.0075 ns |   3.9874 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |   3.8036 ns |  0.0471 ns | 0.0026 ns |   3.8032 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |   0.9081 ns |  0.4211 ns | 0.0231 ns |   0.9157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |   0.9685 ns |  0.6620 ns | 0.0363 ns |   0.9658 ns |  1.07 |    0.06 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |   3.9823 ns |  0.2189 ns | 0.0120 ns |   3.9799 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |   3.8109 ns |  0.3080 ns | 0.0169 ns |   3.8085 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |   0.9573 ns |  1.3368 ns | 0.0733 ns |   0.9393 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |   1.2040 ns |  0.2297 ns | 0.0126 ns |   1.2011 ns |  1.26 |    0.10 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |   4.4831 ns |  8.4990 ns | 0.4659 ns |   4.3513 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |   3.8228 ns |  0.5059 ns | 0.0277 ns |   3.8107 ns |  0.86 |    0.09 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |   1.0492 ns |  0.2102 ns | 0.0115 ns |   1.0484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |   1.3375 ns |  3.1361 ns | 0.1719 ns |   1.2466 ns |  1.27 |    0.15 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |   3.9425 ns |  0.1527 ns | 0.0084 ns |   3.9413 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |   3.7965 ns |  0.1376 ns | 0.0075 ns |   3.7946 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |   0.9073 ns |  0.3539 ns | 0.0194 ns |   0.9063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |   0.9509 ns |  0.4545 ns | 0.0249 ns |   0.9584 ns |  1.05 |    0.04 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |   1.5329 ns |  0.3824 ns | 0.0210 ns |   1.5298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |   1.6611 ns |  0.0595 ns | 0.0033 ns |   1.6618 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |   0.8964 ns |  0.0992 ns | 0.0054 ns |   0.8971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |   0.9520 ns |  0.1890 ns | 0.0104 ns |   0.9497 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |   1.6629 ns |  0.0807 ns | 0.0044 ns |   1.6648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |   1.4935 ns |  0.1676 ns | 0.0092 ns |   1.4900 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |   0.9874 ns |  0.2437 ns | 0.0134 ns |   0.9934 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |   1.4285 ns |  0.0947 ns | 0.0052 ns |   1.4256 ns |  1.45 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |   3.9636 ns |  1.0492 ns | 0.0575 ns |   3.9480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |   3.8153 ns |  0.0880 ns | 0.0048 ns |   3.8136 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |   0.9040 ns |  0.4624 ns | 0.0253 ns |   0.8914 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |   1.0007 ns |  0.3048 ns | 0.0167 ns |   0.9994 ns |  1.11 |    0.04 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |   1.5535 ns |  0.4870 ns | 0.0267 ns |   1.5418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |   1.8808 ns |  0.5576 ns | 0.0306 ns |   1.8771 ns |  1.21 |    0.04 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |   2.6756 ns |  0.8760 ns | 0.0480 ns |   2.6545 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |   2.7221 ns |  0.1908 ns | 0.0105 ns |   2.7216 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |   1.4549 ns |  0.5979 ns | 0.0328 ns |   1.4701 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |   1.5806 ns |  0.1248 ns | 0.0068 ns |   1.5813 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |   1.5725 ns |  0.1491 ns | 0.0082 ns |   1.5760 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |   1.1645 ns |  3.1785 ns | 0.1742 ns |   1.0733 ns |  0.74 |    0.11 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |   5.1137 ns |  0.4056 ns | 0.0222 ns |   5.1120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |   5.1997 ns |  0.1824 ns | 0.0100 ns |   5.1960 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |   3.5375 ns |  1.2959 ns | 0.0710 ns |   3.5569 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |   3.6213 ns |  1.9898 ns | 0.1091 ns |   3.6133 ns |  1.02 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |             |            |           |             |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 223.5834 ns | 26.8509 ns | 1.4718 ns | 223.7166 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
          To_String | .NET Core 5.0 | 216.4525 ns | 12.1523 ns | 0.6661 ns | 216.4259 ns |  0.97 |    0.01 | 0.0100 |     - |     - |      64 B |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |   7.1894 ns |  0.5595 ns | 0.0307 ns |   7.1879 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |   3.9132 ns |  0.2720 ns | 0.0149 ns |   3.9188 ns |  0.54 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 |   7.3778 ns |  0.3789 ns | 0.0208 ns |   7.3836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |   3.6965 ns |  0.6199 ns | 0.0340 ns |   3.7152 ns |  0.50 |    0.00 |      - |     - |     - |         - |
