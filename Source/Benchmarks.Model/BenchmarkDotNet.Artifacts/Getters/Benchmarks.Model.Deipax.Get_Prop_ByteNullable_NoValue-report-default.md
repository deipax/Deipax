
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.3290 ns | 0.8915 ns | 0.0489 ns | 1.3458 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.2708 ns | 0.3788 ns | 0.0208 ns | 1.2595 ns |  0.96 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 3.9969 ns | 0.3475 ns | 0.0190 ns | 4.0010 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.7814 ns | 0.3228 ns | 0.0177 ns | 3.7744 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.4911 ns | 0.4968 ns | 0.0272 ns | 1.5044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.3357 ns | 0.4693 ns | 0.0257 ns | 1.3322 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.0244 ns | 0.3526 ns | 0.0193 ns | 4.0284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.7551 ns | 0.3130 ns | 0.0172 ns | 3.7586 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.5491 ns | 3.6523 ns | 0.2002 ns | 1.6599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.5473 ns | 0.6210 ns | 0.0340 ns | 1.5321 ns |  1.01 |    0.13 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 4.0030 ns | 0.3425 ns | 0.0188 ns | 4.0105 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.7546 ns | 0.3841 ns | 0.0211 ns | 3.7550 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.4782 ns | 0.3953 ns | 0.0217 ns | 1.4669 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.4146 ns | 0.4821 ns | 0.0264 ns | 1.4074 ns |  0.96 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 0.9497 ns | 0.6033 ns | 0.0331 ns | 0.9383 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 0.9096 ns | 0.0732 ns | 0.0040 ns | 0.9101 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.4463 ns | 0.9141 ns | 0.0501 ns | 1.4197 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.2875 ns | 0.7549 ns | 0.0414 ns | 1.2683 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 3.9996 ns | 0.2726 ns | 0.0149 ns | 4.0072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.7526 ns | 0.2893 ns | 0.0159 ns | 3.7512 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.3463 ns | 0.7400 ns | 0.0406 ns | 1.3572 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.2954 ns | 0.9192 ns | 0.0504 ns | 1.2714 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.0023 ns | 0.1852 ns | 0.0101 ns | 4.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.7635 ns | 0.1924 ns | 0.0105 ns | 3.7685 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.4238 ns | 0.1245 ns | 0.0068 ns | 1.4257 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.2682 ns | 0.3531 ns | 0.0194 ns | 1.2610 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.0058 ns | 0.1299 ns | 0.0071 ns | 4.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.7628 ns | 0.3431 ns | 0.0188 ns | 3.7679 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.2586 ns | 0.3357 ns | 0.0184 ns | 1.2481 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.4254 ns | 0.3330 ns | 0.0183 ns | 1.4218 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.0189 ns | 0.0587 ns | 0.0032 ns | 4.0201 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.8338 ns | 3.1962 ns | 0.1752 ns | 3.7381 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.3257 ns | 0.5506 ns | 0.0302 ns | 1.3268 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.3159 ns | 0.0679 ns | 0.0037 ns | 1.3175 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 1.9470 ns | 0.6509 ns | 0.0357 ns | 1.9653 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 1.7744 ns | 0.2982 ns | 0.0163 ns | 1.7797 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 5.5342 ns | 0.3468 ns | 0.0190 ns | 5.5277 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.3194 ns | 0.0859 ns | 0.0047 ns | 1.3190 ns |  0.24 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.1172 ns | 0.0950 ns | 0.0052 ns | 2.1158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 1.9494 ns | 0.3276 ns | 0.0180 ns | 1.9406 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.2686 ns | 0.4214 ns | 0.0231 ns | 1.2610 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.3209 ns | 0.1199 ns | 0.0066 ns | 1.3190 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.2464 ns | 0.6257 ns | 0.0343 ns | 4.2577 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 3.9841 ns | 0.3191 ns | 0.0175 ns | 3.9884 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.4683 ns | 0.3188 ns | 0.0175 ns | 1.4600 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.3122 ns | 0.0677 ns | 0.0037 ns | 1.3102 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 1.9051 ns | 0.3748 ns | 0.0205 ns | 1.8997 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 1.9834 ns | 0.7238 ns | 0.0397 ns | 2.0049 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.1701 ns | 0.1187 ns | 0.0065 ns | 2.1669 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 1.9852 ns | 0.8424 ns | 0.0462 ns | 1.9603 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.9941 ns | 1.6635 ns | 0.0912 ns | 2.9567 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.2520 ns | 0.9113 ns | 0.0500 ns | 2.2317 ns |  0.75 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.3269 ns | 0.1512 ns | 0.0083 ns | 2.3262 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.1689 ns | 1.1540 ns | 0.0633 ns | 2.1390 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.0239 ns | 0.5509 ns | 0.0302 ns | 2.0246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.6881 ns | 0.2278 ns | 0.0125 ns | 1.6949 ns |  0.83 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.3274 ns | 0.4951 ns | 0.0271 ns | 1.3164 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.4067 ns | 0.5448 ns | 0.0299 ns | 1.4104 ns |  1.06 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.3679 ns | 0.5234 ns | 0.0287 ns | 1.3561 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.4253 ns | 0.6246 ns | 0.0342 ns | 1.4222 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.4009 ns | 0.8712 ns | 0.0478 ns | 1.3904 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.3233 ns | 0.2253 ns | 0.0124 ns | 1.3297 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.0189 ns | 0.2385 ns | 0.0131 ns | 4.0191 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.0008 ns | 0.1281 ns | 0.0070 ns | 3.9968 ns |  1.00 |    0.00 |     - |     - |     - |         - |
