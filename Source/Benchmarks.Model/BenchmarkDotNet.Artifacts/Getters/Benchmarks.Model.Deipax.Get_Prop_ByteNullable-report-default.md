
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.5611 ns | 0.8992 ns | 0.0493 ns |  1.5544 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.3436 ns | 0.6369 ns | 0.0349 ns |  1.3323 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.2427 ns | 0.2332 ns | 0.0128 ns |  4.2399 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.9871 ns | 0.3290 ns | 0.0180 ns |  3.9781 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.6740 ns | 1.0242 ns | 0.0561 ns |  1.6644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.3056 ns | 0.3090 ns | 0.0169 ns |  1.2964 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.2214 ns | 0.2535 ns | 0.0139 ns |  4.2149 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.2208 ns | 0.2387 ns | 0.0131 ns |  4.2190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.8078 ns | 1.1009 ns | 0.0603 ns |  1.7908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.8142 ns | 0.5309 ns | 0.0291 ns |  1.8127 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.4614 ns | 0.6915 ns | 0.0379 ns |  4.4808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  3.9911 ns | 0.2202 ns | 0.0121 ns |  3.9858 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.5953 ns | 0.4494 ns | 0.0246 ns |  1.5859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.1967 ns | 0.1521 ns | 0.0083 ns |  1.2009 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  1.2055 ns | 0.0572 ns | 0.0031 ns |  1.2051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  0.9138 ns | 0.3272 ns | 0.0179 ns |  0.9035 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.6656 ns | 0.0769 ns | 0.0042 ns |  1.6666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.3741 ns | 2.6922 ns | 0.1476 ns |  1.2924 ns |  0.83 |    0.09 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.2314 ns | 0.4000 ns | 0.0219 ns |  4.2266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.1776 ns | 0.6528 ns | 0.0358 ns |  4.1656 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.4881 ns | 0.4102 ns | 0.0225 ns |  1.4833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.3166 ns | 0.6014 ns | 0.0330 ns |  1.3010 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.2295 ns | 0.1116 ns | 0.0061 ns |  4.2274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.2187 ns | 0.1331 ns | 0.0073 ns |  4.2148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.6482 ns | 0.0849 ns | 0.0047 ns |  1.6463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.2908 ns | 0.2235 ns | 0.0122 ns |  1.2899 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.9909 ns | 0.4057 ns | 0.0222 ns |  3.9980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.0035 ns | 0.3089 ns | 0.0169 ns |  4.0046 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.5206 ns | 0.0586 ns | 0.0032 ns |  1.5198 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.3853 ns | 0.0575 ns | 0.0032 ns |  1.3837 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  3.9874 ns | 0.5995 ns | 0.0329 ns |  3.9978 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.2263 ns | 0.1712 ns | 0.0094 ns |  4.2247 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.5022 ns | 0.6357 ns | 0.0348 ns |  1.4836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.5663 ns | 0.3708 ns | 0.0203 ns |  1.5571 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.8925 ns | 0.8147 ns | 0.0447 ns |  1.8687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.0722 ns | 1.8905 ns | 0.1036 ns |  2.0988 ns |  1.09 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.4947 ns | 0.1096 ns | 0.0060 ns |  1.4979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.5794 ns | 0.4242 ns | 0.0233 ns |  1.5660 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.1111 ns | 0.0719 ns | 0.0039 ns |  2.1124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.9999 ns | 0.2075 ns | 0.0114 ns |  1.9968 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.5242 ns | 0.6669 ns | 0.0366 ns |  1.5044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.5374 ns | 0.1720 ns | 0.0094 ns |  1.5408 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.4608 ns | 0.0426 ns | 0.0023 ns |  4.4620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.2962 ns | 2.1881 ns | 0.1199 ns |  4.2380 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.4891 ns | 0.1141 ns | 0.0063 ns |  1.4855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.5587 ns | 0.2989 ns | 0.0164 ns |  1.5513 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.1885 ns | 0.8262 ns | 0.0453 ns |  2.1955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.0301 ns | 0.6951 ns | 0.0381 ns |  2.0152 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.0141 ns | 2.7235 ns | 0.1493 ns |  6.0901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.7592 ns | 0.1323 ns | 0.0073 ns |  1.7578 ns |  0.29 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.3411 ns | 0.8800 ns | 0.0482 ns | 13.3608 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  8.2456 ns | 0.9935 ns | 0.0545 ns |  8.2267 ns |  0.62 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.3233 ns | 0.1088 ns | 0.0060 ns |  2.3237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.1704 ns | 0.4066 ns | 0.0223 ns |  2.1618 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0150 ns | 0.0811 ns | 0.0044 ns |  2.0150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.7257 ns | 0.6248 ns | 0.0342 ns |  1.7318 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.4268 ns | 0.3159 ns | 0.0173 ns |  4.4209 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.9922 ns | 3.0564 ns | 0.1675 ns |  4.0081 ns |  0.90 |    0.04 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.1863 ns | 0.2226 ns | 0.0122 ns | 13.1829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.6743 ns | 0.2454 ns | 0.0134 ns |  3.6809 ns |  0.28 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.5411 ns | 0.4175 ns | 0.0229 ns |  8.5377 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.8781 ns | 0.6962 ns | 0.0382 ns |  7.8939 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.3523 ns | 1.2772 ns | 0.0700 ns | 13.3699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 12.0707 ns | 0.4377 ns | 0.0240 ns | 12.0603 ns |  0.90 |    0.01 |      - |     - |     - |         - |
