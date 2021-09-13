
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |         NA |         NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 |         NA |         NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 |         NA |         NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |         NA |         NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 |  3.6191 ns |  0.0324 ns | 0.0018 ns |  3.6186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  3.0657 ns |  0.8323 ns | 0.0456 ns |  3.0551 ns |  0.85 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 |  5.4360 ns |  0.7646 ns | 0.0419 ns |  5.4491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  5.3497 ns |  0.5430 ns | 0.0298 ns |  5.3661 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 10.5370 ns |  5.3850 ns | 0.2952 ns | 10.6316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  7.7365 ns |  1.1772 ns | 0.0645 ns |  7.7482 ns |  0.73 |    0.03 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 11.7673 ns |  0.1812 ns | 0.0099 ns | 11.7686 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 11.3409 ns |  4.8848 ns | 0.2678 ns | 11.4213 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 10.1442 ns |  1.6074 ns | 0.0881 ns | 10.1401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  9.0158 ns |  0.4902 ns | 0.0269 ns |  9.0016 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 11.5498 ns |  1.3039 ns | 0.0715 ns | 11.5139 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 10.8132 ns |  0.3385 ns | 0.0186 ns | 10.8152 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 |  9.9444 ns |  0.7691 ns | 0.0422 ns |  9.9297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  8.0759 ns |  0.7788 ns | 0.0427 ns |  8.0934 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 11.7644 ns |  0.4373 ns | 0.0240 ns | 11.7774 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 11.0428 ns |  0.8359 ns | 0.0458 ns | 11.0284 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 10.1229 ns |  3.0585 ns | 0.1676 ns | 10.1944 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  9.3218 ns |  0.7510 ns | 0.0412 ns |  9.3062 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 11.5648 ns |  1.1737 ns | 0.0643 ns | 11.5907 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 11.0717 ns |  2.8406 ns | 0.1557 ns | 11.0080 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 11.9413 ns |  2.2881 ns | 0.1254 ns | 11.8820 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 10.3614 ns |  0.1257 ns | 0.0069 ns | 10.3595 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 13.0543 ns |  3.7002 ns | 0.2028 ns | 12.9736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 12.1203 ns |  1.6439 ns | 0.0901 ns | 12.1046 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 11.7948 ns |  0.6772 ns | 0.0371 ns | 11.7957 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 10.8192 ns |  2.1610 ns | 0.1185 ns | 10.7677 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 12.9412 ns |  0.5001 ns | 0.0274 ns | 12.9477 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 12.1038 ns |  2.1674 ns | 0.1188 ns | 12.0400 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 11.7409 ns |  3.3975 ns | 0.1862 ns | 11.6465 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 10.2977 ns |  2.1856 ns | 0.1198 ns | 10.2406 ns |  0.88 |    0.02 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 12.6179 ns |  6.0748 ns | 0.3330 ns | 12.5981 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 11.2506 ns |  6.6533 ns | 0.3647 ns | 11.1491 ns |  0.89 |    0.05 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 11.5797 ns |  1.3869 ns | 0.0760 ns | 11.5401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 10.0208 ns |  0.5723 ns | 0.0314 ns | 10.0189 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 12.8054 ns |  1.7793 ns | 0.0975 ns | 12.7739 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 11.7784 ns |  1.1187 ns | 0.0613 ns | 11.7760 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 48.8992 ns |  5.8910 ns | 0.3229 ns | 48.7703 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 43.4547 ns |  3.2419 ns | 0.1777 ns | 43.4987 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 46.8396 ns |  0.3624 ns | 0.0199 ns | 46.8450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 42.4399 ns |  0.5809 ns | 0.0318 ns | 42.4490 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 46.1554 ns | 13.0044 ns | 0.7128 ns | 45.8150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 43.1738 ns | 10.9725 ns | 0.6014 ns | 43.2384 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 48.1793 ns |  3.3248 ns | 0.1822 ns | 48.2206 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 45.3605 ns |  3.9003 ns | 0.2138 ns | 45.2383 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 47.2205 ns |  7.1353 ns | 0.3911 ns | 47.1151 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 47.5569 ns | 13.1708 ns | 0.7219 ns | 47.2341 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 52.4581 ns | 20.4787 ns | 1.1225 ns | 52.7007 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 50.6635 ns |  0.9059 ns | 0.0497 ns | 50.6865 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 |         NA |         NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |         NA |         NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |         NA |         NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |         NA |         NA |        NA |         NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 |  0.9451 ns |  0.0818 ns | 0.0045 ns |  0.9429 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 |  0.9544 ns |  0.3502 ns | 0.0192 ns |  0.9446 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
          To_String | .NET Core 3.1 |  1.0189 ns |  0.5095 ns | 0.0279 ns |  1.0297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 |  0.9232 ns |  0.4098 ns | 0.0225 ns |  0.9129 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 17.2002 ns |  0.9135 ns | 0.0501 ns | 17.1919 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 15.7365 ns |  2.6357 ns | 0.1445 ns | 15.7791 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |            |            |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 19.6314 ns |  1.1844 ns | 0.0649 ns | 19.6656 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 17.9494 ns |  7.6689 ns | 0.4204 ns | 18.0877 ns |  0.91 |    0.02 |     - |     - |     - |         - |

Benchmarks with issues:
  Get_Prop_String.ToBool: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  Get_Prop_String.ToBool: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  Get_Prop_String.ToBoolNullable: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  Get_Prop_String.ToBoolNullable: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  Get_Prop_String.ToDateTime: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  Get_Prop_String.ToDateTime: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
  Get_Prop_String.ToDateTimeNullable: ShortRun(Toolchain=.NET Core 3.1, IterationCount=3, LaunchCount=1, WarmupCount=3)
  Get_Prop_String.ToDateTimeNullable: ShortRun(Toolchain=.NET Core 5.0, IterationCount=3, LaunchCount=1, WarmupCount=3)
