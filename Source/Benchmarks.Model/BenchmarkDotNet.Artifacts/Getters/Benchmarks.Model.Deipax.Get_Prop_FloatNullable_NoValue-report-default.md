
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.5265 ns |  0.2106 ns | 0.0115 ns | 1.5286 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.3306 ns |  0.0349 ns | 0.0019 ns | 1.3301 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.2146 ns |  0.3199 ns | 0.0175 ns | 4.2235 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 4.0308 ns |  0.1255 ns | 0.0069 ns | 4.0329 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.1438 ns |  0.3463 ns | 0.0190 ns | 1.1509 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.0866 ns |  0.4479 ns | 0.0246 ns | 1.0786 ns |  0.95 |    0.03 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.2708 ns |  1.7183 ns | 0.0942 ns | 4.2601 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.7301 ns |  0.2113 ns | 0.0116 ns | 3.7301 ns |  0.87 |    0.02 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.6236 ns |  2.0570 ns | 0.1128 ns | 1.5695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.4122 ns |  0.1250 ns | 0.0069 ns | 1.4155 ns |  0.87 |    0.06 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 4.2437 ns |  0.3099 ns | 0.0170 ns | 4.2519 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.9808 ns |  0.6442 ns | 0.0353 ns | 3.9959 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.9487 ns |  8.6264 ns | 0.4728 ns | 1.7671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.3359 ns |  0.1355 ns | 0.0074 ns | 1.3341 ns |  0.71 |    0.16 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.2576 ns |  0.3739 ns | 0.0205 ns | 4.2601 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.9806 ns |  0.2916 ns | 0.0160 ns | 3.9812 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.5344 ns |  0.3335 ns | 0.0183 ns | 1.5318 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.3809 ns |  0.2689 ns | 0.0147 ns | 1.3864 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.1580 ns |  0.2177 ns | 0.0119 ns | 4.1556 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.9759 ns |  0.2150 ns | 0.0118 ns | 3.9737 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.4344 ns |  0.7852 ns | 0.0430 ns | 1.4272 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.4953 ns |  0.1549 ns | 0.0085 ns | 1.4944 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.0878 ns |  0.1357 ns | 0.0074 ns | 4.0851 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 4.0422 ns |  0.5480 ns | 0.0300 ns | 4.0335 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.7464 ns |  0.1300 ns | 0.0071 ns | 1.7503 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.3083 ns |  0.1450 ns | 0.0079 ns | 1.3060 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.1996 ns |  0.3157 ns | 0.0173 ns | 4.2076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.8033 ns |  0.0396 ns | 0.0022 ns | 3.8041 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.4332 ns |  0.3044 ns | 0.0167 ns | 1.4265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 3.2360 ns | 14.4148 ns | 0.7901 ns | 3.0404 ns |  2.26 |    0.57 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.3209 ns |  1.1463 ns | 0.0628 ns | 4.3143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 4.4659 ns |  0.1539 ns | 0.0084 ns | 4.4677 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.7448 ns |  1.3270 ns | 0.0727 ns | 1.7112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.6146 ns |  0.2603 ns | 0.0143 ns | 1.6129 ns |  0.93 |    0.04 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.2020 ns |  5.2514 ns | 0.2878 ns | 2.0528 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.0846 ns |  0.4788 ns | 0.0262 ns | 2.0773 ns |  0.96 |    0.12 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.6434 ns |  0.2244 ns | 0.0123 ns | 1.6479 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.4088 ns |  0.3212 ns | 0.0176 ns | 1.3987 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.0776 ns |  0.4163 ns | 0.0228 ns | 2.0706 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.2659 ns |  0.2057 ns | 0.0113 ns | 2.2614 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.4594 ns |  0.1170 ns | 0.0064 ns | 1.4584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.4895 ns |  0.3061 ns | 0.0168 ns | 1.4976 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 1.0356 ns |  0.1094 ns | 0.0060 ns | 1.0382 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 0.9392 ns |  0.5656 ns | 0.0310 ns | 0.9271 ns |  0.91 |    0.04 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.6574 ns |  2.3722 ns | 0.1300 ns | 1.5899 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.4286 ns |  0.6763 ns | 0.0371 ns | 1.4480 ns |  0.86 |    0.06 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 1.9385 ns |  0.4406 ns | 0.0241 ns | 1.9273 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.1589 ns |  3.4260 ns | 0.1878 ns | 2.2333 ns |  1.11 |    0.11 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.2754 ns |  0.7337 ns | 0.0402 ns | 2.2653 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.5273 ns |  0.1896 ns | 0.0104 ns | 2.5229 ns |  1.11 |    0.02 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.4903 ns |  0.1228 ns | 0.0067 ns | 2.4874 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.6235 ns |  0.7234 ns | 0.0396 ns | 2.6064 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.2328 ns |  0.1604 ns | 0.0088 ns | 2.2303 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.2022 ns |  0.3750 ns | 0.0206 ns | 2.1997 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.1743 ns |  0.3643 ns | 0.0200 ns | 2.1852 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.6583 ns |  0.6735 ns | 0.0369 ns | 1.6423 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.7427 ns |  0.0614 ns | 0.0034 ns | 1.7433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.5008 ns |  0.2836 ns | 0.0155 ns | 1.4951 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.5646 ns |  0.5076 ns | 0.0278 ns | 1.5641 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.5205 ns |  3.5448 ns | 0.1943 ns | 1.5448 ns |  0.97 |    0.13 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.7123 ns |  0.5272 ns | 0.0289 ns | 1.7020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.4420 ns |  0.3629 ns | 0.0199 ns | 1.4329 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                    |               |           |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.2207 ns |  1.0149 ns | 0.0556 ns | 4.2198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 3.9817 ns |  0.1873 ns | 0.0103 ns | 3.9762 ns |  0.94 |    0.01 |     - |     - |     - |         - |
