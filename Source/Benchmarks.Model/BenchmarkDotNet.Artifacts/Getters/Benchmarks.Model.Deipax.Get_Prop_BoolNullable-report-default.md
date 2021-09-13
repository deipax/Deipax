
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.6580 ns | 0.5627 ns | 0.0308 ns |  1.6680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.2172 ns | 0.0502 ns | 0.0028 ns |  1.2173 ns |  0.73 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  0.9700 ns | 0.2452 ns | 0.0134 ns |  0.9657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  0.9151 ns | 0.0784 ns | 0.0043 ns |  0.9139 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.0798 ns | 0.7693 ns | 0.0422 ns |  1.0634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.0488 ns | 0.0375 ns | 0.0021 ns |  1.0481 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.0079 ns | 0.9840 ns | 0.0539 ns |  3.9907 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.7554 ns | 0.3404 ns | 0.0187 ns |  3.7622 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.6865 ns | 0.0712 ns | 0.0039 ns |  1.6867 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.5105 ns | 0.8211 ns | 0.0450 ns |  1.5341 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.4992 ns | 0.8927 ns | 0.0489 ns |  4.5109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  3.9854 ns | 0.0705 ns | 0.0039 ns |  3.9858 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.5220 ns | 0.2783 ns | 0.0153 ns |  1.5177 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.6219 ns | 0.2508 ns | 0.0137 ns |  1.6161 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.4754 ns | 0.2092 ns | 0.0115 ns |  4.4700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.9944 ns | 0.1024 ns | 0.0056 ns |  3.9957 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.8045 ns | 0.8988 ns | 0.0493 ns |  1.8249 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.8967 ns | 2.0315 ns | 0.1114 ns |  1.9311 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.4878 ns | 0.2322 ns | 0.0127 ns |  4.4831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.9799 ns | 0.4130 ns | 0.0226 ns |  3.9911 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.7899 ns | 0.0924 ns | 0.0051 ns |  1.7870 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.7412 ns | 0.4337 ns | 0.0238 ns |  1.7353 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.2667 ns | 0.1374 ns | 0.0075 ns |  4.2636 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.9761 ns | 0.4167 ns | 0.0228 ns |  3.9783 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.6978 ns | 0.2050 ns | 0.0112 ns |  1.7012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.5011 ns | 0.5591 ns | 0.0306 ns |  1.5131 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.4870 ns | 0.3025 ns | 0.0166 ns |  4.4832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.9399 ns | 0.3361 ns | 0.0184 ns |  3.9494 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.6535 ns | 2.4903 ns | 0.1365 ns |  1.6104 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.6499 ns | 0.9177 ns | 0.0503 ns |  1.6226 ns |  1.00 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.4784 ns | 0.0803 ns | 0.0044 ns |  4.4761 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.0047 ns | 0.2014 ns | 0.0110 ns |  4.0105 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.7636 ns | 0.4496 ns | 0.0246 ns |  1.7494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.8125 ns | 0.7400 ns | 0.0406 ns |  1.7964 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.0490 ns | 0.2120 ns | 0.0116 ns |  2.0448 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.6035 ns | 0.4226 ns | 0.0232 ns |  2.5958 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.5777 ns | 0.9140 ns | 0.0501 ns |  1.6010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.7371 ns | 0.5696 ns | 0.0312 ns |  1.7204 ns |  1.10 |    0.06 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.2681 ns | 0.3711 ns | 0.0203 ns |  2.2573 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  2.1316 ns | 0.4091 ns | 0.0224 ns |  2.1302 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.7454 ns | 0.1226 ns | 0.0067 ns |  1.7440 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.5375 ns | 0.7742 ns | 0.0424 ns |  1.5275 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.7100 ns | 0.3953 ns | 0.0217 ns |  4.7191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.4534 ns | 0.5047 ns | 0.0277 ns |  4.4609 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.8098 ns | 0.5379 ns | 0.0295 ns |  1.8153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.5428 ns | 0.6954 ns | 0.0381 ns |  1.5280 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.2965 ns | 0.9724 ns | 0.0533 ns |  2.2702 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.3754 ns | 0.8706 ns | 0.0477 ns |  2.3689 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.1178 ns | 0.4179 ns | 0.0229 ns |  6.1162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.3795 ns | 1.0148 ns | 0.0556 ns |  2.3827 ns |  0.39 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.0958 ns | 0.4683 ns | 0.0257 ns | 13.0863 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  8.1890 ns | 0.1199 ns | 0.0066 ns |  8.1906 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.2374 ns | 1.3981 ns | 0.0766 ns |  2.2281 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.1428 ns | 0.0144 ns | 0.0008 ns |  2.1427 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.1108 ns | 1.1781 ns | 0.0646 ns |  2.0795 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.6666 ns | 0.9177 ns | 0.0503 ns |  1.6402 ns |  0.79 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.4201 ns | 0.2454 ns | 0.0134 ns |  4.4146 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.7637 ns | 0.4890 ns | 0.0268 ns |  3.7487 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 |  3.2505 ns | 1.2232 ns | 0.0670 ns |  3.2150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.4771 ns | 0.6935 ns | 0.0380 ns |  3.4655 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.6230 ns | 0.8917 ns | 0.0489 ns |  8.6475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.8273 ns | 0.3819 ns | 0.0209 ns |  7.8202 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.2009 ns | 0.4215 ns | 0.0231 ns | 13.2038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 12.1978 ns | 4.2619 ns | 0.2336 ns | 12.0648 ns |  0.92 |    0.02 |      - |     - |     - |         - |
