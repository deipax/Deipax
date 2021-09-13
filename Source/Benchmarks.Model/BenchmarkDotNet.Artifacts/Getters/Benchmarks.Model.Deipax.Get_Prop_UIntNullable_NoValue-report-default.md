
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.5032 ns | 0.2970 ns | 0.0163 ns | 1.5083 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.4103 ns | 0.0847 ns | 0.0046 ns | 1.4107 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 3.9168 ns | 0.3393 ns | 0.0186 ns | 3.9108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.8135 ns | 0.3068 ns | 0.0168 ns | 3.8129 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.3458 ns | 0.1698 ns | 0.0093 ns | 1.3495 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.5921 ns | 1.3244 ns | 0.0726 ns | 1.5864 ns |  1.18 |    0.05 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.2496 ns | 6.8914 ns | 0.3777 ns | 4.0379 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.7888 ns | 0.2225 ns | 0.0122 ns | 3.7891 ns |  0.90 |    0.08 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.3722 ns | 0.3165 ns | 0.0173 ns | 1.3758 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.2818 ns | 0.4158 ns | 0.0228 ns | 1.2741 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 4.0386 ns | 0.5851 ns | 0.0321 ns | 4.0478 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.7791 ns | 0.0698 ns | 0.0038 ns | 3.7779 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.4417 ns | 0.6312 ns | 0.0346 ns | 1.4244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.4851 ns | 1.2803 ns | 0.0702 ns | 1.4901 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.0720 ns | 3.1022 ns | 0.1700 ns | 4.0134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.7921 ns | 0.1743 ns | 0.0096 ns | 3.7922 ns |  0.93 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.6750 ns | 0.7740 ns | 0.0424 ns | 1.6808 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.3448 ns | 0.4161 ns | 0.0228 ns | 1.3355 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.0083 ns | 0.5058 ns | 0.0277 ns | 4.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.7914 ns | 0.2619 ns | 0.0144 ns | 3.7861 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.3457 ns | 0.4334 ns | 0.0238 ns | 1.3375 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.5188 ns | 0.0595 ns | 0.0033 ns | 1.5191 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.0148 ns | 0.0828 ns | 0.0045 ns | 4.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.7807 ns | 0.1003 ns | 0.0055 ns | 3.7780 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.4529 ns | 0.6437 ns | 0.0353 ns | 1.4647 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.4550 ns | 0.4457 ns | 0.0244 ns | 1.4526 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 3.9926 ns | 0.1088 ns | 0.0060 ns | 3.9926 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.7878 ns | 0.2095 ns | 0.0115 ns | 3.7873 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.5109 ns | 0.0443 ns | 0.0024 ns | 1.5113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.4383 ns | 0.5021 ns | 0.0275 ns | 1.4445 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 1.1637 ns | 0.0670 ns | 0.0037 ns | 1.1651 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 0.9289 ns | 0.0972 ns | 0.0053 ns | 0.9261 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.2899 ns | 0.4094 ns | 0.0224 ns | 1.2959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.2939 ns | 0.6759 ns | 0.0371 ns | 1.2757 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.2592 ns | 1.0818 ns | 0.0593 ns | 2.2816 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.1748 ns | 0.9030 ns | 0.0495 ns | 2.1974 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.3515 ns | 0.3863 ns | 0.0212 ns | 1.3420 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.3382 ns | 0.4443 ns | 0.0244 ns | 1.3282 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.2273 ns | 0.8492 ns | 0.0465 ns | 2.2173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 1.9798 ns | 0.6726 ns | 0.0369 ns | 1.9684 ns |  0.89 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.2986 ns | 0.1230 ns | 0.0067 ns | 1.3017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.3720 ns | 1.1827 ns | 0.0648 ns | 1.3412 ns |  1.06 |    0.05 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.2289 ns | 0.0232 ns | 0.0013 ns | 4.2293 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.0201 ns | 0.4332 ns | 0.0237 ns | 4.0079 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.2768 ns | 0.1953 ns | 0.0107 ns | 1.2736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.3439 ns | 0.0612 ns | 0.0034 ns | 1.3454 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.1404 ns | 0.4829 ns | 0.0265 ns | 2.1285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.0949 ns | 1.3538 ns | 0.0742 ns | 2.0639 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.4598 ns | 0.7398 ns | 0.0405 ns | 2.4440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.0441 ns | 1.3984 ns | 0.0766 ns | 2.0404 ns |  0.83 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.4316 ns | 0.9579 ns | 0.0525 ns | 2.4128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.2592 ns | 0.6956 ns | 0.0381 ns | 2.2376 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.1900 ns | 0.1083 ns | 0.0059 ns | 2.1932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.1586 ns | 0.8351 ns | 0.0458 ns | 2.1333 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.1735 ns | 0.3883 ns | 0.0213 ns | 2.1823 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.7421 ns | 0.5095 ns | 0.0279 ns | 1.7276 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.4523 ns | 0.9751 ns | 0.0534 ns | 1.4253 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.4087 ns | 0.1614 ns | 0.0088 ns | 1.4043 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.4066 ns | 0.7443 ns | 0.0408 ns | 1.4019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.4253 ns | 0.0633 ns | 0.0035 ns | 1.4268 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.3456 ns | 0.5300 ns | 0.0291 ns | 1.3351 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.3251 ns | 0.1776 ns | 0.0097 ns | 1.3228 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.0048 ns | 0.1462 ns | 0.0080 ns | 4.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 3.9891 ns | 0.3455 ns | 0.0189 ns | 3.9965 ns |  1.00 |    0.01 |     - |     - |     - |         - |
