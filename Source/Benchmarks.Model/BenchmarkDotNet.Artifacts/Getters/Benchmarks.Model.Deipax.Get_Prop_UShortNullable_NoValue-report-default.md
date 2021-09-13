
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.514 ns | 0.1067 ns | 0.0058 ns | 1.514 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.508 ns | 1.0310 ns | 0.0565 ns | 1.480 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 3.992 ns | 0.0823 ns | 0.0045 ns | 3.991 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.770 ns | 0.3133 ns | 0.0172 ns | 3.778 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.670 ns | 0.5987 ns | 0.0328 ns | 1.671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.536 ns | 0.7954 ns | 0.0436 ns | 1.513 ns |  0.92 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.121 ns | 3.8817 ns | 0.2128 ns | 4.014 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.758 ns | 0.3552 ns | 0.0195 ns | 3.765 ns |  0.91 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.519 ns | 0.1190 ns | 0.0065 ns | 1.518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.567 ns | 0.4899 ns | 0.0269 ns | 1.568 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 3.993 ns | 0.2346 ns | 0.0129 ns | 3.987 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.787 ns | 0.4402 ns | 0.0241 ns | 3.787 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.324 ns | 0.0863 ns | 0.0047 ns | 1.327 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.528 ns | 0.4422 ns | 0.0242 ns | 1.517 ns |  1.15 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.007 ns | 0.4136 ns | 0.0227 ns | 4.003 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 4.223 ns | 0.5877 ns | 0.0322 ns | 4.234 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.702 ns | 0.5078 ns | 0.0278 ns | 1.686 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.515 ns | 0.6020 ns | 0.0330 ns | 1.498 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 3.978 ns | 0.2683 ns | 0.0147 ns | 3.986 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.797 ns | 0.7952 ns | 0.0436 ns | 3.773 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.499 ns | 0.1062 ns | 0.0058 ns | 1.495 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.525 ns | 0.0484 ns | 0.0027 ns | 1.525 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 1.161 ns | 0.0608 ns | 0.0033 ns | 1.161 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 1.171 ns | 0.2932 ns | 0.0161 ns | 1.169 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.502 ns | 0.4278 ns | 0.0234 ns | 1.495 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.618 ns | 0.1084 ns | 0.0059 ns | 1.619 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 3.981 ns | 0.4183 ns | 0.0229 ns | 3.991 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.753 ns | 0.5162 ns | 0.0283 ns | 3.759 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.615 ns | 0.7386 ns | 0.0405 ns | 1.603 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.599 ns | 0.6185 ns | 0.0339 ns | 1.616 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 3.996 ns | 0.1068 ns | 0.0059 ns | 3.995 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.771 ns | 0.2975 ns | 0.0163 ns | 3.769 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.578 ns | 0.8651 ns | 0.0474 ns | 1.585 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.505 ns | 0.4276 ns | 0.0234 ns | 1.496 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 1.880 ns | 0.1514 ns | 0.0083 ns | 1.884 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.184 ns | 0.0399 ns | 0.0022 ns | 2.184 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.473 ns | 0.0637 ns | 0.0035 ns | 1.471 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.493 ns | 0.4461 ns | 0.0245 ns | 1.482 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 1.924 ns | 0.6900 ns | 0.0378 ns | 1.905 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.234 ns | 0.1152 ns | 0.0063 ns | 2.232 ns |  1.16 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.549 ns | 1.5427 ns | 0.0846 ns | 1.577 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.511 ns | 0.7818 ns | 0.0429 ns | 1.515 ns |  0.98 |    0.08 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.385 ns | 2.8230 ns | 0.1547 ns | 4.366 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.002 ns | 0.1537 ns | 0.0084 ns | 3.998 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.493 ns | 0.4470 ns | 0.0245 ns | 1.488 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.505 ns | 0.2926 ns | 0.0160 ns | 1.498 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.151 ns | 0.7825 ns | 0.0429 ns | 2.129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.207 ns | 0.5006 ns | 0.0274 ns | 2.196 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.404 ns | 0.6167 ns | 0.0338 ns | 2.393 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.327 ns | 0.7208 ns | 0.0395 ns | 2.310 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.280 ns | 1.1994 ns | 0.0657 ns | 2.269 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.540 ns | 0.1560 ns | 0.0086 ns | 2.540 ns |  1.11 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.423 ns | 0.9039 ns | 0.0495 ns | 2.417 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.258 ns | 0.8713 ns | 0.0478 ns | 2.236 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.049 ns | 1.0570 ns | 0.0579 ns | 2.082 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.735 ns | 0.0527 ns | 0.0029 ns | 1.734 ns |  0.85 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.367 ns | 1.1522 ns | 0.0632 ns | 1.336 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.529 ns | 0.1996 ns | 0.0109 ns | 1.532 ns |  1.12 |    0.06 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.458 ns | 0.4710 ns | 0.0258 ns | 1.454 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.913 ns | 0.3419 ns | 0.0187 ns | 1.902 ns |  1.31 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.323 ns | 0.2668 ns | 0.0146 ns | 1.329 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.502 ns | 0.0441 ns | 0.0024 ns | 1.501 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.016 ns | 0.0656 ns | 0.0036 ns | 4.017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 3.987 ns | 0.2153 ns | 0.0118 ns | 3.984 ns |  0.99 |    0.00 |     - |     - |     - |         - |
