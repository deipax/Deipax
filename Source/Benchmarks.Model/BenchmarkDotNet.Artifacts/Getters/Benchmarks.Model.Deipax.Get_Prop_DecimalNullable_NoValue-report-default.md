
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.729 ns | 0.3436 ns | 0.0188 ns |  1.720 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.743 ns | 0.1482 ns | 0.0081 ns |  1.742 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  5.213 ns | 1.6314 ns | 0.0894 ns |  5.169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  4.207 ns | 0.2387 ns | 0.0131 ns |  4.201 ns |  0.81 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 |  1.138 ns | 0.1700 ns | 0.0093 ns |  1.136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.231 ns | 0.5481 ns | 0.0300 ns |  1.228 ns |  1.08 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.013 ns | 0.5483 ns | 0.0301 ns |  4.015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.792 ns | 0.0912 ns | 0.0050 ns |  3.791 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 |  1.707 ns | 0.0779 ns | 0.0043 ns |  1.709 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.788 ns | 0.2892 ns | 0.0159 ns |  1.786 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  5.174 ns | 0.4271 ns | 0.0234 ns |  5.184 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.250 ns | 0.4211 ns | 0.0231 ns |  4.238 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 |  1.685 ns | 0.1133 ns | 0.0062 ns |  1.685 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.751 ns | 0.7266 ns | 0.0398 ns |  1.743 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 |  5.234 ns | 2.9530 ns | 0.1619 ns |  5.143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.255 ns | 0.8010 ns | 0.0439 ns |  4.272 ns |  0.81 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 |  1.706 ns | 1.0096 ns | 0.0553 ns |  1.684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.758 ns | 0.0794 ns | 0.0043 ns |  1.759 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 |  5.131 ns | 0.7617 ns | 0.0418 ns |  5.119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.241 ns | 0.0668 ns | 0.0037 ns |  4.241 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 |  1.996 ns | 0.0656 ns | 0.0036 ns |  1.996 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.770 ns | 0.3717 ns | 0.0204 ns |  1.763 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  5.127 ns | 0.3468 ns | 0.0190 ns |  5.117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.272 ns | 0.3899 ns | 0.0214 ns |  4.268 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 |  1.746 ns | 0.6980 ns | 0.0383 ns |  1.766 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.768 ns | 0.9904 ns | 0.0543 ns |  1.785 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 |  5.391 ns | 3.2023 ns | 0.1755 ns |  5.428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.233 ns | 0.3945 ns | 0.0216 ns |  4.237 ns |  0.79 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 |  2.176 ns | 0.7539 ns | 0.0413 ns |  2.162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.828 ns | 0.3251 ns | 0.0178 ns |  1.829 ns |  0.84 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  5.308 ns | 0.9156 ns | 0.0502 ns |  5.292 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.244 ns | 0.1676 ns | 0.0092 ns |  4.247 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 |  1.877 ns | 0.7089 ns | 0.0389 ns |  1.859 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.770 ns | 0.2858 ns | 0.0157 ns |  1.763 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.515 ns | 1.7270 ns | 0.0947 ns |  2.463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.339 ns | 0.2294 ns | 0.0126 ns |  2.334 ns |  0.93 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 |  1.897 ns | 0.4646 ns | 0.0255 ns |  1.884 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.738 ns | 0.4154 ns | 0.0228 ns |  1.727 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.688 ns | 1.1990 ns | 0.0657 ns |  2.661 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  2.393 ns | 1.3485 ns | 0.0739 ns |  2.402 ns |  0.89 |    0.05 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 |  1.721 ns | 1.0127 ns | 0.0555 ns |  1.698 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.847 ns | 0.7312 ns | 0.0401 ns |  1.825 ns |  1.07 |    0.05 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  5.128 ns | 0.3017 ns | 0.0165 ns |  5.130 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.227 ns | 0.1800 ns | 0.0099 ns |  4.233 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 |  1.721 ns | 0.1107 ns | 0.0061 ns |  1.725 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.818 ns | 0.5979 ns | 0.0328 ns |  1.836 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.630 ns | 0.8740 ns | 0.0479 ns |  2.655 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.407 ns | 1.7552 ns | 0.0962 ns |  2.446 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 |  2.076 ns | 0.8143 ns | 0.0446 ns |  2.088 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.174 ns | 0.3192 ns | 0.0175 ns |  2.169 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  1.775 ns | 0.0365 ns | 0.0020 ns |  1.775 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  1.927 ns | 0.9425 ns | 0.0517 ns |  1.902 ns |  1.09 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.310 ns | 0.0509 ns | 0.0028 ns |  2.310 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.221 ns | 0.9323 ns | 0.0511 ns |  2.226 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.001 ns | 0.7703 ns | 0.0422 ns |  1.985 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.695 ns | 0.4156 ns | 0.0228 ns |  1.683 ns |  0.85 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 |  1.490 ns | 0.0934 ns | 0.0051 ns |  1.490 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 |  1.537 ns | 0.5556 ns | 0.0305 ns |  1.523 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 10.769 ns | 0.5864 ns | 0.0321 ns | 10.772 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 |  2.353 ns | 1.2579 ns | 0.0689 ns |  2.322 ns |  0.22 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 |  9.723 ns | 4.2244 ns | 0.2316 ns |  9.590 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  1.809 ns | 0.0185 ns | 0.0010 ns |  1.808 ns |  0.19 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 |  9.923 ns | 1.9106 ns | 0.1047 ns |  9.935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |  4.915 ns | 0.3961 ns | 0.0217 ns |  4.925 ns |  0.50 |    0.01 |     - |     - |     - |         - |
