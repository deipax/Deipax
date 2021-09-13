
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.3466 ns | 0.5982 ns | 0.0328 ns | 1.3295 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.3487 ns | 1.5579 ns | 0.0854 ns | 1.3211 ns |  1.00 |    0.07 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 0.9970 ns | 0.0266 ns | 0.0015 ns | 0.9969 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 0.9454 ns | 0.5649 ns | 0.0310 ns | 0.9444 ns |  0.95 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.3399 ns | 4.1333 ns | 0.2266 ns | 1.4651 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.0714 ns | 0.1910 ns | 0.0105 ns | 1.0717 ns |  0.82 |    0.15 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.2426 ns | 7.3957 ns | 0.4054 ns | 4.0168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.7644 ns | 0.1574 ns | 0.0086 ns | 3.7656 ns |  0.89 |    0.08 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.6291 ns | 0.0636 ns | 0.0035 ns | 1.6304 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.2764 ns | 0.3369 ns | 0.0185 ns | 1.2862 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 3.9793 ns | 0.1404 ns | 0.0077 ns | 3.9822 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.7570 ns | 0.5094 ns | 0.0279 ns | 3.7443 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.4898 ns | 0.2934 ns | 0.0161 ns | 1.4979 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.3896 ns | 0.2195 ns | 0.0120 ns | 1.3897 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 3.9885 ns | 0.3470 ns | 0.0190 ns | 3.9934 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.7735 ns | 0.1449 ns | 0.0079 ns | 3.7703 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.3027 ns | 0.0147 ns | 0.0008 ns | 1.3027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.3362 ns | 0.6659 ns | 0.0365 ns | 1.3226 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.0220 ns | 0.1284 ns | 0.0070 ns | 4.0252 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.7889 ns | 1.3932 ns | 0.0764 ns | 3.7576 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.3448 ns | 0.0990 ns | 0.0054 ns | 1.3426 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.2920 ns | 0.3195 ns | 0.0175 ns | 1.2874 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.0193 ns | 0.3338 ns | 0.0183 ns | 4.0196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 4.2861 ns | 1.3849 ns | 0.0759 ns | 4.2483 ns |  1.07 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.5333 ns | 1.6578 ns | 0.0909 ns | 1.5390 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.2775 ns | 1.1333 ns | 0.0621 ns | 1.2447 ns |  0.83 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.0220 ns | 0.3549 ns | 0.0195 ns | 4.0315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.7299 ns | 0.5825 ns | 0.0319 ns | 3.7309 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.2979 ns | 0.2271 ns | 0.0124 ns | 1.2983 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.3849 ns | 0.4918 ns | 0.0270 ns | 1.3755 ns |  1.07 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.0266 ns | 0.1073 ns | 0.0059 ns | 4.0245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.7604 ns | 0.2229 ns | 0.0122 ns | 3.7534 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.3414 ns | 0.6352 ns | 0.0348 ns | 1.3477 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.3221 ns | 0.0718 ns | 0.0039 ns | 1.3217 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 1.9039 ns | 1.0590 ns | 0.0580 ns | 1.8718 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.3289 ns | 0.7329 ns | 0.0402 ns | 2.3115 ns |  1.22 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.2923 ns | 0.4010 ns | 0.0220 ns | 1.2821 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.3172 ns | 0.8776 ns | 0.0481 ns | 1.3103 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 1.8990 ns | 1.0842 ns | 0.0594 ns | 1.8674 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.0949 ns | 0.3671 ns | 0.0201 ns | 2.0866 ns |  1.10 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.4666 ns | 0.1860 ns | 0.0102 ns | 1.4684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.3606 ns | 0.4290 ns | 0.0235 ns | 1.3547 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.2629 ns | 0.0897 ns | 0.0049 ns | 4.2647 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 3.9915 ns | 0.2152 ns | 0.0118 ns | 3.9881 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.5244 ns | 0.3205 ns | 0.0176 ns | 1.5332 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.4049 ns | 0.8077 ns | 0.0443 ns | 1.4226 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 1.7924 ns | 0.2582 ns | 0.0142 ns | 1.7855 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 1.9265 ns | 0.8110 ns | 0.0445 ns | 1.9386 ns |  1.08 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.1253 ns | 1.1926 ns | 0.0654 ns | 2.1624 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.1693 ns | 0.0956 ns | 0.0052 ns | 2.1721 ns |  1.02 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.3255 ns | 1.7261 ns | 0.0946 ns | 2.2858 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.4127 ns | 1.1747 ns | 0.0644 ns | 2.4233 ns |  1.04 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.1681 ns | 0.0219 ns | 0.0012 ns | 2.1684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.1662 ns | 0.3353 ns | 0.0184 ns | 2.1744 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.0301 ns | 0.1186 ns | 0.0065 ns | 2.0301 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.6520 ns | 0.8715 ns | 0.0478 ns | 1.6319 ns |  0.81 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.3452 ns | 0.0715 ns | 0.0039 ns | 1.3440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.3632 ns | 0.8435 ns | 0.0462 ns | 1.3848 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.4695 ns | 2.0874 ns | 0.1144 ns | 1.4451 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.4639 ns | 1.3523 ns | 0.0741 ns | 1.4620 ns |  1.00 |    0.08 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.4188 ns | 0.2706 ns | 0.0148 ns | 1.4181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.4149 ns | 0.4094 ns | 0.0224 ns | 1.4113 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.0186 ns | 0.1402 ns | 0.0077 ns | 4.0216 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 3.9840 ns | 0.2684 ns | 0.0147 ns | 3.9888 ns |  0.99 |    0.00 |     - |     - |     - |         - |
