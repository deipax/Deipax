
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |      Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|-----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.365 ns |  3.6918 ns | 0.2024 ns | 1.295 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.219 ns |  0.4858 ns | 0.0266 ns | 1.208 ns |  0.90 |    0.11 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.774 ns |  2.5352 ns | 0.1390 ns | 4.711 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.824 ns |  0.2539 ns | 0.0139 ns | 3.822 ns |  0.80 |    0.02 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.146 ns |  0.3670 ns | 0.0201 ns | 1.140 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.219 ns |  0.2806 ns | 0.0154 ns | 1.211 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.712 ns |  0.1871 ns | 0.0103 ns | 4.712 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.806 ns |  0.5315 ns | 0.0291 ns | 3.820 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.245 ns |  0.1553 ns | 0.0085 ns | 1.247 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.206 ns |  0.3554 ns | 0.0195 ns | 1.200 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 4.722 ns |  0.2798 ns | 0.0153 ns | 4.727 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.828 ns |  0.0307 ns | 0.0017 ns | 3.828 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.401 ns |  0.8490 ns | 0.0465 ns | 1.386 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.218 ns |  0.2126 ns | 0.0117 ns | 1.218 ns |  0.87 |    0.03 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.721 ns |  0.4789 ns | 0.0262 ns | 4.718 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.804 ns |  0.5340 ns | 0.0293 ns | 3.795 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.539 ns | 13.1785 ns | 0.7224 ns | 1.125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.196 ns |  0.1421 ns | 0.0078 ns | 1.192 ns |  0.88 |    0.32 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.711 ns |  0.4722 ns | 0.0259 ns | 4.718 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.775 ns |  0.5489 ns | 0.0301 ns | 3.759 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.205 ns |  0.8867 ns | 0.0486 ns | 1.192 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.221 ns |  0.3487 ns | 0.0191 ns | 1.230 ns |  1.02 |    0.05 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.735 ns |  0.0660 ns | 0.0036 ns | 4.735 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.815 ns |  0.1366 ns | 0.0075 ns | 3.817 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.243 ns |  0.1103 ns | 0.0060 ns | 1.244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.191 ns |  0.1163 ns | 0.0064 ns | 1.188 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.675 ns |  1.0859 ns | 0.0595 ns | 4.708 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.818 ns |  0.2735 ns | 0.0150 ns | 3.824 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.270 ns |  0.5469 ns | 0.0300 ns | 1.280 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.202 ns |  0.0182 ns | 0.0010 ns | 1.202 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 5.011 ns |  5.4921 ns | 0.3010 ns | 5.045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.814 ns |  0.0310 ns | 0.0017 ns | 3.815 ns |  0.76 |    0.05 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.323 ns |  0.4419 ns | 0.0242 ns | 1.313 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.200 ns |  0.1542 ns | 0.0085 ns | 1.196 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 1.757 ns |  0.3694 ns | 0.0202 ns | 1.749 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 1.718 ns |  0.1255 ns | 0.0069 ns | 1.721 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.199 ns |  1.0583 ns | 0.0580 ns | 1.210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.191 ns |  0.0641 ns | 0.0035 ns | 1.190 ns |  1.00 |    0.05 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 1.743 ns |  0.1740 ns | 0.0095 ns | 1.739 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 1.744 ns |  0.6995 ns | 0.0383 ns | 1.725 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.119 ns |  0.4894 ns | 0.0268 ns | 1.112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.447 ns |  0.2413 ns | 0.0132 ns | 1.454 ns |  1.29 |    0.03 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.728 ns |  0.2993 ns | 0.0164 ns | 4.727 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 3.791 ns |  0.1995 ns | 0.0109 ns | 3.793 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.111 ns |  0.3672 ns | 0.0201 ns | 1.101 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.272 ns |  1.3823 ns | 0.0758 ns | 1.254 ns |  1.15 |    0.09 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 1.757 ns |  0.0332 ns | 0.0018 ns | 1.757 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 1.809 ns |  0.1333 ns | 0.0073 ns | 1.806 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.851 ns |  0.7842 ns | 0.0430 ns | 2.859 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.878 ns |  2.4357 ns | 0.1335 ns | 2.804 ns |  1.01 |    0.04 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 1.852 ns |  0.1588 ns | 0.0087 ns | 1.850 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 1.729 ns |  0.0940 ns | 0.0052 ns | 1.729 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.611 ns |  0.1362 ns | 0.0075 ns | 2.611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.636 ns |  1.4677 ns | 0.0804 ns | 2.624 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 1.957 ns |  1.4998 ns | 0.0822 ns | 1.913 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.921 ns |  0.4499 ns | 0.0247 ns | 1.916 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.506 ns |  0.8531 ns | 0.0468 ns | 1.505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.724 ns |  0.0998 ns | 0.0055 ns | 1.722 ns |  1.15 |    0.04 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.621 ns |  0.8087 ns | 0.0443 ns | 1.615 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.784 ns |  0.5258 ns | 0.0288 ns | 1.778 ns |  1.10 |    0.02 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.559 ns |  0.5213 ns | 0.0286 ns | 1.546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.850 ns |  1.9242 ns | 0.1055 ns | 1.815 ns |  1.19 |    0.05 |     - |     - |     - |         - |
                    |               |          |            |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.732 ns |  2.3674 ns | 0.1298 ns | 4.806 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.222 ns |  0.4111 ns | 0.0225 ns | 4.226 ns |  0.89 |    0.03 |     - |     - |     - |         - |
