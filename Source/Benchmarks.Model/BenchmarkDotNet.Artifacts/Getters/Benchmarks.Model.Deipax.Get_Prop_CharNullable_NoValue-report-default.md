
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.068 ns | 0.4301 ns | 0.0236 ns | 1.055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.181 ns | 0.1568 ns | 0.0086 ns | 1.178 ns |  1.11 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 3.990 ns | 0.3149 ns | 0.0173 ns | 3.991 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.782 ns | 0.1930 ns | 0.0106 ns | 3.778 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.293 ns | 0.1151 ns | 0.0063 ns | 1.296 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.569 ns | 0.7677 ns | 0.0421 ns | 1.549 ns |  1.21 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 1.172 ns | 0.2481 ns | 0.0136 ns | 1.170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 1.155 ns | 0.0123 ns | 0.0007 ns | 1.155 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.643 ns | 0.1234 ns | 0.0068 ns | 1.640 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.502 ns | 0.7024 ns | 0.0385 ns | 1.506 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 3.990 ns | 0.4179 ns | 0.0229 ns | 3.980 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.769 ns | 1.3652 ns | 0.0748 ns | 3.734 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.594 ns | 1.4472 ns | 0.0793 ns | 1.617 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.654 ns | 0.6099 ns | 0.0334 ns | 1.638 ns |  1.04 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.005 ns | 0.3801 ns | 0.0208 ns | 4.016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.743 ns | 0.3275 ns | 0.0179 ns | 3.748 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.722 ns | 0.0620 ns | 0.0034 ns | 1.724 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.589 ns | 0.6448 ns | 0.0353 ns | 1.571 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.014 ns | 0.1494 ns | 0.0082 ns | 4.017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.789 ns | 0.4866 ns | 0.0267 ns | 3.800 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.549 ns | 2.1374 ns | 0.1172 ns | 1.486 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.565 ns | 0.2742 ns | 0.0150 ns | 1.561 ns |  1.01 |    0.08 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 3.987 ns | 0.4232 ns | 0.0232 ns | 3.977 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.767 ns | 0.0490 ns | 0.0027 ns | 3.766 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.537 ns | 0.0479 ns | 0.0026 ns | 1.536 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.509 ns | 0.2679 ns | 0.0147 ns | 1.504 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 3.993 ns | 0.0976 ns | 0.0053 ns | 3.993 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.799 ns | 0.3630 ns | 0.0199 ns | 3.792 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.671 ns | 0.1397 ns | 0.0077 ns | 1.673 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.517 ns | 0.6057 ns | 0.0332 ns | 1.502 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 3.994 ns | 0.1152 ns | 0.0063 ns | 3.992 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.786 ns | 0.4746 ns | 0.0260 ns | 3.792 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.537 ns | 0.8294 ns | 0.0455 ns | 1.518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.735 ns | 0.9901 ns | 0.0543 ns | 1.734 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.105 ns | 0.1203 ns | 0.0066 ns | 2.106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.256 ns | 0.1231 ns | 0.0067 ns | 2.254 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.686 ns | 0.0403 ns | 0.0022 ns | 1.687 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.588 ns | 0.8000 ns | 0.0438 ns | 1.569 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 1.879 ns | 0.2318 ns | 0.0127 ns | 1.872 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 1.947 ns | 0.7532 ns | 0.0413 ns | 1.955 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.188 ns | 0.2319 ns | 0.0127 ns | 1.183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.445 ns | 0.4804 ns | 0.0263 ns | 1.432 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.227 ns | 0.1425 ns | 0.0078 ns | 4.228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.036 ns | 0.2466 ns | 0.0135 ns | 4.032 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.214 ns | 0.3539 ns | 0.0194 ns | 1.204 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.352 ns | 1.9721 ns | 0.1081 ns | 1.356 ns |  1.11 |    0.09 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 1.896 ns | 0.2665 ns | 0.0146 ns | 1.893 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 1.950 ns | 0.6889 ns | 0.0378 ns | 1.940 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.129 ns | 1.0141 ns | 0.0556 ns | 2.118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.054 ns | 0.3961 ns | 0.0217 ns | 2.045 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 1.643 ns | 0.0198 ns | 0.0011 ns | 1.643 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.041 ns | 0.1241 ns | 0.0068 ns | 2.040 ns |  1.24 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.355 ns | 0.1480 ns | 0.0081 ns | 2.357 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.419 ns | 0.5229 ns | 0.0287 ns | 2.433 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.775 ns | 0.3721 ns | 0.0204 ns | 2.777 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.732 ns | 0.1670 ns | 0.0092 ns | 1.731 ns |  0.62 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.476 ns | 0.1124 ns | 0.0062 ns | 1.479 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.718 ns | 0.1188 ns | 0.0065 ns | 1.715 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.520 ns | 0.5047 ns | 0.0277 ns | 1.504 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.629 ns | 0.7060 ns | 0.0387 ns | 1.641 ns |  1.07 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.701 ns | 0.9269 ns | 0.0508 ns | 1.695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.700 ns | 0.6740 ns | 0.0369 ns | 1.680 ns |  1.00 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 3.996 ns | 0.3304 ns | 0.0181 ns | 3.991 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.027 ns | 0.4656 ns | 0.0255 ns | 4.021 ns |  1.01 |    0.01 |     - |     - |     - |         - |
